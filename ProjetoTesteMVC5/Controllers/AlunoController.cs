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
        [Route("novo-aluno")]
        public ActionResult Novo(Aluno aluno)
        {
            aluno = new Aluno { 
                Id = 1,
                Nome = "Karol",
                CPF = "1234567863",
                DataMatricula=DateTime.Now,
                Email = "karol@mail.com",
                Ativo = true
            };

            return RedirectToAction("Index", aluno);
        }

        public ActionResult Index(Aluno aluno)
        {
            if (!ModelState.IsValid)
            {
                return View(aluno);
            }

            return View(aluno);

        }
    }
}