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
    public partial class form3 : Form
    {
        public form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            form2 novo = new form2();
            novo.ShowDialog();
            this.Visible = true;
        }
    }
}
