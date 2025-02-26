using LojaInfo.Data;
using LojaInfo.Models;
using Microsoft.AspNetCore.Mvc;
namespace LojaInfo.Controllers
{
    public class CadastroController : Controller
    {
        private readonly ContextoDB _contexto;
        public CadastroController(ContextoDB contexto) { _contexto = contexto; }
        public List<ModelClientes> GetClientes()
        {
            return _contexto.clientes.ToList();
        }
        public IActionResult CadastroClientes()
        {
            List<ModelClientes> tabela = GetClientes();
            return View(tabela);
        }
        public IActionResult CadastroColaboradores() { return View(); }
        public IActionResult CadastroFornecedores() { return View(); }
        public IActionResult CadastroProdutos() { return View(); }
    }    
}