import React from 'react';
import Sidebar from './sideBarPage';

function MyFields() {
  const handleLogout = () => {
    // פונקציה להתנתקות
  };

  return (
    <div className="my-fields-page">
      <Sidebar username="User123" email="user123@example.com" onLogout={() => handleLogout()} />
      <h1>עמוד המגרשים</h1>
      <p>כאן יוצג רשימת המגרשים שלך</p>
      {/* ניתן להוסיף קוד נוסף להצגת המגרשים */}
    </div>
  );
}

export default MyFields;
