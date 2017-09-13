using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF
{
    class ListarEditorasComEF
    {
        static void Main(string[] args)
        {
            using (EFContext ctx = new EFContext())
            {
                foreach(Editora e in ctx.Editoras)
                {
                    Console.WriteLine("Editora {0} - {1}", e.Nome, e.Email);
                }
            }
        }
    }
}
