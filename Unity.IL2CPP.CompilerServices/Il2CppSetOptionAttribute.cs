using System;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;

namespace Unity.IL2CPP.CompilerServices;

[Cpp2IlInjected.Token(Token = "0x200075F")]
[Cpp2IlInjected.Attribute(Name = "AttributeUsageAttribute", RVA = "0x3855C8", Offset = "0x3855C8")]
public class Il2CppSetOptionAttribute : Attribute
{
	[Cpp2IlInjected.Token(Token = "0x1700083A")]
	public Option Option
	{
		[Cpp2IlInjected.Token(Token = "0x600482E")]
		[Cpp2IlInjected.Address(RVA = "0xE87C48", Offset = "0xE87C48", VA = "0xE87C48")]
		[CompilerGenerated]
		get
		{
			return default(Option);
		}
		[Cpp2IlInjected.Token(Token = "0x600482F")]
		[Cpp2IlInjected.Address(RVA = "0xE87C50", Offset = "0xE87C50", VA = "0xE87C50")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700083B")]
	public object Value
	{
		[Cpp2IlInjected.Token(Token = "0x6004830")]
		[Cpp2IlInjected.Address(RVA = "0xE87C58", Offset = "0xE87C58", VA = "0xE87C58")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6004831")]
		[Cpp2IlInjected.Address(RVA = "0xE87C60", Offset = "0xE87C60", VA = "0xE87C60")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6004832")]
	[Cpp2IlInjected.Address(RVA = "0xE87C68", Offset = "0xE87C68", VA = "0xE87C68")]
	public Il2CppSetOptionAttribute(Option option, object value)
	{
	}
}
