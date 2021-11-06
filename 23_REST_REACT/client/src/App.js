import React, {useState} from 'react';
import Header from './Header'


export default function App() {
  // soh eh possivel alterar o valor com estadovi
  const [counter, setCounter] = useState(0);
  //Array [value, changeValueFunction]

  function increment(){
    setCounter(counter + 1);
  }
  return(
    //JSX Javascript XML
    //<h1 >Hello World!</h1>
    <div> 
      <Header>
        Counter: {counter}
      </Header>
      <button onClick={increment}>Add</button>
    </div>
  );

}


