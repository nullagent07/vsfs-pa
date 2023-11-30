namespace Priklad_2_5_NameSpace {
    class Priklad_2_5 {
        public int findNOD (int a, int b) {
            while( b != 0 ) {
                int temp = b;
                b = a % b;
                a = temp;
            }
            return a;
        }
        public void Run () {
            int a;
            int b;
            string? input;
            Console.Write("Zadej pvni cislo: ");
            while(true) {                
                input = Console.ReadLine();                
                if(int.TryParse(input, out int number))
                {
                    a = number;
                    break;
                } 
                else                 
                    Console.Write("Spatne cislo zadejte znovu: ");
            }
            Console.Write("Zadej druhe cislo: ");
            while(true) {
                
                input = Console.ReadLine();                
                if(int.TryParse(input, out int number))
                {
                    b = number;
                    break;
                }                    
                else                
                    Console.Write("Spatne cislo zadejte znovu: ");
            }
            int nor = findNOD(a, b);
            int nsn = (a * b)/nor;
            Console.WriteLine("Nejmensi spolecny nasobek je " + nsn);
        }        
    }
}