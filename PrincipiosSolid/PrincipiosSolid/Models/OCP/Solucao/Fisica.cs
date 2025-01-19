using System;
using System.Collections.Generic;
using System.Text;

namespace PrincipiosSolid.Models.OCP.Solucao
{
    public class Fisica : IPessoa, IPessoaFisica
    {
        public int Id { get; set; }
        public string Nome { get ; set; }
        public string CPF { get; set; }

        public void Salvar()
        {
            throw new NotImplementedException();
        }
    }
}
