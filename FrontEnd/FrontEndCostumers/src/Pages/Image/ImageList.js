import React, { useEffect, useState } from "react";
import axios from "axios";
import "./ImageList.css";

const ImageList = ({ projectId }) => {
  const [images, setImages] = useState([]);
  const [error, setError] = useState(null);

  useEffect(() => {
    const fetchImages = async () => {
      if (!projectId) {
        setError("Project ID is not defined");
        return;
      }
      try {
        const response = await axios.get(
          `https://localhost:7219/api/Images/project/${projectId}`
        );
        if (Array.isArray(response.data)) {
          setImages(response.data);
        } else {
          setError("Data format error: Images data is not an array");
        }
      } catch (err) {
        console.error("Error fetching images:", err);
        setError("Failed to fetch images");
      }
    };
    fetchImages();
  }, [projectId]);

  if (error)
    return <div className="error-message">Error: {error}</div>;

  return (
    <div className="image-list-container">
      <div className="image-grid">
        {images.length > 0 ? (
          images.map((image) => (
            <div key={image.id} className="image-card">
              <img
                src={`data:${image.fileType};base64,${image.imageData}`}
                alt={image.imageDescription}
                className="image"
              />
              <div className="image-description">{image.imageDescription}</div>
            </div>
          ))
        ) : (
          <p className="no-images">No images found</p>
        )}
      </div>
    </div>
  );
};

export default ImageList;
