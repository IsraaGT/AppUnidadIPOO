namespace AppFiguraGeometrica
{
  partial class frmTriangulo
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
      this.lblBase = new System.Windows.Forms.Label();
      this.nudBase = new System.Windows.Forms.NumericUpDown();
      this.btnCalcular = new System.Windows.Forms.Button();
      this.lblAltura = new System.Windows.Forms.Label();
      this.nudAltura = new System.Windows.Forms.NumericUpDown();
      ((System.ComponentModel.ISupportInitialize)(this.nudBase)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.nudAltura)).BeginInit();
      this.SuspendLayout();
      // 
      // lblBase
      // 
      this.lblBase.AutoSize = true;
      this.lblBase.Location = new System.Drawing.Point(298, 203);
      this.lblBase.Name = "lblBase";
      this.lblBase.Size = new System.Drawing.Size(79, 13);
      this.lblBase.TabIndex = 5;
      this.lblBase.Text = "Ingresa la base";
      // 
      // nudBase
      // 
      this.nudBase.Location = new System.Drawing.Point(383, 201);
      this.nudBase.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
      this.nudBase.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
      this.nudBase.Name = "nudBase";
      this.nudBase.Size = new System.Drawing.Size(120, 20);
      this.nudBase.TabIndex = 4;
      this.nudBase.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
      // 
      // btnCalcular
      // 
      this.btnCalcular.Location = new System.Drawing.Point(446, 297);
      this.btnCalcular.Name = "btnCalcular";
      this.btnCalcular.Size = new System.Drawing.Size(75, 23);
      this.btnCalcular.TabIndex = 3;
      this.btnCalcular.Text = "Calcular";
      this.btnCalcular.UseVisualStyleBackColor = true;
      this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
      // 
      // lblAltura
      // 
      this.lblAltura.AutoSize = true;
      this.lblAltura.Location = new System.Drawing.Point(298, 229);
      this.lblAltura.Name = "lblAltura";
      this.lblAltura.Size = new System.Drawing.Size(82, 13);
      this.lblAltura.TabIndex = 7;
      this.lblAltura.Text = "Ingresa la altura";
      // 
      // nudAltura
      // 
      this.nudAltura.Location = new System.Drawing.Point(383, 227);
      this.nudAltura.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
      this.nudAltura.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
      this.nudAltura.Name = "nudAltura";
      this.nudAltura.Size = new System.Drawing.Size(120, 20);
      this.nudAltura.TabIndex = 6;
      this.nudAltura.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
      // 
      // frmTriangulo
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(800, 450);
      this.Controls.Add(this.lblAltura);
      this.Controls.Add(this.nudAltura);
      this.Controls.Add(this.lblBase);
      this.Controls.Add(this.nudBase);
      this.Controls.Add(this.btnCalcular);
      this.Name = "frmTriangulo";
      this.Text = "frmTriangulo";
      ((System.ComponentModel.ISupportInitialize)(this.nudBase)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.nudAltura)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label lblBase;
    private System.Windows.Forms.NumericUpDown nudBase;
    private System.Windows.Forms.Button btnCalcular;
    private System.Windows.Forms.Label lblAltura;
    private System.Windows.Forms.NumericUpDown nudAltura;
  }
}