// Simple Code Main Menu by OGBLEXX (language Polish)
internal class Program
{
    private static void Main(string[] args)
    {
        
        Console.WriteLine("Menu Wyboru");
        Console.WriteLine();
        Console.WriteLine("1 - Przejdz do Kalkulatora");
        Console.WriteLine("2 - Przejdz do Pytan");
        Console.WriteLine("3 - Wyjdz");
        Console.WriteLine();
        Console.WriteLine("Wpisz Wybrana Cyfre Ponizej");
        var OptionsMenu = Console.ReadLine();

        var oneOption = 1;
        var twoOption = 2;
        var threeOption = 3;


        if (oneOption.ToString() == OptionsMenu)
        {
            Console.WriteLine("Kalkulator B)");
        }
        if (twoOption.ToString() == OptionsMenu)
        {
            Console.WriteLine("Pytania");
        }
        if (threeOption.ToString() == OptionsMenu) 
        {
            Console.Clear();
        }
    }
}
