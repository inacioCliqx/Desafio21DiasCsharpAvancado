using System;
using System.Collections.Generic;
using System.Text;

namespace PrincipiosSolid.Models.SRP.Solucao
{
    public  class ClienteValidacao
    {
        public void ValidandoDados(Cliente cliente)
        {
            if (string.IsNullOrEmpty(cliente.Nome)) throw new Exception("Erro na validação dos dados. Nome é obrigatório");
            if (string.IsNullOrEmpty(cliente.Telefone)) throw new Exception("Erro na validação dos dados. Telefone é obrigatório");
            if (string.IsNullOrEmpty(cliente.Cpf)) throw new Exception("Erro na validação dos dados. Cpf é obrigatório");
        }
    }
}
