using System;

namespace C_
{
    class Ex2
    {
       public static void SeqAcumulativa(int num)
        {

            double acum = 1;
            double acum2 = 0;
            double acum3 = num;

            System.Console.WriteLine("O valor escolhido foi : " + num);
            System.Console.WriteLine(acum2);
            System.Console.WriteLine(acum);
                
                while (acum3 != 0){
                
                System.Console.WriteLine(acum);
                acum2 = acum - acum2; 
                acum = acum + acum2;     
                acum3--;       
            }
          
       }


    }
}