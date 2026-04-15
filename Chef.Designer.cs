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
            this.listBoxEnEspera = new System.Windows.Forms.ListBox();
            this.listBoxEnPreparacion = new System.Windows.Forms.ListBox();
            this.listBoxListo = new System.Windows.Forms.ListBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnEnPreparacion = new System.Windows.Forms.Button();
            this.btnListo = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // listBoxEnEspera
            // 
            this.listBoxEnEspera.FormattingEnabled = true;
            this.listBoxEnEspera.HorizontalScrollbar = true;
            this.listBoxEnEspera.ItemHeight = 16;
            this.listBoxEnEspera.Location = new System.Drawing.Point(10, 102);
            this.listBoxEnEspera.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listBoxEnEspera.Name = "listBoxEnEspera";
            this.listBoxEnEspera.Size = new System.Drawing.Size(373, 372);
            this.listBoxEnEspera.TabIndex = 0;
            // 
            // listBoxEnPreparacion
            // 
            this.listBoxEnPreparacion.FormattingEnabled = true;
            this.listBoxEnPreparacion.HorizontalScrollbar = true;
            this.listBoxEnPreparacion.ItemHeight = 16;
            this.listBoxEnPreparacion.Location = new System.Drawing.Point(389, 102);
            this.listBoxEnPreparacion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listBoxEnPreparacion.Name = "listBoxEnPreparacion";
            this.listBoxEnPreparacion.Size = new System.Drawing.Size(373, 372);
            this.listBoxEnPreparacion.TabIndex = 1;
            // 
            // listBoxListo
            // 
            this.listBoxListo.FormattingEnabled = true;
            this.listBoxListo.HorizontalScrollbar = true;
            this.listBoxListo.ItemHeight = 16;
            this.listBoxListo.Location = new System.Drawing.Point(772, 101);
            this.listBoxListo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listBoxListo.Name = "listBoxListo";
            this.listBoxListo.Size = new System.Drawing.Size(373, 372);
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
            this.btnEnPreparacion.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEnPreparacion.Location = new System.Drawing.Point(116, 503);
            this.btnEnPreparacion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEnPreparacion.Name = "btnEnPreparacion";
            this.btnEnPreparacion.Size = new System.Drawing.Size(145, 52);
            this.btnEnPreparacion.TabIndex = 3;
            this.btnEnPreparacion.Text = "En Preparacion";
            this.btnEnPreparacion.UseVisualStyleBackColor = false;
            this.btnEnPreparacion.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnListo
            // 
            this.btnListo.BackColor = System.Drawing.Color.Lime;
            this.btnListo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnListo.Location = new System.Drawing.Point(520, 503);
            this.btnListo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnListo.Name = "btnListo";
            this.btnListo.Size = new System.Drawing.Size(137, 52);
            this.btnListo.TabIndex = 4;
            this.btnListo.Text = "Listo";
            this.btnListo.UseVisualStyleBackColor = false;
            this.btnListo.Click += new System.EventHandler(this.btnListo_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Yellow;
            this.button1.Location = new System.Drawing.Point(891, 503);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(137, 52);
            this.button1.TabIndex = 5;
            this.button1.Text = "Entregar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(58)))), ((int)(((byte)(95)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Location = new System.Drawing.Point(-4, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1168, 79);
            this.panel1.TabIndex = 6;
            // 
            // Chef
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1152, 608);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnListo);
            this.Controls.Add(this.btnEnPreparacion);
            this.Controls.Add(this.listBoxListo);
            this.Controls.Add(this.listBoxEnPreparacion);
            this.Controls.Add(this.listBoxEnEspera);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Chef";
            this.Text = "Chef";
            this.ResumeLayout(false);

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
    }
}