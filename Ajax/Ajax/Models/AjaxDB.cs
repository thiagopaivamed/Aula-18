using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ajax.Models
{
    public class AjaxDB : DbContext
    {
        public DbSet<Pessoa> Pessoas { get; set; }

        public AjaxDB(DbContextOptions<AjaxDB> options) : base(options)
        {

        }
    }
}
