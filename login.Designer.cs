namespace interfaz_de_caja_registradora
{
    partial class login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(login));
            this.btnLogin = new System.Windows.Forms.Button();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtContraseña = new System.Windows.Forms.TextBox();
            this.timerBloqueo = new System.Windows.Forms.Timer(this.components);
            this.lblBloqueo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblOlvidaste = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.cuerpo = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.cuerpo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.Black;
            this.btnLogin.Location = new System.Drawing.Point(52, 276);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(177, 55);
            this.btnLogin.TabIndex = 0;
            this.btnLogin.Text = " ingresar \r\n";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // txtUsuario
            // 
            this.txtUsuario.BackColor = System.Drawing.Color.AliceBlue;
            this.txtUsuario.Location = new System.Drawing.Point(29, 113);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(236, 20);
            this.txtUsuario.TabIndex = 1;
            // 
            // txtContraseña
            // 
            this.txtContraseña.BackColor = System.Drawing.Color.AliceBlue;
            this.txtContraseña.Location = new System.Drawing.Point(29, 189);
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.Size = new System.Drawing.Size(236, 20);
            this.txtContraseña.TabIndex = 2;
            // 
            // timerBloqueo
            // 
            this.timerBloqueo.Interval = 1000;
            this.timerBloqueo.Tick += new System.EventHandler(this.timerBloqueo_Tick);
            // 
            // lblBloqueo
            // 
            this.lblBloqueo.AutoSize = true;
            this.lblBloqueo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBloqueo.ForeColor = System.Drawing.Color.Red;
            this.lblBloqueo.Location = new System.Drawing.Point(91, 189);
            this.lblBloqueo.Name = "lblBloqueo";
            this.lblBloqueo.Size = new System.Drawing.Size(0, 25);
            this.lblBloqueo.TabIndex = 3;
            this.lblBloqueo.Click += new System.EventHandler(this.lblBloqueo_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Usuario ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(25, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "contraseña ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(46, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(201, 33);
            this.label3.TabIndex = 6;
            this.label3.Text = "Iniciar sesión";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // lblOlvidaste
            // 
            this.lblOlvidaste.AutoSize = true;
            this.lblOlvidaste.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblOlvidaste.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOlvidaste.Location = new System.Drawing.Point(25, 214);
            this.lblOlvidaste.Name = "lblOlvidaste";
            this.lblOlvidaste.Size = new System.Drawing.Size(204, 18);
            this.lblOlvidaste.TabIndex = 7;
            this.lblOlvidaste.Text = "¿Olvidaste tu contraseña?";
            this.lblOlvidaste.Click += new System.EventHandler(this.lblOlvidaste_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightGray;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.lblOlvidaste);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lblBloqueo);
            this.panel1.Controls.Add(this.txtContraseña);
            this.panel1.Controls.Add(this.txtUsuario);
            this.panel1.Controls.Add(this.btnLogin);
            this.panel1.Cursor = System.Windows.Forms.Cursors.Default;
            this.panel1.Location = new System.Drawing.Point(271, 85);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(306, 383);
            this.panel1.TabIndex = 8;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // cuerpo
            // 
            this.cuerpo.BackColor = System.Drawing.Color.LightGray;
            this.cuerpo.Controls.Add(this.pictureBox1);
            this.cuerpo.Location = new System.Drawing.Point(338, 1);
            this.cuerpo.Name = "cuerpo";
            this.cuerpo.Size = new System.Drawing.Size(172, 123);
            this.cuerpo.TabIndex = 10;
            this.cuerpo.Paint += new System.Windows.Forms.PaintEventHandler(this.cuerpo_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Silver;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(175, 116);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(800, 480);
            this.Controls.Add(this.cuerpo);
            this.Controls.Add(this.panel1);
            this.Name = "login";
            this.Text = "l";
            this.Load += new System.EventHandler(this.login_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.cuerpo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox txtContraseña;
        private System.Windows.Forms.Timer timerBloqueo;
        private System.Windows.Forms.Label lblBloqueo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblOlvidaste;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Panel cuerpo;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}