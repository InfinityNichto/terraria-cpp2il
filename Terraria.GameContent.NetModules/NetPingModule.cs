using System.IO;
using Cpp2IlInjected;
using Microsoft.Xna.Framework;
using Terraria.Net;

namespace Terraria.GameContent.NetModules;

[Cpp2IlInjected.Token(Token = "0x2000677")]
public class NetPingModule : NetModule
{
	[Cpp2IlInjected.Token(Token = "0x600413A")]
	[Cpp2IlInjected.Address(RVA = "0x105DA88", Offset = "0x105DA88", VA = "0x105DA88")]
	public static NetPacket Serialize(Vector2 position)
	{
		return default(NetPacket);
	}

	[Cpp2IlInjected.Token(Token = "0x600413B")]
	[Cpp2IlInjected.Address(RVA = "0x105DB78", Offset = "0x105DB78", VA = "0x105DB78", Slot = "4")]
	public override bool Deserialize(BinaryReader reader, int userId)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600413C")]
	[Cpp2IlInjected.Address(RVA = "0x105DCF0", Offset = "0x105DCF0", VA = "0x105DCF0")]
	public NetPingModule()
	{
	}
}
