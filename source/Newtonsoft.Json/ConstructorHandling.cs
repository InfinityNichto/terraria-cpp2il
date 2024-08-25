using System;
using Cpp2ILInjected;
using Newtonsoft.Json.Shims;

namespace Newtonsoft.Json
{
	[Preserve]
	[global::Cpp2ILInjected.Token(Token = "0x200000B")]
	public enum ConstructorHandling
	{
		[global::Cpp2ILInjected.Token(Token = "0x400000F")]
		Default,
		[global::Cpp2ILInjected.Token(Token = "0x4000010")]
		AllowNonPublicDefaultConstructor
	}
}
