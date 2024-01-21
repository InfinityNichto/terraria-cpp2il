using System;
using Cpp2IlInjected;

namespace Microsoft.Xna.Framework.Graphics.PackedVector;

[Cpp2IlInjected.Token(Token = "0x20002DE")]
public struct Alpha8 : IPackedVector<byte>, IPackedVector, IEquatable<Alpha8>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400213E")]
	private byte packedValue;

	[Cpp2IlInjected.Token(Token = "0x17000335")]
	[Cpp2IlInjected.Attribute(Name = "CLSCompliantAttribute", RVA = "0x3991E8", Offset = "0x3991E8")]
	public byte PackedValue
	{
		[Cpp2IlInjected.Token(Token = "0x6001801")]
		[Cpp2IlInjected.Address(RVA = "0x3A2D20", Offset = "0x3A2D20", VA = "0x3A2D20", Slot = "4")]
		get
		{
			return default(byte);
		}
		[Cpp2IlInjected.Token(Token = "0x6001802")]
		[Cpp2IlInjected.Address(RVA = "0x3A2D28", Offset = "0x3A2D28", VA = "0x3A2D28", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6001803")]
	[Cpp2IlInjected.Address(RVA = "0x3A2D30", Offset = "0x3A2D30", VA = "0x3A2D30")]
	public Alpha8(float alpha)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001804")]
	[Cpp2IlInjected.Address(RVA = "0x3A2D4C", Offset = "0x3A2D4C", VA = "0x3A2D4C")]
	public float ToAlpha()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6001805")]
	[Cpp2IlInjected.Address(RVA = "0x3A2D6C", Offset = "0x3A2D6C", VA = "0x3A2D6C", Slot = "6")]
	void IPackedVector.PackFromVector4(Vector4 vector)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001806")]
	[Cpp2IlInjected.Address(RVA = "0x3A2D88", Offset = "0x3A2D88", VA = "0x3A2D88", Slot = "7")]
	Vector4 IPackedVector.ToVector4()
	{
		return default(Vector4);
	}

	[Cpp2IlInjected.Token(Token = "0x6001807")]
	[Cpp2IlInjected.Address(RVA = "0x3A2DD8", Offset = "0x3A2DD8", VA = "0x3A2DD8", Slot = "0")]
	public override bool Equals(object obj)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6001808")]
	[Cpp2IlInjected.Address(RVA = "0x3A2DE0", Offset = "0x3A2DE0", VA = "0x3A2DE0", Slot = "8")]
	public bool Equals(Alpha8 other)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6001809")]
	[Cpp2IlInjected.Address(RVA = "0x3A2DF8", Offset = "0x3A2DF8", VA = "0x3A2DF8", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600180A")]
	[Cpp2IlInjected.Address(RVA = "0x3A2E34", Offset = "0x3A2E34", VA = "0x3A2E34", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600180B")]
	[Cpp2IlInjected.Address(RVA = "0x158A038", Offset = "0x158A038", VA = "0x158A038")]
	public static bool operator ==(Alpha8 lhs, Alpha8 rhs)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600180C")]
	[Cpp2IlInjected.Address(RVA = "0x158A050", Offset = "0x158A050", VA = "0x158A050")]
	public static bool operator !=(Alpha8 lhs, Alpha8 rhs)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600180D")]
	[Cpp2IlInjected.Address(RVA = "0x1589D6C", Offset = "0x1589D6C", VA = "0x1589D6C")]
	private static byte Pack(float alpha)
	{
		return default(byte);
	}
}
