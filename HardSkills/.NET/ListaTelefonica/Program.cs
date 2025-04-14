using System;
using System.Data.Common;
using System.Diagnostics.Contracts;

namespace App {

        struct Pessoa {
        public int Id { get; set; } 
        private string _Name { get; set; } 
        public string Birth { get; set; }

        public void setName (string nome){
            _Name = nome;
        }

        public string showName(){
            return _Name;
        }

        public override string ToString(){
        return $"Id: {Id}, Nome: {_Name}, Data de Nascimento: {Birth}";
        }
    }



    class program {
        static void Main(string[] args) {  
            var estrutura = new Pessoa(); 
            estrutura.Id = 1;
            estrutura.Birth = "01/01/1990";
            estrutura.setName("Gwitus");
            // Imprimindo essa parada
            string aux = estrutura.ToString();
            Console.WriteLine(aux);
        }
    }
}