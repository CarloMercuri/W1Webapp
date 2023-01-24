namespace W1Webapp.Data
{
    public class ImageProperty
    {
        public string Name { get; set; }
        public string Extension { get; set; }
        public string Type { get; set; }
        public string Dimensions { get; set; }
        public long Size { get; set; }
        public string OriginalAddress { get; set; }
        public Guid Guid { get; set; }
    }
}
