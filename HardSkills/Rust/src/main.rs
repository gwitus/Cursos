//Import de biblioteca
use  std::io;


// Fn é como se declara uma função
// Mão é necessariamente Tipada - Da para tipar e da para não tipar

fn main() {
    //------------------------------------------------------%declaração de variaveis%----------------------------------------------------\\

    // 1 - Em rust existem dois tipos de variaveis, sendo elas as vinculadas e as não vinculadas
    //     1.1 - Quando se declara uma variavel LET, a IDE reconhece automaticamente o tipo e já entende que ela é imutável
    //     1.2 - Quando se declara uma variavel LET MUT, a IDE reconhece automaticamente o tipo mas entende que ela é mutavel

    // Vinculada
    let name     = "Emanuel";
    // Não Vinculada
    let mut nome = "Oliveira" ;

    // Numeros
    let numero  = 1;
    let numero2 = 2;
    
    let numer3 = 3.5;
    let b = true;
    
    // Soma
    println!("{}", numero + numero2);
    println!("{}", b);
    // Além disso, Rust tem tipos de dados básicos como i8, i16, i32, i64, u8, u16, u32, u64 que representam números inteiros com sinal e sem sinal de diferentes tamanhos. 
    // Também há f32 e f64 que representam números de ponto flutuante de precisão simples e dupla, respectivamente. Rust também suporta tipos booleanos (bool), caracteres (char),
    // tuplas ((T1, T2, ...)) e arrays ([T; N]).
    
    //2 - Para printar
    println!("{}", name);
    
    // Necessário criar objeto para guardar o valor na memória
    //Com a biblioteca io conseguimos utilizar um leitor de número no terminal
    let mut number1 = String::new();
    io::stdin().read_line(&mut number1).expect("Erro ao ler o número inserido!");
    let mut number2 = String::new();
    io::stdin().read_line(&mut number1).expect("Erro ao ler o número inserido2!");



    if convertToInt(&number1) > convertToInt(&number2) {
        println!("O número inserido é maior que o Inserido a direita!");
    } else {
        println!("O número inserido é maior que o Inserido a esquerda!");
    }

}


// Função para converter tipo 
// Por ser conversor cai o ->
// Para passar um parametro, precisa declarar o tipo
fn convertToInt (dataInput: & String) -> i32{
    // O método unwrap é diferenciado
    let aux = dataInput.trim().parse::<i32>().unwrap();
    // Vai retornar o aux, sem ;
    aux
}