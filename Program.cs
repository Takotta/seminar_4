//Напишите программу, которая на вход принимает число и 
//выдаёт его квадрат (число умноженное на само себя).
//Например:
//4 -> 16 
//-3 -> 9 
//-7 -> 49
// Console.Write("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine()); 
// Переменнная с результатом
// int result = number * number; // number^2 = result
// Console.WriteLine(result);

// camelCase => firstNumber, secondNumber, thirdNumberAndFourthNumber, fourthNumber
// Console.Write("Введите первое число: "); // текст-подсказка которая помогает получить число
// int firstNumber = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите второе число: "); // текст-подсказка которая помогает получить число
// int secondNumber = Convert.ToInt32(Console.ReadLine());
// // ТОЧКА С ЗАПЯТОЙ НЕ СТАВЯТСЯ ПЕРЕД ФИГУРНОЙ СКОБКОЙ
// if (secondNumber * secondNumber == firstNumber) // 
// {
// Console.WriteLine("Первое число является квадратом второго");
// }
// else Console.WriteLine("Первое число НЕ является квадратом второго");



// 3. Напишите программу, которая будет выдавать название дня недели по заданному номеру.
// 	3 -> Среда 
// 5 -> Пятница

int dayNumber = Convert.ToInt32(Console.ReadLine());
if (dayNumber == 1) Console.WriteLine("Понедельник");

// 5. Напишите программу, которая на вход принимает одно число (N),
// а на выходе показывает все целые числа в промежутке от -N до N.
// 4 -> "-4, -3, -2, -1, 0, 1, 2, 3, 4" 
// 2 -> " -2, -1, 0, 1, 2"

int positiveNumber = Convert.ToInt32(Console.ReadLine()); // число N
if (positiveNumber < 0) positiveNumber*= -1; // Из отр -> пол.
int negativeNumber = positiveNumber * (-1); // получили -N

while (negativeNumber <= positiveNumber) // пока условие истинно
{
  Console.WriteLine(negativeNumber);
  negativeNumber++; //negativeNumber = negativeNumber + 1
  //negativeNumber+=1
}
