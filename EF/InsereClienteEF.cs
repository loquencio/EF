using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF
{
    class InsereClienteEF
    {
        static void Main(string[] args)
        {
            using(EFContext ctx = new EFContext())
            {
                Cliente c = new EF.Cliente();

                Console.Write("Digite o nome do cliente:");
                c.Nome = Console.ReadLine();

                Console.Write("Digite o cpf do cliente:");
                c.Cpf = Console.ReadLine();

                Endereco e = new Endereco();

                Console.Write("Digite o endereço do cliente(separado por vírgulas): ");
                string endereco = Console.ReadLine();

                string[] enderecos = endereco.Split(',');

                e.Logradouro = enderecos[0];
                e.Numero = enderecos[1];
                e.Cep = enderecos[2];
                e.Bairo = enderecos[3];
                e.Municipio = enderecos[4];
                e.Estado = enderecos[5];
                e.Pais = enderecos[6];

                c.Endereco = e;

                ctx.Clientes.Add(c);

                ctx.SaveChanges();

                Console.WriteLine("Cliente salvo com o id: " + c.Id);
            }
        }
    }
}
