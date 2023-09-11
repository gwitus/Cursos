using System;
using System.Dynamic;

namespace Animal {
    class Mamifero {
        private string especie {get; set; }
        private string raca;
        private int idade;

        public string minhaEspecie {
            get { return especie; }

            set {
                if (!string.IsNullOrEmpty(value))
                {
                    especie = value;    
                }
            }
        }    
    }
}