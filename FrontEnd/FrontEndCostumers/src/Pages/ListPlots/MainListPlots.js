import React, { useState, useEffect } from "react";
import axios from "axios";
import Sidebar from "../sideBarPage";
import ProjectCard from "./ProjectCard";
import "./ListPlots.css"
import { useNavigate } from "react-router";
function MainListPlots() {
  const [plots, setPlots] = useState([]);
  useEffect(() => {
    const fetchPlots = async () => {
      try {
        const response = await axios.get(
          "https://localhost:7219/api/plot",
          { id: 1 },
          { headers: { "Content-Type": "application/json" } }
        );
        setPlots(response.data);
      } catch (error) {
        console.error("Error fetching plots:", error);
      }
    };
    fetchPlots();
  }, []);
  const navigate = useNavigate();
  // Function to handle page click
  const handlePageClick = (id) => {
    navigate(`/PlotsPage/${id}`);
  };
  return (
    <div className="plots-list">
      {plots.map((plot) => (
        <div
          key={plot.id}
          className="project-card"
          onClick={() => handlePageClick(plot.id)}
        >
          <h3 className="project-title">{plot.project.projectName}</h3>
          <p className="project-info">כתובת: {plot.project.projectAddress}</p>
          <p className="project-info">מספר מגרש: {plot.plotNumber}</p>
          <p className="project-info">גודל: {plot.plotSize} מ"ר</p>
          <p className="project-info">עלות: ₪{plot.plotCost.toLocaleString()}</p>
        </div>
      ))}
    </div>
  );
}
export default MainListPlots;