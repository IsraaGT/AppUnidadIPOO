using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppUnidadIPOO
{
  internal class Resta : Operacion
  {
    public Resta() 
    {
      this.numero1 = 0;
      this.numero2 = 0;
      this.resultado = 0;
    }
    public override int Ejecutar()
    {
      resultado = numero1 - numero2;
      return resultado;
    }
  }
}
