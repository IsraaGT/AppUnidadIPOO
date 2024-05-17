using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppAdministracionEscuela
{
  public static class BaseDatos
  {
    private static Alumno[] alumnos;

    public static Alumno[] Alumnos { get => alumnos; set => alumnos = value; }

    public static void InicializarBD()
    {
      alumnos = new Alumno[100];
    }
  }

}
