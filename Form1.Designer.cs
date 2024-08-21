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
            this.lblFlowers = new System.Windows.Forms.Label();
            this.cmbObjective = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lblVegetables = new System.Windows.Forms.Label();
            this.lblPanel = new System.Windows.Forms.Panel();
            this.lblTab = new System.Windows.Forms.Label();
            this.checkbxRobot = new System.Windows.Forms.CheckBox();
            this.lblHome = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txbPassword = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txbEmail = new System.Windows.Forms.TextBox();
            this.comboBox5 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblMenu = new System.Windows.Forms.Label();
            this.lblFlowerCampos = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pctMenu = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSubscribe
            // 
            this.btnSubscribe.BackColor = System.Drawing.Color.LightCoral;
            this.btnSubscribe.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSubscribe.Location = new System.Drawing.Point(163, 248);
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
            this.lblName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblName.Location = new System.Drawing.Point(23, 77);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(85, 13);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Nome Completo:";
            this.lblName.Click += new System.EventHandler(this.lblName_Click);
            // 
            // txbName
            // 
            this.txbName.BackColor = System.Drawing.SystemColors.Info;
            this.txbName.Location = new System.Drawing.Point(23, 93);
            this.txbName.Name = "txbName";
            this.txbName.Size = new System.Drawing.Size(206, 20);
            this.txbName.TabIndex = 2;
            this.txbName.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // lblFlowers
            // 
            this.lblFlowers.AutoSize = true;
            this.lblFlowers.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.lblFlowers.Font = new System.Drawing.Font("Gentium Basic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFlowers.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblFlowers.Location = new System.Drawing.Point(3, 45);
            this.lblFlowers.Name = "lblFlowers";
            this.lblFlowers.Size = new System.Drawing.Size(34, 13);
            this.lblFlowers.TabIndex = 7;
            this.lblFlowers.Text = "Flores";
            this.lblFlowers.Click += new System.EventHandler(this.lblObjective_Click);
            // 
            // cmbObjective
            // 
            this.cmbObjective.BackColor = System.Drawing.SystemColors.Info;
            this.cmbObjective.FormattingEnabled = true;
            this.cmbObjective.Items.AddRange(new object[] {
            "DE SOMBRA",
            "DE MEIA-SOMBRA",
            "DE SOL"});
            this.cmbObjective.Location = new System.Drawing.Point(6, 61);
            this.cmbObjective.Name = "cmbObjective";
            this.cmbObjective.Size = new System.Drawing.Size(113, 21);
            this.cmbObjective.TabIndex = 9;
            this.cmbObjective.SelectedIndexChanged += new System.EventHandler(this.cmbObjective_SelectedIndexChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.SystemColors.Info;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Hortaliças-Tuberosas",
            "Hortaliças-Folhosas",
            "Hortaliças-Flores",
            "Hortaliças-Frutos",
            "Hortaliças-Legumes",
            "Hortaliças-Haste",
            "Hortaliças-Raízes"});
            this.comboBox1.Location = new System.Drawing.Point(6, 116);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(113, 21);
            this.comboBox1.TabIndex = 11;
            // 
            // lblVegetables
            // 
            this.lblVegetables.AutoSize = true;
            this.lblVegetables.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.lblVegetables.Font = new System.Drawing.Font("Gentium Basic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVegetables.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblVegetables.Location = new System.Drawing.Point(3, 100);
            this.lblVegetables.Name = "lblVegetables";
            this.lblVegetables.Size = new System.Drawing.Size(53, 13);
            this.lblVegetables.TabIndex = 10;
            this.lblVegetables.Text = "Hortaliças";
            this.lblVegetables.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // lblPanel
            // 
            this.lblPanel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
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
            this.lblPanel.Location = new System.Drawing.Point(424, 180);
            this.lblPanel.Name = "lblPanel";
            this.lblPanel.Size = new System.Drawing.Size(257, 297);
            this.lblPanel.TabIndex = 12;
            this.lblPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.lblPanel_Paint);
            // 
            // lblTab
            // 
            this.lblTab.AutoSize = true;
            this.lblTab.BackColor = System.Drawing.SystemColors.Menu;
            this.lblTab.Font = new System.Drawing.Font("Dutch801 XBd BT", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTab.Location = new System.Drawing.Point(46, 40);
            this.lblTab.Name = "lblTab";
            this.lblTab.Size = new System.Drawing.Size(155, 22);
            this.lblTab.TabIndex = 9;
            this.lblTab.Text = "Clique em \"TAB\" após o preenchimeto\r\n     dos dados de cada caixa de texto\r\n";
            this.lblTab.Click += new System.EventHandler(this.label1_Click_2);
            // 
            // checkbxRobot
            // 
            this.checkbxRobot.AutoSize = true;
            this.checkbxRobot.BackColor = System.Drawing.SystemColors.ControlLight;
            this.checkbxRobot.Location = new System.Drawing.Point(23, 259);
            this.checkbxRobot.Name = "checkbxRobot";
            this.checkbxRobot.Size = new System.Drawing.Size(107, 17);
            this.checkbxRobot.TabIndex = 8;
            this.checkbxRobot.Text = "Não sou um robô";
            this.checkbxRobot.UseVisualStyleBackColor = false;
            this.checkbxRobot.CheckedChanged += new System.EventHandler(this.checkbxRobot_CheckedChanged);
            // 
            // lblHome
            // 
            this.lblHome.AutoSize = true;
            this.lblHome.BackColor = System.Drawing.Color.Silver;
            this.lblHome.Font = new System.Drawing.Font("Dutch801 XBd BT", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHome.Location = new System.Drawing.Point(61, 14);
            this.lblHome.Name = "lblHome";
            this.lblHome.Size = new System.Drawing.Size(127, 14);
            this.lblHome.TabIndex = 7;
            this.lblHome.Text = "FAÇA SEU CADASTRO";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblPassword.Location = new System.Drawing.Point(23, 190);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(41, 13);
            this.lblPassword.TabIndex = 5;
            this.lblPassword.Text = "Senha:";
            // 
            // txbPassword
            // 
            this.txbPassword.BackColor = System.Drawing.SystemColors.Info;
            this.txbPassword.Location = new System.Drawing.Point(23, 206);
            this.txbPassword.Name = "txbPassword";
            this.txbPassword.Size = new System.Drawing.Size(206, 20);
            this.txbPassword.TabIndex = 6;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblEmail.Location = new System.Drawing.Point(23, 127);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(35, 13);
            this.lblEmail.TabIndex = 3;
            this.lblEmail.Text = "Email:";
            // 
            // txbEmail
            // 
            this.txbEmail.BackColor = System.Drawing.SystemColors.Info;
            this.txbEmail.Location = new System.Drawing.Point(23, 143);
            this.txbEmail.Name = "txbEmail";
            this.txbEmail.Size = new System.Drawing.Size(206, 20);
            this.txbEmail.TabIndex = 4;
            this.txbEmail.TextChanged += new System.EventHandler(this.textBox1_TextChanged_2);
            // 
            // comboBox5
            // 
            this.comboBox5.BackColor = System.Drawing.SystemColors.Info;
            this.comboBox5.FormattingEnabled = true;
            this.comboBox5.Items.AddRange(new object[] {
            "Caducifólias",
            "Perenes"});
            this.comboBox5.Location = new System.Drawing.Point(6, 181);
            this.comboBox5.Name = "comboBox5";
            this.comboBox5.Size = new System.Drawing.Size(113, 21);
            this.comboBox5.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.label4.Font = new System.Drawing.Font("Gentium Basic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label4.Location = new System.Drawing.Point(6, 165);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Árvores";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.BackColor = System.Drawing.Color.RosyBrown;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.cmbObjective);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.lblVegetables);
            this.panel1.Controls.Add(this.lblMenu);
            this.panel1.Controls.Add(this.lblFlowers);
            this.panel1.Controls.Add(this.comboBox5);
            this.panel1.Controls.Add(this.pctMenu);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(-1, -3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(136, 609);
            this.panel1.TabIndex = 13;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // lblMenu
            // 
            this.lblMenu.AutoSize = true;
            this.lblMenu.BackColor = System.Drawing.Color.Transparent;
            this.lblMenu.Font = new System.Drawing.Font("Dutch801 XBd BT", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMenu.Location = new System.Drawing.Point(31, 15);
            this.lblMenu.Name = "lblMenu";
            this.lblMenu.Size = new System.Drawing.Size(42, 14);
            this.lblMenu.TabIndex = 8;
            this.lblMenu.Text = "MENU";
            // 
            // lblFlowerCampos
            // 
            this.lblFlowerCampos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFlowerCampos.AutoSize = true;
            this.lblFlowerCampos.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblFlowerCampos.Font = new System.Drawing.Font("Reem Kufi", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFlowerCampos.Location = new System.Drawing.Point(443, 32);
            this.lblFlowerCampos.Name = "lblFlowerCampos";
            this.lblFlowerCampos.Size = new System.Drawing.Size(212, 49);
            this.lblFlowerCampos.TabIndex = 9;
            this.lblFlowerCampos.Text = "Floris_Campos";
            this.lblFlowerCampos.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pctMenu
            // 
            this.pctMenu.Image = ((System.Drawing.Image)(resources.GetObject("pctMenu.Image")));
            this.pctMenu.Location = new System.Drawing.Point(3, 9);
            this.pctMenu.Name = "pctMenu";
            this.pctMenu.Size = new System.Drawing.Size(22, 20);
            this.pctMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctMenu.TabIndex = 21;
            this.pctMenu.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(126, -3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(902, 119);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Khaki;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1024, 595);
            this.Controls.Add(this.lblFlowerCampos);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblPanel);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FlorisCampos";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.lblPanel.ResumeLayout(false);
            this.lblPanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSubscribe;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txbName;
        private System.Windows.Forms.Label lblFlowers;
        private System.Windows.Forms.ComboBox cmbObjective;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lblVegetables;
        private System.Windows.Forms.Panel lblPanel;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txbPassword;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txbEmail;
        private System.Windows.Forms.Label lblHome;
        private System.Windows.Forms.ComboBox comboBox5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblMenu;
        private System.Windows.Forms.PictureBox pctMenu;
        private System.Windows.Forms.CheckBox checkbxRobot;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblFlowerCampos;
        private System.Windows.Forms.Label lblTab;
        private System.Windows.Forms.Timer timer1;
    }
}

