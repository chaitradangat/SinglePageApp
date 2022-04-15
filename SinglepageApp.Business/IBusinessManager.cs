using SinglePageApp.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace SinglepageApp.Business
{
    public interface IBusinessManager
    {
        public UserInfo GetUserByLogin(string username);

        public bool Validate(string username, string password);
    }
}
