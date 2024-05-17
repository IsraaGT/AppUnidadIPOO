using System;
using System.Linq;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace AppAdministracionEscuela
{
    public partial class frmAlumno : Form
    {
        public frmAlumno()
        {
            InitializeComponent();
            lstAlumnos.View = View.Details;
            lstAlumnos.Columns.Add("Matricula");
            lstAlumnos.Columns.Add("Nombre");
            lstAlumnos.Columns.Add("Ap Paterno");
            lstAlumnos.Columns.Add("Ap Materno");
            lstAlumnos.Columns.Add("Carrera");
            lstAlumnos.Columns.Add("CURP"); // Agregar la columna CURP
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmInformacionGeneral informacionGeneral = new frmInformacionGeneral();
            bool datosValidos = false;

            while (!datosValidos)
            {
                if (informacionGeneral.ShowDialog() == DialogResult.OK)
                {
                    string informacion = informacionGeneral.DatosJSON;
                    int i = FuncionesComunes.ObtieneSiguiente(BaseDatos.Alumnos);
                    if (i >= 0 && i < BaseDatos.Alumnos.Length)
                    {
                        try
                        {
                            BaseDatos.Alumnos[i] = JsonConvert.DeserializeObject<Alumno>(informacion);

                            // Abre el formulario frmAgregarAlumno para datos adicionales
                            frmAgregarAlumno agregarAlumno = new frmAgregarAlumno(BaseDatos.Alumnos[i]);
                            if (agregarAlumno.ShowDialog() == DialogResult.OK)
                            {
                                FuncionesComunes.CalculaCURP(BaseDatos.Alumnos[i]);
                                poblarListView();
                                MessageBox.Show("La información se guardó correctamente");
                                datosValidos = true;
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"Error al deserializar los datos del alumno: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("No hay espacio para más alumnos.");
                        break; // Salir del bucle si no hay espacio
                    }
                }
                else
                {
                    break; // Salir del bucle si se cancela el formulario
                }
            }
        }

        private void frmAlumno_Load(object sender, EventArgs e)
        {
            poblarListView();
        }

        public void poblarListView()
        {
            lstAlumnos.Items.Clear();
            foreach (Alumno alumno in BaseDatos.Alumnos)
            {
                if (alumno != null && !string.IsNullOrWhiteSpace(alumno.Matricula))
                {
                    ListViewItem item = new ListViewItem(alumno.Matricula);
                    item.SubItems.Add(alumno.Nombre);
                    item.SubItems.Add(alumno.App);
                    item.SubItems.Add(alumno.Apm);
                    item.SubItems.Add(alumno.Carrera);
                    item.SubItems.Add(alumno.Curp); // Agregar la CURP al item

                    lstAlumnos.Items.Add(item);
                }
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (lstAlumnos.SelectedItems.Count == 0)
            {
                MessageBox.Show("No hay registros disponibles para modificar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string matricula = lstAlumnos.SelectedItems[0].SubItems[0].Text;
            Alumno alumnoExistente = ObtenerAlumnoPorMatricula(matricula);

            if (alumnoExistente != null)
            {
                if (ModificarInformacionGeneral(alumnoExistente) && ModificarDatosAdicionales(alumnoExistente))
                {
                    FuncionesComunes.CalculaCURP(alumnoExistente);
                    poblarListView();
                    MessageBox.Show("La información se modificó correctamente.");
                }
            }
            else
            {
                MessageBox.Show("No se encontró el alumno con la matrícula especificada.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private Alumno ObtenerAlumnoPorMatricula(string matricula)
        {
            return BaseDatos.Alumnos.FirstOrDefault(a => a != null && a.Matricula == matricula);
        }

        private bool ModificarInformacionGeneral(Alumno alumno)
        {
            frmInformacionGeneral frmInformacionGeneral = new frmInformacionGeneral(alumno.Matricula);
            if (frmInformacionGeneral.ShowDialog() == DialogResult.OK)
            {
                string informacion = frmInformacionGeneral.DatosJSON.ToString();
                Alumno alumnoModificado = JsonConvert.DeserializeObject<Alumno>(informacion);

                ActualizarDatosAlumno(alumno, alumnoModificado);
                return true;
            }
            return false;
        }

        private bool ModificarDatosAdicionales(Alumno alumno)
        {
            frmAgregarAlumno agregarAlumno = new frmAgregarAlumno(alumno);
            return agregarAlumno.ShowDialog() == DialogResult.OK;
        }

        private void ActualizarDatosAlumno(Alumno alumnoExistente, Alumno alumnoModificado)
        {
            alumnoExistente.Nombre = alumnoModificado.Nombre;
            alumnoExistente.App = alumnoModificado.App;
            alumnoExistente.Apm = alumnoModificado.Apm;
            alumnoExistente.FechaNacimiento = alumnoModificado.FechaNacimiento;
            alumnoExistente.Sexo = alumnoModificado.Sexo;
            alumnoExistente.Estado = alumnoModificado.Estado;
            alumnoExistente.Telefono = alumnoModificado.Telefono;
            alumnoExistente.Email = alumnoModificado.Email;
            alumnoExistente.Calle = alumnoModificado.Calle;
            alumnoExistente.Colonia = alumnoModificado.Colonia;
            alumnoExistente.Ciudad = alumnoModificado.Ciudad;
            alumnoExistente.Matricula = alumnoModificado.Matricula;
            alumnoExistente.Carrera = alumnoModificado.Carrera;
            alumnoExistente.CargaAcademica = alumnoModificado.CargaAcademica;
            alumnoExistente.Semestre = alumnoModificado.Semestre;
        }
    }
}