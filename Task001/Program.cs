Console.Write("Введите число по оси х: ");
int x = int.Parse(Console.ReadLine());
Console.Write("Введите число по оси y: ");
int y = int.Parse(Console.ReadLine());

if(x > 0 && y > 0){
    Console.Write("Это первая четверть");
} else if(x < 0 && y > 0) {
    Console.Write("Это вторая четверть");
} else if(x < 0 && y < 0) {
    Console.Write("Это третья четверть");
} else if(x > 0 && y < 0) {
    Console.Write("Это четвертая четверть");
} 
