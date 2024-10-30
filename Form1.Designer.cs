namespace Floris_Campos
{
    partial class frmMain
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.btnSubscribe = new System.Windows.Forms.Button();
            this.lblName = new System.Windows.Forms.Label();
            this.txbName = new System.Windows.Forms.TextBox();
            this.lblPanel = new System.Windows.Forms.Panel();
            this.lblTab = new System.Windows.Forms.Label();
            this.checkbxRobot = new System.Windows.Forms.CheckBox();
            this.lblHome = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txbPassword = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txbEmail = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lista = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSubscribe
            // 
            this.btnSubscribe.BackColor = System.Drawing.Color.White;
            this.btnSubscribe.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSubscribe.Font = new System.Drawing.Font("Reem Kufi", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubscribe.Location = new System.Drawing.Point(162, 272);
            this.btnSubscribe.Name = "btnSubscribe";
            this.btnSubscribe.Size = new System.Drawing.Size(77, 36);
            this.btnSubscribe.TabIndex = 0;
            this.btnSubscribe.Tag = "";
            this.btnSubscribe.Text = "Cadastrar";
            this.btnSubscribe.UseVisualStyleBackColor = false;
            this.btnSubscribe.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Reem Kufi", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.Color.Black;
            this.lblName.Location = new System.Drawing.Point(22, 95);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(91, 19);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Nome Completo:";
            this.lblName.Click += new System.EventHandler(this.lblName_Click);
            // 
            // txbName
            // 
            this.txbName.BackColor = System.Drawing.SystemColors.Info;
            this.txbName.Location = new System.Drawing.Point(22, 117);
            this.txbName.Name = "txbName";
            this.txbName.Size = new System.Drawing.Size(206, 20);
            this.txbName.TabIndex = 2;
            this.txbName.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // lblPanel
            // 
            this.lblPanel.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.lblPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblPanel.Controls.Add(this.lblTab);
            this.lblPanel.Controls.Add(this.checkbxRobot);
            this.lblPanel.Controls.Add(this.lblHome);
            this.lblPanel.Controls.Add(this.lblPassword);
            this.lblPanel.Controls.Add(this.txbPassword);
            this.lblPanel.Controls.Add(this.lblEmail);
            this.lblPanel.Controls.Add(this.txbEmail);
            this.lblPanel.Controls.Add(this.btnSubscribe);
            this.lblPanel.Controls.Add(this.lblName);
            this.lblPanel.Controls.Add(this.txbName);
            this.lblPanel.Location = new System.Drawing.Point(388, 164);
            this.lblPanel.Name = "lblPanel";
            this.lblPanel.Size = new System.Drawing.Size(257, 328);
            this.lblPanel.TabIndex = 12;
            this.lblPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.lblPanel_Paint);
            // 
            // lblTab
            // 
            this.lblTab.AutoSize = true;
            this.lblTab.BackColor = System.Drawing.Color.LightGray;
            this.lblTab.Font = new System.Drawing.Font("Noto Sans Lisu", 6.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTab.Location = new System.Drawing.Point(40, 50);
            this.lblTab.Name = "lblTab";
            this.lblTab.Size = new System.Drawing.Size(178, 26);
            this.lblTab.TabIndex = 9;
            this.lblTab.Text = " Clique em \"TAB\" após o preenchimeto     \r\n     dos dados de cada caixa de texto\r" +
    "\n";
            this.lblTab.Click += new System.EventHandler(this.label1_Click_2);
            // 
            // checkbxRobot
            // 
            this.checkbxRobot.AutoSize = true;
            this.checkbxRobot.BackColor = System.Drawing.SystemColors.ControlLight;
            this.checkbxRobot.Font = new System.Drawing.Font("OpenSymbol", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkbxRobot.Location = new System.Drawing.Point(22, 283);
            this.checkbxRobot.Name = "checkbxRobot";
            this.checkbxRobot.Size = new System.Drawing.Size(116, 17);
            this.checkbxRobot.TabIndex = 8;
            this.checkbxRobot.Text = "Não sou um robô";
            this.checkbxRobot.UseVisualStyleBackColor = false;
            this.checkbxRobot.CheckedChanged += new System.EventHandler(this.checkbxRobot_CheckedChanged);
            // 
            // lblHome
            // 
            this.lblHome.AutoSize = true;
            this.lblHome.BackColor = System.Drawing.Color.White;
            this.lblHome.Font = new System.Drawing.Font("Reem Kufi", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHome.Location = new System.Drawing.Point(55, 13);
            this.lblHome.Name = "lblHome";
            this.lblHome.Size = new System.Drawing.Size(146, 23);
            this.lblHome.TabIndex = 7;
            this.lblHome.Text = "FAÇA SEU CADASTRO";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Reem Kufi", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.ForeColor = System.Drawing.Color.Black;
            this.lblPassword.Location = new System.Drawing.Point(22, 208);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(44, 19);
            this.lblPassword.TabIndex = 5;
            this.lblPassword.Text = "Senha:";
            // 
            // txbPassword
            // 
            this.txbPassword.BackColor = System.Drawing.SystemColors.Info;
            this.txbPassword.Location = new System.Drawing.Point(22, 230);
            this.txbPassword.Name = "txbPassword";
            this.txbPassword.PasswordChar = '*';
            this.txbPassword.Size = new System.Drawing.Size(206, 20);
            this.txbPassword.TabIndex = 6;
            this.txbPassword.TextChanged += new System.EventHandler(this.txbPassword_TextChanged);
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Reem Kufi", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.ForeColor = System.Drawing.Color.Black;
            this.lblEmail.Location = new System.Drawing.Point(22, 145);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(40, 19);
            this.lblEmail.TabIndex = 3;
            this.lblEmail.Text = "Email:";
            // 
            // txbEmail
            // 
            this.txbEmail.BackColor = System.Drawing.SystemColors.Info;
            this.txbEmail.Location = new System.Drawing.Point(22, 167);
            this.txbEmail.Name = "txbEmail";
            this.txbEmail.Size = new System.Drawing.Size(206, 20);
            this.txbEmail.TabIndex = 4;
            this.txbEmail.TextChanged += new System.EventHandler(this.textBox1_TextChanged_2);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-2, -2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1031, 599);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // lista
            // 
            this.lista.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.lista.HideSelection = false;
            this.lista.Location = new System.Drawing.Point(12, 164);
            this.lista.Name = "lista";
            this.lista.Size = new System.Drawing.Size(359, 298);
            this.lista.TabIndex = 14;
            this.lista.UseCompatibleStateImageBehavior = false;
            this.lista.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Código Usuário";
            this.columnHeader1.Width = 88;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Nome";
            this.columnHeader2.Width = 88;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Email";
            this.columnHeader3.Width = 102;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Senha";
            this.columnHeader4.Width = 110;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1024, 595);
            this.Controls.Add(this.lista);
            this.Controls.Add(this.lblPanel);
            this.Controls.Add(this.pictureBox1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FlorisCampos";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.lblPanel.ResumeLayout(false);
            this.lblPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSubscribe;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txbName;
        private System.Windows.Forms.Panel lblPanel;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txbPassword;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txbEmail;
        private System.Windows.Forms.Label lblHome;
        private System.Windows.Forms.CheckBox checkbxRobot;
        private System.Windows.Forms.Label lblTab;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ListView lista;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
    }
}

