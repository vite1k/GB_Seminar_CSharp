/*
int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size];

    for(int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(minValue, maxValue + 1);
    }   
    return array;
}

void WriteArray(int[] array)
{
    Console.Write("[ ");

    for(int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }    

    Console.Write("]");
}

void ReverseArray(int[] array)
{
    for (int i = 0, j = array.Length - 1; i < j; i++, j--)
    {
        int temp = array[i];
        array[i] = array[j];
        array[j] = temp;
    }
}

Console.Clear();

Console.Write("Введите количество элементов: ");
int lenght = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите минимальное возможное значение: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимальное возможное значение: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateRandomArray(lenght, min, max);
WriteArray(myArray);
ReverseArray(myArray);
Console.Write($" -> ");
WriteArray(myArray);
*/

/*
Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник с сторонами такой длины.
*/
/*
bool CheckTriangle(int a, int b, int c)
{
    if(a + b > c && a + c > b && b + c > a)
    {
        return true;
    }
    else
    {
        return false;
    }
}

Console.Write("Введите длину a: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите длину b: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите длину c: ");
int c = Convert.ToInt32(Console.ReadLine());

bool result = CheckTriangle(a,b,c);
Console.WriteLine(result);
*/
/*
Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: a и b.
*/
/*
int[] Fibonachi(int a, int b, int size)
{
    int[] array = new int[size];

    array[0] = a;
    array[1] = b;

    for (int i = 2; i < size; i++)
    {
        array[i] = array[i - 1] + array[i - 2];
    }
    return array;
}

void WriteArray(int[] array)
{
    Console.Write("[ ");

    for(int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }    

    Console.Write("]");
}

Console.Write("Введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество чисел к выводу: ");
int n = Convert.ToInt32(Console.ReadLine());

int[] result = Fibonachi(a,b,n);

WriteArray(result);
*/
/*
Напишите программу, которая будет создавать копию заданного массива с помощью поэлементного копирования.
*/
/*
int[] CreateRandomArray(int size)
{
    int[] array = new int[size];

    for(int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(1, 100 + 1);
    }   
    return array;
}

void WriteArray(int[] array)
{
    Console.Write("[ ");

    for(int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }    

    Console.Write("]");
}

int[] ArrayCopy(int[] array)
{
    int[] arrCopy = new int[array.Length];

    for (int i = 0; i < array.Length; i++)
    {
        arrCopy[i] = array[i];
    }
    return arrCopy;
}

Console.Clear();

Console.Write("Введите количество элементов: ");
int lenght = Convert.ToInt32(Console.ReadLine());


int[] myArray = CreateRandomArray(lenght);
WriteArray(myArray);
int[] NewMyArray = ArrayCopy(myArray);
Console.WriteLine();
WriteArray(NewMyArray);
*/