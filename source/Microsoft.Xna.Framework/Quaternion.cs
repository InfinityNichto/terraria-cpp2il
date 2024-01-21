using System;
using Cpp2IlInjected;

namespace Microsoft.Xna.Framework;

[Serializable]
[Cpp2IlInjected.Token(Token = "0x200026F")]
public struct Quaternion : IEquatable<Quaternion>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4001C96")]
	public float X;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4001C97")]
	public float Y;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4001C98")]
	public float Z;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4001C99")]
	public float W;

	[Cpp2IlInjected.Token(Token = "0x4001C9A")]
	private static Quaternion identity;

	[Cpp2IlInjected.Token(Token = "0x170001BA")]
	public static Quaternion Identity
	{
		[Cpp2IlInjected.Token(Token = "0x6001209")]
		[Cpp2IlInjected.Address(RVA = "0x1584030", Offset = "0x1584030", VA = "0x1584030")]
		get
		{
			return default(Quaternion);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6001207")]
	[Cpp2IlInjected.Address(RVA = "0x3A28D8", Offset = "0x3A28D8", VA = "0x3A28D8")]
	public Quaternion(float x, float y, float z, float w)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001208")]
	[Cpp2IlInjected.Address(RVA = "0x3A28EC", Offset = "0x3A28EC", VA = "0x3A28EC")]
	public Quaternion(Vector3 vectorPart, float scalarPart)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600120A")]
	[Cpp2IlInjected.Address(RVA = "0x15840B0", Offset = "0x15840B0", VA = "0x15840B0")]
	public static Quaternion Add(Quaternion quaternion1, Quaternion quaternion2)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x600120B")]
	[Cpp2IlInjected.Address(RVA = "0x15840F4", Offset = "0x15840F4", VA = "0x15840F4")]
	public static void Add(ref Quaternion quaternion1, ref Quaternion quaternion2, out Quaternion result)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600120C")]
	[Cpp2IlInjected.Address(RVA = "0x1584138", Offset = "0x1584138", VA = "0x1584138")]
	public static Quaternion Concatenate(Quaternion value1, Quaternion value2)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x600120D")]
	[Cpp2IlInjected.Address(RVA = "0x3A2900", Offset = "0x3A2900", VA = "0x3A2900")]
	public void Conjugate()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600120E")]
	[Cpp2IlInjected.Address(RVA = "0x15841D4", Offset = "0x15841D4", VA = "0x15841D4")]
	public static Quaternion Conjugate(Quaternion value)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x600120F")]
	[Cpp2IlInjected.Address(RVA = "0x15841EC", Offset = "0x15841EC", VA = "0x15841EC")]
	public static void Conjugate(ref Quaternion value, out Quaternion result)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001210")]
	[Cpp2IlInjected.Address(RVA = "0x158421C", Offset = "0x158421C", VA = "0x158421C")]
	public static void Concatenate(ref Quaternion value1, ref Quaternion value2, out Quaternion result)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001211")]
	[Cpp2IlInjected.Address(RVA = "0x15842F0", Offset = "0x15842F0", VA = "0x15842F0")]
	public static Quaternion CreateFromYawPitchRoll(float yaw, float pitch, float roll)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6001212")]
	[Cpp2IlInjected.Address(RVA = "0x157C8C8", Offset = "0x157C8C8", VA = "0x157C8C8")]
	public static void CreateFromYawPitchRoll(float yaw, float pitch, float roll, out Quaternion result)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001213")]
	[Cpp2IlInjected.Address(RVA = "0x1584664", Offset = "0x1584664", VA = "0x1584664")]
	public static Quaternion CreateFromAxisAngle(Vector3 axis, float angle)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6001214")]
	[Cpp2IlInjected.Address(RVA = "0x158474C", Offset = "0x158474C", VA = "0x158474C")]
	public static void CreateFromAxisAngle(ref Vector3 axis, float angle, out Quaternion result)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001215")]
	[Cpp2IlInjected.Address(RVA = "0x157D930", Offset = "0x157D930", VA = "0x157D930")]
	public static Quaternion CreateFromRotationMatrix(Matrix matrix)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6001216")]
	[Cpp2IlInjected.Address(RVA = "0x1584830", Offset = "0x1584830", VA = "0x1584830")]
	public static void CreateFromRotationMatrix(ref Matrix matrix, out Quaternion result)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001217")]
	[Cpp2IlInjected.Address(RVA = "0x1584B30", Offset = "0x1584B30", VA = "0x1584B30")]
	public static Quaternion Divide(Quaternion quaternion1, Quaternion quaternion2)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6001218")]
	[Cpp2IlInjected.Address(RVA = "0x1584BDC", Offset = "0x1584BDC", VA = "0x1584BDC")]
	public static void Divide(ref Quaternion quaternion1, ref Quaternion quaternion2, out Quaternion result)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001219")]
	[Cpp2IlInjected.Address(RVA = "0x1584CBC", Offset = "0x1584CBC", VA = "0x1584CBC")]
	public static float Dot(Quaternion quaternion1, Quaternion quaternion2)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600121A")]
	[Cpp2IlInjected.Address(RVA = "0x1584CF4", Offset = "0x1584CF4", VA = "0x1584CF4")]
	public static void Dot(ref Quaternion quaternion1, ref Quaternion quaternion2, out float result)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600121B")]
	[Cpp2IlInjected.Address(RVA = "0x3A2928", Offset = "0x3A2928", VA = "0x3A2928", Slot = "0")]
	public override bool Equals(object obj)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600121C")]
	[Cpp2IlInjected.Address(RVA = "0x3A2930", Offset = "0x3A2930", VA = "0x3A2930", Slot = "4")]
	public bool Equals(Quaternion other)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600121D")]
	[Cpp2IlInjected.Address(RVA = "0x3A2994", Offset = "0x3A2994", VA = "0x3A2994", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600121E")]
	[Cpp2IlInjected.Address(RVA = "0x1584F78", Offset = "0x1584F78", VA = "0x1584F78")]
	public static Quaternion Inverse(Quaternion quaternion)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x600121F")]
	[Cpp2IlInjected.Address(RVA = "0x1584FC4", Offset = "0x1584FC4", VA = "0x1584FC4")]
	public static void Inverse(ref Quaternion quaternion, out Quaternion result)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001220")]
	[Cpp2IlInjected.Address(RVA = "0x3A299C", Offset = "0x3A299C", VA = "0x3A299C")]
	public float Length()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6001221")]
	[Cpp2IlInjected.Address(RVA = "0x3A29A4", Offset = "0x3A29A4", VA = "0x3A29A4")]
	public float LengthSquared()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6001222")]
	[Cpp2IlInjected.Address(RVA = "0x1585100", Offset = "0x1585100", VA = "0x1585100")]
	public static Quaternion Lerp(Quaternion quaternion1, Quaternion quaternion2, float amount)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6001223")]
	[Cpp2IlInjected.Address(RVA = "0x1585284", Offset = "0x1585284", VA = "0x1585284")]
	public static void Lerp(ref Quaternion quaternion1, ref Quaternion quaternion2, float amount, out Quaternion result)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001224")]
	[Cpp2IlInjected.Address(RVA = "0x158543C", Offset = "0x158543C", VA = "0x158543C")]
	public static Quaternion Slerp(Quaternion quaternion1, Quaternion quaternion2, float amount)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6001225")]
	[Cpp2IlInjected.Address(RVA = "0x1585664", Offset = "0x1585664", VA = "0x1585664")]
	public static void Slerp(ref Quaternion quaternion1, ref Quaternion quaternion2, float amount, out Quaternion result)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001226")]
	[Cpp2IlInjected.Address(RVA = "0x1585888", Offset = "0x1585888", VA = "0x1585888")]
	public static Quaternion Subtract(Quaternion quaternion1, Quaternion quaternion2)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6001227")]
	[Cpp2IlInjected.Address(RVA = "0x15858CC", Offset = "0x15858CC", VA = "0x15858CC")]
	public static void Subtract(ref Quaternion quaternion1, ref Quaternion quaternion2, out Quaternion result)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001228")]
	[Cpp2IlInjected.Address(RVA = "0x1585910", Offset = "0x1585910", VA = "0x1585910")]
	public static Quaternion Multiply(Quaternion quaternion1, Quaternion quaternion2)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6001229")]
	[Cpp2IlInjected.Address(RVA = "0x1585990", Offset = "0x1585990", VA = "0x1585990")]
	public static Quaternion Multiply(Quaternion quaternion1, float scaleFactor)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x600122A")]
	[Cpp2IlInjected.Address(RVA = "0x15859C8", Offset = "0x15859C8", VA = "0x15859C8")]
	public static void Multiply(ref Quaternion quaternion1, float scaleFactor, out Quaternion result)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600122B")]
	[Cpp2IlInjected.Address(RVA = "0x1585A00", Offset = "0x1585A00", VA = "0x1585A00")]
	public static void Multiply(ref Quaternion quaternion1, ref Quaternion quaternion2, out Quaternion result)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600122C")]
	[Cpp2IlInjected.Address(RVA = "0x1585AA8", Offset = "0x1585AA8", VA = "0x1585AA8")]
	public static Quaternion Negate(Quaternion quaternion)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x600122D")]
	[Cpp2IlInjected.Address(RVA = "0x1585AD4", Offset = "0x1585AD4", VA = "0x1585AD4")]
	public static void Negate(ref Quaternion quaternion, out Quaternion result)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600122E")]
	[Cpp2IlInjected.Address(RVA = "0x3A29CC", Offset = "0x3A29CC", VA = "0x3A29CC")]
	public void Normalize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600122F")]
	[Cpp2IlInjected.Address(RVA = "0x1585BD0", Offset = "0x1585BD0", VA = "0x1585BD0")]
	public static Quaternion Normalize(Quaternion quaternion)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6001230")]
	[Cpp2IlInjected.Address(RVA = "0x1585CBC", Offset = "0x1585CBC", VA = "0x1585CBC")]
	public static void Normalize(ref Quaternion quaternion, out Quaternion result)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001231")]
	[Cpp2IlInjected.Address(RVA = "0x1585DAC", Offset = "0x1585DAC", VA = "0x1585DAC")]
	public static Quaternion operator +(Quaternion quaternion1, Quaternion quaternion2)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6001232")]
	[Cpp2IlInjected.Address(RVA = "0x1585DF0", Offset = "0x1585DF0", VA = "0x1585DF0")]
	public static Quaternion operator /(Quaternion quaternion1, Quaternion quaternion2)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6001233")]
	[Cpp2IlInjected.Address(RVA = "0x1584E5C", Offset = "0x1584E5C", VA = "0x1584E5C")]
	public static bool operator ==(Quaternion quaternion1, Quaternion quaternion2)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6001234")]
	[Cpp2IlInjected.Address(RVA = "0x1585E9C", Offset = "0x1585E9C", VA = "0x1585E9C")]
	public static bool operator !=(Quaternion quaternion1, Quaternion quaternion2)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6001235")]
	[Cpp2IlInjected.Address(RVA = "0x1585F08", Offset = "0x1585F08", VA = "0x1585F08")]
	public static Quaternion operator *(Quaternion quaternion1, Quaternion quaternion2)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6001236")]
	[Cpp2IlInjected.Address(RVA = "0x1585F88", Offset = "0x1585F88", VA = "0x1585F88")]
	public static Quaternion operator *(Quaternion quaternion1, float scaleFactor)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6001237")]
	[Cpp2IlInjected.Address(RVA = "0x1585FC0", Offset = "0x1585FC0", VA = "0x1585FC0")]
	public static Quaternion operator -(Quaternion quaternion1, Quaternion quaternion2)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6001238")]
	[Cpp2IlInjected.Address(RVA = "0x1586004", Offset = "0x1586004", VA = "0x1586004")]
	public static Quaternion operator -(Quaternion quaternion)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6001239")]
	[Cpp2IlInjected.Address(RVA = "0x3A29D4", Offset = "0x3A29D4", VA = "0x3A29D4", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
