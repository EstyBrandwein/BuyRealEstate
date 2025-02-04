import React, { useState } from 'react';
import axios from 'axios';
import { useNavigate } from 'react-router-dom';

const Login = () => {
    const [username, setUsername] = useState('');
    const [password, setPassword] = useState('');
    const [message, setMessage] = useState('');
    const navigate = useNavigate();

    const handleSubmit = async (e) => {
        e.preventDefault();
        try {
            const response = await axios.post(
                'https://localhost:7219/api/user/login',
                { username, password },
                { headers: { 'Content-Type': 'application/json' } }
            );

            if (response.status === 200) {
                console.log("userName", username, "password", password);
                //lockalstorage
                // שליחת קוד האימות
                const verificationSuccess = await handleVerification(username, password);
                
                if (verificationSuccess) {
                    localStorage.setItem('username', username);
                    console.log(response.data);
                    
                   // localStorage.setItem('id', response.data.user.Id);
                    navigate('/VerifyPage');
                    //navigate('/VerifyPage', { state: { userId: response.data.Id } });
                }
            }
        } catch (error) {
            console.error("Login error:", error);
            setMessage(error.response?.data?.message || 'ארעה שגיאה, אנא נסה שנית');
        }
    };

    const handleVerification = async (userName, password) => {
        try {
            const response = await axios.post('https://localhost:7219/api/Verification/SendVerificationCode', {
                userName,
                password,
            });
            console.log("response",response.data.userId);
            
            localStorage.setItem('id', 11
                // response.data.userId
            );

            if (response.status === 200) {
                return true; // שליחת הקוד הצליחה
            }
        } catch (error) {
            setMessage('שליחת קוד אימות נכשלה. נסה שוב.');
            return false; // שליחת הקוד נכשלה
        }
    };

    return (
        <div dir="rtl">
            <h2>התחברות</h2>
            <form onSubmit={handleSubmit}>
                <input
                    type="text"
                    placeholder="שם משתמש"
                    value={username}
                    onChange={(e) => setUsername(e.target.value)}
                    required
                    style={{ width: "100%", padding: "8px", boxSizing: "border-box" }}
                />
                <input
                    type="password"
                    placeholder="סיסמה"
                    value={password}
                    onChange={(e) => setPassword(e.target.value)}
                    required
                    style={{ width: "100%", padding: "8px", boxSizing: "border-box" }}
                />
                <button type="submit" style={{ width: "100%", padding: "10px", backgroundColor: "#4CAF50", color: "white", border: "none", cursor: "pointer" }}>
                    התחבר
                </button>
            </form>
            {message && <p>{message}</p>}
        </div>
    );
};

export default Login;
