namespace Floris_Campos
{
    partial class form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form2));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblFlowerCampos = new System.Windows.Forms.Label();
            this.lblMenu = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmbObjective = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lblVegetables = new System.Windows.Forms.Label();
            this.lblFlowers = new System.Windows.Forms.Label();
            this.comboBox5 = new System.Windows.Forms.ComboBox();
            this.pctMenu = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctMenu)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            // 
            // lblFlowerCampos
            // 
            this.lblFlowerCampos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFlowerCampos.AutoSize = true;
            this.lblFlowerCampos.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblFlowerCampos.Font = new System.Drawing.Font("Reem Kufi", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFlowerCampos.Location = new System.Drawing.Point(451, 38);
            this.lblFlowerCampos.Name = "lblFlowerCampos";
            this.lblFlowerCampos.Size = new System.Drawing.Size(212, 49);
            this.lblFlowerCampos.TabIndex = 16;
            this.lblFlowerCampos.Text = "Floris_Campos";
            this.lblFlowerCampos.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblMenu
            // 
            this.lblMenu.AutoSize = true;
            this.lblMenu.BackColor = System.Drawing.Color.Transparent;
            this.lblMenu.Font = new System.Drawing.Font("Dutch801 XBd BT", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMenu.Location = new System.Drawing.Point(43, 15);
            this.lblMenu.Name = "lblMenu";
            this.lblMenu.Size = new System.Drawing.Size(42, 14);
            this.lblMenu.TabIndex = 8;
            this.lblMenu.Text = "MENU";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.BackColor = System.Drawing.Color.RosyBrown;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel1.Controls.Add(this.cmbObjective);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.lblVegetables);
            this.panel1.Controls.Add(this.lblMenu);
            this.panel1.Controls.Add(this.lblFlowers);
            this.panel1.Controls.Add(this.comboBox5);
            this.panel1.Controls.Add(this.pctMenu);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(-3, -4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(141, 642);
            this.panel1.TabIndex = 18;
            // 
            // cmbObjective
            // 
            this.cmbObjective.BackColor = System.Drawing.SystemColors.Info;
            this.cmbObjective.FormattingEnabled = true;
            this.cmbObjective.Items.AddRange(new object[] {
            "DE SOMBRA",
            "DE MEIA-SOMBRA",
            "DE SOL"});
            this.cmbObjective.Location = new System.Drawing.Point(15, 61);
            this.cmbObjective.Name = "cmbObjective";
            this.cmbObjective.Size = new System.Drawing.Size(113, 21);
            this.cmbObjective.TabIndex = 9;
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
            this.comboBox1.Location = new System.Drawing.Point(15, 116);
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
            this.lblVegetables.Location = new System.Drawing.Point(12, 100);
            this.lblVegetables.Name = "lblVegetables";
            this.lblVegetables.Size = new System.Drawing.Size(53, 13);
            this.lblVegetables.TabIndex = 10;
            this.lblVegetables.Text = "Hortaliças";
            // 
            // lblFlowers
            // 
            this.lblFlowers.AutoSize = true;
            this.lblFlowers.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.lblFlowers.Font = new System.Drawing.Font("Gentium Basic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFlowers.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblFlowers.Location = new System.Drawing.Point(12, 45);
            this.lblFlowers.Name = "lblFlowers";
            this.lblFlowers.Size = new System.Drawing.Size(34, 13);
            this.lblFlowers.TabIndex = 7;
            this.lblFlowers.Text = "Flores";
            // 
            // comboBox5
            // 
            this.comboBox5.BackColor = System.Drawing.SystemColors.Info;
            this.comboBox5.FormattingEnabled = true;
            this.comboBox5.Items.AddRange(new object[] {
            "Caducifólias",
            "Perenes"});
            this.comboBox5.Location = new System.Drawing.Point(15, 181);
            this.comboBox5.Name = "comboBox5";
            this.comboBox5.Size = new System.Drawing.Size(113, 21);
            this.comboBox5.TabIndex = 18;
            // 
            // pctMenu
            // 
            this.pctMenu.Image = ((System.Drawing.Image)(resources.GetObject("pctMenu.Image")));
            this.pctMenu.Location = new System.Drawing.Point(9, 9);
            this.pctMenu.Name = "pctMenu";
            this.pctMenu.Size = new System.Drawing.Size(22, 20);
            this.pctMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctMenu.TabIndex = 21;
            this.pctMenu.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.label4.Font = new System.Drawing.Font("Gentium Basic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label4.Location = new System.Drawing.Point(15, 165);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Árvores";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Location = new System.Drawing.Point(178, 145);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(809, 279);
            this.panel2.TabIndex = 20;
            // 
            // form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(1027, 594);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.lblFlowerCampos);
            this.Controls.Add(this.panel1);
            this.Name = "form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctMenu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblFlowerCampos;
        private System.Windows.Forms.Label lblMenu;
        private System.Windows.Forms.PictureBox pctMenu;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cmbObjective;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lblVegetables;
        private System.Windows.Forms.Label lblFlowers;
        private System.Windows.Forms.ComboBox comboBox5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel2;
    }
}