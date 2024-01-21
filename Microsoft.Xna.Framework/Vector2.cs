using System;
using Cpp2IlInjected;

namespace Microsoft.Xna.Framework;

[Serializable]
[Cpp2IlInjected.Token(Token = "0x2000272")]
public struct Vector2 : IEquatable<Vector2>
{
	[Cpp2IlInjected.Token(Token = "0x4001CA0")]
	private static Vector2 zeroVector;

	[Cpp2IlInjected.Token(Token = "0x4001CA1")]
	private static Vector2 unitVector;

	[Cpp2IlInjected.Token(Token = "0x4001CA2")]
	private static Vector2 unitXVector;

	[Cpp2IlInjected.Token(Token = "0x4001CA3")]
	private static Vector2 unitYVector;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4001CA4")]
	public float X;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4001CA5")]
	public float Y;

	[Cpp2IlInjected.Token(Token = "0x170001C3")]
	public static Vector2 Zero
	{
		[Cpp2IlInjected.Token(Token = "0x600125C")]
		[Cpp2IlInjected.Address(RVA = "0x1587244", Offset = "0x1587244", VA = "0x1587244")]
		get
		{
			return default(Vector2);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001C4")]
	public static Vector2 One
	{
		[Cpp2IlInjected.Token(Token = "0x600125D")]
		[Cpp2IlInjected.Address(RVA = "0x15872CC", Offset = "0x15872CC", VA = "0x15872CC")]
		get
		{
			return default(Vector2);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001C5")]
	public static Vector2 UnitX
	{
		[Cpp2IlInjected.Token(Token = "0x600125E")]
		[Cpp2IlInjected.Address(RVA = "0x1587354", Offset = "0x1587354", VA = "0x1587354")]
		get
		{
			return default(Vector2);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001C6")]
	public static Vector2 UnitY
	{
		[Cpp2IlInjected.Token(Token = "0x600125F")]
		[Cpp2IlInjected.Address(RVA = "0x15873DC", Offset = "0x15873DC", VA = "0x15873DC")]
		get
		{
			return default(Vector2);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6001260")]
	[Cpp2IlInjected.Address(RVA = "0x3A2CB0", Offset = "0x3A2CB0", VA = "0x3A2CB0")]
	public Vector2(float x, float y)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001261")]
	[Cpp2IlInjected.Address(RVA = "0x3A2CBC", Offset = "0x3A2CBC", VA = "0x3A2CBC")]
	public Vector2(float value)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001262")]
	[Cpp2IlInjected.Address(RVA = "0x1587470", Offset = "0x1587470", VA = "0x1587470")]
	public static void Reflect(ref Vector2 vector, ref Vector2 normal, out Vector2 result)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001263")]
	[Cpp2IlInjected.Address(RVA = "0x158755C", Offset = "0x158755C", VA = "0x158755C")]
	public static Vector2 Reflect(Vector2 vector, Vector2 normal)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x6001264")]
	[Cpp2IlInjected.Address(RVA = "0x158760C", Offset = "0x158760C", VA = "0x158760C")]
	public static Vector2 Add(Vector2 value1, Vector2 value2)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x6001265")]
	[Cpp2IlInjected.Address(RVA = "0x1587630", Offset = "0x1587630", VA = "0x1587630")]
	public static void Add(ref Vector2 value1, ref Vector2 value2, out Vector2 result)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001266")]
	[Cpp2IlInjected.Address(RVA = "0x1587654", Offset = "0x1587654", VA = "0x1587654")]
	public static Vector2 Barycentric(Vector2 value1, Vector2 value2, Vector2 value3, float amount1, float amount2)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x6001267")]
	[Cpp2IlInjected.Address(RVA = "0x15876A0", Offset = "0x15876A0", VA = "0x15876A0")]
	public static void Barycentric(ref Vector2 value1, ref Vector2 value2, ref Vector2 value3, float amount1, float amount2, out Vector2 result)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001268")]
	[Cpp2IlInjected.Address(RVA = "0x15876F0", Offset = "0x15876F0", VA = "0x15876F0")]
	public static Vector2 CatmullRom(Vector2 value1, Vector2 value2, Vector2 value3, Vector2 value4, float amount)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x6001269")]
	[Cpp2IlInjected.Address(RVA = "0x1587758", Offset = "0x1587758", VA = "0x1587758")]
	public static void CatmullRom(ref Vector2 value1, ref Vector2 value2, ref Vector2 value3, ref Vector2 value4, float amount, out Vector2 result)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600126A")]
	[Cpp2IlInjected.Address(RVA = "0x15877C8", Offset = "0x15877C8", VA = "0x15877C8")]
	public static Vector2 Clamp(Vector2 value1, Vector2 min, Vector2 max)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x600126B")]
	[Cpp2IlInjected.Address(RVA = "0x1587824", Offset = "0x1587824", VA = "0x1587824")]
	public static void Clamp(ref Vector2 value1, ref Vector2 min, ref Vector2 max, out Vector2 result)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600126C")]
	[Cpp2IlInjected.Address(RVA = "0x1587880", Offset = "0x1587880", VA = "0x1587880")]
	public static float Distance(Vector2 value1, Vector2 value2)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600126D")]
	[Cpp2IlInjected.Address(RVA = "0x1587948", Offset = "0x1587948", VA = "0x1587948")]
	public static void Distance(ref Vector2 value1, ref Vector2 value2, out float result)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600126E")]
	[Cpp2IlInjected.Address(RVA = "0x1587A08", Offset = "0x1587A08", VA = "0x1587A08")]
	public static float DistanceSquared(Vector2 value1, Vector2 value2)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600126F")]
	[Cpp2IlInjected.Address(RVA = "0x1587A30", Offset = "0x1587A30", VA = "0x1587A30")]
	public static void DistanceSquared(ref Vector2 value1, ref Vector2 value2, out float result)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001270")]
	[Cpp2IlInjected.Address(RVA = "0x1587A58", Offset = "0x1587A58", VA = "0x1587A58")]
	public static Vector2 Divide(Vector2 value1, Vector2 value2)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x6001271")]
	[Cpp2IlInjected.Address(RVA = "0x1587A7C", Offset = "0x1587A7C", VA = "0x1587A7C")]
	public static void Divide(ref Vector2 value1, ref Vector2 value2, out Vector2 result)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001272")]
	[Cpp2IlInjected.Address(RVA = "0x1587AA0", Offset = "0x1587AA0", VA = "0x1587AA0")]
	public static Vector2 Divide(Vector2 value1, float divider)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x6001273")]
	[Cpp2IlInjected.Address(RVA = "0x1587AC8", Offset = "0x1587AC8", VA = "0x1587AC8")]
	public static void Divide(ref Vector2 value1, float divider, out Vector2 result)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001274")]
	[Cpp2IlInjected.Address(RVA = "0x158753C", Offset = "0x158753C", VA = "0x158753C")]
	public static float Dot(Vector2 value1, Vector2 value2)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6001275")]
	[Cpp2IlInjected.Address(RVA = "0x1587AF0", Offset = "0x1587AF0", VA = "0x1587AF0")]
	public static void Dot(ref Vector2 value1, ref Vector2 value2, out float result)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001276")]
	[Cpp2IlInjected.Address(RVA = "0x3A2CC8", Offset = "0x3A2CC8", VA = "0x3A2CC8", Slot = "0")]
	public override bool Equals(object obj)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6001277")]
	[Cpp2IlInjected.Address(RVA = "0x3A2CD0", Offset = "0x3A2CD0", VA = "0x3A2CD0", Slot = "4")]
	public bool Equals(Vector2 other)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6001278")]
	[Cpp2IlInjected.Address(RVA = "0x3A2CD8", Offset = "0x3A2CD8", VA = "0x3A2CD8", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6001279")]
	[Cpp2IlInjected.Address(RVA = "0x1587D04", Offset = "0x1587D04", VA = "0x1587D04")]
	public static Vector2 Hermite(Vector2 value1, Vector2 tangent1, Vector2 value2, Vector2 tangent2, float amount)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x600127A")]
	[Cpp2IlInjected.Address(RVA = "0x1587D6C", Offset = "0x1587D6C", VA = "0x1587D6C")]
	public static void Hermite(ref Vector2 value1, ref Vector2 tangent1, ref Vector2 value2, ref Vector2 tangent2, float amount, out Vector2 result)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600127B")]
	[Cpp2IlInjected.Address(RVA = "0x3A2CF0", Offset = "0x3A2CF0", VA = "0x3A2CF0")]
	public float Length()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600127C")]
	[Cpp2IlInjected.Address(RVA = "0x3A2CF8", Offset = "0x3A2CF8", VA = "0x3A2CF8")]
	public float LengthSquared()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600127D")]
	[Cpp2IlInjected.Address(RVA = "0x1587E9C", Offset = "0x1587E9C", VA = "0x1587E9C")]
	public static Vector2 Lerp(Vector2 value1, Vector2 value2, float amount)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x600127E")]
	[Cpp2IlInjected.Address(RVA = "0x1587ECC", Offset = "0x1587ECC", VA = "0x1587ECC")]
	public static void Lerp(ref Vector2 value1, ref Vector2 value2, float amount, out Vector2 result)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600127F")]
	[Cpp2IlInjected.Address(RVA = "0x1587EFC", Offset = "0x1587EFC", VA = "0x1587EFC")]
	public static Vector2 Max(Vector2 value1, Vector2 value2)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x6001280")]
	[Cpp2IlInjected.Address(RVA = "0x1587F34", Offset = "0x1587F34", VA = "0x1587F34")]
	public static void Max(ref Vector2 value1, ref Vector2 value2, out Vector2 result)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001281")]
	[Cpp2IlInjected.Address(RVA = "0x1587F70", Offset = "0x1587F70", VA = "0x1587F70")]
	public static Vector2 Min(Vector2 value1, Vector2 value2)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x6001282")]
	[Cpp2IlInjected.Address(RVA = "0x1587FA8", Offset = "0x1587FA8", VA = "0x1587FA8")]
	public static void Min(ref Vector2 value1, ref Vector2 value2, out Vector2 result)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001283")]
	[Cpp2IlInjected.Address(RVA = "0x1587FE4", Offset = "0x1587FE4", VA = "0x1587FE4")]
	public static Vector2 Multiply(Vector2 value1, Vector2 value2)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x6001284")]
	[Cpp2IlInjected.Address(RVA = "0x1588008", Offset = "0x1588008", VA = "0x1588008")]
	public static Vector2 Multiply(Vector2 value1, float scaleFactor)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x6001285")]
	[Cpp2IlInjected.Address(RVA = "0x1588028", Offset = "0x1588028", VA = "0x1588028")]
	public static void Multiply(ref Vector2 value1, float scaleFactor, out Vector2 result)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001286")]
	[Cpp2IlInjected.Address(RVA = "0x1588048", Offset = "0x1588048", VA = "0x1588048")]
	public static void Multiply(ref Vector2 value1, ref Vector2 value2, out Vector2 result)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001287")]
	[Cpp2IlInjected.Address(RVA = "0x158806C", Offset = "0x158806C", VA = "0x158806C")]
	public static Vector2 Negate(Vector2 value)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x6001288")]
	[Cpp2IlInjected.Address(RVA = "0x158807C", Offset = "0x158807C", VA = "0x158807C")]
	public static void Negate(ref Vector2 value, out Vector2 result)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001289")]
	[Cpp2IlInjected.Address(RVA = "0x3A2D10", Offset = "0x3A2D10", VA = "0x3A2D10")]
	public void Normalize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600128A")]
	[Cpp2IlInjected.Address(RVA = "0x158815C", Offset = "0x158815C", VA = "0x158815C")]
	public static Vector2 Normalize(Vector2 value)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x600128B")]
	[Cpp2IlInjected.Address(RVA = "0x1588220", Offset = "0x1588220", VA = "0x1588220")]
	public static void Normalize(ref Vector2 value, out Vector2 result)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600128C")]
	[Cpp2IlInjected.Address(RVA = "0x15882E8", Offset = "0x15882E8", VA = "0x15882E8")]
	public static Vector2 SmoothStep(Vector2 value1, Vector2 value2, float amount)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x600128D")]
	[Cpp2IlInjected.Address(RVA = "0x1588368", Offset = "0x1588368", VA = "0x1588368")]
	public static void SmoothStep(ref Vector2 value1, ref Vector2 value2, float amount, out Vector2 result)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600128E")]
	[Cpp2IlInjected.Address(RVA = "0x15883EC", Offset = "0x15883EC", VA = "0x15883EC")]
	public static Vector2 Subtract(Vector2 value1, Vector2 value2)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x600128F")]
	[Cpp2IlInjected.Address(RVA = "0x1588410", Offset = "0x1588410", VA = "0x1588410")]
	public static void Subtract(ref Vector2 value1, ref Vector2 value2, out Vector2 result)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001290")]
	[Cpp2IlInjected.Address(RVA = "0x1588434", Offset = "0x1588434", VA = "0x1588434")]
	public static Vector2 Transform(Vector2 position, Matrix matrix)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x6001291")]
	[Cpp2IlInjected.Address(RVA = "0x1588514", Offset = "0x1588514", VA = "0x1588514")]
	public static void Transform(ref Vector2 position, ref Matrix matrix, out Vector2 result)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001292")]
	[Cpp2IlInjected.Address(RVA = "0x1588558", Offset = "0x1588558", VA = "0x1588558")]
	public static Vector2 Transform(Vector2 value, Quaternion rotation)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x6001293")]
	[Cpp2IlInjected.Address(RVA = "0x15885D0", Offset = "0x15885D0", VA = "0x15885D0")]
	public static void Transform(ref Vector2 value, ref Quaternion rotation, out Vector2 result)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001294")]
	[Cpp2IlInjected.Address(RVA = "0x1588648", Offset = "0x1588648", VA = "0x1588648")]
	public static void Transform(Vector2[] sourceArray, ref Matrix matrix, Vector2[] destinationArray)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001295")]
	[Cpp2IlInjected.Address(RVA = "0x15886C0", Offset = "0x15886C0", VA = "0x15886C0")]
	public static void Transform(Vector2[] sourceArray, ref Quaternion rotation, Vector2[] destinationArray)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001296")]
	[Cpp2IlInjected.Address(RVA = "0x1588738", Offset = "0x1588738", VA = "0x1588738")]
	public static void Transform(Vector2[] sourceArray, int sourceIndex, ref Matrix matrix, Vector2[] destinationArray, int destinationIndex, int length)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001297")]
	[Cpp2IlInjected.Address(RVA = "0x15887B0", Offset = "0x15887B0", VA = "0x15887B0")]
	public static void Transform(Vector2[] sourceArray, int sourceIndex, ref Quaternion rotation, Vector2[] destinationArray, int destinationIndex, int length)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001298")]
	[Cpp2IlInjected.Address(RVA = "0x1588828", Offset = "0x1588828", VA = "0x1588828")]
	public static Vector2 TransformNormal(Vector2 normal, Matrix matrix)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x6001299")]
	[Cpp2IlInjected.Address(RVA = "0x15888E8", Offset = "0x15888E8", VA = "0x15888E8")]
	public static void TransformNormal(ref Vector2 normal, ref Matrix matrix, out Vector2 result)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600129A")]
	[Cpp2IlInjected.Address(RVA = "0x158891C", Offset = "0x158891C", VA = "0x158891C")]
	public static void TransformNormal(Vector2[] sourceArray, ref Matrix matrix, Vector2[] destinationArray)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600129B")]
	[Cpp2IlInjected.Address(RVA = "0x1588994", Offset = "0x1588994", VA = "0x1588994")]
	public static void TransformNormal(Vector2[] sourceArray, int sourceIndex, ref Matrix matrix, Vector2[] destinationArray, int destinationIndex, int length)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600129C")]
	[Cpp2IlInjected.Address(RVA = "0x3A2D18", Offset = "0x3A2D18", VA = "0x3A2D18", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600129D")]
	[Cpp2IlInjected.Address(RVA = "0x1588AFC", Offset = "0x1588AFC", VA = "0x1588AFC")]
	public static Vector2 operator -(Vector2 value)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x600129E")]
	[Cpp2IlInjected.Address(RVA = "0x1587C04", Offset = "0x1587C04", VA = "0x1587C04")]
	public static bool operator ==(Vector2 value1, Vector2 value2)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600129F")]
	[Cpp2IlInjected.Address(RVA = "0x1588B0C", Offset = "0x1588B0C", VA = "0x1588B0C")]
	public static bool operator !=(Vector2 value1, Vector2 value2)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60012A0")]
	[Cpp2IlInjected.Address(RVA = "0x1588B40", Offset = "0x1588B40", VA = "0x1588B40")]
	public static Vector2 operator +(Vector2 value1, Vector2 value2)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x60012A1")]
	[Cpp2IlInjected.Address(RVA = "0x1588B64", Offset = "0x1588B64", VA = "0x1588B64")]
	public static Vector2 operator -(Vector2 value1, Vector2 value2)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x60012A2")]
	[Cpp2IlInjected.Address(RVA = "0x1588B88", Offset = "0x1588B88", VA = "0x1588B88")]
	public static Vector2 operator *(Vector2 value1, Vector2 value2)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x60012A3")]
	[Cpp2IlInjected.Address(RVA = "0x1588BAC", Offset = "0x1588BAC", VA = "0x1588BAC")]
	public static Vector2 operator *(Vector2 value, float scaleFactor)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x60012A4")]
	[Cpp2IlInjected.Address(RVA = "0x1588BCC", Offset = "0x1588BCC", VA = "0x1588BCC")]
	public static Vector2 operator *(float scaleFactor, Vector2 value)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x60012A5")]
	[Cpp2IlInjected.Address(RVA = "0x1588BEC", Offset = "0x1588BEC", VA = "0x1588BEC")]
	public static Vector2 operator /(Vector2 value1, Vector2 value2)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x60012A6")]
	[Cpp2IlInjected.Address(RVA = "0x1588C10", Offset = "0x1588C10", VA = "0x1588C10")]
	public static Vector2 operator /(Vector2 value1, float divider)
	{
		return default(Vector2);
	}
}
