using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace AppAdministracionEscuela
{
  public class Alumno: Personal
  {
    #region Variables
    private string matricula, carrera;
    private double[] promedio, evaluacion, calificacion;
    private int semestre;
    private string[] actividadAprendizaje, cargaAcademica;
    #endregion
    public Alumno() :base()
    {

                promedio = new double[10];
                evaluacion = new double[10];
                calificacion = new double[10];
                actividadAprendizaje = new string[10];
                cargaAcademica = new string[10];
            

        }
        #region Propiedades
        public string Matricula { get => matricula; set => matricula = value; }
    public string Carrera { get => carrera; set => carrera = value; }
    public double[] Promedio { get => promedio; set => promedio = value; }
    public double[] Evaluacion { get => evaluacion; set => evaluacion = value; }
    public double[] Calificacion { get => calificacion; set => calificacion = value; }
    public int Semestre { get => semestre; set => semestre = value; }
    public string[] ActividadAprendizaje { get => actividadAprendizaje; set => actividadAprendizaje = value; }
    public string[] CargaAcademica { get => cargaAcademica; set => cargaAcademica = value; }
    #endregion
    #region metodos
    public string BuscarPorMatricula(string matricula)
    {
      string resultado = "";
      foreach (Alumno alumno in BaseDatos.Alumnos)
      {
        if(alumno != null)
        {
          if(alumno.matricula ==  matricula)
          {
            resultado = JsonConvert.SerializeObject(alumno);
          }
        }
      }
      return resultado;
    }
    #endregion
  }
}
