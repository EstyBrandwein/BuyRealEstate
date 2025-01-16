import { useEffect, useState } from "react";

function FileListViewer() {
  const [files, setFiles] = useState([]);

  useEffect(() => {
    const fetchFiles = async () => {
      try {
        const response = await fetch("https://localhost:7219/api/Document");
        if (!response.ok) {
          throw new Error(`Error fetching files: ${response.statusText}`);
        }
        const data = await response.json();
        console.log("Fetched Files:", data); // Log the response
        const processedFiles = data.map(file => {
          const base64Content = file.DocumentData; // Adjusted to match the DTO
          const blob = base64Content
            ? new Blob([Uint8Array.from(atob(base64Content), char => char.charCodeAt(0))], { type: "application/pdf" })
            : null;
    
          return {
            name: file.DocumentDescription || "Unnamed File",
            thumbnail: blob ? URL.createObjectURL(blob) : null,
            fullView: blob ? URL.createObjectURL(blob) : null,
          };
        });
    
        setFiles(processedFiles);
      } catch (error) {
        console.error("Error:", error.message);
        alert("Failed to load files.");
      }
    };
    

    fetchFiles();
  }, []);

  return (
    <div>
      <h1>רשימת קבצים</h1>
      <div style={{ display: "flex", flexWrap: "wrap", gap: "20px" }}>
        {files.map((file, index) => (
          <div
            key={index}
            style={{
              border: "1px solid #ddd",
              borderRadius: "5px",
              padding: "10px",
              width: "200px",
              textAlign: "center",
            }}
          >
            <h3 style={{ fontSize: "16px", margin: "10px 0" }}>{file.DocumentDescription}</h3>
            <iframe
              src={file.thumbnail}
              width="100%"
              height="150px"
              title={`Thumbnail for ${file.DocumentDescription}`}
            ></iframe>
            <button
              onClick={() => window.open(file.fullView, "_blank")}
              style={{
                marginTop: "10px",
                padding: "5px 10px",
                backgroundColor: "#007bff",
                color: "#fff",
                border: "none",
                borderRadius: "5px",
                cursor: "pointer",
              }}
            >
              צפה בקובץ
            </button>
          </div>
        ))}
      </div>
    </div>
  );
}

export default FileListViewer;
