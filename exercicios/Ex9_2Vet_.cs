using System;
using System.Globalization;

namespace C_{
    class Ex9_2Vet_{

        public static void Ex1(){

            int n =int.Parse(Console.ReadLine());
            
            double[] vect = new double [n];

            for (int i=0; i < n; i++){
                vect[i] = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                
            }

            double sum = 0.0;
            for (int i = 0; i < n; i++){
                sum += vect[i];
            }
            double avg = sum / n;
            System.Console.WriteLine("AVERAG HEIGHT = "+ avg.ToString("F2",CultureInfo.InvariantCulture));
        }
    }
}