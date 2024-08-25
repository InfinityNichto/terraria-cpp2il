using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;
using Terraria.Graphics;

[global::Cpp2ILInjected.Token(Token = "0x200000E")]
public struct FloatArray_10
{
	[global::Cpp2ILInjected.Token(Token = "0x17000016")]
	public float this[int index]
	{
		[global::Cpp2ILInjected.Token(Token = "0x6000047")]
		[global::Cpp2ILInjected.Address(RVA = "0x6FB978", Offset = "0x6FB978", Length = "0x78")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(VertexStrip), Member = "PrepareStrip", MemberParameters = new object[]
		{
			typeof(ref Vector2Array_10),
			typeof(ref FloatArray_10),
			typeof(VertexStrip.StripColorFunction),
			typeof(VertexStrip.StripHalfWidthFunction),
			typeof(Vector2),
			typeof(int?),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(VertexStrip), Member = "PrepareStripWithProceduralPadding", MemberParameters = new object[]
		{
			typeof(ref Vector2Array_10),
			typeof(ref FloatArray_10),
			typeof(VertexStrip.StripColorFunction),
			typeof(VertexStrip.StripHalfWidthFunction),
			typeof(Vector2),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		get
		{
			throw null;
		}
		[global::Cpp2ILInjected.Token(Token = "0x6000048")]
		[global::Cpp2ILInjected.Address(RVA = "0x6FB9F0", Offset = "0x6FB9F0", Length = "0x70")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		set
		{
			throw null;
		}
	}

	[global::Cpp2ILInjected.Token(Token = "0x4000017")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
	private float val0;

	[global::Cpp2ILInjected.Token(Token = "0x4000018")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x4")]
	private float val1;

	[global::Cpp2ILInjected.Token(Token = "0x4000019")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x8")]
	private float val2;

	[global::Cpp2ILInjected.Token(Token = "0x400001A")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xC")]
	private float val3;

	[global::Cpp2ILInjected.Token(Token = "0x400001B")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
	private float val4;

	[global::Cpp2ILInjected.Token(Token = "0x400001C")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x14")]
	private float val5;

	[global::Cpp2ILInjected.Token(Token = "0x400001D")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
	private float val6;

	[global::Cpp2ILInjected.Token(Token = "0x400001E")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x1C")]
	private float val7;

	[global::Cpp2ILInjected.Token(Token = "0x400001F")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
	private float val8;

	[global::Cpp2ILInjected.Token(Token = "0x4000020")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x24")]
	private float val9;
}
