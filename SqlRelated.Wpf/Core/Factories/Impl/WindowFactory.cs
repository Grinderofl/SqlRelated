using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autofac;

namespace SqlRelated.Wpf.Core.Factories.Impl
{
    public class WindowFactory : IWindowFactory
    {
        private IComponentContext _context;

        public WindowFactory(IComponentContext context)
        {
            _context = context;
        }

        public T Resolve<T>()
        {
            return _context.Resolve<T>();
        }
    }
}
