using System;
using Cpp2IlInjected;

namespace Microsoft.Xna.Framework.Graphics.PackedVector;

[Cpp2IlInjected.Token(Token = "0x20002E2")]
public struct Byte4 : IPackedVector<uint>, IPackedVector, IEquatable<Byte4>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4002142")]
	private uint packedValue;

	[Cpp2IlInjected.Token(Token = "0x17000339")]
	[Cpp2IlInjected.Attribute(Name = "CLSCompliantAttribute", RVA = "0x399238", Offset = "0x399238")]
	public uint PackedValue
	{
		[Cpp2IlInjected.Token(Token = "0x600183A")]
		[Cpp2IlInjected.Address(RVA = "0x3A3288", Offset = "0x3A3288", VA = "0x3A3288", Slot = "4")]
		get
		{
			return default(uint);
		}
		[Cpp2IlInjected.Token(Token = "0x600183B")]
		[Cpp2IlInjected.Address(RVA = "0x3A3290", Offset = "0x3A3290", VA = "0x3A3290", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6001836")]
	[Cpp2IlInjected.Address(RVA = "0x3A3210", Offset = "0x3A3210", VA = "0x3A3210")]
	public Byte4(Vector4 vector)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001837")]
	[Cpp2IlInjected.Address(RVA = "0x3A3240", Offset = "0x3A3240", VA = "0x3A3240")]
	public Byte4(float x, float y, float z, float w)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001838")]
	[Cpp2IlInjected.Address(RVA = "0x158B610", Offset = "0x158B610", VA = "0x158B610")]
	public static bool operator !=(Byte4 a, Byte4 b)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6001839")]
	[Cpp2IlInjected.Address(RVA = "0x158B61C", Offset = "0x158B61C", VA = "0x158B61C")]
	public static bool operator ==(Byte4 a, Byte4 b)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600183C")]
	[Cpp2IlInjected.Address(RVA = "0x3A3298", Offset = "0x3A3298", VA = "0x3A3298", Slot = "0")]
	public override bool Equals(object obj)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600183D")]
	[Cpp2IlInjected.Address(RVA = "0x3A32A0", Offset = "0x3A32A0", VA = "0x3A32A0", Slot = "8")]
	public bool Equals(Byte4 other)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600183E")]
	[Cpp2IlInjected.Address(RVA = "0x3A32B4", Offset = "0x3A32B4", VA = "0x3A32B4", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600183F")]
	[Cpp2IlInjected.Address(RVA = "0x3A32C0", Offset = "0x3A32C0", VA = "0x3A32C0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6001840")]
	[Cpp2IlInjected.Address(RVA = "0x158B214", Offset = "0x158B214", VA = "0x158B214")]
	private static uint Pack(ref Vector4 vector)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6001841")]
	[Cpp2IlInjected.Address(RVA = "0x3A32C8", Offset = "0x3A32C8", VA = "0x3A32C8", Slot = "6")]
	void IPackedVector.PackFromVector4(Vector4 vector)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001842")]
	[Cpp2IlInjected.Address(RVA = "0x3A32F8", Offset = "0x3A32F8", VA = "0x3A32F8", Slot = "7")]
	public Vector4 ToVector4()
	{
		return default(Vector4);
	}
}
