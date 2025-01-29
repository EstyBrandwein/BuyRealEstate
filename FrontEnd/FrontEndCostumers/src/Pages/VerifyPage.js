import React, { useState } from 'react';
import axios from 'axios';
import { useLocation, useNavigate } from 'react-router-dom';

const VerificationPage = () => {
    const [code, setCode] = useState('');
    const [message, setMessage] = useState('');
    const navigate = useNavigate();
    const location = useLocation();
    const userId = location.state?.userId; 

    const handleVerification = async (e) => {
        e.preventDefault();

        console.log("📢 שולח קוד אימות:", { userId, code });

        try {
            const response = await axios.post('https://localhost:7219/api/Verification/CheckVerificationCode', {
                userId,
                code,
            });

            console.log("✅ תגובת שרת:", response.data);

            if (response.status === 200) {
                navigate('/MainListPlot'); // נווט לעמוד הראשי
            } else {
                setMessage('קוד שגוי, נסה שוב.');
            }
        } catch (error) {
            console.error("❌ שגיאת אימות:", error.response?.data || error.message);
            setMessage(error.response?.data?.message || 'קוד שגוי, נסה שוב.');
        }
    };

    return (
        <div dir="rtl">
            <h2>אנא הכנס קוד אימות</h2>
            <form onSubmit={handleVerification}>
                <input
                    type="text"
                    placeholder="קוד אימות"
                    value={code}
                    onChange={(e) => setCode(e.target.value)}
                    required
                    style={{ width: "100%", padding: "8px", boxSizing: "border-box" }}
                />
                <button type="submit" style={{ width: "100%", padding: "10px", backgroundColor: "#4CAF50", color: "white", border: "none", cursor: "pointer" }}>
                    אשר
                </button>
            </form>
            {message && <p>{message}</p>}
        </div>
    );
};

export default VerificationPage;
