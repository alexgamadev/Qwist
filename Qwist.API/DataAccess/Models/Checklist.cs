namespace Qwist.API.DataAccess.Models;

public class Checklist
{
    public Guid Id { get; set; }
    public string Name { get; set; } = String.Empty;
    public Guid CreatorId { get; set; }
    public List<bool> Items { get; set; } = new List<bool>();
}
