using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppUnidadIPOO
{
  public partial class frmSuma : Form
  {
    public frmSuma()
    {
      InitializeComponent();
    }

    private void btnSumar_Click(object sender, EventArgs e)
    {
      Sumatoria suma = new Sumatoria(Int32.Parse(txtNumeroUno.Text), Int32.Parse(txtNumeroDos.Text));
      suma.Ejecutar();
      MessageBox.Show("El resultado de la suma de " + suma.Numero1 + " + " + suma.Numero2 + " es: " + suma.Resultado);
    }
    private void btnRestar_Click(object sender, EventArgs e)
    {
      Resta resta = new Resta();
      resta.Numero1 = Int32.Parse(txtNumeroUno.Text);
      resta.Numero2 = Int32.Parse(txtNumeroDos.Text);
      MessageBox.Show("El resultado de la suma de " + resta.Numero1 + " + " + resta.Numero2 + " es: " + resta.Ejecutar());      
    }
  }
}
