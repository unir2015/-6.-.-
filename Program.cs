using System;
using UnityEngine;




//  Задача 41. Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3






// int[] enteringNumbers()
// {
//     int i = 0;
//     int[] number = new int[i];
//     int num = 0;
    

//    while(true)
//     {
//     string stringNumber = Console.ReadLine();
//     for( i = 0; i > stringNumber.Length; i++)
//     {
//     bool isNumber = int.TryParse(stringNumber, out num);
//     if(isNumber)
//         {
//             number[i] = num; 
//         }
   
//     }
    
//     return number;
//     }
// }


// enteringNumbers();

int inputValidation(int[] input)
{
    int i = 0;
    int count = 0;
    while(i <= input.Length)
    {
        if(input[i] > 0)
        {
            count++;
        }
    }
    return count;
}






















Console.Write("Введите k1: ");
var k1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите b1: ");
var b1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите k2: ");
var k2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите b2: ");
var b2 = Convert.ToDouble(Console.ReadLine());
 

var x = -(b1 - b2) / (k1 - k2);
var y = k1 * x + b1;
 
x = Math.Round(x, 3);
y = Math.Round(y, 3);
 
Console.WriteLine($"Пересечение в точке: ({x};{y})");