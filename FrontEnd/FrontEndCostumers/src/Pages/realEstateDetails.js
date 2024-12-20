// src/pages/PlotsPage.js
import React, { useState } from "react";
import Sidebar from "react-sidebar";

function PlotsPage() {
  const [activeTab, setActiveTab] = useState("description");

  const renderContent = () => {

    switch (activeTab) {
      case "description":
        return (
          <div>
            <h3>Description</h3>
            <p><strong>Number:</strong> [Insert Number]</p>
            <p><strong>Status:</strong> [Insert Status]</p>
            <p><strong>Name of Neman:</strong> [Insert Name]</p>
            <p><strong>Legal Status:</strong> [Insert Legal Status]</p>
          </div>
        );
      case "payments":
        return (
          <div>
            <h3>Payments</h3>
            <table border="1">
              <thead>
                <tr>
                  <th>Sum</th>
                  <th>For Whom</th>
                  <th>Payment Until</th>
                  <th>Document</th>
                  <th>Way of Pay</th>
                  <th>Women for Pay</th>
                  <th>Status</th>
                </tr>
              </thead>
              <tbody>
                {/* Example row */}
                <tr>
                  <td>$1000</td>
                  <td>John Doe</td>
                  <td>2024-12-31</td>
                  <td>Document.pdf</td>
                  <td>Bank Transfer</td>
                  <td>Jane Doe</td>
                  <td>Completed</td>
                </tr>
              </tbody>
            </table>
            <h4>Summary</h4>
            <p><strong>Total Paid:</strong> [Insert Total Paid]</p>
            <p><strong>Total Left to Pay:</strong> [Insert Remaining]</p>
            <p><strong>Project Cost:</strong> [Insert Cost]</p>
            <p><strong>Links to Website:</strong> <a href="[Insert Link]">[Insert Link]</a></p>
          </div>
        );
      case "projectCost":
        return (
          <div>
            <h3>Project Cost</h3>
            <p><strong>Monthly Pay Bill:</strong> [Insert Monthly Bill]</p>
            <p><strong>Number of Months:</strong> [Insert Months]</p>
            <p><strong>Sum of Payments:</strong> [Insert Total Payments]</p>
            <p><strong>Project Worth:</strong> [Insert Worth]</p>
            <p><strong>Gross Profit:</strong> [Insert Gross Profit]</p>
          </div>
        );
      case "documents":
        return (
          <div>
            <h3>Documents</h3>
            <p><strong>Private Documents:</strong> [Insert Private Documents]</p>
            <p><strong>Public Bill Documents:</strong> [Insert Public Documents]</p>
            <p><strong>Receipts:</strong> [Insert Receipts]</p>
          </div>
        );
      default:
        return <div>Select a tab to view content</div>;
    }
  };

  return (
    <div>    
      {/* <Sidebar username="User123" email="user123@example.com" onLogout={() => {}} /> */}
      <p><strong>Project Name:</strong> [Insert Project Name]</p>
      <div style={{ display: "flex" }}>
        <nav style={{ width: "20%", borderRight: "1px solid #ccc", padding: "10px" }}>
          <ul>
            <li><button onClick={() => setActiveTab("description")}>Description</button></li>
            <li><button onClick={() => setActiveTab("payments")}>Payments</button></li>
            <li><button onClick={() => setActiveTab("projectCost")}>Project Cost</button></li>
            <li><button onClick={() => setActiveTab("documents")}>Documents</button></li>
          </ul>
        </nav>
        <div style={{ padding: "10px", width: "80%" }}>{renderContent()}</div>
      </div>
    </div>
  );
}

export default PlotsPage;
