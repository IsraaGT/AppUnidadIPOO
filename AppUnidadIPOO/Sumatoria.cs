using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppUnidadIPOO
{
  public class Sumatoria : Operacion
  {

    #region Constructores
    public Sumatoria()
    {
      numero1 = 0;
      numero2 = 0;
      resultado = 0;
    }
    public Sumatoria(int numero1, int numero2)
    {
      this.numero1 = numero1;
      this.numero2 = numero2;
      resultado = 0;
    }
    #endregion
    
    #region Metodos
    public override int Ejecutar()
    {
      resultado = numero1 + numero2;
      return resultado;
    }
    public int Ejecutar(int numero1, int numero2)
    { 
      return numero1 + numero2; 
    }
    #endregion
  }
}
