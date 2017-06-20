using System;
using System.Text;
using System.Text.RegularExpressions;

namespace DecRDM
{
	class MainClass
	{
		/* Original code
		 var dec:Function = function(param1:String, param2:String):String
            {
               var _loc3_:ByteArray = HumanCheck["decodeToByteArray"](param1);
               var _loc4_:ByteArray = HumanCheck["decodeToByteArray"](param2);
               var _loc5_:uint = 0;
               while(_loc5_ < _loc3_.length)
               {
                  _loc3_[_loc5_] = _loc3_[_loc5_] ^ _loc4_[_loc5_ % _loc4_["length"]];
                  _loc5_++;
               }
               return _loc3_.toString();
            };
            */
		public static void Main(string[] args)
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
				string pattern = @"dec\(\""(.+?)\"",\""(.+?)\""\)";
				string result = Regex.Replace(content, pattern, m =>
				 {
					 string encrypted = m.Groups[1].Value;
					 string key = m.Groups[2].Value;
					return "\"" + dec(encrypted,key) + "\"";
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
				string[] splitted = command.Split(' ');
				Console.WriteLine(dec(splitted[0], splitted[1]));
			}*/
		}

		public static string dec(string param1, string param2)
		{
			byte[] _loc3_ = Convert.FromBase64String(param1);
			byte[] _loc4_ = Convert.FromBase64String(param2);
			uint _loc5_ = 0;

			while (_loc5_ < _loc3_.Length)
			{
				_loc3_[_loc5_] = (byte)(_loc3_[_loc5_] ^ _loc4_[_loc5_ % _loc4_.Length]);
				_loc5_++;
			}

			return Encoding.ASCII.GetString(_loc3_);
		}
	}
}
