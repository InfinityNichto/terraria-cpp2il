using System;
using Cpp2ILInjected;

namespace System.Security.Cryptography.X509Certificates
{
	[Flags]
	[global::Cpp2ILInjected.Token(Token = "0x20000F9")]
	public enum X500DistinguishedNameFlags
	{
		[global::Cpp2ILInjected.Token(Token = "0x4000487")]
		None = 0,
		[global::Cpp2ILInjected.Token(Token = "0x4000488")]
		Reversed = 1,
		[global::Cpp2ILInjected.Token(Token = "0x4000489")]
		UseSemicolons = 16,
		[global::Cpp2ILInjected.Token(Token = "0x400048A")]
		DoNotUsePlusSign = 32,
		[global::Cpp2ILInjected.Token(Token = "0x400048B")]
		DoNotUseQuotes = 64,
		[global::Cpp2ILInjected.Token(Token = "0x400048C")]
		UseCommas = 128,
		[global::Cpp2ILInjected.Token(Token = "0x400048D")]
		UseNewLines = 256,
		[global::Cpp2ILInjected.Token(Token = "0x400048E")]
		UseUTF8Encoding = 4096,
		[global::Cpp2ILInjected.Token(Token = "0x400048F")]
		UseT61Encoding = 8192,
		[global::Cpp2ILInjected.Token(Token = "0x4000490")]
		ForceUTF8Encoding = 16384
	}
}
