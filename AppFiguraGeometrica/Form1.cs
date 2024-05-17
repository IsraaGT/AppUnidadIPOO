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
  public partial class Form1 : Form
  {
    public static FiguraGeometrica figuraGeometrica;
    public Form1()
    {
      InitializeComponent();
    }

    private void btnCirculo_Click(object sender, EventArgs e)
    {
      frmCirculo frmCirculo = new frmCirculo();
      frmCirculo.ShowDialog();
    }

    private void btnTriangulo_Click(object sender, EventArgs e)
    {
      frmTriangulo frmTriangulo = new frmTriangulo();
      frmTriangulo.ShowDialog();
    }
  }
}
