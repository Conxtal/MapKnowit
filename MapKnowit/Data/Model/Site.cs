namespace MapIt.Data.Model
{
    public class Site
    {
        public int SiteID { get; set; }

        public string? SiteName { get; set; }

        public float Latitude { get; set; }

        public float Longitude { get; set; }

        public string? Area { get; set; }

        public string? Country { get; set; }
        
        public float? Rent { get; set; }
    }
}
