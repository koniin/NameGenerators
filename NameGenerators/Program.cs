using System;

namespace NameGenerators {
    class Program {
        static void Main(string[] args) {
            Random r = new Random(2345); // using fixed seed
            var simpleNameGenerator = new SimpleCharacterNameGenerator();
            Console.Write("Name: ");
            Console.Write(simpleNameGenerator.GenerateName(r, 5));

            Console.WriteLine("\n");

            var spaceBodyGenerator = new SpaceBodyGenerator();
            Console.Write("Space body: ");
            Console.Write(spaceBodyGenerator.GenerateSpaceBodyName(r, 3, 4));

            Console.Read();
        }
    }
}
