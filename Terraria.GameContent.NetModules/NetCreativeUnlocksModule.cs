using System.IO;
using Cpp2IlInjected;
using Terraria.Net;

namespace Terraria.GameContent.NetModules;

[Cpp2IlInjected.Token(Token = "0x2000672")]
public class NetCreativeUnlocksModule : NetModule
{
	[Cpp2IlInjected.Token(Token = "0x6004129")]
	[Cpp2IlInjected.Address(RVA = "0x105C07C", Offset = "0x105C07C", VA = "0x105C07C")]
	public static NetPacket SerializeItemSacrifice(int itemId, int sacrificeCount)
	{
		return default(NetPacket);
	}

	[Cpp2IlInjected.Token(Token = "0x600412A")]
	[Cpp2IlInjected.Address(RVA = "0x105C160", Offset = "0x105C160", VA = "0x105C160", Slot = "4")]
	public override bool Deserialize(BinaryReader reader, int userId)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600412B")]
	[Cpp2IlInjected.Address(RVA = "0x105C2B0", Offset = "0x105C2B0", VA = "0x105C2B0")]
	public NetCreativeUnlocksModule()
	{
	}
}
