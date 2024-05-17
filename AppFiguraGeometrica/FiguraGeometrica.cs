using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppFiguraGeometrica
{
  public abstract class FiguraGeometrica
  {
    protected int b, h, area;
    public FiguraGeometrica()
    {
      area = 0;
      b = 0;
      h = 0;
    }
    public int B
    {
      get
      {
        return b;
      }
      set
      {
        b = value;
      }
    }
    public int H
    {
      get { return h; }
      set { h = value; }
    }
    public int Area
    {
      get { return area; }
    }
    public virtual int Calcular()
    {
      return Area;
    }
  }
}
