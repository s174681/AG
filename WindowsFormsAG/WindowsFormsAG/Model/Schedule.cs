using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Windows.Forms;
using WindowsFormsAG.Controller;
using WindowsFormsAG.Model;
using WindowsFormsAG;

namespace WindowsFormsAG.Model
{
    /// <summary>
    /// Stan algorytmu
    /// </summary>
    enum AlgorithmState
    {
        AS_USER_STOPED,
        AS_CRITERIA_STOPPED,
        AS_RUNNING,
        AS_CHECK
    }

    class ConstValue
    { }

    /// <summary>
    /// Generacja liczb losowych.
    /// </summary>
    class RandomNbr
    {
        public static int GetRandomNbr()
        {
            byte[] bytes = new byte[4];
            System.Security.Cryptography.RNGCryptoServiceProvider rng = new System.Security.Cryptography.RNGCryptoServiceProvider();
            rng.GetBytes(bytes);

            Random random = new Random(BitConverter.ToInt32(bytes, 0));

            return random.Next();
        }
    }
//[Serializable]
    public class Schedule //: ICloneable
    {

        public Schedule()
        {
        }

        /// <summary>
        /// Liczba punktów krzyżowania tabelach klasy rodzica 
        /// </summary>
        private int numberOfCrossoverPoints;
        /// <summary>
        /// Rozmiar mutacji, Liczba klas, które przemieszcza się losowo pojedynczej mutacji
        /// </summary>
        private int mutationSize;
        /// <summary>
        /// Prawdopodobieństwo, że krzyżowanie nastąpi, będzie max
        /// </summary>
        private int crossoverProbability;
        /// <summary>
        /// Prawdopodobieństwo, że mutacja nastąpi, 
        /// </summary>
        private int mutationProbability;
        /// <summary>
        /// Wartość fitness chromosomu
        /// Wartości dopasowania są reprezentowane przez liczb zmiennoprzecinkowych pojedynczej precyzji (float), w zakresie od 0 do 1.
        /// </summary>
        private float fitness;

        /// <summary>
        /// lista przechowuje kryteria
        /// </summary>
        List<bool> criteria = new List<bool>();

        /// <summary>
        /// Reprezuentuje przestrzen czasową jeden wpis to jeden dzien harmonogramu
        /// </summary>
        List<List<Egzaminy>> slots = new List<List<Egzaminy>>();

        /// <summary>
        /// Class tabela Exams dla chromosomu
        /// Używany do określenia pierwszy slot czasoprzestrzeni używaną przez class
        /// </summary>
        Dictionary<Egzaminy, int> mapExam = new Dictionary<Egzaminy, int>();

        public static int NUM_DAYS;   //dni w sesji nie uwzględniając w tym weekendów i świąt   // Form1.DaysCount
        public static int NUM_EXAMS; // ilość ośrodków z kwalifikacjami //ExamsController.RecordCount
        public static int NUM_CRITERIA;//{ get; set; }

        public void SetNumDays(int num_days)
        {
            NUM_DAYS = num_days;
        }

        public void SetNumExams(int num_exams)
        {
            NUM_EXAMS = num_exams;
        }

        /// <summary>
        /// inicjalizacja chromosomu 
        /// </summary>
        /// <param name="numberOfCrossoverPoints"></param>
        /// <param name="mutationSize"></param>
        /// <param name="crossoverProbability"></param>
        /// <param name="mutationProbability"></param>
        public Schedule(int numberOfCrossoverPoints, int mutationSize, int crossoverProbability, int mutationProbability)
        {

            this.numberOfCrossoverPoints = numberOfCrossoverPoints;
            this.mutationSize = mutationSize;
            this.crossoverProbability = crossoverProbability;
            this.mutationProbability = mutationProbability;
        }

        /// <summary>
        /// konstruktor kopiujący 
        /// </summary>
        /// <param name="c"></param>
        /// <param name="setupOnly"></param>
        public Schedule(Schedule c, bool setupOnly)
        {
            if (!setupOnly) // jeśli istnieje już kopia chrompsomu   
            {
                // kopia kod
                slots = c.slots;
                mapExam = c.mapExam;
                // kopia flagi wymagań klasy 
                criteria = c.criteria;
                // kopia fitness
                fitness = c.fitness;

            }
            else            // jeśli nie, tworzymy chromosom
            {
                // rezerwujemy przestrzeń czasową dla egzaminow w chromosomie
                slots.Capacity = NUM_DAYS; //* NUM_EXAMS;
                for (int i = 0; i < slots.Capacity; i++)
                {
                  slots.Add(new List<Egzaminy>());
                }

                // rezerwujemy przestrzeń dla oceny kryteriów
                NUM_CRITERIA = 4;
                criteria.Capacity = NUM_EXAMS * NUM_CRITERIA;
                for (int i = 0; i < criteria.Capacity; i++)
                {
                    criteria.Add(false);
                }
            }

            // kopia pozostałych parametrów
            numberOfCrossoverPoints = c.numberOfCrossoverPoints;
            mutationSize = c.mutationSize;
            crossoverProbability = c.crossoverProbability;
            mutationProbability = c.mutationProbability;
        }

        /// <summary>
        /// Robi kopię chromosomu
        /// </summary>
        /// <param name="setupOnly"></param>
        /// <returns></returns>
        public Schedule MakeCopy(bool setupOnly)
        {
            // wywołaj konstruktor kopiujący
            return new Schedule(this, setupOnly);
        }

       
        /// <summary>
        /// losowo wygenerowanie nowego chromosoma
        /// </summary>
        /// <returns></returns>
        public Schedule MakeNewFromPrototype(List<Egzaminy> courseList, List<Egzaminatorzy> egzaminatorzy)
        {
            // ilość przestrzeni czasowwej 
            int size = slots.Capacity;

            // tworzenie nowego chromosomu, kopiowanie struktury(ustawień) chromosomu 
            // Zgodnie z obecnym chromosomem skopiować nowy chromosom, ponieważ wartość setupOnly jest true, więc o to nowa generacja chromosomów
            Schedule newChromosome = new Schedule(this, true);

            // miejsce egzaminu w losowej pozycji
            // Egzaminator w losowej lokalizacji
            List<Egzaminy> c = courseList;// Pobierz wszystkie Exams, przechowaj w c liście 
            List<Egzaminatorzy> eg = egzaminatorzy;


            foreach (Egzaminy it in c)// Use of iterators，C traverses
            {
                // okreslamy losową pozycje egzaminów
                int nr = NUM_EXAMS;
                int dur = it.CzasTrwania;
                int day = RandomNbr.GetRandomNbr() % NUM_DAYS;
                int center = RandomNbr.GetRandomNbr() % nr;
                int time = RandomNbr.GetRandomNbr() % (NUM_DAYS + 1 - dur);

                //pos numer slotu czyli konkretny dzien sesji egzaminacyjnej
                int pos = day - time; //day * center + time;

                if (pos<1) 
                    pos = day;
                else if ((pos + dur)>NUM_DAYS) 
                    pos = NUM_DAYS-dur;

                // wypełnić szczeliny przestrzeni czasu, dla każdego dnia
                for (int i = dur - 1; i >= 0; i--)
                {
                   newChromosome.slots[pos + i].Add(it);
                }

                it.EgzaminatorzyList.Clear();
                for (int k = 0; k < it.LiczbaEgzaminatorow; k++)
                {
                    int losowy = RandomNbr.GetRandomNbr() % eg.Count;
                    Egzaminatorzy egzaminator_losowy = eg[losowy];
                    //eg.RemoveAt(losowy);
                    it.EgzaminatorzyList.Add(egzaminator_losowy);

                }
                newChromosome.mapExam.Add(it, pos);
            }

           newChromosome.CalculateFitness();

            // return smart pointer
            return newChromosome;
        }

        /// <summary>
        /// Wykonanie krzyżowania używająć chromosomów i zwraca wskaźnik do potomstwa
        /// </summary>
        /// <param name="parent2"></param>
        /// <returns></returns>
        public Schedule Crossover(Schedule parent2)
        {
            // sprawdzenie prawdopodobieństwa krzyżowania 
            if (RandomNbr.GetRandomNbr() % 100 > crossoverProbability)
            {
                //nie krzyżowanie, wystarczy skopiować pierwszego rodzica
                return new Schedule(this, false);
            }

            // nowy obiekt chromosomu, kopiuj struktury(ustawień) chromosomu 
            // n jest nowy chromosom
            Schedule n = new Schedule(this, true);

            // liczba egzaminów
            int size = mapExam.Count;

            List<bool> cp = new List<bool>();
            cp.Capacity = size;
            for (int c = 0; c < cp.Capacity; c++)
            {
                cp.Add(false);
            }

            // określić punkt krzyżowania (losowo)
            for (int i = numberOfCrossoverPoints; i > 0; i--)
            {
                while (true)
                {
                    int p = RandomNbr.GetRandomNbr() % size;

                    if (!cp[p])
                    {
                        cp[p] = true;
                        break;
                    }
                }
            }

            // Get pierwsze iteracje były potrzebne do skrzyżowania z harmonogramem dwa
            IDictionaryEnumerator it1 = this.mapExam.GetEnumerator();
            IDictionaryEnumerator it2 = parent2.mapExam.GetEnumerator();

            bool first = RandomNbr.GetRandomNbr() % 2 == 0;
            for (int i = 0; i < size; i++)
            {
                it1.MoveNext();
                it2.MoveNext();

                // punkt krzyżowania
                if (cp[i])
                {
                    // zmiana żródła chromosomu 
                    first = !first;
                }

                if (first)
                {
                    // wstawienie egzaminu z pierwszego rodzica do nowej chromosome's class table
                    if (n.mapExam.ContainsKey(it1.Key as Egzaminy))
                    {
                        n.mapExam.Remove(it1.Key as Egzaminy);
                        n.mapExam.Add(it1.Key as Egzaminy, (int)it1.Value);
                    }
                    else
                    {
                        n.mapExam.Add(it1.Key as Egzaminy, (int)it1.Value);
                    }

                    // wszystkie slots czaso-przestrzenne egzaminu są kopiowane 
                    for (int j = (it1.Key as Egzaminy).CzasTrwania - 1; j >= 0; j--)
                    {
                        n.slots[(int)it1.Value + j].Add(it1.Key as Egzaminy);
                    }

                }
                else
                {
                    // wstawienie egzaminu z drugiego rodzica do nowego chromosome's calss table
                    if (n.mapExam.ContainsKey(it2.Key as Egzaminy))
                    {
                        n.mapExam.Remove(it2.Key as Egzaminy);
                        n.mapExam.Add(it2.Key as Egzaminy, (int)it2.Value);
                    }
                    else
                    {
                        n.mapExam.Add(it2.Key as Egzaminy, (int)it2.Value);
                    }
                    // wszystkie slots czaso-przestrzenne egzaminu są kopiowane 
                    for (int j = (it2.Key as Egzaminy).CzasTrwania - 1; j >= 0; j--)
                    {
                        n.slots[(int)it2.Value + j].Add(it2.Key as Egzaminy);
                    }

                }

            }

            // Wartośc fitness jest przeliczana po krzyżowaniu chromosomów 
            n.CalculateFitness();

            // return smart pointer to offspring
            return n;
        }

        /// <summary>
        /// Wykonuje mutacji na chromosomie
        /// </summary>
        public void Mutation()
        {
            // sprawdzenie prawdopodobieństwa mutacji
            // decision was not random mutation operation
            if (RandomNbr.GetRandomNbr() % 100 > mutationProbability)
            {
                return;
            }

            // number of classes
            int numberOfClasses = mapExam.Count;
            // number of time-space slots
            int size = slots.Capacity;

            // przenieść wybraną liczbę klas w dowolnej pozycji
            // mutationSize zróżnicowanie odnosi się do liczby punktów, aby ilość lekcji zmienności
            for (int i = mutationSize; i > 0; i--)
            {
                // wybierz losowo chromosom dla przemieszczenia 
                int mpos = RandomNbr.GetRandomNbr() % numberOfClasses;
                int pos1 = 0;

                IDictionaryEnumerator it = mapExam.GetEnumerator();

                // Według mpos weź i it
                // W celu uzyskania wymaganych kursów i punktów zmiany pozycji w przestrzeni czasowej
                if (it.MoveNext())
                {
                    for (; mpos > 0; it.MoveNext(), mpos--)
                        ;
                }

                // Aktualna przestrzeń czasowa używana przez klase
                pos1 = (int)it.Value;

                // Get the information you need variation points Exams
                Egzaminy cc1 = it.Key as Egzaminy;

                // określa pozycję klasy losowo
                int nr = NUM_EXAMS;
                int dur = cc1.CzasTrwania;
                int day = RandomNbr.GetRandomNbr() % NUM_DAYS;
                int center = RandomNbr.GetRandomNbr() % nr;
                int time = RandomNbr.GetRandomNbr() % (NUM_DAYS + 1 - dur);
                int pos2 = (day * nr * NUM_DAYS + center * NUM_DAYS + time) % NUM_DAYS; //day-time;

                // przenieść wszystkie przestrzenie czasowe
                for (int j = dur - 1; j >= 0; j--)
                {
                    // usuń class hour z bieżącej przestrzeni czasowj 
                    foreach (Egzaminy it2 in slots[pos1 + j])
                    {
                        if (it2 == cc1) //(it2.QualificationId == cc1.QualificationId)
                        {
                            slots[pos1 + j].Remove(it2);
                            break;
                        }
                    }

                    // przedz do class hour nowej przestrzeni czasowj 
                    slots[pos2 + j].Add(cc1);
                }

                // change entry of class table to point to new time-space slots
                mapExam[cc1] = pos2;
            }

            // Mutated chromosome fitness value is calculated
            this.CalculateFitness();

        }

        public void CalculateFitness()
        {
            //1) w danym ośrodku egzaminacyjnym nie mogą nakładac sie egzaminy waga 3
            //2) egzaminatorzy nie mogą być w tym samym czasie w różnych ośrodkach waga 5
            //3) egzaminator nie moze byc przydzielony do ośrodka w którym pracuje waga 1
            //4) egzaminator musi być z uprawnieniem do danego egzaminu(kwalifikacji) waga 7
            //5) Osrodek nie egzaminuje w weekend

            // Wynik chromosomu
            int score = 0;

            int numberOfCenter = NUM_EXAMS;
            int daySize = NUM_DAYS * numberOfCenter;
            string kryteriumEgzaminu; //kryterium dla poszczegolnego egzaminu w skali 0-5

            int ci = 0;
            IDictionaryEnumerator it = mapExam.GetEnumerator();

            // sprawdzić i obliczyć wyniki charakterystyczne dla każdej klasy w harmonogramie
            while (it.MoveNext())
            {
                // współrzędne szczeliny czasoprzestrzeni
                int p = (int)it.Value; //numer slotu jako Value mapExam <Key,Value>
                int day = p / daySize;
                int time = p % daySize;
                int room = time / NUM_DAYS;
                time = time % NUM_DAYS;

                kryteriumEgzaminu = string.Empty;
              
                Egzaminy egzamin = ((Egzaminy)it.Key);

                int dur = egzamin.CzasTrwania;

                //// sprawdzamy kryterium 1
                bool ro = false;

                for (int i = dur - 1; i >= 0; i--)
                {
                    if (slots[p + i].Count(x => x.OsrodekKod == egzamin.OsrodekKod) > 1)
                    {
                        ro = true;
                        break;
                    }
                }

                // nakładanie się ośrodków 
                if (!ro)
                {
                    score++;
                    kryteriumEgzaminu = "3";
                }

                //wstawiamy wartość kryterium 1 do tablicy z kryteriami
                criteria[ci + 0] = !ro;

                //nakładanie sie egzaminatorów w tym samym dniu w innym oe
                bool eg = false;

                for (int i = dur - 1; i >= 0; i--)
                {
                    for (int j = 0; j < egzamin.LiczbaEgzaminatorow; j++)
                    {
                        //wykluczamy nasz OE
                        List<Egzaminy> item_egzamin = slots[p + i].Where(x => x.OsrodekKod != egzamin.OsrodekKod).ToList();

                        for (int k = 0; k < item_egzamin.Count; k++)
                        {
                            List<Egzaminatorzy> item_egzaminatorzy = item_egzamin.ElementAt(k).EgzaminatorzyList.ToList();

                            for (int d = 0; d < item_egzaminatorzy.Count; d++)
                            {
                                if (item_egzaminatorzy.ElementAt(d).EgzaminatorCKE == egzamin.EgzaminatorzyList.ElementAt(j).EgzaminatorCKE)
                                {
                                    eg = true;
                                }
                            }

                            if (eg) break;
                        }

                        if (eg) break;
                    }

                    if (eg) break;
                }

                if (!eg)
                {
                    score++;
                    kryteriumEgzaminu = kryteriumEgzaminu + "5";
                }

                criteria[ci + 1] = !eg;

                // Egzaminator nie pracuje w tym osrodku
                bool po = false;

                for (int i = 0; i < egzamin.LiczbaEgzaminatorow; i++)
                {
                    if (egzamin.EgzaminatorzyList.ElementAt(i).EgzaminatorOsrodek == egzamin.OsrodekKod)
                    {
                        po = true;
                        break;
                    }
                }

                if (!po)
                {
                    score++;
                    kryteriumEgzaminu = kryteriumEgzaminu + "1";
                }

                criteria[ci + 2] = !po;

                //egzaminator ma uprawnienie w tej kwalifikacji
                bool go = false;

                for (int i = 0; i < egzamin.LiczbaEgzaminatorow; i++)
                {
                    if (egzamin.EgzaminatorzyList.ElementAt(i).KwalifikacjeList.Count(x => x.KwalifikacjaKod == egzamin.KwalifikacjaKod) == 0)
                    {
                        go = true;
                        break;
                    }
                }

                if (!go)
                {
                    score++;
                    kryteriumEgzaminu = kryteriumEgzaminu + "7";
                }

                criteria[ci + 3] = !go;

                egzamin.Kryterium = kryteriumEgzaminu;
                
            }

            //NUM_CRITERIA = NUM_EXAMS * 4;
            fitness = (float)score / (NUM_EXAMS * NUM_CRITERIA);
 
        }

        /// <summary>
        /// zwraca aktualne przystosowanie
        /// </summary>
        /// <returns></returns>
        public float GetFitness()
        {
            return fitness;
        }

        /// <summary>
        /// zwraca tablice egzaminów
        /// </summary>
        /// <returns></returns>
        public Dictionary<Egzaminy, int> GetMapExam()
        {
            return mapExam;
        }

        /// <summary>
        /// Returns array of flags of class requiroments satisfaction
        /// </summary>
        /// <returns></returns>
        public List<bool> GetCriteria()
        {
            return criteria;
        }

        /// <summary>
        /// Return reference to array of time-space slots
        /// </summary>
        /// <returns></returns>
        public List<List<Egzaminy>> GetSlots()
        {
            return slots;
        }


        //public object Clone()
        //{
        //    Schedule kopia = (Schedule)this.MemberwiseClone();
        //    kopia.slots = (List<List<Egzaminy>>)this.slots;
        //    kopia.mapExam = (Dictionary<Egzaminy, int>)this.mapExam;
        //    return kopia;
        //}
    }
}

