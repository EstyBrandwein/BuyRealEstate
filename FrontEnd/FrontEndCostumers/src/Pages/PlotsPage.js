import React, { useState, useEffect } from "react";
import axios from "axios";

function PlotsPage() {
  const [activeTab, setActiveTab] = useState("description");
  const [plot, setPlot] = useState(null); // State for the single plot
  const [error, setError] = useState(null);

  // Fetch data for a single plot
  useEffect(() => {
    axios
      .get("https://localhost:7219/api/plot/1")
      .then((response) => {
        setPlot(response.data);
      })
      .catch((err) => {
        setError("Failed to fetch plot data.");
        console.error(err);
      });
  }, []);

  const renderContent = () => {
    if (!plot) return <p>Loading plot data...</p>;

    switch (activeTab) {
      case "description":
        return (
          <div>
            <h3>Description</h3>
            <p><strong>Plot Number:</strong> {plot.plotNumber}</p>
            <p><strong>Size:</strong> {plot.plotSize} sqm</p>
            <p><strong>Value:</strong> {plot.plotValue} USD</p>
            <p><strong>Legal Status:</strong> {plot.project?.legalStatus || "N/A"}</p>
            <p><strong>Project Name:</strong> {plot.project?.projectName}</p>
          </div>
        );
      case "payments":
        return (
          <div>
            <h3>Payments</h3>
            <table border="1">
              <thead>
                <tr>
                  <th>Equity</th>
                  <th>Building Cost</th>
                  <th>Monthly Funding Cost</th>
                  <th>Months for Funding</th>
                  <th>Total Value</th>
                </tr>
              </thead>
              <tbody>
                <tr>
                  <td>{plot.equity} USD</td>
                  <td>{plot.buildingCost} USD</td>
                  <td>{plot.monthlyFundingCost} USD</td>
                  <td>{plot.monthsForFundingCost}</td>
                  <td>{plot.plotValue} USD</td>
                </tr>
              </tbody>
            </table>
          </div>
        );
      case "projectCost":
        return (
          <div>
            <h3>Project Cost</h3>
            <p><strong>Total Plot Cost:</strong> {plot.plotCost} USD</p>
            <p><strong>Management Cost:</strong> {plot.managmentCost} USD</p>
            <p><strong>Ground Cost:</strong> {plot.ground} USD</p>
            <p><strong>Gross Profit:</strong> {plot.project?.grossProfit || "N/A"} USD</p>
          </div>
        );
      case "documents":
        return (
          <div>
            <h3>Documents</h3>
            <p><strong>Project Documents:</strong> {plot.project?.documents?.length || 0} available</p>
          </div>
        );
      default:
        return <p>Select a tab to view content.</p>;
    }
  };

  return (
    <div>
      {error && <p style={{ color: "red" }}>{error}</p>}
      <p><strong>Project Name:</strong> {plot?.project?.projectName || "[Loading Project Name...]"}</p>
      <div style={{ display: "flex" }}>
        <nav style={{ width: "20%", borderRight: "1px solid #ccc", padding: "10px" }}>
          <ul>
            <li><button onClick={() => setActiveTab("description")}>Description</button></li>
            <li><button onClick={() => setActiveTab("payments")}>Payments</button></li>
            <li><button onClick={() => setActiveTab("projectCost")}>Project Cost</button></li>
            <li><button onClick={() => setActiveTab("documents")}>Documents</button></li>
          </ul>
        </nav>
        <div style={{ padding: "10px", width: "80%" }}>
          {renderContent()}
        </div>
      </div>
    </div>
  );
}

export default PlotsPage;
