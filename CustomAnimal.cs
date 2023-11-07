using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adv_csharp_animals
{
    public class CustomAnimal
    {
        private Talkable animal;

        public CustomAnimal()
        {
            try
            {
                Console.WriteLine("(Options are: Dog or Cat)");
                Console.Write("Enter the Name of the Type of Animal being created: ");
                string animalType = Console.ReadLine().Trim().ToLower();
                Console.WriteLine("\n");

                if(animalType == "dog" || animalType == "cat")
                {
                    Console.Write("Enter the Name of the Animal being created: ");
                    string animalName = Console.ReadLine().Trim();
                    Console.WriteLine("\n");

                    if (animalType == "dog")
                    {
                        Console.Write("Is the dog friendly? (yes/no): ");
                        string dogFriendly = Console.ReadLine().Trim();
                        Console.WriteLine("\n");

                        bool dogIsFriendly = false;

                        if(dogFriendly == "yes")
                        {
                            dogIsFriendly = true;
                        }

                        animal = new Dog(dogIsFriendly, animalName);
                    }
                    else
                    {
                        Console.Write("How many mice has the cat killed? (Enter Interger): ");
                        string miceKilledString = Console.ReadLine().Trim();
                        Console.WriteLine("\n");

                        int miceKilled;
                        if(int.TryParse(miceKilledString, out miceKilled))
                        {
                            animal = new Cat(miceKilled, animalName);
                        }
                        else 
                        {
                            Console.WriteLine("Value entered for mice killed is invalid");
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Invalid Animal Type Provided");
                }
            }
            catch (IOException ex)
            {
                Console.WriteLine($"Input Error: {ex}");
            }
        }

        public Talkable GetAnimal() => animal;
    }
}
