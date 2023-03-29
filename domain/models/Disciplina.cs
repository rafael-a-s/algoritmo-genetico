public class Disciplina
{
  public int Id { get; set; }
  public string? Name { get; set; }
  public Sala? Sala { get; set; }

  public Disciplina(int id, string? name, Sala sala)
  {
    Id = id;
    Name = name;
    Sala = sala;
  }
}