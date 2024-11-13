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
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Floris_Campos //Tela Principal
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }
        private bool IsValidEmail(string email)
        {
            string pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            return Regex.IsMatch(email, pattern);
        }


       


       

        private void Form1_Load(object sender, EventArgs e)
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
            

            if (IsValidEmail(email))
            {
              MessageBox.Show ("E-mail válido.");

                Property registro = new Property(name, email, password);

                RegistroDAO registroDAO = new RegistroDAO();

                registroDAO.Insert(registro);




                MessageBox.Show("Nome Completo: " + txbName.Text + "\nEmail: " + txbEmail.Text + "\nSenha: " + txbPassword.Text, "Dados de Cadastro", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
                this.Visible = false;
                form2 novo = new form2();
                novo.ShowDialog();
                this.Visible = true;



                // Prosseguir
                DialogResult result = MessageBox.Show("Nome Completo: " + txbName.Text + "\nEmail: " + txbEmail.Text + "\nSenha: " + txbPassword.Text, "Dados de Cadastro", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);

                if (result == DialogResult.Cancel) //Resultado para 'Cancelar' na mensagem
                {
                    // Fecha a mensagem
                    this.Show();
                }
                else
                {
                    //Abre o form2
                    this.Visible = false;
                    form2 novo1 = new form2();
                    novo1.ShowDialog();
                    this.Visible = true;
                }

            }
            else
            {
                MessageBox.Show("E-mail inválido.");

            }

         
          

        }

     
        private void lblPanel_Paint(object sender, PaintEventArgs e)
        {

        }

      

        private void lblName_Click(object sender, EventArgs e)
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

        private void timer1_Tick(object sender, EventArgs e)
        {
       
                timer1.Enabled = false;
                //this.Visible = false;

              
            }

        private void txbPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void lblHome_Click(object sender, EventArgs e)
        {

        }

        private void lblPassword_Click(object sender, EventArgs e)
        {

        }

        private void lblEmail_Click(object sender, EventArgs e)
        {

        }

       
    }
    }
    
