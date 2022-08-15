//Напишите программу, которая по заданному номеру четверти показывает диапазон возможных координат точек в этой четверти (х и y)

Console.Write("Введите номер четверти от 1 до 4:  ");
int number = int.Parse(Console.ReadLine());

/*if(number == 1){
    Console.WriteLine("Диапазоны по оси x > 0, y > 0");
} else if(number == 2){
    Console.WriteLine("Диапазоны по оси x < 0, y > 0");
} else if(number == 3){
    Console.WriteLine("Диапазоны по оси x < 0, y < 0");
} else if(number == 4){
    Console.WriteLine("Диапазоны по оси x > 0, y < 0");
} else if(number > 4 || number < 1){
    Console.WriteLine("Номер четверти введен некорректно");
}*/

//Альтернативное решение данной задачи с помощью switch

switch(number){
    case 1:
    {
        Console.WriteLine("Диапазоны по оси x > 0, y > 0");
        break;
    }
    case 2:
    {
        Console.WriteLine("Диапазоны по оси x < 0, y > 0");
        break;
    }
    case 3:
    {
        Console.WriteLine("Диапазоны по оси x < 0, y < 0");
        break;
    }
    case 4:
    {
        Console.WriteLine("Диапазоны по оси x > 0, y < 0");
        break;
    }
    default:
    {
        Console.WriteLine("Номер четверти введен некорректно");
        break;
    }
}