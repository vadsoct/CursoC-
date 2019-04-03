using System;
using System.Globalization;

namespace C_
{
    class Ex6_1POO
    {
       public static void Ex1()
           {
               Ex6_1POOPessoa X , Y;

             X = new Ex6_1POOPessoa();
             Y = new Ex6_1POOPessoa();
            
            System.Console.WriteLine("insira o nome: ");            
            X.nome = Console.ReadLine();     
            System.Console.WriteLine("Insira a idade: ");
            X.idade = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);                       
            
            System.Console.WriteLine("insira o nome: ");   
            Y.nome = Console.ReadLine();
            System.Console.WriteLine("Insira a idade: ");
            Y.idade = int.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                 
            if (X.idade > Y.idade){
                
                System.Console.WriteLine("Pessoa mais velha : " + X.idade);

            }else{
                System.Console.WriteLine("Pessoa mais velha : " + Y.idade);
            }
       }


    }
}