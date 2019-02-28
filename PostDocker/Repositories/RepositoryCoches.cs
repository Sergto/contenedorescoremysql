using PostDocker.Data;
using PostDocker.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PostDocker.Repositories
{
    public class RepositoryCoches: IRepositoryCoches
    {
        ICochesContext context;
        public RepositoryCoches(ICochesContext context)
        {
            this.context = context;
        }
        public List<Coche> GetCoches()
        {
            return context.Coches.ToList();
        }
    }
}
