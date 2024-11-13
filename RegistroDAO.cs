using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.Drawing;
using Floris_Campos.Controller;
using Floris_Campos.Model;


namespace Floris_Campos
{
    internal class RegistroDAO
    {
         private Connection Connect { get; set; }
         private SqlCommand Command { get; set; }
         public RegistroDAO() 
             { 
             Connect = new Connection();
             Command = new SqlCommand();
             }
        private string ComputeSha256Hash(string rawData)
        {
            using (SHA256 sha256Hash = SHA256.Create())
            {
                // ComputeHash - returns byte array
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(rawData));

                // Convert byte array to a string
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }

        public void Insert(Property prop)
         {
            Command.Connection = Connect.ReturnConnection();
            Command.CommandText = @"INSERT INTO tabelafloriscampos (Nome, Email, Senha) VALUES (@Nome, @Email, @Senha)";

            Command.Parameters.AddWithValue("@Nome", prop.Name);
            Command.Parameters.AddWithValue("@Email", prop.Email);
            Command.Parameters.AddWithValue("@Senha", ComputeSha256Hash(prop.Password));

            try
            {
                // Executa a query definida acima
                Command.ExecuteNonQuery();
            }
            catch (Exception err)
            {
                throw new Exception("Erro: Problemas ao inserir" + err.Message);
            }
            finally
            {
                Connect.CloseConnection();
            }
        }

        public void Update(Property prop)
        {
            Command.Connection = Connect.ReturnConnection();
            Command.CommandText = @"UPDATE tabelafloriscampos SET 
        CodUsuario = @codusuario, 
        Nome = @nome, 
        Email = @email,
        Senha = @senha 
        WHERE CodUsuario = @codusuario";

            Command.Parameters.AddWithValue("@codusuario", prop.CodUsuario);
            Command.Parameters.AddWithValue("@nome", prop.Name);
            Command.Parameters.AddWithValue("@email", prop.Email);
            Command.Parameters.AddWithValue("@senha", prop.Password);
            try
            {
                Command.ExecuteNonQuery();
            }
            catch (Exception err)
            {
                throw new Exception("Erro: Problemas ao realizar atualização de usuário no banco.\n" + err.Message);
            }
            finally
            {
                Connect.CloseConnection();
            }
        }

        public void Excluir(int idProperty)
        {
            Command.Connection = Connect.ReturnConnection();
            Command.CommandText = @"DELETE FROM Property WHERE CodUsuario = @codusuario";
            Command.Parameters.AddWithValue("@codusuario", idProperty);
            try
            {
                Command.ExecuteNonQuery();
            }
            catch (Exception err)
            {
                throw new Exception("Erro: Problemas ao excluir usuário no banco.\n" + err.Message);
            }
            finally
            {
                Connect.CloseConnection();
            }
        }
        public List<Property> ListarTodosProperty()
        {

            Command.Connection = Connect.ReturnConnection();
            Command.CommandText = "SELECT * FROM Property";

            List<Property> listaDeProperty = new List<Property>(); //Instancio a list com o tamanho padrão.
            try
            {
                SqlDataReader rd = Command.ExecuteReader();

                //Enquanto for possível continuar a leitura das linhas que foram retornadas na consulta, execute.
                while (rd.Read())
                {
                    Property Property = new Property (
                        (int)rd["CodUsuario"],
                        (string)rd["Nome"], 
                        (string)rd["Email"],
                        (string)rd["Senha"]);
                    
                    listaDeProperty.Add(Property);
                }
                rd.Close();
            }
            catch (Exception err)
            {
                throw new Exception("Erro: Problemas ao realizar leitura de usuários no banco.\n" + err.Message);
            }
            finally
            {
                Connect.CloseConnection();
            }

            return listaDeProperty;
        }

      
        }
    }
