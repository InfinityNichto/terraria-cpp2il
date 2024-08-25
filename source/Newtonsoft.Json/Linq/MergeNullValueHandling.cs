using System;
using Cpp2ILInjected;
using Newtonsoft.Json.Shims;

namespace Newtonsoft.Json.Linq
{
	[Flags]
	[Preserve]
	[global::Cpp2ILInjected.Token(Token = "0x20000BE")]
	public enum MergeNullValueHandling
	{
		[global::Cpp2ILInjected.Token(Token = "0x40002FB")]
		Ignore = 0,
		[global::Cpp2ILInjected.Token(Token = "0x40002FC")]
		Merge = 1
	}
}
