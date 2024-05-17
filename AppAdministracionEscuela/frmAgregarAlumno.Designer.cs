namespace AppAdministracionEscuela
{
  partial class frmAgregarAlumno
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this.btnAgregar = new System.Windows.Forms.Button();
      this.label1 = new System.Windows.Forms.Label();
      this.txtMatricula = new System.Windows.Forms.TextBox();
      this.txtCarrera = new System.Windows.Forms.TextBox();
      this.label2 = new System.Windows.Forms.Label();
      this.txtSemestre = new System.Windows.Forms.TextBox();
      this.label3 = new System.Windows.Forms.Label();
      this.txtCargaAcademica = new System.Windows.Forms.TextBox();
      this.label4 = new System.Windows.Forms.Label();
      this.label5 = new System.Windows.Forms.Label();
      this.LblNombre = new System.Windows.Forms.Label();
      this.SuspendLayout();
      // 
      // btnAgregar
      // 
      this.btnAgregar.DialogResult = System.Windows.Forms.DialogResult.OK;
      this.btnAgregar.Location = new System.Drawing.Point(639, 371);
      this.btnAgregar.Name = "btnAgregar";
      this.btnAgregar.Size = new System.Drawing.Size(149, 67);
      this.btnAgregar.TabIndex = 1;
      this.btnAgregar.Text = "Aceptar";
      this.btnAgregar.UseVisualStyleBackColor = true;
      this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(17, 73);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(50, 13);
      this.label1.TabIndex = 2;
      this.label1.Text = "Matricula";
      // 
      // txtMatricula
      // 
      this.txtMatricula.Location = new System.Drawing.Point(107, 70);
      this.txtMatricula.Name = "txtMatricula";
      this.txtMatricula.Size = new System.Drawing.Size(100, 20);
      this.txtMatricula.TabIndex = 3;
      // 
      // txtCarrera
      // 
      this.txtCarrera.Location = new System.Drawing.Point(107, 96);
      this.txtCarrera.Name = "txtCarrera";
      this.txtCarrera.Size = new System.Drawing.Size(100, 20);
      this.txtCarrera.TabIndex = 5;
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(17, 99);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(41, 13);
      this.label2.TabIndex = 4;
      this.label2.Text = "Carrera";
      // 
      // txtSemestre
      // 
      this.txtSemestre.Location = new System.Drawing.Point(107, 122);
      this.txtSemestre.Name = "txtSemestre";
      this.txtSemestre.Size = new System.Drawing.Size(100, 20);
      this.txtSemestre.TabIndex = 7;
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(17, 125);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(51, 13);
      this.label3.TabIndex = 6;
      this.label3.Text = "Semestre";
      // 
      // txtCargaAcademica
      // 
      this.txtCargaAcademica.Location = new System.Drawing.Point(107, 148);
      this.txtCargaAcademica.Name = "txtCargaAcademica";
      this.txtCargaAcademica.Size = new System.Drawing.Size(100, 20);
      this.txtCargaAcademica.TabIndex = 9;
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Location = new System.Drawing.Point(17, 151);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(91, 13);
      this.label4.TabIndex = 8;
      this.label4.Text = "Carga Academica";
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label5.Location = new System.Drawing.Point(13, 13);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(84, 24);
      this.label5.TabIndex = 10;
      this.label5.Text = "Nombre:";
      // 
      // LblNombre
      // 
      this.LblNombre.AutoSize = true;
      this.LblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.LblNombre.Location = new System.Drawing.Point(103, 17);
      this.LblNombre.Name = "LblNombre";
      this.LblNombre.Size = new System.Drawing.Size(0, 20);
      this.LblNombre.TabIndex = 11;
      // 
      // frmAgregarAlumno
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(800, 450);
      this.Controls.Add(this.LblNombre);
      this.Controls.Add(this.label5);
      this.Controls.Add(this.txtCargaAcademica);
      this.Controls.Add(this.label4);
      this.Controls.Add(this.txtSemestre);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.txtCarrera);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.txtMatricula);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.btnAgregar);
      this.Name = "frmAgregarAlumno";
      this.Text = "frmAgregarAlumno";
      this.Load += new System.EventHandler(this.frmAgregarAlumno_Load);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion
    private System.Windows.Forms.Button btnAgregar;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.TextBox txtMatricula;
    private System.Windows.Forms.TextBox txtCarrera;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.TextBox txtSemestre;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.TextBox txtCargaAcademica;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.Label LblNombre;
  }
}