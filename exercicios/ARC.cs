using System;
using System.Globalization;
using System.Collections.Generic;

namespace C_{
    class ARC{
        public static void Ex1 () {
        
        System.Console.WriteLine("Matriz 5x5 :");
        int m = 5;        
        int n = 5;

        Random Ran = new Random();
        int?[,] mat = new int?[m,n];

// Construção da matriz
        for (int i=0; i < m; i++){                     
            for (int j=0; j < n; j++){                
                mat [i, j] = Ran.Next(0, 9);
            }
        }
//esse codigo imprime a diagonal principal

        for(int q = 0; q < n; q++){

            System.Console.WriteLine();

            for(int w = 0; w < n; w++){
                if(q == w){
                System.Console.Write(" " + mat[q,w]);
                }else{
                System.Console.Write(" " + " ");    
                }
            }
        }
        System.Console.WriteLine();

    // Esse codigo imprime a diagonal inversa.

        for(int q = 0; q < n; q++){

        System.Console.WriteLine();

            for(int w = 0; w < n; w++){
                if(q + w == n-1){
                    System.Console.Write(" " + mat[q,w]);
                }else{
                    System.Console.Write(" " + " ");    
                    }
                }
            }
        System.Console.WriteLine();

    // Esse codigo imprime o "x".   

        for(int q = 0; q < n; q++){

            System.Console.WriteLine();

            for(int w = 0; w < n; w++){
                if(q + w == n-1 || q == w){
                System.Console.Write(" " + mat[q,w]);
                }else{
                System.Console.Write(" " + " ");    
                }
            }
        }
            System.Console.WriteLine();

// Esse codigo imprime o "triangulo superior esquerdo".

        for(int q = 0; q < n; q++){

            System.Console.WriteLine();

            for(int w = 0; w < n; w++){
                if(q + w <= n-1){
                System.Console.Write(" " + mat[q,w]);
                }else{
                System.Console.Write(" " + " ");    
                }
            }
        }
        System.Console.WriteLine();

//Esse codigo imprime o "triangulo inferior direito".

        for(int q = 0; q < n; q++){

            System.Console.WriteLine();

            for(int w = 0; w < n; w++){
                if(q + w >= n-1){
                System.Console.Write(" " + mat[q,w]);
                }else{
                System.Console.Write(" " + " ");    
                }
            }
        }
        System.Console.WriteLine();

// Esse codigo imprime o "triangulo superior direito".

        for(int q = 0; q < n; q++){

            System.Console.WriteLine();

            for(int w = 0; w < n; w++){
                if(q <= w){
                System.Console.Write(" " + mat[q,w]);
                }else{
                System.Console.Write(" " + " ");    
                }
            }
        }
        System.Console.WriteLine();
    
    // Esse codigo imprime o "triangulo superior esquerdo".

        for(int q = 0; q < n; q++){

            System.Console.WriteLine();

            for(int w = 0; w < n; w++){
                if(q >= w){
                System.Console.Write(" " + mat[q,w]);
                }else{
                System.Console.Write(" " + " ");    
                }
            }
        }
        System.Console.WriteLine();
    
    // Matriz original

        for(int q = 0; q < n; q++){

            System.Console.WriteLine();

            for(int w = 0; w < n; w++){                
                System.Console.Write(" " + mat[q,w]);                
            }
        }
        System.Console.WriteLine();
    }
    private int RandomNumber(int min, int max){
        Random random = new Random();
        return random.Next(min, max); 
        }
    }
}