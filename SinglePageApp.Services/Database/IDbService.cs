using SinglePageApp.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace SinglePageApp.Services.Database
{
    public interface IDbService
    {
        public UserInfo GetUserByLogin(string username);
    }
}
