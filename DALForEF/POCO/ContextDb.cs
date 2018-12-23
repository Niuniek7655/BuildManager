using DALForEF.EntitiesConfiguration;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using static Constans.ConstansValues;

namespace DALForEF.POCO
{
    public class ContextDb : DbContext
    {
        public DbSet<User> Users { get; set; }
        public ContextDb() : base(ProductionContextDb)
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            var usersConfiguration = new UsersConfiguration();
            usersConfiguration.OnModelCreating(modelBuilder);
        }
    }
}