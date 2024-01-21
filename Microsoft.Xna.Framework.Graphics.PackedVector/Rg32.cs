using System;
using Cpp2IlInjected;

namespace Microsoft.Xna.Framework.Graphics.PackedVector;

[Cpp2IlInjected.Token(Token = "0x20002ED")]
public struct Rg32 : IPackedVector<uint>, IPackedVector, IEquatable<Rg32>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400214A")]
	private uint packedValue;

	[Cpp2IlInjected.Token(Token = "0x17000342")]
	[Cpp2IlInjected.Attribute(Name = "CLSCompliantAttribute", RVA = "0x3992D8", Offset = "0x3992D8")]
	public uint PackedValue
	{
		[Cpp2IlInjected.Token(Token = "0x60018A8")]
		[Cpp2IlInjected.Address(RVA = "0x3A3A90", Offset = "0x3A3A90", VA = "0x3A3A90", Slot = "4")]
		get
		{
			return default(uint);
		}
		[Cpp2IlInjected.Token(Token = "0x60018A9")]
		[Cpp2IlInjected.Address(RVA = "0x3A3A98", Offset = "0x3A3A98", VA = "0x3A3A98", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60018AA")]
	[Cpp2IlInjected.Address(RVA = "0x3A3AA0", Offset = "0x3A3AA0", VA = "0x3A3AA0")]
	public Rg32(float x, float y)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60018AB")]
	[Cpp2IlInjected.Address(RVA = "0x3A3AC0", Offset = "0x3A3AC0", VA = "0x3A3AC0")]
	public Rg32(Vector2 vector)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60018AC")]
	[Cpp2IlInjected.Address(RVA = "0x3A3AE0", Offset = "0x3A3AE0", VA = "0x3A3AE0")]
	public Vector2 ToVector2()
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x60018AD")]
	[Cpp2IlInjected.Address(RVA = "0x3A3B3C", Offset = "0x3A3B3C", VA = "0x3A3B3C", Slot = "6")]
	void IPackedVector.PackFromVector4(Vector4 vector)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60018AE")]
	[Cpp2IlInjected.Address(RVA = "0x3A3B5C", Offset = "0x3A3B5C", VA = "0x3A3B5C", Slot = "7")]
	Vector4 IPackedVector.ToVector4()
	{
		return default(Vector4);
	}

	[Cpp2IlInjected.Token(Token = "0x60018AF")]
	[Cpp2IlInjected.Address(RVA = "0x3A3B70", Offset = "0x3A3B70", VA = "0x3A3B70", Slot = "0")]
	public override bool Equals(object obj)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60018B0")]
	[Cpp2IlInjected.Address(RVA = "0x3A3B78", Offset = "0x3A3B78", VA = "0x3A3B78", Slot = "8")]
	public bool Equals(Rg32 other)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60018B1")]
	[Cpp2IlInjected.Address(RVA = "0x3A3B8C", Offset = "0x3A3B8C", VA = "0x3A3B8C", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60018B2")]
	[Cpp2IlInjected.Address(RVA = "0x3A3B94", Offset = "0x3A3B94", VA = "0x3A3B94", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60018B3")]
	[Cpp2IlInjected.Address(RVA = "0x158DADC", Offset = "0x158DADC", VA = "0x158DADC")]
	public static bool operator ==(Rg32 lhs, Rg32 rhs)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60018B4")]
	[Cpp2IlInjected.Address(RVA = "0x158DAEC", Offset = "0x158DAEC", VA = "0x158DAEC")]
	public static bool operator !=(Rg32 lhs, Rg32 rhs)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60018B5")]
	[Cpp2IlInjected.Address(RVA = "0x158D690", Offset = "0x158D690", VA = "0x158D690")]
	private static uint Pack(float x, float y)
	{
		return default(uint);
	}
}
