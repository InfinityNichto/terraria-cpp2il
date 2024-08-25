using System;
using Cpp2ILInjected;

namespace UnityEngine.Bindings
{
	[VisibleToOtherModules]
	[global::Cpp2ILInjected.Token(Token = "0x2000018")]
	internal enum StaticAccessorType
	{
		[global::Cpp2ILInjected.Token(Token = "0x400001E")]
		Dot,
		[global::Cpp2ILInjected.Token(Token = "0x400001F")]
		Arrow,
		[global::Cpp2ILInjected.Token(Token = "0x4000020")]
		DoubleColon,
		[global::Cpp2ILInjected.Token(Token = "0x4000021")]
		ArrowWithDefaultReturnIfNull
	}
}
