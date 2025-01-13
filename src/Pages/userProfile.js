import React from 'react';
import { Card, CardContent, Typography, Grid } from '@mui/material';

const UserProfile = ({ user }) => {
  return (
    <Card>
      <CardContent>
        <Typography variant="h5" gutterBottom>
          {`בוקר טוב, ${user.name}`}
        </Typography>
        <Grid container spacing={2}>
          <Grid item xs={6}>
            <Typography>ת.ז: {user.id}</Typography>
            <Typography>כתובת: {user.address}</Typography>
            <Typography>מספר חוזה: {user.contractNumber}</Typography>
          </Grid>
          <Grid item xs={6}>
            <Typography>טלפון: {user.phone}</Typography>
            <Typography>דוא"ל: {user.email}</Typography>
          </Grid>
          <Grid item xs={6}>
            <Typography>מבנה: {user.building}</Typography>
            <Typography>קומה: {user.floor}</Typography>
          </Grid>
          <Grid item xs={6}>
            <Typography>דירה: {user.apartment}</Typography>
            <Typography>חדרים: {user.rooms}</Typography>
          </Grid>
        </Grid>
      </CardContent>
    </Card>
  );
};

export default UserProfile;
