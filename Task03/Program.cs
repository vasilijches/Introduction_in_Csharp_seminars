﻿//Напишите программу, которая будет выдавать название дня недели по заданному номеру
// Например:
// 3 -> Среда
// 5 -> Пятница

Console.Write("Введите номер дня недели: ");
string dayNumber = Console.ReadLine();

if (dayNumber == "1") { Console.WriteLine("Понедельник"); }
else if (dayNumber == "2") { Console.WriteLine("Вторник"); }
else if (dayNumber == "3") { Console.WriteLine("Среда"); }
else if (dayNumber == "4") { Console.WriteLine("Четверг"); }
else if (dayNumber == "5") { Console.WriteLine("Пятница"); }
else if (dayNumber == "6") { Console.WriteLine("Суббота"); }
else if (dayNumber == "7") { Console.WriteLine("Воскресенье"); }
else { Console.WriteLine("нет такого дня недели"); }