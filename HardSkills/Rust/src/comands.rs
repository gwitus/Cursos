//Importação de biblioteca

//Precisa colocar isso aqui nas dependencias toml para importar a biblioteca

// chrono = { version = "0.4", features = ["serde", "rustc-serialize"] }
// use chrono::NaiveDate; //Essa em específico serve para ter o dipo Date

fn main () {
    // let data = NaiveDate::from_ymd(2023, 03, 26); // Exemplo de tipo Date da biblioteca importada
    println!("Teste!");
    somarValores();
    subtrairValores(1,3);
    // Declaração do Struct
    let pessoaUm = declararPessoas(String::from("Emanuel"), 20, 'M');
}


//---------------------------------------------------------------//++Functions++\\--------------------------------------------------------------\\
//Tipo 1 de função
fn somarValores () {
    let valorUm   = 1;
    let valorDois = 2;

    let mut somaTotal = valorUm + valorDois;
    println!("{:?}", somaTotal);
}

//Tipo 2 de função
fn subtrairValores (number1:i32, number2:i32 ) -> i32{
    if number1 < 0 || number2 < 0{
        println!("Ambos os números precisam ser maiores que zero");
    } else {
        println!("O resultado é: ");
    }
    //Só para demontração, não retorna nada por não poder colocar um println aqui, mas a nível de código isso funciona
    number1 - number2
}

// Função para declarar pessoas
fn declararPessoas(nome: String, dataNasc: u32, sexo: char) -> Pessoa {
    Pessoa { nome, dataNasc, sexo}
}


//---------------------------------------------------------------//++Structs++\\--------------------------------------------------------------\\

struct Pessoa {
    nome: String,
    dataNasc: u32,
    sexo: char,
}