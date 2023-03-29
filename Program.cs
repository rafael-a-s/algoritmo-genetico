class Program
{
  static void Main(string[] args)
  {
    AlgoritmoGenetico alg = new AlgoritmoGenetico();
    List<int> grade = alg.init();

    List<Professor> professores = new List<Professor>(){
      new Professor(1, "Janio",
        new List<Disciplina>{
          new Disciplina(1, "Topicos", new Sala(1, "Labin I"))}, ""),

      new Professor(2, "Tamirys",
        new List<Disciplina>{
          new Disciplina(2, "Inteligencia Artificial", new Sala(2, "Labin II"))}, ""),

      new Professor(5, "Carlos",
        new List<Disciplina>{
          new Disciplina(5, "BD2", new Sala(5, "Labin IV"))}, ""),

      new Professor(4, "Silvano",
          new List<Disciplina>{
          new Disciplina(4, "BD2", new Sala(4, "sala4"))}, ""),

      new Professor(3, "Silvano",
            new List<Disciplina>{
          new Disciplina(3, "BD2", new Sala(3, "sala 2"))}, "")
    };

    for (int i = 0; i < professores.Count; i++)
    {
      if(grade[i] == 2){
        professores[i].Dia = "Segunda";
      }
      if(grade[i] == 3){
        professores[i].Dia = "Terça";
      }
      if(grade[i] == 4){
        professores[i].Dia = "Quarta";
      }
      if(grade[i] == 5){
        professores[i].Dia = "Quinta";
      }
      if(grade[i] == 6){
        professores[i].Dia = "Sexta";
      }
    }
    Console.WriteLine("========== Grade 6º, 1 Aula por dia ===========");
    for (int i = 0; i < professores.Count; i++)
    {
      Console.WriteLine("Professor - "+professores[i].Name + "\n Disciplina - "+ professores[i].Disciplina[0].Name+" \n Sala - "+ professores[i].Disciplina[0].Sala.Name+ "\n Dia - "+ professores[i].Dia);
       Console.WriteLine("===========================");
    }
  }

}