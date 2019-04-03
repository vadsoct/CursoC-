using System;
using System.Globalization;
using System.Collections.Generic;

namespace C_{
    class Ex11_3Matriz_{
        public static void Ex1 () {
        
        System.Console.WriteLine("Entre com o numero de linhas: ");
        int m = int.Parse(Console.ReadLine());

        System.Console.WriteLine("Entre com o numero de colunas: ");
        int n = int.Parse(Console.ReadLine());

        double[,] mat = new double[m,n];

        System.Console.WriteLine("Insira os elementos das matrizes: ");

        for (int i=0; i < m; i++){

            string[] values = Console.ReadLine().Split(' ');

            for (int j=0; j < n; j++){
                    mat [i, j] = int.Parse(values[j]);
            }
        }

        System.Console.WriteLine("Digite o numero a ser mapeado: ");
        int num = int.Parse(Console.ReadLine());
        double? up = 0,rt = 0, lt = 0, dn = 0;
        int conti = 0;

            for (int i=0; i < m; i++){
            
                for (int j=0; j < n; j++){
                    if (mat[i,j] == num){
                        conti++;
                        System.Console.WriteLine("\n"+"-----------"+"\n");
                        System.Console.WriteLine("Posição : " + i + " , " + j);
                        System.Console.WriteLine();
                        if (i >= 1){
                            up = mat[i-1,j];
                        }else{
                            up = null;
                        }
                        if (i < m-1){
                            dn = mat[i+1,j];
                        }else{
                           dn = null;
                        } 
                        if (j < n-1 ){
                            rt = mat[i,j+1];
                        }else{
                            rt = null;
                        } 
                        if (j >= 1){
                            lt = mat[i,j-1];
                        }else{
                            lt = null;
                        }
                        if (up != null){
                        System.Console.WriteLine("Up: " + up);
                        }
                        if (dn != null){
                        System.Console.WriteLine("Down: " + dn);
                        }
                        if (rt != null){
                        System.Console.WriteLine("Right: " + rt);
                        }
                        if (lt != null){
                        System.Console.WriteLine("Left: " + lt);
                        }
                        System.Console.WriteLine("\n"+"-----------"+"\n");
                    }  
                }
            }
        System.Console.WriteLine("o numero selecionado foi encontrado "+ conti + " vezes.");
        }
    }
}