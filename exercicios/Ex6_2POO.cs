using System;
using System.Globalization;

namespace C_
{
    class Ex1_2POO
    {
       public static void Ex1()
           {
               Ex6_2POOFuncionario X , Y;
               double mediaSalario;

             X = new Ex6_2POOFuncionario();
             Y = new Ex6_2POOFuncionario();
            
            System.Console.WriteLine("Insira o nome do primeiro funcionario: ");
            System.Console.WriteLine("insira o nome : ");            
            X.nome = Console.ReadLine();     
            System.Console.WriteLine("Insira a salario : ");
            X.salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);                       
            
            System.Console.WriteLine("Insira o nome do segundo funcionario: ");
            System.Console.WriteLine("insira o nome : ");   
            Y.nome = Console.ReadLine();
            System.Console.WriteLine("Insira a salario : ");
            Y.salario = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                 
            mediaSalario = (X.salario + Y.salario) / 2;

            System.Console.WriteLine("A media de salario é : " + mediaSalario.ToString("F2",CultureInfo.InvariantCulture));

       }


    }
}