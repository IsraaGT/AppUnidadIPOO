namespace AppUnidadIPOO
{
  partial class frmSuma
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
      this.btnSumar = new System.Windows.Forms.Button();
      this.lblNumeroUno = new System.Windows.Forms.Label();
      this.txtNumeroUno = new System.Windows.Forms.TextBox();
      this.lblNumeroDos = new System.Windows.Forms.Label();
      this.txtNumeroDos = new System.Windows.Forms.TextBox();
      this.btnRestar = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // btnSumar
      // 
      this.btnSumar.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
      this.btnSumar.Location = new System.Drawing.Point(166, 86);
      this.btnSumar.Name = "btnSumar";
      this.btnSumar.Size = new System.Drawing.Size(136, 48);
      this.btnSumar.TabIndex = 0;
      this.btnSumar.Text = "Sumar";
      this.btnSumar.UseVisualStyleBackColor = false;
      this.btnSumar.Click += new System.EventHandler(this.btnSumar_Click);
      // 
      // lblNumeroUno
      // 
      this.lblNumeroUno.AutoSize = true;
      this.lblNumeroUno.Location = new System.Drawing.Point(12, 15);
      this.lblNumeroUno.Name = "lblNumeroUno";
      this.lblNumeroUno.Size = new System.Drawing.Size(184, 18);
      this.lblNumeroUno.TabIndex = 2;
      this.lblNumeroUno.Text = "Ingresa el primer numero:";
      // 
      // txtNumeroUno
      // 
      this.txtNumeroUno.Location = new System.Drawing.Point(202, 12);
      this.txtNumeroUno.Name = "txtNumeroUno";
      this.txtNumeroUno.Size = new System.Drawing.Size(100, 26);
      this.txtNumeroUno.TabIndex = 3;
      // 
      // lblNumeroDos
      // 
      this.lblNumeroDos.AutoSize = true;
      this.lblNumeroDos.Location = new System.Drawing.Point(1, 47);
      this.lblNumeroDos.Name = "lblNumeroDos";
      this.lblNumeroDos.Size = new System.Drawing.Size(199, 18);
      this.lblNumeroDos.TabIndex = 4;
      this.lblNumeroDos.Text = "Ingresa el segundo numero:";
      // 
      // txtNumeroDos
      // 
      this.txtNumeroDos.Location = new System.Drawing.Point(202, 44);
      this.txtNumeroDos.Name = "txtNumeroDos";
      this.txtNumeroDos.Size = new System.Drawing.Size(100, 26);
      this.txtNumeroDos.TabIndex = 5;
      // 
      // btnRestar
      // 
      this.btnRestar.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
      this.btnRestar.Location = new System.Drawing.Point(4, 86);
      this.btnRestar.Name = "btnRestar";
      this.btnRestar.Size = new System.Drawing.Size(136, 48);
      this.btnRestar.TabIndex = 6;
      this.btnRestar.Text = "Restar";
      this.btnRestar.UseVisualStyleBackColor = false;
      this.btnRestar.Click += new System.EventHandler(this.btnRestar_Click);
      // 
      // frmSuma
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
      this.ClientSize = new System.Drawing.Size(404, 235);
      this.Controls.Add(this.btnRestar);
      this.Controls.Add(this.txtNumeroDos);
      this.Controls.Add(this.lblNumeroDos);
      this.Controls.Add(this.txtNumeroUno);
      this.Controls.Add(this.lblNumeroUno);
      this.Controls.Add(this.btnSumar);
      this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
      this.Margin = new System.Windows.Forms.Padding(4);
      this.Name = "frmSuma";
      this.Text = "Form1";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button btnSumar;
    private System.Windows.Forms.Label lblNumeroUno;
    private System.Windows.Forms.TextBox txtNumeroUno;
    private System.Windows.Forms.Label lblNumeroDos;
    private System.Windows.Forms.TextBox txtNumeroDos;
    private System.Windows.Forms.Button btnRestar;
  }
}

