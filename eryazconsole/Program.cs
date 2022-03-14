
using System;
class Program
{
    /*
    1'den 100'e kadar olan sayıları bir listeye/diziye ekleyen ve bu listeyi geri dönen bir
    program/metot/fonksiyon hazırlanacak. Eğer sayı 4 veya 4'ün katı ise, sayı yerine “ER”; eğer
    7 veya 7'nin katları ise sayı yerine “YAZ”; eğer hem 4'ün hem de 7'nin katı ise sayı yerine
    “ERYAZ” eklenmelidir.
    */
    private static int multiplesOffour = 4;
    private static int multiplesOfSeven = 7;
    private static int zero = 0;

 
    static void Main()
    { 
            var numberList = Enumerable.Range(1, 100).ToArray();

            foreach (var item in numberList)
            {
                if(CheckContains( item))
                {
                 ErYaz();
                }
                
                else if (CheckMultiplesOfFour(item))
                {
                    Er();
                }
                else if (CheckMultiplesOfSeven(item))
                {
                    Yaz();
                }
                else
                {
                  Console.WriteLine(item.ToString());
                } 
             } 
    }

     static bool CheckContains(int item)
    {
        return (item % multiplesOffour == zero & item % multiplesOfSeven == zero);

    }

     static bool CheckMultiplesOfFour(int item)
    {
        return (item % multiplesOffour == zero);

    }
    private static bool CheckMultiplesOfSeven(int item)
    {
        return (item % multiplesOfSeven == zero);

    }
    static void Er()
    {
        Console.WriteLine("ER");
    }
    static void Yaz()
    {
        Console.WriteLine("YAZ");
    }
    static void ErYaz()
    {
        Console.WriteLine("ERYAZ");
    }
}