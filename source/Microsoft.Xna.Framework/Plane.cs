using System;
using Cpp2IlInjected;

namespace Microsoft.Xna.Framework;

[Serializable]
[Cpp2IlInjected.Token(Token = "0x200026D")]
public struct Plane : IEquatable<Plane>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4001C91")]
	public float D;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4001C92")]
	public Vector3 Normal;

	[Cpp2IlInjected.Token(Token = "0x60011E7")]
	[Cpp2IlInjected.Address(RVA = "0x3A2620", Offset = "0x3A2620", VA = "0x3A2620")]
	public Plane(Vector4 value)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60011E8")]
	[Cpp2IlInjected.Address(RVA = "0x3A2644", Offset = "0x3A2644", VA = "0x3A2644")]
	public Plane(Vector3 normal, float d)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60011E9")]
	[Cpp2IlInjected.Address(RVA = "0x3A2658", Offset = "0x3A2658", VA = "0x3A2658")]
	public Plane(Vector3 a, Vector3 b, Vector3 c)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60011EA")]
	[Cpp2IlInjected.Address(RVA = "0x3A26A0", Offset = "0x3A26A0", VA = "0x3A26A0")]
	public Plane(float a, float b, float c, float d)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60011EB")]
	[Cpp2IlInjected.Address(RVA = "0x3A26EC", Offset = "0x3A26EC", VA = "0x3A26EC")]
	public float Dot(Vector4 value)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60011EC")]
	[Cpp2IlInjected.Address(RVA = "0x3A2724", Offset = "0x3A2724", VA = "0x3A2724")]
	public void Dot(ref Vector4 value, out float result)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60011ED")]
	[Cpp2IlInjected.Address(RVA = "0x3A275C", Offset = "0x3A275C", VA = "0x3A275C")]
	public float DotCoordinate(Vector3 value)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60011EE")]
	[Cpp2IlInjected.Address(RVA = "0x3A2790", Offset = "0x3A2790", VA = "0x3A2790")]
	public void DotCoordinate(ref Vector3 value, out float result)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60011EF")]
	[Cpp2IlInjected.Address(RVA = "0x3A27C4", Offset = "0x3A27C4", VA = "0x3A27C4")]
	public float DotNormal(Vector3 value)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60011F0")]
	[Cpp2IlInjected.Address(RVA = "0x3A27F0", Offset = "0x3A27F0", VA = "0x3A27F0")]
	public void DotNormal(ref Vector3 value, out float result)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60011F1")]
	[Cpp2IlInjected.Address(RVA = "0x158365C", Offset = "0x158365C", VA = "0x158365C")]
	public static void Transform(ref Plane plane, ref Quaternion rotation, out Plane result)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60011F2")]
	[Cpp2IlInjected.Address(RVA = "0x15836D4", Offset = "0x15836D4", VA = "0x15836D4")]
	public static void Transform(ref Plane plane, ref Matrix matrix, out Plane result)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60011F3")]
	[Cpp2IlInjected.Address(RVA = "0x158374C", Offset = "0x158374C", VA = "0x158374C")]
	public static Plane Transform(Plane plane, Quaternion rotation)
	{
		return default(Plane);
	}

	[Cpp2IlInjected.Token(Token = "0x60011F4")]
	[Cpp2IlInjected.Address(RVA = "0x15837C4", Offset = "0x15837C4", VA = "0x15837C4")]
	public static Plane Transform(Plane plane, Matrix matrix)
	{
		return default(Plane);
	}

	[Cpp2IlInjected.Token(Token = "0x60011F5")]
	[Cpp2IlInjected.Address(RVA = "0x3A281C", Offset = "0x3A281C", VA = "0x3A281C")]
	public void Normalize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60011F6")]
	[Cpp2IlInjected.Address(RVA = "0x157C5A8", Offset = "0x157C5A8", VA = "0x157C5A8")]
	public static Plane Normalize(Plane value)
	{
		return default(Plane);
	}

	[Cpp2IlInjected.Token(Token = "0x60011F7")]
	[Cpp2IlInjected.Address(RVA = "0x1583990", Offset = "0x1583990", VA = "0x1583990")]
	public static void Normalize(ref Plane value, out Plane result)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60011F8")]
	[Cpp2IlInjected.Address(RVA = "0x1583AE4", Offset = "0x1583AE4", VA = "0x1583AE4")]
	public static bool operator !=(Plane plane1, Plane plane2)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60011F9")]
	[Cpp2IlInjected.Address(RVA = "0x1583C10", Offset = "0x1583C10", VA = "0x1583C10")]
	public static bool operator ==(Plane plane1, Plane plane2)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60011FA")]
	[Cpp2IlInjected.Address(RVA = "0x3A2824", Offset = "0x3A2824", VA = "0x3A2824", Slot = "0")]
	public override bool Equals(object other)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60011FB")]
	[Cpp2IlInjected.Address(RVA = "0x3A282C", Offset = "0x3A282C", VA = "0x3A282C", Slot = "4")]
	public bool Equals(Plane other)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60011FC")]
	[Cpp2IlInjected.Address(RVA = "0x3A2850", Offset = "0x3A2850", VA = "0x3A2850", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60011FD")]
	[Cpp2IlInjected.Address(RVA = "0x3A2880", Offset = "0x3A2880", VA = "0x3A2880", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
