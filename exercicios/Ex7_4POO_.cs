using System;
using System.Globalization;

namespace C_
{
    class Ex7_4POO_
    {
       public static void Ex1()
           {
                              
            double din;
            double con;
                                    
            System.Console.WriteLine("Entre com o valor a ser convertido");

            din = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            con = Ex7_4POO_Conversor.ConversorDeMoeda(din);

                       
            System.Console.WriteLine("Valor convertido: \n" + con.ToString("F2",CultureInfo.InvariantCulture));
                                           
       }
    }
}