using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraScheduler;

namespace Finances
{
  public static class Extensions
  {
    public static void AddRange<T>(this IList<T> list, IEnumerable<T> items)
    {
      foreach (var item in items)
      {
        list.Add(item);
      }
    }

    public static bool Confirm(this IWin32Window window, string message, string caption = "Confirm")
    {
      var result = XtraMessageBox.Show(window, message, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
      return (result == DialogResult.Yes);
    }

    public static DateTime FirstOfMonth(this DateTime date)
    {
      return new DateTime(date.Year, date.Month, 1);
    }

    public static DateTime EndOfMonth(this DateTime date)
    {
      var days = DateTime.DaysInMonth(date.Year, date.Month);
      return new DateTime(date.Year, date.Month, days);
    }

    public static object[] AsArray<T>(this IEnumerable<T> items)
    {
      return items.Cast<object>().ToArray();
    }
  }
}
