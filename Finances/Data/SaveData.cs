using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Finances
{
  public class SaveData
  {
    public AccountNode[] Accounts { get; set; }
    public RecurringTransaction[] Transactions { get; set; }
  }
}
