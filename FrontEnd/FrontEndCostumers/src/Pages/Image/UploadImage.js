import React, { useState } from "react";
import axios from "axios";

const UploadImage = ({ projectId }) => {
  const [file, setFile] = useState(null);
  const [description, setDescription] = useState("");

  const handleFileChange = (e) => {
    setFile(e.target.files[0]);
  };

  const handleUpload = async () => {
    if (!file) {
      alert("Please select a file first!");
      return;
    }

    const formData = new FormData();
    formData.append("file", file);
    formData.append("description", description);
    formData.append("projectId", projectId);

    try {
      const response = await axios.post("/api/images", formData, {
        headers: { "Content-Type": "multipart/form-data" },
      });
      console.log("Uploaded:", response.data);
    } catch (err) {
      console.error("Error uploading file:", err);
    }
  };

  return (
    <div>
      <input type="file" onChange={handleFileChange} />
      <input
        type="text"
        placeholder="Description"
        value={description}
        onChange={(e) => setDescription(e.target.value)}
      />
      <button onClick={handleUpload}>Upload</button>
    </div>
  );
};

export default UploadImage;
