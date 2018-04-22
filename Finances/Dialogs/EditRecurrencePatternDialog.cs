using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraLayout;
using DevExpress.XtraScheduler;
using DevExpress.XtraScheduler.Drawing;

namespace Finances
{
  public partial class EditRecurrencePatternDialog : BaseForm
  {
    static readonly Color BackgroundColor = ColorTranslator.FromHtml("#4A90D9");

    private RecurringTransaction _model = new RecurringTransaction();
    private HashSet<DateTime> _visibleDates = new HashSet<DateTime>();
    private bool _modelInitialized = false;

    public EditRecurrencePatternDialog()
    {
      InitializeComponent();
      _model.Type = RecurringType.Once;
    }

    public RecurringTransaction Model => _model;

    public void InitFrom(RecurringTransaction data)
    {
      _model.OverwriteWith(data);
      _modelInitialized = true;
      UpdateSchedulerControl();
    }

    private void SetLayoutVisible(BaseLayoutItem item, bool visible, int rowHeight)
    {
      item.Visibility = visible
        ? DevExpress.XtraLayout.Utils.LayoutVisibility.Always
        : DevExpress.XtraLayout.Utils.LayoutVisibility.Never;

      var r = item.OptionsTableLayoutItem.RowIndex;
      var row = layoutControlGroup3.OptionsTableLayoutGroup.GetRow(r);
      row.Height = visible ? rowHeight : 1;
    }

    private void PushToModel()
    {
      // set the variable for initialization
      _modelInitialized = true;

      // update the model underneath
      var day1 = (int)recurringDayOfMonthControl1.DayOfMonth1;
      var day2 = (int)recurringDayOfMonthControl1.DayOfMonth2;
      if (day1 > day2)
      {
        var temp = day1;
        day1 = day2;
        day2 = temp;
      }

      _model.DayOfMonth = (RecurringDayOfMonth)day1;
      _model.DayOfMonth2 = (RecurringDayOfMonth)day2;
      _model.Days = recurringWeekDaysControl1.Days;
      _model.EndDate = recurringEndTypeControl1.UntilDate;
      _model.EndType = recurringEndTypeControl1.EndType;
      _model.MaxOccurrences = recurringEndTypeControl1.MaxOccurrences;
      _model.Period = recurringPeriodControl1.Period;
      _model.StartDate = ctrlFrequency.StartDate.Date;

      var type = ctrlFrequency.Frequency;
      if (type == RecurringType.SemiMonthly && (day1 == day2))
      {
        type = RecurringType.Monthly;
      }
      _model.Type = type;
      UpdateSchedulerControl();
    }

    private void UpdateSchedulerControl()
    {
      // set the schedule date
      schedulerControl1.Start = _model.StartDate;
      schedulerControl1.LimitInterval.Start = _model.StartDate;
      schedulerControl1.LimitInterval.End = _model.StartDate.AddYears(100);
    }

    protected override void OnLoad(EventArgs e)
    {
      base.OnLoad(e);
      ctrlFrequency.Frequency = _model.Type;
    }

    private void ctrlFrequency_FrequencyChanged(object sender, EventArgs e)
    {
      var frequency = ctrlFrequency.Frequency;

      // adjust visibility of the period editor
      SetLayoutVisible(layoutControlItem4, frequency != RecurringType.Once, 30);

      // adjust visibility of the days
      SetLayoutVisible(layoutControlItem5, frequency == RecurringType.Weekly, 73);

      // adjust visibility of the day of month editor
      SetLayoutVisible(layoutControlItem6, frequency == RecurringType.Monthly || frequency == RecurringType.SemiMonthly, 30);

      // set the properties of the controls
      switch (frequency)
      {
        case RecurringType.Daily:
          recurringPeriodControl1.Units = "days";
          break;
        case RecurringType.SemiMonthly:
        case RecurringType.Monthly:
          recurringDayOfMonthControl1.IsSemiMonthly = (frequency == RecurringType.SemiMonthly);
          recurringPeriodControl1.Units = "months";
          break;
        case RecurringType.Weekly:
          recurringPeriodControl1.Units = "weeks";
          break;
      }

      layoutControlGroup3.Update();
      PushToModel();
    }

    private void recurrencePattern_Changed(object sender, EventArgs e)
    {
      PushToModel();
    }

    private void ctrlSchedule_PopupMenuShowing(object sender, DevExpress.XtraScheduler.PopupMenuShowingEventArgs e)
    {
      e.Menu.Items.Clear();
    }

    private void schedulerControl1_VisibleIntervalChanged(object sender, EventArgs e)
    {
      if (!_modelInitialized)
        return;

      _visibleDates.Clear();

      var date = _model.GetNextDate(out bool isValid);
      if (_model.Type == RecurringType.Once)
      {
        _visibleDates.Add(date.Date);
      }
      else if (isValid)
      {
        foreach (var d in _model.GenerateDates(date, schedulerControl1.LimitInterval.End))
        {
          _visibleDates.Add(d);
        }
      }

      schedulerControl1.MonthView.Invalidate();
    }

    private void schedulerControl1_CustomDrawDayHeader(object sender, CustomDrawObjectEventArgs e)
    {
      if (e.ObjectInfo is MonthViewTimeCellHeader header)
      {
        header.Selected = false;
        if (_visibleDates.Contains(header.Interval.Start.Date))
        {
          var backBrush = e.Cache.GetSolidBrush(BackgroundColor);
          e.Graphics.FillRectangle(backBrush, e.Bounds);

          var appearance = header.CaptionAppearance;
          var bounds = header.ContentBounds;
          var textBrush = appearance.GetForeBrush(e.Cache);
          e.Graphics.DrawString(header.Caption, appearance.Font, textBrush, bounds, appearance.GetStringFormat());
          e.Handled = true;
        }
      }
    }

    private void schedulerControl1_CustomDrawTimeCell(object sender, CustomDrawObjectEventArgs e)
    {
      if (e.ObjectInfo is TimeCell cell)
      {
        cell.Selected = false;
      }
    }
  }
}
