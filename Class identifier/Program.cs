using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Linq;

public class Class_identifier
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
			var identified = Identify(content);
			foreach(var item in identified)
			{
				Console.WriteLine($"{item.Key} : {item.Value}");
			}
			var replaced = Replace(content, identified);
			if (content == replaced) { Console.WriteLine("Error"); }
			else
			{
				Console.Write("Chemin du fichier décodé: ");
				filePath = Console.ReadLine();
				System.IO.File.WriteAllText(filePath, replaced);
			}
		}
    }

    public static Dictionary<string,string> Identify(string code)
    {
    	Dictionary<string,string> identified = new Dictionary<string,string>();
    	Dictionary<string,string> regexPatt = new Dictionary<string,string>
    	{
    		{"MD5",@"function (.+?)\(\)\s*{\s*super\(\);\s*}\s*public static function hash"},
    		{"RSAKey",@"function (.+?)\(param1:BigInteger, param2:int, param3:BigInteger = null, param4:BigInteger = null, param5:BigInteger = null, param6:BigInteger = null, param7:BigInteger = null, param8:BigInteger = null\)
   {"},
    		{"AESKey",@"class (.+?) implements ISymmetricKey"},
    		{"TLSPad",@"class (.+?) implements IPad"},
    		{"SimpleIVMode",@"class (.+?) implements IMode, ICipher"},
    		{"CBCMode",@"class (.+?) extends IVMode implements IMode"},
    		{"Base64",@"function (.+?)\(\)\s*{\s*super\(\);\s*throw new Error\(\""Base64 internal class is static container only\""\);"}
    	};

    	foreach(var item in regexPatt)
    	{
    		Regex r = new Regex(item.Value);
    		Match m = r.Match(code);
    		identified.Add(item.Key, m.Groups[1].Value.Replace(" ",""));
    	}
    	return identified;
    }

    public static string Replace(string code, Dictionary<string,string> identified)
    {
    	string result = code;
    	foreach(var item in identified)
    	{
    		result = result.Replace(item.Value, item.Key);
    	}
    	return result;
    }

}