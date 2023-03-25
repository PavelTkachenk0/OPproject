namespace TestWebApp.Models;

public class UserModel
{
    public string Id { get; set; } = Guid.NewGuid().ToString();
    public string? Name { get; set; }
    public string? SurName { get; set; }

    public string? MiddleName { get; set; }

    public string? Number { get; set; }

    public string? SNILS { get; set; }

}