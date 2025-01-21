import React from "react";
import { useNavigate } from "react-router-dom";
import "./ListPlots.css";
function ProjectCard({ plot, isClickable }) {
  const navigate = useNavigate();
  const { id, project, plotSize, plotNumber, plotCost } = plot;
  // Function to handle card click
  const handleCardClick = () => {
    if (isClickable) {
      navigate(`/PlotsPage/${id}`);
    }
  };
  return (
    <div
      className={`project-card ${isClickable ? "clickable" : "non-clickable"}`}
      onClick={isClickable ? handleCardClick : undefined}
      style={{
        cursor: isClickable ? "pointer" : "default",
        opacity: isClickable ? 1 : 0.7, // רק כדי להבהיר ויזואלית
      }}
    >
      <h3 className="project-title">{project.projectName}</h3>
      <p className="project-info">כתובת: {project.projectAddress}</p>
      <p className="project-info">מספר מגרש: {plotNumber}</p>
      <p className="project-info">גודל: {plotSize} מ"ר</p>
      <p className="project-info">עלות: ₪{plotCost.toLocaleString()}</p>
    </div>
  );
}
export default ProjectCard;