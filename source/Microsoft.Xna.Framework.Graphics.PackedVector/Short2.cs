using System;
using Cpp2IlInjected;

namespace Microsoft.Xna.Framework.Graphics.PackedVector;

[Cpp2IlInjected.Token(Token = "0x20002F0")]
public struct Short2 : IPackedVector<uint>, IPackedVector, IEquatable<Short2>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400214D")]
	private uint _short2Packed;

	[Cpp2IlInjected.Token(Token = "0x17000345")]
	[Cpp2IlInjected.Attribute(Name = "CLSCompliantAttribute", RVA = "0x399314", Offset = "0x399314")]
	public uint PackedValue
	{
		[Cpp2IlInjected.Token(Token = "0x60018D4")]
		[Cpp2IlInjected.Address(RVA = "0x3A3E48", Offset = "0x3A3E48", VA = "0x3A3E48", Slot = "4")]
		get
		{
			return default(uint);
		}
		[Cpp2IlInjected.Token(Token = "0x60018D5")]
		[Cpp2IlInjected.Address(RVA = "0x3A3E50", Offset = "0x3A3E50", VA = "0x3A3E50", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60018D0")]
	[Cpp2IlInjected.Address(RVA = "0x3A3E08", Offset = "0x3A3E08", VA = "0x3A3E08")]
	public Short2(Vector2 vector)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60018D1")]
	[Cpp2IlInjected.Address(RVA = "0x3A3E28", Offset = "0x3A3E28", VA = "0x3A3E28")]
	public Short2(float x, float y)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60018D2")]
	[Cpp2IlInjected.Address(RVA = "0x158EA0C", Offset = "0x158EA0C", VA = "0x158EA0C")]
	public static bool operator !=(Short2 a, Short2 b)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60018D3")]
	[Cpp2IlInjected.Address(RVA = "0x158EA18", Offset = "0x158EA18", VA = "0x158EA18")]
	public static bool operator ==(Short2 a, Short2 b)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60018D6")]
	[Cpp2IlInjected.Address(RVA = "0x3A3E58", Offset = "0x3A3E58", VA = "0x3A3E58", Slot = "0")]
	public override bool Equals(object obj)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60018D7")]
	[Cpp2IlInjected.Address(RVA = "0x3A3E60", Offset = "0x3A3E60", VA = "0x3A3E60", Slot = "8")]
	public bool Equals(Short2 other)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60018D8")]
	[Cpp2IlInjected.Address(RVA = "0x3A3E74", Offset = "0x3A3E74", VA = "0x3A3E74", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60018D9")]
	[Cpp2IlInjected.Address(RVA = "0x3A3E80", Offset = "0x3A3E80", VA = "0x3A3E80", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60018DA")]
	[Cpp2IlInjected.Address(RVA = "0x3A3E88", Offset = "0x3A3E88", VA = "0x3A3E88")]
	public Vector2 ToVector2()
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x60018DB")]
	[Cpp2IlInjected.Address(RVA = "0x158E7D8", Offset = "0x158E7D8", VA = "0x158E7D8")]
	private static uint PackInTwo(float vectorX, float vectorY)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60018DC")]
	[Cpp2IlInjected.Address(RVA = "0x3A3EB0", Offset = "0x3A3EB0", VA = "0x3A3EB0", Slot = "6")]
	void IPackedVector.PackFromVector4(Vector4 vector)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60018DD")]
	[Cpp2IlInjected.Address(RVA = "0x3A3ED0", Offset = "0x3A3ED0", VA = "0x3A3ED0", Slot = "7")]
	Vector4 IPackedVector.ToVector4()
	{
		return default(Vector4);
	}
}
