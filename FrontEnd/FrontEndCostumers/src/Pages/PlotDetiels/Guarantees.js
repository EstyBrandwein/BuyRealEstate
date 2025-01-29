import { useEffect, useState } from "react";
import "./Guarantees.css"; // ייבוא קובץ ה-CSS לעיצוב
function Guarantees() {
  const [guarantees, setGuarantees] = useState([]);
  useEffect(() => {
    const fetchGuarantees = async () => {
      try {
        const response = await fetch("https://localhost:7219/api/Guarantees");
        if (!response.ok) {
          throw new Error(`Error fetching guarantees: ${response.statusText}`);
        }
        const data = await response.json();
        console.log("Fetched Guarantees:", data);
        const processedGuarantees = data.map(item => ({
          dateOfPayment: item.dateOfPayment || null,
          voucherNumber: item.voucherNumber || "לא זמין",
          amount: item.amount || 0,
          isPaid: item.isPaid || false,
          guaranteeUssued: item.guaranteeUssued || false,
          note: item.note || "",
        }));
        setGuarantees(processedGuarantees);
      } catch (error) {
        console.error("Error:", error.message);
        alert("Failed to load guarantees.");
      }
    };
    fetchGuarantees();
  }, []);
  return (
    <div className="guarantees-container">
      <table className="guarantees-table">
        <thead>
          <tr>
            <th>תאריך תשלום</th>
            <th>מספר שובר</th>
            <th>סכום לתשלום</th>
            <th>שולם</th>
            <th>הופקה ערבות</th>
            <th>הערות</th>
          </tr>
        </thead>
        <tbody>
          {guarantees.map((item, index) => (
            <tr key={index}>
              <td>{item.dateOfPayment
                  ? new Date(item.dateOfPayment).toLocaleDateString("he-IL")
                  : "לא זמין"} </td>
              <td>{item.voucherNumber}</td>
              <td>{item.amount}</td>
              <td>{item.isPaid ? "✅" : "❌"}</td>
              <td>{item.guaranteeUssued ? "✅" : "❌"}</td>
              <td>{item.note || " "}</td>
            </tr>
          ))}
        </tbody>
      </table>
    </div>
  );
}
export default Guarantees;