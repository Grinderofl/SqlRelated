using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Management.Instrumentation;
using System.Text;
using System.Threading.Tasks;
using Autofac;
using Moq;
using NUnit.Framework;
using SqlRelated.Core.Connection;
using SqlRelated.Core.Connection.Impl;
using SqlRelated.Core.Domain;
using SqlRelated.Core.Domain.Enums;

namespace UnitTests.Connection
{
    public class ConnectionResolverFacilitySpec
    {
        public class ConnectionResolverFacilityContext : SharedContext
        {
            protected Mock<IConnectionResolver> ConnectionResolverMock;

            protected ICollection<IConnectionResolver> ConnectionResolvers;
            protected IConnectionResolverFacility ConnectionResolverFacility;

            protected IDbConnection DbConnection;

            protected User User;
            
            protected override void SetupShared()
            {
                ConnectionResolvers = new List<IConnectionResolver>();
                ConnectionResolverMock = new Mock<IConnectionResolver>();
            }
        }

        public class WhenResolvingConnectionWithWindowsAuthentication : ConnectionResolverFacilityContext
        {
            private IDbConnection _expectedConnection;

            protected override void Setup()
            {
                _expectedConnection = new SqlConnection();
                User = new User()
                {
                    AuthenticationMode = AuthenticationMode.Windows
                };
                ConnectionResolverMock.SetupGet(x => x.AuthenticationMode).Returns(AuthenticationMode.Windows);
                ConnectionResolverMock.Setup(x => x.Resolve(It.IsAny<User>()))
                    .Returns(_expectedConnection);
                ConnectionResolvers.Add(ConnectionResolverMock.Object);
                ConnectionResolverFacility = new ConnectionResolverFacility(ConnectionResolvers);
            }

            protected override void Because()
            {
                DbConnection = ConnectionResolverFacility.Resolve(User);
            }

            [Test]
            public void should_return_correct_resolver()
            {
                Assert.That(DbConnection, Is.SameAs(_expectedConnection));
            }
        }

        public class WhenResolvingConnectionThatDoesNotExist : ConnectionResolverFacilityContext
        {
            protected override void Setup()
            {
                User = new User()
                {
                    AuthenticationMode = AuthenticationMode.Windows
                };

                ConnectionResolverMock.SetupGet(x => x.AuthenticationMode).Returns(AuthenticationMode.SqlServer);
                ConnectionResolvers.Add(ConnectionResolverMock.Object);
                ConnectionResolverFacility = new ConnectionResolverFacility(ConnectionResolvers);
            }

            [Test]
            public void should_throw()
            {
                Assert.Throws<InstanceNotFoundException>(() => ConnectionResolverFacility.Resolve(User));
            }
        }
    }
}
