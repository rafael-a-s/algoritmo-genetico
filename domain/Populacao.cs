public class Populacao
{
  public List<Individuo> populacao = new List<Individuo>();

  //mock de dados desejados, vai ser usado para calcular o score
  //que vai ser usado para calcular o fitness
  private List<int> mock = new List<int>();

  public Populacao(){}
  //Construtor da classe populacao
  public Populacao(List<int> mock, List<int>? cromossomo)
  {
    this.mock = mock;
    //inicia um array com tamanho definido na constant
    int i;
    for (i = 0; i < Constants.sizePopulacao; i++)
    {
      if(i == 0 && cromossomo != null && cromossomo.Count > 0 ) {
        var evolucao = new Individuo(cromossomo);
        evolucao.Score = calculaScore(evolucao);
        populacao.Add(evolucao);
        i++;
      }
      var individuo = new Individuo();
      individuo.Score = calculaScore(individuo);
      populacao.Add(individuo);
    }
    
    //Alaviação da populacao 
    calcularFitness();
    calcularFitnessPercent();
  }

  int calculaScore(Individuo individuo) {
    
    return individuo.cromossomo.Zip(mock, (x,y) => x == y ? 1 : 0).Count(res => res == 1);
  }

  public void calcularFitness()
  {
    int i;
    for (i = 0; i < Constants.sizePopulacao; i++)
    {
      //Para calcular, aplique o valor inteiro do individuo na função de aptidao
      this.populacao[i].setFitness(Constants.function1(this.populacao[i].getInt()));
    }
  }

  public void calcularFitnessPercent()
  {
    double somatoriaFitness = 0;

    //Somatoria de todos os valores de aptidao
    for (int i = 0; i < Constants.sizePopulacao; i++)
    {
      somatoriaFitness += populacao[i].getFitness();
    }

    for (int i = 0; i < Constants.sizePopulacao; i++)
    {
      populacao[i].setFitnessPercent((populacao[i].getFitness() * 100) / somatoriaFitness);
    }
  }

  public void atuazarValores()
  {
    //CalcularFitness
    calcularFitness();

    //CalcularFitnessPercent;
    calcularFitnessPercent();
  }

  public double getMediaPopulacao()
  {
    double sum = 0;
    foreach (Individuo ind in populacao)
    {
      sum += ind.Score; //media pelo score
    }

    return sum / Constants.sizePopulacao;
  }


  //Metodo para ordenar a populacao
  public void OrdenarPopulacao()
  {
    Individuo aux = new Individuo();

    for (int i = 0; i < Constants.sizePopulacao; i++)
    {
      for (int j = 0; j < Constants.sizePopulacao; j++)
      {
        if (populacao[i].getFitnessPercent() < populacao[j].getFitnessPercent())
        {
          aux = populacao[i];
          populacao[i] = populacao[j];
          populacao[j] = aux;
        }
      }
    }
  }

  public void printPop()
  {

    for (int i = 0; i < Constants.sizePopulacao; i++)
    {
      string result = string.Empty;
      result = result + populacao[i].PrintIndividuo() + "    |    "
                      + populacao[i].getInt() + "    |    "
                      + populacao[i].getFitness().ToString() + "    |    "
                      + populacao[i].getFitnessPercent().ToString() + "    |    ";
      Console.WriteLine(result);
    }
  }



}
