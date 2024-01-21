using System.Collections.Generic;
using Cpp2IlInjected;

namespace Terraria.DataStructures;

[Cpp2IlInjected.Token(Token = "0x2000432")]
public class FlowerPacketInfo
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40062E7")]
	public List<int> stylesOnPurity;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40062E8")]
	public List<int> stylesOnCorruption;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40062E9")]
	public List<int> stylesOnCrimson;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x40062EA")]
	public List<int> stylesOnHallow;

	[Cpp2IlInjected.Token(Token = "0x6003123")]
	[Cpp2IlInjected.Address(RVA = "0x1013B30", Offset = "0x1013B30", VA = "0x1013B30")]
	public FlowerPacketInfo()
	{
	}
}
