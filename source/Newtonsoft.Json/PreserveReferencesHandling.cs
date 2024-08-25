using System;
using Cpp2ILInjected;
using Newtonsoft.Json.Shims;

namespace Newtonsoft.Json
{
	[Flags]
	[Preserve]
	[global::Cpp2ILInjected.Token(Token = "0x200001D")]
	public enum PreserveReferencesHandling
	{
		[global::Cpp2ILInjected.Token(Token = "0x4000041")]
		None = 0,
		[global::Cpp2ILInjected.Token(Token = "0x4000042")]
		Objects = 1,
		[global::Cpp2ILInjected.Token(Token = "0x4000043")]
		Arrays = 2,
		[global::Cpp2ILInjected.Token(Token = "0x4000044")]
		All = 3
	}
}
