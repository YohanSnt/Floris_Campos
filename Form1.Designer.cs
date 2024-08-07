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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.btnSubscribe = new System.Windows.Forms.Button();
            this.lblName = new System.Windows.Forms.Label();
            this.txbName = new System.Windows.Forms.TextBox();
            this.lblFlowers = new System.Windows.Forms.Label();
            this.cmbObjective = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lblVegetables = new System.Windows.Forms.Label();
            this.lblPanel = new System.Windows.Forms.Panel();
            this.lblEmail = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lblHome = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox5 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblMenu = new System.Windows.Forms.Label();
            this.pctMenu = new System.Windows.Forms.PictureBox();
            this.lblPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctMenu)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSubscribe
            // 
            this.btnSubscribe.BackColor = System.Drawing.Color.LightCoral;
            this.btnSubscribe.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSubscribe.Location = new System.Drawing.Point(162, 225);
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
            this.lblName.Location = new System.Drawing.Point(22, 54);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(85, 13);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Nome Completo:";
            this.lblName.Click += new System.EventHandler(this.lblName_Click);
            // 
            // txbName
            // 
            this.txbName.BackColor = System.Drawing.SystemColors.Info;
            this.txbName.Location = new System.Drawing.Point(22, 70);
            this.txbName.Name = "txbName";
            this.txbName.Size = new System.Drawing.Size(206, 20);
            this.txbName.TabIndex = 2;
            this.txbName.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // lblFlowers
            // 
            this.lblFlowers.AutoSize = true;
            this.lblFlowers.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.lblFlowers.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblFlowers.Location = new System.Drawing.Point(687, 73);
            this.lblFlowers.Name = "lblFlowers";
            this.lblFlowers.Size = new System.Drawing.Size(35, 13);
            this.lblFlowers.TabIndex = 7;
            this.lblFlowers.Text = "Flores";
            this.lblFlowers.Click += new System.EventHandler(this.lblObjective_Click);
            // 
            // cmbObjective
            // 
            this.cmbObjective.BackColor = System.Drawing.SystemColors.Info;
            this.cmbObjective.FormattingEnabled = true;
            this.cmbObjective.Items.AddRange(new object[] {
            "VENDA",
            "COMPRA"});
            this.cmbObjective.Location = new System.Drawing.Point(690, 89);
            this.cmbObjective.Name = "cmbObjective";
            this.cmbObjective.Size = new System.Drawing.Size(85, 21);
            this.cmbObjective.TabIndex = 9;
            this.cmbObjective.SelectedIndexChanged += new System.EventHandler(this.cmbObjective_SelectedIndexChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.SystemColors.Info;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "VENDA",
            "COMPRA"});
            this.comboBox1.Location = new System.Drawing.Point(690, 136);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(85, 21);
            this.comboBox1.TabIndex = 11;
            // 
            // lblVegetables
            // 
            this.lblVegetables.AutoSize = true;
            this.lblVegetables.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.lblVegetables.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblVegetables.Location = new System.Drawing.Point(687, 120);
            this.lblVegetables.Name = "lblVegetables";
            this.lblVegetables.Size = new System.Drawing.Size(54, 13);
            this.lblVegetables.TabIndex = 10;
            this.lblVegetables.Text = "Hortaliças";
            this.lblVegetables.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // lblPanel
            // 
            this.lblPanel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblPanel.Controls.Add(this.lblHome);
            this.lblPanel.Controls.Add(this.lblPassword);
            this.lblPanel.Controls.Add(this.textBox2);
            this.lblPanel.Controls.Add(this.lblEmail);
            this.lblPanel.Controls.Add(this.textBox1);
            this.lblPanel.Controls.Add(this.btnSubscribe);
            this.lblPanel.Controls.Add(this.lblName);
            this.lblPanel.Controls.Add(this.txbName);
            this.lblPanel.Location = new System.Drawing.Point(270, 150);
            this.lblPanel.Name = "lblPanel";
            this.lblPanel.Size = new System.Drawing.Size(257, 298);
            this.lblPanel.TabIndex = 12;
            this.lblPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.lblPanel_Paint);
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblEmail.Location = new System.Drawing.Point(22, 104);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(35, 13);
            this.lblEmail.TabIndex = 3;
            this.lblEmail.Text = "Email:";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Info;
            this.textBox1.Location = new System.Drawing.Point(22, 120);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(206, 20);
            this.textBox1.TabIndex = 4;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblPassword.Location = new System.Drawing.Point(22, 167);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(41, 13);
            this.lblPassword.TabIndex = 5;
            this.lblPassword.Text = "Senha:";
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.Info;
            this.textBox2.Location = new System.Drawing.Point(22, 183);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(206, 20);
            this.textBox2.TabIndex = 6;
            // 
            // lblHome
            // 
            this.lblHome.AutoSize = true;
            this.lblHome.BackColor = System.Drawing.SystemColors.Menu;
            this.lblHome.Font = new System.Drawing.Font("Dutch801 XBd BT", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHome.Location = new System.Drawing.Point(61, 17);
            this.lblHome.Name = "lblHome";
            this.lblHome.Size = new System.Drawing.Size(127, 14);
            this.lblHome.TabIndex = 7;
            this.lblHome.Text = "FAÇA SEU CADASTRO";
            // 
            // comboBox2
            // 
            this.comboBox2.BackColor = System.Drawing.SystemColors.Info;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "VENDA",
            "COMPRA"});
            this.comboBox2.Location = new System.Drawing.Point(13, 342);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(85, 21);
            this.comboBox2.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(10, 326);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Tipo";
            // 
            // comboBox3
            // 
            this.comboBox3.BackColor = System.Drawing.SystemColors.Info;
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
            "VENDA",
            "COMPRA"});
            this.comboBox3.Location = new System.Drawing.Point(13, 295);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(85, 21);
            this.comboBox3.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(10, 279);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Objetivo";
            // 
            // comboBox4
            // 
            this.comboBox4.BackColor = System.Drawing.SystemColors.Info;
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Items.AddRange(new object[] {
            "VENDA",
            "COMPRA"});
            this.comboBox4.Location = new System.Drawing.Point(13, 245);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(85, 21);
            this.comboBox4.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(10, 229);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Tipo";
            // 
            // comboBox5
            // 
            this.comboBox5.BackColor = System.Drawing.SystemColors.Info;
            this.comboBox5.FormattingEnabled = true;
            this.comboBox5.Items.AddRange(new object[] {
            "VENDA",
            "COMPRA"});
            this.comboBox5.Location = new System.Drawing.Point(13, 157);
            this.comboBox5.Name = "comboBox5";
            this.comboBox5.Size = new System.Drawing.Size(85, 21);
            this.comboBox5.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label4.Location = new System.Drawing.Point(10, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Objetivo";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.comboBox4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.lblMenu);
            this.panel1.Controls.Add(this.comboBox2);
            this.panel1.Controls.Add(this.comboBox5);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pctMenu);
            this.panel1.Controls.Add(this.comboBox3);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(675, 26);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(122, 412);
            this.panel1.TabIndex = 13;
            // 
            // lblMenu
            // 
            this.lblMenu.AutoSize = true;
            this.lblMenu.BackColor = System.Drawing.Color.Transparent;
            this.lblMenu.Font = new System.Drawing.Font("Dutch801 XBd BT", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMenu.Location = new System.Drawing.Point(31, 9);
            this.lblMenu.Name = "lblMenu";
            this.lblMenu.Size = new System.Drawing.Size(42, 14);
            this.lblMenu.TabIndex = 8;
            this.lblMenu.Text = "MENU";
            // 
            // pctMenu
            // 
            this.pctMenu.Image = ((System.Drawing.Image)(resources.GetObject("pctMenu.Image")));
            this.pctMenu.Location = new System.Drawing.Point(3, 3);
            this.pctMenu.Name = "pctMenu";
            this.pctMenu.Size = new System.Drawing.Size(22, 20);
            this.pctMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctMenu.TabIndex = 21;
            this.pctMenu.TabStop = false;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(810, 589);
            this.Controls.Add(this.lblPanel);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.lblVegetables);
            this.Controls.Add(this.cmbObjective);
            this.Controls.Add(this.lblFlowers);
            this.Controls.Add(this.panel1);
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
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblHome;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblMenu;
        private System.Windows.Forms.PictureBox pctMenu;
    }
}

