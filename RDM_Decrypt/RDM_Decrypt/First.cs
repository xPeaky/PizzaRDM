using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RDM_Decrypt
{
	public class First // _a_-_---
	{
		private static List<string> first = new List<string>(); // _a_-____
		private static List<BigEndianReader> second = new List<BigEndianReader>(); // _a_----
		private static bool third = false; // _a_-___-
		private static int fourth = 0; // _a_--
		private static List<byte[]> resources;

		private static void firstFunc() // _a_-_--
		{
			var loc1 = new BigEndianReader(new MemoryStream(resources[0]));
			var loc2 = new BigEndianReader(new MemoryStream(resources[1]));
			var loc3 = new BinaryReader(new MemoryStream(resources[2]));
			fourth = loc3.ReadInt32();
			int loc4 = loc2.ReadByte();
			var loc5 = 0;
			while (loc5 < loc4)
			{
				thirdFunc(loc2);
				loc5++;
			}
			loc1.BaseStream.Position = 0;
			loc4 = loc1.ReadInt32();
			var loc6 = 0;
			while (loc6 < loc4)
			{
				secondFunc(loc1, second[loc6 % second.Count]);
				loc6++;
			}
			third = true;
		}

		private static void secondFunc(BigEndianReader param1, BigEndianReader param2) // _a_--__
		{
			int loc3 = param1.ReadInt32();
			byte[] loc4 = new byte[loc3];
			param1.Read(loc4, 0, loc3);
			var loc5 = new Second(param2);
			loc5.sixthFunc(loc4);
			var reader = new BinaryReader(new MemoryStream(loc4));
			byte[] readed = new byte[loc4.Length];
			reader.Read(readed, 0, loc4.Length);
			first.Add(Encoding.UTF8.GetString(readed));
		}

		private static void thirdFunc(BigEndianReader param1) // _a_-__-_
		{
			byte[] loc2 = param1.ReadBytes(16);
			second.Add(new BigEndianReader(new MemoryStream(loc2)));
		}

		private static string fourthFunc(int param1) // _a_--_--
		{
			if (!third)
			{
				firstFunc();
			}
			return first[param1 ^ fourth];
		}

		public static string GetDefinitionName(int value, List<byte[]> binaryDatas)
		{
			resources = binaryDatas;
			return fourthFunc(value);
		}
	}
}