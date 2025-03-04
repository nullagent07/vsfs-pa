namespace HodinaFive 
{
    public class MyClassFive {

        public void SelectSort (int[] arr) {
            
            for (int i = 0; i < arr.Length-1; i++) {
                int indexMax = i;
                for (int j = i+1; j < arr.Length; j++) {
                    if(arr[j] > arr[indexMax]) {
                        indexMax = j;
                    }
                }

                int temp = arr[indexMax];
                arr[indexMax] = arr[i];
                arr[i] = temp;
            }

            foreach (int el in arr) {
                Console.Write($"{el} ");
            }
            Console.WriteLine(" ");          
        }

        public void InsertSort (int[] arr) {
            for(int i = 1; i < arr.Length; i++) {
                int current = arr[i];
                int j = i - 1;
                
                while( j >= 0 &&  arr[j] < current ) {
                    Console.WriteLine($"index j [{j}] : {arr[j]}");
                    Console.WriteLine($"index i [{i}] : {current}");  
                    Console.WriteLine($" ");  
                    arr[j+1] = arr[j];  
                    j--;
                }              
                arr[j+1] = current;                
            }

            foreach (int el in arr) {
                Console.Write($"{el} ");
            }
            Console.WriteLine(" ");
        }

        public void BubbleSort (int[] arr) {
            for(int i = 0; i < arr.Length-1; i++) {
                for(int j = 0; j < arr.Length-i-1; j++) {
                    if(arr[j] < arr[j+1]){
                        int temp = arr[j];
                        arr[j] = arr[j+1];
                        arr[j+1] = temp;
                    }
                }
            }
            foreach (int el in arr) {
                Console.Write($"{el} ");
            }
            Console.WriteLine(" ");
        }
        
        void Priklad_5_3 () {
            int[] pole = { 5, 7, 1, 5, 6, 8, 9, 0, 1, 2};
            SelectSort(pole);
            InsertSort(pole);
            BubbleSort(pole);


        }
        public void RunExample() {
            Priklad_5_3();            
        }
    }
}