// Sum of eleents from M to N
Console.WriteLine("input number M");
int numM = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("input number N");
int numN = Convert.ToInt32(Console.ReadLine());

int SumElements(int numM, int numN)
{
    if (numM <= numN)
        return numM + SumElements(numM + 1, numN);
    else return 0;

}

int result = SumElements(numM, numN);
Console.WriteLine(result);
