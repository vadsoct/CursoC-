using System;
using System.Globalization;
namespace C_ {
class Ex8_1Construtores_ {
public static void Ex1() {


Console.WriteLine("Entre os dados do produto:");
Console.Write("Nome: ");
string nome = Console.ReadLine();
Console.Write("Preço: ");
double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

Console.WriteLine();

Ex8_1Construtores_Produto p = new Ex8_1Construtores_Produto();


Console.WriteLine("Dados do produto: " + p);
Console.WriteLine();
Console.Write("Digite o número de produtos a ser adicionado ao estoque: ");
int qte = int.Parse(Console.ReadLine());
p.AdicionarProdutos(qte);
Console.WriteLine();
Console.WriteLine("Dados atualizados: " + p);
Console.WriteLine();
Console.Write("Digite o número de produtos a ser removido do estoque: ");
qte = int.Parse(Console.ReadLine());
p.RemoverProdutos(qte);
Console.WriteLine();
Console.WriteLine("Dados atualizados: " + p);

}
}
}