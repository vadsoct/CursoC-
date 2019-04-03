using System;
using System.Globalization;

namespace Ricardibre{
    class R3_Vet_{

        public static void Ex1(){

            int n = 10;
            
            double[] vect = new double [n];
            double[] vect1 = new double [n];

            System.Console.WriteLine("Digite a lista de numeros: ");

            for (int i=0; i < n; i++){
                vect[i] = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                vect1[i] = vect[i] * 5;       
            } 
            for (int i=0; i < n ;i++){
                    System.Console.WriteLine("Nomes digitados: " + vect[i] + " " + vect1[i] );
            }                        
        }
    }
}