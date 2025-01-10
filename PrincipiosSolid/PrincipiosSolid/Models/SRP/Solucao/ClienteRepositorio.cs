using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace PrincipiosSolid.Models.SRP.Solucao
{
    public class ClienteRepositorio
    {
        public void Salvar(ref Cliente cliente)
        {
            
            using (var cn = new SqlConnection())
            {
                var cmd = new SqlCommand();
                cn.ConnectionString = "MInha conexao";
                cmd.Connection = cn;
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = "insert into ...";

                cn.Open();
                cmd.ExecuteScalar();
                cn.Close();
                Console.WriteLine("Salvando o objeto no banco de dados");

            }
        }

       
        public void Excluir()
        {
            using (var cn = new SqlConnection())
            {
                var cmd = new SqlCommand();
                cn.ConnectionString = "MInha conexao";
                cmd.Connection = cn;
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = "delete from clientes where id = " + 1;

                cn.Open();
                cmd.ExecuteScalar();
                cn.Close();
                Console.WriteLine("Excluindo o objeto no banco de dados");

            }
        }
        public bool EnviarSMS()
        {
            Console.WriteLine("Enviando SMS...");
            return true;
        }
    }
}
