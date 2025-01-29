import React from "react";
import "./Paymentsheet.css"; // Import CSS file

const Paymentsheet = ({ plot }) => {
  return (
    <div className="paymentsheet">
      <h1 className="title">תשלומים לחשבון הנאמנות</h1>
      <Table data={plot.paymentSheet} />
      
      <h1 className="title">תשלומים לחברת לקנות נדלן</h1>
      <Table data={plot.paymentSheet} />
      
      <h1 className="title">תשלומים נוספים</h1>
      <Table data={plot.paymentSheet} />
    </div>
  );
};

const Table = ({ data }) => (
  <table className="payment-table">
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
      {data?.map((item, index) => (
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
);

export default Paymentsheet;
