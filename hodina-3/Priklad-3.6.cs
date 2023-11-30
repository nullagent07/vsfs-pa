namespace Priklad_3_6_NameSpace {
    class Priklad_3_6 {
        enum Volba { Kamen = 1, Nuzky, Papir };
        static Volba? GetVolbaEnum ( object name ) {
            if( name is string ) 
            {
                switch ( name ) {
                    case "kamen":
                        return Volba.Kamen;  
                    case "nuzky":
                        return Volba.Nuzky;
                    case "papir":
                        return Volba.Papir;
                    case 1:
                        return Volba.Kamen;                    
                }            
            }   

            if( name is int) 
            {
                switch ( name ) {
                    case 1:
                        return Volba.Kamen;  
                    case 2:
                        return Volba.Nuzky;
                    case 3:
                        return Volba.Papir;                                        
                }            
            }     

            Console.WriteLine("Tento tah je neplatny");
            return null;   
        }        
        public void Run() {            
            Console.WriteLine("Vitejte ve hre kamen – nuzky – papir");
            Console.WriteLine("Hrajeme na dve vitezna kola");
            int hrac = 0;
            int pocitac = 0;

            while (hrac < 2 && pocitac < 2) 
            {                    
                Console.Write("Zadejte svuj tah: ");

                string? input = Console.ReadLine().ToLower();
                Volba? a;                

                if(int.TryParse(input, out int number))
                    a = GetVolbaEnum(number);
                else 
                    a = GetVolbaEnum(input);            

                Random random = new Random();
                Volba? b = GetVolbaEnum(random.Next(1, 4));                                      
                
                if ( a != null && b != null )
                    if (a > b) 
                        hrac++;
                    else                                         
                        pocitac++;

                    Console.WriteLine($"Hrac zahral {a}, pocitac zahral {b}");
                    Console.WriteLine($"Celkove skore: hrac {hrac}  – pocitac {pocitac}");       
            }        

            Console.WriteLine($"Celou hru vyhral {(hrac > pocitac ? "hrac" : "pocitac")}");  
        }   
    }
}