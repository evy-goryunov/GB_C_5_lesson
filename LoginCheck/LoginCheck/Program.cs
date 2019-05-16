using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

/// <summary>
/// Горюнов Евгений
/// 
/// Создать программу, которая будет проверять корректность ввода логина. 
/// Корректным логином будет строка от 2 до 10 символов, 
/// содержащая только буквы латинского алфавита или цифры, 
/// при этом цифра не может быть первой:
/// б) **с использованием регулярных выражений.
/// </summary>

namespace LoginCheck
{
	class Program
	{
		static void Main(string[] args)
		{
			
			Console.WriteLine("Придумайте логин");
			string login = Console.ReadLine();

			Regex myNewReg = new Regex(@"^[^0-9][a-z,0-9]{2,10}$");

			if (!myNewReg.IsMatch(login))
			{
				Console.WriteLine("Логин должен содержать от 2 до 10 символов, \nтолько буквы латинского алфавита или цифры, \nпри этом цифра не может быть первой");
			}

		}
	}
}
