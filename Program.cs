// See https://aka.ms/new-console-template for more information
using adv_csharp_animals;
using System.Collections;
using System.Xml.Linq;

namespace adv_csharp_animals
{
    public class Program
    {
        private readonly static FileOutput outFile = new FileOutput("animals.txt");
        private readonly static FileInput inFile = new FileInput("animals.txt");

        public static void Main()
        {
            List<Talkable> zoo = new List<Talkable>();

            /*zoo.Add(new Dog(true, "Bean"));
            zoo.Add(new Cat(9, "Charlie"));
            zoo.Add(new Teacher(44, "Stacy Read"));*/

            CustomAnimal customAnimal = new CustomAnimal();
            var animal = customAnimal.GetAnimal();
            if (animal != null )
            {
                zoo.Add(animal);
            }

            outFile.FileOpen();

            foreach (Talkable thing in zoo)
            {
                PrintOut(thing);
            }

            outFile.FileClose();

            inFile.FileOpen();
            inFile.FileRead();
            inFile.FileClose();

            FileInput inData = new FileInput("animals.txt");
            inData.FileOpen();

            string line;
            while ((line = inData.FileReadLine()) != null)
            {
                Console.WriteLine(line);
            }
        }

        public static void PrintOut(Talkable p) 
        {
            Console.WriteLine($"{p.GetName()} says={p.Talk()}");
            outFile.FileWrite($"{p.GetName()} | {p.Talk()}");
        }
    }
}


