// a ideia aqui é trabalhar com eventos (OnClick, OnChange..)
function Events () {
    function myEvent (){
        alert("Olá, rapaziada!");
    }
    
    return (
        <>
            <h2>clique para ativar o botão!</h2>
            <button onClick={myEvent}>Ativar!</button>
        </>
    )
}

export default Events;