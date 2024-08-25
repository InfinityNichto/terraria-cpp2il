using System;
using Cpp2ILInjected;

namespace UnityEngine
{
	[Flags]
	[global::Cpp2ILInjected.Token(Token = "0x2000003")]
	internal enum TextGenerationError
	{
		[global::Cpp2ILInjected.Token(Token = "0x4000007")]
		None = 0,
		[global::Cpp2ILInjected.Token(Token = "0x4000008")]
		CustomSizeOnNonDynamicFont = 1,
		[global::Cpp2ILInjected.Token(Token = "0x4000009")]
		CustomStyleOnNonDynamicFont = 2,
		[global::Cpp2ILInjected.Token(Token = "0x400000A")]
		NoFont = 4
	}
}
