using System;
using System.Collections.Generic;

namespace NameGenerators {
    public class FromSyllablesNameGenerator {
        public static List<string> Syllables = new List<string> { "mon", "din", "ish", "for", "ban", "di", "ox", "sh", "hex", "ar", "den", "cal", "vin" };
        public string GenerateName(Random r, int syllables) {
            string name = "";
            for(int i = 0; i < syllables; i++) {
                name += Syllables[r.Next(Syllables.Count)];
            }
            return name;
        }
    }
}
