using System;

namespace NameGenerators {
    public class SimpleCharacterNameGenerator {
        static string[] consonants = { "b", "c", "d", "f", "g", "h", "j", "k", "l", "m", "l", "n", "p", "q", "r", "s", "sh", "zh", "t", "v", "w", "x" };
        static string[] vowels = { "a", "e", "i", "o", "u", "ae", "y" };
        public static string GenerateName(Random r, int nameLength) {
            string name = "";
            for(int i = 0; i < nameLength; i++) {
                name += i % 2 == 0 ? consonants[r.Next(consonants.Length)] : vowels[r.Next(vowels.Length)];
            }
            return name;
        }
    }
}
