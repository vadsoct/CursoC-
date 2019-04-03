using System;
using System.Globalization;

namespace C_
{
    class Ex7_4POO_Conversor
    {
        public const double dolar = 3.10;
        public const double iof = 0.06;
         
        public static double ConversorDeMoeda(double din){
      
           return (din * dolar) * (1 + iof);
       
        }
    }
}
    
