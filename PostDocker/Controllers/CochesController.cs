using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PostDocker.Repositories;

namespace PostDocker.Controllers
{
    public class CochesController : Controller
    {
        IRepositoryCoches repo;
        public CochesController(IRepositoryCoches repo)
        {
            this.repo = repo;
        }
        public IActionResult Index()
        {

            return View(this.repo.GetCoches());
        }
    }
}