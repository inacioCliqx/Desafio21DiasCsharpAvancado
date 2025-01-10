using System;
using System.Collections.Generic;
using System.Text;

namespace Abstracao
{
    internal class HondaCivic : Carro
    {
        public override List<Carro> BuscarPorNome(string nome)
        {
            return new List<Carro>();
        }
        public override string ToString()
        {
            return $"HondaCivic - {this.Roda} - {this.Porta} - {this.Vidro}";
        }
    }
}
