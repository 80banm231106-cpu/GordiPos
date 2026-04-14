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
            this.SuspendLayout();
            // 
            // listBoxEnEspera
            // 
            this.listBoxEnEspera.FormattingEnabled = true;
            this.listBoxEnEspera.HorizontalScrollbar = true;
            this.listBoxEnEspera.Location = new System.Drawing.Point(10, 13);
            this.listBoxEnEspera.Name = "listBoxEnEspera";
            this.listBoxEnEspera.Size = new System.Drawing.Size(281, 303);
            this.listBoxEnEspera.TabIndex = 0;
            // 
            // listBoxEnPreparacion
            // 
            this.listBoxEnPreparacion.FormattingEnabled = true;
            this.listBoxEnPreparacion.HorizontalScrollbar = true;
            this.listBoxEnPreparacion.Location = new System.Drawing.Point(294, 13);
            this.listBoxEnPreparacion.Name = "listBoxEnPreparacion";
            this.listBoxEnPreparacion.Size = new System.Drawing.Size(281, 303);
            this.listBoxEnPreparacion.TabIndex = 1;
            // 
            // listBoxListo
            // 
            this.listBoxListo.FormattingEnabled = true;
            this.listBoxListo.HorizontalScrollbar = true;
            this.listBoxListo.Location = new System.Drawing.Point(581, 12);
            this.listBoxListo.Name = "listBoxListo";
            this.listBoxListo.Size = new System.Drawing.Size(281, 303);
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
            this.btnEnPreparacion.Location = new System.Drawing.Point(121, 358);
            this.btnEnPreparacion.Name = "btnEnPreparacion";
            this.btnEnPreparacion.Size = new System.Drawing.Size(109, 42);
            this.btnEnPreparacion.TabIndex = 3;
            this.btnEnPreparacion.Text = "En Preparacion";
            this.btnEnPreparacion.UseVisualStyleBackColor = false;
            this.btnEnPreparacion.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnListo
            // 
            this.btnListo.BackColor = System.Drawing.Color.Lime;
            this.btnListo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnListo.Location = new System.Drawing.Point(390, 358);
            this.btnListo.Name = "btnListo";
            this.btnListo.Size = new System.Drawing.Size(103, 42);
            this.btnListo.TabIndex = 4;
            this.btnListo.Text = "Listo";
            this.btnListo.UseVisualStyleBackColor = false;
            this.btnListo.Click += new System.EventHandler(this.btnListo_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Yellow;
            this.button1.Location = new System.Drawing.Point(639, 358);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(103, 42);
            this.button1.TabIndex = 5;
            this.button1.Text = "Entregar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Chef
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(864, 494);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnListo);
            this.Controls.Add(this.btnEnPreparacion);
            this.Controls.Add(this.listBoxListo);
            this.Controls.Add(this.listBoxEnPreparacion);
            this.Controls.Add(this.listBoxEnEspera);
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
    }
}