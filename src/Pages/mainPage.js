import React from "react";
import { Link, useNavigate } from "react-router-dom";
import Sidebar from './sideBarPage';

const fields = [
  { id: 1, name: "Field 1", description: "Short description of Field 1", image: "https://via.placeholder.com/150" },
  { id: 2, name: "Field 2", description: "Short description of Field 2", image: "https://via.placeholder.com/150" },
  { id: 3, name: "Field 3", description: "Short description of Field 3", image: "https://via.placeholder.com/150" },
];

export default function MainPage() {
  const navigate = useNavigate();

  const handleCardClick = (id) => {
    console.log(`Navigating to details for project ID: ${id}`);
    navigate(`/my-fields`);

  };
  

  return (
    <div style={{ padding: "20px", maxWidth: "800px", margin: "0 auto" }}>
      <Sidebar username="User123" email="user123@example.com" onLogout={() => {}} />
      <h1 style={{ textAlign: "center" }}>הפרויקטים שלי</h1>
      <div style={{ display: "flex", flexDirection: "column", gap: "20px" }}>
        {fields.map((field) => (
          <div
            key={field.id}
            //onClick={() => handleCardClick(field.id)}
            
            style={{
              cursor: "pointer",
              display: "flex",
              alignItems: "center",
              border: "1px solid #ccc",
              borderRadius: "8px",
              padding: "15px",
              backgroundColor: "#f9f9f9",
            }}
          >
            <img
              src={field.image}
              alt={field.name}
              style={{
                width: "100px",
                height: "100px",
                objectFit: "cover",
                marginRight: "15px",
                borderRadius: "8px",
              }}
            />
            <div>
              <h2 style={{ margin: "0 0 5px 0" }}>{field.name}</h2>
              <p style={{ margin: "0", color: "#555" }}>{field.description}</p>
              <Link to="/my-fields">השדות שלי</Link>

            </div>
          </div>
        ))}
      </div>
    </div>
  );
}
