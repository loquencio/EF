using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF
{
    class AlteraEditoraComEF
    {
        static void Main(string[] args)
        {
            using(EFContext ctx = new EFContext()) { 
                Editora e = new EF.Editora();

                Console.Write("Digite o Id da Editora que deseja alterar:");
                e.Id = Convert.ToInt64(Console.ReadLine());

                e = ctx.Editoras.Find(e.Id);

                Console.Write("Digite o novo nome da Editora:");
                e.Nome = Console.ReadLine();

                Console.Write("Digite o novo email da Editora:");
                e.Email = Console.ReadLine();

                ctx.SaveChanges();
            }

        }
    }
}
