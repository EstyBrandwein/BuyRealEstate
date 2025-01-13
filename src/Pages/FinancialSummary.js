import React from 'react';
import { Table, TableBody, TableCell, TableContainer, TableHead, TableRow, Paper, Typography } from '@mui/material';

const FinancialSummary = ({ summary }) => {
  return (
    <TableContainer component={Paper}>
      <Typography variant="h6" align="center" gutterBottom>
        פירוט עלויות
      </Typography>
      <Table>
        <TableHead>
          <TableRow>
            <TableCell align="right">תיאור</TableCell>
            <TableCell align="right">ערך</TableCell>
          </TableRow>
        </TableHead>
        <TableBody>
          {summary.map((row, index) => (
            <TableRow key={index}>
              <TableCell align="right">{row.description}</TableCell>
              <TableCell align="right">{row.value}</TableCell>
            </TableRow>
          ))}
        </TableBody>
      </Table>
    </TableContainer>
  );
};

export default FinancialSummary;
