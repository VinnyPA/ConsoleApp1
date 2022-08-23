using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Produto prod = new Produto();
            Cliente cli = new Cliente();
            Pedido ped = new Pedido();

            Console.Write("Digite o numero do pedido: ");
            ped.setNumero(Convert.ToInt32(Console.ReadLine()));
            Console.WriteLine("Digite a quantidade do pedido: ");
            ped.setQuantidade(Convert.ToInt32(Console.ReadLine()));

            Console.Write("Digite o nome do cliente: ");
            cli.setNome(Console.ReadLine());
            Console.WriteLine("Digite a CPF do cliente: ");
            cli.setCpf(Console.ReadLine());
            Console.WriteLine("Digite a endereço do cliente: ");
            cli.setEndereco(Console.ReadLine());
            Console.WriteLine("Digite o idade do cliente: ");
            cli.setIdade(Convert.ToInt32(Console.ReadLine()));


            Console.Write("Digite o código do produto: ");
            prod.setCodigo(Convert.ToInt32(Console.ReadLine()));
            Console.WriteLine("Digite a decrição do produto: ");
            prod.setDescricao(Console.ReadLine());
            Console.WriteLine("Digite a categoria do produto: ");
            prod.setCategoria(Console.ReadLine());
            Console.WriteLine("Digite o valor do produto: ");
            prod.setValor(Convert.ToDouble(Console.ReadLine()));

            Console.WriteLine("Nome = " + cli.getNome()+ "\nEndereço = "+ cli.getEndereco() + "\nCPF = " + cli.getCpf() + "\nIdade = " + cli.getIdade());

            Console.WriteLine("Código = " + prod.getCodigo() +"\nDescrição : "+ prod.getDescricao()+"\nCategoria = " + prod.getCategoria() + "\nValor = " + prod.getValor().ToString("C"));

            Console.WriteLine("Pedido = " + )
        }
    }
}
