using System;
using Cpp2ILInjected;
using Newtonsoft.Json.Shims;

namespace Newtonsoft.Json
{
	[Flags]
	[Preserve]
	[global::Cpp2ILInjected.Token(Token = "0x2000021")]
	public enum DefaultValueHandling
	{
		[global::Cpp2ILInjected.Token(Token = "0x4000050")]
		Include = 0,
		[global::Cpp2ILInjected.Token(Token = "0x4000051")]
		Ignore = 1,
		[global::Cpp2ILInjected.Token(Token = "0x4000052")]
		Populate = 2,
		[global::Cpp2ILInjected.Token(Token = "0x4000053")]
		IgnoreAndPopulate = 3
	}
}
