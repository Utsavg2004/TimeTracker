namespace abc.Models
{
    public class TimeEntry
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public DateTime CheckIn { get; set;}

        public DateTime? CheckOut { get; set; }

        public double? TotalHours { get; set; }
    }
}
