using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;
using Terraria.Graphics;

[global::Cpp2ILInjected.Token(Token = "0x2000012")]
public struct Vector2Array_10
{
	[global::Cpp2ILInjected.Token(Token = "0x1700001D")]
	public Vector2 this[int index]
	{
		[global::Cpp2ILInjected.Token(Token = "0x6000052")]
		[global::Cpp2ILInjected.Address(RVA = "0x6FBBC8", Offset = "0x6FBBC8", Length = "0x12C")]
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
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 6)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		get
		{
			throw null;
		}
		[global::Cpp2ILInjected.Token(Token = "0x6000053")]
		[global::Cpp2ILInjected.Address(RVA = "0x6FBCF4", Offset = "0x6FBCF4", Length = "0x9C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		set
		{
			throw null;
		}
	}

	[global::Cpp2ILInjected.Token(Token = "0x1700001E")]
	public int Length
	{
		[global::Cpp2ILInjected.Token(Token = "0x6000054")]
		[global::Cpp2ILInjected.Address(RVA = "0x6FBD90", Offset = "0x6FBD90", Length = "0x8")]
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
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		get
		{
			throw null;
		}
	}

	[global::Cpp2ILInjected.Token(Token = "0x4000030")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
	private Vector2 val0;

	[global::Cpp2ILInjected.Token(Token = "0x4000031")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x8")]
	private Vector2 val1;

	[global::Cpp2ILInjected.Token(Token = "0x4000032")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
	private Vector2 val2;

	[global::Cpp2ILInjected.Token(Token = "0x4000033")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
	private Vector2 val3;

	[global::Cpp2ILInjected.Token(Token = "0x4000034")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
	private Vector2 val4;

	[global::Cpp2ILInjected.Token(Token = "0x4000035")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
	private Vector2 val5;

	[global::Cpp2ILInjected.Token(Token = "0x4000036")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
	private Vector2 val6;

	[global::Cpp2ILInjected.Token(Token = "0x4000037")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
	private Vector2 val7;

	[global::Cpp2ILInjected.Token(Token = "0x4000038")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
	private Vector2 val8;

	[global::Cpp2ILInjected.Token(Token = "0x4000039")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
	private Vector2 val9;
}
