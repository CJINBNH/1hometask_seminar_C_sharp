Console.Clear();
Console.WriteLine("Введите любое целое число: ");
int N = Convert.ToInt32(Console.ReadLine());
int count = 2;
while (count < N)
{
    Console.Write(count);
    Console.Write(" ");
    count += 2;
}