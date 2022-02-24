using System;
using System.Globalization;
using Fixação.Enums.Entities;
using Fixação.Enums.Entities.Enums;

namespace Fixação.Enums
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com os dados do cliente: ");
            Console.Write("Nome: ");
            string nome = Console.ReadLine();
            Console.Write("Email: ");
            string email = Console.ReadLine();
            Console.Write("Data Aniversario: (DD/MM/AAAA) ");
            DateTime dataAniversario = DateTime.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Entre com os dados do pedido");
            Console.Write("Status: ");
            StatusPedido status = Enum.Parse<StatusPedido>(Console.ReadLine());

            Cliente cliente = new Cliente(nome, email, dataAniversario);
            Pedido pedido = new Pedido(DateTime.Now,status,cliente );


            Console.WriteLine("Quantos itens para este pedido: ");
            int item = int.Parse(Console.ReadLine());

            for(int i = 1; i <= item; i++ )
            {
                Console.WriteLine();
                Console.WriteLine($"Entre com os dados do {i}# pedido");
                Console.Write("Nome: ");
                string nomeProduto = Console.ReadLine();
                Console.Write("Preço: ");
                double precoProduto = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture); ;

                Produto produto = new Produto(nomeProduto, precoProduto);

                Console.Write("Quantidade: ");
                int quantidade = int.Parse(Console.ReadLine());

                ItemsPedido items = new ItemsPedido(quantidade, precoProduto, produto);

                pedido.AddItem(items);

            }

            Console.WriteLine();
            Console.WriteLine("Relatorio: ");
            Console.WriteLine(pedido);
            
        }
    }
}
