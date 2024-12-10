import React, { useState, useEffect } from "react";
import Details from "./realEstateDetails";
import Documents from "./documents";
import Payment from "./paymentsPage";
import GrossProfitPage from './profitCalculations';
import axios from "axios";

const DetailsPage = () => {
  const [data, setData] = useState({
    Details: null,
    Documents: null,
    Payment: null,
    Profit: null,
  });
  const [loading, setLoading] = useState(true);

  useEffect(() => {
    axios.get("http://localhost:5145/api/plot")
      .then(response => {
        setData(response.data);
        setLoading(false);
      })
      .catch(() => setLoading(false));
  }, []);

  if (loading) return <div>Loading...</div>;

  return (
    <div style={{ padding: "20px" }}>
      <h1>Details Page</h1>
      <div style={{ display: "grid", gap: "20px", gridTemplateColumns: "1fr 1fr" }}>
        <Details data={data.details} />
        <Documents documents={data.documents} />
        <Payment payment={data.payment} />
        <GrossProfitPage profit={data.profit} />
      </div>
    </div>
  );
};

export default DetailsPage;
