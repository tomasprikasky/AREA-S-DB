using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ZAD_WEB_2b.Models.Entities;

namespace ZAD_WEB_2b.Models.Databse
{
    public class InfoDbContext :DbContext //jmeno našeho db contextu : třída DbContext se najde až po nainstalování package EF core 5.0.17 a PomeloSQL 5.0.4
    {
        public DbSet<Informace> Informace { get; set; } //Informace  musíme dát using na tu entitu co jsme vytvořili
        public InfoDbContext(DbContextOptions options) : base(options)
        {

        }
    }
}
