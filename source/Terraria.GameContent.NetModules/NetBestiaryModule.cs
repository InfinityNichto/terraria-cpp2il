using System.IO;
using Cpp2IlInjected;
using Terraria.Net;

namespace Terraria.GameContent.NetModules;

[Cpp2IlInjected.Token(Token = "0x2000671")]
public class NetBestiaryModule : NetModule
{
	[Cpp2IlInjected.Token(Token = "0x2000A5C")]
	private enum BestiaryUnlockType : byte
	{
		[Cpp2IlInjected.Token(Token = "0x4008E37")]
		Kill,
		[Cpp2IlInjected.Token(Token = "0x4008E38")]
		Sight,
		[Cpp2IlInjected.Token(Token = "0x4008E39")]
		Chat
	}

	[Cpp2IlInjected.Token(Token = "0x6004124")]
	[Cpp2IlInjected.Address(RVA = "0x105AFD0", Offset = "0x105AFD0", VA = "0x105AFD0")]
	public static NetPacket SerializeKillCount(int npcNetId, int killcount)
	{
		return default(NetPacket);
	}

	[Cpp2IlInjected.Token(Token = "0x6004125")]
	[Cpp2IlInjected.Address(RVA = "0x105B0D4", Offset = "0x105B0D4", VA = "0x105B0D4")]
	public static NetPacket SerializeSight(int npcNetId)
	{
		return default(NetPacket);
	}

	[Cpp2IlInjected.Token(Token = "0x6004126")]
	[Cpp2IlInjected.Address(RVA = "0x105B1B4", Offset = "0x105B1B4", VA = "0x105B1B4")]
	public static NetPacket SerializeChat(int npcNetId)
	{
		return default(NetPacket);
	}

	[Cpp2IlInjected.Token(Token = "0x6004127")]
	[Cpp2IlInjected.Address(RVA = "0x105B294", Offset = "0x105B294", VA = "0x105B294", Slot = "4")]
	public override bool Deserialize(BinaryReader reader, int userId)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6004128")]
	[Cpp2IlInjected.Address(RVA = "0x105B588", Offset = "0x105B588", VA = "0x105B588")]
	public NetBestiaryModule()
	{
	}
}
