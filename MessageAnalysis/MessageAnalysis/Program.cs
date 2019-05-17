using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// 
/// Горюнов Евгений
/// 
/// д) ***Создать метод, который производит частотный анализ текста. 
/// В качестве параметра в него передается массив слов и текст, 
/// в качестве результата метод возвращает сколько раз каждое из слов массива входит в этот текст. 
/// Здесь требуется использовать класс Dictionary.
/// </summary>

namespace MessageAnalysis
{
	class Program
	{
		static void Main(string[] args)
		{

			String[] sArray = { "куртку", "меч", "не", "дверь", "налоговая" };
			//String[] sArray = { "мот", "пар", "ключ", "дверь", "налоговая" };
			string text = "Трактирщик вытер руки полотняным фартуком и наполнил щербатую глиняную кружку. Незнакомец не " +
						  "был стар, но волосы у него были почти совершенно белыми.Под плащом он носил потертую " +
						  "кожаную куртку со шнуровкой у горла и на рукавах. " +
						  "Когда сбросил плащ, стало видно, что на ремне за спиной у него висит меч. " +
						  "Ничего странного в этом не было, в Вызиме почти все ходили с оружием, правда, " +
						  "никто не носил меч на спине, словно лук или колчан.";

			Dictionary<string, int> dl = new Dictionary<string, int>();
			dl = Message.Analys(sArray, text);
			foreach(KeyValuePair<string,int> keyValue in dl)
			{
				Console.WriteLine(keyValue.Key + " - " + keyValue.Value);
			}
		}
	}
}
