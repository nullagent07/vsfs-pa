using System;
using System.Globalization;
using System.Net;

namespace HodinaTwo
{
    public class MyClassTwo {
        int a;
        int b;
        string? input;
        public int[] CreateAndFillArray( int arrLen ) {
            int[] arr = new int[ arrLen ];
            int count = 0;

            Console.WriteLine("Setridime " + arrLen + " cisla sestupne");
            while ( count < arrLen ) {             
                Console.WriteLine("Zadejte " + (count + 1) + " cislo");   
                string? input = Console.ReadLine();                
                if(int.TryParse( input, out int number)) {
                    arr[count] = number;
                    count++;
                }              
            }

            if ( arrLen == 2) {
                Array.Sort(arr);
                Array.Reverse(arr);                
            } 
            if ( arrLen ==  3 ) {
                Array.Sort(arr);
            }

            Console.Write("Setridena cisla jsou ");
            foreach ( int el in arr ) {
                    Console.Write(el + " ");                    
            }
            Console.WriteLine();

            return arr;
        }
        
        public int findNOD (int a, int b) {
            while( b != 0 ) {
                int temp = b;
                b = a % b;
                a = temp;
            }

            return a;
        }

        public void Priklad_2_1 () {
            Console.WriteLine("Příklad 2.1");
            CreateAndFillArray(2);                                  
        }
        
        public void Priklad_2_2 () {
            Console.WriteLine("Příklad 2.2");
            CreateAndFillArray(3);
        }

        public void Priklad_2_3 () {
            Console.WriteLine("Příklad 2.3");
            Console.Write("Vsechna dvojciferna cisla jsou: ");
            for(int i = 10; i < 100; i++) {
                if( i != 99) {
                    Console.Write(i + " ");
                } else {
                    Console.WriteLine(i);
                }                
            }
        }

        public void Priklad_2_5 () {
            Console.WriteLine("Příklad 2.5");            
            while(true) {
                Console.Write("Zadej prvni cislo: ");
                input = Console.ReadLine();
                
                if(int.TryParse(input, out int number)){
                    a = number;
                    break;
                } else {
                    Console.WriteLine("Spatne cislo");
                }
            }

            while(true) {
                Console.Write("Zadej druhe cislo: ");
                input = Console.ReadLine();
                
                if(int.TryParse(input, out int number)){
                    b = number;
                    break;
                } else {
                    Console.WriteLine("Spatne cislo");
                }
            }

            int nor = findNOD(a, b);
            int nsn = (a * b)/nor;
            Console.WriteLine("Nejmensi spolecny nasobek je " + nsn);
        }

        public void RunExample() {
            Priklad_2_1();
            Priklad_2_2();
            Priklad_2_3();
            Priklad_2_5();
        }
    }   
}