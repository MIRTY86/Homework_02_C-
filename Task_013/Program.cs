string message1 = "Введите первое число : ";
string message2 = "Введите второе число : ";
int startNum = CheckNumber(message1);
int finihNum = CheckNumber(message2);

int res = SumNumbers(startNum, finihNum);
System.Console.WriteLine($"M = {startNum}; N =  {finihNum}  --> {res}");

int CheckNumber(string mes)
{
    int num = 0;
    while (true)
    {
        try
        {
            System.Console.WriteLine(mes);
            num = int.Parse(Console.ReadLine() ?? "");
            break;
        }
        catch (Exception error)
        {
            System.Console.WriteLine("Неверный формат данных! " + error.Message);
        }

    }
    return num;
}

int SumNumbers(int firstNum, int secondNum)
{
    int result = 0;
    if (firstNum > secondNum) 
    {
        Console.WriteLine("Нарушена логика программы, введите верный интервал.");
        return 0;
    }
    if (firstNum <= secondNum)
    {
        result = firstNum + SumNumbers(firstNum + 1, secondNum);
    }
    return result;
}
