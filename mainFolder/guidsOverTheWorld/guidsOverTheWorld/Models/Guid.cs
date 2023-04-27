namespace guidsOverTheWorld.Models
{
    public class Guid
    {
        public int GuidId { get; set; }
        public string fName { get; set; }
        public string lName { get; set; }
        public int price { get; set; }
        public string[] country { get; set; }
        public string[] city { get; set; }
        public string[] languages { get; set; }
        public string? description { get; set; }


    }
}
