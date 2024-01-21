using System.IO;
using Cpp2IlInjected;

namespace Terraria.IO;

[Cpp2IlInjected.Token(Token = "0x20003D7")]
public class TimeInfo_OldMobile
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40032D8")]
	private short totalDays;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA")]
	[Cpp2IlInjected.Token(Token = "0x40032D9")]
	private byte moonType;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40032DA")]
	public short daysSinceHardmode;

	[Cpp2IlInjected.Token(Token = "0x6002FF7")]
	[Cpp2IlInjected.Address(RVA = "0xE4A13C", Offset = "0xE4A13C", VA = "0xE4A13C")]
	public bool Load(BinaryReader reader, int release)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6002FF8")]
	[Cpp2IlInjected.Address(RVA = "0xE4A37C", Offset = "0xE4A37C", VA = "0xE4A37C")]
	public bool LoadMeta(WorldFileData data, BinaryReader reader, int release)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6002FF9")]
	[Cpp2IlInjected.Address(RVA = "0xE4A434", Offset = "0xE4A434", VA = "0xE4A434")]
	public TimeInfo_OldMobile()
	{
	}
}
