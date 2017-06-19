using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RDM_Decrypt
{
	public class Second
	{
		private int first = 0; // _a_-___
		private int second = 0;// _a_---__
		private List<byte> third = new List<byte>();// _a_-_-_-
		private const uint fourth = 256; // _a_-__--

		public Second(BigEndianReader param1)
		{
			secondFunc(param1);
		}

		private uint firstFunc() // _a_--___
		{
			return fourth;
		}

		public void secondFunc(BigEndianReader param1) // _a_-
		{
			var loc2 = 0;
			var loc3 = 0;
			var loc4 = 0;
			loc2 = 0;
			while (loc2 < 256)
			{
				this.third.Add((byte)loc2);
				loc2++;
			}
			loc3 = 0;
			loc2 = 0;
			while (loc2 < 256)
			{
				var array = ((MemoryStream)param1.BaseStream).ToArray();
				loc3 = loc3 + this.third[loc2] + array[loc2 % array.Length] & 255;
				loc4 = third[loc2];
				third[loc2] = third[loc3];
				third[loc3] = (byte)loc4;
				loc2++;
			}
			first = 0;
			second = 0;
		}

		private uint thirdFunc() // _a_-__-
		{
			var loc1 = 0;
			first = first + 1 & 255;
			second = second + third[first] & 255;
			loc1 = third[first];
			third[first] = third[second];
			third[second] = (byte)loc1;
			return third[loc1 + third[first] & 255];
		}

		public uint fourthFunc() // _a_--_-_
		{
			return 1;
		}

		public void fifthFunc(byte[] param1) // _a_-_--_
		{
			uint loc2 = 0;
			while (loc2 < param1.Length)
			{
				param1[loc2] = (byte)(param1[loc2] ^ thirdFunc());
				loc2++;
			}
		}

		public void sixthFunc(byte[] param1) // _a_---_
		{
			fifthFunc(param1);
		}

		public void seventhFunc() // _a_-_-
		{

		}

	}
}