using Ap_Dev_L_1;
using System.Globalization;
using System.Security.Cryptography.X509Certificates;


class Program
{
    static void Main()
    {
        var woman = new Woman("Анна", DateTime.Parse("01.01.1990"));
        var man = new Man("Олег", DateTime.Parse("01.01.1990"));
        var sister = new Sister("Катюха", DateTime.Parse("01.01.2006"));
        var brother = new Brother("Кирилл", DateTime.Parse("01.01.2000"));
        string h = "___";
        for(int i =0; i < 4; i++)
        {
            h+=h;
        }
        
        woman.Print();
        woman.PutMakeup();
        woman.RemoveMakeup();
        Console.WriteLine(h);
        man.Print();
        man.Shave();
        Console.WriteLine(h);
        sister.Print();
        sister.HelpsWithCleaning();
        Console.WriteLine(h);
        brother.Print();
        brother.Shave();
        brother.HelpWithTraining();
        Console.WriteLine(h);

    }
}