namespace AppFiguraGeometrica
{
  partial class frmCirculo
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
      this.btnCalcular = new System.Windows.Forms.Button();
      this.nudRadio = new System.Windows.Forms.NumericUpDown();
      this.lblRadio = new System.Windows.Forms.Label();
      ((System.ComponentModel.ISupportInitialize)(this.nudRadio)).BeginInit();
      this.SuspendLayout();
      // 
      // btnCalcular
      // 
      this.btnCalcular.Location = new System.Drawing.Point(176, 113);
      this.btnCalcular.Name = "btnCalcular";
      this.btnCalcular.Size = new System.Drawing.Size(75, 23);
      this.btnCalcular.TabIndex = 0;
      this.btnCalcular.Text = "Calcular";
      this.btnCalcular.UseVisualStyleBackColor = true;
      this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
      // 
      // nudRadio
      // 
      this.nudRadio.Location = new System.Drawing.Point(131, 87);
      this.nudRadio.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
      this.nudRadio.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
      this.nudRadio.Name = "nudRadio";
      this.nudRadio.Size = new System.Drawing.Size(120, 20);
      this.nudRadio.TabIndex = 1;
      this.nudRadio.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
      // 
      // lblRadio
      // 
      this.lblRadio.AutoSize = true;
      this.lblRadio.Location = new System.Drawing.Point(46, 89);
      this.lblRadio.Name = "lblRadio";
      this.lblRadio.Size = new System.Drawing.Size(79, 13);
      this.lblRadio.TabIndex = 2;
      this.lblRadio.Text = "Ingresa el radio";
      // 
      // frmCirculo
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(343, 206);
      this.Controls.Add(this.lblRadio);
      this.Controls.Add(this.nudRadio);
      this.Controls.Add(this.btnCalcular);
      this.Name = "frmCirculo";
      this.Text = "Calcula el area de un circulo";
      ((System.ComponentModel.ISupportInitialize)(this.nudRadio)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button btnCalcular;
    private System.Windows.Forms.NumericUpDown nudRadio;
    private System.Windows.Forms.Label lblRadio;
  }
}