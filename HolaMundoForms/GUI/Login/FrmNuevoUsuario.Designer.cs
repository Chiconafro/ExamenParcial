namespace HolaMundoForms
{
    partial class NuevoUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NuevoUsuario));
            this.NuevoUsusario = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.CB_2 = new System.Windows.Forms.ComboBox();
            this.btnsalir = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // NuevoUsusario
            // 
            this.NuevoUsusario.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NuevoUsusario.Location = new System.Drawing.Point(13, 13);
            this.NuevoUsusario.Name = "NuevoUsusario";
            this.NuevoUsusario.Size = new System.Drawing.Size(146, 32);
            this.NuevoUsusario.TabIndex = 0;
            this.NuevoUsusario.Text = "Ususario";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Contraseña";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(283, 32);
            this.label2.TabIndex = 2;
            this.label2.Text = "Repetir Contraseña";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(224, 32);
            this.label3.TabIndex = 3;
            this.label3.Text = "Email";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 217);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(224, 32);
            this.label4.TabIndex = 4;
            this.label4.Text = "Tipo de usuario";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(367, 13);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(336, 38);
            this.textBox1.TabIndex = 5;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(367, 61);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(336, 38);
            this.textBox2.TabIndex = 6;
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(367, 110);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(336, 38);
            this.textBox3.TabIndex = 7;
            // 
            // textBox4
            // 
            this.textBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.Location = new System.Drawing.Point(367, 166);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(336, 38);
            this.textBox4.TabIndex = 8;
            // 
            // CB_2
            // 
            this.CB_2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CB_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CB_2.FormattingEnabled = true;
            this.CB_2.Items.AddRange(new object[] {
            "Vendedor",
            "Administrador"});
            this.CB_2.Location = new System.Drawing.Point(367, 223);
            this.CB_2.Name = "CB_2";
            this.CB_2.Size = new System.Drawing.Size(336, 39);
            this.CB_2.TabIndex = 9;
            // 
            // btnsalir
            // 
            this.btnsalir.BackColor = System.Drawing.Color.Transparent;
            this.btnsalir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnsalir.BackgroundImage")));
            this.btnsalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnsalir.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnsalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsalir.ForeColor = System.Drawing.Color.Transparent;
            this.btnsalir.Location = new System.Drawing.Point(1009, 13);
            this.btnsalir.Margin = new System.Windows.Forms.Padding(4);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(64, 64);
            this.btnsalir.TabIndex = 23;
            this.btnsalir.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.Transparent;
            this.button1.Location = new System.Drawing.Point(722, 317);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(64, 64);
            this.button1.TabIndex = 24;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // NuevoUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1086, 566);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnsalir);
            this.Controls.Add(this.CB_2);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NuevoUsusario);
            this.ForeColor = System.Drawing.Color.DarkOrange;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "NuevoUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro";
            this.Load += new System.EventHandler(this.NuevoUsuario_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NuevoUsusario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.ComboBox CB_2;
        private System.Windows.Forms.Button btnsalir;
        private System.Windows.Forms.Button button1;
    }
}