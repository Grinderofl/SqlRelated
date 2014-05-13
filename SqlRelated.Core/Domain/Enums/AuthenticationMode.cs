using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SqlRelated.Core.Domain.Enums
{
    public enum AuthenticationMode
    {
        [Description("Windows Authentication")]
        Windows,

        [Description("SQL Server Authentication")]
        SqlServer
    }
}
