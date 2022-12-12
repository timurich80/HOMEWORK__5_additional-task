/* Необязательная к выполнению задача (не будет влиять на итоговую оценку ДЗ)
Дополнительная задача (задача со звёздочкой): Задайте одномерный массив, заполненный случайными числами. 
Из входного массива сформируйте массив с чётными и массив с нечётными значениями элементов входного массива. 
Найдите ср. арифметическое из полученных значений элементов массивов и выведите результат сравнения средних арифметических.
[1,2,3,4] -> средн. арифм. значений элементов массива с чётными числами > средн. арифм. значений элементов с нечётными числами
[2,3,5,7] -> средн. арифм. массива значений элементов с нечётными числами > средн. арифм. значений элементов с чётными числами
[1,2,5,4] -> средн. арифм. значений элементов массива с нечётными числами = средн. арифм. значений элементов с чётными числами 
*/


Console.Clear();
System.Console.WriteLine("Введите длину массива: ");
int arrLngth = Convert.ToInt32(Console.ReadLine());

int[] arr = new int[arrLngth];
FillArray(arr);
PrintArray(arr);
ArithmeticMeanOfEvenElements(arr);

int[] FillArray(int[] array)

{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(1, 100);
    }
    return array;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++) { }
    System.Console.WriteLine($"[{String.Join(",", array)}]");
}

void ArithmeticMeanOfEvenElements(int[] array)
{
    double a = 0;
    double b = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (i % 2 == 0)
        {
            a = a + array[i];
        }
    }
    a = a * 2 / arrLngth;
    System.Console.WriteLine($"средн. арифм. значений элементов массива с чётными числами {a}");



    for (int i = 0; i < array.Length; i++)
    {
        if (i % 2 != 0)
        {
            b = b + array[i];
        }
    }
    b = b * 2 / arrLngth;
    System.Console.WriteLine($"средн. арифм. значений элементов с нечётными числами {b}");
}
