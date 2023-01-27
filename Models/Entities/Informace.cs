using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ZAD_WEB_2b.Models.Entities
{
    public class Informace
    {
        public int ID { get; set; }


        public string Nazev { get; set; } = "";


        public string Detail { get; set; } = "";

        [Required]
        public string DatumVytvoreni { get; set; } = "";

        public Informace()
        {

        }

    }
}
