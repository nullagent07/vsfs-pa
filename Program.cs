// See https://aka.ms/new-console-template for more information
using System;
using System.Globalization;
using Hodina0ne;
using HodinaTwo;
using HodinaThree;
using HodinaFour;
using HodinaFive;
using HodinaSix;


class Program
{
    static void Main() {   
        bool status = true;

        while (status) {
            Console.Write("Zadejte cislo nebo 'exit': ");            
            string? input = Console.ReadLine();
            if ( input == "exit" ) {
                status = false;
            } else {
                if ( int.TryParse( input, out int number)) {
                    RunExampleCode(number);
                }
            }
        }        

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
                MyClassFour hodina_fout = new MyClassFour();
                hodina_fout.RunExample();
                break;
            case 5 : 
                MyClassFive hodina_five = new MyClassFive();
                hodina_five.RunExample();
                break;
            case 6 :
                MyClassSix hodina_six = new MyClassSix();
                hodina_six.RunExample();
                break;
            case 7 :

                break;
            case 8 :

                break;
        }
    }
}
