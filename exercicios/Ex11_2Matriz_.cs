using System;
using System.Globalization;
using System.Collections.Generic;

namespace C_{
    class Ex11_2Matriz_{
        public static void Ex1 () {
        
        System.Console.WriteLine("entre com o numero da matriz quadadra: ");

        int n = int.Parse(Console.ReadLine());
        double[,] mat = new double[n,n];

        System.Console.WriteLine("insira o elemento das matrizes: ");

        for (int i=0; i < n; i++){

            string[] values = Console.ReadLine().Split(' ');

            for (int j=0; j < n; j++){
                    mat [i, j] = int.Parse(values[j]);

            }

        }

        System.Console.WriteLine("Diagonal principal: ");

        for (int i = 0; i < n; i++){
            System.Console.Write(mat[i,i]+" ");
        }
        int cont = 0;
        for (int i=0; i < n; i++){
         
            for (int j=0; j < n; j++){
                    if (mat[i,j] < 0){
                        cont++;
                    }

            }

        }
        System.Console.WriteLine();
        System.Console.WriteLine("quantidade de numeros negativos: "+"\n"+cont);
        System.Console.WriteLine();
        System.Console.WriteLine(mat.Length);
        System.Console.WriteLine(mat.Rank);
        System.Console.WriteLine(mat.GetLength(0));
        System.Console.WriteLine(mat.GetLength(1));
        System.Console.WriteLine();



        }
    }
}