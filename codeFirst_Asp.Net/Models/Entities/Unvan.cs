using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace codeFirst_Asp.Net.Models.Entities
{
    public class Unvan
    {
        public int Id { get; set; }
        public string Ad { get; set; }
        public DateTime OlusturmaTarihi { get; set; }

        public virtual ICollection<Personel> Personeller { get; set; }
    }
}