// Tento zdrojovy kod jsem vzpracoval zcela samostatne bez cizi pomoci
// Neokopiroval jsem ani neopsal jsem cizi zdrojove kody
// Nikdo me pri vzpracovani neradil
// Pokud nektery radek porusuje toto pravidlo je oznacek komentarem
// NENI NOJE TVORBA
// Poruseni techto pravidel se povazuje za podvod, ktery lze potrestat VYLOUCENIM ZE STUDIA
// Platon Solovinanov 40450

namespace Priklad_1_2_NameSpace {
    class Priklad_1_2 {
        public void Run () {
            Console.WriteLine("Příklad 1.2: Zbytek po celočíselném dělení bez operátoru %");  

            int x = 14, y = 3;
            int result2 = x - (x / y) * y;

            Console.WriteLine($"Zbytek po celočíselném dělení čísla {x} číslem {y} je {result2}");            
        }            
    }
}