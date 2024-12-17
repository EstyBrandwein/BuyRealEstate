namespace BuyRealEstate.Domain.Models
{
    public class Image : BaseClass
    {
        public int ID { get; set; }
        public string ImageDescription { get; set; }
        public byte[] ImageData { get; set; }
        public int ProjectID { get; set; } // Foreign Key to Project
        public Project? Project { get; set; }
        // Navigation property to relate to Project
        public string FileType { get; set; }

    }
}
