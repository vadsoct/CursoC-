using System;
using System.Globalization;

namespace C_
{
    class Ex5Curso
    {
       public static void Ex4Sequencial()
        {

            int idFunc = 0;
            double salario = 0;
            double hrasTrab = 0;   
            double vlrHr = 0;
                                   
            Console.WriteLine("Insira o ID do funcionario : ");
            idFunc = int.Parse(Console.ReadLine());

            Console.WriteLine("Insira o valor das horas : ");
            hrasTrab = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            Console.WriteLine("Insira quantidade de horas trabalhadas : ");
            vlrHr = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            salario = vlrHr * hrasTrab;

            System.Console.WriteLine("O salario do colaborador " + idFunc + " será de: " + salario.ToString("F2",CultureInfo.InvariantCulture));
       }


    }
}