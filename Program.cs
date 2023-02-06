// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

// Console.WriteLine("Введите число");
//     while(true)
//     {
//         string input = Console.ReadLine();
//         if(!input.Equals("exit"))
//             Console.WriteLine("{0}  {1}",input, input[1]);
//         else
//             break;

//     }



// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

// Console.WriteLine("Введите число");
// int number = Convert.ToInt32(Console.ReadLine());

// if (number < 100)
// {
//     Console.WriteLine("Третьей цифры не существует");
// }
// else
// {
//     while (number > 1000);
//     {
//         number /= 10;
//     }
//     Console.WriteLine(number%10);
// }


// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

// Console.Write("Введите день недели  ");
// int Day = Convert.ToInt32(Console.ReadLine());
// if (Day >= 1 && Day <=7) 
// {
// 	if (Day >= 6) 
//     {
// 		Console.Write("Выходной");
// 	} else {
// 		Console.Write("Рабочий день");
// 	}
// }