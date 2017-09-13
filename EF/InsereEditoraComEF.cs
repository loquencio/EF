using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF
{
    class InsereEditoraComEF
    {
        static void Main(string[] args)
        {
            using (EFContext ctx = new EFContext())
            {
                Editora e = new Editora();

                Console.Write("Digite o nome da Editora:");
                e.Nome = Console.ReadLine();

                Console.WriteLine("Digite o e-mail da Editora:");
                e.Email = Console.ReadLine();

                ctx.Editoras.Add(e);
                ctx.SaveChanges();

                Console.WriteLine("Editora cadastrada com id: " + e.Id);

                Console.ReadLine();
            }
        }
    }
}
