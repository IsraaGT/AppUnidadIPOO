using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppFiguraGeometrica
{
  public class Cuadrado: FiguraGeometrica
  {
    public Cuadrado():base()
    { }
    public override int Calcular()
    {
      area = b * h;
      return area;
    }
  }
}
