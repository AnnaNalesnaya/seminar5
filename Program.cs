// Задача 34: Задайте массив заполненный случайными положительными 
//трёхзначными числами. Напишите программу, которая покажет 
//количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2

int Prompt(string message)
{
    Console.ForegroundColor=ConsoleColor.White;
    System.Console.Write(message);
    string input = System.Console.ReadLine();
    int result = int.Parse(input);
    return result;
}
int [] ArreyFill(int size)
{
    int i = 0;
    int [] arrey = new int [size];
    while (i<size)
    {
        arrey[i] = new Random().Next (99, 1000);
        i++;
    }
    return arrey;
}
void PrintArrey(int[] arrey)
{
    System.Console.Write("[");
    for (int i = 0; i < arrey.Length; i++)
    {
        System.Console.Write(arrey[i]);
        if (i < arrey.Length - 1)
        {
            System.Console.Write(" , ");
        }
    }
    System.Console.Write("]");
}
int EvenNumberSounter(int[] array)
{
    int evenCount = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        {
          evenCount++;  
        }       
    }
      return evenCount;
}
int sizeArray = Prompt("введите размер массива: ");
for (int i = 0; i < 4; i++)
{
    int[] newArray = ArreyFill(sizeArray);
    PrintArrey(newArray);
    System.Console.Write("-> ");
    System.Console.WriteLine(EvenNumberSounter(newArray));
}

