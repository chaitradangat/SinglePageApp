using System;
using System.Collections.Generic;
using System.Text;

namespace SinglePageApp.Services
{
    public interface ICommonService
    {
        public void EncryptPassword(string password, out string encryptedPassword, out string salt);

        public void DecryptPassword(string encryptedPassword, string salt, out string password);
    }
}
