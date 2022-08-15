/* Написать программу, которая принимает на вход число (N) и выдает таблицу квадратов от 1 до N
5 -> 1, 4, 9, 16, 25
2 -> 1, 4*/

Console.Write("Введите любое число для последовательного вывода квадратов ");
int number = int.Parse(Console.ReadLine());

for(int i = 1; i <= number; i++){
    int result = Convert.ToInt32(Math.Pow(i, 2));
    Console.WriteLine(result);
}
