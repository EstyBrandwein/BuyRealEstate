import React, { useState } from 'react';

function Contact() {
  const [formData, setFormData] = useState({
    name: '',
    idNumber: '',
    primaryPhone: '',
    secondaryPhone: '',
    email: '',
  });

  const handleChange = (e) => {
    setFormData({
      ...formData,
      [e.target.name]: e.target.value,
    });
  };

  const handleSubmit = (e) => {
    e.preventDefault();
    console.log('Form Submitted:', formData);
  };

  return (
    <form onSubmit={handleSubmit}>
      <h2>צור קשר</h2>
      <div className="mb-3">
        <label>שם הרוכש</label>
        <input
          name="name"
          type="text"
          className="form-control"
          value={formData.name}
          onChange={handleChange}
        />
      </div>
      <div className="mb-3">
        <label>ת.ז</label>
        <input
          name="idNumber"
          type="text"
          className="form-control"
          value={formData.idNumber}
          onChange={handleChange}
        />
      </div>
      <div className="mb-3">
        <label>טלפון רשאי</label>
        <input
          name="primaryPhone"
          type="text"
          className="form-control"
          value={formData.primaryPhone}
          onChange={handleChange}
        />
      </div>
      <div className="mb-3">
        <label>טלפון משני</label>
        <input
          name="secondaryPhone"
          type="text"
          className="form-control"
          value={formData.secondaryPhone}
          onChange={handleChange}
        />
      </div>
      <div className="mb-3">
        <label>דוא"ל</label>
        <input
          name="email"
          type="email"
          className="form-control"
          value={formData.email}
          onChange={handleChange}
        />
      </div>
      <button type="submit" className="btn btn-primary">שלח</button>
    </form>
  );
}

export default Contact;
