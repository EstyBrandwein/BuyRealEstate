import React, { useState, useEffect } from 'react';
import axios from 'axios';

const PaymentPage = () => {
  const [payments, setPayments] = useState([]);
  const [loading, setLoading] = useState(true);
  const [error, setError] = useState(null);

  useEffect(() => {
    // Replace 'YOUR_API_ENDPOINT' with your backend endpoint
    axios.get('http://localhost:5145/api/plot')
      .then(response => {
        setPayments(response.data);
        setLoading(false);
      })
      .catch(err => {
        console.error('Error fetching payment data:', err);
        setError('Failed to load payment data.');
        setLoading(false);
      });
  }, []);

  if (loading) return <div>Loading Payments...</div>;
  if (error) return <div>{error}</div>;

  return (
    <div style={{ padding: '20px' }}>
      <h1>Payment Details</h1>
      <ul>
        {payments.map((payment, index) => (
          <li key={index}>
            <strong>{payment.date}</strong>: {payment.amount} {payment.currency}
          </li>
        ))}
      </ul>
    </div>
  );
};

export default PaymentPage;
