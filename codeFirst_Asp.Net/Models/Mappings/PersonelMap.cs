using codeFirst_Asp.Net.Models.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;

namespace codeFirst_Asp.Net.Models.Mappings
{
    public class PersonelMap: EntityTypeConfiguration<Personel>
    {
        public PersonelMap()
        {
            ToTable("Personel");
            Property(x => x.Ad).HasMaxLength(30).IsRequired();
            Property(x => x.Soyad).HasMaxLength(50).IsOptional();
            Property(x => x.EmailAdress).HasMaxLength(150).IsRequired();

           
        }

    }
}