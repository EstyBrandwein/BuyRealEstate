import React from "react";
import Header from "../Header";

const Contact = () => {
  return (
    <div dir="rtl"> 
           <Header></Header>

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
            </div>
          );
};

export default Contact;
