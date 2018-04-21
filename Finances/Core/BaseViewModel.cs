using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Finances
{
  public abstract class BaseViewModel : BaseNotifyPropertyChanged
  {
    private readonly Dictionary<string, object> _fields = new Dictionary<string, object>();

    protected T GetField<T>([CallerMemberName] string name = "")
    {
      if (_fields.TryGetValue(name, out object obj) && obj is T value)
      {
        return value;
      }

      return default(T);
    }

    protected void SetField<T>(T desiredValue, bool force = true, [CallerMemberName] string name = "")
    {
      if (force || DidChange())
      {
        _fields[name] = desiredValue;
        FirePropertyChanged(name);
      }

      bool DidChange()
      {
        if (!_fields.TryGetValue(name, out object obj))
        {
          // there is no value
          return true;
        }

        if (!(obj is T currentValue))
        {
          // the current value is the wrong type
          return true;
        }

        var eq = EqualityComparer<T>.Default;
        return !eq.Equals(desiredValue, currentValue);
      }
    }
  }
}
