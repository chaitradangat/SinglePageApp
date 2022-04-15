using Microsoft.EntityFrameworkCore;
using SinglePageApp.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace SinglePageApp.Services.Database
{
    public class UserContext : DbContext
    {
        public UserContext(DbContextOptions<UserContext> options) : base(options)
        {

        }

        public DbSet<UserInfo> UserInfos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<UserInfo>().ToTable("UserInfo");
        }

    }
}
