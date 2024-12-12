namespace chatty.Models
{
    public class Room
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public ApplicationUser Admin {  get; set; }
        public ICollection<Message> Messages { get; set; }
    }
}
