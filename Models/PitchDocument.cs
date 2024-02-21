namespace GoogleAuthDemo.Models
{
    public class PitchDocument
    {

        public int Id { get; set; }

        public string FileName { get; set; }

        public string FileURL { get; set; }

        public PitchDocument(int id, string fileName, string fileURL)
        {
            Id = id;
            FileName = fileName;
            FileURL = fileURL;
        }
    }
}
