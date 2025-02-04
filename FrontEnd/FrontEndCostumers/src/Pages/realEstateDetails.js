import React, { useState, useEffect } from "react";
import axios from "axios";
import "../CSS/Contact.css";
import FileListViewer from "../Pages/Document/Document";
import { Link, useParams } from "react-router";
import ImageList from "./Image/ImageList";
import CostDetiels from "./PlotDetiels/costDetiels";
import Contact from "./PlotDetiels/Contact";
import Paymentsheet from "./PlotDetiels/Paymentsheet";
import DescriptionPlot from "./PlotDetiels/DescriptionPlot";
import Header from "./Header";
import ProgressUpdate from "./PlotDetiels/ProgressUpdate";
import Guarantees from "./PlotDetiels/Guarantees";
import { FaArrowRight } from "react-icons/fa";

import "../CSS/PlotsPage.css"
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
      case "description":return (<DescriptionPlot plot={plot}></DescriptionPlot>);
      case "updates":return (<ProgressUpdate></ProgressUpdate>);
      case "receiptsInvoices":return (<div><FileListViewer></FileListViewer></div>);
      case "doucuments":return (<div><FileListViewer projectId={1}></FileListViewer></div>);
      case "paymentSheet":return (<Paymentsheet plot={plot}></Paymentsheet>);
      case "fieldPhotos":return (<ImageList projectId={plot.project.id}></ImageList>);
      case "contact":return (<Contact></Contact>);
      case "costDetails": return (<CostDetiels plot={plot} />);
      case "guarantees":return (<Guarantees></Guarantees>);
      default:return <p>בחר לשונית כדי לראות תוכן.</p>;
    }
  };
  return (
    <div dir="rtl"> 
      <Header></Header>
      <Link to="/MainListPlots" className="header-icon-button" title=" למגרשים שלי"> 
       </Link>{error && <p style={{ color: "red" }}>{error}</p>}

      <h1><FaArrowRight className="header-icon"/>{plot?.project?.projectName || "[טעינת שם הפרויקט...]"}</h1>
        <div className="tabs-container" >
          <div onClick={() => setActiveTab("description")}style={{ padding: "10px 20px",cursor: "pointer", backgroundColor: activeTab === "description" ? "#D3D3D3" : "transparent",borderTopLeftRadius: "5px",fontWeight: "bold", }}>
            📄 תיאור פרויקט
          </div>
          <div onClick={() => setActiveTab("updates")}style={{padding: "10px 20px", cursor: "pointer", backgroundColor: activeTab === "updates" ? "#D3D3D3" : "transparent",borderTopLeftRadius: "5px",fontWeight: "bold",}}>
            🔨 עדכונים</div>
          <div onClick={() => setActiveTab("costDetails")} style={{padding: "10px 20px",cursor: "pointer",backgroundColor: activeTab === "costDetails" ? "#D3D3D3" : "transparent",fontWeight: "bold", }}>
            💰 פירוט עלויות
          </div>
          <div onClick={() => setActiveTab("guarantees")} style={{padding: "10px 20px",cursor: "pointer",backgroundColor: activeTab === "guarantees" ? "#D3D3D3" : "transparent",fontWeight: "bold",}}>
            🛡️ שוברים וערבויות
          </div>
          <div onClick={() => setActiveTab("paymentSheet")}style={{ padding: "10px 20px",  cursor: "pointer", backgroundColor: activeTab === "paymentSheet" ? "#D3D3D3" : "transparent",fontWeight: "bold",}}>
            📋 כרטסת תשלומים
          </div>
          <div   onClick={() => setActiveTab("receiptsInvoices")}style={{padding: "10px 20px",cursor: "pointer",backgroundColor: activeTab === "receiptsInvoices" ? "#D3D3D3" : "transparent",fontWeight: "bold",}}>
            🧾 קבלות/חשבוניות
          </div>
          <div onClick={() => setActiveTab("doucuments")}style={{padding: "10px 20px",cursor: "pointer",backgroundColor: activeTab === "doucuments" ? "#D3D3D3" : "transparent",fontWeight: "bold",}}>
            📂 מסמכים אישיים
          </div>
          <div onClick={() => setActiveTab("fieldPhotos")}style={{padding: "10px 20px",cursor: "pointer",backgroundColor: activeTab === "fieldPhotos" ? "#D3D3D3" : "transparent",fontWeight: "bold",}}>
            📷 תמונות מהשטח
          </div>
          <div onClick={() => setActiveTab("contact")}style={{padding: "10px 20px",cursor: "pointer",backgroundColor: activeTab === "contact" ? "#D3D3D3" : "transparent",fontWeight: "bold",}}>
            📞 צור קשר
          </div>
        </div>
        <div className="content">
          {renderContent()} {/* התוכן לא משנה את גובה האזור */}
        </div>
      </div>
  );
  
}
export default PlotsPage;