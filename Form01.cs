using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Floris_Campos
{
    public partial class Form01 : Form
    {
        public Form01()
        {
            InitializeComponent();
        }

        private void lblHome_Click(object sender, EventArgs e)
        {

        }

        private void lblUsuario_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            FrmMain novo1 = new FrmMain();
            novo1.ShowDialog();
            this.Visible = true;
        }

        private void bttCdfloricultor_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            FrmFloricultor novo = new FrmFloricultor();
            novo.ShowDialog();
            this.Visible = true;
        }

        private void Form01_Load(object sender, EventArgs e)
        {

            DialogResult result = MessageBox.Show("Antes de abrir o programa, desejamos uma boa experiència e que você possa atender suas necessidades em busca de plantas e " +
        "combinações para o seu jardim! \nBora lá?", "Bem-Vindo ao Floris_Campos", MessageBoxButtons.YesNo, MessageBoxIcon.Question); //Mensagem de boas vindas

            if (result == DialogResult.No) //Resultado para 'Não' na mensagem
            {
                // Fecha o programa
                Application.Exit();
            }
        }
    }
}
