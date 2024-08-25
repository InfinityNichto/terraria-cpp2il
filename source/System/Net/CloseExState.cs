using System;
using Cpp2ILInjected;

namespace System.Net
{
	[Flags]
	[global::Cpp2ILInjected.Token(Token = "0x20001ED")]
	internal enum CloseExState
	{
		[global::Cpp2ILInjected.Token(Token = "0x4000A80")]
		Normal = 0,
		[global::Cpp2ILInjected.Token(Token = "0x4000A81")]
		Abort = 1,
		[global::Cpp2ILInjected.Token(Token = "0x4000A82")]
		Silent = 2
	}
}
