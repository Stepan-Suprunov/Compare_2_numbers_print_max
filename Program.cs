// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

// Запрос на ввод чисел.
Console.WriteLine("Введите число a");
int NumA = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число b");
int NumB = int.Parse(Console.ReadLine());

// Вычисления и вывод решения.
if (NumA > NumB) {
    Console.WriteLine("max = " + NumA);
}
else if (NumA < NumB) {
    Console.WriteLine("max = " + NumB);
}
else {
    Console.WriteLine("числа равны");
}