using System;
using System.Text;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace Microsoft.Xna.Framework
{
	[global::Cpp2ILInjected.Token(Token = "0x200032D")]
	[Serializable]
	public struct Quaternion : IEquatable<Quaternion>
	{
		[global::Cpp2ILInjected.Token(Token = "0x600132C")]
		[global::Cpp2ILInjected.Address(RVA = "0xA8D72C", Offset = "0xA8D72C", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public Quaternion(float x, float y, float z, float w)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600132D")]
		[global::Cpp2ILInjected.Address(RVA = "0xA8D738", Offset = "0xA8D738", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public Quaternion(Vector3 vectorPart, float scalarPart)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x170001E0")]
		public static Quaternion Identity
		{
			[global::Cpp2ILInjected.Token(Token = "0x600132E")]
			[global::Cpp2ILInjected.Address(RVA = "0xA8D744", Offset = "0xA8D744", Length = "0x5C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x600132F")]
		[global::Cpp2ILInjected.Address(RVA = "0xA8D7A0", Offset = "0xA8D7A0", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public static Quaternion Add(Quaternion quaternion1, Quaternion quaternion2)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001330")]
		[global::Cpp2ILInjected.Address(RVA = "0xA8D7B4", Offset = "0xA8D7B4", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public static void Add(ref Quaternion quaternion1, ref Quaternion quaternion2, out Quaternion result)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001331")]
		[global::Cpp2ILInjected.Address(RVA = "0xA8D7C8", Offset = "0xA8D7C8", Length = "0x74")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public static Quaternion Concatenate(Quaternion value1, Quaternion value2)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001332")]
		[global::Cpp2ILInjected.Address(RVA = "0xA8D83C", Offset = "0xA8D83C", Length = "0x1C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public void Conjugate()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001333")]
		[global::Cpp2ILInjected.Address(RVA = "0xA8D858", Offset = "0xA8D858", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public static Quaternion Conjugate(Quaternion value)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001334")]
		[global::Cpp2ILInjected.Address(RVA = "0xA8D868", Offset = "0xA8D868", Length = "0x24")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public static void Conjugate(ref Quaternion value, out Quaternion result)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001335")]
		[global::Cpp2ILInjected.Address(RVA = "0xA8D88C", Offset = "0xA8D88C", Length = "0xAC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public static void Concatenate(ref Quaternion value1, ref Quaternion value2, out Quaternion result)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001336")]
		[global::Cpp2ILInjected.Address(RVA = "0xA8D938", Offset = "0xA8D938", Length = "0x120")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public static Quaternion CreateFromYawPitchRoll(float yaw, float pitch, float roll)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001337")]
		[global::Cpp2ILInjected.Address(RVA = "0xA8DA58", Offset = "0xA8DA58", Length = "0x128")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Matrix), Member = "CreateFromYawPitchRoll", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(Matrix))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Matrix), Member = "CreateFromYawPitchRoll", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(ref Matrix)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public static void CreateFromYawPitchRoll(float yaw, float pitch, float roll, out Quaternion result)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001338")]
		[global::Cpp2ILInjected.Address(RVA = "0xA8DB80", Offset = "0xA8DB80", Length = "0xA8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public static Quaternion CreateFromAxisAngle(Vector3 axis, float angle)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001339")]
		[global::Cpp2ILInjected.Address(RVA = "0xA8DC28", Offset = "0xA8DC28", Length = "0xAC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public static void CreateFromAxisAngle(ref Vector3 axis, float angle, out Quaternion result)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600133A")]
		[global::Cpp2ILInjected.Address(RVA = "0xA8DCD4", Offset = "0xA8DCD4", Length = "0x1DC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Matrix), Member = "Decompose", MemberParameters = new object[]
		{
			typeof(ref Vector3),
			typeof(ref Quaternion),
			typeof(ref Vector3)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public static Quaternion CreateFromRotationMatrix(Matrix matrix)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600133B")]
		[global::Cpp2ILInjected.Address(RVA = "0xA8DEB0", Offset = "0xA8DEB0", Length = "0x220")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public static void CreateFromRotationMatrix(ref Matrix matrix, out Quaternion result)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600133C")]
		[global::Cpp2ILInjected.Address(RVA = "0xA8E0D0", Offset = "0xA8E0D0", Length = "0xB0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public static Quaternion Divide(Quaternion quaternion1, Quaternion quaternion2)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600133D")]
		[global::Cpp2ILInjected.Address(RVA = "0xA8E180", Offset = "0xA8E180", Length = "0xDC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public static void Divide(ref Quaternion quaternion1, ref Quaternion quaternion2, out Quaternion result)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600133E")]
		[global::Cpp2ILInjected.Address(RVA = "0xA8E25C", Offset = "0xA8E25C", Length = "0x20")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public static float Dot(Quaternion quaternion1, Quaternion quaternion2)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600133F")]
		[global::Cpp2ILInjected.Address(RVA = "0xA8E27C", Offset = "0xA8E27C", Length = "0x34")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public static void Dot(ref Quaternion quaternion1, ref Quaternion quaternion2, out float result)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001340")]
		[global::Cpp2ILInjected.Address(RVA = "0xA8E2B0", Offset = "0xA8E2B0", Length = "0xE8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public override bool Equals(object obj)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001341")]
		[global::Cpp2ILInjected.Address(RVA = "0xA8E3C8", Offset = "0xA8E3C8", Length = "0x3C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public bool Equals(Quaternion other)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001342")]
		[global::Cpp2ILInjected.Address(RVA = "0xA8E404", Offset = "0xA8E404", Length = "0x64")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(float), Member = "GetHashCode", ReturnType = typeof(int))]
		public override int GetHashCode()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001343")]
		[global::Cpp2ILInjected.Address(RVA = "0xA8E468", Offset = "0xA8E468", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public static Quaternion Inverse(Quaternion quaternion)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001344")]
		[global::Cpp2ILInjected.Address(RVA = "0xA8E4A0", Offset = "0xA8E4A0", Length = "0x4C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public static void Inverse(ref Quaternion quaternion, out Quaternion result)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001345")]
		[global::Cpp2ILInjected.Address(RVA = "0xA8E4EC", Offset = "0xA8E4EC", Length = "0x88")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public float Length()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001346")]
		[global::Cpp2ILInjected.Address(RVA = "0xA8E574", Offset = "0xA8E574", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public float LengthSquared()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001347")]
		[global::Cpp2ILInjected.Address(RVA = "0xA8E59C", Offset = "0xA8E59C", Length = "0x150")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static Quaternion Lerp(Quaternion quaternion1, Quaternion quaternion2, float amount)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001348")]
		[global::Cpp2ILInjected.Address(RVA = "0xA8E6EC", Offset = "0xA8E6EC", Length = "0x158")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static void Lerp(ref Quaternion quaternion1, ref Quaternion quaternion2, float amount, out Quaternion result)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001349")]
		[global::Cpp2ILInjected.Address(RVA = "0xA8E844", Offset = "0xA8E844", Length = "0x1B0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public static Quaternion Slerp(Quaternion quaternion1, Quaternion quaternion2, float amount)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600134A")]
		[global::Cpp2ILInjected.Address(RVA = "0xA8E9F4", Offset = "0xA8E9F4", Length = "0x174")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public static void Slerp(ref Quaternion quaternion1, ref Quaternion quaternion2, float amount, out Quaternion result)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600134B")]
		[global::Cpp2ILInjected.Address(RVA = "0xA8EB68", Offset = "0xA8EB68", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public static Quaternion Subtract(Quaternion quaternion1, Quaternion quaternion2)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600134C")]
		[global::Cpp2ILInjected.Address(RVA = "0xA8EB7C", Offset = "0xA8EB7C", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public static void Subtract(ref Quaternion quaternion1, ref Quaternion quaternion2, out Quaternion result)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600134D")]
		[global::Cpp2ILInjected.Address(RVA = "0xA8EB90", Offset = "0xA8EB90", Length = "0x74")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public static Quaternion Multiply(Quaternion quaternion1, Quaternion quaternion2)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600134E")]
		[global::Cpp2ILInjected.Address(RVA = "0xA8EC04", Offset = "0xA8EC04", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public static Quaternion Multiply(Quaternion quaternion1, float scaleFactor)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600134F")]
		[global::Cpp2ILInjected.Address(RVA = "0xA8EC18", Offset = "0xA8EC18", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public static void Multiply(ref Quaternion quaternion1, float scaleFactor, out Quaternion result)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001350")]
		[global::Cpp2ILInjected.Address(RVA = "0xA8EC28", Offset = "0xA8EC28", Length = "0x90")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public static void Multiply(ref Quaternion quaternion1, ref Quaternion quaternion2, out Quaternion result)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001351")]
		[global::Cpp2ILInjected.Address(RVA = "0xA8ECB8", Offset = "0xA8ECB8", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public static Quaternion Negate(Quaternion quaternion)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001352")]
		[global::Cpp2ILInjected.Address(RVA = "0xA8ECCC", Offset = "0xA8ECCC", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public static void Negate(ref Quaternion quaternion, out Quaternion result)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001353")]
		[global::Cpp2ILInjected.Address(RVA = "0xA8ECDC", Offset = "0xA8ECDC", Length = "0xA8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public void Normalize()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001354")]
		[global::Cpp2ILInjected.Address(RVA = "0xA8ED84", Offset = "0xA8ED84", Length = "0xA4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static Quaternion Normalize(Quaternion quaternion)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001355")]
		[global::Cpp2ILInjected.Address(RVA = "0xA8EE28", Offset = "0xA8EE28", Length = "0xB4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static void Normalize(ref Quaternion quaternion, out Quaternion result)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001356")]
		[global::Cpp2ILInjected.Address(RVA = "0xA8EEDC", Offset = "0xA8EEDC", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public static Quaternion operator +(Quaternion quaternion1, Quaternion quaternion2)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001357")]
		[global::Cpp2ILInjected.Address(RVA = "0xA8EEF0", Offset = "0xA8EEF0", Length = "0xB0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public static Quaternion operator /(Quaternion quaternion1, Quaternion quaternion2)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001358")]
		[global::Cpp2ILInjected.Address(RVA = "0xA8E398", Offset = "0xA8E398", Length = "0x30")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public static bool operator ==(Quaternion quaternion1, Quaternion quaternion2)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001359")]
		[global::Cpp2ILInjected.Address(RVA = "0xA8EFA0", Offset = "0xA8EFA0", Length = "0x30")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public static bool operator !=(Quaternion quaternion1, Quaternion quaternion2)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600135A")]
		[global::Cpp2ILInjected.Address(RVA = "0xA8EFD0", Offset = "0xA8EFD0", Length = "0x74")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public static Quaternion operator *(Quaternion quaternion1, Quaternion quaternion2)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600135B")]
		[global::Cpp2ILInjected.Address(RVA = "0xA8F044", Offset = "0xA8F044", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public static Quaternion operator *(Quaternion quaternion1, float scaleFactor)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600135C")]
		[global::Cpp2ILInjected.Address(RVA = "0xA8F058", Offset = "0xA8F058", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public static Quaternion operator -(Quaternion quaternion1, Quaternion quaternion2)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600135D")]
		[global::Cpp2ILInjected.Address(RVA = "0xA8F06C", Offset = "0xA8F06C", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public static Quaternion operator -(Quaternion quaternion)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600135E")]
		[global::Cpp2ILInjected.Address(RVA = "0xA8F080", Offset = "0xA8F080", Length = "0x170")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = ".ctor", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(StringBuilder))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(StringBuilder))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		public override string ToString()
		{
			throw null;
		}

		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x600135F")]
		[global::Cpp2ILInjected.Address(RVA = "0xA8F1F0", Offset = "0xA8F1F0", Length = "0x50")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		static Quaternion()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x4002268")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		public float X;

		[global::Cpp2ILInjected.Token(Token = "0x4002269")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x4")]
		public float Y;

		[global::Cpp2ILInjected.Token(Token = "0x400226A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x8")]
		public float Z;

		[global::Cpp2ILInjected.Token(Token = "0x400226B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xC")]
		public float W;

		[global::Cpp2ILInjected.Token(Token = "0x400226C")]
		private static Quaternion identity;
	}
}
