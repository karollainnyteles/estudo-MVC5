using ProjetoTesteMVC5.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjetoTesteMVC5.Controllers
{
    public class AlunoController : Controller
    {
        [HttpGet]
        [Route("novo-aluno")]
        public ActionResult NovoAluno()
        {
            return View();

        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [Route("novo-aluno")]
        public ActionResult NovoAluno(Aluno aluno)
        {
            if (!ModelState.IsValid)
            {
                return View(aluno);
            }

            return View(aluno);

        }
           
    }
}