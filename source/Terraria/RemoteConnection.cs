using Cpp2IlInjected;
using Telepathy;

namespace Terraria;

[Cpp2IlInjected.Token(Token = "0x200033A")]
public class RemoteConnection
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4002EB4")]
	public Client Client;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4002EB5")]
	public bool IsActive;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4002EB6")]
	public int State;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4002EB7")]
	public int TimeOutTimer;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4002EB8")]
	public string StatusText;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4002EB9")]
	public int StatusCount;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4002EBA")]
	public int StatusMax;

	[Cpp2IlInjected.Token(Token = "0x60026FD")]
	[Cpp2IlInjected.Address(RVA = "0x14DC0D8", Offset = "0x14DC0D8", VA = "0x14DC0D8")]
	public RemoteConnection()
	{
	}
}
