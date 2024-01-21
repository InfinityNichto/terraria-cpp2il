using System.IO;
using Cpp2IlInjected;
using Terraria.Net;

namespace Terraria.GameContent.NetModules;

[Cpp2IlInjected.Token(Token = "0x2000673")]
public class NetCreativePowersModule : NetModule
{
	[Cpp2IlInjected.Token(Token = "0x4006D84")]
	public static int specificPlrDeserialise;

	[Cpp2IlInjected.Token(Token = "0x600412C")]
	[Cpp2IlInjected.Address(RVA = "0x105BB40", Offset = "0x105BB40", VA = "0x105BB40")]
	public static NetPacket PreparePacket(ushort powerId, int specificInfoBytesInPacketCount)
	{
		return default(NetPacket);
	}

	[Cpp2IlInjected.Token(Token = "0x600412D")]
	[Cpp2IlInjected.Address(RVA = "0x105BC00", Offset = "0x105BC00", VA = "0x105BC00", Slot = "4")]
	public override bool Deserialize(BinaryReader reader, int userId)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600412E")]
	[Cpp2IlInjected.Address(RVA = "0x105C018", Offset = "0x105C018", VA = "0x105C018")]
	public NetCreativePowersModule()
	{
	}
}
