using ControleDeContatos.Models;
using ControleDeContatos.Repositorio;
using Microsoft.AspNetCore.Mvc;

namespace ControleDeContatos.Controllers
{
    public class ContatoController : Controller
    {
        private readonly IContatoRepositorio _contatoRepositorio;
        public ContatoController(IContatoRepositorio contatoRepositorio)
        {
            _contatoRepositorio = contatoRepositorio;
            
        }
        public IActionResult Index()
        {
            List<ContatoModel> contatos = _contatoRepositorio.BuscarTodos();
            return View(contatos);
        }

        public IActionResult Criar()
        {
            return View();
        }

        public IActionResult Editar(int id )
        {
            ContatoModel contato = _contatoRepositorio.ListarPorId(id);
            
            return View(contato);
        }

        public IActionResult ApagarConfirmacao(int id)
        {
            ContatoModel contato = _contatoRepositorio.ListarPorId(id);
            return View(contato);
        }

<<<<<<< HEAD
        public IActionResult Apagar(int id)
        {
            _contatoRepositorio.Apagar(id);
            return RedirectToAction("Index");
        }

=======
>>>>>>> 2895ed94175598edbbf925dd9ae96e6ebcca2d0a
        [HttpPost]
        public IActionResult Criar(ContatoModel contato) 
        {
            _contatoRepositorio.Adicionar(contato);
            return RedirectToAction("Index");
        
        }
<<<<<<< HEAD
        [HttpPost]
        public IActionResult Alterar(ContatoModel contato) 
        {
            _contatoRepositorio.Atualizar(contato);
            return RedirectToAction("Index");
        
        }
=======
>>>>>>> 2895ed94175598edbbf925dd9ae96e6ebcca2d0a

    }
}
