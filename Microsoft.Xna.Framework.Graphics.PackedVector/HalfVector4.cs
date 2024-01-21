using System;
using Cpp2IlInjected;

namespace Microsoft.Xna.Framework.Graphics.PackedVector;

[Cpp2IlInjected.Token(Token = "0x20002E6")]
public struct HalfVector4 : IPackedVector<ulong>, IPackedVector, IEquatable<HalfVector4>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4002145")]
	private ulong packedValue;

	[Cpp2IlInjected.Token(Token = "0x1700033C")]
	[Cpp2IlInjected.Attribute(Name = "CLSCompliantAttribute", RVA = "0x399274", Offset = "0x399274")]
	public ulong PackedValue
	{
		[Cpp2IlInjected.Token(Token = "0x6001866")]
		[Cpp2IlInjected.Address(RVA = "0x3A35C8", Offset = "0x3A35C8", VA = "0x3A35C8", Slot = "4")]
		get
		{
			return default(ulong);
		}
		[Cpp2IlInjected.Token(Token = "0x6001867")]
		[Cpp2IlInjected.Address(RVA = "0x3A35D0", Offset = "0x3A35D0", VA = "0x3A35D0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6001861")]
	[Cpp2IlInjected.Address(RVA = "0x3A350C", Offset = "0x3A350C", VA = "0x3A350C")]
	public HalfVector4(float x, float y, float z, float w)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001862")]
	[Cpp2IlInjected.Address(RVA = "0x3A3554", Offset = "0x3A3554", VA = "0x3A3554")]
	public HalfVector4(Vector4 vector)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001863")]
	[Cpp2IlInjected.Address(RVA = "0x3A3584", Offset = "0x3A3584", VA = "0x3A3584", Slot = "6")]
	void IPackedVector.PackFromVector4(Vector4 vector)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001864")]
	[Cpp2IlInjected.Address(RVA = "0x158BE34", Offset = "0x158BE34", VA = "0x158BE34")]
	private static ulong PackHelper(ref Vector4 vector)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x6001865")]
	[Cpp2IlInjected.Address(RVA = "0x3A35B4", Offset = "0x3A35B4", VA = "0x3A35B4", Slot = "7")]
	public Vector4 ToVector4()
	{
		return default(Vector4);
	}

	[Cpp2IlInjected.Token(Token = "0x6001868")]
	[Cpp2IlInjected.Address(RVA = "0x3A35E0", Offset = "0x3A35E0", VA = "0x3A35E0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6001869")]
	[Cpp2IlInjected.Address(RVA = "0x3A3624", Offset = "0x3A3624", VA = "0x3A3624", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600186A")]
	[Cpp2IlInjected.Address(RVA = "0x3A3630", Offset = "0x3A3630", VA = "0x3A3630", Slot = "0")]
	public override bool Equals(object obj)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600186B")]
	[Cpp2IlInjected.Address(RVA = "0x3A3638", Offset = "0x3A3638", VA = "0x3A3638", Slot = "8")]
	public bool Equals(HalfVector4 other)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600186C")]
	[Cpp2IlInjected.Address(RVA = "0x158C068", Offset = "0x158C068", VA = "0x158C068")]
	public static bool operator ==(HalfVector4 a, HalfVector4 b)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600186D")]
	[Cpp2IlInjected.Address(RVA = "0x158C094", Offset = "0x158C094", VA = "0x158C094")]
	public static bool operator !=(HalfVector4 a, HalfVector4 b)
	{
		return default(bool);
	}
}
