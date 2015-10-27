using System;

namespace NameGenerators {
    public class SpaceBodyGenerator {
        static string[] planetPrefix = { "X", "A", "Z", "T", "F", "Q" };
        static string[] planetSuffix = { "1", "2", "3", "4", "5", "6", "7", "8", "9" };
        public string GenerateSpaceBodyName(Random r, int lettersLength, int numbersLength) {
            string name = "", letter = "";
            while(name.Length < lettersLength) {
                letter = planetPrefix[r.Next(planetPrefix.Length)];
                if(!name.Contains(letter))
                    name += letter;
            }
            while(name.Length < lettersLength + numbersLength) {
                letter = planetSuffix[r.Next(planetSuffix.Length)];
                name += letter;
            }
            return name;
        }
    }
}
