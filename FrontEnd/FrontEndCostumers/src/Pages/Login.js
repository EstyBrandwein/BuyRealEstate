// import React, { useState } from 'react';
// import Button from '@mui/material/Button';
// import TextField from '@mui/material/TextField';

// function Login() {
//     const [username, setUsername] = useState('');
//     const [password, setPassword] = useState('');
//     const [error, setError] = useState('');

//     const handleLoginSubmit = async () => {
//         try {
//             const response = await fetch('https://your-api-url/api/customer/login', {
//                 method: 'POST',
//                 headers: {
//                     'Content-Type': 'application/json',
//                 },
//                 body: JSON.stringify({ username, password }),
//             });

//             if (!response.ok) {
//                 throw new Error('Login failed');
//             }

//             const data = await response.json();
//             // Handle successful login (e.g., save token, redirect, etc.)
//             console.log(data);
//         } catch (error) {
//             setError(error.message);
//         }
//     }
// } export default Login;

import React, { useState } from 'react';
import { useNavigate } from 'react-router-dom';
import Button from '@mui/material/Button';
import TextField from '@mui/material/TextField';
import axios from 'axios';

function Login() {
    const [username, setUsername] = useState('');
    const [password, setPassword] = useState('');
    const [error, setError] = useState('');
    const navigate = useNavigate();

    const handleLoginSubmit = async (e) => {
        e.preventDefault(); // Prevent default form submission
        try {
            const response = await axios.post('https://localhost:7219/api/user/login', {
                Username : username,
                Password : password
            }, {
                headers: {
                    'Content-Type': 'application/json',
                },
            });

            if (response.status === 200) {
                // Handle successful login, e.g., navigate to the main page
                navigate('/mainPage');
            } else {
                // Handle unexpected response status
                setError('Unexpected response from the server.');
            }
        } catch (error) {
            if (error.response) {
                // The request was made, but the server responded with a status code
                // that falls out of the range of 2xx
                setError(error.response.data || 'An error occurred while logging in.');
            } else {
                // Something happened in setting up the request that triggered an Error
                setError('An error occurred while logging in.');
            }
        }
    }

    return (
        <form onSubmit={handleLoginSubmit}>
            <TextField
                label="Username"
                value={username}
                onChange={(e) => setUsername(e.target.value)}
                required
            />
            <TextField
                label="Password"
                type="password"
                value={password}
                onChange={(e) => setPassword(e.target.value)}
                required
            />
            {error && <p>{error}</p>} {/* Display error message if exists */}
            <Button type="submit">Login</Button>
        </form>
    );
}

export default Login;
