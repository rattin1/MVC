using Microsoft.AspNetCore.Mvc;
using MVC.Models;

namespace MVC.Controllers
{
    public class AlunoController : Controller
    {
        public IActionResult Index()
        {
            Aluno a1 = new Aluno(1, "Thiag O Mazzi", "thiago.mazzi@email.com", 4552);
            Aluno a2 = new Aluno(2, "Bruno Junior", "bruno.junior@email.com", 4444);
            Aluno a3 = new Aluno(3, "João Rodolfo Jones", "jones.fia@email.com", 4241);
            Aluno a4 = new Aluno(4, "Jeremias Lol", "jere.lol@email.com", 4214);
            Aluno a5 = new Aluno(5, "Juliana Fulanetto", "juli.ana@email.com", 4567);

            // Criar uma lista de Alunos
            List<Aluno> listaAlunos = new List<Aluno>();
            // Adicionar os Objetos Alunos na Lista Alunos
            listaAlunos.Add(a1);
            listaAlunos.Add(a2);
            listaAlunos.Add(a3);
            listaAlunos.Add(a4);
            listaAlunos.Add(a5);
            // Enviando a lista de Alunos por marametro na View Index
            return View(listaAlunos);
        }

        public IActionResult Cadastrar()
        {
            return View();
        }
    }
}
