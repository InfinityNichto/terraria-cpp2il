using System;
using Cpp2ILInjected;

namespace System.IO
{
	[global::System.Flags]
	[global::Cpp2ILInjected.Token(Token = "0x2000536")]
	public enum FileOptions
	{
		[global::Cpp2ILInjected.Token(Token = "0x4001575")]
		None = 0,
		[global::Cpp2ILInjected.Token(Token = "0x4001576")]
		WriteThrough = -2147483648,
		[global::Cpp2ILInjected.Token(Token = "0x4001577")]
		Asynchronous = 1073741824,
		[global::Cpp2ILInjected.Token(Token = "0x4001578")]
		RandomAccess = 268435456,
		[global::Cpp2ILInjected.Token(Token = "0x4001579")]
		DeleteOnClose = 67108864,
		[global::Cpp2ILInjected.Token(Token = "0x400157A")]
		SequentialScan = 134217728,
		[global::Cpp2ILInjected.Token(Token = "0x400157B")]
		Encrypted = 16384
	}
}
