using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebString.Model;


namespace WebString.Controllers
{
    public class CadenaController : Controller
    {
        // GET: Cadena
        public ActionResult Practica()
        {
            return View("Practica");
        }

        public ActionResult Contador(string cadena)
        {
            Logica contador = new Logica();
            int caracter = contador.Contador(cadena);
            TempData["ejercicio1"] =$"{cadena} tiene {caracter} caracteres";

            return View("Practica");
        }

        public ActionResult Mayus(string cadena)
        {
            Logica mayus = new Logica();
            string resultado = mayus.Mayusculas(cadena);
            TempData["ejercicio2"] = resultado;

            return View("Practica");
        }

        public ActionResult Minus(string cadena)
        {
            Logica minus = new Logica();
            string resultado = minus.Minusculas(cadena);
            TempData["ejercicio3"] = resultado;

            return View("Practica");
        }

        public ActionResult Concatenar(string cadenaUno, string cadenaDos, string cadenaTres)
        {
            TempData["ejercicio4"] = $"{cadenaUno} {cadenaDos} {cadenaTres}";
            return View("Practica");
        }

        public ActionResult Validar(string cadenaUno, string cadenaDos)
        {
            Logica validar = new Logica();
            bool existe = validar.Validacion(cadenaUno, cadenaDos);

            if (existe)
            {
                TempData["ejercicio5"] = $"{cadenaDos} si existe en la primer cadena";
            } 
            else
            {
                TempData["ejercicio5"] = $"{cadenaDos} no existe en la primer cadena";
            }

            return View("Practica");
        }

        public ActionResult QuitarCaracter(string cadena)
        {
            Logica cadenaNew = new Logica();
            string resultado = cadenaNew.Quitar(cadena);
            TempData["ejercicio6"] = resultado;

            return View("Practica");
        }

        public ActionResult QuitarComa(string cadena)
        {
            Logica logica = new Logica();
            string resultado = logica.Quitar(cadena);
            TempData["ejercicio7"] = resultado;

            return View("Practica");
        }

        public ActionResult QuitarEspacios(string cadena)
        {
            Logica logica = new Logica();
            string resultado = logica.Espacios(cadena);
            TempData["ejercicio8"] = resultado;

            return View("Practica");
        }

        public ActionResult ValidarString(string cadena)
        {
            Logica logica = new Logica();
            bool existe = logica.ValidacionDos(cadena);

            if (existe)
            {
                TempData["ejercicio9"] = $"{cadena} si contiene la palabra 'Ti'";
            }
            else
            {
                TempData["ejercicio9"] = $"{cadena} no contiene la palabra 'Ti'";
            }

            return View("Practica");
        }

        public ActionResult Agregar(string cadena)
        {
            Logica logica = new Logica();
            string resultado = logica.AgregarCeros(cadena);
            TempData["ejercicio10"] = resultado;

            return View("Practica");
        }
    }
}