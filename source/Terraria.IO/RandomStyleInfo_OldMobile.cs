using System.IO;
using Cpp2IlInjected;

namespace Terraria.IO;

[Cpp2IlInjected.Token(Token = "0x20003D4")]
public class RandomStyleInfo_OldMobile
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40032D6")]
	public byte[] style;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40032D7")]
	public ushort[] X;

	[Cpp2IlInjected.Token(Token = "0x6002FE8")]
	[Cpp2IlInjected.Address(RVA = "0xE47404", Offset = "0xE47404", VA = "0xE47404")]
	public bool Load(BinaryReader reader, int release)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6002FE9")]
	[Cpp2IlInjected.Address(RVA = "0xE47480", Offset = "0xE47480", VA = "0xE47480")]
	public RandomStyleInfo_OldMobile()
	{
	}
}
