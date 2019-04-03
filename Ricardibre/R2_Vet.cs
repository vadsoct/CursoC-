using System;
using System.Globalization;

namespace Ricardibre{
    class R2_Vet_{

        public static void Ex1(){

            int n = 5;
            
            string[] vect = new string [n];

            System.Console.WriteLine("Digite a lista de nomes:  ");

            for (int i=0; i < n; i++){
                vect[i] = Console.ReadLine();               
            } 
            int x = n - 1;
            for (int i=0; i < n ;i++){
                System.Console.WriteLine("Nomes digitados: " + vect[x]);
                x--;
            }
        }
    }
}