using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JWT_AuthorizeAttribute.Models
{
    public class User
    {
        public int UserId { get; set; }
        public string FName { get; set; }
        public string LName { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Token { get; set; }

    }
}
