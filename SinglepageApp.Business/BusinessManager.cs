using SinglePageApp.Domain;
using SinglePageApp.Services.Database;
using SinglePageApp.Services.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace SinglepageApp.Business
{
    public class BusinessManager : IBusinessManager
    {
        private readonly IDbService _dbService;

        private readonly ICommonService _commonService;

        public BusinessManager(IDbService dbService,ICommonService commonService)
        {
            _dbService = dbService;

            _commonService = commonService;
        }

        public UserInfo GetUserByLogin(string username)
        {
            return _dbService.GetUserByLogin(username);
        }

        public bool Validate(string username, string password)
        {
            var user = _dbService.GetUserByLogin(username);

            if (user == null)
            {
                throw new Exception("user does not exist");
            }

            if (_commonService.DecryptPassword(user.HashedPassword) == password)
            {
                return true;
            }

            return false;
        }

    }
}
