using System;
using System.Collections.Generic;
using System.Linq;

namespace ExpressionsEtOperateurs
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== 1. Expressions et Opérateurs (Basique) ===");
            int a, b, c;
            a = 7;
            b = a;
            c = b++; // c = 7, b devient 8
            b = a + b * c; // 7 + 8 * 7 = 63
            c = a >= 100 ? b : c / 10; // 7 >= 100 est faux, donc c = 7 / 10 = 0
            a = (int)Math.Sqrt(b * b + c * c); // Math.Sqrt(63^2 + 0^2) = 63

            Console.WriteLine($"Résultats -> a: {a}, b: {b}, c: {c}");

            Console.WriteLine("\n=== 2. Manipulation de chaînes ===");
            string s = "String literal";
            string l = s[s.Length - 1].ToString(); // Récupère le dernier caractère ('r')
            Console.WriteLine($"Chaîne complète : {s}");
            Console.WriteLine($"Dernier caractère : {l}");

            Console.WriteLine("\n=== 3. Listes et Expressions Lambda ===");
            var nombres = new List<int>(new[] { 1, 2, 3 });
            b = nombres.FindIndex(n => n > 1); // Trouve l'indice du premier nombre > 1 (ici '2', indice 1)
            Console.WriteLine($"Indice du premier nombre > 1 : {b}");

            Console.WriteLine("\n=== 4. Expression de requête (LINQ) ===");
            var noms = new[] { "Sarr", "Sy", "Faye", "Diop", "Ba", "Toupane", "Lo", "Agbahé" };
            
            IEnumerable<string> nomsPlusDe2Caracteres = 
                from nom in noms
                where nom.Length > 2
                orderby nom.Length descending
                select nom;

            Console.WriteLine("Noms filtrés (> 2 caractères) et triés par longueur décroissante :");
            Console.WriteLine(string.Join(" ", nomsPlusDe2Caracteres));
        }
    }
}
```[cite: 2, 3]

---

### 2. Comment exécuter le programme ?

Pour compiler et exécuter ce code pas à pas depuis votre terminal (dans le dossier de votre projet) :

1. Assurez-vous d'avoir enregistré le code ci-dessus dans le fichier `Program.cs`.
2. Lancez la compilation et l'exécution avec la commande :
   ```bash
   dotnet run