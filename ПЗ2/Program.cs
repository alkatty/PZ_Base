using System;

namespace ПЗ2
{
	class MainProgram
	{
		
		public static void Main()
		{
			ConsoleKeyInfo CKI;
			int number;
			bool run_program = true;
			//CKI = ConsoleKey.Backspace;
			while(run_program /*& !CKI.Key.Equals(ConsoleKey.Escape)*/)
			{
				Console.WriteLine("Какую задачу вам решить? Для выбора перемещайте курсор.");
				number = Methods.Choise2();
				switch (number)
				{
					case 0: run_program = false; break;
					case 1: Program.Zadacha1(); break;
					case 2: Program.Zadacha2(); break;
					case 3: Program.Zadacha3(); break;
					case 4: Program.Zadacha4(); break;
					case 5: Program.Zadacha5(); break;
					case 6: Program.Zadacha6(); break;
					case 7: Program.Zadacha7(); break;
					case 8: Program.Zadacha8(); break;
					case 9: Program.Zadacha9(); break;
					case 10: Program.Zadacha10(); break;
					case 11: Program.Zadacha11(); break;
					case 12: Program.Zadacha12(); break;
					case 13: Program.Zadacha13(); break;
					case 14: Program.Zadacha141(); break;
					case 15: Program.Zadacha15(); break;
					case 16: Program.Zadacha16(); break;
					case 17: Program.Zadacha17(); break;
					case 18: Program.Zadacha18(); break;
					case 19: Program.Zadacha19(); break;
					case 20:Program.Zadacha20(); break;

					default: run_program = false; break;	
				}	
			if (Console.ReadKey(true).Key == ConsoleKey.Escape)
					run_program = false;				
			}
		}
	}
}



	
	
	