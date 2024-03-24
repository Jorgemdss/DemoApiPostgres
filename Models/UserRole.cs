using System.ComponentModel.DataAnnotations.Schema;

namespace DemoApp.Models;

[Table("UserRole")]
public class UserRole
{

    public int UserId { get; set; }
    public int RoleId { get; set; }

}
