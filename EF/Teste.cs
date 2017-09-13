using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF
{
    class Teste
    {
        static void Main(string[] args)
        {
            using (EFContext cntx = new EFContext())
            {
                Editora e = new Editora();
                e.Nome = "K19";
                e.Email = "contato@k19.com";

                cntx.Editoras.Add(e);

                cntx.SaveChanges();
            }
        }
    }
}
