namespace Convertidor
{
	partial class MainForm
	{
		
		private System.ComponentModel.IContainer components = null;
		
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.Label1 = new System.Windows.Forms.Label();
			this.Label2 = new System.Windows.Forms.Label();
			this.Label3 = new System.Windows.Forms.Label();
			this.peso = new System.Windows.Forms.TextBox();
			this.dolar = new System.Windows.Forms.TextBox();
			this.tasa = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// Label1
			// 
			this.Label1.BackColor = System.Drawing.Color.Transparent;
			this.Label1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Label1.ForeColor = System.Drawing.Color.Black;
			this.Label1.Location = new System.Drawing.Point(52, 34);
			this.Label1.Name = "Label1";
			this.Label1.Size = new System.Drawing.Size(149, 23);
			this.Label1.TabIndex = 0;
			this.Label1.Text = "Pesos (MX)";
			this.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// Label2
			// 
			this.Label2.BackColor = System.Drawing.Color.Transparent;
			this.Label2.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Label2.Location = new System.Drawing.Point(57, 123);
			this.Label2.Name = "Label2";
			this.Label2.Size = new System.Drawing.Size(144, 23);
			this.Label2.TabIndex = 1;
			this.Label2.Text = "Dolares (US)";
			this.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// Label3
			// 
			this.Label3.BackColor = System.Drawing.Color.Transparent;
			this.Label3.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Label3.Location = new System.Drawing.Point(247, 34);
			this.Label3.Name = "Label3";
			this.Label3.Size = new System.Drawing.Size(222, 23);
			this.Label3.TabIndex = 2;
			this.Label3.Text = "Tasa de Cambio (flexible)";
			this.Label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// peso
			// 
			this.peso.AcceptsTab = true;
			this.peso.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.peso.Location = new System.Drawing.Point(75, 60);
			this.peso.Name = "peso";
			this.peso.Size = new System.Drawing.Size(100, 22);
			this.peso.TabIndex = 3;
			this.peso.Text = "0.0";
			this.peso.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// dolar
			// 
			this.dolar.Enabled = false;
			this.dolar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dolar.Location = new System.Drawing.Point(75, 149);
			this.dolar.Name = "dolar";
			this.dolar.Size = new System.Drawing.Size(100, 22);
			this.dolar.TabIndex = 4;
			this.dolar.Text = "0.0";
			this.dolar.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// tasa
			// 
			this.tasa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tasa.Location = new System.Drawing.Point(298, 60);
			this.tasa.Name = "tasa";
			this.tasa.Size = new System.Drawing.Size(126, 22);
			this.tasa.TabIndex = 5;
			this.tasa.Text = "12.8454 ";
			this.tasa.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.Color.Transparent;
			this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
			this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
			this.button1.ForeColor = System.Drawing.Color.Transparent;
			this.button1.Location = new System.Drawing.Point(366, 112);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(77, 77);
			this.button1.TabIndex = 6;
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.ClientSize = new System.Drawing.Size(498, 210);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.tasa);
			this.Controls.Add(this.dolar);
			this.Controls.Add(this.peso);
			this.Controls.Add(this.Label3);
			this.Controls.Add(this.Label2);
			this.Controls.Add(this.Label1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "MainForm";
			this.Text = "Convertidor de Pesos(MX) a Dolares(US)";
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.TextBox tasa;
		private System.Windows.Forms.TextBox dolar;
		private System.Windows.Forms.TextBox peso;
		private System.Windows.Forms.Label Label3;
		private System.Windows.Forms.Label Label2;
		private System.Windows.Forms.Label Label1;
		
		
	}
}
