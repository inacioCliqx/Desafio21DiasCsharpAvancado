using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace PrincipiosSolid.Models.SRP.QuebrandoRegras
{
    internal class Cliente
    {
        public long Id { get; set; }
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public string Cpf { get; set; }

        public Cliente() { }

        public void Salvar()
        {
            if (!this.ValidandoDados()) throw new Exception("Erro na validação dos dados");
            Console.WriteLine("Salvando o objeto no banco de dados");
            EnviarSMS();
        }
        private bool ValidandoDados()
        {
            Console.WriteLine("Validando classe");
            return true;
        }
        public void Excluir()
        {
            using (var cn = new SqlConnection())
            {
                var cmd = new SqlCommand();
                cn.ConnectionString = "MInha conexao";
                cmd.Connection = cn;
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = "delete from clientes where id = "+ 1;

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
        public static List<Cliente> Buscar()
        {
            Console.WriteLine("Buscando lista de clientes");

            return new List<Cliente>();
        }
    }
}
