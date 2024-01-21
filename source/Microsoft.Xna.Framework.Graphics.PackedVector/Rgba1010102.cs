using System;
using Cpp2IlInjected;

namespace Microsoft.Xna.Framework.Graphics.PackedVector;

[Cpp2IlInjected.Token(Token = "0x20002EE")]
public struct Rgba1010102 : IPackedVector<uint>, IPackedVector, IEquatable<Rgba1010102>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400214B")]
	private uint packedValue;

	[Cpp2IlInjected.Token(Token = "0x17000343")]
	[Cpp2IlInjected.Attribute(Name = "CLSCompliantAttribute", RVA = "0x3992EC", Offset = "0x3992EC")]
	public uint PackedValue
	{
		[Cpp2IlInjected.Token(Token = "0x60018B6")]
		[Cpp2IlInjected.Address(RVA = "0x3A3BA0", Offset = "0x3A3BA0", VA = "0x3A3BA0", Slot = "4")]
		get
		{
			return default(uint);
		}
		[Cpp2IlInjected.Token(Token = "0x60018B7")]
		[Cpp2IlInjected.Address(RVA = "0x3A3BA8", Offset = "0x3A3BA8", VA = "0x3A3BA8", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60018B8")]
	[Cpp2IlInjected.Address(RVA = "0x3A3BB0", Offset = "0x3A3BB0", VA = "0x3A3BB0")]
	public Rgba1010102(float x, float y, float z, float w)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60018B9")]
	[Cpp2IlInjected.Address(RVA = "0x3A3BE4", Offset = "0x3A3BE4", VA = "0x3A3BE4")]
	public Rgba1010102(Vector4 vector)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60018BA")]
	[Cpp2IlInjected.Address(RVA = "0x3A3C18", Offset = "0x3A3C18", VA = "0x3A3C18", Slot = "7")]
	public Vector4 ToVector4()
	{
		return default(Vector4);
	}

	[Cpp2IlInjected.Token(Token = "0x60018BB")]
	[Cpp2IlInjected.Address(RVA = "0x3A3C2C", Offset = "0x3A3C2C", VA = "0x3A3C2C", Slot = "6")]
	void IPackedVector.PackFromVector4(Vector4 vector)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60018BC")]
	[Cpp2IlInjected.Address(RVA = "0x3A3C60", Offset = "0x3A3C60", VA = "0x3A3C60", Slot = "0")]
	public override bool Equals(object obj)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60018BD")]
	[Cpp2IlInjected.Address(RVA = "0x3A3C68", Offset = "0x3A3C68", VA = "0x3A3C68", Slot = "8")]
	public bool Equals(Rgba1010102 other)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60018BE")]
	[Cpp2IlInjected.Address(RVA = "0x3A3C7C", Offset = "0x3A3C7C", VA = "0x3A3C7C", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60018BF")]
	[Cpp2IlInjected.Address(RVA = "0x3A3CC0", Offset = "0x3A3CC0", VA = "0x3A3CC0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60018C0")]
	[Cpp2IlInjected.Address(RVA = "0x158E0A8", Offset = "0x158E0A8", VA = "0x158E0A8")]
	public static bool operator ==(Rgba1010102 lhs, Rgba1010102 rhs)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60018C1")]
	[Cpp2IlInjected.Address(RVA = "0x158E0B8", Offset = "0x158E0B8", VA = "0x158E0B8")]
	public static bool operator !=(Rgba1010102 lhs, Rgba1010102 rhs)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60018C2")]
	[Cpp2IlInjected.Address(RVA = "0x158DB3C", Offset = "0x158DB3C", VA = "0x158DB3C")]
	private static uint Pack(float x, float y, float z, float w)
	{
		return default(uint);
	}
}
