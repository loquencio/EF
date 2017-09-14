using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF
{
    class AdicionaPedidoConsumidor
    {
        static void Main(string[] args)
        {
            using(EFContext ctx = new EFContext())
            {
                Consumidor c = new EF.Consumidor();
                Console.WriteLine("Digite o nome do consumidor:");
                c.Nome = Console.ReadLine();

                Pedido p = new EF.Pedido();
                p.Consumidor = c;

                ctx.Pedidos.Add(p);

                ctx.SaveChanges();

                Console.WriteLine("Consumidor cadastrado com id: {0}", c.Id);
                Console.WriteLine("Pedido cadastrado com id: {0}", p.Id);
            }
        }
    }
}
