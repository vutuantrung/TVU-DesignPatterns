using System;
using System.Collections.Generic;
using System.Text;

namespace Memento.Demo.Memento
{
    public interface IMemento
    {
        string GetName();

        string GetState();

        DateTime GetDate();
    }
}
