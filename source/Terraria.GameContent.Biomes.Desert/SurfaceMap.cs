using Cpp2IlInjected;

namespace Terraria.GameContent.Biomes.Desert;

[Cpp2IlInjected.Token(Token = "0x2000609")]
[Cpp2IlInjected.Attribute(Name = "DefaultMemberAttribute", RVA = "0x3854EC", Offset = "0x3854EC")]
public class SurfaceMap
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4006C11")]
	public readonly double Average;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4006C12")]
	public readonly int Bottom;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4006C13")]
	public readonly int Top;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4006C14")]
	public readonly int X;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4006C15")]
	private readonly short[] _heights;

	[Cpp2IlInjected.Token(Token = "0x1700074D")]
	public int Width
	{
		[Cpp2IlInjected.Token(Token = "0x6003E18")]
		[Cpp2IlInjected.Address(RVA = "0x1456D18", Offset = "0x1456D18", VA = "0x1456D18")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700074E")]
	public short Item
	{
		[Cpp2IlInjected.Token(Token = "0x6003E1A")]
		[Cpp2IlInjected.Address(RVA = "0x1456D24", Offset = "0x1456D24", VA = "0x1456D24")]
		get
		{
			return default(short);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6003E19")]
	[Cpp2IlInjected.Address(RVA = "0x145E10C", Offset = "0x145E10C", VA = "0x145E10C")]
	private SurfaceMap(short[] heights, int x)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003E1B")]
	[Cpp2IlInjected.Address(RVA = "0x1458D64", Offset = "0x1458D64", VA = "0x1458D64")]
	public static SurfaceMap FromArea(int startX, int width)
	{
		return null;
	}
}
