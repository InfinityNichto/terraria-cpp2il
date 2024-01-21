using Cpp2IlInjected;

namespace Telepathy;

[Cpp2IlInjected.Token(Token = "0x200025A")]
public struct Message
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4001C3D")]
	public readonly int connectionId;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4001C3E")]
	public readonly EventType eventType;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4001C3F")]
	public readonly byte[] data;

	[Cpp2IlInjected.Token(Token = "0x600114D")]
	[Cpp2IlInjected.Address(RVA = "0x39B91C", Offset = "0x39B91C", VA = "0x39B91C")]
	public Message(int connectionId, EventType eventType, byte[] data)
	{
	}
}
