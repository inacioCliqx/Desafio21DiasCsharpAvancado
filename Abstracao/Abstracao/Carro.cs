using Abstracao.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Abstracao
{
    public abstract class Carro : ICarro
    {
        public string Roda { get; set; }
        public string Porta { get; set; }
        public string Vidro { get; set; }

        public List<Carro> Todos()
        {
            return new List<Carro>();
        }
        public abstract List<Carro> BuscarPorNome(string nome);
    }
}
