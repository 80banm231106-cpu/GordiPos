namespace interfaz_de_caja_registradora
{
    partial class CorteDeCaja
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CorteDeCaja));
            this.txtEfectivoContado = new System.Windows.Forms.TextBox();
            this.lblDiferencia = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnFinalizarCorte = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblCajero = new System.Windows.Forms.Label();
            this.txtTotalesperado = new System.Windows.Forms.TextBox();
            this.txtVentastotales = new System.Windows.Forms.TextBox();
            this.txtFondoinicial = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnRegreso = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtEfectivoContado
            // 
            this.txtEfectivoContado.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtEfectivoContado.Location = new System.Drawing.Point(154, 68);
            this.txtEfectivoContado.Name = "txtEfectivoContado";
            this.txtEfectivoContado.Size = new System.Drawing.Size(183, 20);
            this.txtEfectivoContado.TabIndex = 4;
            this.txtEfectivoContado.TextChanged += new System.EventHandler(this.txtEfectivoContado_TextChanged);
            // 
            // lblDiferencia
            // 
            this.lblDiferencia.AutoSize = true;
            this.lblDiferencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiferencia.ForeColor = System.Drawing.Color.Black;
            this.lblDiferencia.Location = new System.Drawing.Point(125, 9);
            this.lblDiferencia.Name = "lblDiferencia";
            this.lblDiferencia.Size = new System.Drawing.Size(232, 31);
            this.lblDiferencia.TabIndex = 5;
            this.lblDiferencia.Text = "   DIFERENCIA: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Fondo Inicial:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Ventas totales: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "Total Esperado: ";
            // 
            // btnFinalizarCorte
            // 
            this.btnFinalizarCorte.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFinalizarCorte.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnFinalizarCorte.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinalizarCorte.Location = new System.Drawing.Point(29, 271);
            this.btnFinalizarCorte.Name = "btnFinalizarCorte";
            this.btnFinalizarCorte.Size = new System.Drawing.Size(134, 72);
            this.btnFinalizarCorte.TabIndex = 9;
            this.btnFinalizarCorte.Text = "Finalizar Corte";
            this.btnFinalizarCorte.UseVisualStyleBackColor = true;
            this.btnFinalizarCorte.Click += new System.EventHandler(this.btnFinalizarCorte_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(58)))), ((int)(((byte)(95)))));
            this.panel1.Controls.Add(this.btnRegreso);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(1, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(881, 75);
            this.panel1.TabIndex = 10;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(22, 21);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(172, 37);
            this.label9.TabIndex = 1;
            this.label9.Text = "Gordi Feliz";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.label4.Location = new System.Drawing.Point(360, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(219, 37);
            this.label4.TabIndex = 0;
            this.label4.Text = "Corte De Caja";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.lblCajero);
            this.panel2.Controls.Add(this.txtTotalesperado);
            this.panel2.Controls.Add(this.txtVentastotales);
            this.panel2.Controls.Add(this.txtFondoinicial);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(224, 93);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(475, 150);
            this.panel2.TabIndex = 11;
            // 
            // lblCajero
            // 
            this.lblCajero.AutoSize = true;
            this.lblCajero.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCajero.Location = new System.Drawing.Point(13, 6);
            this.lblCajero.Name = "lblCajero";
            this.lblCajero.Size = new System.Drawing.Size(57, 16);
            this.lblCajero.TabIndex = 13;
            this.lblCajero.Text = "Cajero:";
            // 
            // txtTotalesperado
            // 
            this.txtTotalesperado.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtTotalesperado.Location = new System.Drawing.Point(335, 110);
            this.txtTotalesperado.Name = "txtTotalesperado";
            this.txtTotalesperado.Size = new System.Drawing.Size(100, 20);
            this.txtTotalesperado.TabIndex = 12;
            // 
            // txtVentastotales
            // 
            this.txtVentastotales.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtVentastotales.Location = new System.Drawing.Point(335, 77);
            this.txtVentastotales.Name = "txtVentastotales";
            this.txtVentastotales.Size = new System.Drawing.Size(100, 20);
            this.txtVentastotales.TabIndex = 11;
            // 
            // txtFondoinicial
            // 
            this.txtFondoinicial.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtFondoinicial.Location = new System.Drawing.Point(335, 42);
            this.txtFondoinicial.Name = "txtFondoinicial";
            this.txtFondoinicial.Size = new System.Drawing.Size(100, 20);
            this.txtFondoinicial.TabIndex = 10;
            this.txtFondoinicial.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(168, 3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(154, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Resumen De Caja";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.txtEfectivoContado);
            this.panel3.Location = new System.Drawing.Point(224, 253);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(475, 121);
            this.panel3.TabIndex = 12;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(120, 91);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(256, 18);
            this.label8.TabIndex = 5;
            this.label8.Text = "(Ingrese el total contado en caja)";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(225, 38);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 16);
            this.label7.TabIndex = 1;
            this.label7.Text = "Total:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(168, 3);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(169, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "Conteo En Efectivo ";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4.Controls.Add(this.lblDiferencia);
            this.panel4.Location = new System.Drawing.Point(224, 390);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(475, 121);
            this.panel4.TabIndex = 13;
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
            this.btnRegreso.Location = new System.Drawing.Point(804, 17);
            this.btnRegreso.Name = "btnRegreso";
            this.btnRegreso.Size = new System.Drawing.Size(64, 38);
            this.btnRegreso.TabIndex = 14;
            this.btnRegreso.UseVisualStyleBackColor = false;
            this.btnRegreso.Click += new System.EventHandler(this.btnRegreso_Click);
            // 
            // CorteDeCaja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(881, 581);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnFinalizarCorte);
            this.Name = "CorteDeCaja";
            this.Text = "CorteDeCaja";
            this.Load += new System.EventHandler(this.CorteDeCaja_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox txtEfectivoContado;
        private System.Windows.Forms.Label lblDiferencia;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnFinalizarCorte;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtTotalesperado;
        private System.Windows.Forms.TextBox txtVentastotales;
        private System.Windows.Forms.TextBox txtFondoinicial;
        private System.Windows.Forms.Label lblCajero;
        private System.Windows.Forms.Button btnRegreso;
    }
}