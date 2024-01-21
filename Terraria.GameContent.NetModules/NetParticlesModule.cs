using System.IO;
using Cpp2IlInjected;
using Terraria.GameContent.Drawing;
using Terraria.Net;

namespace Terraria.GameContent.NetModules;

[Cpp2IlInjected.Token(Token = "0x2000676")]
public class NetParticlesModule : NetModule
{
	[Cpp2IlInjected.Token(Token = "0x6004137")]
	[Cpp2IlInjected.Address(RVA = "0x105D7A0", Offset = "0x105D7A0", VA = "0x105D7A0")]
	public static NetPacket Serialize(ParticleOrchestraType particleType, ParticleOrchestraSettings settings)
	{
		return default(NetPacket);
	}

	[Cpp2IlInjected.Token(Token = "0x6004138")]
	[Cpp2IlInjected.Address(RVA = "0x105D898", Offset = "0x105D898", VA = "0x105D898", Slot = "4")]
	public override bool Deserialize(BinaryReader reader, int userId)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6004139")]
	[Cpp2IlInjected.Address(RVA = "0x105DA80", Offset = "0x105DA80", VA = "0x105DA80")]
	public NetParticlesModule()
	{
	}
}
