using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SqlRelated.Core.Domain;
using SqlRelated.Core.Domain.Enums;

namespace SqlRelated.Core.Connection.Impl
{
    public class SqlServerAuthenticationConnectionResolver : IConnectionResolver
    {
        public IDbConnection Resolve(User user)
        {
            throw new NotImplementedException();
        }

        public AuthenticationMode AuthenticationMode { get { return AuthenticationMode.SqlServer;} }
    }
}
