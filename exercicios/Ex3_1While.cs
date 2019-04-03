using System;
using System.Globalization;

namespace C_
{
    class Ex3_1while
       {
       public static void Ex1()
        {          
            System.Console.WriteLine("Entre com uma Senha: ");
            int senha = int.Parse(Console.ReadLine());

                while (senha != 2002)
            {
                System.Console.WriteLine("Acesso negado");
                System.Console.WriteLine("Entre com a senha: ");
                senha = int.Parse(Console.ReadLine());
              
            }

                 System.Console.WriteLine("Acesso Permitido");
       }


    }
}