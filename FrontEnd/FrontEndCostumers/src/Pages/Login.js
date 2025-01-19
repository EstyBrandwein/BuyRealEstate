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
            const response = await axios.post('http://localhost:5145/api/user/login', {
                username,
                password
            });

            // אם הבקשה הצליחה, ננווט לדף הראשי
            if (response.status === 200) {
                // console.log(response.data);
                // navigate('/mainPage');
                navigate('/VerifyPage', { state: { userId: response.data.userId } });
            }
        } catch (error) {
            // טיפול בשגיאות
            if (error.response) {
                setMessage(error.response.data.message || 'Login failed');
            } else {
                setMessage('An error occurred. Please try again.');
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
