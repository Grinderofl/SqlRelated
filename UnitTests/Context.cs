using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace UnitTests
{
    public class Context
    {
        [SetUp]
        protected void SetupCore()
        {
            SetupShared();
            Setup();
            Because();
            After();
        }

        protected virtual void SetupShared()
        {
        }

        protected virtual void Setup()
        {
        }

        protected virtual void Because()
        {
        }

        protected virtual void After()
        {
        }
    }
}
