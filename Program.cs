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

Console.WriteLine("2nd number -> input :");
string number2Str = Console.ReadLine();
int number2 = Convert.ToInt32(number2Str);

switch (operatorStr)
{
    case "+":
        Console.WriteLine($" output : {number1 + number2}");
        break;
    case "-":
        Console.WriteLine($" output : {number1 - number2}");
        break;
    case "*":
        Console.WriteLine($" output : {number1 * number2}");
        break;
    case "/":
        Console.WriteLine($" output : {number1 / number2}");
        break;
}   

