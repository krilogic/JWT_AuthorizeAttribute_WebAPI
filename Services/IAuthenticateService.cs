using JWT_AuthorizeAttribute.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JWT_AuthorizeAttribute.Services
{
    public interface IAuthenticateService
    {
        User Authenticate(string userName, string password);
    }
}
