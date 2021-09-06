using ProjetoTesteMVC5.Data;
using ProjetoTesteMVC5.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjetoTesteMVC5.Controllers
{
    public class AlunoController : Controller
    {

        private AppDbContext context = new AppDbContext();

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

            aluno.DataMatricula = DateTime.Now;
            context.Alunos.Add(aluno);
            context.SaveChanges();

            return View(aluno);

        }

        [HttpGet]
        [Route("obter-alunos")]
        public ActionResult ObterAlunos()
        {
            var alunos = context.Alunos.ToList();
            return View("NovoAluno",alunos.FirstOrDefault());

        }

        [HttpGet]
        [Route("editar-alunos")]
        public ActionResult EditarAluno()
        {
            var aluno = context.Alunos.FirstOrDefault(a => a.Nome == "karol teles");

            aluno.Nome = "Karollainny Teles";
            var entry = context.Entry(aluno);
            context.Set<Aluno>().Attach(aluno);
            entry.State = EntityState.Modified;

            context.SaveChanges();

            var alunoModificado = context.Alunos.Find(aluno.Id);
            return View("NovoAluno", alunoModificado);

        }

        [HttpGet]
        [Route("excluir-alunos")]
        public ActionResult ExcluirAluno()
        {
            var aluno = context.Alunos.FirstOrDefault(a => a.Nome == "teste");

            context.Alunos.Remove(aluno);
            context.SaveChanges();

            var alunos = context.Alunos.ToList();
            return View("NovoAluno", alunos.FirstOrDefault());

        }

    }
}   