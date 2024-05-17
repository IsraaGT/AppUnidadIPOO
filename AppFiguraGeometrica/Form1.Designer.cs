namespace AppFiguraGeometrica
{
  partial class Form1
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
      this.btnCirculo = new System.Windows.Forms.Button();
      this.btnTriangulo = new System.Windows.Forms.Button();
      this.btnCuadrado = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // btnCirculo
      // 
      this.btnCirculo.Location = new System.Drawing.Point(12, 13);
      this.btnCirculo.Name = "btnCirculo";
      this.btnCirculo.Size = new System.Drawing.Size(191, 70);
      this.btnCirculo.TabIndex = 0;
      this.btnCirculo.Text = "Circulo";
      this.btnCirculo.UseVisualStyleBackColor = true;
      this.btnCirculo.Click += new System.EventHandler(this.btnCirculo_Click);
      // 
      // btnTriangulo
      // 
      this.btnTriangulo.Location = new System.Drawing.Point(209, 13);
      this.btnTriangulo.Name = "btnTriangulo";
      this.btnTriangulo.Size = new System.Drawing.Size(191, 70);
      this.btnTriangulo.TabIndex = 1;
      this.btnTriangulo.Text = "Triangulo";
      this.btnTriangulo.UseVisualStyleBackColor = true;
      this.btnTriangulo.Click += new System.EventHandler(this.btnTriangulo_Click);
      // 
      // btnCuadrado
      // 
      this.btnCuadrado.Location = new System.Drawing.Point(412, 12);
      this.btnCuadrado.Name = "btnCuadrado";
      this.btnCuadrado.Size = new System.Drawing.Size(191, 70);
      this.btnCuadrado.TabIndex = 2;
      this.btnCuadrado.Text = "Cuadrado";
      this.btnCuadrado.UseVisualStyleBackColor = true;
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(643, 265);
      this.Controls.Add(this.btnCuadrado);
      this.Controls.Add(this.btnTriangulo);
      this.Controls.Add(this.btnCirculo);
      this.Name = "Form1";
      this.Text = "Form1";
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Button btnCirculo;
    private System.Windows.Forms.Button btnTriangulo;
    private System.Windows.Forms.Button btnCuadrado;
  }
}

