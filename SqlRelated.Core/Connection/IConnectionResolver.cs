using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SqlRelated.Core.Domain;
using SqlRelated.Core.Domain.Enums;

namespace SqlRelated.Core.Connection
{
    public interface IConnectionResolver
    {
        IDbConnection Resolve(User user);
        AuthenticationMode AuthenticationMode { get; }
    }
}
