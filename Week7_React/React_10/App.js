import React, { useEffect, useState } from 'react';

function App() {
  const [offices, setOffices] = useState([]);

  useEffect(() => {
    fetch("http://localhost:5000/api/offices")
      .then(res => res.json())
      .then(data => setOffices(data));
  }, []);

  return (
    <div style={{ fontFamily: 'Arial, sans-serif', padding: '20px' }}>
      <h1 style={{ textAlign: 'center' }}>Office Space Rental</h1>

      <img
        src="/office.jpg" 
        alt="Office"
        style={{
          display: 'block',
          margin: '20px auto',
          width: '300px',
          borderRadius: '10px',
          boxShadow: '0 0 10px rgba(0,0,0,0.2)'
        }}
      />

      <h2>Available Offices:</h2>
      <li>Office Space One : Rs. 55000</li>
      <li>Office Space Two : Rs. 65000</li>
      <li>Office Space Three : Rs. 45000</li>
      <ul style={{ listStyle: 'none', padding: 0 }}>
        {offices.map((office, idx) => (
          <li
            key={idx}
            style={{
              background: '#f9f9f9',
              padding: '10px',
              marginBottom: '10px',
              borderRadius: '5px',
              borderLeft: `5px solid ${office.Rent < 60000 ? 'red' : 'green'}`
            }}
          >
            <strong>{office.Name}</strong> {' '}
            <span style={{ color: office.Rent < 60000 ? 'red' : 'green' }}>
              ₹{office.Rent}
            </span>{' '}
            – {office.Address}
          </li>
        ))}
      </ul>
    </div>
  );
}

export default App;
