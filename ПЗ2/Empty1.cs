using System;
using System.Collections.Generic;
using System.Linq;
using System.Collections;
using System.Text;
using System.IO;
using System.Diagnostics;
namespace ПЗ2
{
	static class Program
	{
		public static int Readln()
		{
			string ans = Console.ReadLine();
			ans = (ans == "") ? "0" : ans;
			return Convert.ToInt32(ans);
		}
		public static string ReadlnString()
		{
			string ans = Console.ReadLine();
			ans = (ans == "") ? "-" : ans;
			return ans;
		}
		
		public static void Zadacha1()
		{
			//Console.WriteLine("(Среднее арифметическое двух кубов) Введите 2 переменные");
			int a = Readln();
			int b = Readln();
			int c = (a*a*a + b*b*b);
			Console.WriteLine(c/2);
			
		}
		
		public static void Zadacha2()
		{
			//Console.WriteLine("(Заканчивается ли число а на цифру b)Введите 2 переменные");
			int a = Readln();
			int b = Readln();
			Console.WriteLine((a%10==b)?"Yes":"No");
			
		}
		
		public static void Zadacha3()
		{
			//Console.WriteLine("(Является ли а 'Зеркальной' b)Введите 2 переменные");
			int a = Readln();
			
			int b = Readln();
			Console.WriteLine((a%10==b/10 | a/10%10 == b/10%10 | b%10==a/100)?"Yes":"No");
		}
		
		public static void Zadacha4()
		{
			//Console.WriteLine("(Кубы нечетных чисел от а до b)Введите 2 переменные");
			int a = Readln();
			int b = Readln();
			while(a<=b)
			{	
			
				if (a%2 != 0)
					Console.WriteLine("{0}",Math.Pow(a,3));
				a++;
			}
			
		
		}
		
		public static void Zadacha5()
		{
			//Console.WriteLine("(Матрица)");
			int a = -10;
			int b = 12;
			for(int i = 0; i < 5; i++)
			{
				Console.WriteLine(" ");
			    while(a<=b)
				{	
			    	Console.Write("{0} ", a);
					a++;
				}
			    a=-10;
			   
			}
			
			Console.WriteLine(" ");
		}
		
		public static void Zadacha6()
		{
			//Console.WriteLine("(Кубы нечетных чисел от а до b)Введите 4 переменные: начало отрезка, конец отрезка, шаг, параметр");
			double a = Convert.ToDouble(Readln());
			double b = Convert.ToDouble(Readln());
			double h = Convert.ToDouble(Readln());
			double p = Convert.ToDouble(Readln());
			double ans = 0;
			Console.WriteLine("x y");
			while (a <= b)
			{
				if (a<p)
					ans = 0;
				if (a == p)
					ans = 1;
				if (a > p)
					ans = (a-p)/(a+p);
			
				a += h;
				
				Console.WriteLine("{0} {1}",a, Math.Round(ans, 2));
			}
		}
		
		public static void Zadacha7()
		{
			//Console.WriteLine("(Решение примера y = sqrt(x^2 - 1) ) Введите переменную x");
			double x = Convert.ToDouble(Console.ReadLine());
			if(x>-1 & x<1)
				Console.WriteLine("неть");
			else
				Console.WriteLine("y = {0}", Math.Sqrt(Math.Pow(x,2) - 1));
		
		}
		
		public static void Zadacha8()
		{
			var cards = new Dictionary<int, string>()
			{
				{6, "Шестерка"},
				{7, "Семерка"},
				{8, "Восьмерка"},
				{9, "Девятка"},
				{10, "Десятка"},
				{11, "Валет"},
				{12, "Дама"},
				{13, "Король"},
				{14, "Туз"}
								
			};
			Console.WriteLine("Введите номер карты");
			int a = Readln();
			Console.WriteLine((a>= 6 & a<= 14) ? cards[a] : "Такой карты нет");
		}
		
		public static void Zadacha9()
		{   double pipka = Math.PI * Math.Pow(7,2) - Math.PI * Math.Pow(3,2);
			//Console.WriteLine("Будет ли точка входить в круг площадью {0} , быть на ее границе или вовсе находиться вне фигуры ограниченной кругами с центром в (0,0) и радиусами 3 и 7?",Math.Round(pipka, 2));
			Console.WriteLine("Введите x и y");
			double x = Convert.ToDouble(Console.ReadLine());
			double y = Convert.ToDouble(Console.ReadLine());
			if ((Math.Pow(x,2) + Math.Pow(y,2)) > (2 * Math.PI * Math.Pow(3,2)) & (Math.Pow(x,2) + Math.Pow(y,2)) <= (2 * Math.PI * Math.Pow(7,2)))
				Console.WriteLine("Да");
			
			if (((y == Math.Abs(x) * (-1) | (Math.Pow(x,2) + Math.Pow(y,2)) == Math.Pow(7,2) | (Math.Pow(x,2) + Math.Pow(y,2)) == Math.Pow(3,2))))
				Console.WriteLine("На границе");
		
			if ((Math.Pow(x,2) + Math.Pow(y,2)) < (2 * Math.PI * Math.Pow(3,2)) | (Math.Pow(x,2) + Math.Pow(y,2)) >= (2 * Math.PI * Math.Pow(7,2)))
				Console.WriteLine("Нет");
			
			
			
			
			
			
		}
		
		public static void Zadacha10()
		{
			
			//Console.Write("Введите размер массива: ");
			int n = Readln();
			int[] bobrik = new int[n];
			Console.WriteLine("Как вы хотите заполнить массив?");
			// int Question=Readln();
			int answer = Methods.Choise();
			
			switch (answer)
			{
					case 2: bobrik = Methods.Manual(n, "random"); break;
					case 1: {Console.WriteLine("Введите {0} значений", n); bobrik = Methods.Manual(n, "manual"); break;}
					case 3: bobrik = Methods.Manual(n, "null"); break;
			}
		
			Methods.PrintArray(bobrik);
			Methods.PrintArray(Methods.Change(bobrik,n));
	
		}
		
		public static void Zadacha11()
		{
			
			//Console.Write("Введите размер массива: ");
			int n = Readln();
			int[] bobrik = new int[n];
			Console.WriteLine("Как вы хотите заполнить массив?");
			// int Question=Readln();
			int answer = Methods.Choise();
			
			switch (answer)
			{
					case 2: bobrik = Methods.Manual(n, "random"); break;
					case 1: {Console.WriteLine("Введите {0} значений", n); bobrik = Methods.Manual(n, "manual"); break;}
					case 3: bobrik = Methods.Manual(n, "null"); break;
			}
		
			Methods.PrintArray(bobrik);
			
			Methods.PrintArray(Methods.ChangeMax(bobrik,n));
	
		}
		
		public static void Zadacha12()
		{
			
			//Console.Write("Введите высоту и длину массива: ");
			int height = Readln();
			int length = Readln();
			int[,] bobrik = new int[height,length];
			Console.WriteLine("Как вы хотите заполнить массив?");
			// int Question=Readln();
			int answer = Methods.Choise();
			
			switch (answer)
			{
					case 2: bobrik = Methods.Manual2(height, length, "random"); break;
					case 1: {Console.WriteLine("Введите {0} значений", height*length); bobrik = Methods.Manual2(height, length, "manual"); break;}
					case 3: bobrik = Methods.Manual2(height, length, "null"); break;
			}
		
			Methods.PrintArray2(bobrik);
			
			int ans = 0;
			for (int i = 0; i < bobrik.GetLength(0); i++)
			{
				
					for (int j = bobrik.GetLength(1) - i; j < bobrik.GetLength(1); j++)
					{
						ans += bobrik[i,j];

					}
			}
			Console.WriteLine("Сумма элементов побочной диагонали массива - {0}", ans);	
		}
		
		public static void Zadacha13()
		{
			string main_word = Console.ReadLine();
			Console.WriteLine("Длина слова: {0} ", main_word.Length);
			Console.WriteLine("Введите два символа");
			int first_sum = 0;
			int second_sum = 0;
			char previous_letter = ' ';
			char current_letter = ' ';
			StringBuilder sb = new StringBuilder(2);
			char a = Convert.ToChar(ReadlnString());
			char b = Convert.ToChar(ReadlnString());
			foreach (var next_letter in main_word)
			{
				if (next_letter == a)
					first_sum++;
				if (next_letter == b & a != b)
					second_sum++;
				
				previous_letter = current_letter;
				current_letter = next_letter;
				
				if (previous_letter == current_letter)
				{
					sb.Append(previous_letter); sb.Append(next_letter);
					Console.WriteLine("Два соседствующих одинаковых символа: {0}",sb);
					sb.Clear();
				}
			}
			Console.WriteLine("Общая сумма двух введенных символов: {0} \nНаиболее встречающийся символ из введенных: {1}", first_sum + second_sum, (first_sum > second_sum) ? a : b);
			
			//Console.WriteLine("Наиболее встречающийся символ: {0}", (first_sum > second_sum) ? a : b);
			
		}
		public static void Zadacha141()
		{
			HashSet<char> A = new HashSet<char>(){'a', 'h', 'm', 'o', 'r'};
			HashSet<char> B = new HashSet<char>(){'j', 'k', 'o', 'u', 'y'};
			HashSet<char> C = new HashSet<char>(){'g', 'h', 'j'};
			HashSet<char> D = new HashSet<char>(){'b', 'e', 'g'};
			
			HashSet<char> a = new HashSet<char>(A);
			HashSet<char> b = new HashSet<char>(B);
			Console.WriteLine("1 множество: X = (A и C) или (D и B)");
			a.IntersectWith(C);
			b.IntersectWith(B);
			
			a.UnionWith(b);
			
				Console.Write(string.Join(",",a));
			Console.WriteLine();
			
			a.Clear();
			b.Clear();
			
			a = A;
			b = B;
			Console.WriteLine("2 множество: X = (A и B) или (D без C)");
		
			
			a.IntersectWith(B);
			b.ExceptWith(C);
				
			a.UnionWith(b);
			
				Console.Write(string.Join(",",a));
			Console.WriteLine();
		}
			
	public static void Zadacha15()
	{
		HashSet<int> Answers = new HashSet<int>(){};
		int A;
		int B = -7;
	
		while(true)
		{
			A = Readln();
			if (( (A - B) > 7 | (A - B) < (-7)) & ((A < 256) & (A > 0)) & !Answers.Contains(A) )
			{	Answers.Add(A);
				B = A;
				Console.Clear();
			}
			else
			{
				Console.WriteLine((Answers.Contains(A) ? "Попался! Число уже было записано тобой" : "Попался! Число не подходит условиям") + "\nКоличество очков - {0}", Answers.Count());
				break;
				                  
			}
		}
	}
	public static void Zadacha16()
	{
		
		using (StreamReader file_in = new StreamReader("C:/Users/K208-3/Documents/pipka_orig.txt"))
		{
			var words = new SortedSet<string>();
		       	using (StreamWriter file_out = new StreamWriter("C:/Users/K208-3/Documents/pipka.txt", false))
			{
		       		char str = Convert.ToChar(Console.ReadLine());
		       		char[] div = {' ', '?', ',', '.', '!','?'};
		       		string file_in_read = file_in.ReadToEnd();
		       		string[] s = file_in_read.Trim().Split(div, StringSplitOptions.RemoveEmptyEntries);
		       		int sum = 0;
		       		foreach(string str1 in s)
		       		{
		       			if (str1[0] == str)
		       				words.Add(str1);
		       				
		       		}
		       		foreach(string word in s)
		       		{
		       			foreach(char c in word)
		       			{
		       				if (c == str)
		       					sum++;
		       			}
		       		}
		       		file_out.WriteLine(string.Join(",", words));
		       		Console.WriteLine("Файл изменен! Содержимое файла: {0}\nДанный символ в этой пипке попался нам {1} раз",string.Join(",",words), sum);
		       
			}
		}
	}
	public static void Zadacha17()
	{
		using (StreamReader f = new StreamReader("C:/Users/K208-3/Documents/f.txt"))
		{
				using (StreamWriter h = new StreamWriter("C:/Users/K208-3/Documents/h.txt", false))
			{
					using (StreamWriter j = new StreamWriter("C:/Users/K208-3/Documents/j.txt", false))
				{
						char[] div = {' ', '?', ',', '.', '!','?'};
						string f1= f.ReadToEnd();
						string[] s = f1.Trim().Split(div, StringSplitOptions.RemoveEmptyEntries);
						Console.WriteLine("В файл h аписаны:");
						foreach(string num in s)
						{
							if(Convert.ToInt32(num)%2==1)
							{
								Console.Write("{0} ", num);
								h.WriteLine("{0} ", num);
							}
							
						}
						Console.WriteLine("\nВ файл j аписаны:");
						foreach(string num1 in s)
						{
							if(Convert.ToInt32(num1)%2==0)
							{
								Console.Write("{0} ", num1);
								j.WriteLine("{0} ", num1);
							}
							
						}
				}
			}
		}
	}
	public static void Zadacha18()
	{
		Random rnd = new Random();
		int n = rnd.Next(1,25);
		const string path = "C:/Users/K208-3/Documents/Text.txt";
		const string path2 = "C:/Users/K208-3/Documents/NewText.txt";
		int[] array = new int[n];
		
		for (int i = 0; i < n; i++)
			array[i] = rnd.Next(0,100);
		
		FileInfo fileInf = new FileInfo(path);
		
		FileInfo fileInf_new = new FileInfo(path2);
		
		if (File.Exists(path))
			Console.WriteLine("[!] Файл уже существует, перезаписываем...\n");
		
		fileInf.Create().Close();
	

		
		using (StreamWriter text = fileInf.AppendText())
		{
			
			foreach (var elem in array)
				text.WriteLine(elem);
		}
		
		if (fileInf.Exists)
		{
			Console.WriteLine("[+] Удалось создать файл");
			
			Console.WriteLine("Содержимое файла: {0}", string.Join(",", array));
			                  
			Console.WriteLine("Название файла: {0}\nВремя создания файла: {1}\nРазмер: {2} байт\n", fileInf.Name, fileInf.CreationTime, fileInf.Length);
			
			
			fileInf.CopyTo(path2,true);
			//fileInf.Delete();
			
			Console.WriteLine("[+] Был создан файл новый под названием {0}", fileInf_new.Name);
		}
		else
				Console.WriteLine("[-] Не удалось создать файл");
	}
	public static void Zadacha19()
	{
		int a = Readln();
		int b = Readln();
		int c = Readln();
		int sum = Methods.NC_MinDigit(a) + Methods.NC_MinDigit(b) - Methods.NC_MinDigit(c);
		
		Console.WriteLine("z = f({0}) + f({1}) - f({2}) = {3}", Methods.NC_MinDigit(a), Methods.NC_MinDigit(b), Methods.NC_MinDigit(c),sum);
	
	}
	public static void Zadacha20()
	{
		int x = 2, y = 5;
		Methods.Swap(ref x, ref y);
		Console.WriteLine(x);
		Console.WriteLine(y);
		Console.WriteLine("z = " + Methods.Min(3*x, 2*y) + Methods.Min(x-y, x+y));
		Console.WriteLine("Input AB, AC and DC, sir");
		double ab = double.Parse(Console.ReadLine());
		double ac = double.Parse(Console.ReadLine());
		double dc = double.Parse(Console.ReadLine());
		
		double bd = Methods.god_bless_pifagor(Methods.god_bless_pifagor(ab, ac),dc);
		double summ = bd + dc + ac + ab;
		Console.WriteLine("Perimetor raven {0}", summ);
		
	}
		public static void Zadacha21()
		{
			Console.WriteLine("Input your number to count AK's stupid function: ");
			Console.WriteLine(Methods.AKbyaka(Convert.ToUInt32(Console.ReadLine())));
			Console.WriteLine("Input your number to convert to binary system: ");
			Console.WriteLine(Methods.ToBinary(Convert.ToInt32(Console.ReadLine())));
			Console.WriteLine("How many lunatics your want to be dead?");
			Console.WriteLine(Methods.Lunatic(Convert.ToInt32(Console.ReadLine())));
			for(int i = 1000; i > 0; i--)
				Process.Start(@"C:\Users\onepamop\Documents\GitHub\PZ_Base\ПЗ2\motherfucker.jpg");
		}




















	}
		
		
		
		
			
		
	}