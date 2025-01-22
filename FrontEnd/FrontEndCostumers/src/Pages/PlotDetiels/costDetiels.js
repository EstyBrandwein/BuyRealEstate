import React from "react";

const CostDetiels = ({ plot }) => {
  return (
    <div>
      <h3>פירוט עלויות</h3>
      <table
        border="1"
        style={{ width: "100%", textAlign: "right", marginTop: "20px" }}>
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
  );
};

export default CostDetiels;
