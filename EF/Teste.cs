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
                    var res = cntx.Autores;
                    
                    foreach (Autor autor in res) { 
                        Console.WriteLine("{0} - {1}: ", autor.Id, autor.Nome);
                        var livros =  cntx.Livros.Where(x => x.Autores.Contains(autor));
                        foreach (Livro livro in livros) 
                            Console.WriteLine("\t{0}", livro.Nome);
                    }
                    Console.ReadKey();
                }
            } catch (SystemException e)
            {
                Console.WriteLine(e.Message);
                Console.ReadKey();
            }
        }
    }
}
