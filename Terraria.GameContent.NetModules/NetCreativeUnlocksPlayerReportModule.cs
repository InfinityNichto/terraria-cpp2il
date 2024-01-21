using System.IO;
using Cpp2IlInjected;
using Terraria.Net;

namespace Terraria.GameContent.NetModules;

[Cpp2IlInjected.Token(Token = "0x2000674")]
public class NetCreativeUnlocksPlayerReportModule : NetModule
{
	[Cpp2IlInjected.Token(Token = "0x4006D85")]
	private const byte _requestItemSacrificeId = 0;

	[Cpp2IlInjected.Token(Token = "0x6004130")]
	[Cpp2IlInjected.Address(RVA = "0x105C2B8", Offset = "0x105C2B8", VA = "0x105C2B8")]
	public static NetPacket SerializeSacrificeRequest(int itemId, int amount)
	{
		return default(NetPacket);
	}

	[Cpp2IlInjected.Token(Token = "0x6004131")]
	[Cpp2IlInjected.Address(RVA = "0x105C3BC", Offset = "0x105C3BC", VA = "0x105C3BC", Slot = "4")]
	public override bool Deserialize(BinaryReader reader, int userId)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6004132")]
	[Cpp2IlInjected.Address(RVA = "0x105C414", Offset = "0x105C414", VA = "0x105C414")]
	public NetCreativeUnlocksPlayerReportModule()
	{
	}
}
