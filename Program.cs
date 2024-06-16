using System;
using System.Linq;

class Program
{
    static void Main()
    {
        string x;
        // Предположим, что у нас есть следующие данные:
        int[] newspapers = new int[] { 8, 10, 12, 14, 16 }; // Количество страниц в газетах
        int[] magazines = new int[] { 20, 25, 30 };          // Количество страниц в журналах

        // Переменная для хранения общего числа страниц во всех журналах
        int totalPagesInMagazines = 0;

        // Находим максимальное количество страниц в газетах
        int maxNewspaperPages = newspapers.Max();

        // Проверяем каждый журнал и добавляем его страницы к общему числу, если они больше, чем в любой газете
        foreach (int magazinePages in magazines)
        {
            if (magazinePages > maxNewspaperPages)
            {
                totalPagesInMagazines += magazinePages;
            }
            else { Console.WriteLine("Данные не выполняют условия задачи.\nКоличество страниц журнала меньше, чем у одной из газет"); return; }
        }

        Console.WriteLine("Общее количество страниц во всех журналах: " + totalPagesInMagazines);
    }
}