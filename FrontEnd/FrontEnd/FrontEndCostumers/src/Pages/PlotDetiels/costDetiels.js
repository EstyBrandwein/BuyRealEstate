import React from "react";
import "./CostDetiels.css";

const CostDetiels = ({ plot }) => {
  return (
    <div className="cost-details-container">
      <div className="cost-details-card">
        <h3 className="cost-details-title">פירוט עלויות</h3>
        <table className="cost-details-table">
          <thead>
            <tr>
              <th>תיאור</th>
              <th>ערך</th>
            </tr>
          </thead>
          <tbody>
            <tr>
              <td>תאריך עדכון</td>
              <td>
                {plot.updateDate
                  ? new Date(plot.updateDate).toLocaleDateString()
                  : "לא זמין"}
              </td>
            </tr>
            <tr>
              <td>שם הרוכש</td>
              <td>{plot.user?.username || "לא זמין"}</td>
            </tr>
            <tr>
              <td>קבוצה</td>
              <td>{plot.project?.projectName || "לא זמין"}</td>
            </tr>
            <tr>
              <td>עלות יחידה משוער</td>
              <td>
                {plot.plotCost !== undefined && plot.plotCost !== null
                  ? plot.plotCost
                  : "לא זמין"}
              </td>
            </tr>
            <tr>
              <td>הון עצמי</td>
              <td>
                {plot.equity !== undefined && plot.equity !== null
                  ? plot.equity
                  : "לא זמין"}
              </td>
            </tr>
            <tr>
              <td>קרקע</td>
              <td>
                {plot.ground !== undefined && plot.ground !== null
                  ? plot.ground
                  : "לא זמין"}
              </td>
            </tr>
            <tr>
              <td>בנייה</td>
              <td>
                {plot.buildingCost !== undefined && plot.buildingCost !== null
                  ? plot.buildingCost
                  : "לא זמין"}
              </td>
            </tr>
            <tr>
              <td>ניהול וכלליות</td>
              <td>
                {plot.managmentCost !== undefined &&
                plot.managmentCost !== null
                  ? plot.managmentCost
                  : "לא זמין"}
              </td>
            </tr>
          </tbody>
        </table>
      </div>
    </div>
  );
};

export default CostDetiels;
