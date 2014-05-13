using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Management.Instrumentation;
using System.Text;
using System.Threading.Tasks;
using SqlRelated.Core.Domain;

namespace SqlRelated.Core.Connection.Impl
{
    public class ConnectionResolverFacility : IConnectionResolverFacility
    {
        private readonly IEnumerable<IConnectionResolver> _connectionResolvers;
        public ConnectionResolverFacility(IEnumerable<IConnectionResolver> connectionResolvers)
        {
            _connectionResolvers = connectionResolvers;
        }

        public IDbConnection Resolve(User user)
        {
            foreach (
                var resolver in
                    _connectionResolvers.Where(resolver => resolver.AuthenticationMode == user.AuthenticationMode))
                return resolver.Resolve(user);
            
            throw new InstanceNotFoundException(string.Format("No ConnectionResolver for AuthenticatonMode {0} found.",
                user.AuthenticationMode));
        }
    }
}
