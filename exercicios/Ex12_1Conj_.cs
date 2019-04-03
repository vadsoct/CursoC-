using System;
using System.Globalization;
using System.Collections.Generic;

namespace C_{
    class Ex12_1Conj_{
        public static void Ex1 () {

            HashSet<int> A = new HashSet<int>();
            HashSet<int> B = new HashSet<int>();

            A.Add(3);
            A.Add(5);
            A.Add(8);
            A.Add(9);

            B.Add(3);
            B.Add(6);
            B.Add(5);
            B.Add(4);

            B.Remove(4);
            A.ExceptWith(B);
            A.UnionWith(B);
            A.IntersectWith(B);
            

            Console.ReadLine();

            foreach (int x in B){
                Console.WriteLine(x);
            }

        System.Console.WriteLine("Digite em valor inteiro: ");
        int N = int.Parse(Console.ReadLine());

        if(B.Contains(N)){
            Console.WriteLine(N+" pertence ao conjunto B");
            }else{
                System.Console.WriteLine(N+" Não pertence ao conjunto B");
            }
        }
    }
}