using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace RenanIkedaFernandes_d7_avaliacao.Model;

[Table("Users")]
public class User
{
    public User()
    {

    }
    public User(string Name, string Password)
    {
        this.Name = Name;
        this.Password = Password;
    }

    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public uint Id { get; set; }

    [Column(TypeName = "VARCHAR(150)")]
    public string Name { get; set; } = Guid.NewGuid().ToString();

    [Column(TypeName = "VARCHAR(150)")]
    public string Password { get; set; } = string.Empty;

}

