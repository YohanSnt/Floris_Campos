using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Floris_Campos
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Cookies: a gente usa cookies para personalizar anúncios e melhorar a sua experiência no site. Ao continuar navegando, você concorda com a nossa Política de Privacidade.","Termos de Privacidade", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);




        }
        private void progressBar1_Click(object sender, EventArgs e)
        {
        }
        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            MessageBox.Show("Alfabetizado!");
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
          
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            
            MessageBox.Show("Nome Completo: " + txbName.Text + "\nEmail: " + txbEmail.Text + "\nSenha: " + txbPassword.Text, "Dados de Cadastro", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk );
            form2 novo = new form2();
            novo.Show();


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblObjective_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void lblPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void lblName_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("CÓDIGO: 5443267");
        }

        private void cmbObjective_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmbObjective.SelectedIndex == 3)
            
                lblPanel.Visible = false;
            else 
                lblPanel.Visible = true;

            
           

        }

        private void checkbxRobot_CheckedChanged(object sender, EventArgs e)
        {
            MessageBox.Show("Você confirma ter sentimentos?", "Não sou um robô", MessageBoxButtons.YesNo , MessageBoxIcon.Asterisk);
        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_2(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void progressBar1_Click_1(object sender, EventArgs e)
        {
          
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
       
                timer1.Enabled = false;
                this.Visible = false;

              
            }
        }
    }
    
