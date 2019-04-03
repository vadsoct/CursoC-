using System;
using System.Globalization;

namespace C_
{
    class Ex7_2POOFuncionario
    {
        
            public string nome; 
            public double salario;
            public double imposto;
        
        public void AlmentarSalario(double aumento){

            salario = salario * (1 + (aumento/100));

        }

        public double SalarioLiquido(){
          return salario - imposto;
        }

        public override string ToString(){
         
            return nome 
                + ", R$"    
                + salario.ToString("F2", CultureInfo.InvariantCulture)
                +", o imposto sopre o salarios é de R$"
                + imposto
                + " e o salario bruto é R$"
                + SalarioLiquido().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}