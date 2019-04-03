using System;
using System.Globalization;

namespace Ricardibre{
    class R5_Vet_{

        public static void Ex1(){

            int n = 10;
            
            double?[] vect = new double? [n];
            double?[] vect1 = new double? [n];
           
            
            
            System.Console.WriteLine("Digite a lista de numeros: ");

            for (int i=0; i < n; i++){
                double? x = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

                if(x != 0){
                    if(x%2==0){
                    vect[i] = x;
                    vect1[i] = null;
                    }else{
                    vect1[i] = x;
                    vect[i] = null;
                }     
                }else{
                System.Console.WriteLine("0 não é um valor valido, digite outro valor:");
                i--;
                }
            } 
            for (int i=0; i < n ;i++){
                if(vect[i] != null){
                    System.Console.WriteLine("Nomes digitados pares: " + vect[i]);
                }
            }   

            System.Console.WriteLine();   

            for (int i=0; i < n ;i++){
                    if(vect1[i] != null){
                    System.Console.WriteLine("Nomes digitados pares: " + vect1[i]);
                }
            }                     

            System.Console.WriteLine(vect.GetLength(0));  //VECT.LENGTH vect[0].length
        }
    }
}