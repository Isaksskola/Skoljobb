/*
int a;
for(a = 200; a <20000; a = a - 100;)
    {
    Console.Beep(a, 500);
}
*/

using System;


    try
    {
    Console.WriteLine("Ange önskad frekvens (noll 0 avslutar): ");
    int frekvens = int.Parse(Console.ReadLine());
    while (frekvens != 0)
        {
            Console.Beep(frekvens, 2000);
            Console.WriteLine("Ange önskad frekvens (noll 0 avslutar): ");
            frekvens = int.Parse(Console.ReadLine());
        }
    }
    catch {
        Console.WriteLine("Felaktig frekvens. Försök igen. Frekvens skall ligga mellan 37 och 32767");
        Console.WriteLine("Ange önskad frekvens (noll 0 avslutar): ");
        int frekvens = int.Parse(Console.ReadLine());
    }




