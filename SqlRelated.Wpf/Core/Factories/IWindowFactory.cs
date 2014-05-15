using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SqlRelated.Wpf.Core.Factories
{
    public interface IWindowFactory
    {
        T Resolve<T>();
    }
}
