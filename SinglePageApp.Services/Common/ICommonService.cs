using System;
using System.Collections.Generic;
using System.Text;

namespace SinglePageApp.Services.Common
{
    public interface ICommonService
    {
        public string EncryptPassword(string password);

        public string DecryptPassword(string encryptedPassword);
    }
}
