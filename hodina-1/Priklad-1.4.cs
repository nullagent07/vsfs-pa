namespace Priklad_1_4_NameSpace {
    class Priklad_1_4 {
        public void Run () {
            Console.WriteLine("Příklad 1.4: Největší ze tří čísel");  

            int numA = 14, numB = 6, numC = 23;
            int max = (numA > numB) ? ((numA > numC) ? numA : numC) : ((numB > numC) ? numB : numC);

            Console.WriteLine($"Nejvyšší z hodnot {numA}, {numB} a {numC} je {max}");            
        }
    }
}