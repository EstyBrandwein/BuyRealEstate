import React, { useState, useEffect } from 'react';
import axios from 'axios';

const GrossProfitPage = () => {
  const [grossProfit, setGrossProfit] = useState(null);
  const [loading, setLoading] = useState(true);
  const [error, setError] = useState(null);

  useEffect(() => {
    // Replace 'YOUR_API_ENDPOINT' with your backend endpoint
    axios.get('http://localhost:5145/api/plot')
      .then(response => {
        setGrossProfit(response.data);
        setLoading(false);
      })
      .catch(err => {
        console.error('Error fetching gross profit data:', err);
        setError('Failed to load gross profit data.');
        setLoading(false);
      });
  }, []);

  if (loading) return <div>Loading Gross Profit...</div>;
  if (error) return <div>{error}</div>;

  return (
    <div style={{ padding: '20px' }}>
      <h1>Gross Profit</h1>
      <pre>{JSON.stringify(grossProfit, null, 2)}</pre>
    </div>
  );
};
export default GrossProfitPage;

