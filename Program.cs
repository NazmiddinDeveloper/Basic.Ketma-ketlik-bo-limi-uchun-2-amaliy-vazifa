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

