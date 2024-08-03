int N = 0;
while (N <= 0)
{
    Console.WriteLine("Musbat son kiriting : ");
    string nStr = Console.ReadLine();
    N = Convert.ToInt32(nStr);
}

int yigindi = 0;
for(int i = 1; i <= N; i++)
{
    yigindi += i;
}

Console.WriteLine($" Output : {yigindi}");