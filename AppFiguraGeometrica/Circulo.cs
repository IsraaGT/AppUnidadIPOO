using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppFiguraGeometrica
{
  public class Circulo : FiguraGeometrica
  {
    int radio;
    public Circulo() : base()
    {
      radio = 0;
    }
    public int Radio
    {
      get { return  radio; }
      set { radio = value; }
    }
    public override int Calcular()
    {
      try
      {
        double a = Math.PI * Math.Pow(radio, 2);
        area = (int)a;
        return area;
      }
      catch (Exception ex)
      {
        area = -1;
        return area;
      }
    }
  }
}
