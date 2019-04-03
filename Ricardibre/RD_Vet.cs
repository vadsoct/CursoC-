using System;
using System.Globalization;

namespace Ricardibre{
    class RD_Vet_{
        public static void Ex1(){

            int [] vect = new int [] {5,6,3,2,1,5,8,21,97,4,60,7,45,70};
            int x = vect.Length;     
            int z = 0;
            int troca = 0;

            System.Console.WriteLine("Organizar vetor:");
            int c = 0;
            while(z != x-2){
                z=0;
                for(int i=0 ; i < x-1 ;i++){                                        
                    if(vect[i] > vect[i + 1]){ 
                        c = vect[i];   
                        vect[i] = vect[i+1];
                        vect[i+1] = c;
                        troca += 1;
                        System.Console.WriteLine(" trocou "+vect[i+1]+" pelo "+ vect[i]);
                        System.Console.WriteLine(vect[0]+","+vect[1]+","+vect[2]+","+vect[3]+","+vect[4]+","+vect[5]+","+vect[6]+","+vect[7]+","+vect[8]+","+vect[9]+","+vect[10]+","+vect[11]+","+vect[12]);
                    }                                        
                }
                
                for(int i=0 ; i < x-1 ;i++){
                        if(vect[i] > vect[i+1]){                        
                        z = z - 1;                        
                    }else if(vect[i] < vect[i+1]){                        
                        z = z + 1;                        
                    }                 
                }
            }   
             System.Console.WriteLine(vect[0]+","+vect[1]+","+vect[2]+","+vect[3]+","+vect[4]+","+vect[5]+","+vect[6]+","+vect[7]+","+vect[8]+","+vect[9]+","+vect[10]+","+vect[11]+","+vect[12]);
             System.Console.WriteLine("foram realizadas: "+ troca + " trocas");
        }
    }
}
