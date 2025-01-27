import React from "react";
import "./DescriptionPlot.css";

const DescriptionPlot = ({ plot }) => {
  return (
    <div className="description-plot-container">
      <div className="description-plot-card">
        <h3 className="description-plot-title">📋 תיאור</h3>
        <p>
          <strong>מספר מגרש:</strong> {plot.plotNumber || "לא זמין"}
        </p>
        <p>
          <strong>גודל:</strong> {plot.plotSize ? `${plot.plotSize} מ"ר` : "לא זמין"}
        </p>
        <p>
          <strong>ערך:</strong> {plot.plotValue ? `${plot.plotValue} ש"ח` : "לא זמין"}
        </p>
        <p>
          <strong>סטטוס משפטי:</strong> {plot.project?.legalStatus || "לא זמין"}
        </p>
        <p>
          <strong>שם פרויקט:</strong> {plot.project?.projectName || "לא זמין"}
        </p>
      </div>
    </div>
  );
};

export default DescriptionPlot;
