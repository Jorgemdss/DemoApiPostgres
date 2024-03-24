namespace DemoApp.Models;

public class Role
{

    public int Id { get; set; }

    public required string Name { get; set; }

    public virtual ICollection<User> Users { get; set; } = [];

}
