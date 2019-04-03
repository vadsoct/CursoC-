using System;
using System.Globalization;

namespace C_
{
    class Ex2_7Condicional
       {
       public static void Ex1()
        {
            Console.WriteLine("Digite os valores de x e y: ");

            string[] valores = Console.ReadLine().Split(',');
            double X = double.Parse(valores[0],CultureInfo.InvariantCulture);
            double Y = double.Parse(valores[1],CultureInfo.InvariantCulture);
            string quadrante;
                    

            if ( X > 0 && Y > 0 )
            {
                quadrante = "1° Quandrante";
                                                 
            }else if (X < 0 && Y > 0){

                quadrante = "2° Quandrante";

            }else if (X < 0 && Y < 0){

                quadrante = "3° Quandrante";

            }else if (X > 0 && Y < 0){

                quadrante = "4° Quandrante";
            
            }else{

                quadrante = "Origem";

            }

                    
            System.Console.WriteLine("ponto está na " + quadrante);
       }


    }
}