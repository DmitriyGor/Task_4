/* Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
Например:
2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22
*/

int FirstNumber = 0;
int SecondNumber = 0;
int ThirdNumber = 0;

Console.Write("Enter the first number:  ");
FirstNumber = Convert.ToInt32(Console.ReadLine()); // Convert.ToInt32 == int.Parse

Console.Write("Enter the second number:  ");
SecondNumber = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter the third number:  ");
ThirdNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("------------------------");

if (FirstNumber > SecondNumber && FirstNumber > ThirdNumber)
{
    Console.WriteLine ("Greater number is first:  " + FirstNumber);
}
else if (SecondNumber > ThirdNumber)
{
    Console.WriteLine ("Greater number is second:  " + SecondNumber);
}
else
{
   Console.WriteLine ("Greater number is third:  " + ThirdNumber);
}
