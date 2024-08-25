using System;
using System.Net;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Terraria;

[global::Cpp2ILInjected.Token(Token = "0x20002B6")]
public class MPSessionMetaData
{
	[global::Cpp2ILInjected.Token(Token = "0x6001016")]
	[global::Cpp2ILInjected.Address(RVA = "0xA3B8C0", Offset = "0xA3B8C0", Length = "0x10")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Netplay), Member = "StartBroadCasting", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
	public MPSessionMetaData()
	{
		throw null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x4001D93")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
	public string WorldName;

	[global::Cpp2ILInjected.Token(Token = "0x4001D94")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
	public IPAddress ServerAddress;

	[global::Cpp2ILInjected.Token(Token = "0x4001D95")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
	public int ServerPort;

	[global::Cpp2ILInjected.Token(Token = "0x4001D96")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x24")]
	public ushort WorldXSize;

	[global::Cpp2ILInjected.Token(Token = "0x4001D97")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
	public int NumberOfPlayers;

	[global::Cpp2ILInjected.Token(Token = "0x4001D98")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x2C")]
	public int MaxPlayers;

	[global::Cpp2ILInjected.Token(Token = "0x4001D99")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
	public short GameMode;

	[global::Cpp2ILInjected.Token(Token = "0x4001D9A")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x32")]
	public bool Corruption;

	[global::Cpp2ILInjected.Token(Token = "0x4001D9B")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x33")]
	public bool HardMode;

	[global::Cpp2ILInjected.Token(Token = "0x4001D9C")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
	public string HostName;

	[global::Cpp2ILInjected.Token(Token = "0x4001D9D")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
	public bool InviteOnly;
}
