import PropTypes from 'prop-types'; // Import do recurso

function Item({marca, ano, ano_lanc}) {
    console.log("Item renderizou com props:", { marca, ano, ano_lanc }); //caso eu queira ver o retorno de cada props efetivamente

    // forma de usar o DefaultProps após a versão 17
    ano = 0;
    ano_lanc = "Não identificado";
    marca = "Não registrado";

    return (
        // vou usar o exemplo de um possível carro
        // 2 de cada para testar o valor default
        <div className="carro">
            <h2>ano: {ano}</h2>
            <h2>marca do carro: {marca}</h2>
            <h2>ano de lançamento: {ano_lanc}</h2>
        </div>
    )
}

// apesar do import ser maisculo, aqui o 'p' de 'Props' é minúsculo
Item.propTypes = {
  marca: PropTypes.string,
  ano: PropTypes.number.isRequired, //isRequired para mostrar que é obrigatório
  ano_lanc: PropTypes.number
};

// Mas só vai funcionar do REACT 17 para tras
Item.defaultProps = {
    // Valores definidos se nada for setado
    marca: "Marca não identificada",
    ano: 0,
    ano_lanc: 2000
}

export default Item;