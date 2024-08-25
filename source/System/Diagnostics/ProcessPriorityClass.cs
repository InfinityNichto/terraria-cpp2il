using System;
using Cpp2ILInjected;

namespace System.Diagnostics
{
	[global::Cpp2ILInjected.Token(Token = "0x20000E1")]
	public enum ProcessPriorityClass
	{
		[global::Cpp2ILInjected.Token(Token = "0x400041D")]
		AboveNormal = 32768,
		[global::Cpp2ILInjected.Token(Token = "0x400041E")]
		BelowNormal = 16384,
		[global::Cpp2ILInjected.Token(Token = "0x400041F")]
		High = 128,
		[global::Cpp2ILInjected.Token(Token = "0x4000420")]
		Idle = 64,
		[global::Cpp2ILInjected.Token(Token = "0x4000421")]
		Normal = 32,
		[global::Cpp2ILInjected.Token(Token = "0x4000422")]
		RealTime = 256
	}
}
