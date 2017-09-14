using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF
{
    class Consultas
    {
        static void Main(string[] args) { 
            using(EFContext ctx = new EFContext()){
                Console.WriteLine("Existem {0} revistas cadastradas.\n", ctx.Revistas.Count());

                Console.WriteLine("Existem {0} revistas com o preco acima de 50.\n", ctx.Revistas.Count(x => x.Preco > 50));

                Console.WriteLine("A soma dos preços das revistas é igual a {0}. \n", ctx.Revistas.Sum(x => x.Preco));

                Console.WriteLine("O maior preço de revista é " + ctx.Revistas.Max(x => x.Preco));

                Console.ReadKey();
            }
        }
    }
}
