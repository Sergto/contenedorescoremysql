using Microsoft.EntityFrameworkCore;
using PostDocker.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PostDocker.Data
{
    public interface ICochesContext
    {
        DbSet<Coche> Coches { get; set; }
        int SaveChanges();

        void GuardarCambios();
    }
}
