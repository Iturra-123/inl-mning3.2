
using System;

class Program
{
    static void Main()
    {
        Console.Write("Har du gått ut gymnasiet? (j/n): ");
        char harGottUtGymnasiet = char.ToLower(Console.ReadKey().KeyChar); 
        Console.WriteLine(); 

       
        Console.Write("Hur gammal är du? ");
        int ålder = int.Parse(Console.ReadLine());

        if (harGottUtGymnasiet == 'j' && ålder < 22)
        {
            Console.WriteLine("Vi vill gärna anställa dig");
        }
        else
        {
            Console.WriteLine("Vi letar tyvärr efter annan personal just nu");
        }
    }
}
