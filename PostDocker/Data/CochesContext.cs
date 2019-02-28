using Microsoft.EntityFrameworkCore;
using PostDocker.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PostDocker.Data
{
    public class CochesContext : DbContext, ICochesContext
    {
        public CochesContext(DbContextOptions options)
            : base(options) { }

        public DbSet<Coche> Coches { get; set; }

        public void GuardarCambios()
        {
            this.SaveChanges();
        }
    }
}
