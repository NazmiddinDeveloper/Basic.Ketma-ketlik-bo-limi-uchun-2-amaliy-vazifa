// BU Master banchidagi Programm.cs faylida 3 dona hamma vazifalar jamlangan yani har bir vazifa uchun alohida shu repositoridan ranch ochilib song ularni har birini masterga  pr qilingan 
// barcha vazifalar alohi alohida branchlarda jamlangan
/*
Basic.Ketma-ketlik bo'limi uchun 2-amaliy vazifa

1. Kalkulyator:
Foydalanuvchidan ikkita raqam va operatsiyani (+, -, *, /) so'raydigan kalkulyator dasturini yozing va keyin operatsiya natijasini chop eting.
*/
Console.WriteLine("1sn number -> input :");
string number1Str = Console.ReadLine();
int number1 = Convert.ToInt32(number1Str);

string operatorStr;
while (true)
{
    Console.WriteLine(" Operator -> input :");
    operatorStr = Console.ReadLine();

    switch (operatorStr)
    {
        case "+":
            break;
        case "-":
            break;
        case "*":
            break;
        case "/":
            break;
        default:
            Console.WriteLine("Please type (+ or - or * or /)");
            continue;
    }
    break;

}
/*
2. Raqamlar qatorining yig‘indisini hisoblash:
Foydalanuvchidan N musbat butun sonni so‘ragan, so‘ngra 1 dan N gacha bo‘lgan barcha sonlar yig‘indisini hisoblab, natijani ekranga chiqaradigan dastur tuzing.

*/

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
