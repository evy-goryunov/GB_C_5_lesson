using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace MessageAnalysis
{
	static class Message
	{
		public static Dictionary<string, int> Analys(String[] s, string t)
		{
			Dictionary<string, int> dList = new Dictionary<string, int>();

			int a = 0;

			for (int i = 0; i < s.Length; i++)
			{
				string mask = s[i];

				// используем класс регулярных выражений для поиска по передаваемой в объект myReg маске.
				Regex myReg = new Regex(mask);

				// логика проверки на частоту вхождения
				if (myReg.IsMatch(t) || dList.TryGetValue(s[i], out a))
				{
					dList[s[i]] = ++a;
				}
				else
				{
					dList.Add(s[i], 0);
				}
			}

			return dList;
		}
	}
}
