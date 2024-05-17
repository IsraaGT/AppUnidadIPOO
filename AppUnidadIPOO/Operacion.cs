using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppUnidadIPOO
{
  public abstract class Operacion
  {
    protected int numero1, numero2;
    protected int resultado;
    public Operacion()
    {
      numero1=0; 
      numero2=0;
      resultado=0;
    }
    #region Propiedades
    public int Numero1
    {
      get { return numero1; }
      set { numero1 = value; }
    }
    public int Numero2
    {
      get { return numero2; }
      set { numero2 = value; }
    }
    public int Resultado
    {
      get { return resultado; }
    }
    #endregion
    public virtual int Ejecutar()
    {
      return resultado;
    }
  }
}
