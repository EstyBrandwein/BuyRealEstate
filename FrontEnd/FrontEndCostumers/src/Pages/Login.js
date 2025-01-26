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
                navigate('/VerifyPage', { state: { userId: response.data.userId } });
            }
        } catch (error) {
            console.error("Login error:", error);
            if (error.response) {
                setMessage(error.response.data.message || 'Login failed');
            } else {
                setMessage('ארעה שגיאה, אנא נסה שנית');
            }
        }
    };
    return (
        <div>
            <form onSubmit={handleSubmit}>
                <input
                    type="text"
                    placeholder="Username"
                    value={username}
                    onChange={(e) => setUsername(e.target.value)}
                    required
                />
                <input
                    type="password"
                    placeholder="Password"
                    value={password}
                    onChange={(e) => setPassword(e.target.value)}
                    required
                />
                <button type="submit">Login</button>
            </form>
            {message && <p>{message}</p>}
        </div>
    );
};
export default Login;