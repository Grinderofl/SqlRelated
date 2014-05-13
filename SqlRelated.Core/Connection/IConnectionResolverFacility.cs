using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SqlRelated.Core.Domain;

namespace SqlRelated.Core.Connection
{
    public interface IConnectionResolverFacility
    {
        IDbConnection Resolve(User user);
    }
}
