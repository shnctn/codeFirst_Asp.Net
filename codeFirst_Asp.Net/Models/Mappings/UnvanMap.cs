using codeFirst_Asp.Net.Models.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;

namespace codeFirst_Asp.Net.Models.Mappings
{
    public class UnvanMap:EntityTypeConfiguration<Unvan>
    {

        public UnvanMap()
        {
            ToTable("Unvanlar");
            Property(x => x.Ad).HasMaxLength(100).IsRequired();
         
        }
    }
}