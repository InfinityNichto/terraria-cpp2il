using System;
using Cpp2IlInjected;

namespace Microsoft.Xna.Framework.Graphics.PackedVector;

[Cpp2IlInjected.Token(Token = "0x20002DF")]
public struct Bgr565 : IPackedVector<ushort>, IPackedVector, IEquatable<Bgr565>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400213F")]
	private ushort _packedValue;

	[Cpp2IlInjected.Token(Token = "0x17000336")]
	[Cpp2IlInjected.Attribute(Name = "CLSCompliantAttribute", RVA = "0x3991FC", Offset = "0x3991FC")]
	public ushort PackedValue
	{
		[Cpp2IlInjected.Token(Token = "0x6001811")]
		[Cpp2IlInjected.Address(RVA = "0x3A2E88", Offset = "0x3A2E88", VA = "0x3A2E88", Slot = "4")]
		get
		{
			return default(ushort);
		}
		[Cpp2IlInjected.Token(Token = "0x6001812")]
		[Cpp2IlInjected.Address(RVA = "0x3A2E90", Offset = "0x3A2E90", VA = "0x3A2E90", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600180E")]
	[Cpp2IlInjected.Address(RVA = "0x158A064", Offset = "0x158A064", VA = "0x158A064")]
	private static ushort Pack(float x, float y, float z)
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x600180F")]
	[Cpp2IlInjected.Address(RVA = "0x3A2E40", Offset = "0x3A2E40", VA = "0x3A2E40")]
	public Bgr565(float x, float y, float z)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001810")]
	[Cpp2IlInjected.Address(RVA = "0x3A2E64", Offset = "0x3A2E64", VA = "0x3A2E64")]
	public Bgr565(Vector3 vector)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001813")]
	[Cpp2IlInjected.Address(RVA = "0x3A2E98", Offset = "0x3A2E98", VA = "0x3A2E98")]
	public Vector3 ToVector3()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6001814")]
	[Cpp2IlInjected.Address(RVA = "0x3A2F14", Offset = "0x3A2F14", VA = "0x3A2F14", Slot = "6")]
	void IPackedVector.PackFromVector4(Vector4 vector)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001815")]
	[Cpp2IlInjected.Address(RVA = "0x3A2F68", Offset = "0x3A2F68", VA = "0x3A2F68", Slot = "7")]
	Vector4 IPackedVector.ToVector4()
	{
		return default(Vector4);
	}

	[Cpp2IlInjected.Token(Token = "0x6001816")]
	[Cpp2IlInjected.Address(RVA = "0x3A2F7C", Offset = "0x3A2F7C", VA = "0x3A2F7C", Slot = "0")]
	public override bool Equals(object obj)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6001817")]
	[Cpp2IlInjected.Address(RVA = "0x3A2F84", Offset = "0x3A2F84", VA = "0x3A2F84", Slot = "8")]
	public bool Equals(Bgr565 other)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6001818")]
	[Cpp2IlInjected.Address(RVA = "0x3A2F9C", Offset = "0x3A2F9C", VA = "0x3A2F9C", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6001819")]
	[Cpp2IlInjected.Address(RVA = "0x3A2FA4", Offset = "0x3A2FA4", VA = "0x3A2FA4", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600181A")]
	[Cpp2IlInjected.Address(RVA = "0x158A57C", Offset = "0x158A57C", VA = "0x158A57C")]
	public static bool operator ==(Bgr565 lhs, Bgr565 rhs)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600181B")]
	[Cpp2IlInjected.Address(RVA = "0x158A65C", Offset = "0x158A65C", VA = "0x158A65C")]
	public static bool operator !=(Bgr565 lhs, Bgr565 rhs)
	{
		return default(bool);
	}
}
