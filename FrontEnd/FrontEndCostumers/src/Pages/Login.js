import React, { useState } from 'react';
import axios from 'axios';
import { useNavigate } from 'react-router-dom';

const Login = () => {
    const [username, setUsername] = useState('');
    const [password, setPassword] = useState('');
    const [message, setMessage] = useState('');
    const [showForm, setShowForm] = useState(false);
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
                const verificationSuccess = await handleVerification(username, password);
                
                if (verificationSuccess) {
                    localStorage.setItem('username', username);
                    navigate('/VerifyPage');
                }
            }
        } catch (error) {
            setMessage(error.response?.data?.message || 'שם משתמש או סיסמה לא נכונים');
        }
    };

    const handleVerification = async (userName, password) => {
        try {
            const response = await axios.post('https://localhost:7219/api/Verification/SendVerificationCode', {
                userName,
                password,
            });
            
            localStorage.setItem('id', response.data.userId);
            return response.status === 200;
        } catch (error) {
            setMessage('שליחת קוד אימות נכשלה. נסה שוב.');
            return false;
        }
    };

    return (
        <div style={{ 
            display: 'flex', 
            justifyContent: 'center', 
            alignItems: 'center', 
            height: '100vh', 
            backgroundImage: 'url(/https://globalnadlan.co.il/wp-content/uploads/2022/12/%D7%A0%D7%93%D7%9C%D7%9F.jpg)', 
            backgroundSize: 'cover', 
            backgroundPosition: 'center',
            flexDirection: 'column',
            position: 'relative',
            fontFamily: 'Arial, sans-serif',
        }}>
            {!showForm ? (
                <button 
                    onClick={() => setShowForm(true)} 
                    style={{ 
                        padding: '15px 40px', 
                        fontSize: '22px', 
                        backgroundColor: 'rgba(0, 86, 179, 0.8)', 
                        color: 'white', 
                        border: 'none', 
                        borderRadius: '50px', 
                        cursor: 'pointer',
                        boxShadow: '0px 6px 15px rgba(0,0,0,0.3)',
                        transition: 'all 0.3s ease',
                        fontWeight: 'bold'
                    }}
                >
                    כניסה
                </button>
            ) : (
                // <div style={{ 
                //     background: 'rgba(255, 255, 255, 0.95)', 
                //     padding: '50px', 
                //     borderRadius: '20px', 
                //     boxShadow: '0px 8px 20px rgba(0,0,0,0.3)', 
                //     maxWidth: '420px',
                //     width: '100%',
                //     textAlign: 'center',
                //     backdropFilter: 'blur(10px)'
                // }}>
                <>
                    <h2 style={{ color: '#333', marginBottom: '25px', fontSize: '26px' }}>התחברות</h2>
                    <form onSubmit={handleSubmit} style={{ display: 'flex', flexDirection: 'column' }}>
                        <input
                            type="text"
                            placeholder="שם משתמש"
                            value={username}
                            onChange={(e) => setUsername(e.target.value)}
                            required
                            style={{ 
                                padding: '12px', 
                                marginBottom: '15px', 
                                borderRadius: '10px', 
                                border: '1px solid #aaa',
                                fontSize: '18px',
                                textAlign: 'center'
                            }}
                        />
                        <input
                            type="password"
                            placeholder="סיסמה"
                            value={password}
                            onChange={(e) => setPassword(e.target.value)}
                            required
                            style={{ 
                                padding: '12px', 
                                marginBottom: '15px', 
                                borderRadius: '10px', 
                                border: '1px solid #aaa',
                                fontSize: '18px',
                                textAlign: 'center'
                            }}
                        />
                        <button type="submit" style={{ 
                            padding: '12px', 
                            backgroundColor: '#28a745', 
                            color: 'white', 
                            border: 'none', 
                            borderRadius: '10px', 
                            cursor: 'pointer',
                            fontSize: '18px',
                            boxShadow: '0px 4px 10px rgba(0,0,0,0.3)',
                            fontWeight: 'bold'
                        }}>
                            התחבר
                        </button>
                    </form>
                    {message && <p style={{ color: 'red', marginTop: '15px', fontSize: '16px' }}>{message}</p>}
                {/* </div> */}
                </>
            )}
        </div>
    );
};

export default Login;
