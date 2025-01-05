import React from 'react';
import { BrowserRouter as Router, Routes, Route } from 'react-router-dom';
import Sidebar from './Pages/sideBarPage';
import MyFields from './Pages/myFeiledPage';
import EditProfile from './Pages/editProfilePage';
import Login from './Pages/homePage';
import MainPage from './Pages/mainPage';
import EntryPage from './Pages/entryPage';
import DetailsPage from './Pages/myFeiledPage';
import PaymentPage from './Pages/paymentsPage';
import GrossProfitPage from './Pages/profitCalculations';
import PlotsPage from './Pages/realEstateDetails';
function App() {
  const handleLogout = () => {
    // פונקציה להתנתקות
  };

  return (
    <Router>
      <div className="app">
        <Routes>
          <Route exact path="/" element={<EntryPage/>} />  
          <Route path="/mainPage" element={<MainPage />} />
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
