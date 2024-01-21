using System;
using Cpp2IlInjected;

namespace Microsoft.Xna.Framework.Graphics.PackedVector;

[Cpp2IlInjected.Token(Token = "0x20002E3")]
public struct HalfSingle : IPackedVector<ushort>, IPackedVector, IEquatable<HalfSingle>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4002143")]
	private ushort packedValue;

	[Cpp2IlInjected.Token(Token = "0x1700033A")]
	[Cpp2IlInjected.Attribute(Name = "CLSCompliantAttribute", RVA = "0x39924C", Offset = "0x39924C")]
	public ushort PackedValue
	{
		[Cpp2IlInjected.Token(Token = "0x6001844")]
		[Cpp2IlInjected.Address(RVA = "0x3A3328", Offset = "0x3A3328", VA = "0x3A3328", Slot = "4")]
		get
		{
			return default(ushort);
		}
		[Cpp2IlInjected.Token(Token = "0x6001845")]
		[Cpp2IlInjected.Address(RVA = "0x3A3330", Offset = "0x3A3330", VA = "0x3A3330", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6001843")]
	[Cpp2IlInjected.Address(RVA = "0x3A330C", Offset = "0x3A330C", VA = "0x3A330C")]
	public HalfSingle(float single)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001846")]
	[Cpp2IlInjected.Address(RVA = "0x3A3338", Offset = "0x3A3338", VA = "0x3A3338")]
	public float ToSingle()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6001847")]
	[Cpp2IlInjected.Address(RVA = "0x3A3340", Offset = "0x3A3340", VA = "0x3A3340", Slot = "6")]
	void IPackedVector.PackFromVector4(Vector4 vector)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001848")]
	[Cpp2IlInjected.Address(RVA = "0x3A335C", Offset = "0x3A335C", VA = "0x3A335C", Slot = "7")]
	Vector4 IPackedVector.ToVector4()
	{
		return default(Vector4);
	}

	[Cpp2IlInjected.Token(Token = "0x6001849")]
	[Cpp2IlInjected.Address(RVA = "0x3A33A8", Offset = "0x3A33A8", VA = "0x3A33A8", Slot = "0")]
	public override bool Equals(object obj)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600184A")]
	[Cpp2IlInjected.Address(RVA = "0x3A33B0", Offset = "0x3A33B0", VA = "0x3A33B0", Slot = "8")]
	public bool Equals(HalfSingle other)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600184B")]
	[Cpp2IlInjected.Address(RVA = "0x3A33C8", Offset = "0x3A33C8", VA = "0x3A33C8", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600184C")]
	[Cpp2IlInjected.Address(RVA = "0x3A33F4", Offset = "0x3A33F4", VA = "0x3A33F4", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600184D")]
	[Cpp2IlInjected.Address(RVA = "0x158BA24", Offset = "0x158BA24", VA = "0x158BA24")]
	public static bool operator ==(HalfSingle lhs, HalfSingle rhs)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600184E")]
	[Cpp2IlInjected.Address(RVA = "0x158BA88", Offset = "0x158BA88", VA = "0x158BA88")]
	public static bool operator !=(HalfSingle lhs, HalfSingle rhs)
	{
		return default(bool);
	}
}
