// import React from "react";
// import { Link } from "react-router-dom";

// const Sidebar = ({ username, email, onLogout }) => {
//   const handleLogout = () => {
//     // פונקציה לניקוי עוגיות ועדכון ההקשר של המשתמש
//     onLogout();
//   };

//   return (
//     <nav className="navbar">
//       <ul>
//         <li>
//           <Link to="/my-fields">השדות שלי</Link>
//         </li>
//         <li>
//           <Link to="/edit-profile">ערוך פרופיל</Link>
//         </li>
//         <li>
//           <button onClick={handleLogout}>התנתק</button>
//         </li>
//       </ul>
//     </nav>
//   );
// };
// export default Sidebar;
import React, { useState } from 'react';
import { Link } from 'react-router-dom';
import Sidebar from 'react-sidebar';

const MySidebar = ({ username, email, onLogout }) => {
  const [sidebarOpen, setSidebarOpen] = useState(false);

  const handleLogout = () => {
    onLogout();
  };

  return (
    <Sidebar
      sidebar={
        <ul>
          <li>
            <Link to="/my-fields">השדות שלי</Link>
          </li>
          <li>
            <Link to="/edit-profile">ערוך פרופיל</Link>
          </li>
          <li>
            <button onClick={handleLogout}>התנתק</button>
          </li>
        </ul>
      }
      open={sidebarOpen}
      onSetOpen={setSidebarOpen}
      styles={{ sidebar: { background: 'white', width: '250px' } }}
    >
      <button onClick={() => setSidebarOpen(true)}>פתח תפריט</button>
    </Sidebar>
  );
};

export default MySidebar;
