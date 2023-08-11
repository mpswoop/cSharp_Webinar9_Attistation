// input number 
// output sum of digits

Console.WriteLine("Please input Number");
int num = Convert.ToInt32(Console.ReadLine());

int SumDigits(int num)
{
    if (num == 0 ) return 0;

    return num % 10 + SumDigits(num / 10);

}

int sum = SumDigits(num);

Console.WriteLine(sum);