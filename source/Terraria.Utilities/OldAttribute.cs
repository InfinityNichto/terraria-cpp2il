using System;
using Cpp2IlInjected;

namespace Terraria.Utilities;

[Cpp2IlInjected.Token(Token = "0x200037B")]
public sealed class OldAttribute : Attribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4003197")]
	private string message;

	[Cpp2IlInjected.Token(Token = "0x170005AB")]
	public string Message
	{
		[Cpp2IlInjected.Token(Token = "0x6002D1C")]
		[Cpp2IlInjected.Address(RVA = "0x10DE168", Offset = "0x10DE168", VA = "0x10DE168")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6002D1A")]
	[Cpp2IlInjected.Address(RVA = "0x10DE0E4", Offset = "0x10DE0E4", VA = "0x10DE0E4")]
	public OldAttribute()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002D1B")]
	[Cpp2IlInjected.Address(RVA = "0x10DE148", Offset = "0x10DE148", VA = "0x10DE148")]
	public OldAttribute(string message)
	{
	}
}
