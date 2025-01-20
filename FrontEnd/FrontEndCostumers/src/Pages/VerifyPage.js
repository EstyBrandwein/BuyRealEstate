import React, { useState } from 'react';
import axios from 'axios';

const VerificationPage = ({ userId }) => {
    const [code, setCode] = useState('');
    const [message, setMessage] = useState('');

    const handleVerification = async (e) => {
        e.preventDefault();
        try {
            const response = await axios.post('http://localhost:5145/api/user/verify', {
                userId,
                code,
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
        <div>
            <h2>Enter Verification Code</h2>
            <form onSubmit={handleVerification}>
                <input
                    type="text"
                    placeholder="Verification Code"
                    value={code}
                    onChange={(e) => setCode(e.target.value)}
                    required
                />
                <button type="submit">Verify</button>
            </form>
            {message && <p>{message}</p>}
        </div>
    );
};

export default VerificationPage;
