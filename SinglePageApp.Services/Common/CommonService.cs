using Microsoft.AspNetCore.Cryptography.KeyDerivation;
using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace SinglePageApp.Services.Common
{
    public class CommonService : ICommonService
    {
        public string EncryptPassword(string password)
        {
            return password;

            /*
            byte[] _salt = new byte[128 / 8];

            using (var rngCsp = new RNGCryptoServiceProvider())
            {
                rngCsp.GetNonZeroBytes(_salt);
            }

            salt = Convert.ToBase64String(_salt);


            encryptedPassword = Convert.ToBase64String(KeyDerivation.Pbkdf2(
            password: password,
            salt: _salt,
            prf: KeyDerivationPrf.HMACSHA256,
            iterationCount: 100000,
            numBytesRequested: 256 / 8));
            */
        }

        public string DecryptPassword(string encryptedPassword)
        {
            return encryptedPassword;
        }
    }
}
