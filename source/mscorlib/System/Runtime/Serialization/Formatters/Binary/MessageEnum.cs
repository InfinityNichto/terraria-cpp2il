using System;
using Cpp2ILInjected;

namespace System.Runtime.Serialization.Formatters.Binary
{
	[global::System.Flags]
	[global::Cpp2ILInjected.Token(Token = "0x200042C")]
	[global::System.Serializable]
	internal enum MessageEnum
	{
		[global::Cpp2ILInjected.Token(Token = "0x40011DC")]
		NoArgs = 1,
		[global::Cpp2ILInjected.Token(Token = "0x40011DD")]
		ArgsInline = 2,
		[global::Cpp2ILInjected.Token(Token = "0x40011DE")]
		ArgsIsArray = 4,
		[global::Cpp2ILInjected.Token(Token = "0x40011DF")]
		ArgsInArray = 8,
		[global::Cpp2ILInjected.Token(Token = "0x40011E0")]
		NoContext = 16,
		[global::Cpp2ILInjected.Token(Token = "0x40011E1")]
		ContextInline = 32,
		[global::Cpp2ILInjected.Token(Token = "0x40011E2")]
		ContextInArray = 64,
		[global::Cpp2ILInjected.Token(Token = "0x40011E3")]
		MethodSignatureInArray = 128,
		[global::Cpp2ILInjected.Token(Token = "0x40011E4")]
		PropertyInArray = 256,
		[global::Cpp2ILInjected.Token(Token = "0x40011E5")]
		NoReturnValue = 512,
		[global::Cpp2ILInjected.Token(Token = "0x40011E6")]
		ReturnValueVoid = 1024,
		[global::Cpp2ILInjected.Token(Token = "0x40011E7")]
		ReturnValueInline = 2048,
		[global::Cpp2ILInjected.Token(Token = "0x40011E8")]
		ReturnValueInArray = 4096,
		[global::Cpp2ILInjected.Token(Token = "0x40011E9")]
		ExceptionInArray = 8192,
		[global::Cpp2ILInjected.Token(Token = "0x40011EA")]
		GenericMethod = 32768
	}
}
