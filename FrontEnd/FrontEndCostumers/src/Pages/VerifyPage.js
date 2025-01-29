import React, { useState } from 'react';
import axios from 'axios';

const VerificationPage = ({ userName,password }) => {
    const [code, setCode] = useState('');
    const [message, setMessage] = useState('');

    const handleVerification = async (e) => {
        e.preventDefault();
        try {
            const response = await axios.post('http://localhost:7219/api/Verification/send-verification-code', {
                userName,
                password,
            });

            if (response.status === 200) {
                setMessage('Verification successful! Redirecting...');
                // נווט לדף הראשי
                window.location.href = '/mainPage';
            }
        } catch (error) {
            setMessage('Invalid verification code. Please try again.');
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
