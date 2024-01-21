using Cpp2IlInjected;
using Telepathy;

namespace Terraria;

[Cpp2IlInjected.Token(Token = "0x200033B")]
public class RemoteServer
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4002EBB")]
	public Telepathy.Server Client;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4002EBC")]
	public bool IsActive;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4002EBD")]
	public int State;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4002EBE")]
	public int TimeOutTimer;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4002EBF")]
	public string StatusText;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4002EC0")]
	public int StatusCount;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4002EC1")]
	public int StatusMax;

	[Cpp2IlInjected.Token(Token = "0x60026FE")]
	[Cpp2IlInjected.Address(RVA = "0x14DC14C", Offset = "0x14DC14C", VA = "0x14DC14C")]
	public RemoteServer()
	{
	}
}
