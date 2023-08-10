// See https://aka.ms/new-console-template for more information
Console.WriteLine("input number M");
int numM = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("input number N");
int numN = Convert.ToInt32(Console.ReadLine());

string Numbers(int numM, int numN)

{
    if (numM <= numN)
    
        return $"{numM} " + Numbers(numM+1,numN);
    
    else return string.Empty;
}
Console.WriteLine(Numbers(numM, numN));


