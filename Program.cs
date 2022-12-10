Console.WriteLine("Введите первое граничное значение: ");
int M = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе граничное значение: ");
int N = Convert.ToInt32(Console.ReadLine());
int num = 1;
void NaturalNum(int num)
{
        if(num % 3 == 0)
        {
            Console.Write(num + " ");
        }
        num++;
    if(num > N) 
    return;
    NaturalNum(num);
}
NaturalNum(num);