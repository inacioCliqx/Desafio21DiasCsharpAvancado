using System;
using System.Collections.Generic;
using System.Text;

namespace PrincipiosSolid.Models.SRP.Solucao
{
    public class Cliente
    {
        public long Id { get; set; }
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public string Cpf { get; set; }

        public Cliente() { }
    }
}
