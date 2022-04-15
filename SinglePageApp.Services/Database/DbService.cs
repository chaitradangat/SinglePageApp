using SinglePageApp.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SinglePageApp.Services.Database
{
    public class DbService : IDbService
    {
        private readonly UserContext _context;

        public DbService(UserContext context)
        {
            _context = context;
        }

        public List<UserInfo> GetAllUsers()
        {
            return _context.UserInfos.ToList();
        }

        public UserInfo GetUserById(int id)
        {
            return _context.UserInfos.Find(id);
        }

        public UserInfo GetUserByLogin(string username)
        {
            return _context.UserInfos.Where(x => x.UserName == username).FirstOrDefault();
        }

        public void UpdateUsers(List<UserInfo> users)
        {
            foreach (var user in users)
            {
                UserInfo entity = _context.UserInfos.Find(user.ID);

                if ( entity != null)
                {
                    _context.UserInfos.Update(user);       
                }
            }

            _context.SaveChanges();

        }

        public void UpdateUser(UserInfo user)
        {
            _context.Update(user);

            _context.SaveChanges();
        }
    }
}
