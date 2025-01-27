import React from "react";
import "../CSS/Header.css";
import logo from "../Img/LogoLiknotNadlan.png"; // העלה את התמונה שלך לספרייה זו
import { FaUser, FaPhone, FaSignOutAlt } from "react-icons/fa"; // ספריית איקונים
import { Link } from "react-router-dom"; // ייבוא Link עבור ניווט

const Header = () => {
  return (
    <div className="header-container">
      <div className="header-right">
        <img src={logo} alt="לוגו החברה" className="header-logo" />
      </div>
      <div className="header-left">
     
        <Link to="/UpdateProfile" className="header-icon-button" title="פרופיל שלי">
          <FaUser className="header-icon" />
        </Link>
        <Link to="/contact" className="header-icon-button" title="צור קשר">
          <FaPhone className="header-icon" />
        </Link>
        <Link to="/" className="header-icon-button" title="התנתק">
          <FaSignOutAlt className="header-icon" />
        </Link>
      </div>
    </div>
  );
};

export default Header;
