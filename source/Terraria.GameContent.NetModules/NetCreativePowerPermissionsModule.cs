using System.IO;
using Cpp2IlInjected;
using Terraria.Net;

namespace Terraria.GameContent.NetModules;

[Cpp2IlInjected.Token(Token = "0x2000675")]
public class NetCreativePowerPermissionsModule : NetModule
{
	[Cpp2IlInjected.Token(Token = "0x4006D86")]
	private const byte _setPermissionLevelId = 0;

	[Cpp2IlInjected.Token(Token = "0x4006D87")]
	public static int specificPlrDeserialise;

	[Cpp2IlInjected.Token(Token = "0x6004133")]
	[Cpp2IlInjected.Address(RVA = "0x105B590", Offset = "0x105B590", VA = "0x105B590")]
	public static NetPacket SerializeCurrentPowerPermissionLevel(ushort powerId, int level)
	{
		return default(NetPacket);
	}

	[Cpp2IlInjected.Token(Token = "0x6004134")]
	[Cpp2IlInjected.Address(RVA = "0x105B694", Offset = "0x105B694", VA = "0x105B694", Slot = "4")]
	public override bool Deserialize(BinaryReader reader, int userId)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6004135")]
	[Cpp2IlInjected.Address(RVA = "0x105BADC", Offset = "0x105BADC", VA = "0x105BADC")]
	public NetCreativePowerPermissionsModule()
	{
	}
}
