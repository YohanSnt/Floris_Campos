using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
         public void Insert(Property prop)
         {
          Command.Connection = Connect.ReturnConnection();
            Command.CommandText = @"INSERT INTO Usuarios VALUES (@nome, @email, @senha)";

            Command.Parameters.AddWithValue("@nome",prop.Name);
            Command.Parameters.AddWithValue("@email", prop.Email);
            Command.Parameters.AddWithValue("@senha", prop.Password);


          try
            {
                //executa query definida acima
                Command.ExecuteNonQuery();
            }
            catch (Exception err)
            {
                throw new Exception("Erro: Problemas ao inserir" + "usuário.\n" + err.Message);

            }
            finally
            {
                Connect.CloseConnection();
            }
        }


    }
}