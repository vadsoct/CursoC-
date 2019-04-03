using System;
using System.Globalization;

namespace C_
{
    class Ex7_1POOAula
    {
       public static void Ex1()
           {
               
               
            Ex7_1POOAulaProduto P = new Ex7_1POOAulaProduto();
                        
            System.Console.WriteLine("Insira os dado do produto: ");
            System.Console.WriteLine("insira o nome : ");            
            P.nome = Console.ReadLine();     

            System.Console.WriteLine("Insira o preço : ");
            P.preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture); 

            System.Console.WriteLine("quantidade no estoque: ");       
            P.Quantidade = int.Parse(Console.ReadLine());

                                        
            System.Console.WriteLine("Dados do produto: " + P);

            System.Console.WriteLine();
            System.Console.Write("Digite o numero de produtos a serem adicionados no estoque: ");
            int qte = int.Parse(Console.ReadLine());
            P.AdicionarProdutos(qte);

            System.Console.WriteLine();
            System.Console.WriteLine("Dados atualizados: " + P);

            System.Console.WriteLine();
            System.Console.Write("Digite o numero de produtos a serem removidos do estoque: ");
            qte = int.Parse(Console.ReadLine());
            P.RemoverProdutos(qte);

            System.Console.WriteLine();
            System.Console.WriteLine("Dados atualizados: " + P);

       }


    }
}