using System;
using Cpp2IlInjected;

namespace Microsoft.Xna.Framework.Graphics.PackedVector;

[Cpp2IlInjected.Token(Token = "0x20002EC")]
public struct NormalizedShort4 : IPackedVector<ulong>, IPackedVector, IEquatable<NormalizedShort4>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4002149")]
	private ulong short4Packed;

	[Cpp2IlInjected.Token(Token = "0x17000341")]
	[Cpp2IlInjected.Attribute(Name = "CLSCompliantAttribute", RVA = "0x3992C4", Offset = "0x3992C4")]
	public ulong PackedValue
	{
		[Cpp2IlInjected.Token(Token = "0x600189F")]
		[Cpp2IlInjected.Address(RVA = "0x3A39A4", Offset = "0x3A39A4", VA = "0x3A39A4", Slot = "4")]
		get
		{
			return default(ulong);
		}
		[Cpp2IlInjected.Token(Token = "0x60018A0")]
		[Cpp2IlInjected.Address(RVA = "0x3A39AC", Offset = "0x3A39AC", VA = "0x3A39AC", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600189B")]
	[Cpp2IlInjected.Address(RVA = "0x3A393C", Offset = "0x3A393C", VA = "0x3A393C")]
	public NormalizedShort4(Vector4 vector)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600189C")]
	[Cpp2IlInjected.Address(RVA = "0x3A3970", Offset = "0x3A3970", VA = "0x3A3970")]
	public NormalizedShort4(float x, float y, float z, float w)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600189D")]
	[Cpp2IlInjected.Address(RVA = "0x158D434", Offset = "0x158D434", VA = "0x158D434")]
	public static bool operator !=(NormalizedShort4 a, NormalizedShort4 b)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600189E")]
	[Cpp2IlInjected.Address(RVA = "0x158D484", Offset = "0x158D484", VA = "0x158D484")]
	public static bool operator ==(NormalizedShort4 a, NormalizedShort4 b)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60018A1")]
	[Cpp2IlInjected.Address(RVA = "0x3A39BC", Offset = "0x3A39BC", VA = "0x3A39BC", Slot = "0")]
	public override bool Equals(object obj)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60018A2")]
	[Cpp2IlInjected.Address(RVA = "0x3A39C4", Offset = "0x3A39C4", VA = "0x3A39C4", Slot = "8")]
	public bool Equals(NormalizedShort4 other)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60018A3")]
	[Cpp2IlInjected.Address(RVA = "0x3A39E8", Offset = "0x3A39E8", VA = "0x3A39E8", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60018A4")]
	[Cpp2IlInjected.Address(RVA = "0x3A39F4", Offset = "0x3A39F4", VA = "0x3A39F4", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60018A5")]
	[Cpp2IlInjected.Address(RVA = "0x158D068", Offset = "0x158D068", VA = "0x158D068")]
	private static ulong PackInFour(float vectorX, float vectorY, float vectorZ, float vectorW)
	{
		return default(ulong);
	}

	[Cpp2IlInjected.Token(Token = "0x60018A6")]
	[Cpp2IlInjected.Address(RVA = "0x3A39FC", Offset = "0x3A39FC", VA = "0x3A39FC", Slot = "6")]
	void IPackedVector.PackFromVector4(Vector4 vector)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60018A7")]
	[Cpp2IlInjected.Address(RVA = "0x3A3A30", Offset = "0x3A3A30", VA = "0x3A3A30", Slot = "7")]
	public Vector4 ToVector4()
	{
		return default(Vector4);
	}
}
