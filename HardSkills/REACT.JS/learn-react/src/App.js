
import './styles/App.css';
import InputModel from './components/InputModel'; //Tipo indicado de como usar o props
import Props from './components/Props'; //aqui eu pratiquei o props no modo como se importa classes
import InputTy from './components/InputTy' //aqui eu pratiquei fragmentos
import Item from './components/Item' //praticando setar um tipo e um default para cada componente

// aqui estamos mexendo com eventos agora
import Events from './components/Events';
import TesteEventos from './components/TesteEventos';

function App() {
  function alertar (){
    alert("salve, quebrada!");
  }

  return (
    <div className='App'>
      <Item />

      <Events />

      <p></p>
      {/* props como evento */}
      <TesteEventos event={alertar} text="clique aqui para saber o evento" /> 
    </div>
  );
}

export default App;