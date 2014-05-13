using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SqlRelated.Core.Domain.Enums;

namespace SqlRelated.Core.Domain
{
    public class User
    {
        public string Server { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public AuthenticationMode AuthenticationMode { get; set; }
    }
}
