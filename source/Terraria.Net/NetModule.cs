using System.IO;
using Cpp2IlInjected;

namespace Terraria.Net;

[Cpp2IlInjected.Token(Token = "0x200049C")]
public abstract class NetModule
{
	[Cpp2IlInjected.Token(Token = "0x6003396")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract bool Deserialize(BinaryReader reader, int userId);

	[Cpp2IlInjected.Token(Token = "0x6003397")]
	[Cpp2IlInjected.Address(RVA = "0x206EFEC", Offset = "0x206EFEC", VA = "0x206EFEC")]
	protected static NetPacket CreatePacket<T>(int maxSize) where T : NetModule
	{
		return default(NetPacket);
	}

	[Cpp2IlInjected.Token(Token = "0x6003398")]
	[Cpp2IlInjected.Address(RVA = "0x142C360", Offset = "0x142C360", VA = "0x142C360")]
	protected NetModule()
	{
	}
}
