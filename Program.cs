// See https://aka.ms/new-console-template for more information
using System;
using System.Globalization;
using Hodina0ne;
using HodinaTwo;
using HodinaThree;



class Program
{
    static void Main() {   

        RunExampleCode(3);


        // bool status = true;

        // while (status) {
        //     Console.WriteLine("Zadejte cislo nebo 'exit' :");            
        //     string input = Console.ReadLine();
        //     if ( input == "exit" ) {
        //         status = false;
        //     } else {
        //         if ( int.TryParse( input, out int number)) {
        //             RunExampleCode(number);
        //         } else {
        //             Console.WriteLine("Zadejte cislo");
        //         }
        //     }
        // }        

    }

    static void RunExampleCode (int number) {
        switch (number) {
            case 1 : 
                MyClassOne hodina_one = new MyClassOne();
                hodina_one.RunExample();
                break;
            case 2 :
                MyClassTwo hodina_two = new MyClassTwo();
                hodina_two.RunExample();
                break;
            case 3 : 
                MyClassThree hodina_three = new MyClassThree();
                hodina_three.RunExample();
                break;
            case 4 :
            
                break;
            case 5 : 

                break;
            case 6 :
            
                break;
            case 7 :

                break;
            case 8 :

                break;
        }
    }
}
