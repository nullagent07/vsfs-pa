namespace Priklad_4_9_NameSpace {
    class Priklad_4_9 {
        static int PocitacCisla ( int[] arrUser) {
            var vyhry = new List<(int UhodnutoCisel, int Vyhra)> {
                (6, 15382198),  // 6 - 15 382 198 Kč
                (5, 815723),    // 5+ - 815 723 Kč                
                (4, 619),       // 4 - 619 Kč
                (3, 113),        // 3 - 113 Kč
            };                            
                int[] arrPocitac = new int[7];
                int matchingNumbers = 0;                
                Random random = new Random();                
                for ( int i = 0; i < arrPocitac.Length; i++ ) {
                    arrPocitac[i] = random.Next(1, 50);
                }
                // kontrola dodat čísela
                bool dodatCislo = arrUser.Contains(arrPocitac[6]);                
                // počítání výherních čísel
                for ( int i = 0; i < arrUser.Length; i++ ) {
                    if(arrPocitac.Contains(arrUser[i]))
                        matchingNumbers++;                    
                }                
                if (matchingNumbers == 5 && dodatCislo)
                    return 24971;                                     
                else if( matchingNumbers > 2)
                {
                    var vyhra = vyhry.FirstOrDefault(v => v.UhodnutoCisel == matchingNumbers);                    
                    return vyhra.Vyhra;
                }                                            
            return 0;                        
        }               
        public void Run() {                        
            int[] arrUser = new int[6];
            int countGames = 0;
            bool isNumber;             
            Console.Write("Zadejte cislo her: ");            
            do {                    
                isNumber = int.TryParse(Console.ReadLine(), out int number);                    
                if( isNumber)                                        
                    countGames = number;                                          
                else                 
                    Console.Write("Spatne cislo her, zkuste to znovu : ");                                                 
            } while (!isNumber);                        
            Console.Write("Zadejte cislo: ");
            for ( int i = 0; i < arrUser.Length; i++ ) {
                Console.WriteLine(i);                         
                do {                    
                    isNumber = int.TryParse(Console.ReadLine(), out int number) && 0 < number && 49 >= number;
                    if( !isNumber) {
                        Console.Write("Spatne cislo zkuste to znovu : ");
                        isNumber = true;
                    } 
                    else if (isNumber = arrUser.Contains(number))                     
                        Console.Write("Toto cislo uz existuje : ");                     
                    else if ( i != 5) 
                    {
                        arrUser[i] = number;                 
                        Console.Write("Zadejte cislo: ");    
                    }                        
                } while (isNumber);
            }                  
            int zisk = -(countGames * 20);
            for (int i = 0; i < countGames; i++) {
                int vyhra = PocitacCisla(arrUser);    
                Console.WriteLine($"hra {i+1} : {vyhra}");
                zisk += vyhra;
            }
            Console.WriteLine($"Vaše výhry {zisk}");
        }                
    }
}