using L02P02_2021CL650.Models;
using Microsoft.AspNetCore.Mvc;

namespace L02P02_2021CL650.Controllers
{
    public class ClientesController : Controller
    {
        private readonly LibreriaDbContext _LibreriaDbContext;

        public ClientesController(LibreriaDbContext equiposDbContext)
        {
            _LibreriaDbContext = equiposDbContext;
        }

        public IActionResult Index()
        {
            var ListaClientes = (from m in _LibreriaDbContext.Clientes select m).ToList();

            ViewData["ListaClientes"] = ListaClientes;
            return View();
        }

        public IActionResult CrearClientes(Clientes nuevoCliente)
        {
            _LibreriaDbContext.Add(nuevoCliente);
            _LibreriaDbContext.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
