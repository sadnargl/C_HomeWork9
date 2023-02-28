int First= InputFigureFromConsole ("Введите первое число: ");
int Second = InputFigureFromConsole ("Введите второе число: ");
if (First == -1 | Second == -1)
    { 
    Console.WriteLine ("Число введено с ошибкой");
    System.Environment.Exit (0);
    }
Console.Write ($"{AkkermanFunction (First, Second)}");

int InputFigureFromConsole (string invitation)
{
    Console.Write (invitation);
    int i;
    while (!int.TryParse (Console.ReadLine(), out i))
    {
        Console.WriteLine ("Ошибка ввода числа");
        Console.Write (invitation);
    }
    return i;
}

int AkkermanFunction (int n, int m)
{
    if (n==0) 
    {
        return m+1;
    }
    else
    {
       if (m==0) 
       {
            return (AkkermanFunction (n-1, 1));
       }
       else
       {
         return (AkkermanFunction (n-1, AkkermanFunction (n, m-1)));
       }
    }
}