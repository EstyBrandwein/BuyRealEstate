import React from 'react';
import Button from '@mui/material/Button'; 
import TextField from '@mui/material/TextField';

function Register() {
    const handleRegisterSubmit = () => {
        // Add registration logic here
    };

    return (
        <div>
            <TextField label="שם משתמש" fullWidth />
            <TextField type="email" label="אימייל" fullWidth />
            <TextField type="password" label="סיסמה" fullWidth />
            <Button onClick={handleRegisterSubmit} color="primary" variant="contained">הרשמה</Button>
        </div>
    );
}

export default Register;