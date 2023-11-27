namespace Hodina0ne {
    public class MyClassOne {
        public void RunExample() {       
            Console.WriteLine("");     
            Console.WriteLine("Příklad 1.1: Specifický aritmetický výraz");  
            int a = 12, b = 5, c = 9;
            int result1 = b * c - a;
            Console.WriteLine($"Výsledek výrazu {b}*{c}-{a} je {result1}");
            Console.WriteLine("");  

            Console.WriteLine("Příklad 1.2: Zbytek po celočíselném dělení bez operátoru %");  
            int x = 14, y = 3;
            int result2 = x - (x / y) * y;
            Console.WriteLine($"Zbytek po celočíselném dělení čísla {x} číslem {y} je {result2}");
            Console.WriteLine("");  
            
            Console.WriteLine("Příklad 1.4: Největší ze tří čísel");  
            int numA = 14, numB = 6, numC = 23;
            int max = (numA > numB) ? ((numA > numC) ? numA : numC) : ((numB > numC) ? numB : numC);
            Console.WriteLine($"Nejvyšší z hodnot {numA}, {numB} a {numC} je {max}");
            Console.WriteLine("");

            Console.WriteLine("Příklad 1.6: Různá čísla");
            int numM = 7, numN = 3, numO = 7;
            bool areDifferent1 = (numM != numN) && (numN != numO) && (numM != numO);
            Console.WriteLine($"Hodnoty {numM}, {numN} a {numO} jsou navzájem různé: {areDifferent1}");
            Console.WriteLine("");  

            int numP = 25, numQ = 8, numR = 19;
            bool areDifferent2 = (numP != numQ) && (numQ != numR) && (numP != numR);
            Console.WriteLine($"Hodnoty {numP}, {numQ} a {numR} jsou navzájem různé: {areDifferent2}");
            Console.WriteLine("");  
                        
            Console.WriteLine("Příklad 1.9: Sčítance čísla");
            int num1_9 = 4, num2_9 = 13, num3_9 = 9;
            if (num1_9 == num2_9 + num3_9 || num2_9 == num1_9 + num3_9 || num3_9 == num1_9 + num2_9)
            {
                Console.WriteLine("Některá čísla jsou součtem zbývajících dvou čísel.");
            }
            else
            {
                Console.WriteLine("Žádná dvě čísla netvoří součet třetího čísla.");
            }            
        }
    }
}
