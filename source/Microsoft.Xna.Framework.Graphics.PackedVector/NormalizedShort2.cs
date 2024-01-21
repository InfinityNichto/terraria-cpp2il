using System;
using Cpp2IlInjected;

namespace Microsoft.Xna.Framework.Graphics.PackedVector;

[Cpp2IlInjected.Token(Token = "0x20002EB")]
public struct NormalizedShort2 : IPackedVector<uint>, IPackedVector, IEquatable<NormalizedShort2>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4002148")]
	private uint short2Packed;

	[Cpp2IlInjected.Token(Token = "0x17000340")]
	[Cpp2IlInjected.Attribute(Name = "CLSCompliantAttribute", RVA = "0x3992B0", Offset = "0x3992B0")]
	public uint PackedValue
	{
		[Cpp2IlInjected.Token(Token = "0x6001891")]
		[Cpp2IlInjected.Address(RVA = "0x3A3898", Offset = "0x3A3898", VA = "0x3A3898", Slot = "4")]
		get
		{
			return default(uint);
		}
		[Cpp2IlInjected.Token(Token = "0x6001892")]
		[Cpp2IlInjected.Address(RVA = "0x3A38A0", Offset = "0x3A38A0", VA = "0x3A38A0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600188D")]
	[Cpp2IlInjected.Address(RVA = "0x3A3858", Offset = "0x3A3858", VA = "0x3A3858")]
	public NormalizedShort2(Vector2 vector)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600188E")]
	[Cpp2IlInjected.Address(RVA = "0x3A3878", Offset = "0x3A3878", VA = "0x3A3878")]
	public NormalizedShort2(float x, float y)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600188F")]
	[Cpp2IlInjected.Address(RVA = "0x158CDFC", Offset = "0x158CDFC", VA = "0x158CDFC")]
	public static bool operator !=(NormalizedShort2 a, NormalizedShort2 b)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6001890")]
	[Cpp2IlInjected.Address(RVA = "0x158CE2C", Offset = "0x158CE2C", VA = "0x158CE2C")]
	public static bool operator ==(NormalizedShort2 a, NormalizedShort2 b)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6001893")]
	[Cpp2IlInjected.Address(RVA = "0x3A38A8", Offset = "0x3A38A8", VA = "0x3A38A8", Slot = "0")]
	public override bool Equals(object obj)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6001894")]
	[Cpp2IlInjected.Address(RVA = "0x3A38B0", Offset = "0x3A38B0", VA = "0x3A38B0", Slot = "8")]
	public bool Equals(NormalizedShort2 other)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6001895")]
	[Cpp2IlInjected.Address(RVA = "0x3A38BC", Offset = "0x3A38BC", VA = "0x3A38BC", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6001896")]
	[Cpp2IlInjected.Address(RVA = "0x3A38C8", Offset = "0x3A38C8", VA = "0x3A38C8", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6001897")]
	[Cpp2IlInjected.Address(RVA = "0x3A38D0", Offset = "0x3A38D0", VA = "0x3A38D0")]
	public Vector2 ToVector2()
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x6001898")]
	[Cpp2IlInjected.Address(RVA = "0x158CBC8", Offset = "0x158CBC8", VA = "0x158CBC8")]
	private static uint PackInTwo(float vectorX, float vectorY)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6001899")]
	[Cpp2IlInjected.Address(RVA = "0x3A3908", Offset = "0x3A3908", VA = "0x3A3908", Slot = "6")]
	void IPackedVector.PackFromVector4(Vector4 vector)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600189A")]
	[Cpp2IlInjected.Address(RVA = "0x3A3928", Offset = "0x3A3928", VA = "0x3A3928", Slot = "7")]
	Vector4 IPackedVector.ToVector4()
	{
		return default(Vector4);
	}
}
