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
            try { 
                using (EFContext cntx = new EFContext())
                {
                    Editora e = new Editora();
                    e.Nome = "K19";
                    e.Email = "contato@k19.com";

                    cntx.Editoras.Add(e);

                    cntx.SaveChanges();

                    Console.WriteLine("Deu tudo certo porra");
                }
            } catch (SystemException e)
            {
                Console.WriteLine(e.Message);
                Console.ReadKey();
            }
        }
    }
}
