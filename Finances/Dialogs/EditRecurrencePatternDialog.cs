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

namespace Finances
{
  public partial class EditRecurrencePatternDialog : BaseForm
  {
    const string AppointmentBackColor = "BackColor";
    const string AppointmentForeColor = "ForeColor";

    public EditRecurrencePatternDialog()
    {
      InitializeComponent();
      schedulerStorage1.Appointments.CustomFieldMappings.Add(new AppointmentCustomFieldMapping(AppointmentBackColor, AppointmentBackColor, FieldValueType.Integer));
      schedulerStorage1.Appointments.CustomFieldMappings.Add(new AppointmentCustomFieldMapping(AppointmentForeColor, AppointmentForeColor, FieldValueType.Integer));
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

    private void UpdateSchedulerControl()
    {
      schedulerControl1.Start = ctrlFrequency.StartDate;

      schedulerStorage1.BeginUpdate();
      schedulerStorage1.Appointments.Clear();

      var apt = schedulerStorage1.CreateAppointment(AppointmentType.Pattern);
      apt.AllDay = true;
      apt.Description = "";
      apt.Start = ctrlFrequency.StartDate;
      apt.Subject = "";
      apt.CustomFields[AppointmentBackColor] = Color.SlateBlue.ToArgb();
      apt.CustomFields[AppointmentForeColor] = Color.White.ToArgb();
      apt.RecurrenceInfo.Start = apt.Start;
      apt.RecurrenceInfo.WeekOfMonth = WeekOfMonth.None;

      switch (recurringEndTypeControl1.EndType)
      {
        case RecurringEndType.ByCount:
          apt.RecurrenceInfo.Range = RecurrenceRange.OccurrenceCount;
          apt.RecurrenceInfo.OccurrenceCount = recurringEndTypeControl1.MaxOccurrences;
          break;
        case RecurringEndType.ByDate:
          apt.RecurrenceInfo.Range = RecurrenceRange.EndByDate;
          apt.RecurrenceInfo.End = recurringEndTypeControl1.UntilDate;
          break;
        case RecurringEndType.Never:
          apt.RecurrenceInfo.Range = RecurrenceRange.NoEndDate;
          break;
      }
      
      switch (ctrlFrequency.Frequency)
      {
        case RecurringType.Daily:
          apt.RecurrenceInfo.Periodicity = recurringPeriodControl1.Period;
          apt.RecurrenceInfo.Type = RecurrenceType.Daily;
          break;
        case RecurringType.Monthly:
          apt.RecurrenceInfo.Periodicity = recurringPeriodControl1.Period;
          apt.RecurrenceInfo.Type = RecurrenceType.Monthly;
          apt.RecurrenceInfo.DayNumber = (int)recurringDayOfMonthControl1.DayOfMonth1;
          break;
        case RecurringType.Once:
          apt.RecurrenceInfo.Periodicity = 1;
          apt.RecurrenceInfo.Type = RecurrenceType.Daily;
          apt.RecurrenceInfo.Range = RecurrenceRange.OccurrenceCount;
          apt.RecurrenceInfo.OccurrenceCount = 1;
          break;
        case RecurringType.SemiMonthly:
          break;
        case RecurringType.Weekly:
          var days = recurringWeekDaysControl1.Days;
          if (days == RecurringDayOfWeek.None)
            days = RecurringDayOfWeek.All;

          apt.RecurrenceInfo.Periodicity = recurringPeriodControl1.Period;
          apt.RecurrenceInfo.Type = RecurrenceType.Weekly;
          apt.RecurrenceInfo.WeekDays = days.ToWeekDays();
          break;
      }

      schedulerStorage1.Appointments.Add(apt);
      schedulerStorage1.EndUpdate();
    }

    protected override void OnLoad(EventArgs e)
    {
      base.OnLoad(e);
      ctrlFrequency.Frequency = RecurringType.Once;
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
      UpdateSchedulerControl();
    }

    private void recurrencePattern_Changed(object sender, EventArgs e)
    {
      UpdateSchedulerControl();
    }

    private void ctrlSchedule_PopupMenuShowing(object sender, DevExpress.XtraScheduler.PopupMenuShowingEventArgs e)
    {
      e.Menu.Items.Clear();
    }

    private void ctrlSchedule_AppointmentViewInfoCustomizing(object sender, AppointmentViewInfoCustomizingEventArgs e)
    {
      var fields = e.ViewInfo.Appointment.CustomFields;

      if (fields[AppointmentBackColor] is int backColor)
      {
        e.ViewInfo.Appearance.BackColor = Color.FromArgb(backColor);
      }

      if (fields[AppointmentForeColor] is int foreColor)
      {
        e.ViewInfo.Appearance.ForeColor = Color.FromArgb(foreColor);
      }
    }
  }
}
