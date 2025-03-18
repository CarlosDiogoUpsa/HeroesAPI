namespace HeroesAPI.Models;

public class Hero
{
    public int Id { get; set; }
    public string FirstName { get; set; } = null!;
    public string LastName { get; set; } = null!;
    public string HeroName { get; set; } = null!;
}