import React, { useState } from 'react';
import axios from 'axios';
import { useLocation, useNavigate } from 'react-router-dom';
import './VerifyPage.css'; // יבוא את קובץ ה-CSS

const VerificationPage = () => {
    const [code, setCode] = useState(['', '', '', '', '', '']);
    const [message, setMessage] = useState('');
    const navigate = useNavigate();
    const location = useLocation();
    const storedUserId = localStorage.getItem('username');
    const username = location.state?.userId || storedUserId;

    const handleVerification = async (e) => {
        e.preventDefault();

        const codeString = code.join('');

        console.log("📢 שולח קוד אימות:", { username, codeString });

        try {
            const response = await axios.post('https://localhost:7219/api/Verification/VerifyCode', {
                username,
                code: codeString,
            });

            console.log("✅ תגובת שרת:", response.data);

            if (response.status === 200) {
                navigate('/MainListPlots');
            } else {
                setMessage('קוד שגוי, נסה שוב.');
            }
        } catch (error) {
            console.error("❌ שגיאת אימות:", error.response?.data || error.message);
            setMessage(error.response?.data?.message || 'קוד שגוי, נסה שוב.');
        }
    };

    const handleChange = (e, index) => {
        const newCode = [...code];
        newCode[index] = e.target.value.slice(0, 1); // מאפשר רק ספרה אחת
        setCode(newCode);

        // אם הקלט מלא, עבור לתא הבא
        if (e.target.value.length === 1 && index < 5) {
            document.getElementById(`code-input-${index + 1}`).focus();
        } 
        // אם מוחקים ספרה, עבור לתא הקודם
        else if (e.target.value === '' && index > 0) {
            document.getElementById(`code-input-${index - 1}`).focus();
        }
    };

    const handlePaste = (e) => {
        const pasteData = e.clipboardData.getData('text');
        const newCode = pasteData.split('').slice(0, 6); // הגבלת ההדבקה ל-6 ספרות
        setCode(newCode);

        // מיקוד לתא הראשון
        document.getElementById('code-input-0').focus();
    };

    return (
        <div className="verification-container" dir="ltr">
            <h1>קוד אימות נשלח אליך כרגע למייל</h1>
            <b>הקוד תקף ל-10 דקות בלבד</b>
            <h2>אנא הכנס קוד אימות</h2>
            <form onSubmit={handleVerification}>
                <div className="input-code">
                    {code.map((digit, index) => (
                        <input className='input-code-'
                            id={`code-input-${index}`}
                            key={index}
                            type="text"
                            maxLength="1"
                            value={digit}
                            onChange={(e) => handleChange(e, index)}
                            onPaste={handlePaste}  // הוספת פונקציה להדבקה
                            required
                        />
                    ))}
                </div>
                <button type="submit">אשר</button>
            </form>
            {message && <p className="message">{message}</p>}
        </div>
    );
};

export default VerificationPage;
