using System.Security.Claims;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AquiOuAcola.Controllers
{
    public class CursoFavoritoController : Controller
    {
        private readonly Contexto db;

        public CursoFavoritoController(Contexto contexto)
        {
            db = contexto;
        }

        public IActionResult Add(int id)
        {
            var identity = HttpContext.User.Identity as ClaimsIdentity;
            if (identity != null)
            {
                IEnumerable<Claim> claims = identity.Claims;
                // or
                identity.FindFirst(a => a.Type == ClaimTypes.Sid);

            }
            return View("~/Views/Usuarios/Perfil.cshtml");
        }
    }
}
