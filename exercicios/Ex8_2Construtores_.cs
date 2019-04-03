using System;
using System.Globalization;
namespace C_ {
class Ex8_2Construtores_ {
    public static void Ex1() {

        Ex8_2Construtores_Conta Conta;

        System.Console.WriteLine("Entre o numero da conta: ");
        int nConta = int.Parse(Console.ReadLine());
        System.Console.WriteLine("Entre com o titular da conta: ");
        string titular = Console.ReadLine();
        System.Console.WriteLine("Haverá um primeiro depósito: (S/N) ");
        char resp = char.Parse(Console.ReadLine());
        if (resp == 's' || resp == 'S'){
            System.Console.WriteLine("Entre com o valor do depósito inicial: ");   
            double depositoInicial = double.Parse(Console.ReadLine());  
            Conta = new Ex8_2Construtores_Conta(titular, nConta ,depositoInicial);

        }
        else{
            Conta = new Ex8_2Construtores_Conta(titular , nConta);
        }

        System.Console.WriteLine();
        System.Console.WriteLine("Dados da conta: ");
        System.Console.WriteLine(Conta);

        System.Console.WriteLine();
        System.Console.WriteLine("Entre um valor para depósito: ");
        double quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        Conta.Deposito(quantia);
        System.Console.WriteLine("Dados da conta atualizados: \n");
        System.Console.WriteLine(Conta);

         System.Console.WriteLine();
        System.Console.WriteLine("Entre um valor para saque: ");
        quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        Conta.Saque(quantia);
        System.Console.WriteLine("Dados da conta atualizados: \n");
        System.Console.WriteLine(Conta);



}
}
}