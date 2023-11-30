using System;

namespace Priklad_3_7_NameSpace 
{
    class Priklad_3_7 
    {
        struct Data {
            public int day;
            public int month;
            public int year;

        }
         static Data NasledneDatum ( Data data, int daysAfter) {
            DateTime start = new DateTime(data.year, data.month, data.day);
            DateTime end = start.AddDays(daysAfter);

            return new Data { day = end.Day, month = end.Month, year = end.Year};

        } 
       
        public void Run () 
        {
           Console.WriteLine("Priklad 3.7");
            Data date = new Data {
                day = 16,
                month = 7,
                year = 2015
            };
            Data dateAfter =  NasledneDatum(date, 500);
            Console.WriteLine($"{dateAfter.day} {dateAfter.month} {dateAfter.year} ");
            Console.WriteLine("");  
        }        
    }
}