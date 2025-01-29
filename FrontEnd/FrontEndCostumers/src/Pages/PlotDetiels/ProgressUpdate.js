// ProgressUpdate.js
import React from 'react';
import './ProgressUpdate.css';

const ProgressUpdate = () => {
  return (
    <div className="container">
      <h1 className="title">אז מה התקדם עם תכנון מגרשכם?</h1>
      <p className="paragraph">
        בחודש שחלף, הסקיצות כולן עברו דיוקים, פינישים ועדכונים עד לסגירת סקיצה אחידה וסופית,
        אשר נשלחה לאישור חברי הנציגות.
      </p>

      <h2 className="subtitle">דגשים בפינישים</h2>
      <p className="paragraph">
        בפינישים שמנו דגש על סגירות החלוקה הפנימית, כל אחד בהתאם לתנאי המגרש שלו, וסגירת סקיצות אופן
        הנחת הבית. כמובן, יש להתחשב בכך שעל חזיתות המבנים להיות אחידים מאחר ומדובר במתחם.
      </p>
      <p className="paragraph">
        בנוסף, התחלנו עבודה על תכנון השפ"פ (שטח פרטי פתוח) מול יועץ פיתוח לצורך הכנת הגרמושקא.
      </p>

      <h2 className="subtitle">שאלות ותשובות</h2>
      <p className="paragraph">
        לאלו מכם שהיו שאלות, נשלחו תשובות באופן פרטי. ואנו שמחים כי ב"ה אפשר להתקדם.
      </p>

      <h2 className="subtitle">צפי שלב הבא</h2>
      <p className="paragraph">
        לאחר אישור הנציגות לסקיצה הסופית, נתקדם להכנת גרמושקא לקראת העלאה לאישור הוועדה.
      </p>

      <h2 className="subtitle">צפי תשלומים</h2>
      <p className="paragraph">
        <strong>חברת אודם:</strong> אין צפי תשלומים קרובים.
      </p>
      <p className="paragraph">
        <strong>תשלומים חיצוניים:</strong> אין צפי תשלומים קרובים.
      </p>
    </div>
  );
};

export default ProgressUpdate;
