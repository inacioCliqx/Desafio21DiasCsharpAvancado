using System;
using System.Collections.Generic;
using System.Text;

namespace PrincipiosSolid.Models.OCP.Solucao
{
    public interface IPessoa
    {
        int Id { get; set; }
        string Nome { get; set; }

        void Salvar();
    }
}