import React from 'react';
import { BrowserRouter as Router, Routes, Route } from 'react-router-dom';
import Login from './Pages/Login';
import MainPage from './Pages/mainPage';
import PlotsPage from './Pages/realEstateDetails';
import VerificationPage from './Pages/VerifyPage';
import FileListViewer from './Pages/Document/Document';
import MainListPlots from './Pages/ListPlots/MainListPlots';
import Contact from './Pages/PlotDetiels/Contact';



function App() {
 
  return (
    <Router>
      <div className="app">
        <Routes>
        <Route path="/" element={<Login />} />
        <Route path="/MainListPlots" element={<MainListPlots />} />
        <Route path="/contact" element={<Contact />} />
        <Route path="/VerifyPage" element={<VerificationPage />} />

        {/* <Route path="/UploadImage" element={<UploadImage />} /> */}
        <Route path="/PlotsPage/:id" element={<PlotsPage/>} />
        <Route exact path="/PDFViewer" element={<FileListViewer/>} />
        <Route path="/mainPage" element={<MainPage />} />
        </Routes>
      </div>
    </Router>
  );
}

export default App;
