int N = 0;
while (N <= 0){
    System.Console.WriteLine(" Musbat son kiriting : ");
    string nStr = Console.ReadLine();
    N = Convert.ToInt32(nStr);
}

int yigindi = 0;
for (int i = 0; i <= N; i++){
    yigindi += i;
}

System.Console.WriteLine($" Output : {yigindi}");
