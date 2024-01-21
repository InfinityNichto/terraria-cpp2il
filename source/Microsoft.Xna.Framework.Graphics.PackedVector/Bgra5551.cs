using System;
using Cpp2IlInjected;

namespace Microsoft.Xna.Framework.Graphics.PackedVector;

[Cpp2IlInjected.Token(Token = "0x20002E1")]
public struct Bgra5551 : IPackedVector<ushort>, IPackedVector, IEquatable<Bgra5551>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4002141")]
	private ushort packedValue;

	[Cpp2IlInjected.Token(Token = "0x17000338")]
	[Cpp2IlInjected.Attribute(Name = "CLSCompliantAttribute", RVA = "0x399224", Offset = "0x399224")]
	public ushort PackedValue
	{
		[Cpp2IlInjected.Token(Token = "0x6001829")]
		[Cpp2IlInjected.Address(RVA = "0x3A30E0", Offset = "0x3A30E0", VA = "0x3A30E0", Slot = "4")]
		get
		{
			return default(ushort);
		}
		[Cpp2IlInjected.Token(Token = "0x600182A")]
		[Cpp2IlInjected.Address(RVA = "0x3A30E8", Offset = "0x3A30E8", VA = "0x3A30E8", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600182B")]
	[Cpp2IlInjected.Address(RVA = "0x3A30F0", Offset = "0x3A30F0", VA = "0x3A30F0")]
	public Bgra5551(float x, float y, float z, float w)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600182C")]
	[Cpp2IlInjected.Address(RVA = "0x3A3124", Offset = "0x3A3124", VA = "0x3A3124")]
	public Bgra5551(Vector4 vector)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600182D")]
	[Cpp2IlInjected.Address(RVA = "0x3A3158", Offset = "0x3A3158", VA = "0x3A3158", Slot = "7")]
	public Vector4 ToVector4()
	{
		return default(Vector4);
	}

	[Cpp2IlInjected.Token(Token = "0x600182E")]
	[Cpp2IlInjected.Address(RVA = "0x3A316C", Offset = "0x3A316C", VA = "0x3A316C", Slot = "6")]
	void IPackedVector.PackFromVector4(Vector4 vector)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600182F")]
	[Cpp2IlInjected.Address(RVA = "0x3A31A0", Offset = "0x3A31A0", VA = "0x3A31A0", Slot = "0")]
	public override bool Equals(object obj)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6001830")]
	[Cpp2IlInjected.Address(RVA = "0x3A31A8", Offset = "0x3A31A8", VA = "0x3A31A8", Slot = "8")]
	public bool Equals(Bgra5551 other)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6001831")]
	[Cpp2IlInjected.Address(RVA = "0x3A31C0", Offset = "0x3A31C0", VA = "0x3A31C0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6001832")]
	[Cpp2IlInjected.Address(RVA = "0x3A3204", Offset = "0x3A3204", VA = "0x3A3204", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6001833")]
	[Cpp2IlInjected.Address(RVA = "0x158B1B8", Offset = "0x158B1B8", VA = "0x158B1B8")]
	public static bool operator ==(Bgra5551 lhs, Bgra5551 rhs)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6001834")]
	[Cpp2IlInjected.Address(RVA = "0x158B1D0", Offset = "0x158B1D0", VA = "0x158B1D0")]
	public static bool operator !=(Bgra5551 lhs, Bgra5551 rhs)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6001835")]
	[Cpp2IlInjected.Address(RVA = "0x158AC74", Offset = "0x158AC74", VA = "0x158AC74")]
	private static ushort Pack(float x, float y, float z, float w)
	{
		return default(ushort);
	}
}
