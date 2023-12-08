
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using _17_CROUD.Models;

namespace _17_CROUD.Controllers
{
   
    public class TarefaController : Controller
    {
        private static List<Tarefa> _tarefas = new List<Tarefa>();
        public IActionResult Index()
        {
            return View(_tarefas);
        }

        public IActionResult Adicionar()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Adicionar(Tarefa novaTarefa)
        {
            novaTarefa.Id = _tarefas.Count + 1;

            _tarefas.Add(novaTarefa);

            return RedirectToAction("index");
        }

        public IActionResult Editar(int id)
        {
            Tarefa tarefaBD = _tarefas.FirstOrDefault(t => t.Id == id);

            if (tarefaBD == null)
                return NotFound();
            return View(tarefaBD);

        }

        [HttpPost]

        public IActionResult Editar(Tarefa tarefaEditando)
        {
            Tarefa tarefaDB = _tarefas.Find(t => t.Id == tarefaEditando.Id);
            if(tarefaDB ==null)
            return NotFound();

            tarefaDB.Descricao = tarefaEditando.Descricao;
            tarefaDB.Concluida= tarefaEditando.Concluida;

            return RedirectToAction("index");
        }
        
        public IActionResult Deletar(int id)
        {
            Tarefa tarefaBD = _tarefas.FirstOrDefault(t => t.Id == id);

            if (tarefaBD == null)
                return NotFound();
            return View(tarefaBD);

        }

        [HttpPost]

        public IActionResult  Deletar(Tarefa tarefaDeletando)
        {
            Tarefa tarefaDB = _tarefas.Find(t => t.Id == tarefaDeletando.Id);
            if(tarefaDB ==null)
            return NotFound();

           _tarefas.Remove(tarefaDB);
            return RedirectToAction("index");
        }
    }
}