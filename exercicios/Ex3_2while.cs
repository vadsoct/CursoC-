using System;
using System.Globalization;

namespace C_
{
    class Ex3_2while
       {
       public static void Ex1()
        {          
            Console.WriteLine("Digite os valores de x e y: ");

            string[] valores = Console.ReadLine().Split(',');
            double X = double.Parse(valores[0],CultureInfo.InvariantCulture);
            double Y = double.Parse(valores[1],CultureInfo.InvariantCulture);
            string quadrante = null;

                while (X != 0 && Y != 0)
            {
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

             
            System.Console.WriteLine(quadrante);
            Console.WriteLine("Digite os valores de x e y: ");
            valores = Console.ReadLine().Split(',');
            X = int.Parse(valores[0],CultureInfo.InvariantCulture);
            Y = int.Parse(valores[1],CultureInfo.InvariantCulture);
              
             
            }

                
       }


    }
}


            
                    

            
                    
            