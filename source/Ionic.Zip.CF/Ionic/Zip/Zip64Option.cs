using System;
using Cpp2ILInjected;

namespace Ionic.Zip
{
	[global::Cpp2ILInjected.Token(Token = "0x200002A")]
	public enum Zip64Option
	{
		[global::Cpp2ILInjected.Token(Token = "0x40000FF")]
		Default,
		[global::Cpp2ILInjected.Token(Token = "0x4000100")]
		Never = 0,
		[global::Cpp2ILInjected.Token(Token = "0x4000101")]
		AsNecessary,
		[global::Cpp2ILInjected.Token(Token = "0x4000102")]
		Always
	}
}
