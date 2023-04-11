using Microsoft.AspNetCore.Mvc;
using SLNListaDB.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SLNListaDB.Controllers
{
    public class Respcontroller : Controller
    {
        public IActionResult Index()
        {


            Respdal dados = new Respdal();
            ViewBag.listaresponsaveis = dados.getTodosresponsaveis();
            return View();






        }




    }
}
