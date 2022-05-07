using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AquiOuAcola.Controllers
{
    public class UsuariosController : Controller
    {
        public IActionResult cadastrarUsuario()
        {
            return View();
        }
    }
}
