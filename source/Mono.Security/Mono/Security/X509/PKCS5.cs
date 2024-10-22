﻿using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace Mono.Security.X509
{
	[global::Cpp2ILInjected.Token(Token = "0x200000B")]
	public class PKCS5
	{
		[global::Cpp2ILInjected.Token(Token = "0x6000044")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A7B890", Offset = "0x1A7B890", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public PKCS5()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x4000019")]
		public const string pbeWithMD2AndDESCBC = "1.2.840.113549.1.5.1";

		[global::Cpp2ILInjected.Token(Token = "0x400001A")]
		public const string pbeWithMD5AndDESCBC = "1.2.840.113549.1.5.3";

		[global::Cpp2ILInjected.Token(Token = "0x400001B")]
		public const string pbeWithMD2AndRC2CBC = "1.2.840.113549.1.5.4";

		[global::Cpp2ILInjected.Token(Token = "0x400001C")]
		public const string pbeWithMD5AndRC2CBC = "1.2.840.113549.1.5.6";

		[global::Cpp2ILInjected.Token(Token = "0x400001D")]
		public const string pbeWithSHA1AndDESCBC = "1.2.840.113549.1.5.10";

		[global::Cpp2ILInjected.Token(Token = "0x400001E")]
		public const string pbeWithSHA1AndRC2CBC = "1.2.840.113549.1.5.11";
	}
}
