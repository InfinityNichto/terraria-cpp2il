using System;
using Cpp2ILInjected;

namespace System.Threading
{
	[global::Cpp2ILInjected.Token(Token = "0x20001F9")]
	[global::System.Serializable]
	internal enum StackCrawlMark
	{
		[global::Cpp2ILInjected.Token(Token = "0x40009B0")]
		LookForMe,
		[global::Cpp2ILInjected.Token(Token = "0x40009B1")]
		LookForMyCaller,
		[global::Cpp2ILInjected.Token(Token = "0x40009B2")]
		LookForMyCallersCaller,
		[global::Cpp2ILInjected.Token(Token = "0x40009B3")]
		LookForThread
	}
}
