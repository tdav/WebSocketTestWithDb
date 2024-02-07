namespace App.Repository.Models
{
    public class viChangeRole
    {
        public Guid UserId { get; set; }
        public List<string> RoleNames { get; set; } = new();
    }
}
