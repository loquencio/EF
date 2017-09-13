using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF
{
    class InsereEstadoEGovernador
    {
        static void Main(string[] args)
        {
            using(EFContext ctx = new EFContext()) { 
                Governador g = new Governador();
                Console.WriteLine("Digite o nome do governador:");
                g.Nome = Console.ReadLine();

                Estado e = new Estado();
                Console.WriteLine("Digite o nome do estado:");
                e.Nome = Console.ReadLine();

                e.Governador = g;

                ctx.Estados.Add(e);

                ctx.SaveChanges();

                Console.WriteLine("Governador cadastrado com id:" + g.Id);
                Console.WriteLine("Estado cadastrado com id:" + e.Id);
            }

        }
    }
}
