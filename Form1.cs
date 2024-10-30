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

namespace Floris_Campos //Tela Principal
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
       

            DialogResult result = MessageBox.Show("Antes de abrir o programa, desejamos uma boa experiència e que você possa atender suas necessidades em busca de plantas e " +
        "combinações para o seu jardim! \nBora lá?", "Bem-Vindo ao Floris_Campos", MessageBoxButtons.YesNo, MessageBoxIcon.Question); //Mensagem de boas vindas

            if ( result == DialogResult.No) //Resultado para 'Não' na mensagem
            {
                // Fecha o programa
                Application.Exit();
            }




        }
        private void progressBar1_Click(object sender, EventArgs e)
        {
        }
        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
          
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string name = txbName.Text;
            string email = txbEmail.Text;
            string password = txbPassword.Text;

            Property property;




            MessageBox.Show("Nome Completo: " + txbName.Text + "\nEmail: " + txbEmail.Text + "\nSenha: " + txbPassword.Text, "Dados de Cadastro", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk );
            this.Visible = false;
            form2 novo = new form2();
            novo.ShowDialog();
            this.Visible = true;

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
       
        }

        private void cmbObjective_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            
           

        }

        private void checkbxRobot_CheckedChanged(object sender, EventArgs e)
        {
              MessageBox.Show("Você será direcionado(a) para uma tela de confirmação", "Não sou um robô", MessageBoxButtons.OK , MessageBoxIcon.Asterisk);

           
            this.Hide();
           
            form3 form3 = new form3();
            form3.FormClosed += (s, args) => this.Show(); // Mostra o frmMain novamente quando form3 for fechado
            form3.Show();



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
    
