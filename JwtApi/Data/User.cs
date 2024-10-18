namespace JwtApi.Data;

public class User
{
    public int Id { get; set; }
    public string Name { get; set; }

    public int Age { get; set; }

    public DateTime CreatedTime { get; set; } = DateTime.UtcNow;

    public int? RoleId { get; set; }
    public Role? Role { get; set; }
}
