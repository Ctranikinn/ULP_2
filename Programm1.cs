using System;
try
{
    string Path1 = @"C:\Users\Ctranikinn\source\repos\ConsoleApp1C#\File3.txt";
    var Numbs = File.ReadAllText(Path1);
    char[] malenkie = new char[26];
    char[] bolshie = new char[26];
    int[] sum = new int[26];
    for (int i = 0; i < 26; i++)
    {
        bolshie[i] = Convert.ToChar(65 + i);
        malenkie[i] = Convert.ToChar(97 + i);
        sum[i] = 0;
    }
    for (int i = 0; i<Numbs.Length; i++)
    {
        for (int j = 0; j < 26; j++)
        {
            if (Numbs[i] == malenkie[j] || Numbs[i] == bolshie[j])
            {
                sum[j]++;
            }
        }
    }
    for (int i = 0; i < 26; i++)
    {
        Console.WriteLine($"{sum[i]} - {bolshie[i]}");
    }

}
catch (Exception e)
{
    Console.WriteLine(e);
}
