import React from 'react';
import { BrowserRouter as Router, Routes, Route } from 'react-router-dom';
//import Sidebar from './Pages/sideBarPage';
import Login from './Pages/Login';

import MainPage from './Pages/MainPage';
import PlotsPage from './Pages/PlotsPage';
import FileListViewer from './Pages/Documents/Document';
import MainListPlots from './Pages/ListPlots/MainListPlots';
import UploadImage from './Pages/Image/UploadImage';
function App() {

  return (
    <Router>
      <div className="app">
        <Routes>
          <Route exact path="/" element={<Login/>} /> 
          {/* <Route exact path="/" element={<EntryPage/>} />   */}
          <Route path="/mainPage" element={<MainPage />} />
          <Route path="/VerifyPage" element={<VerificationPage />} />
          {/* <Route path="/login" element={<Login />} /> */}
          {/* <Route path="/my-fields" element={<MyFields />} />
          <Route path="/edit-profile" element={<EditProfile />} />
          <Route path="/my-fields" element={() => (
          <div>
            <Sidebar username="User123" email="user123@example.com" onLogout={handleLogout} />
            <MyFields />
          </div>
        )} /> */}

        <Route path="/" element={<MainListPlots />} />
        {/* <Route path="/UploadImage" element={<UploadImage />} /> */}
        <Route path="/PlotsPage/:id" element={<PlotsPage />} />
        <Route exact path="/PDFViewer" element={<FileListViewer/>} />  
        <Route path="/mainPage" element={<MainPage />} />
          <Route path="/login" element={<Login />} />          
        </Routes>
      </div>
    </Router>
  );
}

export default App;
