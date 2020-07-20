using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SalesWebMvc.Models;

namespace SalesWebMvc.Controllers
{
    public class DepartamentsController : Controller
    {
        public IActionResult Index()
        {
            List<Departament> listDepartament = new List<Departament>();
            listDepartament.Add(new Departament { Id = 1, Name = "Eletronics"});
            listDepartament.Add(new Departament { Id = 2, Name = "Fashion" });

            return View(listDepartament);
        }
    }
}
