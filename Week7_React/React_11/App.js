import React, { useState } from 'react';

function App() {
  const [counter, setCounter] = useState(0);
  const [message, setMessage] = useState('');
  const [rupees, setRupees] = useState('');
  const [euros, setEuros] = useState(null);

  const increment = () => {
    setCounter(counter + 1);
    sayHello();
  };

  const sayHello = () => {
    console.log("Hello! You clicked increment.");
    setMessage("Hello from Increment button!");
  };

  const decrement = () => {
    setCounter(counter - 1);
    setMessage('');
  };

  const sayWelcome = (text) => {
    alert(text);
  };

  const handlePress = (event) => {
    alert("I was clicked");
    console.log("Synthetic Event: ", event.type);
  };

  const handleSubmit = () => {
    fetch(`http://localhost:3000/api/convert?rupees=${rupees}`)
      .then(res => res.json())
      .then(data => setEuros(data.Euros))
      .catch(err => console.error(err));
  };

  return (
    <div style={{ padding: '20px' }}>
      <h1>React Event Examples</h1>

      <h3>Counter: {counter}</h3>
      <button onClick={increment}>Increment</button>
      <br></br>
      <button onClick={decrement}>Decrement</button>
      <p>{message}</p>
      <br></br>
      <button onClick={() => sayWelcome("Welcome to React Events!")}>Say Welcome</button>
      <br /><br />
      <button onClick={handlePress}>Click Me</button>

      <br /><br />
      <h2>Currency Converter</h2>
      <input
        type="number"
        value={rupees}
        onChange={(e) => setRupees(e.target.value)}
        placeholder="Enter Rupees"
      />
      <button onClick={handleSubmit}>Convert</button>
      {euros !== null && (
        <p>Converted: €{euros.toFixed(2)}</p>
      )}
    </div>
  );
}

export default App;
