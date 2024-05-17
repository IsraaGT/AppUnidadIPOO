using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppAdministracionEscuela
{
  public static class FuncionesComunes
  {
    public static int CalcularEdad(DateTime fechaNacimiento)
    {
      return DateTime.Now.Year - fechaNacimiento.Year;
    }
        public static void CalculaCURP(Personal persona)
        {
            string primeraConsonanteInterna(string str)
            {
                foreach (char c in str.Substring(1).ToUpper())
                {
                    if (!"AEIOU".Contains(c))
                    {
                        return c.ToString();
                    }
                }
                return "X"; // Retorna 'X' si no se encuentra una consonante interna
            }

            persona.Curp = persona.App.Substring(0, 2).ToUpper() +
                           persona.Apm.Substring(0, 1).ToUpper() +
                           persona.Nombre.Substring(0, 1).ToUpper() +
                           persona.FechaNacimiento.ToString("yyMMdd") +
                           (persona.Sexo ? "H" : "M") +
                           persona.Estado.Substring(0, 2).ToUpper() +
                           primeraConsonanteInterna(persona.App) +
                           primeraConsonanteInterna(persona.Apm) +
                           primeraConsonanteInterna(persona.Nombre) +
                           "00"; // Homoclave simple para evitar duplicidades, en lugar de "00" se debería calcular adecuadamente

            // Validación simple para evitar palabras inapropiadas
            if (persona.Curp.Contains("PUTO"))
            {
                persona.Curp = persona.Curp.Replace("O", "X");
            }
        }


        public static int ObtieneSiguiente(object[] arreglo)
    {
      int i = 0;
      for (i = 0; i < arreglo.Length; i++)
      {
        if (arreglo[i] == null)
          break;
      }
      return i;
    }
  }
}
