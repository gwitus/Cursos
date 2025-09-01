// fiz isso aqui só para testar props de eventos

function TesteEventos ({event, text}) {
    return (
        <button onClick={event}>{text}</button>
    )
}

export default TesteEventos;