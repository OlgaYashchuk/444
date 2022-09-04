// See https://aka.ms/new-console-template for more information
// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
//1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
//6, 1, 33 -> [6, 1, 33]
 int numbersSize =8;
 int[] numbers = new int[numbersSize];
 Console.Write("[");
 for (int i=0; i<numbersSize; ++i)
 {
    numbers[i]=new Random().Next(0,100);
    Console.Write($"{numbers[i]}, ");
 }
Console.Write("]");