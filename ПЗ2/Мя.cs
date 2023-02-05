using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Input;
using System.Threading;

namespace ПЗ2
{
	static class Methods
	{
		public static void PrintArray(int[] myArray)
		{
			foreach (int elem in myArray)
			{
				Console.Write("{0} ", elem);
			}
			Console.WriteLine();
		}
		public static void PrintArray2(int[,] myArray)
		{
			for (int i = 0; i < myArray.GetLength(0); i++)
			{
				for (int j = 0; j < myArray.GetLength(1); j++)
				{
					Console.Write("{0} ", myArray[i, j]);
				}
				Console.WriteLine();
			}
		}
		public static int Min(int a, int b)
		{
			return (a < b) ? a : b;
		}
		public static int NC_MinDigit(int a)
		{
			if (a == 0) return 0;
			var digits = new int[a.ToString().Length];
			for (int b = a.ToString().Length; b > 0; b--)
			{

				digits[b - 1] = a % 10;
				a /= 10;
			}


			return digits.ToArray().Min();
		}
		public static double god_bless_pifagor(double a, double b)
		{
			return Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2));
		}
		static public int[] Change(int[] myArray, int length)
		{
			Console.WriteLine("Введите начало и конец отрезка:");
			int a = Program.Readln();
			int b = Program.Readln();
			Console.WriteLine("На какое число вы хотите поменять значения из отрезка?");
			int c = Program.Readln();
			for (int i = 0; i < length; i++)
			{
				if (myArray[i] < b & myArray[i] > a)
					myArray[i] = c;
			}
			return myArray;
		}
		static public int[] ChangeMax(int[] myArray, int length)
		{
			Console.WriteLine("На какое число вы хотите поменять максимальные значения?");
			int c = Program.Readln();
			int pip = myArray.Max();
			for (int i = 0; i < length; i++)
			{
				if (myArray[i] == pip)
					myArray[i] = c;
			}
			return myArray;
		}
		static public int[] Randomize(int length)
		{
			int[] myArray = new int[length];
			Random rnd = new Random();
			for (int i = 0; i < length; i++)
			{
				myArray[i] = rnd.Next(-100, 100);
			}
			return myArray;
		}
		static public void Swap(ref int a, ref int b)
		{
			int temp = 0;
			temp = a;
			a = b;
			b = temp;
		}
		static public int[,] Randomize2(int height, int length)
		{
			int[,] myArray = new int[height, length];
			Random rnd = new Random();
			for (int i = 0; i < height; i++)
				for (int j = 0; j < length; j++)
				{
					myArray[i, j] = rnd.Next(-100, 100);
				}
			return myArray;
		}
		static public int[] Manual(int length, string Setup)
		{
			int[] myArray = new int[length];
			switch (Setup)
			{
				case "manual":
					for (int i = 0; i < length; i++) { myArray[i] = Program.Readln(); } break;
				case "random":
					myArray = Randomize(length); break;
				case "null":
					for (int i = 0; i < length; i++) { myArray[i] = 0; } break;

			}
			return myArray;

		}
		static public int[,] Manual2(int height, int length, string Setup)
		{
			int[,] myArray = new int[height, length];
			switch (Setup)
			{
				case "manual":
					{
						for (int i = 0; i < height; i++)
							for (int j = 0; j < length; j++)
							{
								myArray[i, j] = Program.Readln();
							}
						break;
					}
				case "random":
					myArray = Randomize2(height, length); break;
				case "null":
					for (int i = 0; i < height; i++)
						for (int j = 0; j < length; j++)
						{
							myArray[i, j] = 0;
						}
					break;

			}
			return myArray;

		}
		static public int Choise()
		{
			Console.WriteLine();
			int top = Console.CursorTop;
			int y = top;
			var fillers = new Dictionary<int, string> { { 1, "Ввести вручную" }, { 2, "Заполнить рандомными значениями" }, { 3, "Заполнить нулями" } };
			foreach (var filler in fillers)
				Console.WriteLine(filler.Value);

			int down = Console.CursorTop;

			Console.CursorSize = 100;
			Console.CursorTop = top;

			ConsoleKey key;
			while ((key = Console.ReadKey(true).Key) != ConsoleKey.Enter)
			{
				if (key == ConsoleKey.Escape)
					return 0;
				if (key == ConsoleKey.UpArrow)
				{
					if (y > top)
					{
						y--;
						Console.CursorTop = y;
					}
				}
				else if (key == ConsoleKey.DownArrow)
				{
					if (y < down - 1)
					{
						y++;
						Console.CursorTop = y;
					}
				}
			}

			Console.CursorTop = down;

			foreach (var filler in fillers)
			{
				int Key = top + filler.Key - 1;
				if (y == Key)
				{
					return filler.Key;

				}
			}
			return 0;
		}

		static public int Choise2()
		{
			var tasks = new Dictionary<int, string>()
			{
				{1, "(Среднее арифметическое двух кубов) Введите 2 переменные\n"},
				{2, "(Заканчивается ли число а на цифру b)Введите 2 переменные\n"},
				{3, "(Является ли а 'Зеркальной' b)Введите 2 переменные\n"},
				{4, "(Кубы нечетных чисел от а до b)Введите 2 переменные\n"},
				{5, "(Матрица)"},
				{6, "(Кубы нечетных чисел от а до b)Введите 4 переменные: начало отрезка, конец отрезка, шаг, параметр\n"},
				{7, "(Решение примера y = sqrt(x^2 - 1) ) Введите переменную x\n"},
				{8, "Введите номер карты:"},
				{9, "Будет ли точка входить в круг, быть на ее границе или вовсе находиться вне фигуры ограниченной кругами с центром в (0,0) и радиусами 3 и 7?\n"},
				{10,"Введите размер массива: "},
				{11,"Введите размер массива: "},
				{12,"Введите высоту и длину массива: "},
				{13,"Введите слово: "},
				{14,"Выполнение операций над множествам и их вывод\n"},
				{15,"Игра на память: вводите числа, абсолютная разность которых не меньше 7, не является последовательным и не больше 255.   После ввода числа консоль каждый раз будет очищаться\n"},
				{16,"Редактируем пипку без смс и регистрации\n"},
				{17,"Редактируем пипку без смс и регистрации v.2\n"},
				{18,"Извращения с файлами, с смс и регистрацией\n"},
				{19, "kek"},
				{20, "x = 2, y = 5, свапаем их значения"},
				{21, "Рекурсивная падла"}

			};
			int top = Console.CursorTop;
			int y = top;

			for (int i = 0; i < tasks.Keys.Max(); i++)
				Console.WriteLine(i + 1);

			Console.WriteLine("exit");

			int down = Console.CursorTop;

			Console.CursorSize = 100;
			Console.CursorTop = top;

			ConsoleKey key;
			while ((key = Console.ReadKey(true).Key) != ConsoleKey.Enter)
			{
				if (key == ConsoleKey.UpArrow)
				{
					if (y > top)
					{
						y--;
						Console.CursorTop = y;
					}
				}
				else if (key == ConsoleKey.DownArrow)
				{
					if (y < down - 1)
					{
						y++;
						Console.CursorTop = y;
					}
				}

			}

			Console.CursorTop = down;

			foreach (var task in tasks)
			{
				int Key = top + task.Key - 1;                                           //!!!!
				if (y == Key)
				{
					Console.WriteLine(task.Value);
					return task.Key;

				}
			}

			return 0;
		}
		static public long AKbyaka(uint number)
		{
			if (number <= 2)
				return (number == 1) ? -10 : 2;
			else
				return Math.Abs(AKbyaka(number - 2)) - 6*AKbyaka(number - 1);
		}
		static public string ToBinary(int number)
		{
			return Convert.ToString(number, 2);
		}
		static public string Lunatic(int number)
		{
			return((number == 0) ? "No fucking motherfuckers in your stupid life, you may die too piece of shit\n":(number+" motherfuckers left\n1 motherfucker dead\n"+Lunatic(number-1)) );

		}
	}
	
	
}

