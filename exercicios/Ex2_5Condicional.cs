using System;
using System.Globalization;

namespace C_
{
    class Ex2_5Condicional
       {
       public static void Ex1()
        {
            Console.WriteLine("Insira o codigo do produto e a quantidade desejada: ");

            string[] valores = Console.ReadLine().Split(' ');
            int idProd = int.Parse(valores[0]);
            int quant = int.Parse(valores[1]);
            string prod;
            double precoUni;
            double valorCompra;
                    

            if ( idProd == 1 )
            {
                  prod = "Cachorro Quente";
                  precoUni = 4.00;
                                 
            }else if (idProd == 2){

                prod = "X-Salada";
                precoUni = 4.50;
            }else if (idProd == 3){

                prod = "X-Bacon";
                precoUni = 5.00;

            }else if (idProd == 4){

                prod = "Torrada Simples";
                precoUni = 2.00;

            }else if (idProd == 5){

                prod = "Refrigerante";
                precoUni = 1.50;
            }else{

                System.Console.WriteLine("Entrada invalida");
                prod = null;
                precoUni = 0;

            }

            valorCompra = quant * precoUni;
        
            System.Console.WriteLine("O produto escolhido é " + prod + " de quantidade " + quant + " e o valor da compra é de R$" + valorCompra.ToString("F2",CultureInfo.InvariantCulture));
       }


    }
}