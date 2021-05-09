
namespace Lab_1_zad_1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.labely = new System.Windows.Forms.Label();
            this.labelx = new System.Windows.Forms.Label();
            this.labelwynik = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBoxWynik = new System.Windows.Forms.TextBox();
            this.Suma = new System.Windows.Forms.Button();
            this.Iloczyn = new System.Windows.Forms.Button();
            this.Wyjście = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(168, 149);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "x";
            // 
            // labely
            // 
            this.labely.AutoSize = true;
            this.labely.Location = new System.Drawing.Point(168, 178);
            this.labely.Name = "labely";
            this.labely.Size = new System.Drawing.Size(13, 15);
            this.labely.TabIndex = 1;
            this.labely.Text = "y";
            this.labely.Click += new System.EventHandler(this.y_Click);
            // 
            // labelx
            // 
            this.labelx.AutoSize = true;
            this.labelx.Location = new System.Drawing.Point(169, 207);
            this.labelx.Name = "labelx";
            this.labelx.Size = new System.Drawing.Size(12, 15);
            this.labelx.TabIndex = 2;
            this.labelx.Text = "z";
            // 
            // labelwynik
            // 
            this.labelwynik.AutoSize = true;
            this.labelwynik.Location = new System.Drawing.Point(143, 239);
            this.labelwynik.Name = "labelwynik";
            this.labelwynik.Size = new System.Drawing.Size(38, 15);
            this.labelwynik.TabIndex = 3;
            this.labelwynik.Text = "wynik";
            this.labelwynik.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(187, 149);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 23);
            this.textBox1.TabIndex = 4;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(187, 178);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 23);
            this.textBox2.TabIndex = 4;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(187, 207);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 23);
            this.textBox3.TabIndex = 4;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // textBoxWynik
            // 
            this.textBoxWynik.Location = new System.Drawing.Point(187, 236);
            this.textBoxWynik.Name = "textBoxWynik";
            this.textBoxWynik.Size = new System.Drawing.Size(100, 23);
            this.textBoxWynik.TabIndex = 4;
            this.textBoxWynik.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // Suma
            // 
            this.Suma.Location = new System.Drawing.Point(323, 162);
            this.Suma.Name = "Suma";
            this.Suma.Size = new System.Drawing.Size(75, 23);
            this.Suma.TabIndex = 5;
            this.Suma.Text = "Suma";
            this.Suma.UseVisualStyleBackColor = true;
            this.Suma.Click += new System.EventHandler(this.Suma_Click);
            // 
            // Iloczyn
            // 
            this.Iloczyn.Location = new System.Drawing.Point(323, 191);
            this.Iloczyn.Name = "Iloczyn";
            this.Iloczyn.Size = new System.Drawing.Size(75, 23);
            this.Iloczyn.TabIndex = 5;
            this.Iloczyn.Text = "Iloczyn";
            this.Iloczyn.UseVisualStyleBackColor = true;
            this.Iloczyn.Click += new System.EventHandler(this.Iloczyn_Click);
            // 
            // Wyjście
            // 
            this.Wyjście.Location = new System.Drawing.Point(323, 220);
            this.Wyjście.Name = "Wyjście";
            this.Wyjście.Size = new System.Drawing.Size(75, 23);
            this.Wyjście.TabIndex = 5;
            this.Wyjście.Text = "Wyjście";
            this.Wyjście.UseVisualStyleBackColor = true;
            this.Wyjście.Click += new System.EventHandler(this.Wyjście_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Wyjście);
            this.Controls.Add(this.Iloczyn);
            this.Controls.Add(this.Suma);
            this.Controls.Add(this.textBoxWynik);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.labelwynik);
            this.Controls.Add(this.labelx);
            this.Controls.Add(this.labely);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Matematyka";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labely;
        private System.Windows.Forms.Label labelx;
        private System.Windows.Forms.Label labelwynik;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBoxWynik;
        private System.Windows.Forms.Button Suma;
        private System.Windows.Forms.Button Iloczyn;
        private System.Windows.Forms.Button Wyjście;
    }
}

