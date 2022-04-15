using SinglePageApp.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SinglePageApp.Services.Database
{
    public static class DbInitializer
    {
        public static void Initialize(UserContext context)
        {
            context.Database.EnsureCreated();

            if (context.UserInfos.Any())
            {
                return;   // DB has been seeded
            }

            var users = new UserInfo[]
            {
                new UserInfo{ EmailAddress="user1@email.com", FirstName = "fname1", LastName = "lname1", HashedPassword = "password", HashedSalt= "not implemented", UserName = "user1", UserRole = UserRole.Root },
                new UserInfo{ EmailAddress="user2@email.com", FirstName = "fname2", LastName = "lname2", HashedPassword = "password", HashedSalt= "not implemented", UserName = "user2", UserRole = UserRole.Admin },
                new UserInfo{ EmailAddress="user3@email.com", FirstName = "fname3", LastName = "lname3", HashedPassword = "password", HashedSalt= "not implemented", UserName = "user3", UserRole = UserRole.User },
            };

            context.UserInfos.AddRange(users);
            
            context.SaveChanges();
        }
    }
}