using System.IO;
using Cpp2IlInjected;
using Terraria.Net;

namespace Terraria.GameContent.NetModules;

[Cpp2IlInjected.Token(Token = "0x2000678")]
public class NetTeleportPylonModule : NetModule
{
	[Cpp2IlInjected.Token(Token = "0x2000A5D")]
	public enum SubPacketType : byte
	{
		[Cpp2IlInjected.Token(Token = "0x4008E3B")]
		PylonWasAdded,
		[Cpp2IlInjected.Token(Token = "0x4008E3C")]
		PylonWasRemoved,
		[Cpp2IlInjected.Token(Token = "0x4008E3D")]
		PlayerRequestsTeleport
	}

	[Cpp2IlInjected.Token(Token = "0x600413D")]
	[Cpp2IlInjected.Address(RVA = "0x105DCF8", Offset = "0x105DCF8", VA = "0x105DCF8")]
	public static NetPacket SerializePylonWasAddedOrRemoved(TeleportPylonInfo info, SubPacketType packetType)
	{
		return default(NetPacket);
	}

	[Cpp2IlInjected.Token(Token = "0x600413E")]
	[Cpp2IlInjected.Address(RVA = "0x105DE20", Offset = "0x105DE20", VA = "0x105DE20")]
	public static NetPacket SerializeUseRequest(TeleportPylonInfo info)
	{
		return default(NetPacket);
	}

	[Cpp2IlInjected.Token(Token = "0x600413F")]
	[Cpp2IlInjected.Address(RVA = "0x105DF44", Offset = "0x105DF44", VA = "0x105DF44", Slot = "4")]
	public override bool Deserialize(BinaryReader reader, int userId)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6004140")]
	[Cpp2IlInjected.Address(RVA = "0x105E24C", Offset = "0x105E24C", VA = "0x105E24C")]
	public NetTeleportPylonModule()
	{
	}
}
