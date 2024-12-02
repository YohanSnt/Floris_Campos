using System;

namespace Floris_Campos
{
    partial class FrmFloricultor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmFloricultor));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.ltvBroker = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblEstado = new System.Windows.Forms.Label();
            this.lblSenha = new System.Windows.Forms.Label();
            this.txbNome = new System.Windows.Forms.TextBox();
            this.txbEmail1 = new System.Windows.Forms.TextBox();
            this.txbSenha = new System.Windows.Forms.TextBox();
            this.bttSalvar = new System.Windows.Forms.Button();
            this.bttLimpar = new System.Windows.Forms.Button();
            this.bttEditar = new System.Windows.Forms.Button();
            this.bttExcluir = new System.Windows.Forms.Button();
            this.lblBroker = new System.Windows.Forms.Label();
            this.cmbEstado = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            // 
            // ltvBroker
            // 
            this.ltvBroker.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.ltvBroker.HideSelection = false;
            this.ltvBroker.Location = new System.Drawing.Point(-2, 357);
            this.ltvBroker.Name = "ltvBroker";
            this.ltvBroker.Size = new System.Drawing.Size(646, 166);
            this.ltvBroker.TabIndex = 17;
            this.ltvBroker.UseCompatibleStateImageBehavior = false;
            this.ltvBroker.View = System.Windows.Forms.View.Details;
            this.ltvBroker.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Nome";
            this.columnHeader1.Width = 215;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Email";
            this.columnHeader2.Width = 253;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Senha";
            this.columnHeader3.Width = 106;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Estado";
            this.columnHeader4.Width = 71;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-507, -329);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1910, 1191);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.lblNome.Font = new System.Drawing.Font("Reem Kufi", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(45, 77);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(72, 35);
            this.lblNome.TabIndex = 18;
            this.lblNome.Text = "Nome:";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.lblEmail.Font = new System.Drawing.Font("Reem Kufi", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(45, 169);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(69, 35);
            this.lblEmail.TabIndex = 19;
            this.lblEmail.Text = "Email:";
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.lblEstado.Font = new System.Drawing.Font("Reem Kufi", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstado.Location = new System.Drawing.Point(482, 169);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(81, 35);
            this.lblEstado.TabIndex = 20;
            this.lblEstado.Text = "Estado:";
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.lblSenha.Font = new System.Drawing.Font("Reem Kufi", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSenha.Location = new System.Drawing.Point(40, 267);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(74, 35);
            this.lblSenha.TabIndex = 21;
            this.lblSenha.Text = "Senha:";
            // 
            // txbNome
            // 
            this.txbNome.BackColor = System.Drawing.SystemColors.Info;
            this.txbNome.Location = new System.Drawing.Point(123, 90);
            this.txbNome.Name = "txbNome";
            this.txbNome.Size = new System.Drawing.Size(268, 20);
            this.txbNome.TabIndex = 22;
            this.txbNome.TextChanged += new System.EventHandler(this.txbNome_TextChanged);
            // 
            // txbEmail1
            // 
            this.txbEmail1.BackColor = System.Drawing.SystemColors.Info;
            this.txbEmail1.Location = new System.Drawing.Point(123, 182);
            this.txbEmail1.Name = "txbEmail1";
            this.txbEmail1.Size = new System.Drawing.Size(268, 20);
            this.txbEmail1.TabIndex = 23;
            // 
            // txbSenha
            // 
            this.txbSenha.BackColor = System.Drawing.SystemColors.Info;
            this.txbSenha.Location = new System.Drawing.Point(123, 280);
            this.txbSenha.Name = "txbSenha";
            this.txbSenha.PasswordChar = '*';
            this.txbSenha.Size = new System.Drawing.Size(268, 20);
            this.txbSenha.TabIndex = 24;
            this.txbSenha.UseSystemPasswordChar = true;
            // 
            // bttSalvar
            // 
            this.bttSalvar.Font = new System.Drawing.Font("Reem Kufi", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttSalvar.Location = new System.Drawing.Point(660, 374);
            this.bttSalvar.Name = "bttSalvar";
            this.bttSalvar.Size = new System.Drawing.Size(92, 30);
            this.bttSalvar.TabIndex = 26;
            this.bttSalvar.Text = " Salvar";
            this.bttSalvar.UseVisualStyleBackColor = true;
            this.bttSalvar.Click += new System.EventHandler(this.button1_Click);
            // 
            // bttLimpar
            // 
            this.bttLimpar.Font = new System.Drawing.Font("Reem Kufi", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttLimpar.Location = new System.Drawing.Point(769, 374);
            this.bttLimpar.Name = "bttLimpar";
            this.bttLimpar.Size = new System.Drawing.Size(92, 30);
            this.bttLimpar.TabIndex = 27;
            this.bttLimpar.Text = "Limpar";
            this.bttLimpar.UseVisualStyleBackColor = true;
            this.bttLimpar.Click += new System.EventHandler(this.bttLimpar_Click);
            // 
            // bttEditar
            // 
            this.bttEditar.Font = new System.Drawing.Font("Reem Kufi", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttEditar.Location = new System.Drawing.Point(660, 461);
            this.bttEditar.Name = "bttEditar";
            this.bttEditar.Size = new System.Drawing.Size(92, 30);
            this.bttEditar.TabIndex = 28;
            this.bttEditar.Text = "Editar";
            this.bttEditar.UseVisualStyleBackColor = true;
            this.bttEditar.Visible = false;
            // 
            // bttExcluir
            // 
            this.bttExcluir.Font = new System.Drawing.Font("Reem Kufi", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttExcluir.Location = new System.Drawing.Point(769, 461);
            this.bttExcluir.Name = "bttExcluir";
            this.bttExcluir.Size = new System.Drawing.Size(92, 30);
            this.bttExcluir.TabIndex = 29;
            this.bttExcluir.Text = "Excluir";
            this.bttExcluir.UseVisualStyleBackColor = true;
            this.bttExcluir.Visible = false;
            // 
            // lblBroker
            // 
            this.lblBroker.AutoSize = true;
            this.lblBroker.BackColor = System.Drawing.Color.White;
            this.lblBroker.Font = new System.Drawing.Font("Reem Kufi", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBroker.Location = new System.Drawing.Point(366, 9);
            this.lblBroker.Name = "lblBroker";
            this.lblBroker.Size = new System.Drawing.Size(178, 23);
            this.lblBroker.TabIndex = 30;
            this.lblBroker.Text = "CADASTRO FLORICULTOR";
            // 
            // cmbEstado
            // 
            this.cmbEstado.BackColor = System.Drawing.SystemColors.Info;
            this.cmbEstado.FormattingEnabled = true;
            this.cmbEstado.Items.AddRange(new object[] {
            "Acre (AC)",
            "Alagoas (AL)",
            "Amapá (AP)",
            "Amazonas (AM)",
            "Bahia (BA)",
            "Ceará (CE)",
            "Distrito Federal (DF)",
            "Espírito Santo (ES)",
            "Goiás (GO)",
            "Maranhão (MA)",
            "Mato Grosso (MT)",
            "Mato Grosso do Sul (MS)",
            "Minas Gerais (MG)",
            "Pará (PA)",
            "Paraíba (PB)",
            "Paraná (PR)",
            "Pernambuco (PE)",
            "Piauí (PI)",
            "Rio de Janeiro (RJ)",
            "Rio Grande do Norte (RN)",
            "Rio Grande do Sul (RS)",
            "Rondônia (RO)",
            "Roraima (RR)",
            "Santa Catarina (SC)",
            "São Paulo (SP)",
            "Sergipe (SE)",
            "Tocantins (TO)"});
            this.cmbEstado.Location = new System.Drawing.Point(569, 181);
            this.cmbEstado.Name = "cmbEstado";
            this.cmbEstado.Size = new System.Drawing.Size(90, 21);
            this.cmbEstado.TabIndex = 31;
            // 
            // FrmFloricultor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(912, 522);
            this.Controls.Add(this.cmbEstado);
            this.Controls.Add(this.lblBroker);
            this.Controls.Add(this.bttExcluir);
            this.Controls.Add(this.bttEditar);
            this.Controls.Add(this.bttLimpar);
            this.Controls.Add(this.bttSalvar);
            this.Controls.Add(this.txbSenha);
            this.Controls.Add(this.txbEmail1);
            this.Controls.Add(this.txbNome);
            this.Controls.Add(this.lblSenha);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.ltvBroker);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmFloricultor";
            this.Text = "FrmBroker";
            this.Load += new System.EventHandler(this.FrmFloricultor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void FrmBroker_Load(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void lblHome_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ListView ltvBroker;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.TextBox txbNome;
        private System.Windows.Forms.TextBox txbEmail1;
        private System.Windows.Forms.TextBox txbSenha;
        private System.Windows.Forms.Button bttSalvar;
        private System.Windows.Forms.Button bttLimpar;
        private System.Windows.Forms.Button bttEditar;
        private System.Windows.Forms.Button bttExcluir;
        private System.Windows.Forms.Label lblBroker;
        private System.Windows.Forms.ComboBox cmbEstado;
    }
}