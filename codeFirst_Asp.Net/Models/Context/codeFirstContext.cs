using codeFirst_Asp.Net.Models.Entities;
using codeFirst_Asp.Net.Models.Mappings;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace codeFirst_Asp.Net.Models.Context
{
    public class codeFirstContext:DbContext
    {
        public codeFirstContext():base("CodeFirstMsSql")
        {

        }

        public DbSet<Personel> Personeller { get; set; }
        public DbSet<Unvan> Unvanlar { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Configurations.Add ( new PersonelMap());
            modelBuilder.Configurations.Add ( new UnvanMap());
        }
    }
}