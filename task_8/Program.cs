// Задача 8: Напишите программу, которая на вход принимает число (N), 
// а на выходе показывает все чётные числа от 1 до N.

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int i = 1;

while (i < number) {
    int test = i % 2;
    if (test == 0) {
        Console.WriteLine(i);
        i++;
    } else {
        i++;
    }
}

// сначала неправильно прочитал задачу, начал выполнять, потом выполненные решения оставил как
// доп. задача


// Пользователь задает число N, мы выводим все числа от -N до 0

// for (int i = 0; i < number; i++) Console.WriteLine(-number + i); // пробный вывод 1


// пробный код 2

// while (i >= -number && i <= number) {
//     Console.WriteLine(-number + i);
//     i++;
//     if (i > -number) {
//         Console.WriteLine(i);
//     }
// }