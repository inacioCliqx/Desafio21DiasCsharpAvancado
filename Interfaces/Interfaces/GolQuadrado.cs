using Interfaces.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces
{
    internal class GolQuadrado : IVeiculo
    {
        public string Marca { get; set; }
        public string Nome { get; set; }
        public int Ano { get; set; }

        private string logo = "imagem1.png";
        public GolQuadrado() { }

        public virtual void Salvar()
        {
            throw new NotImplementedException();
        }
        public void Excluir()
        {
            Console.WriteLine("Ação para excluir dados...");
        }
    }
}
