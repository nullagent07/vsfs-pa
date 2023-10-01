// See https://aka.ms/new-console-template for more information
using System;

class Program
{
    static void Main()
    {
        // Příklad 1.1: Specifický aritmetický výraz
        int a = 12, b = 5, c = 9;
        int result1 = b * c - a;
        Console.WriteLine($"Výsledek výrazu {b}*{c}-{a} je {result1}");

        // Příklad 1.2: Zbytek po celočíselném dělení bez operátoru %
        int x = 14, y = 3;
        int result2 = x - (x / y) * y;
        Console.WriteLine($"Zbytek po celočíselném dělení čísla {x} číslem {y} je {result2}");

        // Příklad 1.3: Počet čísel menších než 10
        int num1 = 8, num2 = 22, num3 = 10;
        int count = (num1 < 10 ? 1 : 0) + (num2 < 10 ? 1 : 0) + (num3 < 10 ? 1 : 0);
        Console.WriteLine($"Počet čísel s hodnotou menší než 10 je {count}");

        // Příklad 1.4: Největší ze tří čísel
        int numA = 14, numB = 6, numC = 23;
        int max = (numA > numB) ? ((numA > numC) ? numA : numC) : ((numB > numC) ? numB : numC);
        Console.WriteLine($"Nejvyšší z hodnot {numA}, {numB} a {numC} je {max}");

        // Příklad 1.6: Různá čísla
        int numM = 7, numN = 3, numO = 7;
        bool areDifferent1 = (numM != numN) && (numN != numO) && (numM != numO);
        Console.WriteLine($"Hodnoty {numM}, {numN} a {numO} jsou navzájem různé: {areDifferent1}");

        int numP = 25, numQ = 8, numR = 19;
        bool areDifferent2 = (numP != numQ) && (numQ != numR) && (numP != numR);
        Console.WriteLine($"Hodnoty {numP}, {numQ} a {numR} jsou navzájem různé: {areDifferent2}");

        // Příklad 1.7: Lichá vs sudá čísla
        int numS = 9, numT = 2, numU = 6;
        int sumOdd = (numS % 2 == 1 ? numS : 0) + (numT % 2 == 1 ? numT : 0) + (numU % 2 == 1 ? numU : 0);
        int sumEven = (numS % 2 == 0 ? numS : 0) + (numT % 2 == 0 ? numT : 0) + (numU % 2 == 0 ? numU : 0);

        if (sumOdd > sumEven)
        {
            Console.WriteLine("Součet lichých hodnot je vyšší než součet sudých hodnot.");
        }
        else if (sumOdd < sumEven)
        {
            Console.WriteLine("Součet sudých hodnot je vyšší než součet lichých hodnot.");
        }
        else
        {
            Console.WriteLine("Součty lichých a sudých hodnot jsou stejné.");
        }

        // Příklad 1.8: Dělitel čísla
        int numV = 6, numW = 3, numX2 = 8;
        if (numV % numW == 0)
        {
            Console.WriteLine($"Číslo {numW} je dělitelem čísla {numV}.");
        }
        else if (numV % numX2 == 0)
        {
            Console.WriteLine($"Číslo {numX2} je dělitelem čísla {numV}.");
        }
        else
        {
            Console.WriteLine("Žádné číslo není dělitelem jiného čísla.");
        }

        // Příklad 1.9: Sčítance čísla
        int num1_9 = 4, num2_9 = 13, num3_9 = 9;
        if (num1_9 == num2_9 + num3_9 || num2_9 == num1_9 + num3_9 || num3_9 == num1_9 + num2_9)
        {
            Console.WriteLine("Některá čísla jsou součtem zbývajících dvou čísel.");
        }
        else
        {
            Console.WriteLine("Žádná dvě čísla netvoří součet třetího čísla.");
        }

        // Příklad 1.10: Jízdné v MHD
        int vekCestujiciho = 9;
        int jizdne = 0;

        if (vekCestujiciho < 6)
        {
            jizdne = 0;
        }
        else if (vekCestujiciho < 15 || vekCestujiciho >= 60)
        {
            jizdne = 12;
        }
        else
        {
            jizdne = 24;
        }

        Console.WriteLine($"Cestující ve věku {vekCestujiciho} let zaplatí jízdné {jizdne} Kč.");

        // Příklad 1.11: Rychlost na dálnici
        int rychlostAuta = 146;
        int pokuta = 0;

        if (rychlostAuta < 60)
        {
            pokuta = 1000;
        }
        else if (rychlostAuta > 130)
        {
            pokuta = 2000 + ((rychlostAuta - 130) / 5) * 500;
        }

        Console.WriteLine($"Rychlost {rychlostAuta} km/h je pokutována částkou {pokuta} Kč.");
    }
}
