using System;
using System.Collections.Generic;
using System.Text;

namespace PrincipiosSolid.Models.LSP.Solucao
{
    public class B : A
    {
        public B() { }

        public override void GetNome()
        {
            Console.WriteLine("Nome do usuario B");
        }
    }
}
