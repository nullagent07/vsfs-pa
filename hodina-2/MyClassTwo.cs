using System;
using System.Globalization;
using System.Net;

using Priklad_2_1_NameSpace;
using Priklad_2_2_NameSpace;
using Priklad_2_3_NameSpace;
using Priklad_2_5_NameSpace;


namespace HodinaTwo
{
    public class MyClassTwo {        
        public void RunExample() {  
            Priklad_2_1 priklad_2_1 = new Priklad_2_1();
            priklad_2_1.Run();

            Priklad_2_2 priklad_2_2 = new Priklad_2_2();
            priklad_2_2.Run();

            Priklad_2_3 priklad_2_3 = new Priklad_2_3();
            priklad_2_3.Run();

            Priklad_2_5 priklad_2_5 = new Priklad_2_5();
            priklad_2_5.Run();
        }
    }   
}