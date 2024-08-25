using System;
using Cpp2ILInjected;

namespace System.Xml
{
	[global::Cpp2ILInjected.Token(Token = "0x200002E")]
	public enum ValidationType
	{
		[global::Cpp2ILInjected.Token(Token = "0x4000076")]
		None,
		[Obsolete("Validation type should be specified as DTD or Schema.")]
		[global::Cpp2ILInjected.Token(Token = "0x4000077")]
		Auto,
		[global::Cpp2ILInjected.Token(Token = "0x4000078")]
		DTD,
		[Obsolete("XDR Validation through XmlValidatingReader is obsoleted")]
		[global::Cpp2ILInjected.Token(Token = "0x4000079")]
		XDR,
		[global::Cpp2ILInjected.Token(Token = "0x400007A")]
		Schema
	}
}
