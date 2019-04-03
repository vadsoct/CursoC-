using System;
using System.Globalization;

namespace C_{
    class Funcionario{     
        public int Id { get; set;} 
        public string Nome { get; set; }    
        public double Salario { get; set; }

        public Funcionario(int id, string nome, double salario) {
            Id = id;
            Nome = nome;
            Salario = salario;
        }
        public void AumentoDeSalario(double x){
            Salario = Salario * (1+x/100);

        }

        public override string ToString() {
        return "ID: "
        + Id
        +"\nNome : "
        + Nome
        + "\nSalario: "
        + Salario.ToString("F2",CultureInfo.InvariantCulture);
        }   
    }
}


    




