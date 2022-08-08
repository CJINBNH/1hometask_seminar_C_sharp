Console.Clear();
Console.WriteLine("Введите первое число: ");
int firstNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int secondNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье число: ");
int thirdNumber = Convert.ToInt32(Console.ReadLine());
int max = firstNumber;
//нужно сравнить два числа и вывести большее
if (max < secondNumber)
{
    max = secondNumber;
    Console.Write("max = ");
}
if (max < thirdNumber)
{
    max = thirdNumber;
    Console.Write("max = ");
}
Console.WriteLine(max);