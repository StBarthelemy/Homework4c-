//Задача 25: Напишите цикл, который принимает на вход 2 числа (А и B) и возводит число А в натуральную степень B.
//3,5 ->243
//2,4-> 16


Console.WriteLine ("Введите первое число");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("Введите второе число");
int number2 = Convert.ToInt32(Console.ReadLine());


Sum(number1, number2);

void Sum(int a, int b)
{
    int result = 1;
    for (int i = 1; i <= b; i++)
    {
        result = result * a;
    }
    Console.WriteLine(result);
}


//Задача 27 Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
//452 -> 11;  82 -> 10;  9012 -> 12   

int number = ReadInt("Введите число: ");
int len = NumberLen(number);
SumNumbers(number, len);
int NumberLen(int a)
{
    int index = 0;
    while (a > 0)
    {
        a /= 10;
        index++;
    }
    return index;
}
void SumNumbers(int n, int len)
{
    int sum = 0;
    for (int i = 1; i <= len; i++)
    {
        sum += n % 10;
        n /= 10;
    }
    Console.WriteLine($"Cумма цифр: {sum}");
}
int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}


//Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
//1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
//6, 1, 33 -> [6, 1, 33]


string? seriesOfNumbers = Console.ReadLine();

seriesOfNumbers = seriesOfNumbers + ",";   


string RemovingSpaces (string series)
{
  string seriesNew = "";
  for (int i = 0; i < series.Length; i++)
  {
    if (series[i] != ' ') 
    {
      seriesNew += series[i];
    }
  }
  return seriesNew;
}

void СheckNumber2 (int  series)
{

      if (series == '0'||series == '1'||series == '2'
      ||series == '3'||series == '4'||series == '5'||series == '6'
      ||series == '7'||series == '8'||series == '9'||series == ','
      ||series == '-')
      {
      }
        else {
          Console.WriteLine($"Ошибка ввода. Введите цифры.");

      }
}

int[] ArrayOfNumbers(string seriesNew)
{ 

  int[] arrayOfNumbers = new int[1];    
  int j =0;

  for (int i = 0; i < seriesNew.Length; i++)
  {
    string seriesNew1 = "";

    while (seriesNew[i] != ',' && i < seriesNew.Length)
    {
      seriesNew1 += seriesNew[i];
      СheckNumber2(seriesNew[i]);
      i++;
    }
    arrayOfNumbers[j] = Convert.ToInt32(seriesNew1);
    if (i < seriesNew.Length-1)
    {
      arrayOfNumbers = arrayOfNumbers.Concat(new int[] {0}).ToArray();
    }
    j++;
  }
  return arrayOfNumbers;
}


void PrintArry(int[] coll)
{
  int count = coll.Length;
  int index = 0;
  Console.Write("[");
  while(index < count){
    Console.Write(coll[index]);
    index++;
    if (index < count){
      Console.Write(", ");
    }
  }
  Console.Write("]");
} 


string seriesNew = RemovingSpaces(seriesOfNumbers);

int[] arrayOfNumbers =  ArrayOfNumbers(seriesNew);

PrintArry(arrayOfNumbers);