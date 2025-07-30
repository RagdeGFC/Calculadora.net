using Microsoft.AspNetCore.Mvc;
using src.Models;

namespace src.Controllers
{
  public class CalculadoraController : Controller
  {
    public IActionResult Index()
    {
      return View();
    }

    [HttpPost]
    public IActionResult Calcular(Operacion operacion)
    {
      switch (operacion.Operador)
      {
        case "+":
          operacion.Resultado = operacion.Numero1 + operacion.Numero2;
          break;
        case "-":
          operacion.Resultado = operacion.Numero1 - operacion.Numero2;
          break;
        case "*":
          operacion.Resultado = operacion.Numero1 * operacion.Numero2;
          break;
        case "/":
          operacion.Resultado = operacion.Numero2 != 0 ? operacion.Numero1 / operacion.Numero2 : 0;
          break;
      }

      return View("Resultado", operacion);
    }
  }
}
