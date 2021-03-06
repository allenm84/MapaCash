﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Finances
{
  public abstract class BaseNotifyPropertyChanged : INotifyPropertyChanged
  {
    public event PropertyChangedEventHandler PropertyChanged;

    protected void FirePropertyChanged([CallerMemberName] string name = "")
    {
      OnPropertyChanged(new PropertyChangedEventArgs(name));
    }

    protected virtual void OnPropertyChanged(PropertyChangedEventArgs e)
    {
      PropertyChanged?.Invoke(this, e);
    }
  }
}
