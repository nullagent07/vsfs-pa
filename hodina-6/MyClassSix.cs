namespace HodinaSix
{
    public class MyClassSix {
        int LetterCount(string str) {
            HashSet<char> uniqLetter = new HashSet<char>();
            
            foreach( char c in str ){
                if (Char.IsLetter(c) && ((c >= 'A' && c <= 'Z') || (c >= 'a' && c <= 'z'))) {
                    uniqLetter.Add(c);
                }
            }

            return uniqLetter.Count;
        }

        int Compare(string s1, string s2) {
            char[] charS1 = s1.ToCharArray();
            char[] charS2 = s2.ToCharArray();

            int length = Math.Min(charS1.Length, charS2.Length);

            for (int i = 0; i < length; i++) {
                if(charS1[i] != charS2[i]) {
                    return charS1[i] - charS2[i];
                }
            }

            return charS1.Length - charS2.Length;
        }

        int IndexOf(string s1, string s2, int start = 0) {
            char[] charS1 = s1.ToCharArray();
            char[] charS2 = s2.ToCharArray();

            if(charS2.Length == 0) 
                return start;

            for(int i = start; i < charS1.Length; i++) {                                
                int j = 0;                                   
                int saveIndex = i;                                        
                
                while ( charS1[saveIndex] == charS2[j] ){
                    if( j == charS2.Length - 1) {
                        return i;
                    } else {                        
                        j++;
                        saveIndex++;
                    }
                }
            }

            return -1;
        }

        string Insert(string s1, int index, string s2) 
        {
            if (string.IsNullOrEmpty(s2))
                return s1;

            char[] charS1 = s1.ToCharArray();            

            char[] firstPart = new char[index];
            char[] secondPart = new char[charS1.Length - index];

            Array.Copy(charS1, 0, firstPart, 0, index);
            Array.Copy(charS1, index, secondPart, 0, charS1.Length - index);

            string resStrFirst = new string(firstPart);
            string resStrEnd = new string(secondPart);
            string resStrAdd = new string(s2);
            
            return $"{resStrFirst}{resStrAdd}{resStrEnd}";            
        }

        void Priklad_6_3() {            
            Console.WriteLine("Příklad 6.1 ");
            int _6_1 = LetterCount("привет мое имя John ");
            Console.WriteLine(_6_1);
            Console.WriteLine("");

            Console.WriteLine("Příklad 6.3 (a)");
            string str1 = "hello";
            string str2 = "hello";
            string str3 = "h";
            string str4 = "hello";
            string str5 = "helл";
            string str6 = "hello";
            int _6_3_a_1 = Compare(str1, str2);
            int _6_3_a_2 = Compare(str3, str4);
            int _6_3_a_3 = Compare(str5, str6);
            Console.WriteLine(_6_3_a_1);
            Console.WriteLine(_6_3_a_2);
            Console.WriteLine(_6_3_a_3);
            Console.WriteLine("");

            Console.WriteLine("Příklad 6.3 (b)");
            string str7 = "hello woworldrld";
            string str8 = "lo wow";            
            int _6_3_b_1 = IndexOf(str7, str8);
            Console.WriteLine(_6_3_b_1);
            Console.WriteLine("");

            Console.WriteLine("Příklad 6.3 (d)");
            string str9 = "hello world!";
            string str10 = "0x6edfdd ";            

            string _6_3_d_1 = Insert(str9, 6, str10);
            Console.WriteLine(_6_3_d_1);                        

        }

        public void RunExample () {
            Console.WriteLine("");            
            Priklad_6_3();
        }
    }
}