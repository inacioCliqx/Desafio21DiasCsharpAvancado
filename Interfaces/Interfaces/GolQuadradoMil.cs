using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces
{
    internal class GolQuadradoMil : GolQuadrado
    {
        //sobreescrita e polimorfismo da classe
        public override void Salvar()
        {
            Console.WriteLine("Salvando dados...");
            //base.Salvar();
        }
        public new void Excluir()
        {
            Console.WriteLine("Ação[GolQuadradoMil] para excluir dados...");
        }
        public override string ToString()
        {
            return $"{this.Marca} - {this.Nome} - {this.Ano}";
        }
    }
}
