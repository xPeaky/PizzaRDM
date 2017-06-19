using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RDM_Decrypt
{
	public class BigEndianReader : BinaryReader
	{
		public BigEndianReader(Stream input) : base(input)
		{

		}

		public override short ReadInt16()
		{
			byte[] b = ReadBytes(2);
			return (short)(b[1] + (b[0] << 8));
		}
		public override int ReadInt32()
		{
			byte[] b = ReadBytes(4);
			return b[3] + (b[2] << 8) + (b[1] << 16) + (b[0] << 24);
		}
		public override long ReadInt64()
		{
			byte[] b = ReadBytes(8);
			return b[7] + (b[6] << 8) + (b[5] << 16) + (b[4] << 24) + (b[3] << 32) + (b[2] << 40) + (b[1] << 48) + (b[0] << 56);
		}

		/// <summary>Returns <c>true</c> if the Int32 read is not zero, otherwise, <c>false</c>.</summary>
		/// <returns><c>true</c> if the Int32 is not zero, otherwise, <c>false</c>.</returns>
		public bool ReadInt32AsBool()
		{
			byte[] b = ReadBytes(4);
			if (b[0] == 0 || b[1] == 0 || b[2] == 0 || b[3] == 0)
				return false;
			else
				return true;
		}

		/// <summary>
		/// Reads a string prefixed by a 32-bit integer identifying its length, in chars.
		/// </summary>
		public string ReadString32BitPrefix()
		{
			int length = ReadInt32();
			return Encoding.ASCII.GetString(ReadBytes(length));
		}

		public float ReadFloat()
		{
			return (float)ReadDouble();
		}
	}
}