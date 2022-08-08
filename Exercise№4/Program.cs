Console.Write("Введите любое число ");
int number = Convert.ToInt32(Console.ReadLine());
int StartNumber = 2;

if (number < 0)
{
    Console.WriteLine("Ошибка, введите число > 0");
}

while (StartNumber <= number)
{
    Console.Write(StartNumber + " ");
    StartNumber = StartNumber + 2;
}