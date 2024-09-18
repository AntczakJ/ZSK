namespace _2_dziedziczenie
{
    internal class Program
    {
        public class Job()
        {
            public virtual void Work()
            {
                Console.WriteLine("Praca");
            }
        }

        class Worker : Job
        {
            public string  Name { get; set; }
            public string Surname { get; set; }
            public int Age { get; set; }

            public override void Work()
            {
                Console.WriteLine($"Pracownik {Name} {Surname} ma {Age} lat i pracuje");
            }
        }

        class Assistent : Job
        {
            public string Task { get; set; }

            public override void Work()
            {
                Console.WriteLine($"Asystent {Task}");
            }
        }
            static void Main(string[] args)
        {
            while(true)
            {
                Console.WriteLine("1 - Pracownik");
                Console.WriteLine("2 - Asystent");
                Console.WriteLine("3 - Wyjście");
                int choice = int.Parse(Console.ReadLine());
                switch(choice)
                {
                    case 1:
                        Console.WriteLine("Podaj imię: ");
                        string name = Console.ReadLine();
                        Console.WriteLine("Podaj nazwisko");
                        string surname = Console.ReadLine();
                        Console.WriteLine("Podaj wiek");
                        int age = int.Parse(Console.ReadLine());
                        Worker worker = new Worker();
                        worker.Name = name;
                        worker.Age = age;
                        worker.Surname = surname;
                        worker.Work();
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    case 2:
                        Console.WriteLine("Podaj zadanie: ");
                        string task = Console.ReadLine();
                        Assistent assistent = new Assistent();
                        assistent.Task = task;
                        assistent.Work();
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    case 3:
                        return;
                    default:
                        Console.WriteLine("Błędne dane");
                        break;

                }
            }
        }
    }
}
