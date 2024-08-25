using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected;

namespace System.Security.Cryptography
{
	[global::System.Runtime.InteropServices.ComVisible(true)]
	[global::Cpp2ILInjected.Token(Token = "0x20002F2")]
	[global::System.Serializable]
	public struct RSAParameters
	{
		[global::Cpp2ILInjected.Token(Token = "0x4000CF5")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		public byte[] Exponent;

		[global::Cpp2ILInjected.Token(Token = "0x4000CF6")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x8")]
		public byte[] Modulus;

		[global::Cpp2ILInjected.Token(Token = "0x4000CF7")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		[global::System.NonSerialized]
		public byte[] P;

		[global::Cpp2ILInjected.Token(Token = "0x4000CF8")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		[global::System.NonSerialized]
		public byte[] Q;

		[global::Cpp2ILInjected.Token(Token = "0x4000CF9")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		[global::System.NonSerialized]
		public byte[] DP;

		[global::Cpp2ILInjected.Token(Token = "0x4000CFA")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		[global::System.NonSerialized]
		public byte[] DQ;

		[global::Cpp2ILInjected.Token(Token = "0x4000CFB")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		[global::System.NonSerialized]
		public byte[] InverseQ;

		[global::Cpp2ILInjected.Token(Token = "0x4000CFC")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		[global::System.NonSerialized]
		public byte[] D;
	}
}
