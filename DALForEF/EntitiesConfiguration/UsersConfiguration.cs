using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Data.Entity;
using DALForEF.POCO;

namespace DALForEF.EntitiesConfiguration
{
    public class UsersConfiguration
    {
        public void OnModelCreating(DbModelBuilder usersConfiguration)
        {
            usersConfiguration.Entity<User>().HasKey(x => x.UserId);
            usersConfiguration.Entity<User>().Property(x => x.UserId).HasColumnType("int");

            usersConfiguration.Entity<User>().Property(x => x.UserName).IsRequired();
            usersConfiguration.Entity<User>().Property(x => x.UserName).HasColumnType("nvarchar");
            usersConfiguration.Entity<User>().Property(x => x.UserName).HasMaxLength(300);

            usersConfiguration.Entity<User>().Property(x => x.Password).IsRequired();
            usersConfiguration.Entity<User>().Property(x => x.Password).HasColumnType("nvarchar");
            usersConfiguration.Entity<User>().Property(x => x.Password).HasMaxLength(300);
        }
    }
}