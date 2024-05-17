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
  public partial class frmTriangulo : Form
  {
    public frmTriangulo()
    {
      InitializeComponent();
    }

    private void btnCalcular_Click(object sender, EventArgs e)
    {    

      Form1.figuraGeometrica = new Triangulo();
      Form1.figuraGeometrica.B = (int)nudBase.Value;
      Form1.figuraGeometrica.H = (int)nudAltura.Value;
      Form1.figuraGeometrica.Calcular();
      MessageBox.Show("El area del triangulo es:" + Form1.figuraGeometrica.Area);

      //Form1.figuraGeometrica = new Cuadrado();
      //Form1.figuraGeometrica.H = 5;
      //Form1.figuraGeometrica.B = 5;
      //Form1.figuraGeometrica.Calcular();



    }
  }
}
