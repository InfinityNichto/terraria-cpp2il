using System;
using Cpp2IlInjected;

namespace Terraria.Chat.Commands;

[Cpp2IlInjected.Token(Token = "0x2000532")]
[Cpp2IlInjected.Attribute(Name = "AttributeUsageAttribute", RVA = "0x385230", Offset = "0x385230")]
public sealed class ChatCommandAttribute : Attribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400689A")]
	public readonly string Name;

	[Cpp2IlInjected.Token(Token = "0x6003943")]
	[Cpp2IlInjected.Address(RVA = "0x11CD9B4", Offset = "0x11CD9B4", VA = "0x11CD9B4")]
	public ChatCommandAttribute(string name)
	{
	}
}
