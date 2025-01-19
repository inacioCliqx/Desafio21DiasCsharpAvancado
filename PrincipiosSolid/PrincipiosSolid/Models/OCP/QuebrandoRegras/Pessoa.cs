using System;
using System.Collections.Generic;
using System.Text;

namespace PrincipiosSolid.Models.OCP.QuebrandoRegras
{
    public class Pessoa
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public TipoPessoa Tipo { get; set; }

        public Pessoa() { }

        public void Salvar()
        {
            if (this.Tipo == TipoPessoa.FISICA)
            {
                Console.WriteLine("Salvando Pessoa Fisica");
            } else if(this.Tipo == TipoPessoa.JURIDICA)
            {
                Console.WriteLine("Salvando Pessoa Juridica");
            }
        }
    }
}