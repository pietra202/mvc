using Microsoft.AspNetCore.Mvc;
using Primeiro_MVC.Models;

namespace Primeiro_MVC.Controllers
{
    public class AlunoController : Controller
    {
        public IActionResult Index()
        {
            Aluno a1 = new Aluno(1, "Cristiano de Paula", "cristiano.paula@sp.senai.br", 123456);
            Aluno a2 = new Aluno(2, "Pietra godoi", "pietra.godoi@sp.senai.br", 123456);
            Aluno a3 = new Aluno(3, "Romeu josé", "romeu.jose@sp.senai.br", 123456);
            Aluno a4 = new Aluno(4, "Chico Bento", "chico.bento@sp.senai.br", 123456);
            Aluno a5 = new Aluno(5, "Bidu", "bidu.dudu@sp.senai.br", 123456);

            List<Aluno> listaAlunos = new List<Aluno>();
            listaAlunos.Add(a1);
            listaAlunos.Add(a2);
            listaAlunos.Add(a3);
            listaAlunos.Add(a4);
            listaAlunos.Add(a5);

            return View();
        }

        public IActionResult Cadastrar()
        {
            return View();
        }
    }
}
