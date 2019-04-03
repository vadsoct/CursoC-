using System;
using System.Globalization;

namespace C_
{
    class Ex7_1POOAulaRetangulo
    {
        
            public double altura; 
            public double largura;
           
        public double Area(){
            return altura * largura;
        }

        public double Perimetro(){

            return (largura * 2) + (altura * 2) ;

        }

        public double Diagonal(){

            return Math.Sqrt((Math.Pow(largura,2)+Math.Pow(altura,2)));

        }

        public override string ToString(){
         
            return "O retangulo tem altura " + altura
                + " e largura "    
                + largura
                +" ";
                      
        }


    }
}