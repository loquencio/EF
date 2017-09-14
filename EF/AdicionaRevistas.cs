using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF
{
    class AdicionaRevistas
    {
        static void Main(string[] args)
        {
            using(EFContext ctx = new EFContext())
            {
                for (int i = 0; i < 100; i++)
                {
                    Revista r = new EF.Revista();
                    r.Nome = "Revista " + Convert.ToInt64(((i * 2 / 1.5) + 2 * 5) / 2.5);
                    r.Preco = 0.5 + ((i * 2 / 1.5) + 2 * 5) / 2.5;
                    ctx.Revistas.Add(r);
                }

                ctx.SaveChanges();
            }
        }
    }
}
