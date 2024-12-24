import React, { useEffect, useState } from 'react';
import { fetchPlotsData } from '../services/api';

function MyPlots() {
  const [plots, setPlots] = useState([]);

  useEffect(() => {
    async function loadPlots() {
      const data = await fetchPlotsData();
      setPlots(data);
    }
    loadPlots();
  }, []);

  if (plots.length === 0) return <p>Loading...</p>;

  return (
    <div>
      <h2>המגרשים שלי</h2>
      {plots.map((plot, index) => (
        <div key={index} className="card mb-3">
          <div className="card-body">
            <h5>מגרש: {plot.name}</h5>
            <p>שם הרוכש: {plot.ownerName}</p>
            <p>ת.ז: {plot.idNumber}</p>
            <p>כתובת: {plot.address}</p>
            <p>טלפון רשאי: {plot.primaryPhone}</p>
            <p>דוא"ל: {plot.email}</p>
          </div>
        </div>
      ))}
    </div>
  );
}

export default MyPlots;
