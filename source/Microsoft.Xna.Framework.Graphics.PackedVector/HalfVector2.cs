using System;
using Cpp2IlInjected;

namespace Microsoft.Xna.Framework.Graphics.PackedVector;

[Cpp2IlInjected.Token(Token = "0x20002E5")]
public struct HalfVector2 : IPackedVector<uint>, IPackedVector, IEquatable<HalfVector2>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4002144")]
	private uint packedValue;

	[Cpp2IlInjected.Token(Token = "0x1700033B")]
	[Cpp2IlInjected.Attribute(Name = "CLSCompliantAttribute", RVA = "0x399260", Offset = "0x399260")]
	public uint PackedValue
	{
		[Cpp2IlInjected.Token(Token = "0x6001859")]
		[Cpp2IlInjected.Address(RVA = "0x3A34D4", Offset = "0x3A34D4", VA = "0x3A34D4", Slot = "4")]
		get
		{
			return default(uint);
		}
		[Cpp2IlInjected.Token(Token = "0x600185A")]
		[Cpp2IlInjected.Address(RVA = "0x3A34DC", Offset = "0x3A34DC", VA = "0x3A34DC", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6001853")]
	[Cpp2IlInjected.Address(RVA = "0x3A3400", Offset = "0x3A3400", VA = "0x3A3400")]
	public HalfVector2(float x, float y)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001854")]
	[Cpp2IlInjected.Address(RVA = "0x3A3430", Offset = "0x3A3430", VA = "0x3A3430")]
	public HalfVector2(Vector2 vector)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001855")]
	[Cpp2IlInjected.Address(RVA = "0x3A3460", Offset = "0x3A3460", VA = "0x3A3460", Slot = "6")]
	void IPackedVector.PackFromVector4(Vector4 vector)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001856")]
	[Cpp2IlInjected.Address(RVA = "0x158BBA4", Offset = "0x158BBA4", VA = "0x158BBA4")]
	private static uint PackHelper(float vectorX, float vectorY)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6001857")]
	[Cpp2IlInjected.Address(RVA = "0x3A3490", Offset = "0x3A3490", VA = "0x3A3490")]
	public Vector2 ToVector2()
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x6001858")]
	[Cpp2IlInjected.Address(RVA = "0x3A34C0", Offset = "0x3A34C0", VA = "0x3A34C0", Slot = "7")]
	Vector4 IPackedVector.ToVector4()
	{
		return default(Vector4);
	}

	[Cpp2IlInjected.Token(Token = "0x600185B")]
	[Cpp2IlInjected.Address(RVA = "0x3A34E4", Offset = "0x3A34E4", VA = "0x3A34E4", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600185C")]
	[Cpp2IlInjected.Address(RVA = "0x3A34EC", Offset = "0x3A34EC", VA = "0x3A34EC", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600185D")]
	[Cpp2IlInjected.Address(RVA = "0x3A34F8", Offset = "0x3A34F8", VA = "0x3A34F8", Slot = "0")]
	public override bool Equals(object obj)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600185E")]
	[Cpp2IlInjected.Address(RVA = "0x3A3500", Offset = "0x3A3500", VA = "0x3A3500", Slot = "8")]
	public bool Equals(HalfVector2 other)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600185F")]
	[Cpp2IlInjected.Address(RVA = "0x158BDA0", Offset = "0x158BDA0", VA = "0x158BDA0")]
	public static bool operator ==(HalfVector2 a, HalfVector2 b)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6001860")]
	[Cpp2IlInjected.Address(RVA = "0x158BDC4", Offset = "0x158BDC4", VA = "0x158BDC4")]
	public static bool operator !=(HalfVector2 a, HalfVector2 b)
	{
		return default(bool);
	}
}
