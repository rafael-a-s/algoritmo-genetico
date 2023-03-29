public class AlgoritmoGenetico
{
  static List<int> PAI = new List<int>();
  static List<int> MAE = new List<int>();
  public List<int> mock = new List<int> { 2, 3, 4, 5, 6 };
  static int cont = 0;

  public AlgoritmoGenetico(){}


  public List<int> init()
  {
    Populacao populacao = new Populacao();
    List<int> diasEscolhidos = new List<int>();

    for (int i = 0; i < Constants.geracao; i++)
    {
      Console.WriteLine("========== Geração "+ i +" ===========");
      populacao = new Populacao(mock, diasEscolhidos); //criando a populacao

      //escolher os 2 melhores
      populaPaiMae(populacao);

      //realiza cruzamento
      diasEscolhidos = cruzamento();
      populacao.printPop(); //print do populacao
      Console.Write("Filho "+i+ " Media "+populacao.getMediaPopulacao() +" Dias ");
      diasEscolhidos.ForEach((x) => Console.Write(x +" "));
      Console.WriteLine(" ");
      
      //populacao.populacao.ForEach((x) => Console.Write(x.Score)); //Printa a evolucao do Score
    }
    return diasEscolhidos;
  }

  void populaPaiMae(Populacao pop)
  {
    pop.populacao = pop.populacao.OrderByDescending((x) => x.Score).ToList(); //ordendando pelo maior score
    PAI = pop.populacao[0].cromossomo; //pega o primeiro
    MAE = pop.populacao[0].cromossomo; //pega o segundo
  }

  List<int> cruzamento()
  {
    List<int> diasEscolhidos = new List<int>();
    for (int i = 0; i < mock.Count; i++)
    {
      if (i <= 2)
      {
        diasEscolhidos.Add(PAI[i]);
      }
      else
      {
        diasEscolhidos.Add(MAE[i]);
      }
    }
    return diasEscolhidos;
  }

}