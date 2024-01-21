using System.IO;
using Cpp2IlInjected;

namespace Terraria.IO;

[Cpp2IlInjected.Token(Token = "0x20003D8")]
public class Weather_OldMobile
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40032DB")]
	private float cloudBGActive;

	[Cpp2IlInjected.Token(Token = "0x6002FFA")]
	[Cpp2IlInjected.Address(RVA = "0xE4A43C", Offset = "0xE4A43C", VA = "0xE4A43C")]
	public bool Load(BinaryReader reader, int release)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6002FFB")]
	[Cpp2IlInjected.Address(RVA = "0xE4A53C", Offset = "0xE4A53C", VA = "0xE4A53C")]
	public bool LoadMeta(WorldFileData data, BinaryReader reader, int release)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6002FFC")]
	[Cpp2IlInjected.Address(RVA = "0xE4A5B4", Offset = "0xE4A5B4", VA = "0xE4A5B4")]
	public Weather_OldMobile()
	{
	}
}
