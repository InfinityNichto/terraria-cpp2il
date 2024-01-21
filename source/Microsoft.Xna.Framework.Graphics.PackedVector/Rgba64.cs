using System;
using Cpp2IlInjected;

namespace Microsoft.Xna.Framework.Graphics.PackedVector;

[Cpp2IlInjected.Token(Token = "0x20002EF")]
public struct Rgba64 : IPackedVector<ulong>, IPackedVector, IEquatable<Rgba64>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400214C")]
	private ulong packedValue;

	[Cpp2IlInjected.Token(Token = "0x17000344")]
	[Cpp2IlInjected.Attribute(Name = "CLSCompliantAttribute", RVA = "0x399300", Offset = "0x399300")]
	public ulong PackedValue
	{
		[Cpp2IlInjected.Token(Token = "0x60018C3")]
		[Cpp2IlInjected.Address(RVA = "0x3A3CCC", Offset = "0x3A3CCC", VA = "0x3A3CCC", Slot = "4")]
		get
		{
			return default(ulong);
		}
		[Cpp2IlInjected.Token(Token = "0x60018C4")]
		[Cpp2IlInjected.Address(RVA = "0x3A3CD4", Offset = "0x3A3CD4", VA = "0x3A3CD4", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60018C5")]
	[Cpp2IlInjected.Address(RVA = "0x3A3CE4", Offset = "0x3A3CE4", VA = "0x3A3CE4")]
	public Rgba64(float x, float y, float z, float w)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60018C6")]
	[Cpp2IlInjected.Address(RVA = "0x3A3D18", Offset = "0x3A3D18", VA = "0x3A3D18")]
	public Rgba64(Vector4 vector)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60018C7")]
	[Cpp2IlInjected.Address(RVA = "0x3A3D4C", Offset = "0x3A3D4C", VA = "0x3A3D4C", Slot = "7")]
	public Vector4 ToVector4()
	{
		return default(Vector4);
	}

	[Cpp2IlInjected.Token(Token = "0x60018C8")]
	[Cpp2IlInjected.Address(RVA = "0x3A3D60", Offset = "0x3A3D60", VA = "0x3A3D60", Slot = "6")]
	void IPackedVector.PackFromVector4(Vector4 vector)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60018C9")]
	[Cpp2IlInjected.Address(RVA = "0x3A3D94", Offset = "0x3A3D94", VA = "0x3A3D94", Slot = "0")]
	public override bool Equals(object obj)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60018CA")]
	[Cpp2IlInjected.Address(RVA = "0x3A3D9C", Offset = "0x3A3D9C", VA = "0x3A3D9C", Slot = "8")]
	public bool Equals(Rgba64 other)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60018CB")]
	[Cpp2IlInjected.Address(RVA = "0x3A3DB8", Offset = "0x3A3DB8", VA = "0x3A3DB8", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60018CC")]
	[Cpp2IlInjected.Address(RVA = "0x3A3DFC", Offset = "0x3A3DFC", VA = "0x3A3DFC", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60018CD")]
	[Cpp2IlInjected.Address(RVA = "0x158E78C", Offset = "0x158E78C", VA = "0x158E78C")]
	public static bool operator ==(Rgba64 lhs, Rgba64 rhs)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60018CE")]
	[Cpp2IlInjected.Address(RVA = "0x158E7A4", Offset = "0x158E7A4", VA = "0x158E7A4")]
	public static bool operator !=(Rgba64 lhs, Rgba64 rhs)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60018CF")]
	[Cpp2IlInjected.Address(RVA = "0x158E110", Offset = "0x158E110", VA = "0x158E110")]
	private static ulong Pack(float x, float y, float z, float w)
	{
		return default(ulong);
	}
}
