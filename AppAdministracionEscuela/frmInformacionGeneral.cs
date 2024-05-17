using Newtonsoft.Json;
using System;
using System.Linq;
using System.Windows.Forms;

namespace AppAdministracionEscuela
{
    public partial class frmInformacionGeneral : Form
    {
        private string datosJSON;
        public frmInformacionGeneral()
        {
            InitializeComponent();
        }

        public frmInformacionGeneral(string matricula)
        {
            InitializeComponent();
            Alumno alumno = new Alumno();
            datosJSON = alumno.BuscarPorMatricula(matricula);
            alumno = JsonConvert.DeserializeObject<Alumno>(datosJSON);
            txtNombre.Text = alumno.Nombre;
            txtApellidoPaterno.Text = alumno.App;
            txtApellidoMaterno.Text = alumno.Apm;
            txtTelefono.Text = alumno.Telefono;
            txtEmail.Text = alumno.Email;
            txtEstado.Text = alumno.Estado;
            txtCalle.Text = alumno.Calle;
            txtColonia.Text = alumno.Colonia;
            txtCiudad.Text = alumno.Ciudad;
            dateTimePicker1.Value = alumno.FechaNacimiento;
            if (alumno.Sexo)
            {
                rdHombre.Checked = true;
            }
            else
            {
                rdMujer.Checked = true;
            }
        }

        public string DatosJSON { get => datosJSON; set => datosJSON = value; }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                var alumno = new Alumno
                {
                    Nombre = txtNombre.Text,
                    App = txtApellidoPaterno.Text,
                    Apm = txtApellidoMaterno.Text,
                    FechaNacimiento = dateTimePicker1.Value,
                    Sexo = rdHombre.Checked,
                    Estado = txtEstado.Text,
                    Telefono = txtTelefono.Text,
                    Email = txtEmail.Text,
                    Calle = txtCalle.Text,
                    Colonia = txtColonia.Text,
                    Ciudad = txtCiudad.Text
                };

                datosJSON = JsonConvert.SerializeObject(alumno);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private bool ValidarDatos()
        {
            // Validar que ningún campo esté vacío
            foreach (Control control in this.Controls)
            {
                if (control is TextBox && string.IsNullOrWhiteSpace(control.Text))
                {
                    MessageBox.Show("Todos los campos deben estar completos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }

            // Validar que el número de teléfono tenga exactamente 10 dígitos
            if (txtTelefono.Text.Length != 10 || !txtTelefono.Text.All(char.IsDigit))
            {
                MessageBox.Show("El número de teléfono debe constar de 10 dígitos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // Validar que el email contenga un "@" y al menos un punto "."
            if (!txtEmail.Text.Contains("@") || !txtEmail.Text.Contains("."))
            {
                MessageBox.Show("El correo electrónico debe contener un '@' y al menos un punto '.'", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // Validar que se haya especificado el sexo
            if (!rdHombre.Checked && !rdMujer.Checked)
            {
                MessageBox.Show("Especifique el sexo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // Validar que los campos de texto no contengan números
            if (txtNombre.Text.Any(char.IsDigit) ||
                txtApellidoPaterno.Text.Any(char.IsDigit) ||
                txtApellidoMaterno.Text.Any(char.IsDigit) ||
                txtCiudad.Text.Any(char.IsDigit) ||
                txtColonia.Text.Any(char.IsDigit) ||
                txtEstado.Text.Any(char.IsDigit))
            {
                MessageBox.Show("Los campos de nombre, apellidos, ciudad, colonia y estado no deben contener números.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            // Aquí puedes manejar los cambios en el DateTimePicker, si es necesario
        }
    }
}
