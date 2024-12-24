import React, { useEffect, useState } from 'react';
import { NavLink } from 'react-router-dom';
import { fetchUserData } from '../services/api';

function Header() {
  const [user, setUser] = useState(null);

  useEffect(() => {
    async function loadUserData() {
      const data = await fetchUserData();
      setUser(data);
    }
    loadUserData();
  }, []);

  if (!user) return <p>Loading...</p>;

  return (
    <header className="d-flex justify-content-between align-items-center p-3 bg-light border-bottom">
      <div>
        <img src="/logo.png" alt="Logo" height="40" />
      </div>
      <div>
        <strong>{user.name}</strong> <br />
        <span>{user.email}</span>
      </div>
      <nav>
        <ul className="nav">
          <li className="nav-item">
            <NavLink className="nav-link" to="/my-plots">המגרשים שלי</NavLink>
          </li>
          <li className="nav-item">
            <NavLink className="nav-link" to="/edit-profile">עריכת פרופיל</NavLink>
          </li>
          <li className="nav-item">
            <NavLink className="nav-link" to="/contact">צור קשר</NavLink>
          </li>
          <li className="nav-item">
            <button className="btn btn-link nav-link" onClick={() => console.log('Logout')}>התנתקות</button>
          </li>
        </ul>
      </nav>
    </header>
  );
}

export default Header;
