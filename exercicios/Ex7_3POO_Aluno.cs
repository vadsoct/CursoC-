using System;
using System.Globalization;

namespace C_
{
    class Ex7_3POO_Aluno
    {
        public string nome; 
        public double nota1;
        public double nota2;
        public double nota3;
        public double resto;
        public void Notas(){

        System.Console.WriteLine("insira o nome : ");    

        nome = Console.ReadLine();     

        System.Console.WriteLine("Insira a nota do primeiro semestre : ");
        nota1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture); 

        System.Console.WriteLine("Insira a nota do segundo semestre : ");
        nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);  
            
        System.Console.WriteLine("Insira a nota do terceiro semestre : ");
        nota3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture); 

        if (Aprovacao(MediaNota()) != "aprovado"){
            resto = 60 - MediaNota();
            }else{
            resto = 0;
            }       
        }
        public double MediaNota(){
            return nota1 * 0.3 + nota2 * 0.35 + nota3 * 0.35;
        }
        
        public string Aprovacao(double x){
            if (x < 60 ){
              return "Reprovado";
            }else{
              return "Aprovado";
          }
        }


        
        public override string ToString(){
            return "\n Nome do Aluno : \n"
                +nome 
                + "\n Primeiro semestre : \n"    
                + nota1
                + "\n Segundo semestre : \n"
                + nota2
                + "\n terceiro semestre : \n"
                + nota3
                + "\n A media  do aluno é : \n"
                + MediaNota().ToString("F2", CultureInfo.InvariantCulture)
                + "\n e ele esta :\n"
                + Aprovacao(MediaNota()) + "\n"
                + "foltou " + resto + " para atingir a meta";

                
            
            }
        }
    }
