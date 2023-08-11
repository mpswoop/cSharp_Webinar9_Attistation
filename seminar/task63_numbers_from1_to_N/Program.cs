// input N - output all numbers from 1 to N


Console.WriteLine("Please input first number");
int num1 = Convert.ToInt32(Console.ReadLine());


for (int i = 0; i < num1; i++)
{
    Console.Write(i + 1 + " ");
}
Console.WriteLine("");

string output(int num1)

{
    int temp = 0;
    if (temp < num1)
    {
        return "output(temp+1)";
    }
    else return String.Empty;
}

output(num1);





// Factorial

// int Factorial(int num)
// {
//     if (num == 1)
//         return 1;
//     return num * (Factorial(num - 1));
// }

// int number = Factorial(6);
// Console.WriteLine(number);