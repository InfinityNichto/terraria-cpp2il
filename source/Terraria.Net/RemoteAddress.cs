using Cpp2IlInjected;

namespace Terraria.Net;

[Cpp2IlInjected.Token(Token = "0x200049F")]
public abstract class RemoteAddress
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4006555")]
	public AddressType Type;

	[Cpp2IlInjected.Token(Token = "0x60033A0")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract string GetIdentifier();

	[Cpp2IlInjected.Token(Token = "0x60033A1")]
	[Cpp2IlInjected.Address(Slot = "5")]
	public abstract string GetFriendlyName();

	[Cpp2IlInjected.Token(Token = "0x60033A2")]
	[Cpp2IlInjected.Address(Slot = "6")]
	public abstract bool IsLocalHost();

	[Cpp2IlInjected.Token(Token = "0x60033A3")]
	[Cpp2IlInjected.Address(RVA = "0x142C478", Offset = "0x142C478", VA = "0x142C478")]
	protected RemoteAddress()
	{
	}
}
