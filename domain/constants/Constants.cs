public abstract class Constants
{
  static public int sizeCromossomo = 5;                               //Tamanho do Individuo
  static public int sizePopulacao = 20;     
  static public int geracao = 10;                         //Tamanho da populaçao
  static public int functionXSize = (int)Math.Pow(2, sizeCromossomo); //Função como em 0 até 2 exponencial tamanho do cromossomo
  public static Random random = new Random((int)DateTime.Now.Ticks);  //Objeto randomico, gera numeros pelo clock do processado

  public static double function1(double x)
  {
    return (double)(100 + Math.Abs(x * Math.Sin(Math.Sqrt(Math.Abs(x)))));
  }


}