using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WindowsFormsAG.Controller;
using WindowsFormsAG.Model;

namespace WindowsFormsAG.Controller
{
    class AlgorithmController
    {
        // Populacja chromosomow
        private List<Schedule> chromosomes = new List<Schedule>();

        // Wskazuje czy chromosom należy do najlepszej grupy 
        private List<bool> bestFlags = new List<bool>();

        // Lista najlepszych chromosomów
        private List<int> bestChromosomes = new List<int>();

        // Liczba obecnie najlepszych chromosomów zapisana do grupy najlepszych chromosomów 
        private int currentBestSize;

        // Liczba chromosomów, które są zastępowane w każdej generacji przez potomstwo
        private int replaceByGeneration;

        /// <summary>
        /// Prototyp chromosomów w populacji
        /// </summary>
        private Schedule prototype;

        /// Obecna generacja
        private int currentGeneration;

        // Stan realizacji algorytmu 
        private AlgorithmState state;

        // Wskaźnik do globalnego przypadku algorytmu 
        //private static AlgorithmController instance = null;

        // Zwraca odnesienie do obecnej generacji 
        public int GetCurrentGeneration
        {
            get { return currentGeneration; }
        }

        public AlgorithmController()
        {
        }

        public AlgorithmController(AlgorthmParameters parametry)
            : this()
        {
            Schedule prototype = new Schedule(parametry.NumberOfCrossoverPoints, parametry.MutationSize
                                            , parametry.CrossoverProbability, parametry.MutationProbability);

            this.replaceByGeneration = parametry.ReplaceByGeneration;

            // Obecna liczba genomu najlepszego chromosomu，inicjacja 0
            this.currentBestSize = 0;

            // Chromosom inicjalizacji
            this.prototype = prototype;

            // Obecna generacja po pierwsze generacje tabel są obecnie chromosomy
            this.currentBestSize = 0;

            // stan algorytmu 
            this.state = AlgorithmState.AS_USER_STOPED;

            // Algorytm może mieć co najmniej dwa chromosomy
            if (parametry.NumberOfChromosomes < 2)
                parametry.NumberOfChromosomes = 2;

            // Śledzenia przynajmniej jedna z najlepszych chromosomie？
            if (parametry.TrackBest < 1)
                parametry.TrackBest = 1;

            if (this.replaceByGeneration < 1)
                this.replaceByGeneration = 1;
            else if (this.replaceByGeneration > parametry.NumberOfChromosomes - parametry.TrackBest)
                this.replaceByGeneration = parametry.NumberOfChromosomes - parametry.TrackBest;

            // _chromosomes i _bestFlags są tej samej wielkości, jest jeden do jednego mapowania między nimi
            this.chromosomes.Capacity = parametry.NumberOfChromosomes;
            for (int i = 0; i < this.chromosomes.Capacity; i++)
            {
                chromosomes.Add(new Schedule());
            }

            this.bestFlags.Capacity = parametry.NumberOfChromosomes;
            for (int i = 0; i < this.bestFlags.Capacity; i++)
            {
                this.bestFlags.Add(false);
            }

            this.bestChromosomes.Capacity = parametry.TrackBest;
            for (int i = 0; i < this.bestChromosomes.Capacity; i++)
            {
                this.bestChromosomes.Add(-1);
            }
        }

        public void Population(List<Egzaminatorzy> examinerList, List<Egzaminy> examList)
        {
            for (int i = 0; i < chromosomes.Capacity; i++)
            {
                //chromosomes.Add(Clonowanie.DeepCopy(prototype.MakeNewFromPrototype(examList, examinerList)));
                chromosomes[i] = Clonowanie.DeepCopy(prototype.MakeNewFromPrototype(examList, examinerList)); //dla egzaminatorów jest utworzona tylko jedna instancja odwołanaia się do pamięci
                AddToBest(i);
            }

        }

        //public Schedule GetSchedule(List<Egzaminatorzy> examinerList, out Schedule best, List<Egzaminy> examList)
    public Schedule GetSchedule(List<Egzaminatorzy> examinerList,  List<Egzaminy> examList)
            
    {

            // Ustawia obecną generacje na 0 
            currentGeneration = 0;

            // Zwraca (znajdź) najlepszy chromosom, który uzyska najlepszy harmonogram 
           // best = GetBestChromosome();

            // Reprodukować(rozmnażać) chromosom, potomstwo chromosomu              
            List<Schedule> offspring = new List<Schedule>();    // The definition of chromosomal
            offspring.Capacity = this.replaceByGeneration;      // Ustawienie liczby chromosomów

            for (int o = 0; o < offspring.Capacity; o++)    // Inicjacja chromosomów
            {
                offspring.Add(new Schedule());
            }

            for (int j1 = 0; j1 < this.replaceByGeneration; j1++)
            {
                Schedule p2 = chromosomes[RandomNbr.GetRandomNbr() % chromosomes.Count];
                Schedule p1 = chromosomes[RandomNbr.GetRandomNbr() % chromosomes.Count];

                offspring[j1] = p1.Crossover(p2);

                offspring[j1].Mutation();

                offspring[j1].CalculateFitness();
            }

            // Zatąpienie nowym potomstwem chromosomu liczbę replaceByGeneration(8) starych chromosomów
            for (int j = 0; j < replaceByGeneration; j++)
            {
                int ci;
                do
                {
                    // Losowy wybór chromosom zostanie zastąpiony.
                    ci = RandomNbr.GetRandomNbr() % chromosomes.Count;
                    // If the chromosome is one of the best stain, then a re-election;
                    //otherwise perform the following operations, replacing the old with the new generation of chromosomes
                } while (IsInBest(ci));

                // Delete the older generation of chromosomes, and replaced with new chromosome
                chromosomes[ci] = offspring[j];

                // Look at this new generation of chromosome whether there is sufficient conditions to become one of the best chromosome
                AddToBest(ci);
            }// This，_replaceByGeneration replaced by a new generation of chromosomes _replaceByGeneration old chromosomes

            currentGeneration++;

            return GetBestChromosome();
        }

        /// <summary>
        /// Zatrzymuje wykonania algorytmu
        /// </summary>
        public void Stop()
        {
            if (state == AlgorithmState.AS_RUNNING)
                state = AlgorithmState.AS_USER_STOPED;
        }

        /// <summary>
        /// Zwraca wskaźnik do najlepszych chromosomów w populacji
        /// </summary>
        /// <returns></returns>
        public Schedule GetBestChromosome()
        {
            return chromosomes[bestChromosomes[0]];
        }


        /// <summary>
        /// Próbuje dodać chromosomy do najlepszej grupy chromosomów (genomu)
        /// </summary>
        /// <param name="pos"></param>
        public void AddToBest(int chromosomeIndex)
        {
            // Bez kilku przypadków dla najlepszego chromosomu
            if ((currentBestSize == bestChromosomes.Capacity &&
                chromosomes[bestChromosomes[currentBestSize - 1]].GetFitness() >= chromosomes[chromosomeIndex].GetFitness()) ||
                bestFlags[chromosomeIndex])
            {
                return;
            }

            // Dla nowo przybyłych, aby znaleźć najlepszą lokalizację chromosomów
            int i = currentBestSize;

            for (; i > 0; i--)
            {
                if (i < bestChromosomes.Capacity) //najlepszy chromosom nie pełny 
                {
                    // znajdź lokalizację 
                    if (chromosomes[bestChromosomes[i - 1]].GetFitness() >
                        chromosomes[chromosomeIndex].GetFitness())
                    {
                        break;
                    }

                    bestChromosomes[i] = bestChromosomes[i - 1];
                }
                else // pełny 
                {
                    bestFlags[bestChromosomes[i - 1]] = false;
                }
         }

            bestChromosomes[i] = chromosomeIndex;
            bestFlags[chromosomeIndex] = true;

            if (currentBestSize < bestChromosomes.Capacity)
                currentBestSize++;
        }

        /// <summary>
        /// Osądzenie czy chromosom należy do najlepszej grupy chromosomów 
        /// </summary>
        /// <param name="pos"></param>
        /// <returns></returns>
        public bool IsInBest(int chromosomeIndex)
        {
            return bestFlags[chromosomeIndex];
        }

        /// <summary>
        /// Czyści najlepszą grupę chromosomów(genom)
        /// </summary>
        public void ClearBest()
        {
            for (int i = bestFlags.Capacity - 1; i >= 0; i--)
            {
                bestFlags[i] = false;
            }

            currentBestSize = 0;

        }
    }
}
