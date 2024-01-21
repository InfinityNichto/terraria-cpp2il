using System;
using Cpp2IlInjected;
using UnityEngine;

namespace Microsoft.Xna.Framework;

[Serializable]
[Cpp2IlInjected.Token(Token = "0x2000273")]
public struct Vector3 : IEquatable<Vector3>
{
	[Cpp2IlInjected.Token(Token = "0x4001CA6")]
	private static Vector3 zero;

	[Cpp2IlInjected.Token(Token = "0x4001CA7")]
	private static Vector3 one;

	[Cpp2IlInjected.Token(Token = "0x4001CA8")]
	private static Vector3 unitX;

	[Cpp2IlInjected.Token(Token = "0x4001CA9")]
	private static Vector3 unitY;

	[Cpp2IlInjected.Token(Token = "0x4001CAA")]
	private static Vector3 unitZ;

	[Cpp2IlInjected.Token(Token = "0x4001CAB")]
	private static Vector3 up;

	[Cpp2IlInjected.Token(Token = "0x4001CAC")]
	private static Vector3 down;

	[Cpp2IlInjected.Token(Token = "0x4001CAD")]
	private static Vector3 right;

	[Cpp2IlInjected.Token(Token = "0x4001CAE")]
	private static Vector3 left;

	[Cpp2IlInjected.Token(Token = "0x4001CAF")]
	private static Vector3 forward;

	[Cpp2IlInjected.Token(Token = "0x4001CB0")]
	private static Vector3 backward;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4001CB1")]
	public float X;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4001CB2")]
	public float Y;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4001CB3")]
	public float Z;

	[Cpp2IlInjected.Token(Token = "0x170001C7")]
	public static Vector3 Zero
	{
		[Cpp2IlInjected.Token(Token = "0x60012A8")]
		[Cpp2IlInjected.Address(RVA = "0x10AD2E0", Offset = "0x10AD2E0", VA = "0x10AD2E0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001C8")]
	public static Vector3 One
	{
		[Cpp2IlInjected.Token(Token = "0x60012A9")]
		[Cpp2IlInjected.Address(RVA = "0x10AD368", Offset = "0x10AD368", VA = "0x10AD368")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001C9")]
	public static Vector3 UnitX
	{
		[Cpp2IlInjected.Token(Token = "0x60012AA")]
		[Cpp2IlInjected.Address(RVA = "0x10AD3F0", Offset = "0x10AD3F0", VA = "0x10AD3F0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001CA")]
	public static Vector3 UnitY
	{
		[Cpp2IlInjected.Token(Token = "0x60012AB")]
		[Cpp2IlInjected.Address(RVA = "0x10AD478", Offset = "0x10AD478", VA = "0x10AD478")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001CB")]
	public static Vector3 UnitZ
	{
		[Cpp2IlInjected.Token(Token = "0x60012AC")]
		[Cpp2IlInjected.Address(RVA = "0x10AD500", Offset = "0x10AD500", VA = "0x10AD500")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001CC")]
	public static Vector3 Up
	{
		[Cpp2IlInjected.Token(Token = "0x60012AD")]
		[Cpp2IlInjected.Address(RVA = "0x10AD588", Offset = "0x10AD588", VA = "0x10AD588")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001CD")]
	public static Vector3 Down
	{
		[Cpp2IlInjected.Token(Token = "0x60012AE")]
		[Cpp2IlInjected.Address(RVA = "0x10AD610", Offset = "0x10AD610", VA = "0x10AD610")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001CE")]
	public static Vector3 Right
	{
		[Cpp2IlInjected.Token(Token = "0x60012AF")]
		[Cpp2IlInjected.Address(RVA = "0x10AD698", Offset = "0x10AD698", VA = "0x10AD698")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001CF")]
	public static Vector3 Left
	{
		[Cpp2IlInjected.Token(Token = "0x60012B0")]
		[Cpp2IlInjected.Address(RVA = "0x10AD720", Offset = "0x10AD720", VA = "0x10AD720")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001D0")]
	public static Vector3 Forward
	{
		[Cpp2IlInjected.Token(Token = "0x60012B1")]
		[Cpp2IlInjected.Address(RVA = "0x10AD7A8", Offset = "0x10AD7A8", VA = "0x10AD7A8")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001D1")]
	public static Vector3 Backward
	{
		[Cpp2IlInjected.Token(Token = "0x60012B2")]
		[Cpp2IlInjected.Address(RVA = "0x10AD830", Offset = "0x10AD830", VA = "0x10AD830")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60012B3")]
	[Cpp2IlInjected.Address(RVA = "0x39BD84", Offset = "0x39BD84", VA = "0x39BD84")]
	public Vector3(float x, float y, float z)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60012B4")]
	[Cpp2IlInjected.Address(RVA = "0x39BD90", Offset = "0x39BD90", VA = "0x39BD90")]
	public Vector3(float value)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60012B5")]
	[Cpp2IlInjected.Address(RVA = "0x39BDA0", Offset = "0x39BDA0", VA = "0x39BDA0")]
	public Vector3(Vector2 value, float z)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60012B6")]
	[Cpp2IlInjected.Address(RVA = "0x10AD8D8", Offset = "0x10AD8D8", VA = "0x10AD8D8")]
	public static Vector3 Add(Vector3 value1, Vector3 value2)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60012B7")]
	[Cpp2IlInjected.Address(RVA = "0x10AD90C", Offset = "0x10AD90C", VA = "0x10AD90C")]
	public static void Add(ref Vector3 value1, ref Vector3 value2, out Vector3 result)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60012B8")]
	[Cpp2IlInjected.Address(RVA = "0x10AD940", Offset = "0x10AD940", VA = "0x10AD940")]
	public static Vector3 Barycentric(Vector3 value1, Vector3 value2, Vector3 value3, float amount1, float amount2)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60012B9")]
	[Cpp2IlInjected.Address(RVA = "0x10AD9DC", Offset = "0x10AD9DC", VA = "0x10AD9DC")]
	public static void Barycentric(ref Vector3 value1, ref Vector3 value2, ref Vector3 value3, float amount1, float amount2, out Vector3 result)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60012BA")]
	[Cpp2IlInjected.Address(RVA = "0x10ADA7C", Offset = "0x10ADA7C", VA = "0x10ADA7C")]
	public static Vector3 CatmullRom(Vector3 value1, Vector3 value2, Vector3 value3, Vector3 value4, float amount)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60012BB")]
	[Cpp2IlInjected.Address(RVA = "0x10ADB14", Offset = "0x10ADB14", VA = "0x10ADB14")]
	public static void CatmullRom(ref Vector3 value1, ref Vector3 value2, ref Vector3 value3, ref Vector3 value4, float amount, out Vector3 result)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60012BC")]
	[Cpp2IlInjected.Address(RVA = "0x10ADBB8", Offset = "0x10ADBB8", VA = "0x10ADBB8")]
	public static Vector3 Clamp(Vector3 value1, Vector3 min, Vector3 max)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60012BD")]
	[Cpp2IlInjected.Address(RVA = "0x10ADC24", Offset = "0x10ADC24", VA = "0x10ADC24")]
	public static void Clamp(ref Vector3 value1, ref Vector3 min, ref Vector3 max, out Vector3 result)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60012BE")]
	[Cpp2IlInjected.Address(RVA = "0x10ADC8C", Offset = "0x10ADC8C", VA = "0x10ADC8C")]
	public static Vector3 Cross(Vector3 vector1, Vector3 vector2)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60012BF")]
	[Cpp2IlInjected.Address(RVA = "0x10ADCCC", Offset = "0x10ADCCC", VA = "0x10ADCCC")]
	public static void Cross(ref Vector3 vector1, ref Vector3 vector2, out Vector3 result)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60012C0")]
	[Cpp2IlInjected.Address(RVA = "0x10ADD24", Offset = "0x10ADD24", VA = "0x10ADD24")]
	public static float Distance(Vector3 value1, Vector3 value2)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60012C1")]
	[Cpp2IlInjected.Address(RVA = "0x10ADE10", Offset = "0x10ADE10", VA = "0x10ADE10")]
	public static void Distance(ref Vector3 value1, ref Vector3 value2, out float result)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60012C2")]
	[Cpp2IlInjected.Address(RVA = "0x10ADEE0", Offset = "0x10ADEE0", VA = "0x10ADEE0")]
	public static float DistanceSquared(Vector3 value1, Vector3 value2)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60012C3")]
	[Cpp2IlInjected.Address(RVA = "0x10ADF18", Offset = "0x10ADF18", VA = "0x10ADF18")]
	public static void DistanceSquared(ref Vector3 value1, ref Vector3 value2, out float result)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60012C4")]
	[Cpp2IlInjected.Address(RVA = "0x10ADF50", Offset = "0x10ADF50", VA = "0x10ADF50")]
	public static Vector3 Divide(Vector3 value1, Vector3 value2)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60012C5")]
	[Cpp2IlInjected.Address(RVA = "0x10ADF84", Offset = "0x10ADF84", VA = "0x10ADF84")]
	public static Vector3 Divide(Vector3 value1, float value2)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60012C6")]
	[Cpp2IlInjected.Address(RVA = "0x10ADFB8", Offset = "0x10ADFB8", VA = "0x10ADFB8")]
	public static void Divide(ref Vector3 value1, float divisor, out Vector3 result)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60012C7")]
	[Cpp2IlInjected.Address(RVA = "0x10ADFEC", Offset = "0x10ADFEC", VA = "0x10ADFEC")]
	public static void Divide(ref Vector3 value1, ref Vector3 value2, out Vector3 result)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60012C8")]
	[Cpp2IlInjected.Address(RVA = "0x10AE020", Offset = "0x10AE020", VA = "0x10AE020")]
	public static float Dot(Vector3 vector1, Vector3 vector2)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60012C9")]
	[Cpp2IlInjected.Address(RVA = "0x10AE04C", Offset = "0x10AE04C", VA = "0x10AE04C")]
	public static void Dot(ref Vector3 vector1, ref Vector3 vector2, out float result)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60012CA")]
	[Cpp2IlInjected.Address(RVA = "0x39BDAC", Offset = "0x39BDAC", VA = "0x39BDAC", Slot = "0")]
	public override bool Equals(object obj)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60012CB")]
	[Cpp2IlInjected.Address(RVA = "0x39BDB4", Offset = "0x39BDB4", VA = "0x39BDB4", Slot = "4")]
	public bool Equals(Vector3 other)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60012CC")]
	[Cpp2IlInjected.Address(RVA = "0x39BDD0", Offset = "0x39BDD0", VA = "0x39BDD0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60012CD")]
	[Cpp2IlInjected.Address(RVA = "0x10AE2B0", Offset = "0x10AE2B0", VA = "0x10AE2B0")]
	public static Vector3 Hermite(Vector3 value1, Vector3 tangent1, Vector3 value2, Vector3 tangent2, float amount)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60012CE")]
	[Cpp2IlInjected.Address(RVA = "0x10AE348", Offset = "0x10AE348", VA = "0x10AE348")]
	public static void Hermite(ref Vector3 value1, ref Vector3 tangent1, ref Vector3 value2, ref Vector3 tangent2, float amount, out Vector3 result)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60012CF")]
	[Cpp2IlInjected.Address(RVA = "0x39BDF0", Offset = "0x39BDF0", VA = "0x39BDF0")]
	public float Length()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60012D0")]
	[Cpp2IlInjected.Address(RVA = "0x39BDF8", Offset = "0x39BDF8", VA = "0x39BDF8")]
	public float LengthSquared()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60012D1")]
	[Cpp2IlInjected.Address(RVA = "0x10AE4B4", Offset = "0x10AE4B4", VA = "0x10AE4B4")]
	public static Vector3 Lerp(Vector3 value1, Vector3 value2, float amount)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60012D2")]
	[Cpp2IlInjected.Address(RVA = "0x10AE520", Offset = "0x10AE520", VA = "0x10AE520")]
	public static void Lerp(ref Vector3 value1, ref Vector3 value2, float amount, out Vector3 result)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60012D3")]
	[Cpp2IlInjected.Address(RVA = "0x10AE584", Offset = "0x10AE584", VA = "0x10AE584")]
	public static Vector3 Max(Vector3 value1, Vector3 value2)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60012D4")]
	[Cpp2IlInjected.Address(RVA = "0x10AE5E4", Offset = "0x10AE5E4", VA = "0x10AE5E4")]
	public static void Max(ref Vector3 value1, ref Vector3 value2, out Vector3 result)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60012D5")]
	[Cpp2IlInjected.Address(RVA = "0x10AE640", Offset = "0x10AE640", VA = "0x10AE640")]
	public static Vector3 Min(Vector3 value1, Vector3 value2)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60012D6")]
	[Cpp2IlInjected.Address(RVA = "0x10AE6A0", Offset = "0x10AE6A0", VA = "0x10AE6A0")]
	public static void Min(ref Vector3 value1, ref Vector3 value2, out Vector3 result)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60012D7")]
	[Cpp2IlInjected.Address(RVA = "0x10AE6FC", Offset = "0x10AE6FC", VA = "0x10AE6FC")]
	public static Vector3 Multiply(Vector3 value1, Vector3 value2)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60012D8")]
	[Cpp2IlInjected.Address(RVA = "0x10AE730", Offset = "0x10AE730", VA = "0x10AE730")]
	public static Vector3 Multiply(Vector3 value1, float scaleFactor)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60012D9")]
	[Cpp2IlInjected.Address(RVA = "0x10AE75C", Offset = "0x10AE75C", VA = "0x10AE75C")]
	public static void Multiply(ref Vector3 value1, float scaleFactor, out Vector3 result)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60012DA")]
	[Cpp2IlInjected.Address(RVA = "0x10AE788", Offset = "0x10AE788", VA = "0x10AE788")]
	public static void Multiply(ref Vector3 value1, ref Vector3 value2, out Vector3 result)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60012DB")]
	[Cpp2IlInjected.Address(RVA = "0x10AE7BC", Offset = "0x10AE7BC", VA = "0x10AE7BC")]
	public static Vector3 Negate(Vector3 value)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60012DC")]
	[Cpp2IlInjected.Address(RVA = "0x10AE7D0", Offset = "0x10AE7D0", VA = "0x10AE7D0")]
	public static void Negate(ref Vector3 value, out Vector3 result)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60012DD")]
	[Cpp2IlInjected.Address(RVA = "0x39BE18", Offset = "0x39BE18", VA = "0x39BE18")]
	public void Normalize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60012DE")]
	[Cpp2IlInjected.Address(RVA = "0x10AE8D0", Offset = "0x10AE8D0", VA = "0x10AE8D0")]
	public static Vector3 Normalize(Vector3 value)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60012DF")]
	[Cpp2IlInjected.Address(RVA = "0x10AE9A8", Offset = "0x10AE9A8", VA = "0x10AE9A8")]
	public static void Normalize(ref Vector3 value, out Vector3 result)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60012E0")]
	[Cpp2IlInjected.Address(RVA = "0x10AEA84", Offset = "0x10AEA84", VA = "0x10AEA84")]
	public static Vector3 Reflect(Vector3 vector, Vector3 normal)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60012E1")]
	[Cpp2IlInjected.Address(RVA = "0x10AEB54", Offset = "0x10AEB54", VA = "0x10AEB54")]
	public static void Reflect(ref Vector3 vector, ref Vector3 normal, out Vector3 result)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60012E2")]
	[Cpp2IlInjected.Address(RVA = "0x10AEC3C", Offset = "0x10AEC3C", VA = "0x10AEC3C")]
	public static Vector3 SmoothStep(Vector3 value1, Vector3 value2, float amount)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60012E3")]
	[Cpp2IlInjected.Address(RVA = "0x10AECA8", Offset = "0x10AECA8", VA = "0x10AECA8")]
	public static void SmoothStep(ref Vector3 value1, ref Vector3 value2, float amount, out Vector3 result)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60012E4")]
	[Cpp2IlInjected.Address(RVA = "0x10AED0C", Offset = "0x10AED0C", VA = "0x10AED0C")]
	public static Vector3 Subtract(Vector3 value1, Vector3 value2)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60012E5")]
	[Cpp2IlInjected.Address(RVA = "0x10AED40", Offset = "0x10AED40", VA = "0x10AED40")]
	public static void Subtract(ref Vector3 value1, ref Vector3 value2, out Vector3 result)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60012E6")]
	[Cpp2IlInjected.Address(RVA = "0x39BE20", Offset = "0x39BE20", VA = "0x39BE20", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60012E7")]
	[Cpp2IlInjected.Address(RVA = "0x10AEE90", Offset = "0x10AEE90", VA = "0x10AEE90")]
	public static Vector3 Transform(Vector3 position, Matrix matrix)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60012E8")]
	[Cpp2IlInjected.Address(RVA = "0x10AEFE4", Offset = "0x10AEFE4", VA = "0x10AEFE4")]
	public static void Transform(ref Vector3 position, ref Matrix matrix, out Vector3 result)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60012E9")]
	[Cpp2IlInjected.Address(RVA = "0x39BE28", Offset = "0x39BE28", VA = "0x39BE28")]
	public UnityEngine.Vector3 UnityVec3()
	{
		return default(UnityEngine.Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60012EA")]
	[Cpp2IlInjected.Address(RVA = "0x10AF098", Offset = "0x10AF098", VA = "0x10AF098")]
	public static Vector3 Transform(Vector3 value, Quaternion rotation)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60012EB")]
	[Cpp2IlInjected.Address(RVA = "0x10AF110", Offset = "0x10AF110", VA = "0x10AF110")]
	public static void Transform(Vector3[] sourceArray, ref Matrix matrix, Vector3[] destinationArray)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60012EC")]
	[Cpp2IlInjected.Address(RVA = "0x10AF188", Offset = "0x10AF188", VA = "0x10AF188")]
	public static void Transform(Vector3[] sourceArray, ref Quaternion rotation, Vector3[] destinationArray)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60012ED")]
	[Cpp2IlInjected.Address(RVA = "0x10AF200", Offset = "0x10AF200", VA = "0x10AF200")]
	public static void Transform(Vector3[] sourceArray, int sourceIndex, ref Matrix matrix, Vector3[] destinationArray, int destinationIndex, int length)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60012EE")]
	[Cpp2IlInjected.Address(RVA = "0x10AF278", Offset = "0x10AF278", VA = "0x10AF278")]
	public static void Transform(Vector3[] sourceArray, int sourceIndex, ref Quaternion rotation, Vector3[] destinationArray, int destinationIndex, int length)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60012EF")]
	[Cpp2IlInjected.Address(RVA = "0x10AF2F0", Offset = "0x10AF2F0", VA = "0x10AF2F0")]
	public static void Transform(ref Vector3 value, ref Quaternion rotation, out Vector3 result)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60012F0")]
	[Cpp2IlInjected.Address(RVA = "0x10AF368", Offset = "0x10AF368", VA = "0x10AF368")]
	public static void TransformNormal(Vector3[] sourceArray, ref Matrix matrix, Vector3[] destinationArray)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60012F1")]
	[Cpp2IlInjected.Address(RVA = "0x10AF3E0", Offset = "0x10AF3E0", VA = "0x10AF3E0")]
	public static void TransformNormal(Vector3[] sourceArray, int sourceIndex, ref Matrix matrix, Vector3[] destinationArray, int destinationIndex, int length)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60012F2")]
	[Cpp2IlInjected.Address(RVA = "0x10AF458", Offset = "0x10AF458", VA = "0x10AF458")]
	public static Vector3 TransformNormal(Vector3 normal, Matrix matrix)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60012F3")]
	[Cpp2IlInjected.Address(RVA = "0x10AF588", Offset = "0x10AF588", VA = "0x10AF588")]
	public static void TransformNormal(ref Vector3 normal, ref Matrix matrix, out Vector3 result)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60012F4")]
	[Cpp2IlInjected.Address(RVA = "0x10AE17C", Offset = "0x10AE17C", VA = "0x10AE17C")]
	public static bool operator ==(Vector3 value1, Vector3 value2)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60012F5")]
	[Cpp2IlInjected.Address(RVA = "0x10AF5EC", Offset = "0x10AF5EC", VA = "0x10AF5EC")]
	public static bool operator !=(Vector3 value1, Vector3 value2)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60012F6")]
	[Cpp2IlInjected.Address(RVA = "0x10AF63C", Offset = "0x10AF63C", VA = "0x10AF63C")]
	public static Vector3 operator +(Vector3 value1, Vector3 value2)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60012F7")]
	[Cpp2IlInjected.Address(RVA = "0x10AF670", Offset = "0x10AF670", VA = "0x10AF670")]
	public static Vector3 operator -(Vector3 value)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60012F8")]
	[Cpp2IlInjected.Address(RVA = "0x10AF684", Offset = "0x10AF684", VA = "0x10AF684")]
	public static Vector3 operator -(Vector3 value1, Vector3 value2)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60012F9")]
	[Cpp2IlInjected.Address(RVA = "0x10AF6B8", Offset = "0x10AF6B8", VA = "0x10AF6B8")]
	public static Vector3 operator *(Vector3 value1, Vector3 value2)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60012FA")]
	[Cpp2IlInjected.Address(RVA = "0x10AF6EC", Offset = "0x10AF6EC", VA = "0x10AF6EC")]
	public static Vector3 operator *(Vector3 value, float scaleFactor)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60012FB")]
	[Cpp2IlInjected.Address(RVA = "0x10AF718", Offset = "0x10AF718", VA = "0x10AF718")]
	public static Vector3 operator *(float scaleFactor, Vector3 value)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60012FC")]
	[Cpp2IlInjected.Address(RVA = "0x10AF744", Offset = "0x10AF744", VA = "0x10AF744")]
	public static Vector3 operator /(Vector3 value1, Vector3 value2)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60012FD")]
	[Cpp2IlInjected.Address(RVA = "0x10AF778", Offset = "0x10AF778", VA = "0x10AF778")]
	public static Vector3 operator /(Vector3 value, float divider)
	{
		return default(Vector3);
	}
}
