// A power of B using recursion

Console.WriteLine("please input number A");
int numA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("please input number B");
int numB = Convert.ToInt32(Console.ReadLine());

int PowerOf(int numA, int numB)
{
    if (numB == 0) return 1;

    return numA * PowerOf(numA, numB - 1);

}

int result = PowerOf(numA, numB);
Console.WriteLine(result);