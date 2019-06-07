using System;

namespace interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            Ant ant = new Ant();
            Betta betta = new Betta();
            Copperhead copperhead = new Copperhead();
            Earthworm jim = new Earthworm();
            Finch finch = new Finch();
            Gerbil gerbil = new Gerbil();
            Mouse lenny = new Mouse();
            Parakeet parakeet = new Parakeet();
            Terrapin terry = new Terrapin();
            TimberRattlesnake tim = new TimberRattlesnake();

            DiggingAnimals diggers = new DiggingAnimals();
            diggers.animals.Add(jim);
            diggers.animals.Add(copperhead);
            diggers.animals.Add(tim);

            FlyingAnimals flyers = new FlyingAnimals();
            flyers.animals.Add(finch);
            flyers.animals.Add(parakeet);

            WalkingAnimals walkers = new WalkingAnimals();
            walkers.animals.Add(ant);
            walkers.animals.Add(gerbil);
            walkers.animals.Add(lenny);

            SwimmingAnimals swimmers = new SwimmingAnimals();
            swimmers.animals.Add(betta);
            swimmers.animals.Add(terry);

            Console.WriteLine($"Digging Animals: {diggers.animals.Count}");
            Console.WriteLine($"Flying Animals: {flyers.animals.Count}");
            Console.WriteLine($"Walking Animals: {walkers.animals.Count}");
            Console.WriteLine($"Swimming Animals: {swimmers.animals.Count}");
        }
    }
}
