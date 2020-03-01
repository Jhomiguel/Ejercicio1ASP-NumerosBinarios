using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using NumerosBinarios.Models;

namespace NumerosBinarios.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View(new NumBinario());
        }
        [HttpPost]
        public IActionResult Index(NumBinario Nums)
        {
            if (ModelState.IsValid)
            {
                Nums.NBinarios = NumBinario.Binario(Nums.Numeros);
                return View("Mostrar", Nums);
            }
            return View(Nums);
        }
    }
}
