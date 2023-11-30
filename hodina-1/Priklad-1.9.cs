namespace Priklad_1_9_NameSpace {
    class Priklad_1_9 {
        public void Run () {
            Console.WriteLine("Příklad 1.9: Sčítance čísla");

            int num1_9 = 4, num2_9 = 13, num3_9 = 9;

            if (num1_9 == num2_9 + num3_9 || num2_9 == num1_9 + num3_9 || num3_9 == num1_9 + num2_9)            
                Console.WriteLine("Některá čísla jsou součtem zbývajících dvou čísel.");            
            else            
                Console.WriteLine("Žádná dvě čísla netvoří součet třetího čísla.");                     
        }
    }
}