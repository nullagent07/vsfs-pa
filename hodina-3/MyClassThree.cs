using System;
namespace HodinaThree 
{
    public class MyClassThree {
        enum Volba { Kamen = 1, Nuzky, Papir };
        struct Data {
            public int day;
            public int month;
            public int year;

        }

        static Volba? GetVolbaEnum ( object name ) {
            if( name is string ) {
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

            if( name is int) {
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

        static Data NasledneDatum ( Data data, int daysAfter) {
            DateTime start = new DateTime(data.year, data.month, data.day);
            DateTime end = start.AddDays(daysAfter);

            return new Data { day = end.Day, month = end.Month, year = end.Year};

        } 
        public void Priklad_3_6() {            
            Console.WriteLine("Vitejte ve hre kamen – nuzky – papir");
            Console.WriteLine("Hrajeme na dve vitezna kola");
            int hrac = 0;
            int pocitac = 0;

            while (hrac < 2 && pocitac < 2) {                    
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
        
        public void Priklad_3_7() {            
            Data date = new Data {
                day = 16,
                month = 7,
                year = 2015
            };
            Data dateAfter =  NasledneDatum(date, 500);
            Console.WriteLine($"{dateAfter.day} {dateAfter.month} {dateAfter.year} ");            
        }
        // public 
        public void RunExample() {
            Console.WriteLine("");
            Console.WriteLine("Priklad 3.6");
            Priklad_3_6();
            Console.WriteLine(""); 
            Console.WriteLine("Priklad 3.7"); 
            Priklad_3_7();
        }
    }
}
