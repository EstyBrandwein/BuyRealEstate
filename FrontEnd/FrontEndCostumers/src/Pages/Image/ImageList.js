import React, { useEffect, useState } from "react";
import axios from "axios";

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
        const response = await axios.get(`https://localhost:7219/api/Images/project/${projectId}`);
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

  if (error) return <div>Error: {error}</div>;

  return (
    <div style={{ display: "flex", flexWrap: "wrap", gap: "10px" }}>
      {images.length > 0 ? (
        images.map((image) => (
          <div key={image.id} style={{ flex: "0 0 auto" }}>
            <img
              src={`data:${image.fileType};base64,${image.imageData}`}
              alt={image.imageDescription}
              style={{ width: "200px", height: "auto" }}
            />
            <p>{image.imageDescription}</p>
          </div>
        ))
      ) : (
        <p>No images found</p>
      )}
    </div>
  );
};

export default ImageList;
