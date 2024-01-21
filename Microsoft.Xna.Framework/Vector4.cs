using System;
using Cpp2IlInjected;

namespace Microsoft.Xna.Framework;

[Serializable]
[Cpp2IlInjected.Token(Token = "0x2000274")]
public struct Vector4 : IEquatable<Vector4>
{
	[Cpp2IlInjected.Token(Token = "0x4001CB4")]
	private static Vector4 zeroVector;

	[Cpp2IlInjected.Token(Token = "0x4001CB5")]
	private static Vector4 unitVector;

	[Cpp2IlInjected.Token(Token = "0x4001CB6")]
	private static Vector4 unitXVector;

	[Cpp2IlInjected.Token(Token = "0x4001CB7")]
	private static Vector4 unitYVector;

	[Cpp2IlInjected.Token(Token = "0x4001CB8")]
	private static Vector4 unitZVector;

	[Cpp2IlInjected.Token(Token = "0x4001CB9")]
	private static Vector4 unitWVector;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4001CBA")]
	public float X;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4001CBB")]
	public float Y;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4001CBC")]
	public float Z;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4001CBD")]
	public float W;

	[Cpp2IlInjected.Token(Token = "0x170001D2")]
	public static Vector4 Zero
	{
		[Cpp2IlInjected.Token(Token = "0x60012FF")]
		[Cpp2IlInjected.Address(RVA = "0x10AF8C0", Offset = "0x10AF8C0", VA = "0x10AF8C0")]
		get
		{
			return default(Vector4);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001D3")]
	public static Vector4 One
	{
		[Cpp2IlInjected.Token(Token = "0x6001300")]
		[Cpp2IlInjected.Address(RVA = "0x10AF940", Offset = "0x10AF940", VA = "0x10AF940")]
		get
		{
			return default(Vector4);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001D4")]
	public static Vector4 UnitX
	{
		[Cpp2IlInjected.Token(Token = "0x6001301")]
		[Cpp2IlInjected.Address(RVA = "0x10AF9C4", Offset = "0x10AF9C4", VA = "0x10AF9C4")]
		get
		{
			return default(Vector4);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001D5")]
	public static Vector4 UnitY
	{
		[Cpp2IlInjected.Token(Token = "0x6001302")]
		[Cpp2IlInjected.Address(RVA = "0x10AFA48", Offset = "0x10AFA48", VA = "0x10AFA48")]
		get
		{
			return default(Vector4);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001D6")]
	public static Vector4 UnitZ
	{
		[Cpp2IlInjected.Token(Token = "0x6001303")]
		[Cpp2IlInjected.Address(RVA = "0x10AFACC", Offset = "0x10AFACC", VA = "0x10AFACC")]
		get
		{
			return default(Vector4);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001D7")]
	public static Vector4 UnitW
	{
		[Cpp2IlInjected.Token(Token = "0x6001304")]
		[Cpp2IlInjected.Address(RVA = "0x10AFB50", Offset = "0x10AFB50", VA = "0x10AFB50")]
		get
		{
			return default(Vector4);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6001305")]
	[Cpp2IlInjected.Address(RVA = "0x39BE64", Offset = "0x39BE64", VA = "0x39BE64")]
	public Vector4(float x, float y, float z, float w)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001306")]
	[Cpp2IlInjected.Address(RVA = "0x39BE78", Offset = "0x39BE78", VA = "0x39BE78")]
	public Vector4(Vector2 value, float z, float w)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001307")]
	[Cpp2IlInjected.Address(RVA = "0x39BE8C", Offset = "0x39BE8C", VA = "0x39BE8C")]
	public Vector4(Vector3 value, float w)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001308")]
	[Cpp2IlInjected.Address(RVA = "0x39BEA0", Offset = "0x39BEA0", VA = "0x39BEA0")]
	public Vector4(float value)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001309")]
	[Cpp2IlInjected.Address(RVA = "0x10AFC10", Offset = "0x10AFC10", VA = "0x10AFC10")]
	public static Vector4 Add(Vector4 value1, Vector4 value2)
	{
		return default(Vector4);
	}

	[Cpp2IlInjected.Token(Token = "0x600130A")]
	[Cpp2IlInjected.Address(RVA = "0x10AFC54", Offset = "0x10AFC54", VA = "0x10AFC54")]
	public static void Add(ref Vector4 value1, ref Vector4 value2, out Vector4 result)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600130B")]
	[Cpp2IlInjected.Address(RVA = "0x10AFC98", Offset = "0x10AFC98", VA = "0x10AFC98")]
	public static Vector4 Barycentric(Vector4 value1, Vector4 value2, Vector4 value3, float amount1, float amount2)
	{
		return default(Vector4);
	}

	[Cpp2IlInjected.Token(Token = "0x600130C")]
	[Cpp2IlInjected.Address(RVA = "0x10AFD58", Offset = "0x10AFD58", VA = "0x10AFD58")]
	public static void Barycentric(ref Vector4 value1, ref Vector4 value2, ref Vector4 value3, float amount1, float amount2, out Vector4 result)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600130D")]
	[Cpp2IlInjected.Address(RVA = "0x10AFE1C", Offset = "0x10AFE1C", VA = "0x10AFE1C")]
	public static Vector4 CatmullRom(Vector4 value1, Vector4 value2, Vector4 value3, Vector4 value4, float amount)
	{
		return default(Vector4);
	}

	[Cpp2IlInjected.Token(Token = "0x600130E")]
	[Cpp2IlInjected.Address(RVA = "0x10AFED8", Offset = "0x10AFED8", VA = "0x10AFED8")]
	public static void CatmullRom(ref Vector4 value1, ref Vector4 value2, ref Vector4 value3, ref Vector4 value4, float amount, out Vector4 result)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600130F")]
	[Cpp2IlInjected.Address(RVA = "0x10AFFA0", Offset = "0x10AFFA0", VA = "0x10AFFA0")]
	public static Vector4 Clamp(Vector4 value1, Vector4 min, Vector4 max)
	{
		return default(Vector4);
	}

	[Cpp2IlInjected.Token(Token = "0x6001310")]
	[Cpp2IlInjected.Address(RVA = "0x10B0028", Offset = "0x10B0028", VA = "0x10B0028")]
	public static void Clamp(ref Vector4 value1, ref Vector4 min, ref Vector4 max, out Vector4 result)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001311")]
	[Cpp2IlInjected.Address(RVA = "0x10B00B0", Offset = "0x10B00B0", VA = "0x10B00B0")]
	public static float Distance(Vector4 value1, Vector4 value2)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6001312")]
	[Cpp2IlInjected.Address(RVA = "0x10B01CC", Offset = "0x10B01CC", VA = "0x10B01CC")]
	public static void Distance(ref Vector4 value1, ref Vector4 value2, out float result)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001313")]
	[Cpp2IlInjected.Address(RVA = "0x10B02AC", Offset = "0x10B02AC", VA = "0x10B02AC")]
	public static float DistanceSquared(Vector4 value1, Vector4 value2)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6001314")]
	[Cpp2IlInjected.Address(RVA = "0x10B02F4", Offset = "0x10B02F4", VA = "0x10B02F4")]
	public static void DistanceSquared(ref Vector4 value1, ref Vector4 value2, out float result)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001315")]
	[Cpp2IlInjected.Address(RVA = "0x10B033C", Offset = "0x10B033C", VA = "0x10B033C")]
	public static Vector4 Divide(Vector4 value1, Vector4 value2)
	{
		return default(Vector4);
	}

	[Cpp2IlInjected.Token(Token = "0x6001316")]
	[Cpp2IlInjected.Address(RVA = "0x10B0380", Offset = "0x10B0380", VA = "0x10B0380")]
	public static Vector4 Divide(Vector4 value1, float divider)
	{
		return default(Vector4);
	}

	[Cpp2IlInjected.Token(Token = "0x6001317")]
	[Cpp2IlInjected.Address(RVA = "0x10B03C0", Offset = "0x10B03C0", VA = "0x10B03C0")]
	public static void Divide(ref Vector4 value1, float divider, out Vector4 result)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001318")]
	[Cpp2IlInjected.Address(RVA = "0x10B0400", Offset = "0x10B0400", VA = "0x10B0400")]
	public static void Divide(ref Vector4 value1, ref Vector4 value2, out Vector4 result)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001319")]
	[Cpp2IlInjected.Address(RVA = "0x10B0444", Offset = "0x10B0444", VA = "0x10B0444")]
	public static float Dot(Vector4 vector1, Vector4 vector2)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600131A")]
	[Cpp2IlInjected.Address(RVA = "0x10B047C", Offset = "0x10B047C", VA = "0x10B047C")]
	public static void Dot(ref Vector4 vector1, ref Vector4 vector2, out float result)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600131B")]
	[Cpp2IlInjected.Address(RVA = "0x39BEB0", Offset = "0x39BEB0", VA = "0x39BEB0", Slot = "0")]
	public override bool Equals(object obj)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600131C")]
	[Cpp2IlInjected.Address(RVA = "0x39BEB8", Offset = "0x39BEB8", VA = "0x39BEB8", Slot = "4")]
	public bool Equals(Vector4 other)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600131D")]
	[Cpp2IlInjected.Address(RVA = "0x39BF1C", Offset = "0x39BF1C", VA = "0x39BF1C", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600131E")]
	[Cpp2IlInjected.Address(RVA = "0x10B06DC", Offset = "0x10B06DC", VA = "0x10B06DC")]
	public static Vector4 Hermite(Vector4 value1, Vector4 tangent1, Vector4 value2, Vector4 tangent2, float amount)
	{
		return default(Vector4);
	}

	[Cpp2IlInjected.Token(Token = "0x600131F")]
	[Cpp2IlInjected.Address(RVA = "0x10B0798", Offset = "0x10B0798", VA = "0x10B0798")]
	public static void Hermite(ref Vector4 value1, ref Vector4 tangent1, ref Vector4 value2, ref Vector4 tangent2, float amount, out Vector4 result)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001320")]
	[Cpp2IlInjected.Address(RVA = "0x39BF40", Offset = "0x39BF40", VA = "0x39BF40")]
	public float Length()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6001321")]
	[Cpp2IlInjected.Address(RVA = "0x39BF48", Offset = "0x39BF48", VA = "0x39BF48")]
	public float LengthSquared()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6001322")]
	[Cpp2IlInjected.Address(RVA = "0x10B0934", Offset = "0x10B0934", VA = "0x10B0934")]
	public static Vector4 Lerp(Vector4 value1, Vector4 value2, float amount)
	{
		return default(Vector4);
	}

	[Cpp2IlInjected.Token(Token = "0x6001323")]
	[Cpp2IlInjected.Address(RVA = "0x10B09C0", Offset = "0x10B09C0", VA = "0x10B09C0")]
	public static void Lerp(ref Vector4 value1, ref Vector4 value2, float amount, out Vector4 result)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001324")]
	[Cpp2IlInjected.Address(RVA = "0x10B0A44", Offset = "0x10B0A44", VA = "0x10B0A44")]
	public static Vector4 Max(Vector4 value1, Vector4 value2)
	{
		return default(Vector4);
	}

	[Cpp2IlInjected.Token(Token = "0x6001325")]
	[Cpp2IlInjected.Address(RVA = "0x10B0ABC", Offset = "0x10B0ABC", VA = "0x10B0ABC")]
	public static void Max(ref Vector4 value1, ref Vector4 value2, out Vector4 result)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001326")]
	[Cpp2IlInjected.Address(RVA = "0x10B0B2C", Offset = "0x10B0B2C", VA = "0x10B0B2C")]
	public static Vector4 Min(Vector4 value1, Vector4 value2)
	{
		return default(Vector4);
	}

	[Cpp2IlInjected.Token(Token = "0x6001327")]
	[Cpp2IlInjected.Address(RVA = "0x10B0BA4", Offset = "0x10B0BA4", VA = "0x10B0BA4")]
	public static void Min(ref Vector4 value1, ref Vector4 value2, out Vector4 result)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001328")]
	[Cpp2IlInjected.Address(RVA = "0x10B0C14", Offset = "0x10B0C14", VA = "0x10B0C14")]
	public static Vector4 Multiply(Vector4 value1, Vector4 value2)
	{
		return default(Vector4);
	}

	[Cpp2IlInjected.Token(Token = "0x6001329")]
	[Cpp2IlInjected.Address(RVA = "0x10B0C58", Offset = "0x10B0C58", VA = "0x10B0C58")]
	public static Vector4 Multiply(Vector4 value1, float scaleFactor)
	{
		return default(Vector4);
	}

	[Cpp2IlInjected.Token(Token = "0x600132A")]
	[Cpp2IlInjected.Address(RVA = "0x10B0C90", Offset = "0x10B0C90", VA = "0x10B0C90")]
	public static void Multiply(ref Vector4 value1, float scaleFactor, out Vector4 result)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600132B")]
	[Cpp2IlInjected.Address(RVA = "0x10B0CC8", Offset = "0x10B0CC8", VA = "0x10B0CC8")]
	public static void Multiply(ref Vector4 value1, ref Vector4 value2, out Vector4 result)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600132C")]
	[Cpp2IlInjected.Address(RVA = "0x10B0D0C", Offset = "0x10B0D0C", VA = "0x10B0D0C")]
	public static Vector4 Negate(Vector4 value)
	{
		return default(Vector4);
	}

	[Cpp2IlInjected.Token(Token = "0x600132D")]
	[Cpp2IlInjected.Address(RVA = "0x10B0D38", Offset = "0x10B0D38", VA = "0x10B0D38")]
	public static void Negate(ref Vector4 value, out Vector4 result)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600132E")]
	[Cpp2IlInjected.Address(RVA = "0x39BF70", Offset = "0x39BF70", VA = "0x39BF70")]
	public void Normalize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600132F")]
	[Cpp2IlInjected.Address(RVA = "0x10B0E34", Offset = "0x10B0E34", VA = "0x10B0E34")]
	public static Vector4 Normalize(Vector4 vector)
	{
		return default(Vector4);
	}

	[Cpp2IlInjected.Token(Token = "0x6001330")]
	[Cpp2IlInjected.Address(RVA = "0x10B0F20", Offset = "0x10B0F20", VA = "0x10B0F20")]
	public static void Normalize(ref Vector4 vector, out Vector4 result)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001331")]
	[Cpp2IlInjected.Address(RVA = "0x10B1010", Offset = "0x10B1010", VA = "0x10B1010")]
	public static Vector4 SmoothStep(Vector4 value1, Vector4 value2, float amount)
	{
		return default(Vector4);
	}

	[Cpp2IlInjected.Token(Token = "0x6001332")]
	[Cpp2IlInjected.Address(RVA = "0x10B109C", Offset = "0x10B109C", VA = "0x10B109C")]
	public static void SmoothStep(ref Vector4 value1, ref Vector4 value2, float amount, out Vector4 result)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001333")]
	[Cpp2IlInjected.Address(RVA = "0x10B1120", Offset = "0x10B1120", VA = "0x10B1120")]
	public static Vector4 Subtract(Vector4 value1, Vector4 value2)
	{
		return default(Vector4);
	}

	[Cpp2IlInjected.Token(Token = "0x6001334")]
	[Cpp2IlInjected.Address(RVA = "0x10B1164", Offset = "0x10B1164", VA = "0x10B1164")]
	public static void Subtract(ref Vector4 value1, ref Vector4 value2, out Vector4 result)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001335")]
	[Cpp2IlInjected.Address(RVA = "0x10B11A8", Offset = "0x10B11A8", VA = "0x10B11A8")]
	public static Vector4 Transform(Vector2 position, Matrix matrix)
	{
		return default(Vector4);
	}

	[Cpp2IlInjected.Token(Token = "0x6001336")]
	[Cpp2IlInjected.Address(RVA = "0x10B1318", Offset = "0x10B1318", VA = "0x10B1318")]
	public static Vector4 Transform(Vector2 value, Quaternion rotation)
	{
		return default(Vector4);
	}

	[Cpp2IlInjected.Token(Token = "0x6001337")]
	[Cpp2IlInjected.Address(RVA = "0x10B1390", Offset = "0x10B1390", VA = "0x10B1390")]
	public static Vector4 Transform(Vector3 value, Quaternion rotation)
	{
		return default(Vector4);
	}

	[Cpp2IlInjected.Token(Token = "0x6001338")]
	[Cpp2IlInjected.Address(RVA = "0x10B1408", Offset = "0x10B1408", VA = "0x10B1408")]
	public static Vector4 Transform(Vector4 value, Quaternion rotation)
	{
		return default(Vector4);
	}

	[Cpp2IlInjected.Token(Token = "0x6001339")]
	[Cpp2IlInjected.Address(RVA = "0x10B1480", Offset = "0x10B1480", VA = "0x10B1480")]
	public static void Transform(ref Vector2 value, ref Quaternion rotation, out Vector4 result)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600133A")]
	[Cpp2IlInjected.Address(RVA = "0x10B14F8", Offset = "0x10B14F8", VA = "0x10B14F8")]
	public static void Transform(ref Vector3 value, ref Quaternion rotation, out Vector4 result)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600133B")]
	[Cpp2IlInjected.Address(RVA = "0x10B1570", Offset = "0x10B1570", VA = "0x10B1570")]
	public static void Transform(ref Vector4 value, ref Quaternion rotation, out Vector4 result)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600133C")]
	[Cpp2IlInjected.Address(RVA = "0x10B15E8", Offset = "0x10B15E8", VA = "0x10B15E8")]
	public static void Transform(Vector4[] sourceArray, ref Quaternion rotation, Vector4[] destinationArray)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600133D")]
	[Cpp2IlInjected.Address(RVA = "0x10B1660", Offset = "0x10B1660", VA = "0x10B1660")]
	public static void Transform(Vector4[] sourceArray, ref Matrix matrix, Vector4[] destinationArray)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600133E")]
	[Cpp2IlInjected.Address(RVA = "0x10B16D8", Offset = "0x10B16D8", VA = "0x10B16D8")]
	public static void Transform(Vector4[] sourceArray, int sourceIndex, ref Matrix matrix, Vector4[] destinationArray, int destinationIndex, int length)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600133F")]
	[Cpp2IlInjected.Address(RVA = "0x10B1750", Offset = "0x10B1750", VA = "0x10B1750")]
	public static void Transform(Vector4[] sourceArray, int sourceIndex, ref Quaternion rotation, Vector4[] destinationArray, int destinationIndex, int length)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001340")]
	[Cpp2IlInjected.Address(RVA = "0x10B17C8", Offset = "0x10B17C8", VA = "0x10B17C8")]
	public static Vector4 Transform(Vector3 position, Matrix matrix)
	{
		return default(Vector4);
	}

	[Cpp2IlInjected.Token(Token = "0x6001341")]
	[Cpp2IlInjected.Address(RVA = "0x10B199C", Offset = "0x10B199C", VA = "0x10B199C")]
	public static Vector4 Transform(Vector4 vector, Matrix matrix)
	{
		return default(Vector4);
	}

	[Cpp2IlInjected.Token(Token = "0x6001342")]
	[Cpp2IlInjected.Address(RVA = "0x10B12E8", Offset = "0x10B12E8", VA = "0x10B12E8")]
	public static void Transform(ref Vector2 position, ref Matrix matrix, out Vector4 result)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001343")]
	[Cpp2IlInjected.Address(RVA = "0x10B1948", Offset = "0x10B1948", VA = "0x10B1948")]
	public static void Transform(ref Vector3 position, ref Matrix matrix, out Vector4 result)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001344")]
	[Cpp2IlInjected.Address(RVA = "0x10B1AB4", Offset = "0x10B1AB4", VA = "0x10B1AB4")]
	public static void Transform(ref Vector4 vector, ref Matrix matrix, out Vector4 result)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001345")]
	[Cpp2IlInjected.Address(RVA = "0x39BF78", Offset = "0x39BF78", VA = "0x39BF78", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6001346")]
	[Cpp2IlInjected.Address(RVA = "0x10B1C5C", Offset = "0x10B1C5C", VA = "0x10B1C5C")]
	public static Vector4 operator -(Vector4 value)
	{
		return default(Vector4);
	}

	[Cpp2IlInjected.Token(Token = "0x6001347")]
	[Cpp2IlInjected.Address(RVA = "0x10B05E4", Offset = "0x10B05E4", VA = "0x10B05E4")]
	public static bool operator ==(Vector4 value1, Vector4 value2)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6001348")]
	[Cpp2IlInjected.Address(RVA = "0x10B1C88", Offset = "0x10B1C88", VA = "0x10B1C88")]
	public static bool operator !=(Vector4 value1, Vector4 value2)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6001349")]
	[Cpp2IlInjected.Address(RVA = "0x10B1CF8", Offset = "0x10B1CF8", VA = "0x10B1CF8")]
	public static Vector4 operator +(Vector4 value1, Vector4 value2)
	{
		return default(Vector4);
	}

	[Cpp2IlInjected.Token(Token = "0x600134A")]
	[Cpp2IlInjected.Address(RVA = "0x10B1D3C", Offset = "0x10B1D3C", VA = "0x10B1D3C")]
	public static Vector4 operator -(Vector4 value1, Vector4 value2)
	{
		return default(Vector4);
	}

	[Cpp2IlInjected.Token(Token = "0x600134B")]
	[Cpp2IlInjected.Address(RVA = "0x10B1D80", Offset = "0x10B1D80", VA = "0x10B1D80")]
	public static Vector4 operator *(Vector4 value1, Vector4 value2)
	{
		return default(Vector4);
	}

	[Cpp2IlInjected.Token(Token = "0x600134C")]
	[Cpp2IlInjected.Address(RVA = "0x10B1DC4", Offset = "0x10B1DC4", VA = "0x10B1DC4")]
	public static Vector4 operator *(Vector4 value1, float scaleFactor)
	{
		return default(Vector4);
	}

	[Cpp2IlInjected.Token(Token = "0x600134D")]
	[Cpp2IlInjected.Address(RVA = "0x10B1DFC", Offset = "0x10B1DFC", VA = "0x10B1DFC")]
	public static Vector4 operator *(float scaleFactor, Vector4 value1)
	{
		return default(Vector4);
	}

	[Cpp2IlInjected.Token(Token = "0x600134E")]
	[Cpp2IlInjected.Address(RVA = "0x10B1E34", Offset = "0x10B1E34", VA = "0x10B1E34")]
	public static Vector4 operator /(Vector4 value1, Vector4 value2)
	{
		return default(Vector4);
	}

	[Cpp2IlInjected.Token(Token = "0x600134F")]
	[Cpp2IlInjected.Address(RVA = "0x10B1E78", Offset = "0x10B1E78", VA = "0x10B1E78")]
	public static Vector4 operator /(Vector4 value1, float divider)
	{
		return default(Vector4);
	}
}
