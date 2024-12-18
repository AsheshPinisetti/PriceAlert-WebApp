using System.ComponentModel.DataAnnotations.Schema;

namespace AuthApi.Model
{
    public class User
    {
        public int userId { get; set; }
        [Column("First Name")]
        public required string FirstName { get; set; }
        [Column("Middle Name")]
        public string? MiddleName { get; set; }
        [Column("Last Name")]
        public required string LastName { get; set; }
        public required string Email { get; set; }
        public required string Username { get; set; }
        public required string Password { get; set; }

    }
}
