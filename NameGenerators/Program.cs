using System;

namespace NameGenerators {
    class Program {
        static void Main(string[] args) {
            Random r = new Random(13425); // using fixed seed
            var simpleNameGenerator = new SimpleCharacterNameGenerator();
            Console.Write("Name: ");
            Console.Write(simpleNameGenerator.GenerateName(r, 5));

            Console.WriteLine("\n");

            var spaceBodyGenerator = new SpaceBodyGenerator();
            Console.Write("Space body: ");
            Console.Write(spaceBodyGenerator.GenerateName(r, 3, 4));
            Console.WriteLine("\n");

            var fromSyllablesNameGenerator = new FromSyllablesNameGenerator();
            Console.Write("From syllables: ");
            Console.Write(fromSyllablesNameGenerator.GenerateName(r, 2));
            Console.Read();
        }
    }
}
