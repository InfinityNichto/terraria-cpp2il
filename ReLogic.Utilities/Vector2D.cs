using System;
using Cpp2IlInjected;

namespace ReLogic.Utilities;

[Serializable]
[Cpp2IlInjected.Token(Token = "0x2000717")]
[Cpp2IlInjected.Attribute(Name = "DebuggerDisplayAttribute", RVA = "0x385564", Offset = "0x385564")]
public struct Vector2D : IEquatable<Vector2D>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400715B")]
	public double X;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400715C")]
	public double Y;

	[Cpp2IlInjected.Token(Token = "0x400715D")]
	private static Vector2D zeroVector;

	[Cpp2IlInjected.Token(Token = "0x400715E")]
	private static Vector2D unitVector;

	[Cpp2IlInjected.Token(Token = "0x400715F")]
	private static Vector2D unitXVector;

	[Cpp2IlInjected.Token(Token = "0x4007160")]
	private static Vector2D unitYVector;

	[Cpp2IlInjected.Token(Token = "0x4007161")]
	public static readonly double DoubleEpsilon;

	[Cpp2IlInjected.Token(Token = "0x170007E8")]
	public static Vector2D Zero
	{
		[Cpp2IlInjected.Token(Token = "0x6004652")]
		[Cpp2IlInjected.Address(RVA = "0xF96EDC", Offset = "0xF96EDC", VA = "0xF96EDC")]
		get
		{
			return default(Vector2D);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170007E9")]
	public static Vector2D One
	{
		[Cpp2IlInjected.Token(Token = "0x6004653")]
		[Cpp2IlInjected.Address(RVA = "0xF96F5C", Offset = "0xF96F5C", VA = "0xF96F5C")]
		get
		{
			return default(Vector2D);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170007EA")]
	public static Vector2D UnitX
	{
		[Cpp2IlInjected.Token(Token = "0x6004654")]
		[Cpp2IlInjected.Address(RVA = "0xF96FE0", Offset = "0xF96FE0", VA = "0xF96FE0")]
		get
		{
			return default(Vector2D);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170007EB")]
	public static Vector2D UnitY
	{
		[Cpp2IlInjected.Token(Token = "0x6004655")]
		[Cpp2IlInjected.Address(RVA = "0xF97064", Offset = "0xF97064", VA = "0xF97064")]
		get
		{
			return default(Vector2D);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170007EC")]
	internal string DebugDisplayString
	{
		[Cpp2IlInjected.Token(Token = "0x6004656")]
		[Cpp2IlInjected.Address(RVA = "0x39A99C", Offset = "0x39A99C", VA = "0x39A99C")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6004657")]
	[Cpp2IlInjected.Address(RVA = "0x39A9A4", Offset = "0x39A9A4", VA = "0x39A9A4")]
	public Vector2D(double x, double y)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6004658")]
	[Cpp2IlInjected.Address(RVA = "0x39A9BC", Offset = "0x39A9BC", VA = "0x39A9BC")]
	public Vector2D(double value)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6004659")]
	[Cpp2IlInjected.Address(RVA = "0x39A9CC", Offset = "0x39A9CC", VA = "0x39A9CC", Slot = "0")]
	public override bool Equals(object obj)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600465A")]
	[Cpp2IlInjected.Address(RVA = "0x39A9D4", Offset = "0x39A9D4", VA = "0x39A9D4", Slot = "4")]
	public bool Equals(Vector2D other)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600465B")]
	[Cpp2IlInjected.Address(RVA = "0x39AA10", Offset = "0x39AA10", VA = "0x39AA10", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600465C")]
	[Cpp2IlInjected.Address(RVA = "0x39AA40", Offset = "0x39AA40", VA = "0x39AA40")]
	public double Length()
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x600465D")]
	[Cpp2IlInjected.Address(RVA = "0x39AA48", Offset = "0x39AA48", VA = "0x39AA48")]
	public double LengthSquared()
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x600465E")]
	[Cpp2IlInjected.Address(RVA = "0x39AA60", Offset = "0x39AA60", VA = "0x39AA60")]
	public void Normalize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600465F")]
	[Cpp2IlInjected.Address(RVA = "0x39AA68", Offset = "0x39AA68", VA = "0x39AA68", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6004660")]
	[Cpp2IlInjected.Address(RVA = "0xF975C4", Offset = "0xF975C4", VA = "0xF975C4")]
	public static Vector2D Add(Vector2D value1, Vector2D value2)
	{
		return default(Vector2D);
	}

	[Cpp2IlInjected.Token(Token = "0x6004661")]
	[Cpp2IlInjected.Address(RVA = "0xF97608", Offset = "0xF97608", VA = "0xF97608")]
	public static void Add(ref Vector2D value1, ref Vector2D value2, out Vector2D result)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6004662")]
	[Cpp2IlInjected.Address(RVA = "0xF9762C", Offset = "0xF9762C", VA = "0xF9762C")]
	public static Vector2D Barycentric(Vector2D value1, Vector2D value2, Vector2D value3, double amount1, double amount2)
	{
		return default(Vector2D);
	}

	[Cpp2IlInjected.Token(Token = "0x6004663")]
	[Cpp2IlInjected.Address(RVA = "0xF97778", Offset = "0xF97778", VA = "0xF97778")]
	public static void Barycentric(ref Vector2D value1, ref Vector2D value2, ref Vector2D value3, double amount1, double amount2, out Vector2D result)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6004664")]
	[Cpp2IlInjected.Address(RVA = "0xF97848", Offset = "0xF97848", VA = "0xF97848")]
	public static Vector2D CatmullRom(Vector2D value1, Vector2D value2, Vector2D value3, Vector2D value4, double amount)
	{
		return default(Vector2D);
	}

	[Cpp2IlInjected.Token(Token = "0x6004665")]
	[Cpp2IlInjected.Address(RVA = "0xF97A40", Offset = "0xF97A40", VA = "0xF97A40")]
	public static void CatmullRom(ref Vector2D value1, ref Vector2D value2, ref Vector2D value3, ref Vector2D value4, double amount, out Vector2D result)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6004666")]
	[Cpp2IlInjected.Address(RVA = "0xF97B74", Offset = "0xF97B74", VA = "0xF97B74")]
	public static Vector2D Clamp(Vector2D value1, Vector2D min, Vector2D max)
	{
		return default(Vector2D);
	}

	[Cpp2IlInjected.Token(Token = "0x6004667")]
	[Cpp2IlInjected.Address(RVA = "0xF97CC4", Offset = "0xF97CC4", VA = "0xF97CC4")]
	public static void Clamp(ref Vector2D value1, ref Vector2D min, ref Vector2D max, out Vector2D result)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6004668")]
	[Cpp2IlInjected.Address(RVA = "0xF97D98", Offset = "0xF97D98", VA = "0xF97D98")]
	public static double Distance(Vector2D value1, Vector2D value2)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6004669")]
	[Cpp2IlInjected.Address(RVA = "0xF97E98", Offset = "0xF97E98", VA = "0xF97E98")]
	public static void Distance(ref Vector2D value1, ref Vector2D value2, out double result)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600466A")]
	[Cpp2IlInjected.Address(RVA = "0xF97F50", Offset = "0xF97F50", VA = "0xF97F50")]
	public static double DistanceSquared(Vector2D value1, Vector2D value2)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x600466B")]
	[Cpp2IlInjected.Address(RVA = "0xF97F90", Offset = "0xF97F90", VA = "0xF97F90")]
	public static void DistanceSquared(ref Vector2D value1, ref Vector2D value2, out double result)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600466C")]
	[Cpp2IlInjected.Address(RVA = "0xF97FB0", Offset = "0xF97FB0", VA = "0xF97FB0")]
	public static Vector2D Divide(Vector2D value1, Vector2D value2)
	{
		return default(Vector2D);
	}

	[Cpp2IlInjected.Token(Token = "0x600466D")]
	[Cpp2IlInjected.Address(RVA = "0xF97FF4", Offset = "0xF97FF4", VA = "0xF97FF4")]
	public static void Divide(ref Vector2D value1, ref Vector2D value2, out Vector2D result)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600466E")]
	[Cpp2IlInjected.Address(RVA = "0xF98018", Offset = "0xF98018", VA = "0xF98018")]
	public static Vector2D Divide(Vector2D value1, double divider)
	{
		return default(Vector2D);
	}

	[Cpp2IlInjected.Token(Token = "0x600466F")]
	[Cpp2IlInjected.Address(RVA = "0xF98040", Offset = "0xF98040", VA = "0xF98040")]
	public static void Divide(ref Vector2D value1, double divider, out Vector2D result)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6004670")]
	[Cpp2IlInjected.Address(RVA = "0xF9806C", Offset = "0xF9806C", VA = "0xF9806C")]
	public static double Dot(Vector2D value1, Vector2D value2)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6004671")]
	[Cpp2IlInjected.Address(RVA = "0xF980A4", Offset = "0xF980A4", VA = "0xF980A4")]
	public static void Dot(ref Vector2D value1, ref Vector2D value2, out double result)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6004672")]
	[Cpp2IlInjected.Address(RVA = "0xF980BC", Offset = "0xF980BC", VA = "0xF980BC")]
	public static Vector2D Hermite(Vector2D value1, Vector2D tangent1, Vector2D value2, Vector2D tangent2, double amount)
	{
		return default(Vector2D);
	}

	[Cpp2IlInjected.Token(Token = "0x6004673")]
	[Cpp2IlInjected.Address(RVA = "0xF981E8", Offset = "0xF981E8", VA = "0xF981E8")]
	public static void Hermite(ref Vector2D value1, ref Vector2D tangent1, ref Vector2D value2, ref Vector2D tangent2, double amount, out Vector2D result)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6004674")]
	[Cpp2IlInjected.Address(RVA = "0xF98410", Offset = "0xF98410", VA = "0xF98410")]
	public static Vector2D Lerp(Vector2D value1, Vector2D value2, double amount)
	{
		return default(Vector2D);
	}

	[Cpp2IlInjected.Token(Token = "0x6004675")]
	[Cpp2IlInjected.Address(RVA = "0xF98508", Offset = "0xF98508", VA = "0xF98508")]
	public static void Lerp(ref Vector2D value1, ref Vector2D value2, double amount, out Vector2D result)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6004676")]
	[Cpp2IlInjected.Address(RVA = "0xF985BC", Offset = "0xF985BC", VA = "0xF985BC")]
	public static Vector2D Max(Vector2D value1, Vector2D value2)
	{
		return default(Vector2D);
	}

	[Cpp2IlInjected.Token(Token = "0x6004677")]
	[Cpp2IlInjected.Address(RVA = "0xF9860C", Offset = "0xF9860C", VA = "0xF9860C")]
	public static void Max(ref Vector2D value1, ref Vector2D value2, out Vector2D result)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6004678")]
	[Cpp2IlInjected.Address(RVA = "0xF98640", Offset = "0xF98640", VA = "0xF98640")]
	public static Vector2D Min(Vector2D value1, Vector2D value2)
	{
		return default(Vector2D);
	}

	[Cpp2IlInjected.Token(Token = "0x6004679")]
	[Cpp2IlInjected.Address(RVA = "0xF98690", Offset = "0xF98690", VA = "0xF98690")]
	public static void Min(ref Vector2D value1, ref Vector2D value2, out Vector2D result)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600467A")]
	[Cpp2IlInjected.Address(RVA = "0xF986C4", Offset = "0xF986C4", VA = "0xF986C4")]
	public static Vector2D Multiply(Vector2D value1, Vector2D value2)
	{
		return default(Vector2D);
	}

	[Cpp2IlInjected.Token(Token = "0x600467B")]
	[Cpp2IlInjected.Address(RVA = "0xF98708", Offset = "0xF98708", VA = "0xF98708")]
	public static Vector2D Multiply(Vector2D value1, double scaleFactor)
	{
		return default(Vector2D);
	}

	[Cpp2IlInjected.Token(Token = "0x600467C")]
	[Cpp2IlInjected.Address(RVA = "0xF9872C", Offset = "0xF9872C", VA = "0xF9872C")]
	public static void Multiply(ref Vector2D value1, double scaleFactor, out Vector2D result)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600467D")]
	[Cpp2IlInjected.Address(RVA = "0xF98750", Offset = "0xF98750", VA = "0xF98750")]
	public static void Multiply(ref Vector2D value1, ref Vector2D value2, out Vector2D result)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600467E")]
	[Cpp2IlInjected.Address(RVA = "0xF98774", Offset = "0xF98774", VA = "0xF98774")]
	public static Vector2D Negate(Vector2D value)
	{
		return default(Vector2D);
	}

	[Cpp2IlInjected.Token(Token = "0x600467F")]
	[Cpp2IlInjected.Address(RVA = "0xF98790", Offset = "0xF98790", VA = "0xF98790")]
	public static void Negate(ref Vector2D value, out Vector2D result)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6004680")]
	[Cpp2IlInjected.Address(RVA = "0xF987AC", Offset = "0xF987AC", VA = "0xF987AC")]
	public static Vector2D Normalize(Vector2D value)
	{
		return default(Vector2D);
	}

	[Cpp2IlInjected.Token(Token = "0x6004681")]
	[Cpp2IlInjected.Address(RVA = "0xF98874", Offset = "0xF98874", VA = "0xF98874")]
	public static void Normalize(ref Vector2D value, out Vector2D result)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6004682")]
	[Cpp2IlInjected.Address(RVA = "0xF98938", Offset = "0xF98938", VA = "0xF98938")]
	public static Vector2D Reflect(Vector2D vector, Vector2D normal)
	{
		return default(Vector2D);
	}

	[Cpp2IlInjected.Token(Token = "0x6004683")]
	[Cpp2IlInjected.Address(RVA = "0xF98988", Offset = "0xF98988", VA = "0xF98988")]
	public static void Reflect(ref Vector2D vector, ref Vector2D normal, out Vector2D result)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6004684")]
	[Cpp2IlInjected.Address(RVA = "0xF989B8", Offset = "0xF989B8", VA = "0xF989B8")]
	public static Vector2D SmoothStep(Vector2D value1, Vector2D value2, double amount)
	{
		return default(Vector2D);
	}

	[Cpp2IlInjected.Token(Token = "0x6004685")]
	[Cpp2IlInjected.Address(RVA = "0xF98B90", Offset = "0xF98B90", VA = "0xF98B90")]
	public static void SmoothStep(ref Vector2D value1, ref Vector2D value2, double amount, out Vector2D result)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6004686")]
	[Cpp2IlInjected.Address(RVA = "0xF98C5C", Offset = "0xF98C5C", VA = "0xF98C5C")]
	public static Vector2D Subtract(Vector2D value1, Vector2D value2)
	{
		return default(Vector2D);
	}

	[Cpp2IlInjected.Token(Token = "0x6004687")]
	[Cpp2IlInjected.Address(RVA = "0xF98CA0", Offset = "0xF98CA0", VA = "0xF98CA0")]
	public static void Subtract(ref Vector2D value1, ref Vector2D value2, out Vector2D result)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6004688")]
	[Cpp2IlInjected.Address(RVA = "0xF98CC4", Offset = "0xF98CC4", VA = "0xF98CC4")]
	public static Vector2D operator -(Vector2D value)
	{
		return default(Vector2D);
	}

	[Cpp2IlInjected.Token(Token = "0x6004689")]
	[Cpp2IlInjected.Address(RVA = "0xF98CE0", Offset = "0xF98CE0", VA = "0xF98CE0")]
	public static bool operator ==(Vector2D value1, Vector2D value2)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600468A")]
	[Cpp2IlInjected.Address(RVA = "0xF98D30", Offset = "0xF98D30", VA = "0xF98D30")]
	public static bool operator !=(Vector2D value1, Vector2D value2)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600468B")]
	[Cpp2IlInjected.Address(RVA = "0xF98DF0", Offset = "0xF98DF0", VA = "0xF98DF0")]
	public static Vector2D operator +(Vector2D value1, Vector2D value2)
	{
		return default(Vector2D);
	}

	[Cpp2IlInjected.Token(Token = "0x600468C")]
	[Cpp2IlInjected.Address(RVA = "0xF98E34", Offset = "0xF98E34", VA = "0xF98E34")]
	public static Vector2D operator -(Vector2D value1, Vector2D value2)
	{
		return default(Vector2D);
	}

	[Cpp2IlInjected.Token(Token = "0x600468D")]
	[Cpp2IlInjected.Address(RVA = "0xF98E78", Offset = "0xF98E78", VA = "0xF98E78")]
	public static Vector2D operator *(Vector2D value1, Vector2D value2)
	{
		return default(Vector2D);
	}

	[Cpp2IlInjected.Token(Token = "0x600468E")]
	[Cpp2IlInjected.Address(RVA = "0xF98EBC", Offset = "0xF98EBC", VA = "0xF98EBC")]
	public static Vector2D operator *(Vector2D value, double scaleFactor)
	{
		return default(Vector2D);
	}

	[Cpp2IlInjected.Token(Token = "0x600468F")]
	[Cpp2IlInjected.Address(RVA = "0xF98EE0", Offset = "0xF98EE0", VA = "0xF98EE0")]
	public static Vector2D operator *(double scaleFactor, Vector2D value)
	{
		return default(Vector2D);
	}

	[Cpp2IlInjected.Token(Token = "0x6004690")]
	[Cpp2IlInjected.Address(RVA = "0xF98F14", Offset = "0xF98F14", VA = "0xF98F14")]
	public static Vector2D operator /(Vector2D value1, Vector2D value2)
	{
		return default(Vector2D);
	}

	[Cpp2IlInjected.Token(Token = "0x6004691")]
	[Cpp2IlInjected.Address(RVA = "0xF98F58", Offset = "0xF98F58", VA = "0xF98F58")]
	public static Vector2D operator /(Vector2D value1, double divider)
	{
		return default(Vector2D);
	}

	[Cpp2IlInjected.Token(Token = "0x6004692")]
	[Cpp2IlInjected.Address(RVA = "0xF97C98", Offset = "0xF97C98", VA = "0xF97C98")]
	public static double Clamp(double value, double min, double max)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6004693")]
	[Cpp2IlInjected.Address(RVA = "0xF984EC", Offset = "0xF984EC", VA = "0xF984EC")]
	public static double Lerp(double value1, double value2, double amount)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6004694")]
	[Cpp2IlInjected.Address(RVA = "0xF98AB8", Offset = "0xF98AB8", VA = "0xF98AB8")]
	public static double SmoothStep(double value1, double value2, double amount)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6004695")]
	[Cpp2IlInjected.Address(RVA = "0xF982D0", Offset = "0xF982D0", VA = "0xF982D0")]
	public static double Hermite(double value1, double tangent1, double value2, double tangent2, double amount)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6004696")]
	[Cpp2IlInjected.Address(RVA = "0xF97748", Offset = "0xF97748", VA = "0xF97748")]
	public static double Barycentric(double value1, double value2, double value3, double amount1, double amount2)
	{
		return default(double);
	}

	[Cpp2IlInjected.Token(Token = "0x6004697")]
	[Cpp2IlInjected.Address(RVA = "0xF979D8", Offset = "0xF979D8", VA = "0xF979D8")]
	public static double CatmullRom(double value1, double value2, double value3, double value4, double amount)
	{
		return default(double);
	}
}
