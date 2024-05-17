using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppFiguraGeometrica
{
  public partial class frmCirculo : Form
  {
    public frmCirculo()
    {
      InitializeComponent();
    }

    private void btnCalcular_Click(object sender, EventArgs e)
    {
      Circulo circulo = new Circulo();
      circulo.Radio = Int32.Parse(nudRadio.Value.ToString());
      circulo.Calcular();
      if(circulo.Area == -1 )
      {
        MessageBox.Show("Ocurrio un error en el calculo");
        this.Close();
      }
      MessageBox.Show("El area del circulo es:" + circulo.Area);
    }
  }
}
