
namespace TieMention.Domain.Entities;

public class Mention
{
    public Guid Id { get; set; }
    public string Name { get; set; } = default!;
    // public Guid CategoryId { get; set; }
    public Category Category { get; set; } = default!;

}
