// input N - output all numbers from M to N

// Console.WriteLine("Please input number M");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Please input number N");
// int n = Convert.ToInt32(Console.ReadLine());

// string Numbers(int m, int n)
// {
//     if (m <= n)
//     {
//         return $"{m} " + Numbers(m+1,n);
//     }
//     else return string.Empty;
// }
// Console.WriteLine(Numbers(m,n));



Console.WriteLine("Please input number N");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Please input number M");
int m = Convert.ToInt32(Console.ReadLine());


string output(int m, int n)

{
    int max = 0;
    int min = 0;

    if (n > m)
    {
        max = n;
        min = m;
    }
    else
    {
        max = m;
        min = n;
    }

    Console.Write(min + " ");


    if (max > min)
    {
        return output(min + 1, max);
        // return $"{m} " + output(min+1, max);
    }

    else return String.Empty;
}


output(m, n);
Console.WriteLine();


