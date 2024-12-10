import React, { useState } from 'react';
import Button from '@mui/material/Button';
import TextField from '@mui/material/TextField';

function Login() {
    const [username, setUsername] = useState('');
    const [password, setPassword] = useState('');
    const [error, setError] = useState('');

    const handleLoginSubmit = async () => {
        try {
            const response = await fetch('https://your-api-url/api/customer/login', {
                method: 'POST',
                headers: {
                    'Content-Type': 'application/json',
                },
                body: JSON.stringify({ username, password }),
            });

            if (!response.ok) {
                throw new Error('Login failed');
            }

            const data = await response.json();
            // Handle successful login (e.g., save token, redirect, etc.)
            console.log(data);
        } catch (error) {
            setError(error.message);
        }
    };

    return (
        <div>
            <TextField 
                label="שם משתמש" 
                fullWidth 
                value={username} 
                onChange={(e) => setUsername(e.target.value)} 
            />
            <TextField 
                type="password" 
                label="סיסמה" 
                fullWidth 
                value={password} 
                onChange={(e) => setPassword(e.target.value)} 
            />
            {error && <div style={{ color: 'red' }}>{error}</div>}
            <Button onClick={handleLoginSubmit} color="primary" variant="contained">אישור</Button>
        </div>
    );
}

export default Login;
