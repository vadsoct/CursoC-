using System;

namespace C_
{
    class Ex1
    {
       public static Boolean numeroPrimo(int num)
        {
            Console.WriteLine("num "+num);
           for (int i =2; i<num-1 ; i++){
               Console.WriteLine(i);
               if(num % i == 0)                   
                   return false;
            }

            return true;
          
       }


    }
}