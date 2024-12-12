namespace chatty.Models
{
    public class Message
    {
        public int Id { get; set; }
        public string? Content {  get; set; }
        public DateTime? Timestemp { get; set; }
        public ApplicationUser? Fromuser { get; set; }
        public Room? Room { get; set; }
        public int Roomid {  get; set; }

    }
}
