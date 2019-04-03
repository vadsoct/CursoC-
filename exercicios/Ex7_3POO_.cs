using System;
using System.Globalization;

namespace C_
{
    class Ex7_3POO_
    {
       public static void Ex1()
           {
                              
            Ex7_3POO_Aluno A1 = new Ex7_3POO_Aluno();
            Ex7_3POO_Aluno A2 = new Ex7_3POO_Aluno();
                                    
            System.Console.WriteLine("Insira os dados dos Alunos : ");

            A1.Notas();
                       
            System.Console.WriteLine("Dados do aluno: \n" + A1);
           
            A2.Notas();
                       
            System.Console.WriteLine("Dados do aluno: \n" + A2);                     
       }
    }
}