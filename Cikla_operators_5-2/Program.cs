using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Ievadiet sākotnējo summu: ");
        double saktotnejaSumma = double.Parse(Console.ReadLine());

        Console.Write("Ievadiet noguldījuma laiku (gadi): ");
        int laiks = int.Parse(Console.ReadLine());

        Console.Write("Ievadiet procentu likmi (gada procentos): ");
        double procentuLikme = double.Parse(Console.ReadLine());

        for (int gads = 1; gads <= laiks; gads++)
        {
            saktotnejaSumma += saktotnejaSumma * (procentuLikme / 100);
            Console.WriteLine($"Pēc {gads}. gada: {saktotnejaSumma:C}");
        }

        Console.WriteLine($"Noguldījuma beigu summa pēc {laiks} gadiem ir {saktotnejaSumma:C}");
    }
}
