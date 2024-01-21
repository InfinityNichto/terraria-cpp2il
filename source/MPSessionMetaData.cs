using System.Net;
using Cpp2IlInjected;

[Cpp2IlInjected.Token(Token = "0x2000211")]
public class MPSessionMetaData
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4001870")]
	public string WorldName;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4001871")]
	public IPAddress ServerAddress;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4001872")]
	public int ServerPort;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4001873")]
	public ushort WorldXSize;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4001874")]
	public int NumberOfPlayers;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4001875")]
	public int MaxPlayers;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4001876")]
	public short GameMode;

	[Cpp2IlInjected.FieldOffset(Offset = "0x22")]
	[Cpp2IlInjected.Token(Token = "0x4001877")]
	public bool Corruption;

	[Cpp2IlInjected.FieldOffset(Offset = "0x23")]
	[Cpp2IlInjected.Token(Token = "0x4001878")]
	public bool HardMode;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4001879")]
	public string HostName;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400187A")]
	public bool InviteOnly;

	[Cpp2IlInjected.Token(Token = "0x6000EF9")]
	[Cpp2IlInjected.Address(RVA = "0x12DFF94", Offset = "0x12DFF94", VA = "0x12DFF94")]
	public MPSessionMetaData()
	{
	}
}
