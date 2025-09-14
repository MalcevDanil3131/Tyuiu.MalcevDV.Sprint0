using Tyuiu.MalcevDV.Sprit0.Task7.V0.Lib;
void PrintCenteredLine(string text, int totalWidth)
{
    var padding = totalWidth - text.Length - 2; // -2 для звездочек по бокам
    Console.WriteLine($"* {text}{new string(' ', padding)}*");
}

var width = 75;

Console.WriteLine(new string('*', width));
PrintCenteredLine("Спринт #0", width);
PrintCenteredLine("Тема: Создания итогового решения по спринту", width);
PrintCenteredLine("Задание #7", width);
PrintCenteredLine("Вариант #0", width);
PrintCenteredLine("Выполнил: Мальцев Данил Вячеславович | РППБ-25-1", width);
Console.WriteLine(new string('*', width));
PrintCenteredLine("УСЛОВИЕ:", width);
PrintCenteredLine("Написать консольную программу на C#, которая суммирует значения двух", width);
PrintCenteredLine("одинаковых массивов по длинне.", width);
PrintCenteredLine("ИСХОДНЫЕ ДАННЫЕ:", width);
Console.WriteLine(new string('*', width));
int[] arrayNums1 = new int[] { 1, 2, 3, 4, 5 };

Console.WriteLine("Значение элементовы массива №1");
for (var i = 0; i < arrayNums1.Length; i++)
{
    Console.Write(arrayNums1[i] + ", ");
}

Console.WriteLine();

int[] arrayNums2 = new int[] { 1, 2, 3, 4, 5 };
Console.WriteLine("Значение элементов массива №2");
for (var i = 0; i < arrayNums2.Length; i++)
{
    Console.Write(arrayNums2[i] + ", ");
}
Console.WriteLine();
Console.WriteLine(new string('*', width));
PrintCenteredLine("* РЕЗУЛЬТАТ:", width);
Console.WriteLine(new string('*', width));
if (arrayNums1.Length == arrayNums2.Length)
{
    int[] resultArray = DataService.AdditionArrays(arrayNums1, arrayNums2);
    Console.WriteLine("Сумма элементтов массива равна:");
    for (var i = 0; i < resultArray.Length; i++)
    {
        Console.Write(resultArray[i] + ", ");
    }
}
else
{ 
    Console.WriteLine("Ошибка! Исходные массивы имеютт разное количество элементов");
}



