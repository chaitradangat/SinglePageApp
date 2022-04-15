using System;
using System.Collections.Generic;
using System.Text;

namespace SinglePageApp.Domain
{
    public class UserInfo
    {
        public int ID { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string UserName { get; set; }

        public string EmailAddress { get; set; }

        public UserRole UserRole { get; set; }

        public string HashedPassword { get; set; }

        public string HashedSalt { get; set; }
    }

    public enum UserRole
    { 
        User = 3,
        Admin = 2,
        Root = 1
    }
}
