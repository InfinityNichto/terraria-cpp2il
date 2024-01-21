using System;
using Cpp2IlInjected;

namespace Microsoft.Xna.Framework.Graphics.PackedVector;

[Cpp2IlInjected.Token(Token = "0x20002F1")]
public struct Short4 : IPackedVector<ulong>, IPackedVector, IEquatable<Short4>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400214E")]
	private ulong packedValue;

	[Cpp2IlInjected.Token(Token = "0x17000346")]
	[Cpp2IlInjected.Attribute(Name = "CLSCompliantAttribute", RVA = "0x399328", Offset = "0x399328")]
	public ulong PackedValue
	{
		[Cpp2IlInjected.Token(Token = "0x60018E2")]
		[Cpp2IlInjected.Address(RVA = "0x3A3FC0", Offset = "0x3A3FC0", VA = "0x3A3FC0", Slot = "4")]
		get
		{
			return default(ulong);
		}
		[Cpp2IlInjected.Token(Token = "0x60018E3")]
		[Cpp2IlInjected.Address(RVA = "0x3A3FC8", Offset = "0x3A3FC8", VA = "0x3A3FC8", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60018DE")]
	[Cpp2IlInjected.Address(RVA = "0x3A3F48", Offset = "0x3A3F48", VA = "0x3A3F48")]
	public Short4(Vector4 vector)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60018DF")]
	[Cpp2IlInjected.Address(RVA = "0x3A3F78", Offset = "0x3A3F78", VA = "0x3A3F78")]
	public Short4(float x, float y, float z, float w)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60018E0")]
	[Cpp2IlInjected.Address(RVA = "0x158EFD4", Offset = "0x158EFD4", VA = "0x158EFD4")]
	public static bool operator !=(Short4 a, Short4 b)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60018E1")]
	[Cpp2IlInjected.Address(RVA = "0x158EFE8", Offset = "0x158EFE8", VA = "0x158EFE8")]
	public static bool operator ==(Short4 a, Short4 b)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60018E4")]
	[Cpp2IlInjected.Address(RVA = "0x3A3FD8", Offset = "0x3A3FD8", VA = "0x3A3FD8", Slot = "0")]
	public override bool Equals(object obj)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60018E5")]
	[Cpp2IlInjected.Address(RVA = "0x3A3FE0", Offset = "0x3A3FE0", VA = "0x3A3FE0", Slot = "8")]
	public bool Equals(Short4 other)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60018E6")]
	[Cpp2IlInjected.Address(RVA = "0x3A3FFC", Offset = "0x3A3FFC", VA = "0x3A3FFC", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60018E7")]
	[Cpp2IlInjected.Address(RVA = "0x3A4008", Offset = "0x3A4008", VA = "0x3A4008", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60018E8")]
	[Cpp2IlInjected.Address(RVA = "0x158EC34", Offset = "0x158EC34", VA = "0x158EC34")]
	private static ulong Pack(ref Vector4 vector)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x60018E9")]
	[Cpp2IlInjected.Address(RVA = "0x3A4010", Offset = "0x3A4010", VA = "0x3A4010", Slot = "6")]
	void IPackedVector.PackFromVector4(Vector4 vector)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60018EA")]
	[Cpp2IlInjected.Address(RVA = "0x3A4040", Offset = "0x3A4040", VA = "0x3A4040", Slot = "7")]
	public Vector4 ToVector4()
	{
		return default(Vector4);
	}
}
