using System;
using Cpp2ILInjected;

namespace System.IO
{
	[global::System.Flags]
	[global::Cpp2ILInjected.Token(Token = "0x2000537")]
	public enum FileShare
	{
		[global::Cpp2ILInjected.Token(Token = "0x400157D")]
		None = 0,
		[global::Cpp2ILInjected.Token(Token = "0x400157E")]
		Read = 1,
		[global::Cpp2ILInjected.Token(Token = "0x400157F")]
		Write = 2,
		[global::Cpp2ILInjected.Token(Token = "0x4001580")]
		ReadWrite = 3,
		[global::Cpp2ILInjected.Token(Token = "0x4001581")]
		Delete = 4,
		[global::Cpp2ILInjected.Token(Token = "0x4001582")]
		Inheritable = 16
	}
}
