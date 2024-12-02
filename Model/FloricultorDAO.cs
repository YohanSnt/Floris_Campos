using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Floris_Campos.Controller;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Floris_Campos;

namespace Floris_Campos.Model
{
    internal class FloricultorDAO
    {
        private Connection Connect { get; set; }
        private SqlCommand Command { get; set; }
        //Sempre o nome da classe
        public FloricultorDAO() //método construtor
        {
            Connect = new Connection();
            Command = new SqlCommand();
        }
        public bool Insert(Floricultor broker)
        {
            Command.Connection = Connect.ReturnConnection();
            Command.CommandText =
            @"INSERT INTO 
            Floricultor VALUES 
            (@nome, @estado, @email, @senha)";

            Command.Parameters.AddWithValue("@nome", broker.Nome);
            Command.Parameters.AddWithValue("@estado", broker.Estado);
            Command.Parameters.AddWithValue("@email", broker.Email);
            Command.Parameters.AddWithValue("@senha", broker.Senha);

            try
            {

                Command.ExecuteNonQuery();
            }
            catch (Exception err)
            {
                throw new Exception("Erro: Problemas ao inserir " +
                    "corretor no banco.\n" + err.Message);
            }
            finally
            {
                Connect.CloseConnection();
            }
            return true;
        }


        public void Update(Floricultor broker)
        {
            Command.Connection = Connect.ReturnConnection();
            Command.CommandText = @"UPDATE Broker SET 
            BrokerNome = @nome,
            Estado = @estado,
            Email = @email,
            Senha = @senha
            WHERE Id = @id";

            Command.Parameters.AddWithValue("@id", broker.Id);
            Command.Parameters.AddWithValue("@nome", broker.Nome);
            Command.Parameters.AddWithValue("@estado", broker.Estado);
            Command.Parameters.AddWithValue("@email", broker.Email);
            Command.Parameters.AddWithValue("@senha", broker.Senha);

            try
            {
                Command.ExecuteNonQuery();
            }
            catch (Exception err)
            {
                throw new Exception("Erro: " +
                    "Problemas ao realizar atualização dos dados do " +
                    "corretor no banco.\n" + err.Message);
            }
            finally
            {
                Connect.CloseConnection();
            }
        }

        public void Delete(int brokerCode)
        {
            Command.Connection = Connect.ReturnConnection();
            Command.CommandText = @"DELETE FROM Broker 
            WHERE Id = @id";
            Command.Parameters.AddWithValue("@id", brokerCode);
            try
            {
                Command.ExecuteNonQuery();
            }
            catch (Exception err)
            {
                throw new Exception("Erro: Problemas ao excluir " +
                    "cadastro do corretor do banco.\n" + err.Message);
            }
            finally
            {
                Connect.CloseConnection();
            }
        }
        public List<Floricultor> ListAllBrokers()
        {

            Command.Connection = Connect.ReturnConnection();
            Command.CommandText = "SELECT * FROM Floricultor";

            List<Floricultor> brokers = new List<Floricultor>(); //Instancio a list com o tamanho padrão.
            try
            {
                SqlDataReader rd = Command.ExecuteReader();

                //Enquanto for possível continuar a leitura das linhas que foram retornadas na consulta, execute.
                while (rd.Read())
                {
                    Floricultor broker = new Floricultor(
                        (int)rd["Id"],
                        (string)rd["Nome"],
                        (string)rd["Estado"],
                        (string)rd["Email"],
                        (string)rd["Senha"]
                        );
                    brokers.Add(broker);
                }
                rd.Close();
            }
            catch (Exception err)
            {
                throw new Exception("Erro: Problemas ao realizar " +
                    "leitura de imóveis no banco.\n" + err.Message);
            }
            finally
            {
                Connect.CloseConnection();
            }

            return brokers;
        }
        public bool ValidateLogin(Floricultor broker)
        {

            Command.Connection = Connect.ReturnConnection();
            Command.CommandText = "SELECT * FROM Broker WHERE " +
                                  "Senha = @senha";
            Command.Parameters.AddWithValue("@senha", broker.Senha);

            try
            {
                SqlDataReader rd = Command.ExecuteReader();
                if (rd.HasRows)
                {
                    rd.Close();
                    return true;
                }
            }
            catch (Exception err)
            {
                throw new Exception("Erro: Problemas ao realizar " +
                    "leitura de dados do corretor no banco.\n" + err.Message);
            }
            finally
            {
                Connect.CloseConnection();
            }

            return false;
        }
    }
}
        
   


