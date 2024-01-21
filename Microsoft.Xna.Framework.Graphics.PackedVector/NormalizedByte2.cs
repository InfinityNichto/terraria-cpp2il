using System;
using Cpp2IlInjected;

namespace Microsoft.Xna.Framework.Graphics.PackedVector;

[Cpp2IlInjected.Token(Token = "0x20002E9")]
public struct NormalizedByte2 : IPackedVector<ushort>, IPackedVector, IEquatable<NormalizedByte2>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4002146")]
	private ushort _packed;

	[Cpp2IlInjected.Token(Token = "0x1700033E")]
	[Cpp2IlInjected.Attribute(Name = "CLSCompliantAttribute", RVA = "0x399288", Offset = "0x399288")]
	public ushort PackedValue
	{
		[Cpp2IlInjected.Token(Token = "0x6001876")]
		[Cpp2IlInjected.Address(RVA = "0x3A369C", Offset = "0x3A369C", VA = "0x3A369C", Slot = "4")]
		get
		{
			return default(ushort);
		}
		[Cpp2IlInjected.Token(Token = "0x6001877")]
		[Cpp2IlInjected.Address(RVA = "0x3A36A4", Offset = "0x3A36A4", VA = "0x3A36A4", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6001872")]
	[Cpp2IlInjected.Address(RVA = "0x3A365C", Offset = "0x3A365C", VA = "0x3A365C")]
	public NormalizedByte2(Vector2 vector)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001873")]
	[Cpp2IlInjected.Address(RVA = "0x3A367C", Offset = "0x3A367C", VA = "0x3A367C")]
	public NormalizedByte2(float x, float y)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001874")]
	[Cpp2IlInjected.Address(RVA = "0x158C330", Offset = "0x158C330", VA = "0x158C330")]
	public static bool operator !=(NormalizedByte2 a, NormalizedByte2 b)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6001875")]
	[Cpp2IlInjected.Address(RVA = "0x158C344", Offset = "0x158C344", VA = "0x158C344")]
	public static bool operator ==(NormalizedByte2 a, NormalizedByte2 b)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6001878")]
	[Cpp2IlInjected.Address(RVA = "0x3A36AC", Offset = "0x3A36AC", VA = "0x3A36AC", Slot = "0")]
	public override bool Equals(object obj)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6001879")]
	[Cpp2IlInjected.Address(RVA = "0x3A36B4", Offset = "0x3A36B4", VA = "0x3A36B4", Slot = "8")]
	public bool Equals(NormalizedByte2 other)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600187A")]
	[Cpp2IlInjected.Address(RVA = "0x3A36CC", Offset = "0x3A36CC", VA = "0x3A36CC", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600187B")]
	[Cpp2IlInjected.Address(RVA = "0x3A36D8", Offset = "0x3A36D8", VA = "0x3A36D8", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600187C")]
	[Cpp2IlInjected.Address(RVA = "0x158C0E4", Offset = "0x158C0E4", VA = "0x158C0E4")]
	private static ushort Pack(float x, float y)
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x600187D")]
	[Cpp2IlInjected.Address(RVA = "0x3A36E0", Offset = "0x3A36E0", VA = "0x3A36E0", Slot = "6")]
	void IPackedVector.PackFromVector4(Vector4 vector)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600187E")]
	[Cpp2IlInjected.Address(RVA = "0x3A3700", Offset = "0x3A3700", VA = "0x3A3700", Slot = "7")]
	Vector4 IPackedVector.ToVector4()
	{
		return default(Vector4);
	}

	[Cpp2IlInjected.Token(Token = "0x600187F")]
	[Cpp2IlInjected.Address(RVA = "0x3A3714", Offset = "0x3A3714", VA = "0x3A3714")]
	public Vector2 ToVector2()
	{
		return default(Vector2);
	}
}
