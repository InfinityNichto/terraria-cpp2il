using System;
using Cpp2IlInjected;

namespace Microsoft.Xna.Framework.Graphics.PackedVector;

[Cpp2IlInjected.Token(Token = "0x20002EA")]
public struct NormalizedByte4 : IPackedVector<uint>, IPackedVector, IEquatable<NormalizedByte4>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4002147")]
	private uint _packed;

	[Cpp2IlInjected.Token(Token = "0x1700033F")]
	[Cpp2IlInjected.Attribute(Name = "CLSCompliantAttribute", RVA = "0x39929C", Offset = "0x39929C")]
	public uint PackedValue
	{
		[Cpp2IlInjected.Token(Token = "0x6001884")]
		[Cpp2IlInjected.Address(RVA = "0x3A37D0", Offset = "0x3A37D0", VA = "0x3A37D0", Slot = "4")]
		get
		{
			return default(uint);
		}
		[Cpp2IlInjected.Token(Token = "0x6001885")]
		[Cpp2IlInjected.Address(RVA = "0x3A37D8", Offset = "0x3A37D8", VA = "0x3A37D8", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6001880")]
	[Cpp2IlInjected.Address(RVA = "0x3A3768", Offset = "0x3A3768", VA = "0x3A3768")]
	public NormalizedByte4(Vector4 vector)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001881")]
	[Cpp2IlInjected.Address(RVA = "0x3A379C", Offset = "0x3A379C", VA = "0x3A379C")]
	public NormalizedByte4(float x, float y, float z, float w)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001882")]
	[Cpp2IlInjected.Address(RVA = "0x158C9B8", Offset = "0x158C9B8", VA = "0x158C9B8")]
	public static bool operator !=(NormalizedByte4 a, NormalizedByte4 b)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6001883")]
	[Cpp2IlInjected.Address(RVA = "0x158C9C4", Offset = "0x158C9C4", VA = "0x158C9C4")]
	public static bool operator ==(NormalizedByte4 a, NormalizedByte4 b)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6001886")]
	[Cpp2IlInjected.Address(RVA = "0x3A37E0", Offset = "0x3A37E0", VA = "0x3A37E0", Slot = "0")]
	public override bool Equals(object obj)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6001887")]
	[Cpp2IlInjected.Address(RVA = "0x3A37E8", Offset = "0x3A37E8", VA = "0x3A37E8", Slot = "8")]
	public bool Equals(NormalizedByte4 other)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6001888")]
	[Cpp2IlInjected.Address(RVA = "0x3A37FC", Offset = "0x3A37FC", VA = "0x3A37FC", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6001889")]
	[Cpp2IlInjected.Address(RVA = "0x3A3808", Offset = "0x3A3808", VA = "0x3A3808", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600188A")]
	[Cpp2IlInjected.Address(RVA = "0x158C5AC", Offset = "0x158C5AC", VA = "0x158C5AC")]
	private static uint Pack(float x, float y, float z, float w)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x600188B")]
	[Cpp2IlInjected.Address(RVA = "0x3A3810", Offset = "0x3A3810", VA = "0x3A3810", Slot = "6")]
	void IPackedVector.PackFromVector4(Vector4 vector)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600188C")]
	[Cpp2IlInjected.Address(RVA = "0x3A3844", Offset = "0x3A3844", VA = "0x3A3844", Slot = "7")]
	public Vector4 ToVector4()
	{
		return default(Vector4);
	}
}
