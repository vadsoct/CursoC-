using System;
using System.Globalization;

namespace C_
{
    class Ex7_1POOAulaProduto
    {
        
            public string nome; 
            public double preco;
            public int Quantidade;

        public double ValorTotalEmEstoque(){
            return preco * Quantidade;
        }

        public void AdicionarProdutos(int quantidade){

            Quantidade += quantidade;

        }

                public void RemoverProdutos(int quantidade){

            Quantidade -= quantidade;

        }

        public override string ToString(){
         
            return nome 
                + ", R$"    
                + preco.ToString("F2", CultureInfo.InvariantCulture)
                +", "
                + Quantidade
                + " unidades, Total: R$"
                + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }


    }
}