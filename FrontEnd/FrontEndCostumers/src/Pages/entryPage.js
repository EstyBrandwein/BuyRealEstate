import React, { useState } from 'react';
import Button from '@mui/material/Button';
import Dialog from '@mui/material/Dialog';
import DialogActions from '@mui/material/DialogActions';
import DialogContent from '@mui/material/DialogContent';
import DialogTitle from '@mui/material/DialogTitle';
import Login from './Login';

function EntryPage() {
    const [openLogin, setOpenLogin] = useState(false);
    const handleLogin = () => {
        setOpenLogin(true);
    };

    const handleClose = () => {
        setOpenLogin(false);
    };

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

        </div>
    );
}
export default EntryPage;