// Задача №1.Напишите программу,которая принимает на вход пятизначное число и проверяет,являеться ли оно палиндромом
// System.Console.WriteLine("Введите число: ");
// string nam = Console.ReadLine();
// if (nam.Length < 5)
// {
//     System.Console.WriteLine("Число должно содержыть не менее пяти чисел");
// }
// if (nam [0] == nam [4] && nam [1] == nam [3])
//  {
//      System.Console.WriteLine($"{nam} палиндромное");
//  }
// else 
// {
//     System.Console.WriteLine($"{nam} не палиндромное");
// }

// Задача №2.Напишите программу,которая принимает на вход координаты двух точек и находит растояние между ними в 3D пространстве

// System.Console.Write("введите координату X точки A: ");
// int x1 = Convert.ToInt32(Console.ReadLine());
// System.Console.Write("введите координату Y точки A: ");
// int y1 = Convert.ToInt32(Console.ReadLine());
// System.Console.Write("введите координату Z точки A: ");
// int z1 = Convert.ToInt32(Console.ReadLine());
// System.Console.Write("введите координату X точки B: ");
// int x2 = Convert.ToInt32(Console.ReadLine());
// System.Console.Write("введите координату Y точки B: ");
// int y2 = Convert.ToInt32(Console.ReadLine());
// System.Console.Write("введите координату Z точки B: ");
// int z2 = Convert.ToInt32(Console.ReadLine());

//  double result = Math.Round(Math.Sqrt(Math.Pow((x1 - x2),2) + Math.Pow((y1 - y2),2) + Math.Pow((z1 - z2),2)),2);
//  System.Console.WriteLine($"Растояние между двумя точками: {result}");

// Задача №3.Напишите программу,которая принимает на вход чисто (N) и выдает таблицу кубов чисел от 1 до N

System.Console.Write("Введите чисто: ");
int x = Convert.ToInt32(Console.ReadLine());

for (int i = 1; i <= x; i++)
{
    System.Console.Write(Math.Pow(i,3) + " ");
}