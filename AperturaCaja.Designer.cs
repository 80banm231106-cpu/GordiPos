namespace interfaz_de_caja_registradora
{
    partial class AperturaCaja
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtFondoApertura = new System.Windows.Forms.TextBox();
            this.btnAbrirCaja = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 98);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(387, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingrese fondo inicial de caja:";
            // 
            // txtFondoApertura
            // 
            this.txtFondoApertura.Location = new System.Drawing.Point(131, 165);
            this.txtFondoApertura.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtFondoApertura.Name = "txtFondoApertura";
            this.txtFondoApertura.Size = new System.Drawing.Size(184, 22);
            this.txtFondoApertura.TabIndex = 1;
            // 
            // btnAbrirCaja
            // 
            this.btnAbrirCaja.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAbrirCaja.Location = new System.Drawing.Point(131, 230);
            this.btnAbrirCaja.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAbrirCaja.Name = "btnAbrirCaja";
            this.btnAbrirCaja.Size = new System.Drawing.Size(185, 87);
            this.btnAbrirCaja.TabIndex = 2;
            this.btnAbrirCaja.Text = "Comenzar turno";
            this.btnAbrirCaja.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(58)))), ((int)(((byte)(95)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(-23, -1);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(508, 67);
            this.panel1.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(69, 10);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(342, 39);
            this.label2.TabIndex = 0;
            this.label2.Text = "Bienvenido Usuario ";
            // 
            // AperturaCaja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 380);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnAbrirCaja);
            this.Controls.Add(this.txtFondoApertura);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "AperturaCaja";
            this.Text = "AperturaCaja";
            this.Load += new System.EventHandler(this.AperturaCaja_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFondoApertura;
        private System.Windows.Forms.Button btnAbrirCaja;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
    }
}