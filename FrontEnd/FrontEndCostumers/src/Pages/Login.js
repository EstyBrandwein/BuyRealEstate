import React from 'react';
import Button from '@mui/material/Button'; 
import TextField from '@mui/material/TextField';

function Login() {
    const handleLoginSubmit = () => {
        // Add login logic here
    };

    return (
        <div>
            <TextField label="שם משתמש" fullWidth />
            <TextField type="password" label="סיסמה" fullWidth />
            <Button onClick={handleLoginSubmit} color="primary" variant="contained">אישור</Button>
        </div>
    );
}

export default Login;