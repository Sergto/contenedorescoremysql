using PostDocker.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PostDocker.Repositories
{
    public interface IRepositoryCoches
    {
        List<Coche> GetCoches();
    }
}
