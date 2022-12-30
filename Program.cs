

Console.WriteLine("Enter the first number");
int n1=int .Parse(Console.ReadLine());
Console.WriteLine("Enter the last number");
int n2=int .Parse(Console.ReadLine());

Console.WriteLine("The prime numbers from "+n1+" to "+n2);

for(int i=n1;i<=n2;i++)
{
    int sum = 0;
    int x;
    for ( x = 2; x <= i/2; x++)
    {
        if (i % x == 0)
        {
            sum++;
            
        }
    }
    if (sum == 0 && i != 1)
        Console.WriteLine(i);

}
    


