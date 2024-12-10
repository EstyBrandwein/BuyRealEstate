import React from 'react';

const Documents = ({ documents }) => (
  <div style={{ border: "1px solid #ccc", padding: "10px" }}>
    <h2>Documents</h2>
    <ul>
      {documents && documents.map((doc, index) => (
        <li key={index}>{doc}</li>
      ))}
    </ul>
  </div>
);

export default Documents;
