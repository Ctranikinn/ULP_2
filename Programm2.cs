using System;
try
{
    string Path1 = @"C:\Users\Ctranikinn\source\repos\ConsoleApp1C#\File1.txt", Path2 = @"C:\Users\Ctranikinn\source\repos\ConsoleApp1C#\File2.txt";
    Random r = new Random();
    for (int i = 0; i < 20; i++)
    {
        if (i == 0)
        {
            await File.WriteAllTextAsync(Path1, $"{(r.Next(-100,100)).ToString()}\n");
        }
        else
        {
            await File.AppendAllTextAsync(Path1, $"{(r.Next(-100,100)).ToString()}\n");
        }
    }
    var Numbs = File.ReadAllLines(Path1);
    double[] Numbs_int = new double[Numbs.Length];
    double otricatelnoe=0, desytoe=0;
    for (int i = 0; i < Numbs.Length; i++)
    {
        Numbs_int[i] = double.Parse(Numbs[i]);
        if (Numbs_int[i] < 0 && otricatelnoe==0)
        {
            otricatelnoe = Numbs_int[i];
        }
        if (i == 9)
        {
            desytoe = Numbs_int[i];
        }
    }
    for (int i = 0; i < Numbs_int.Length; i++)
    {
        Numbs_int[i] = Numbs_int[i] / ((desytoe + otricatelnoe) / 2);
        Numbs[i] = Numbs_int[i].ToString();
    }
    for (int i = 0; i < Numbs.Length; i++)
    {
        if (i == 0)
        {
            await File.WriteAllTextAsync(Path2, $"{Numbs[i]}\n");
        }
        else
        {
            await File.AppendAllTextAsync(Path2, $"{Numbs[i]}\n");
        }
    }
}
catch(Exception e)
{
    Console.WriteLine(e);
}
