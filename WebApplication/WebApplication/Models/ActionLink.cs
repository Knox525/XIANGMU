namespace WebApplication1.Models
{
    public class ActionLink
    {
        public string Name { get; set; }
        public string Controller { get; set; }

        public string Action { get; set; }
        public int Id { get; internal set; }
    }
}