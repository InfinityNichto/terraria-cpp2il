using System.IO;
using Cpp2IlInjected;

namespace Terraria.IO;

[Cpp2IlInjected.Token(Token = "0x20003CE")]
public class ChestInfo_OldMobile
{
	[Cpp2IlInjected.Token(Token = "0x40032B3")]
	private static byte[] bits;

	[Cpp2IlInjected.Token(Token = "0x6002FCD")]
	[Cpp2IlInjected.Address(RVA = "0x147D058", Offset = "0x147D058", VA = "0x147D058")]
	public bool Load(BinaryReader reader, int release)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6002FCE")]
	[Cpp2IlInjected.Address(RVA = "0x147D538", Offset = "0x147D538", VA = "0x147D538")]
	private void FixDresserChests()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002FCF")]
	[Cpp2IlInjected.Address(RVA = "0x147D718", Offset = "0x147D718", VA = "0x147D718")]
	public ChestInfo_OldMobile()
	{
	}
}
