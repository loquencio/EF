using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF
{
    class AdicionaDepartamentoFuncionario
    {
        static void Main(string[] args)
        {
            using(EFContext ctx = new EFContext())
            {
                Funcionario f1 = new EF.Funcionario();
                Console.Write("Digite o nome do primeiro funcionário:");
                f1.Nome = Console.ReadLine();

                Funcionario f2 = new EF.Funcionario();
                Console.Write("Digite o nome do segundo funcionário:");
                f2.Nome = Console.ReadLine();

                Funcionario f3 = new Funcionario();
                Console.Write("Digite o nome do terceiro funcionário:");
                f3.Nome = Console.ReadLine();

                Departamento d = new Departamento();
                Console.Write("Digite o nome do departamento:");
                d.Nome = Console.ReadLine();

                d.Funcionarios = new List<Funcionario>();

                d.Funcionarios.Add(f1);
                d.Funcionarios.Add(f2);
                d.Funcionarios.Add(f3);

                ctx.Departamentos.Add(d);

                ctx.SaveChanges();
                
                foreach(Funcionario f in d.Funcionarios)
                {
                    Console.WriteLine("Funcionario " + f.Nome + " gravado com Id: " + f.Id);
                }

                Console.WriteLine("Departamento " + d.Nome + " salvo com Id: " + d.Id);
            }
        }
    }
}
