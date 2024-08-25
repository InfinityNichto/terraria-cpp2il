using System;
using Cpp2ILInjected;

namespace System.Reflection
{
	[global::System.Flags]
	[global::Cpp2ILInjected.Token(Token = "0x20004CB")]
	public enum CallingConventions
	{
		[global::Cpp2ILInjected.Token(Token = "0x4001380")]
		Standard = 1,
		[global::Cpp2ILInjected.Token(Token = "0x4001381")]
		VarArgs = 2,
		[global::Cpp2ILInjected.Token(Token = "0x4001382")]
		Any = 3,
		[global::Cpp2ILInjected.Token(Token = "0x4001383")]
		HasThis = 32,
		[global::Cpp2ILInjected.Token(Token = "0x4001384")]
		ExplicitThis = 64
	}
}
