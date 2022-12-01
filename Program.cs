Console.Clear();

// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.


// Console.Write("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());
// int count = 1;

// void RecursionDown(int n, int count)
// {
//     if (count > n)
//     {
//         return;
//     }
//     else
//     {
//         RecursionDown(n, count + 1);
//         Console.Write(count + " ");
//     }
    
// }
// RecursionDown(number, count);

// Console.WriteLine();





// // Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.


// Console.Write("Введите первое число (M): ");
// int numberM = int.Parse(Console.ReadLine());

// Console.Write("Введите второе число (N): ");
// int numberN = int.Parse(Console.ReadLine());

// void AdderNum (int numberM, int numberN, int sum)
// {
//     if (numberM > numberN) 
//     {
//         Console.WriteLine();
//         Console.WriteLine($"Сумма чисел от M до N = {sum}"); 
//         return;
//     }
//     sum = sum + (numberM++);
//     AdderNum(numberM, numberN, sum);
// }

// AdderNum(numberM, numberN, 0);
// Console.WriteLine();



// // Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.


// Console.Write("Введите первое число (M): ");
// int numberM = int.Parse(Console.ReadLine());

// Console.Write("Введите второе число (N): ");
// int numberN = int.Parse(Console.ReadLine());

// int Ackermann (int numberM, int numberN)
// {
//     if (numberM == 0) return numberN + 1;
//     if (numberM != 0 && numberN == 0) return Ackermann(numberM - 1, 1);
//     if (numberM > 0 && numberN > 0) return Ackermann(numberM - 1, Ackermann(numberM, numberN - 1));
// return Ackermann(numberM, numberN);
// }
// Console.WriteLine();
// Console.WriteLine($"A({numberM},{numberN}) = {Ackermann(numberM, numberN)}");
// Console.WriteLine();