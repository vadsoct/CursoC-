using System;
using System.Globalization;
using System.Collections.Generic;

namespace C_{
    class Ex12_2Conj_{
        public static void Ex1 () {

            HashSet<int> A = new HashSet<int>();
            HashSet<int> B = new HashSet<int>();
            HashSet<int> C = new HashSet<int>();

            System.Console.WriteLine("Digite a quantidade de alunos no curso A: ");
            int NA = int.Parse(Console.ReadLine());

            for(int i = 0; i < NA; i++){
            System.Console.WriteLine("Digite o codigo dos alunos do curso A: ");
            A.Add(int.Parse(Console.ReadLine()));
            }

            System.Console.WriteLine("Digite a quantidade de alunos no curso B: ");
            int NB = int.Parse(Console.ReadLine());

            for(int i = 0; i < NB; i++){
            System.Console.WriteLine("Digite o codigo dos alunos do curso B: ");
            B.Add(int.Parse(Console.ReadLine()));
            }

            System.Console.WriteLine("Digite a quantidade de alunos no curso C: ");
            int NC = int.Parse(Console.ReadLine());

            for(int i = 0; i < NC; i++){
            System.Console.WriteLine("Digite o codigo dos alunos do curso C: ");
            C.Add(int.Parse(Console.ReadLine()));
            }

            HashSet<int> Novo = new HashSet<int>();
            Novo.UnionWith(A);
            Novo.UnionWith(B);
            Novo.UnionWith(C);
            Console.WriteLine("Total de alunos é: " + Novo.Count);
            Console.ReadLine();
            
        }
    }
}