// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16


int ReadInt(string text)
{
    System.Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}

void MathPow(int A, int B)
{
    int result = A;
    for (int i = 1; i < B; i++)
    {
        result *= A;
    }
    System.Console.WriteLine(result);
}

int number = ReadInt("Введите число: ");
int degree = ReadInt("Введите степень числа: ");

MathPow(number, degree);