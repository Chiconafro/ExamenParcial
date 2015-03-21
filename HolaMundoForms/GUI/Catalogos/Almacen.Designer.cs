namespace HolaMundoForms.Catalogos
{
    partial class Almacen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Almacen));
            this.NuevoUsusario = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.no_almacen = new System.Windows.Forms.NumericUpDown();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.numericUpDown3 = new System.Windows.Forms.NumericUpDown();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.no_almacen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).BeginInit();
            this.SuspendLayout();
            // 
            // NuevoUsusario
            // 
            this.NuevoUsusario.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NuevoUsusario.Location = new System.Drawing.Point(107, 19);
            this.NuevoUsusario.Name = "NuevoUsusario";
            this.NuevoUsusario.Size = new System.Drawing.Size(180, 32);
            this.NuevoUsusario.TabIndex = 98;
            this.NuevoUsusario.Text = "No. Almacen";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 380);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(824, 105);
            this.panel1.TabIndex = 97;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.RoyalBlue;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.RoyalBlue;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(104, 21);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(65, 65);
            this.button1.TabIndex = 117;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Transparent;
            this.button3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button3.BackgroundImage")));
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ForeColor = System.Drawing.Color.RoyalBlue;
            this.button3.Location = new System.Drawing.Point(23, 21);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(65, 65);
            this.button3.TabIndex = 27;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // no_almacen
            // 
            this.no_almacen.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F);
            this.no_almacen.Location = new System.Drawing.Point(372, 19);
            this.no_almacen.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.no_almacen.Name = "no_almacen";
            this.no_almacen.Size = new System.Drawing.Size(120, 38);
            this.no_almacen.TabIndex = 110;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(372, 207);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(336, 38);
            this.textBox1.TabIndex = 112;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 207);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(270, 32);
            this.label1.TabIndex = 111;
            this.label1.Text = "Código del Producto";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(155, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 32);
            this.label2.TabIndex = 113;
            this.label2.Text = "Cantidad";
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F);
            this.numericUpDown2.Location = new System.Drawing.Point(372, 72);
            this.numericUpDown2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numericUpDown2.Maximum = new decimal(new int[] {
            150,
            0,
            0,
            0});
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(120, 38);
            this.numericUpDown2.TabIndex = 114;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(98, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(189, 32);
            this.label3.TabIndex = 115;
            this.label3.Text = "Stock Minimo";
            // 
            // numericUpDown3
            // 
            this.numericUpDown3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F);
            this.numericUpDown3.Location = new System.Drawing.Point(372, 131);
            this.numericUpDown3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numericUpDown3.Maximum = new decimal(new int[] {
            150,
            0,
            0,
            0});
            this.numericUpDown3.Name = "numericUpDown3";
            this.numericUpDown3.Size = new System.Drawing.Size(120, 38);
            this.numericUpDown3.TabIndex = 116;
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.ForeColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(582, 38);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(128, 128);
            this.panel2.TabIndex = 117;
            // 
            // Almacen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(824, 485);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.numericUpDown3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.numericUpDown2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.no_almacen);
            this.Controls.Add(this.NuevoUsusario);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Almacen";
            this.Text = "Almacen";
            this.Load += new System.EventHandler(this.Almacen_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.no_almacen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NuevoUsusario;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.NumericUpDown no_almacen;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numericUpDown3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel2;
    }
}