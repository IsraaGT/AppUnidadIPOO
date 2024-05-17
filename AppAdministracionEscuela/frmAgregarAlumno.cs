using System;
using System.Linq;
using System.Windows.Forms;

namespace AppAdministracionEscuela
{
    public partial class frmAgregarAlumno : Form
    {
        private Alumno alumno;
        public frmAgregarAlumno(Alumno alumno)
        {
            InitializeComponent();
            this.alumno = alumno;
        }

        private void frmAgregarAlumno_Load(object sender, EventArgs e)
        {
            LblNombre.Text = alumno.Nombre + " " + alumno.App + " " + alumno.Apm;
            txtMatricula.Text = alumno.Matricula;
            txtCarrera.Text = alumno.Carrera;
            txtSemestre.Text = alumno.Semestre > 0 ? alumno.Semestre.ToString() : string.Empty;
            txtCargaAcademica.Text = alumno.CargaAcademica != null && alumno.CargaAcademica.Any() ? string.Join(",", alumno.CargaAcademica.Where(ca => !string.IsNullOrWhiteSpace(ca))) : string.Empty;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (ValidarDatosAdicionales())
            {
                alumno.Matricula = txtMatricula.Text;
                alumno.Carrera = txtCarrera.Text;
                alumno.Semestre = int.Parse(txtSemestre.Text);
                alumno.CargaAcademica = txtCargaAcademica.Text.Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries).Where(ca => !string.IsNullOrWhiteSpace(ca)).ToArray();
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private bool ValidarDatosAdicionales()
        {
            if (string.IsNullOrWhiteSpace(txtMatricula.Text))
            {
                MessageBox.Show("La matrícula no puede estar vacía.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtCarrera.Text))
            {
                MessageBox.Show("La carrera no puede estar vacía.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (!int.TryParse(txtSemestre.Text, out int semestre) || semestre <= 0)
            {
                MessageBox.Show("El semestre debe ser un número mayor que 0.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
    }
}
