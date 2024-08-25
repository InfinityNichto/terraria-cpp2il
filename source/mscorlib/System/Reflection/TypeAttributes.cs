using System;
using Cpp2ILInjected;

namespace System.Reflection
{
	[global::System.Flags]
	[global::Cpp2ILInjected.Token(Token = "0x20004F5")]
	public enum TypeAttributes
	{
		[global::Cpp2ILInjected.Token(Token = "0x400141E")]
		VisibilityMask = 7,
		[global::Cpp2ILInjected.Token(Token = "0x400141F")]
		NotPublic = 0,
		[global::Cpp2ILInjected.Token(Token = "0x4001420")]
		Public = 1,
		[global::Cpp2ILInjected.Token(Token = "0x4001421")]
		NestedPublic = 2,
		[global::Cpp2ILInjected.Token(Token = "0x4001422")]
		NestedPrivate = 3,
		[global::Cpp2ILInjected.Token(Token = "0x4001423")]
		NestedFamily = 4,
		[global::Cpp2ILInjected.Token(Token = "0x4001424")]
		NestedAssembly = 5,
		[global::Cpp2ILInjected.Token(Token = "0x4001425")]
		NestedFamANDAssem = 6,
		[global::Cpp2ILInjected.Token(Token = "0x4001426")]
		NestedFamORAssem = 7,
		[global::Cpp2ILInjected.Token(Token = "0x4001427")]
		LayoutMask = 24,
		[global::Cpp2ILInjected.Token(Token = "0x4001428")]
		AutoLayout = 0,
		[global::Cpp2ILInjected.Token(Token = "0x4001429")]
		SequentialLayout = 8,
		[global::Cpp2ILInjected.Token(Token = "0x400142A")]
		ExplicitLayout = 16,
		[global::Cpp2ILInjected.Token(Token = "0x400142B")]
		ClassSemanticsMask = 32,
		[global::Cpp2ILInjected.Token(Token = "0x400142C")]
		Class = 0,
		[global::Cpp2ILInjected.Token(Token = "0x400142D")]
		Interface = 32,
		[global::Cpp2ILInjected.Token(Token = "0x400142E")]
		Abstract = 128,
		[global::Cpp2ILInjected.Token(Token = "0x400142F")]
		Sealed = 256,
		[global::Cpp2ILInjected.Token(Token = "0x4001430")]
		SpecialName = 1024,
		[global::Cpp2ILInjected.Token(Token = "0x4001431")]
		Import = 4096,
		[global::Cpp2ILInjected.Token(Token = "0x4001432")]
		Serializable = 8192,
		[global::Cpp2ILInjected.Token(Token = "0x4001433")]
		WindowsRuntime = 16384,
		[global::Cpp2ILInjected.Token(Token = "0x4001434")]
		StringFormatMask = 196608,
		[global::Cpp2ILInjected.Token(Token = "0x4001435")]
		AnsiClass = 0,
		[global::Cpp2ILInjected.Token(Token = "0x4001436")]
		UnicodeClass = 65536,
		[global::Cpp2ILInjected.Token(Token = "0x4001437")]
		AutoClass = 131072,
		[global::Cpp2ILInjected.Token(Token = "0x4001438")]
		CustomFormatClass = 196608,
		[global::Cpp2ILInjected.Token(Token = "0x4001439")]
		CustomFormatMask = 12582912,
		[global::Cpp2ILInjected.Token(Token = "0x400143A")]
		BeforeFieldInit = 1048576,
		[global::Cpp2ILInjected.Token(Token = "0x400143B")]
		RTSpecialName = 2048,
		[global::Cpp2ILInjected.Token(Token = "0x400143C")]
		HasSecurity = 262144,
		[global::Cpp2ILInjected.Token(Token = "0x400143D")]
		ReservedMask = 264192
	}
}
