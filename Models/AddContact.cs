namespace WebApplication1.Models
{
    public class AddContactRequest
    {
        public string Name { get; set; }
        public string Email { get; set; }

        public bool IsAdmin { get; set; }        
    }
}
