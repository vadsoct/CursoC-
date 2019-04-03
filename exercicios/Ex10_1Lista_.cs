using System;
using System.Globalization;
using System.Collections.Generic;

namespace C_{
    class Ex10_1Lista_{
        public static void Ex1 () {

            List<Funcionario> list = new List<Funcionario>();
            
            System.Console.WriteLine("Digite o numero de funcionarios");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++ ){
                System.Console.WriteLine("Funcionario #"+i+":");
                System.Console.Write("Id: ");
                int id = int.Parse(Console.ReadLine());
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("salario: ");
                double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                list.Add(new Funcionario(id,nome,salario));
                Console.WriteLine();
            }

        Console.WriteLine("Entre com o Id do funcionario que terá o aumento: ");
        int procuraId = int.Parse(Console.ReadLine());

        Funcionario emp = list.Find(x => x.Id == procuraId);
        if(emp != null){
            System.Console.Write("Entre com a porcentagem: ");
            double porcent = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            emp.AumentoDeSalario(porcent);
        }
        else{
            System.Console.WriteLine("Esse Id não existe!");
        }

        System.Console.WriteLine();
        System.Console.WriteLine("A lista de empregado foi atualizada: ");
        foreach(Funcionario obj in list){
            System.Console.WriteLine(obj);
        }
        }
    }
}