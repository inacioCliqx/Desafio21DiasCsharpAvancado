using System;
using System.Collections.Generic;
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
            Console.WriteLine("Salvando o objeto no banco de dados");
            EnviarSMS();
        }
        public void Excluir()
        {
            Console.WriteLine("Excluindo o objeto no banco de dados");
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
