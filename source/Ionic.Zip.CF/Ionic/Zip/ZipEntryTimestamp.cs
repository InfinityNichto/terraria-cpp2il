using System;
using Cpp2ILInjected;

namespace Ionic.Zip
{
	[Flags]
	[global::Cpp2ILInjected.Token(Token = "0x2000022")]
	public enum ZipEntryTimestamp
	{
		[global::Cpp2ILInjected.Token(Token = "0x40000A7")]
		None = 0,
		[global::Cpp2ILInjected.Token(Token = "0x40000A8")]
		DOS = 1,
		[global::Cpp2ILInjected.Token(Token = "0x40000A9")]
		Windows = 2,
		[global::Cpp2ILInjected.Token(Token = "0x40000AA")]
		Unix = 4,
		[global::Cpp2ILInjected.Token(Token = "0x40000AB")]
		InfoZip1 = 8
	}
}
