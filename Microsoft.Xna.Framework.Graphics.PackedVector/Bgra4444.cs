using System;
using Cpp2IlInjected;

namespace Microsoft.Xna.Framework.Graphics.PackedVector;

[Cpp2IlInjected.Token(Token = "0x20002E0")]
public struct Bgra4444 : IPackedVector<ushort>, IPackedVector, IEquatable<Bgra4444>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4002140")]
	private ushort _packedValue;

	[Cpp2IlInjected.Token(Token = "0x17000337")]
	[Cpp2IlInjected.Attribute(Name = "CLSCompliantAttribute", RVA = "0x399210", Offset = "0x399210")]
	public ushort PackedValue
	{
		[Cpp2IlInjected.Token(Token = "0x600181F")]
		[Cpp2IlInjected.Address(RVA = "0x3A3018", Offset = "0x3A3018", VA = "0x3A3018", Slot = "4")]
		get
		{
			return default(ushort);
		}
		[Cpp2IlInjected.Token(Token = "0x6001820")]
		[Cpp2IlInjected.Address(RVA = "0x3A3020", Offset = "0x3A3020", VA = "0x3A3020", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600181C")]
	[Cpp2IlInjected.Address(RVA = "0x158A670", Offset = "0x158A670", VA = "0x158A670")]
	private static ushort Pack(float x, float y, float z, float w)
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x600181D")]
	[Cpp2IlInjected.Address(RVA = "0x3A2FB0", Offset = "0x3A2FB0", VA = "0x3A2FB0")]
	public Bgra4444(float x, float y, float z, float w)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600181E")]
	[Cpp2IlInjected.Address(RVA = "0x3A2FE4", Offset = "0x3A2FE4", VA = "0x3A2FE4")]
	public Bgra4444(Vector4 vector)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001821")]
	[Cpp2IlInjected.Address(RVA = "0x3A3028", Offset = "0x3A3028", VA = "0x3A3028", Slot = "7")]
	public Vector4 ToVector4()
	{
		return default(Vector4);
	}

	[Cpp2IlInjected.Token(Token = "0x6001822")]
	[Cpp2IlInjected.Address(RVA = "0x3A303C", Offset = "0x3A303C", VA = "0x3A303C", Slot = "6")]
	void IPackedVector.PackFromVector4(Vector4 vector)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001823")]
	[Cpp2IlInjected.Address(RVA = "0x3A3070", Offset = "0x3A3070", VA = "0x3A3070", Slot = "0")]
	public override bool Equals(object obj)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6001824")]
	[Cpp2IlInjected.Address(RVA = "0x3A3078", Offset = "0x3A3078", VA = "0x3A3078", Slot = "8")]
	public bool Equals(Bgra4444 other)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6001825")]
	[Cpp2IlInjected.Address(RVA = "0x3A3090", Offset = "0x3A3090", VA = "0x3A3090", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6001826")]
	[Cpp2IlInjected.Address(RVA = "0x3A30D4", Offset = "0x3A30D4", VA = "0x3A30D4", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6001827")]
	[Cpp2IlInjected.Address(RVA = "0x158ABA0", Offset = "0x158ABA0", VA = "0x158ABA0")]
	public static bool operator ==(Bgra4444 lhs, Bgra4444 rhs)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6001828")]
	[Cpp2IlInjected.Address(RVA = "0x158AC1C", Offset = "0x158AC1C", VA = "0x158AC1C")]
	public static bool operator !=(Bgra4444 lhs, Bgra4444 rhs)
	{
		return default(bool);
	}
}
