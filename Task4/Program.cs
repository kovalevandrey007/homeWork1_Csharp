﻿/* Задача 4: Напишите программу, которая принимает на вход 
три числа и выдаёт максимальное из этих чисел.
2, 3, 7 -> 7
44, 5, 78 -> 78
22, 3, 9 -> 22*/

int a, b, c;
Console.WriteLine("Введите первое число: ");
a = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
b = int.Parse(Console.ReadLine());
Console.WriteLine("Введите третье число: ");
c = int.Parse(Console.ReadLine());

if(a>b && a>c)
       Console. WriteLine ($"max={a}");
       
    else 
    if (b>a && b>c)
          Console. WriteLine ($"max={b}");
           
             else
      Console. WriteLine ($"max={c}");