using System.Runtime.InteropServices;
using Cpp2IlInjected;

namespace Terraria.Modules;

[Cpp2IlInjected.Token(Token = "0x20003AB")]
public class AnchorTypesModule
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400323E")]
	public int[] tileValid;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x400323F")]
	public int[] tileInvalid;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4003240")]
	public int[] tileAlternates;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4003241")]
	public int[] wallValid;

	[Cpp2IlInjected.Token(Token = "0x6002EC3")]
	[Cpp2IlInjected.Address(RVA = "0xFDC878", Offset = "0xFDC878", VA = "0xFDC878")]
	public AnchorTypesModule([Optional] AnchorTypesModule copyFrom)
	{
	}
}
