using System;

public class FunctionReplace
{

	public static void Main()
	{
		Console.Write("Chemin du fichier HumanCheck.as: ");
		string filePath = Console.ReadLine();
		if (!System.IO.File.Exists(filePath))
		{
			Console.WriteLine("Ce fichier n'existe pas !");
		}
		else
		{
			string content = System.IO.File.ReadAllText(filePath);
			string result = content.Replace("[\"", ".").Replace("\"]","");
			Console.Write("Chemin du fichier décodé: ");
			filePath = Console.ReadLine();
			System.IO.File.WriteAllText(filePath, result);
		}
	}

}