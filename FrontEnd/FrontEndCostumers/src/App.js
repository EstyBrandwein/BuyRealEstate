import React from 'react';
import { BrowserRouter as Router, Routes, Route } from 'react-router-dom';
import Sidebar from './Pages/sideBarPage';
import MyFields from './Pages/myFeiledPage';
import EditProfile from './Pages/EditProfile';
import Login from './Pages/homePage';
import MainPage from './Pages/mainPage';
import MyPlots from './Pages/MyPlots';
import Contact from './Pages/Contact';

function App() {
  const handleLogout = () => {
    // פונקציה להתנתקות
  };

  return (
    <Router>
      <div className="app">
        <Routes>
        <Route path="/my-plots" element={<MyPlots />} />
          <Route path="/contact" element={<Contact />} />
          <Route path="/edit-profile" element={<EditProfile />} />
          <Route path="/" element={<MainPage />} />
          <Route path="/login" element={<Login />} />
          <Route path="/my-fields" element={<MyFields />} />
          <Route path="/edit-profile" element={<EditProfile />} />
          <Route path="/my-fields" render={() => (
          <div>
            <Sidebar username="User123" email="user123@example.com" onLogout={handleLogout} />
            <MyFields />
          </div>
        )} />
        </Routes>
      </div>
    </Router>
  );
}

export default App;
