using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppFiguraGeometrica
{
  public class Triangulo: FiguraGeometrica
  {
    public static int ValorPorDefecto = 15;
    public Triangulo():base() { }
    public override int Calcular()
    {
      area = (b * h) / 2;
      return area;
    }
  }
}
