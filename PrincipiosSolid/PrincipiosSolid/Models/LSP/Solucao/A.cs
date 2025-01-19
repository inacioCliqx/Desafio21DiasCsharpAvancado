using System;
using System.Collections.Generic;
using System.Text;

namespace PrincipiosSolid.Models.LSP.Solucao
{
    public class A
    {
        public A() { }

        public virtual void GetNome()
        {
            Console.WriteLine("Nome do usuario");
        }
    }
}
