using Floris_Campos.Model;
using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Floris_Campos
{
    public partial class FrmFloricultor : Form
    {
        private int Id = -1;
        public FrmFloricultor()
        {
            InitializeComponent();
        }

        private void ClearFields()
        {
            txbNome.Clear();
            txbEmail1.Clear();
            cmbEstado.SelectedIndex = 0;
            txbSenha.Clear();
            bttExcluir.Visible = false;
            bttEditar.Visible = false;
        }
        private void UpdateListView()
        {
            ltvBroker.Items.Clear();

            FloricultorDAO brokerDAO = new FloricultorDAO();
            List<Floricultor> brokers = brokerDAO.ListAllBrokers();

            //This code part access all brokers received from database and iterate by them.
            foreach (Floricultor broker in brokers)
            {
                //Creating a fully line of listview with items from database.
                ListViewItem item = new ListViewItem(broker.Id.ToString());
                item.SubItems.Add(broker.Nome);
                item.SubItems.Add(broker.Estado);
                item.SubItems.Add(broker.Email);
                //Adding the fully line to the listview.
                ltvBroker.Items.Add(item);
            }
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            try
            {
                //Capture inputed text from fields.
                if (new FloricultorDAO().Insert(new Floricultor(
                    txbNome.Text, cmbEstado.Text,
                    txbEmail1.Text, txbSenha.Text)))
                    MessageBox.Show("Floricultor cadastrado!", "SUCESSO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            UpdateListView();
        }

        private void FrmBroker1(object sender, EventArgs e)
        {
            UpdateListView();
        }

        private void ltvBroker_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int index;
            try
            {
                index = ltvBroker.FocusedItem.Index;
                Id = int.Parse(ltvBroker.Items[index].SubItems[0].Text);
                txbNome.Text = ltvBroker.Items[index].SubItems[1].Text;
                cmbEstado.Text = ltvBroker.Items[index].SubItems[3].Text;
                txbEmail1.Text = ltvBroker.Items[index].SubItems[5].Text;
                txbSenha.Text = ltvBroker.Items[index].SubItems[6].Text;

                bttExcluir.Visible = true;
                bttEditar.Visible = true;

            }

            catch (Exception)
            {
                MessageBox.Show("Você precisa selecionar uma linha", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            FloricultorDAO brokerDao = new FloricultorDAO();

            DialogResult resultado = MessageBox.Show("Tem certeza" +
            " que deseja excluir?", "CONFIRMAÇÃO", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (resultado == DialogResult.Yes)
            {
                try
                {
                    brokerDao.Delete(Id);
                }
                catch (Exception err)
                {
                    MessageBox.Show(err.Message, "AVISO DE ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                UpdateListView();
                ClearFields();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearFields();

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                //Capture inputed text from fields.
                new FloricultorDAO().Update(new Floricultor(
                    Id, txbNome.Text, cmbEstado.Text, txbEmail1.Text, txbSenha.Text));
                MessageBox.Show("Corretor atualizado!", "SUCESSO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            UpdateListView();
        }


        private void txbNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nome = txbNome.Text;
            string estado = cmbEstado.Text;
            string email1 = txbEmail1.Text;
            string senha = txbSenha.Text;


            if (IsValidEmail(email1))
            {
                MessageBox.Show("E-mail válido.");

                Floricultor registro = new Floricultor(nome, estado, email1, senha);

                FloricultorDAO util = new FloricultorDAO();
                util.Insert(registro);
            }
        }

        private bool IsValidEmail(string email)
        {
           return Regex.IsMatch(email, @"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z", RegexOptions.IgnoreCase);
        }

        private void FrmFloricultor_Load(object sender, EventArgs e)
        {
            UpdateListView();
        }
    }
}
