namespace interfaz_de_caja_registradora
{
    partial class Chef
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Chef));
            this.listBoxEnEspera = new System.Windows.Forms.ListBox();
            this.listBoxEnPreparacion = new System.Windows.Forms.ListBox();
            this.listBoxListo = new System.Windows.Forms.ListBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnEnPreparacion = new System.Windows.Forms.Button();
            this.btnListo = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnRegreso = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBoxEnEspera
            // 
            this.listBoxEnEspera.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxEnEspera.FormattingEnabled = true;
            this.listBoxEnEspera.HorizontalScrollbar = true;
            this.listBoxEnEspera.ItemHeight = 16;
            this.listBoxEnEspera.Location = new System.Drawing.Point(8, 115);
            this.listBoxEnEspera.Name = "listBoxEnEspera";
            this.listBoxEnEspera.Size = new System.Drawing.Size(430, 580);
            this.listBoxEnEspera.TabIndex = 0;
            // 
            // listBoxEnPreparacion
            // 
            this.listBoxEnPreparacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxEnPreparacion.FormattingEnabled = true;
            this.listBoxEnPreparacion.HorizontalScrollbar = true;
            this.listBoxEnPreparacion.ItemHeight = 16;
            this.listBoxEnPreparacion.Location = new System.Drawing.Point(441, 115);
            this.listBoxEnPreparacion.Name = "listBoxEnPreparacion";
            this.listBoxEnPreparacion.Size = new System.Drawing.Size(430, 580);
            this.listBoxEnPreparacion.TabIndex = 1;
            // 
            // listBoxListo
            // 
            this.listBoxListo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxListo.FormattingEnabled = true;
            this.listBoxListo.HorizontalScrollbar = true;
            this.listBoxListo.ItemHeight = 16;
            this.listBoxListo.Location = new System.Drawing.Point(873, 115);
            this.listBoxListo.Name = "listBoxListo";
            this.listBoxListo.Size = new System.Drawing.Size(430, 580);
            this.listBoxListo.TabIndex = 2;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 2000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnEnPreparacion
            // 
            this.btnEnPreparacion.BackColor = System.Drawing.Color.Red;
            this.btnEnPreparacion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEnPreparacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnPreparacion.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEnPreparacion.Location = new System.Drawing.Point(104, 701);
            this.btnEnPreparacion.Name = "btnEnPreparacion";
            this.btnEnPreparacion.Size = new System.Drawing.Size(173, 65);
            this.btnEnPreparacion.TabIndex = 3;
            this.btnEnPreparacion.Text = "En Preparacion";
            this.btnEnPreparacion.UseVisualStyleBackColor = false;
            this.btnEnPreparacion.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnListo
            // 
            this.btnListo.BackColor = System.Drawing.Color.Yellow;
            this.btnListo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnListo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnListo.Location = new System.Drawing.Point(540, 706);
            this.btnListo.Name = "btnListo";
            this.btnListo.Size = new System.Drawing.Size(211, 60);
            this.btnListo.TabIndex = 4;
            this.btnListo.Text = "Listo";
            this.btnListo.UseVisualStyleBackColor = false;
            this.btnListo.Click += new System.EventHandler(this.btnListo_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Lime;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(1020, 711);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(188, 55);
            this.button1.TabIndex = 5;
            this.button1.Text = "Entregar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(58)))), ((int)(((byte)(95)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.btnRegreso);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-3, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1329, 65);
            this.panel1.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(441, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(266, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cocina GordiFeliz";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(3, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 29);
            this.label3.TabIndex = 7;
            this.label3.Text = "En Espera";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(436, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(193, 29);
            this.label2.TabIndex = 8;
            this.label2.Text = "En Preparacion";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(868, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 29);
            this.label4.TabIndex = 9;
            this.label4.Text = "Listo";
            // 
            // btnRegreso
            // 
            this.btnRegreso.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnRegreso.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRegreso.BackgroundImage")));
            this.btnRegreso.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnRegreso.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegreso.FlatAppearance.BorderSize = 0;
            this.btnRegreso.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegreso.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegreso.ForeColor = System.Drawing.SystemColors.Control;
            this.btnRegreso.Location = new System.Drawing.Point(1240, 10);
            this.btnRegreso.Name = "btnRegreso";
            this.btnRegreso.Size = new System.Drawing.Size(64, 38);
            this.btnRegreso.TabIndex = 15;
            this.btnRegreso.UseVisualStyleBackColor = false;
            this.btnRegreso.Click += new System.EventHandler(this.btnRegreso_Click);
            // 
            // Chef
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1315, 788);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnListo);
            this.Controls.Add(this.btnEnPreparacion);
            this.Controls.Add(this.listBoxListo);
            this.Controls.Add(this.listBoxEnPreparacion);
            this.Controls.Add(this.listBoxEnEspera);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Chef";
            this.Text = "Chef";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxEnEspera;
        private System.Windows.Forms.ListBox listBoxEnPreparacion;
        private System.Windows.Forms.ListBox listBoxListo;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnEnPreparacion;
        private System.Windows.Forms.Button btnListo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnRegreso;
    }
}