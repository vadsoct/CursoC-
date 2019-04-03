using System;
using System.Globalization;
using System.Collections.Generic;

namespace C_{
    class Ex11_1Matriz_{
        public static void Ex1 () {

            double[,] mat = new double[2,3];

            System.Console.WriteLine(mat.Length);
            System.Console.WriteLine(mat.Rank);
            System.Console.WriteLine(mat.GetLength(0));
            System.Console.WriteLine(mat.GetLength(1));



        }
    }
}