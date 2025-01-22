import React, { useState, useEffect } from "react";
import axios from "axios";
import "../CSS/Contact.css";
import FileListViewer from "../Pages/Document/Document";
import { useParams } from "react-router";
import ImageList from "./Image/ImageList";
import CostDetiels from "./PlotDetiels/costDetiels";
import Contact from "./PlotDetiels/Contact";
import Paymentsheet from "./PlotDetiels/Paymentsheet";
function PlotsPage() {
  const { id } = useParams();
  const [activeTab, setActiveTab] = useState("description");
  const [plot, setPlot] = useState(null); // State for the single plot
  const [error, setError] = useState(null);
  // Fetch data for a single plot
  useEffect(() => {
    axios
    .get(`https://localhost:7219/api/plot/${id}`) // Use backticks and template literals
      .then((response) => {
        setPlot(response.data);
      })
      .catch((err) => {
        setError("לא הצלחנו לטעון את נתוני המגרש.");
        console.error(err);
      });
  }, []);
  const renderContent = () => {
    if (!plot) return <p>טעינת נתוני המגרש...</p>;
    switch (activeTab) {
      case "description":
        return (
          <div>
            <h3>תיאור</h3>
            <p><strong>מספר מגרש:</strong> {plot.plotNumber}</p>
            <p><strong>גודל:</strong> {plot.plotSize} מ"ר </p>
            <p><strong>ערך:</strong> {plot.plotValue} ש"ח </p>
            <p> <strong>סטטוס משפטי:</strong>{" "}{plot.project?.legalStatus || "לא זמין"}</p>
            <p> <strong>שם פרויקט:</strong> {plot.project?.projectName}</p>
          </div>
        );
      case "receiptsInvoices":
        return (
          <div><FileListViewer></FileListViewer></div>
        );
        case "doucuments":
        return (
          <div><FileListViewer></FileListViewer></div>
        );
      case "paymentSheet":
        return (
          <Paymentsheet plot={plot}></Paymentsheet>
        );
      case "fieldPhotos":
        return (
          <ImageList projectId={plot.project.id}></ImageList>
        );
      case "contact":
        return (
          <Contact></Contact>
        );
      case "costDetails":
        return (
          <CostDetiels plot={plot} />
        );
      case "guarantees":
        return (
          <div>
            <h3>שובים וערבויות</h3>
            <table  border="1" style={{ width: "100%", textAlign: "right", marginTop: "20px" }}>
              <thead>
                <tr>
                  <th>תאריך תשלום</th>
                  <th>מספר שובר</th>
                  <th>סכום לתשלום</th>
                  <th>שולם?</th>
                  <th>הופקה ערבות</th>
                  <th>הערות</th>
                </tr>
              </thead>
              <tbody>
                {plot.guarantees?.map((item, index) => (
                  <tr key={index}>
                    <td>{item.paymentDate || "לא זמין"}</td>
                    <td>{item.receiptNumber || "לא זמין"}</td>
                    <td>{item.amountToPay || "לא זמין"}</td>
                    <td>{item.paid ? "כן" : "לא"}</td>
                    <td>{item.guaranteeIssued ? "כן" : "לא"}</td>
                    <td>{item.notes || "אין הערות"}</td>
                  </tr>
                ))}
              </tbody>
            </table>
          </div>
        );
      default:
        return <p>בחר לשונית כדי לראות תוכן.</p>;
    }
  };
  return (
    <div dir="rtl">
      {error && <p style={{ color: "red" }}>{error}</p>}
      <p>
        <strong>שם פרויקט:</strong>{" "}
        {plot?.project?.projectName || "[טעינת שם הפרויקט...]"}{" "}
      </p>
      <div style={{ display: "flex", flexDirection: "column" }}>
        <div style={{ display: "flex", borderBottom: "2px solid #ccc" }}>
          <div onClick={() => setActiveTab("description")}style={{padding: "10px 20px",cursor: "pointer",backgroundColor:activeTab === "description" ? "#D3D3D3" : "transparent",
          borderTopLeftRadius: "5px", fontWeight: "bold",}}>תאור פרויקט</div>
          <div onClick={() => setActiveTab("costDetails")}style={{ padding: "10px 20px", cursor: "pointer",backgroundColor:activeTab === "costDetails" ? "#D3D3D3" : "transparent",
              fontWeight: "bold",}} > פירוט עלויות</div>
          <div onClick={() => setActiveTab("guarantees")} style={{padding: "10px 20px",cursor: "pointer", backgroundColor:activeTab === "guarantees" ? "#D3D3D3" : "transparent",
              fontWeight: "bold", }}>שוברים וערבויות</div>
          <div onClick={() => setActiveTab("paymentSheet")} style={{padding: "10px 20px",cursor: "pointer",
              backgroundColor:
                activeTab === "paymentSheet" ? "#D3D3D3" : "transparent",
              fontWeight: "bold",
            }}
          >
            כרטסת תשלומים
          </div>
          <div
            onClick={() => setActiveTab("receiptsInvoices")}
            style={{
              padding: "10px 20px",
              cursor: "pointer",
              backgroundColor:
                activeTab === "receiptsInvoices" ? "#D3D3D3" : "transparent",
              fontWeight: "bold",
            }}
          >
            קבלות/חשבוניות
          </div>
          <div
            onClick={() => setActiveTab("doucuments")}
            style={{
              padding: "10px 20px",
              cursor: "pointer",
              backgroundColor:
                activeTab === "doucuments" ? "#D3D3D3" : "transparent",
              fontWeight: "bold",
            }}
          >
מסמכים אישיים
          </div>
          
          <div
            onClick={() => setActiveTab("fieldPhotos")}
            style={{
              padding: "10px 20px",
              cursor: "pointer",
              backgroundColor:
                activeTab === "fieldPhotos" ? "#D3D3D3" : "transparent",
              fontWeight: "bold",
            }}
          >
            תמונות מהשטח
          </div>
          <div onClick={() => setActiveTab("contact")} style={{ padding: "10px 20px",
              cursor: "pointer",
              backgroundColor:
                activeTab === "contact" ? "#D3D3D3" : "transparent",
              fontWeight: "bold",
            }}
          >
            צור קשר
          </div>
        </div>
        <div style={{ padding: "10px" }}>{renderContent()}</div>
      </div>
    </div>
  );
}
export default PlotsPage;