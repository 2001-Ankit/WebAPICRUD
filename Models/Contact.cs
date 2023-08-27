namespace WebApplication1.Models
{
    public class Contact
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }

        public bool IsAdmin { get; set; }
    }
}
