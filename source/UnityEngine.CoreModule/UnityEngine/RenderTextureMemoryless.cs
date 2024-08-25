using System;
using Cpp2ILInjected;

namespace UnityEngine
{
	[Flags]
	[global::Cpp2ILInjected.Token(Token = "0x200006F")]
	public enum RenderTextureMemoryless
	{
		[global::Cpp2ILInjected.Token(Token = "0x40002D6")]
		None = 0,
		[global::Cpp2ILInjected.Token(Token = "0x40002D7")]
		Color = 1,
		[global::Cpp2ILInjected.Token(Token = "0x40002D8")]
		Depth = 2,
		[global::Cpp2ILInjected.Token(Token = "0x40002D9")]
		MSAA = 4
	}
}
