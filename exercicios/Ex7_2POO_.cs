using System;
using System.Globalization;

namespace C_
{
    class Ex7_2POO_
    {
       public static void Ex1()
           {
               
               
            Ex7_2POOFuncionario F = new Ex7_2POOFuncionario();
                        
            System.Console.WriteLine("Insira os dados do funcionario: ");

            System.Console.WriteLine("insira o nome : ");            
            F.nome = Console.ReadLine();     

            System.Console.WriteLine("Insira o salario bruto : ");
            F.salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture); 

            System.Console.WriteLine("Insira o imposto : ");
            F.imposto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture); 
            
            double salarioLiquido = F.SalarioLiquido();
                                        
            System.Console.WriteLine("Dados do Funcionario: " + F);

            System.Console.WriteLine();
            System.Console.Write("digite uma porcentagem para aumento do salario bruto :\n");
            double aum = double.Parse(Console.ReadLine());
            F.AlmentarSalario(aum);

            System.Console.WriteLine();
            System.Console.WriteLine("Dados atualizados: " + F);


                        
       }
    }
}