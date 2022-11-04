using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sla
{
    class Program
    {
        static void Main(string[] args)
        {
            String nome;
            String endereço;
            String telefone;

            Console.WriteLine("colocar nome:");
            nome = Console.ReadLine();
            Console.WriteLine("colocar endereço: ");
            endereço = Console.ReadLine();
            Console.WriteLine("telefone: ");
            telefone = Console.ReadLine();

            Console.WriteLine(" ");
            Console.WriteLine("nome:");
            Console.WriteLine(nome);
            Console.WriteLine("endereço: ");
            Console.WriteLine(endereço);
            Console.WriteLine("telefone: ");
            Console.WriteLine(telefone);


            Console.ReadKey();

        }
    }
}
