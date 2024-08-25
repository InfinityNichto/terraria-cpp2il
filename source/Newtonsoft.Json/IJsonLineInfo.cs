using System;
using Cpp2ILInjected;
using Newtonsoft.Json.Shims;

namespace Newtonsoft.Json
{
	[Preserve]
	[global::Cpp2ILInjected.Token(Token = "0x200001E")]
	public interface IJsonLineInfo
	{
		[global::Cpp2ILInjected.Token(Token = "0x6000044")]
		bool HasLineInfo();

		[global::Cpp2ILInjected.Token(Token = "0x1700000A")]
		int LineNumber
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000045")]
			get;
		}

		[global::Cpp2ILInjected.Token(Token = "0x1700000B")]
		int LinePosition
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000046")]
			get;
		}
	}
}
