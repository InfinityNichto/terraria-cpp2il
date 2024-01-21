using System.IO;
using Cpp2IlInjected;
using Terraria.GameContent.Ambience;
using Terraria.Net;

namespace Terraria.GameContent.NetModules;

[Cpp2IlInjected.Token(Token = "0x2000670")]
public class NetAmbienceModule : NetModule
{
	[Cpp2IlInjected.Token(Token = "0x6004121")]
	[Cpp2IlInjected.Address(RVA = "0x105AB4C", Offset = "0x105AB4C", VA = "0x105AB4C")]
	public static NetPacket SerializeSkyEntitySpawn(Player player, SkyEntityType type)
	{
		return default(NetPacket);
	}

	[Cpp2IlInjected.Token(Token = "0x6004122")]
	[Cpp2IlInjected.Address(RVA = "0x105AC94", Offset = "0x105AC94", VA = "0x105AC94", Slot = "4")]
	public override bool Deserialize(BinaryReader reader, int userId)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6004123")]
	[Cpp2IlInjected.Address(RVA = "0x105AE2C", Offset = "0x105AE2C", VA = "0x105AE2C")]
	public NetAmbienceModule()
	{
	}
}
