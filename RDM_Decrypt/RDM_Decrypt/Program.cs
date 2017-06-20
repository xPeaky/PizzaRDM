using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;

namespace RDM_Decrypt
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			List<byte[]> binaryDatas = new List<byte[]>();
			binaryDatas.Add(File.ReadAllBytes("4__a_-_-__.bin"));
			binaryDatas.Add(File.ReadAllBytes("5__a_-_.bin"));
			binaryDatas.Add(File.ReadAllBytes("6__a_---.bin"));

			Console.Write("Chemin du fichier HumanCheck.as: ");
			string filePath = Console.ReadLine();
			if (!System.IO.File.Exists(filePath))
			{
				Console.WriteLine("Ce fichier n'existe pas !");
			}
			else
			{
				string content = System.IO.File.ReadAllText(filePath);
				string pattern = @"§_a_-_---§\.§_a_--_--§\(-([0-9]*)\)";
				string result = Regex.Replace(content, pattern, m =>
				 {
					 int value = -(Convert.ToInt32(m.Groups[1].Value));
					return "\"" + First.GetDefinitionName(value, binaryDatas) + "\"";
				 });

				Console.Write("Chemin du fichier décodé: ");
				filePath = Console.ReadLine();
				System.IO.File.WriteAllText(filePath, result);
			}

			/*while (true)
			{
				Console.Write(">>> ");
				string command = Console.ReadLine();
				if (command == "exit")
				{
					break;
				}

				Console.WriteLine(First.GetDefinitionName(Convert.ToInt32(command), binaryDatas));
			}*/
		}
	}
}
