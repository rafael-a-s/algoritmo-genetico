public class Professor
{

  public int Id { get; set; }
  public string? Name { get; set; }
  public List<Disciplina>? Disciplina { get; set; }
  public string Dia { get; set; }

  public Professor(int id, string? name, List<Disciplina>? disciplina, string dia)
  {
    Id = id;
    Name = name;
    Disciplina = disciplina;
    Dia = dia;
  }

}