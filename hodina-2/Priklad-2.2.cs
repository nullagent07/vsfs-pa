namespace Priklad_2_2_NameSpace {
    class Priklad_2_2 {
        public int[] CreateAndFillArray() {
            int[] arr = new int[ 3 ];
            int count = 0;               
            while ( count < arr.Length ) {            
                Console.Write($"Zadej {count+1} cislo: "); 
                string? input = Console.ReadLine();             
                if(int.TryParse( input, out int number))  
                {
                    arr[count] = number;
                    count++;
                }                                   
            }                                                                   
            Array.Sort(arr);  
            foreach (int i in arr) {
                Console.Write(i + " ");
            }          
            Console.WriteLine("");                                            
            return arr;
        }

        public void Run() {
            CreateAndFillArray();
        }
        
    }
}