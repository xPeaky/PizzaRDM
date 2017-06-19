using System;
using System.Collections.Generic;
using System.IO;

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

			while (true)
			{
				Console.Write(">>> ");
				string command = Console.ReadLine();
				if (command == "exit")
				{
					break;
				}

				Console.WriteLine(First.GetDefinitionName(Convert.ToInt32(command), binaryDatas));
			}
		}
	}
}
