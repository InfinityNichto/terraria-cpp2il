using System.Runtime.InteropServices;
using Cpp2IlInjected;

namespace Terraria.Modules;

[Cpp2IlInjected.Token(Token = "0x20003B1")]
public class TileObjectDrawModule
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4003256")]
	public int xOffset;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4003257")]
	public int yOffset;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4003258")]
	public bool flipHorizontal;

	[Cpp2IlInjected.FieldOffset(Offset = "0x11")]
	[Cpp2IlInjected.Token(Token = "0x4003259")]
	public bool flipVertical;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400325A")]
	public int stepDown;

	[Cpp2IlInjected.Token(Token = "0x6002EC9")]
	[Cpp2IlInjected.Address(RVA = "0xFDCE54", Offset = "0xFDCE54", VA = "0xFDCE54")]
	public TileObjectDrawModule([Optional] TileObjectDrawModule copyFrom)
	{
	}
}
