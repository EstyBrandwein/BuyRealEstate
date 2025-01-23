import React from "react";

const Paymentsheet = ({ plot }) => {
  return (
    <div>
    <h1>תשלומים לחשבון הנאמנות</h1>
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
    <h1>תשלומים לחברת לקנות נדלן</h1>
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
    <h1>תשלומים נוספים</h1>
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
};

export default Paymentsheet;
