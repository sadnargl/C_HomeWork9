int First= InputFigureFromConsole ("Введите первое число: ");
int Second = InputFigureFromConsole ("Введите второе число: ");
if (First == -1 | Second == -1)
    { 
    Console.WriteLine ("Число введено с ошибкой");
    System.Environment.Exit (0);
    }
Console.Write ($"{ZumNaturalNumbers (First, Second)}");

int InputFigureFromConsole (string invitation)
{
    Console.Write (invitation);
    int i;
    while (!int.TryParse (Console.ReadLine(), out i))
    {
        Console.WriteLine ("Ошибка ввода числа");
        Console.Write (invitation);
    }
    if (i>=1) {return i;} else {return -1;}
}

int ZumNaturalNumbers (int num1, int num2)
{
    if (num1<=num2) 
    {
        return (num1 + ZumNaturalNumbers (num1+1, num2));
    }
    else
    {
        return 0;
    }
}