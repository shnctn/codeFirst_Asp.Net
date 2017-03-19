using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace codeFirst_Asp.Net.Models.Entities
{
    public class Personel
    {
        public int Id { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string EmailAdress { get; set; }
        public DateTime IseGirisTarihi { get; set; }
        [ForeignKey("Unvan")]
        public int UnvanID { get; set; }

        public virtual Unvan Unvan { get; set; }
    }
}