using System.IO;
using Cpp2IlInjected;
using Microsoft.Xna.Framework.Graphics;
using Terraria.Chat;
using Terraria.Localization;
using Terraria.Net;

namespace Terraria.GameContent.NetModules;

[Cpp2IlInjected.Token(Token = "0x2000679")]
public class NetTextModule : NetModule
{
	[Cpp2IlInjected.Token(Token = "0x6004141")]
	[Cpp2IlInjected.Address(RVA = "0x105E254", Offset = "0x105E254", VA = "0x105E254")]
	public static NetPacket SerializeClientMessage(ChatMessage message)
	{
		return default(NetPacket);
	}

	[Cpp2IlInjected.Token(Token = "0x6004142")]
	[Cpp2IlInjected.Address(RVA = "0x105E318", Offset = "0x105E318", VA = "0x105E318")]
	public static NetPacket SerializeServerMessage(NetworkText text, Color color)
	{
		return default(NetPacket);
	}

	[Cpp2IlInjected.Token(Token = "0x6004143")]
	[Cpp2IlInjected.Address(RVA = "0x105E334", Offset = "0x105E334", VA = "0x105E334")]
	public static NetPacket SerializeServerMessage(NetworkText text, Color color, byte authorId)
	{
		return default(NetPacket);
	}

	[Cpp2IlInjected.Token(Token = "0x6004144")]
	[Cpp2IlInjected.Address(RVA = "0x105E470", Offset = "0x105E470", VA = "0x105E470")]
	private bool DeserializeAsClient(BinaryReader reader, int senderPlayerId)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6004145")]
	[Cpp2IlInjected.Address(RVA = "0x105E588", Offset = "0x105E588", VA = "0x105E588")]
	private bool DeserializeAsServer(BinaryReader reader, int senderPlayerId)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6004146")]
	[Cpp2IlInjected.Address(RVA = "0x105E62C", Offset = "0x105E62C", VA = "0x105E62C", Slot = "4")]
	public override bool Deserialize(BinaryReader reader, int senderPlayerId)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6004147")]
	[Cpp2IlInjected.Address(RVA = "0x105E6C8", Offset = "0x105E6C8", VA = "0x105E6C8")]
	public NetTextModule()
	{
	}
}
