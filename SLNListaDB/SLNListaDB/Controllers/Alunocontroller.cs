using Microsoft.AspNetCore.Mvc;
using SLNListaDB.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SLNListaDB.Controllers
{
    public class Alunocontroller : Controller
    {
        public IActionResult Index()
        {

            Respdal alunos = new Respdal();
            ViewBag.Listalunos = alunos.GetAlunomodels();




            return View();
        }
    }
}
