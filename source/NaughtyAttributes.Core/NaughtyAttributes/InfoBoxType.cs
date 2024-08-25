using System;
using Cpp2ILInjected;

namespace NaughtyAttributes
{
	[global::Cpp2ILInjected.Token(Token = "0x200001C")]
	public enum InfoBoxType
	{
		[global::Cpp2ILInjected.Token(Token = "0x4000029")]
		Normal,
		[global::Cpp2ILInjected.Token(Token = "0x400002A")]
		Warning,
		[global::Cpp2ILInjected.Token(Token = "0x400002B")]
		Error
	}
}
