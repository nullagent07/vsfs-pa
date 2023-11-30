namespace Priklad_1_6_NameSpace {
    class Priklad_1_6 {
        public void Run () {
            Console.WriteLine("Příklad 1.6: Různá čísla");

            int numM = 7, numN = 3, numO = 7;
            bool areDifferent1 = (numM != numN) && (numN != numO) && (numM != numO);

            Console.WriteLine($"Hodnoty {numM}, {numN} a {numO} jsou navzájem různé: {areDifferent1}");    

            Console.WriteLine("");  

            int numP = 25, numQ = 8, numR = 19;
            bool areDifferent2 = (numP != numQ) && (numQ != numR) && (numP != numR);
            Console.WriteLine($"Hodnoty {numP}, {numQ} a {numR} jsou navzájem různé: {areDifferent2}");
                    
        }
    }    
}