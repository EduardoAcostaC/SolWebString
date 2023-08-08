using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;

namespace WebString.Model
{
    public class Logica
    {
        public int Contador(string cadena)
        { 
            int caracteres = cadena.Count();
            return caracteres;
        }

        public string Mayusculas(string cadena) 
        { 
            string caracteres = cadena.ToUpper();
            return caracteres;
        }

        public string Minusculas(string cadena)
        {
            string caracteres = cadena.ToLower();
            return caracteres;
        }

        public bool Validacion(string cadenaUno, string cadenaDos)
        {
            return cadenaUno.Contains(cadenaDos);
        }

        public string Quitar(string cadena)
        {
            string cadenaA = cadena.Replace(",", " ");
            string cadenaB = cadenaA.Replace("/", " ");

            return cadenaB;
        }

        public string Coma(string cadena)
        {
            string SinComa = cadena.Replace(",", "");
            return SinComa;
        }

        public string Espacios(string cadena)
        {
            string SinEspacio = cadena.Trim();
            return SinEspacio;
        }

        public bool ValidacionDos(string cadena)
        {
            return cadena.Contains("Ti");
        }

        public string AgregarCeros(string cadena)
        {
            string resultado = cadena.PadLeft(5, '0');
            return resultado;
        }
    }
}