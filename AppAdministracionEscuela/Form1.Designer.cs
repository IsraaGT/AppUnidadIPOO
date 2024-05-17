namespace AppAdministracionEscuela
{
  partial class frmAlumno
  {
    /// <summary>
    /// Variable del diseñador necesaria.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Limpiar los recursos que se estén usando.
    /// </summary>
    /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Código generado por el Diseñador de Windows Forms

    /// <summary>
    /// Método necesario para admitir el Diseñador. No se puede modificar
    /// el contenido de este método con el editor de código.
    /// </summary>
    private void InitializeComponent()
    {
      this.btnAgregar = new System.Windows.Forms.Button();
      this.btnMostrar = new System.Windows.Forms.Button();
      this.btnEliminar = new System.Windows.Forms.Button();
      this.btnModificar = new System.Windows.Forms.Button();
      this.lblTitulo = new System.Windows.Forms.Label();
      this.lstAlumnos = new System.Windows.Forms.ListView();
      this.SuspendLayout();
      // 
      // btnAgregar
      // 
      this.btnAgregar.Location = new System.Drawing.Point(976, 78);
      this.btnAgregar.Margin = new System.Windows.Forms.Padding(4);
      this.btnAgregar.Name = "btnAgregar";
      this.btnAgregar.Size = new System.Drawing.Size(112, 34);
      this.btnAgregar.TabIndex = 0;
      this.btnAgregar.Text = "Agregar";
      this.btnAgregar.UseVisualStyleBackColor = true;
      this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
      // 
      // btnMostrar
      // 
      this.btnMostrar.Location = new System.Drawing.Point(736, 78);
      this.btnMostrar.Margin = new System.Windows.Forms.Padding(4);
      this.btnMostrar.Name = "btnMostrar";
      this.btnMostrar.Size = new System.Drawing.Size(112, 34);
      this.btnMostrar.TabIndex = 1;
      this.btnMostrar.Text = "Ver todos";
      this.btnMostrar.UseVisualStyleBackColor = true;
      // 
      // btnEliminar
      // 
      this.btnEliminar.Location = new System.Drawing.Point(976, 562);
      this.btnEliminar.Margin = new System.Windows.Forms.Padding(4);
      this.btnEliminar.Name = "btnEliminar";
      this.btnEliminar.Size = new System.Drawing.Size(112, 34);
      this.btnEliminar.TabIndex = 2;
      this.btnEliminar.Text = "Eliminar";
      this.btnEliminar.UseVisualStyleBackColor = true;
      // 
      // btnModificar
      // 
      this.btnModificar.Location = new System.Drawing.Point(856, 78);
      this.btnModificar.Margin = new System.Windows.Forms.Padding(4);
      this.btnModificar.Name = "btnModificar";
      this.btnModificar.Size = new System.Drawing.Size(112, 34);
      this.btnModificar.TabIndex = 3;
      this.btnModificar.Text = "Modificar";
      this.btnModificar.UseVisualStyleBackColor = true;
      this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
      // 
      // lblTitulo
      // 
      this.lblTitulo.AutoSize = true;
      this.lblTitulo.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblTitulo.Location = new System.Drawing.Point(112, 9);
      this.lblTitulo.Name = "lblTitulo";
      this.lblTitulo.Size = new System.Drawing.Size(269, 32);
      this.lblTitulo.TabIndex = 4;
      this.lblTitulo.Text = "Modulo de Alumnos";
      // 
      // lstAlumnos
      // 
      this.lstAlumnos.FullRowSelect = true;
      this.lstAlumnos.GridLines = true;
      this.lstAlumnos.HideSelection = false;
      this.lstAlumnos.Location = new System.Drawing.Point(13, 119);
      this.lstAlumnos.Name = "lstAlumnos";
      this.lstAlumnos.Size = new System.Drawing.Size(1076, 436);
      this.lstAlumnos.TabIndex = 5;
      this.lstAlumnos.UseCompatibleStateImageBehavior = false;
      // 
      // frmAlumno
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1101, 609);
      this.Controls.Add(this.lstAlumnos);
      this.Controls.Add(this.lblTitulo);
      this.Controls.Add(this.btnModificar);
      this.Controls.Add(this.btnEliminar);
      this.Controls.Add(this.btnMostrar);
      this.Controls.Add(this.btnAgregar);
      this.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.Margin = new System.Windows.Forms.Padding(4);
      this.Name = "frmAlumno";
      this.Text = "Alumno";
            this.Load += new System.EventHandler(this.frmAlumno_Load);
            this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button btnAgregar;
    private System.Windows.Forms.Button btnMostrar;
    private System.Windows.Forms.Button btnEliminar;
    private System.Windows.Forms.Button btnModificar;
    private System.Windows.Forms.Label lblTitulo;
    private System.Windows.Forms.ListView lstAlumnos;
  }
}

