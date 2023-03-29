 public class Individuo
    {
        public List<int> cromossomo = new List<int>();//dias da semana segunda, terca ...
        public int Score {get; set;} //cada dia acertivo, recebe +1 ponto de score
        private double fitness;
        private double fitnessPercent;

        public Individuo(List<int> cromo)
        {
            this.cromossomo = cromo;
        }

        //Construtor da classe
        public Individuo()
        {
            //Instancia o cromossomo com a quantidade de bits informados na classe Constants
            this.cromossomo = new List<int>();

            int i;
            for (i = 0; i < Constants.sizeCromossomo; i++)
            {
                //Popula o cromossomo do dia que faz ref ao dia da semana
                //segunda - 2, terça - 3 ...
                this.cromossomo.Add(Constants.random.Next(0, 5) + 2); 
            }
        }

        public void mutarDia(int position, int dia)
        {
            if (position < cromossomo.Count)
            {
                cromossomo[position] = dia;
            }
        }

        public string PrintIndividuo()
        {
            var result ="Dias ";
            cromossomo.ForEach((x) => result += x+", ");
            return result += " Aptidão " + getFitness() + " Porcetagem "+ getFitnessPercent() + " Score " + Score; 
        }

        public int getInt()
        {
            return Score;
        }

        public void setFitness(double fitness)
        {
            this.fitness = fitness;
        }

        public double getFitness()
        {
            return this.fitness;
        }

        public void setFitnessPercent(double fitnessPercent)
        {
            this.fitnessPercent = fitnessPercent;
        }

        public double getFitnessPercent()
        {
            return this.fitnessPercent;
        }

    }