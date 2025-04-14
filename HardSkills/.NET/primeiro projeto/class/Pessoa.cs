using System;
using System.Net;

namespace Pessoa {
    class Candidato {
        protected string nome;
        private int idade;
        private string formation;

        public void NomearCandidato (string nome){
            this.nome = nome;
        }

        public void MostrarNome (){
            Console.WriteLine(this.nome);
        }

        public string Nome {
            get {return nome;}
            set {nome = value;}
        }
    }
    
    class Funcionarios : Candidato {
        private string matricula;
        private string departamento;
        private string cargo;
    }    
}