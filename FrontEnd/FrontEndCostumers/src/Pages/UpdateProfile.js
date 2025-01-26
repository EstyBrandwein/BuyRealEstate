import React, { useEffect, useReducer, useState } from 'react';
import axios from 'axios';
import { useParams, useNavigate } from 'react-router-dom';
import '../CSS/UpdateProfile.css'; 

const initialState = {
    id: 0,
    username: '',
    password: '',
    firstName: '',
    lastName: '',
    email: '',
    firstPhone: '',
    secendPhon: '',
    permissionId: 0,
};

const reducer = (state, action) => {
    switch (action.type) {
        case 'SET_USER_DATA':
            return { ...state, ...action.payload };
        case 'UPDATE_FIELD':
            return { ...state, [action.field]: action.value };
        default:
            return state;
    }
};

const UpdateProfile = () => {
    const { id } = useParams();
    const navigate = useNavigate();
    const [userData, dispatch] = useReducer(reducer, initialState);
    const [message, setMessage] = useState('');

    useEffect(() => {
        const fetchUserData = async () => {
            const response = await axios.get(`https://localhost:7219/api/user/9`);
            dispatch({ type: 'SET_USER_DATA', payload: response.data });
        };
        fetchUserData();
    }, [id]);

    const handleChange = (e) => {
        const { name, value } = e.target;
        dispatch({ type: 'UPDATE_FIELD', field: name, value });
    };

    const validateInput = () => {
        const validations = [
            { condition: !userData.username, message: 'שם משתמש הוא שדה חובה' },
            { condition: userData.username.length < 3 || !/^[א-תa-zA-Z]+$/.test(userData.username), message: 'שם המשתמש חייב להיות באורך מינימלי של 3 תווים ולכלול רק אותיות בשפה אחת' },
            { condition: !userData.firstName || userData.firstName.length < 2 || !/^[א-תa-zA-Z]+$/.test(userData.firstName), message: 'שם פרטי חייב להיות באורך מינימלי של 2 תווים ולכלול רק אותיות בשפה אחת' },
            { condition: !userData.lastName || userData.lastName.length < 2 || !/^[א-תa-zA-Z]+$/.test(userData.lastName), message: 'שם משפחה חייב להיות באורך מינימלי של 2 תווים ולכלול רק אותיות בשפה אחת' },
            { condition: !userData.password || userData.password.length < 6, message: 'סיסמה חייבת להיות באורך מינימלי של 6 תווים' },
            { condition: !/^(?=.*[0-9])(?=.*[!@#$%^&*])/.test(userData.password), message: 'הסיסמה חייבת להכיל לפחות מספר אחד ותו מיוחד' },
            { condition: !userData.email || !userData.email.includes('@'), message: 'כתובת המייל אינה תקינה' },
            { condition: userData.firstPhone && (!/^\d+$/.test(userData.firstPhone) || userData.firstPhone.length < 7 || userData.firstPhone.length > 15), message: 'מספר טלפון 1 חייב להיות בין 7 ל-15 ספרות' },
            { condition: userData.secendPhon && (!/^\d+$/.test(userData.secendPhon) || userData.secendPhon.length < 7 || userData.secendPhon.length > 15), message: 'מספר טלפון 2 חייב להיות בין 7 ל-15 ספרות' },
        ];

        for (const validation of validations) {
            if (validation.condition) {
                setMessage(validation.message);
                return false;
            }
        }
        return true;
    };

    const handleSubmit = async (e) => {
        e.preventDefault();
        if (!validateInput()) return;

        try {
            await axios.put(`https://localhost:7219/api/user/9`, userData);
            window.alert('הפרופיל השתנה בהצלחה');
        } catch (error) {
            const errorMessage = 'נכשל בעדכון הפרופיל: ' + (error.response ? error.response.data : error.message);
            setMessage(errorMessage);
            window.alert(errorMessage);
        }
    };

    return (
        <div className="container">
            {message && <div className="message">{message}</div>}
            <h2>עדכון פרופיל</h2>
            <form onSubmit={handleSubmit}>
                {['username', 'password', 'firstName', 'lastName', 'email', 'firstPhone', 'secendPhon'].map((field) => (
                    <div key={field}>
                        <label>{field === 'secendPhon' ? 'מספר טלפון 2' : field === 'firstPhone' ? 'מספר טלפון 1' : field === 'firstName' ? 'שם פרטי' : field === 'lastName' ? 'שם משפחה' : field === 'email' ? 'כתובת מייל' : field.charAt(0).toUpperCase() + field.slice(1)}</label>
                        <input
                            type={field === 'password' ? 'password' : 'text'}
                            name={field}
                            value={userData[field] || ''}
                            onChange={handleChange}
                        />
                    </div>
                ))}
                <button type="submit">עדכון פרופיל</button>
            </form>
        </div>
    );
};

export default UpdateProfile;
