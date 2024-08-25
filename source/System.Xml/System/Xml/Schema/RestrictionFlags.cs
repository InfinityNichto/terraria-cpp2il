using System;
using Cpp2ILInjected;

namespace System.Xml.Schema
{
	[Flags]
	[global::Cpp2ILInjected.Token(Token = "0x20000DA")]
	internal enum RestrictionFlags
	{
		[global::Cpp2ILInjected.Token(Token = "0x4000453")]
		Length = 1,
		[global::Cpp2ILInjected.Token(Token = "0x4000454")]
		MinLength = 2,
		[global::Cpp2ILInjected.Token(Token = "0x4000455")]
		MaxLength = 4,
		[global::Cpp2ILInjected.Token(Token = "0x4000456")]
		Pattern = 8,
		[global::Cpp2ILInjected.Token(Token = "0x4000457")]
		Enumeration = 16,
		[global::Cpp2ILInjected.Token(Token = "0x4000458")]
		WhiteSpace = 32,
		[global::Cpp2ILInjected.Token(Token = "0x4000459")]
		MaxInclusive = 64,
		[global::Cpp2ILInjected.Token(Token = "0x400045A")]
		MaxExclusive = 128,
		[global::Cpp2ILInjected.Token(Token = "0x400045B")]
		MinInclusive = 256,
		[global::Cpp2ILInjected.Token(Token = "0x400045C")]
		MinExclusive = 512,
		[global::Cpp2ILInjected.Token(Token = "0x400045D")]
		TotalDigits = 1024,
		[global::Cpp2ILInjected.Token(Token = "0x400045E")]
		FractionDigits = 2048
	}
}
