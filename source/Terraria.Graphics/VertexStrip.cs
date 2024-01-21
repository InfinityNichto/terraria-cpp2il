using System.Collections.Generic;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Terraria.Graphics;

[Cpp2IlInjected.Token(Token = "0x20004EB")]
public class VertexStrip
{
	[Cpp2IlInjected.Token(Token = "0x200095C")]
	public delegate void StripColorFunction(float progressOnStrip, out Color col);

	[Cpp2IlInjected.Token(Token = "0x200095D")]
	public delegate float StripHalfWidthFunction(float progressOnStrip);

	[Cpp2IlInjected.Token(Token = "0x200095E")]
	private struct CustomVertexInfo
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4008B88")]
		public Vector2 Position;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4008B89")]
		public Color Color;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4008B8A")]
		public Vector3 TexCoord;

		[Cpp2IlInjected.Token(Token = "0x6004D83")]
		[Cpp2IlInjected.Address(RVA = "0x39DFA4", Offset = "0x39DFA4", VA = "0x39DFA4")]
		public CustomVertexInfo(Vector2 position, Color color, Vector3 texCoord)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400673B")]
	private CustomVertexInfo[] _vertices;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x400673C")]
	private int _vertexAmountCurrentlyMaintained;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400673D")]
	private short[] _indices;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400673E")]
	private int _indicesAmountCurrentlyMaintained;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400673F")]
	private List<Vector2> _temporaryPositionsCache;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4006740")]
	private List<float> _temporaryRotationsCache;

	[Cpp2IlInjected.Token(Token = "0x6003708")]
	[Cpp2IlInjected.Address(RVA = "0x124DF7C", Offset = "0x124DF7C", VA = "0x124DF7C")]
	[Cpp2IlInjected.Attribute(Name = "Il2CppSetOptionAttribute", RVA = "0x3943B4", Offset = "0x3943B4")]
	[Cpp2IlInjected.Attribute(Name = "Il2CppSetOptionAttribute", RVA = "0x3943B4", Offset = "0x3943B4")]
	public void PrepareStrip(ref Vector2Array_10 positions, ref FloatArray_10 rotations, StripColorFunction colorFunction, StripHalfWidthFunction widthFunction, [Optional] Vector2 offsetForAllPositions, [Optional] int? expectedVertexPairsAmount, bool includeBacksides = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6003709")]
	[Cpp2IlInjected.Address(RVA = "0x124E578", Offset = "0x124E578", VA = "0x124E578")]
	[Cpp2IlInjected.Attribute(Name = "Il2CppSetOptionAttribute", RVA = "0x394468", Offset = "0x394468")]
	[Cpp2IlInjected.Attribute(Name = "Il2CppSetOptionAttribute", RVA = "0x394468", Offset = "0x394468")]
	public void PrepareStrip(Vector2[] positions, float[] rotations, StripColorFunction colorFunction, StripHalfWidthFunction widthFunction, [Optional] Vector2 offsetForAllPositions, [Optional] int? expectedVertexPairsAmount, bool includeBacksides = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600370A")]
	[Cpp2IlInjected.Address(RVA = "0x124E818", Offset = "0x124E818", VA = "0x124E818")]
	[Cpp2IlInjected.Attribute(Name = "Il2CppSetOptionAttribute", RVA = "0x39451C", Offset = "0x39451C")]
	[Cpp2IlInjected.Attribute(Name = "Il2CppSetOptionAttribute", RVA = "0x39451C", Offset = "0x39451C")]
	public void PrepareStripWithProceduralPadding(ref Vector2Array_10 positions, ref FloatArray_10 rotations, StripColorFunction colorFunction, StripHalfWidthFunction widthFunction, [Optional] Vector2 offsetForAllPositions, bool includeBacksides = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600370B")]
	[Cpp2IlInjected.Address(RVA = "0x123A684", Offset = "0x123A684", VA = "0x123A684")]
	[Cpp2IlInjected.Attribute(Name = "Il2CppSetOptionAttribute", RVA = "0x3945D0", Offset = "0x3945D0")]
	[Cpp2IlInjected.Attribute(Name = "Il2CppSetOptionAttribute", RVA = "0x3945D0", Offset = "0x3945D0")]
	public void PrepareStripWithProceduralPadding(Vector2[] positions, float[] rotations, StripColorFunction colorFunction, StripHalfWidthFunction widthFunction, [Optional] Vector2 offsetForAllPositions, bool includeBacksides = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600370C")]
	[Cpp2IlInjected.Address(RVA = "0x124E464", Offset = "0x124E464", VA = "0x124E464")]
	private void PrepareIndices(int vertexPaidsAdded)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600370D")]
	[Cpp2IlInjected.Address(RVA = "0x124E240", Offset = "0x124E240", VA = "0x124E240")]
	[Cpp2IlInjected.Attribute(Name = "Il2CppSetOptionAttribute", RVA = "0x394684", Offset = "0x394684")]
	[Cpp2IlInjected.Attribute(Name = "Il2CppSetOptionAttribute", RVA = "0x394684", Offset = "0x394684")]
	private void AddVertex(StripColorFunction colorFunction, StripHalfWidthFunction widthFunction, Vector2 pos, float rot, int indexOnVertexArray, float progressOnStrip)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600370E")]
	[Cpp2IlInjected.Address(RVA = "0x123ADC0", Offset = "0x123ADC0", VA = "0x123ADC0")]
	[Cpp2IlInjected.Attribute(Name = "Il2CppSetOptionAttribute", RVA = "0x394738", Offset = "0x394738")]
	[Cpp2IlInjected.Attribute(Name = "Il2CppSetOptionAttribute", RVA = "0x394738", Offset = "0x394738")]
	public void DrawTrail(bool includeBacksides)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600370F")]
	[Cpp2IlInjected.Address(RVA = "0x123B2B8", Offset = "0x123B2B8", VA = "0x123B2B8")]
	public VertexStrip()
	{
	}
}
