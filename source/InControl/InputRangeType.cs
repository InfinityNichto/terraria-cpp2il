using System;
using Cpp2ILInjected;

namespace InControl
{
	[global::Cpp2ILInjected.Token(Token = "0x2000025")]
	public enum InputRangeType
	{
		[global::Cpp2ILInjected.Token(Token = "0x40001CB")]
		None,
		[global::Cpp2ILInjected.Token(Token = "0x40001CC")]
		MinusOneToOne,
		[global::Cpp2ILInjected.Token(Token = "0x40001CD")]
		OneToMinusOne,
		[global::Cpp2ILInjected.Token(Token = "0x40001CE")]
		ZeroToOne,
		[global::Cpp2ILInjected.Token(Token = "0x40001CF")]
		ZeroToMinusOne,
		[global::Cpp2ILInjected.Token(Token = "0x40001D0")]
		OneToZero,
		[global::Cpp2ILInjected.Token(Token = "0x40001D1")]
		MinusOneToZero
	}
}
