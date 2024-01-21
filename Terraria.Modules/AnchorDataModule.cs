using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Terraria.DataStructures;

namespace Terraria.Modules;

[Cpp2IlInjected.Token(Token = "0x20003AA")]
public class AnchorDataModule
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4003239")]
	public AnchorData top;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400323A")]
	public AnchorData bottom;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400323B")]
	public AnchorData left;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x400323C")]
	public AnchorData right;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400323D")]
	public bool wall;

	[Cpp2IlInjected.Token(Token = "0x6002EC2")]
	[Cpp2IlInjected.Address(RVA = "0xFDC7E8", Offset = "0xFDC7E8", VA = "0xFDC7E8")]
	public AnchorDataModule([Optional] AnchorDataModule copyFrom)
	{
	}
}
