// ackermann function
Console.WriteLine("input number M");
int numM = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("input number N");
int numN = Convert.ToInt32(Console.ReadLine());

int Ackerman(int numM, int numN)
{
    if (numM == 0)
        return numN + 1;
    else if (numN == 0)
        return Ackerman(numM - 1, 1);
    else
        return Ackerman(numM - 1, Ackerman(numM, numN - 1));

}

int result = Ackerman(numM, numN);
Console.WriteLine(result);
