using System;
using System.Collections.Generic;
using System.Text;

namespace SinglePageApp.Services.Database
{
    public interface IDbService
    {
        public void GetUserByLogin(string username);
    }
}
