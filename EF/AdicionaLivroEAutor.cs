using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF
{
    class AdicionaLivroEAutor
    {
        static void Main(string[] args)
        {
            Autor a1 = new EF.Autor();
            Console.Write("Insira o nome do Autor: ");
            a1.Nome = Console.ReadLine();
            
            Autor a2 = new EF.Autor();
            Console.Write("Insira o nome do Autor: ");
            a2.Nome = Console.ReadLine();

            Livro l1 = new Livro();
            Console.Write("Insira o nome do livro: ");
            l1.Nome = Console.ReadLine();

            a1.Livros.Add(l1);
            a2.Livros.Add(l1);
            l1.Autores.Add(a1);
            l1.Autores.Add(a2);

            Livro l2 = new Livro();
            Console.Write("Insira o nome do livro: ");
            l2.Nome = Console.ReadLine();

            a1.Livros.Add(l2);
            l2.Autores.Add(a1);
            
            using (EFContext ctx = new EFContext())
            {
                ctx.Autores.Add(a1);
                ctx.Autores.Add(a2);
                ctx.Livros.Add(l1);
                ctx.Livros.Add(l2);

                ctx.SaveChanges();
            }
        }
    }
}
