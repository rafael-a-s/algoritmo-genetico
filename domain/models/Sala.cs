public class Sala
{
  public int Id { get; set; } //será o numero da sala
  public string? Name { get; set; }

  public Sala(int id, string? name)
  {
    Id = id;
    Name = name;
  }

}