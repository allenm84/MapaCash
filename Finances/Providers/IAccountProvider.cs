﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Finances
{
  public interface IAccountProvider
  {
    IList<AccountNode> Accounts { get; }
    AccountNode AddNewAccount();
  }
}
