using System.ComponentModel.DataAnnotations.Schema;

namespace guidsOverTheWorld.Models
{
    public class Tours
    {
        private DateTime date;
        public int Id { get; set; }
        public int GuidId { get; set; }
        public DateTime Date 
        { 
            get { return date; }
            set { date = value.Date; } 
        }
        public int startTime
        {
            get { return date.Hour; }
            set { date = date.Date + TimeSpan.FromHours(value); }
        }
        public int endTime { get; set; }
    }
}
