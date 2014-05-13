using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autofac;
using SqlRelated.Core;

namespace UnitTests
{
    public class SharedContext : Context
    {
        private IContainer _container;

        protected IContainer Container
        {
            get
            {
                if(_container == null)
                    _container = DependencyResolver.Register();

                return _container;
            }
        }

    }
}
