namespace Floris_Campos
{
    partial class Form01
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form01));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblHome = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblFloricultor = new System.Windows.Forms.Label();
            this.pnlUsuario = new System.Windows.Forms.Panel();
            this.bttCdusuario = new System.Windows.Forms.Button();
            this.CdUsuario = new System.Windows.Forms.Label();
            this.pnlFloricultor = new System.Windows.Forms.Panel();
            this.bttCdfloricultor = new System.Windows.Forms.Button();
            this.CdFloricultor = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnlUsuario.SuspendLayout();
            this.pnlFloricultor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            // 
            // lblHome
            // 
            this.lblHome.AutoSize = true;
            this.lblHome.BackColor = System.Drawing.Color.White;
            this.lblHome.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblHome.Font = new System.Drawing.Font("Reem Kufi", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHome.Location = new System.Drawing.Point(431, 168);
            this.lblHome.Name = "lblHome";
            this.lblHome.Size = new System.Drawing.Size(157, 37);
            this.lblHome.TabIndex = 7;
            this.lblHome.Text = "Seja Bem-Vindo";
            this.lblHome.Click += new System.EventHandler(this.lblHome_Click);
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.lblUsuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblUsuario.Font = new System.Drawing.Font("Reem Kufi", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.Location = new System.Drawing.Point(40, -1);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(108, 24);
            this.lblUsuario.TabIndex = 16;
            this.lblUsuario.Text = "Cadastro Usuário";
            this.lblUsuario.Click += new System.EventHandler(this.lblUsuario_Click);
            // 
            // lblFloricultor
            // 
            this.lblFloricultor.AutoSize = true;
            this.lblFloricultor.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.lblFloricultor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblFloricultor.Font = new System.Drawing.Font("Reem Kufi", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFloricultor.Location = new System.Drawing.Point(40, -1);
            this.lblFloricultor.Name = "lblFloricultor";
            this.lblFloricultor.Size = new System.Drawing.Size(123, 24);
            this.lblFloricultor.TabIndex = 17;
            this.lblFloricultor.Text = "Cadastro Floricultor";
            // 
            // pnlUsuario
            // 
            this.pnlUsuario.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.pnlUsuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlUsuario.Controls.Add(this.bttCdusuario);
            this.pnlUsuario.Controls.Add(this.CdUsuario);
            this.pnlUsuario.Controls.Add(this.lblUsuario);
            this.pnlUsuario.Location = new System.Drawing.Point(305, 253);
            this.pnlUsuario.Name = "pnlUsuario";
            this.pnlUsuario.Size = new System.Drawing.Size(190, 229);
            this.pnlUsuario.TabIndex = 18;
            this.pnlUsuario.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // bttCdusuario
            // 
            this.bttCdusuario.BackColor = System.Drawing.Color.DarkSalmon;
            this.bttCdusuario.Font = new System.Drawing.Font("Reem Kufi", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttCdusuario.Location = new System.Drawing.Point(50, 191);
            this.bttCdusuario.Name = "bttCdusuario";
            this.bttCdusuario.Size = new System.Drawing.Size(83, 33);
            this.bttCdusuario.TabIndex = 17;
            this.bttCdusuario.Text = "Cadastrar";
            this.bttCdusuario.UseVisualStyleBackColor = false;
            this.bttCdusuario.Click += new System.EventHandler(this.button1_Click);
            // 
            // CdUsuario
            // 
            this.CdUsuario.AutoSize = true;
            this.CdUsuario.Font = new System.Drawing.Font("Segoe Fluent Icons", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CdUsuario.Location = new System.Drawing.Point(3, 54);
            this.CdUsuario.Name = "CdUsuario";
            this.CdUsuario.Size = new System.Drawing.Size(173, 117);
            this.CdUsuario.TabIndex = 0;
            this.CdUsuario.Text = "- Opções diversas de flores e plantas;\r\n\r\n- Preços acessíveis;\r\n\r\n- Entrega segur" +
    "a e garantida;\r\n\r\n- Segurança na sua compra;\r\n\r\n- Cupons de Desconto.\r\n";
            // 
            // pnlFloricultor
            // 
            this.pnlFloricultor.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.pnlFloricultor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlFloricultor.Controls.Add(this.bttCdfloricultor);
            this.pnlFloricultor.Controls.Add(this.CdFloricultor);
            this.pnlFloricultor.Controls.Add(this.lblFloricultor);
            this.pnlFloricultor.Location = new System.Drawing.Point(535, 253);
            this.pnlFloricultor.Name = "pnlFloricultor";
            this.pnlFloricultor.Size = new System.Drawing.Size(203, 229);
            this.pnlFloricultor.TabIndex = 19;
            // 
            // bttCdfloricultor
            // 
            this.bttCdfloricultor.BackColor = System.Drawing.Color.DarkSalmon;
            this.bttCdfloricultor.Font = new System.Drawing.Font("Reem Kufi", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttCdfloricultor.Location = new System.Drawing.Point(57, 191);
            this.bttCdfloricultor.Name = "bttCdfloricultor";
            this.bttCdfloricultor.Size = new System.Drawing.Size(83, 33);
            this.bttCdfloricultor.TabIndex = 18;
            this.bttCdfloricultor.Text = "Cadastrar";
            this.bttCdfloricultor.UseVisualStyleBackColor = false;
            this.bttCdfloricultor.Click += new System.EventHandler(this.bttCdfloricultor_Click);
            // 
            // CdFloricultor
            // 
            this.CdFloricultor.AutoSize = true;
            this.CdFloricultor.Font = new System.Drawing.Font("Segoe Fluent Icons", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CdFloricultor.Location = new System.Drawing.Point(3, 54);
            this.CdFloricultor.Name = "CdFloricultor";
            this.CdFloricultor.Size = new System.Drawing.Size(139, 117);
            this.CdFloricultor.TabIndex = 17;
            this.CdFloricultor.Text = "- Cadastro de plantas e flores;\r\n\r\n- Segurança de dados;\r\n\r\n- Fácil controle de c" +
    "lientes;\r\n\r\n- Parceria Logística ;\r\n\r\n- Edição de cadastros.\r\n";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1031, 599);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // Form01
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1025, 598);
            this.Controls.Add(this.pnlFloricultor);
            this.Controls.Add(this.pnlUsuario);
            this.Controls.Add(this.lblHome);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form01";
            this.Text = "Form01";
            this.Load += new System.EventHandler(this.Form01_Load);
            this.pnlUsuario.ResumeLayout(false);
            this.pnlUsuario.PerformLayout();
            this.pnlFloricultor.ResumeLayout(false);
            this.pnlFloricultor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblHome;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblFloricultor;
        private System.Windows.Forms.Panel pnlUsuario;
        private System.Windows.Forms.Label CdUsuario;
        private System.Windows.Forms.Panel pnlFloricultor;
        private System.Windows.Forms.Label CdFloricultor;
        private System.Windows.Forms.Button bttCdusuario;
        private System.Windows.Forms.Button bttCdfloricultor;
    }
}