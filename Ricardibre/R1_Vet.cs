using System;
using System.Globalization;

namespace Ricardibre{
    class R1_Vet{

        public static void Ex1(){

            int n = 5;
            
            double[] vect = new double [n];

            System.Console.WriteLine("Digite a 5 numeros a serem somados:  ");

            for (int i=0; i < n; i++){
                vect[i] = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                
            }

            double sum = 0.0;
            for (int i = 0; i < n; i++){
                sum += vect[i];
            }
            
            System.Console.WriteLine("SOMA DE TUDO = "+ sum.ToString("F2",CultureInfo.InvariantCulture));
        

            for (int i=0; i < n; i++){
                System.Console.WriteLine("numeros digitados: " + vect[i]);
                
            }
        }
    }
}