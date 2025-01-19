using System;
using System.Collections.Generic;
using System.Text;

namespace PrincipiosSolid.Models.OCP.Solucao
{
    public class Juridica : IPessoa, IPessoaJuridica
    {
        public Juridica() { }

        public int Id { get; set; }
        public string Nome { get; set; }
        public string CNPJ { get ; set; }

        public void Salvar()
        {
            throw new NotImplementedException();
        }
    }
}
