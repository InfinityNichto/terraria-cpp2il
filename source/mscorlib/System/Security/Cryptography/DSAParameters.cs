using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected;

namespace System.Security.Cryptography
{
	[global::System.Runtime.InteropServices.ComVisible(true)]
	[global::Cpp2ILInjected.Token(Token = "0x20002D6")]
	[global::System.Serializable]
	public struct DSAParameters
	{
		[global::Cpp2ILInjected.Token(Token = "0x4000CA5")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		public byte[] P;

		[global::Cpp2ILInjected.Token(Token = "0x4000CA6")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x8")]
		public byte[] Q;

		[global::Cpp2ILInjected.Token(Token = "0x4000CA7")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		public byte[] G;

		[global::Cpp2ILInjected.Token(Token = "0x4000CA8")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		public byte[] Y;

		[global::Cpp2ILInjected.Token(Token = "0x4000CA9")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		public byte[] J;

		[global::Cpp2ILInjected.Token(Token = "0x4000CAA")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		[global::System.NonSerialized]
		public byte[] X;

		[global::Cpp2ILInjected.Token(Token = "0x4000CAB")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		public byte[] Seed;

		[global::Cpp2ILInjected.Token(Token = "0x4000CAC")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		public int Counter;
	}
}
