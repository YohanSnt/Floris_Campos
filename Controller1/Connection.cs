using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Floris_Campos
{
    internal class Connection
    {
        private SqlConnection con;
        private string DataBase = "PR2CJ3022625FLORISCAMPOS";
        private string Server = "sqlexpress";
        private string Username = "aluno";
        private string Password = "aluno";

        public Connection()
        {
            string stringConnection = @"PR2CJ3022625FLORISCAMPOS = " + Server
            + "; Initial Catalog = " + DataBase
            + ": User Id =" + Username
            + ": Password =" + Password
            + ": Encrypt = false";

            con = new SqlConnection(stringConnection);
            con.Open();

        }
        //tenta fechar a conexão com o banco
        public void CloseConnection() {
            {
                if (con.State == System.Data.ConnectionState.Open)
                    con.Close();
            }
        }
        //retorna a conexão que foi aberta
        public SqlConnection ReturnConnection()
        {
            return con;
        }
    }
}
