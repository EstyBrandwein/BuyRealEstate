import React, { useState, useEffect } from "react";
import axios from "axios";
import "../CSS/Contact.css";
import FileListViewer from "../Pages/Document/Document";
import { useParams } from "react-router";
import ImageList from "./Image/ImageList";
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
      case "paymentSheet":
        return (
          <div>
            <table border="1" style={{ width: "100%", textAlign: "right" }}>
              <thead>
                <tr>
                  <th>כותרת</th>
                  <th>תנועה</th>
                  <th>מנה</th>
                  <th>ס"ת</th>
                  <th>ת.אסמכתא</th>
                  <th>ת.ערך</th>
                  <th>אסמכתא</th>
                  <th>פרטים</th>
                  <th>חובה / זכות</th>
                </tr>
              </thead>
              <tbody>
                {plot.paymentSheet?.map((item, index) => (
                  <tr key={index}>
                    <td>{item.title}</td>
                    <td>{item.movement}</td>
                    <td>{item.manager}</td>
                    <td>{item.summarized}</td>
                    <td>{item.referenceDate}</td>
                    <td>{item.valueDate}</td>
                    <td>{item.reference}</td>
                    <td>{item.details}</td>
                    <td>{item.debitCredit}</td>
                  </tr>
                ))}
              </tbody>
            </table>
          </div>
        );
      case "fieldPhotos":
        return (
          <div>
            <ImageList projectId={plot.project.id}></ImageList>
          </div>
        );
      case "contact":
        return (
          <div style={{textAlign: "right", direction: "rtl",fontFamily: "Arial",}}>
            <form style={{ maxWidth: "400px", margin: "auto" }}>
              <div style={{ marginBottom: "10px" }}>
                <label htmlFor="name"style={{ display: "block", marginBottom: "5px" }}>
                  שם:
                </label>
                <input type="text"id="name" name="name" style={{width: "100%", padding: "8px", boxSizing: "border-box",}} placeholder="הכנס את שמך"/>
              </div>
              <div style={{ marginBottom: "10px" }}>
                <label htmlFor="email" style={{ display: "block", marginBottom: "5px" }} > אימייל:</label>
                <input  type="email" id="email" name="email" style={{ width: "100%", padding: "8px",boxSizing: "border-box",}}placeholder="הכנס את האימייל שלך"/>
              </div>
              <div style={{ marginBottom: "10px" }}>
                <label  htmlFor="phone" style={{ display: "block", marginBottom: "5px" }} >טלפון: </label>
                <input type="text" id="phone" name="phone" style={{ width: "100%", padding: "8px", boxSizing: "border-box", }} placeholder="הכנס את הטלפון שלך"/>
              </div>
              <div style={{ marginBottom: "10px" }}>
                <label htmlFor="message" style={{ display: "block", marginBottom: "5px" }} > הודעה:</label>
                <textarea  id="message" name="message"style={{ width: "100%", padding: "8px", boxSizing: "border-box", height: "80px", }} placeholder="הכנס את ההודעה שלך"></textarea>
              </div>
              <button type="submit" style={{width: "100%", padding: "10px",backgroundColor: "#4CAF50",color: "white",border: "none",cursor: "pointer",fontSize: "16px",}}>
                שליחה
              </button>
            </form>
          </div>
        );
      case "costDetails":
        return (
          <div>
            <h3>פירוט עלויות</h3>
            <table border="1" style={{ width: "100%", textAlign: "right", marginTop: "20px" }}>
              <thead>
                <tr>
                  <th>תיאור</th>
                  <th>ערך</th>
                </tr>
              </thead>
              <tbody>
                <tr>
                  <td>תאריך עדכון</td>
                  <td>{plot.updateDate || "לא זמין"}</td>
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
                  <td>{plot.plotCost || "לא זמין"}</td>
                </tr>
                <tr>
                  <td>הון עצמי</td>
                  <td>{plot.equity || "לא זמין"}</td>
                </tr>
                <tr>
                  <td>קרקע</td>
                  <td>{plot.ground || "לא זמין"}</td>
                </tr>
                <tr>
                  <td>בנייה</td>
                  <td>{plot.buildingCost || "לא זמין"}</td>
                </tr>
                <tr>
                  <td>ניהול וכלליות</td>
                  <td>{plot.managmentCost || "לא זמין"}</td>
                </tr>
              </tbody>
            </table>
          </div>
        );
      case "profile":
        return (
          <div>
            <h3>פרופיל</h3>
            <p><strong>שם רוכש:</strong> {plot.user?.username} </p>
            <p><strong>ת.ז.:</strong> {plot.user?.id}</p>
            <p><strong>טלפון ראשי:</strong> {plot.user?.firstPhone}</p>
            <p><strong>טלפון משני:</strong> {plot.user?.secendPhon || "לא קיים"}</p>
            <p><strong>מייל:</strong> {plot.user?.email}</p>
            <h4>רשימת מגרשים:</h4>
            <ul>
              {plot.user?.plots?.map((p, index) => (
                <li key={index}>
                  <strong>מגרש מס' {p.plotNumber}:</strong> {p.plotSize} מ"ר -{" "}
                  {p.plotCost} $
                </li>
              ))}
            </ul>
          </div>
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
          <div onClick={() => setActiveTab("profile")}style={{padding: "10px 20px",cursor: "pointer",backgroundColor:activeTab === "profile" ? "#D3D3D3" : "transparent",
          borderTopLeftRadius: "5px", fontWeight: "bold",}}>פרופיל</div>
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