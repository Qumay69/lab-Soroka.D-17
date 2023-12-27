using lab;

int[,] nazvanie = new int[6, 6];
for (int i = 0; i < 6; i++)
{
    for (int j = 0; j < 6; j++)
    {
        Console.Write($"Введите {i},{j}: ");
        nazvanie[i, j] = Convert.ToInt32(Console.ReadLine());
    }

}
Console.WriteLine(lab.Class1.treper(nazvanie));