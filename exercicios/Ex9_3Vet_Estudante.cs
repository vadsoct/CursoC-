using System.Globalization;
namespace C_ {
    class Estudante  {

        public string Nome { get;  set; }    
        public string Email { get; set; }

        //public void Estudante(string nome, string email) {
          //  Nome = nome;
           // Email = email;
        //}

        public override string ToString() {
        return "Nome : "
        + Nome
        + "\nEmail: "
        + Email;
        }   
    }
}