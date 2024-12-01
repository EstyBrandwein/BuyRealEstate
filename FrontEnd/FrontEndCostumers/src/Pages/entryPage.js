import React, { useState } from 'react';
import Button from '@mui/material/Button';
import Dialog from '@mui/material/Dialog';
import DialogActions from '@mui/material/DialogActions';
import DialogContent from '@mui/material/DialogContent';
import DialogTitle from '@mui/material/DialogTitle';
import Register from './Register';
import Login from './Login';
function EntryPage() {
    const [openLogin, setOpenLogin] = useState(false);
    const [openRegister, setOpenRegister] = useState(false);
    const handleLogin = () => {
        setOpenLogin(true);
    };
    const handleRegister = () => {
        setOpenRegister(true);
    };
    const handleClose = () => {
        setOpenLogin(false);
    };
    const handleConfirm = () => {
        setOpenRegister(false);
    }
    return (
        <div>
            <Button sx={{ width: '200px', height: '50px', margin: '10px', display: 'block' }} variant="contained" onClick={handleLogin}>כניסה</Button>
            <Dialog open={openLogin} onClose={handleClose}>
                <DialogTitle>כניסה</DialogTitle>
                <DialogContent>
                    <Login />
                </DialogContent>
                <DialogActions>
                    <Button onClick={handleClose} color="primary">ביטול</Button>
                </DialogActions>
            </Dialog>
            <Button sx={{ width: '200px', height: '50px', margin: '10px', display: 'block' }} variant="contained" onClick={handleRegister}>הרשמה</Button>
            <Dialog open={openRegister} onClose={handleConfirm}>
                <DialogTitle>הרשמה</DialogTitle>
                <DialogContent>
                    <Register />
                </DialogContent>
                <DialogActions>
                <Button onClick={handleConfirm} color="primary" variant="contained">אישור</Button>
                </DialogActions>
            </Dialog>
        </div>
    );
}
export default EntryPage;