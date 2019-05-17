using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// 
/// Горюнов Евгений
/// 
/// *Для двух строк написать метод, определяющий, является ли одна строка перестановкой другой.
/// Например:
/// badc являются перестановкой abcd.

/// </summary>

namespace Permutation
{
	class Program
	{
		static void Main(string[] args)
		{
			string text1 = "qwe";
			string text2 = "ewq";
			int count = 0;

			
			void IsPermutation(string t1, string t2)
			{
				StringBuilder newSB1 = new StringBuilder();
				StringBuilder newSB2 = new StringBuilder();

				newSB1.Append(text1);
				newSB2.Append(text2);

				if (t1.Length == t2.Length)
				{
					for (int i = 0; i < text1.Length; i++)
					{
						if (newSB1[i] == newSB2[(newSB2.Length - 1) - i])
						{
							count++;
						}
					}
				}
				else
				{
					Console.WriteLine("Строки явно разные, т.к. у них разная длина");
				}

				if (count == t1.Length && count == t2.Length)
				{
					Console.WriteLine("Первая строка является перестановкой второй строки");
				}
				else
				{
					Console.WriteLine("Первая строка НЕ является перестановкой второй строки");
				}

			}

			IsPermutation(text1, text2);
		}
	}
}
