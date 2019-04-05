using System;
using System.Globalization;

namespace Ricardibre{
    class R11_Mat{
        public static void Ex1 () {
        
        System.Console.WriteLine("Matriz 5x5 :");
        int m = 5;        
        int n = 5;

        Random Ran = new Random();
        double[,] mat = new double[m,n];

        System.Console.WriteLine("Insira os elementos das matrizes: ");

        for (int i=0; i < m; i++){                     
            for (int j=0; j < n; j++){
                
                int x = Ran.Next(0, 9);            
                mat [i, j] = x;
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
                    }else{
                        System.Console.WriteLine("nem tem");
                    }
                }
            }
        System.Console.WriteLine("o numero selecionado foi encontrado "+ conti + " vezes.");
        }
    private int RandomNumber(int min, int max){
        Random random = new Random();
        return random.Next(min, max); 
        }
    }
}