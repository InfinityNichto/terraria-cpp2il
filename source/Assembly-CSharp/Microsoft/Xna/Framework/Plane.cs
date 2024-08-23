using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace Microsoft.Xna.Framework
{
	// Token: 0x0200026A RID: 618
	[global::Cpp2ILInjected.Token(Token = "0x200032B")]
	[Serializable]
	public struct Plane : IEquatable<Plane>
	{
		// Token: 0x060011AF RID: 4527 RVA: 0x00024FDA File Offset: 0x000231DA
		[global::Cpp2ILInjected.Token(Token = "0x600130C")]
		[global::Cpp2ILInjected.Address(RVA = "0xA8CBF4", Offset = "0xA8CBF4", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public Plane(Vector4 value)
		{
			throw null;
		}

		// Token: 0x060011B0 RID: 4528 RVA: 0x00024FDD File Offset: 0x000231DD
		[global::Cpp2ILInjected.Token(Token = "0x600130D")]
		[global::Cpp2ILInjected.Address(RVA = "0xA8CC0C", Offset = "0xA8CC0C", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public Plane(Vector3 normal, float d)
		{
			throw null;
		}

		// Token: 0x060011B1 RID: 4529 RVA: 0x00024FE0 File Offset: 0x000231E0
		[global::Cpp2ILInjected.Token(Token = "0x600130E")]
		[global::Cpp2ILInjected.Address(RVA = "0xA8CC18", Offset = "0xA8CC18", Length = "0x110")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector3), Member = "Normalize", MemberParameters = new object[] { typeof(Vector3) }, ReturnType = typeof(Vector3))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public Plane(Vector3 a, Vector3 b, Vector3 c)
		{
			throw null;
		}

		// Token: 0x060011B2 RID: 4530 RVA: 0x00024FE3 File Offset: 0x000231E3
		[global::Cpp2ILInjected.Token(Token = "0x600130F")]
		[global::Cpp2ILInjected.Address(RVA = "0xA8CE0C", Offset = "0xA8CE0C", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public Plane(float a, float b, float c, float d)
		{
			throw null;
		}

		// Token: 0x060011B3 RID: 4531 RVA: 0x00024FE6 File Offset: 0x000231E6
		[global::Cpp2ILInjected.Token(Token = "0x6001310")]
		[global::Cpp2ILInjected.Address(RVA = "0xA8CE18", Offset = "0xA8CE18", Length = "0x2C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public float Dot(Vector4 value)
		{
			throw null;
		}

		// Token: 0x060011B4 RID: 4532 RVA: 0x00024FE9 File Offset: 0x000231E9
		[global::Cpp2ILInjected.Token(Token = "0x6001311")]
		[global::Cpp2ILInjected.Address(RVA = "0xA8CE44", Offset = "0xA8CE44", Length = "0x34")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public void Dot(ref Vector4 value, out float result)
		{
			throw null;
		}

		// Token: 0x060011B5 RID: 4533 RVA: 0x00024FEC File Offset: 0x000231EC
		[global::Cpp2ILInjected.Token(Token = "0x6001312")]
		[global::Cpp2ILInjected.Address(RVA = "0xA8CE78", Offset = "0xA8CE78", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public float DotCoordinate(Vector3 value)
		{
			throw null;
		}

		// Token: 0x060011B6 RID: 4534 RVA: 0x00024FEF File Offset: 0x000231EF
		[global::Cpp2ILInjected.Token(Token = "0x6001313")]
		[global::Cpp2ILInjected.Address(RVA = "0xA8CEA0", Offset = "0xA8CEA0", Length = "0x30")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public void DotCoordinate(ref Vector3 value, out float result)
		{
			throw null;
		}

		// Token: 0x060011B7 RID: 4535 RVA: 0x00024FF2 File Offset: 0x000231F2
		[global::Cpp2ILInjected.Token(Token = "0x6001314")]
		[global::Cpp2ILInjected.Address(RVA = "0xA8CED0", Offset = "0xA8CED0", Length = "0x20")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public float DotNormal(Vector3 value)
		{
			throw null;
		}

		// Token: 0x060011B8 RID: 4536 RVA: 0x00024FF5 File Offset: 0x000231F5
		[global::Cpp2ILInjected.Token(Token = "0x6001315")]
		[global::Cpp2ILInjected.Address(RVA = "0xA8CEF0", Offset = "0xA8CEF0", Length = "0x2C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public void DotNormal(ref Vector3 value, out float result)
		{
			throw null;
		}

		// Token: 0x060011B9 RID: 4537 RVA: 0x00024FF8 File Offset: 0x000231F8
		[global::Cpp2ILInjected.Token(Token = "0x6001316")]
		[global::Cpp2ILInjected.Address(RVA = "0xA8CF1C", Offset = "0xA8CF1C", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NotImplementedException), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public static void Transform(ref Plane plane, ref Quaternion rotation, out Plane result)
		{
			throw null;
		}

		// Token: 0x060011BA RID: 4538 RVA: 0x00024FFB File Offset: 0x000231FB
		[global::Cpp2ILInjected.Token(Token = "0x6001317")]
		[global::Cpp2ILInjected.Address(RVA = "0xA8CF54", Offset = "0xA8CF54", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NotImplementedException), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public static void Transform(ref Plane plane, ref Matrix matrix, out Plane result)
		{
			throw null;
		}

		// Token: 0x060011BB RID: 4539 RVA: 0x00024FFE File Offset: 0x000231FE
		[global::Cpp2ILInjected.Token(Token = "0x6001318")]
		[global::Cpp2ILInjected.Address(RVA = "0xA8CF8C", Offset = "0xA8CF8C", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NotImplementedException), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public static Plane Transform(Plane plane, Quaternion rotation)
		{
			throw null;
		}

		// Token: 0x060011BC RID: 4540 RVA: 0x00025001 File Offset: 0x00023201
		[global::Cpp2ILInjected.Token(Token = "0x6001319")]
		[global::Cpp2ILInjected.Address(RVA = "0xA8CFC4", Offset = "0xA8CFC4", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NotImplementedException), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public static Plane Transform(Plane plane, Matrix matrix)
		{
			throw null;
		}

		// Token: 0x060011BD RID: 4541 RVA: 0x00025004 File Offset: 0x00023204
		[global::Cpp2ILInjected.Token(Token = "0x600131A")]
		[global::Cpp2ILInjected.Address(RVA = "0xA8CFFC", Offset = "0xA8CFFC", Length = "0xF8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector3), Member = "Normalize", MemberParameters = new object[] { typeof(Vector3) }, ReturnType = typeof(Vector3))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public void Normalize()
		{
			throw null;
		}

		// Token: 0x060011BE RID: 4542 RVA: 0x00025007 File Offset: 0x00023207
		[global::Cpp2ILInjected.Token(Token = "0x600131B")]
		[global::Cpp2ILInjected.Address(RVA = "0xA8D0F4", Offset = "0xA8D0F4", Length = "0x34")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Matrix), Member = "CreateShadow", MemberParameters = new object[]
		{
			typeof(ref Vector3),
			typeof(ref Plane),
			typeof(ref Matrix)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Matrix), Member = "CreateReflection", MemberParameters = new object[]
		{
			typeof(ref Plane),
			typeof(ref Matrix)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Plane), Member = "Normalize", MemberParameters = new object[]
		{
			typeof(ref Plane),
			typeof(ref Plane)
		}, ReturnType = typeof(void))]
		public static Plane Normalize(Plane value)
		{
			throw null;
		}

		// Token: 0x060011BF RID: 4543 RVA: 0x0002500A File Offset: 0x0002320A
		[global::Cpp2ILInjected.Token(Token = "0x600131C")]
		[global::Cpp2ILInjected.Address(RVA = "0xA8D128", Offset = "0xA8D128", Length = "0x104")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Plane), Member = "Normalize", MemberParameters = new object[] { typeof(Plane) }, ReturnType = typeof(Plane))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector3), Member = "Normalize", MemberParameters = new object[] { typeof(Vector3) }, ReturnType = typeof(Vector3))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public static void Normalize(ref Plane value, out Plane result)
		{
			throw null;
		}

		// Token: 0x060011C0 RID: 4544 RVA: 0x0002500D File Offset: 0x0002320D
		[global::Cpp2ILInjected.Token(Token = "0x600131D")]
		[global::Cpp2ILInjected.Address(RVA = "0xA8D22C", Offset = "0xA8D22C", Length = "0x3C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Plane), Member = "Equals", MemberParameters = new object[] { typeof(Plane) }, ReturnType = typeof(bool))]
		public static bool operator !=(Plane plane1, Plane plane2)
		{
			throw null;
		}

		// Token: 0x060011C1 RID: 4545 RVA: 0x00025010 File Offset: 0x00023210
		[global::Cpp2ILInjected.Token(Token = "0x600131E")]
		[global::Cpp2ILInjected.Address(RVA = "0xA8D320", Offset = "0xA8D320", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Plane), Member = "Equals", MemberParameters = new object[] { typeof(Plane) }, ReturnType = typeof(bool))]
		public static bool operator ==(Plane plane1, Plane plane2)
		{
			throw null;
		}

		// Token: 0x060011C2 RID: 4546 RVA: 0x00025013 File Offset: 0x00023213
		[global::Cpp2ILInjected.Token(Token = "0x600131F")]
		[global::Cpp2ILInjected.Address(RVA = "0xA8D358", Offset = "0xA8D358", Length = "0x7C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Plane), Member = "Equals", MemberParameters = new object[] { typeof(Plane) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public override bool Equals(object other)
		{
			throw null;
		}

		// Token: 0x060011C3 RID: 4547 RVA: 0x00025016 File Offset: 0x00023216
		[global::Cpp2ILInjected.Token(Token = "0x6001320")]
		[global::Cpp2ILInjected.Address(RVA = "0xA8D268", Offset = "0xA8D268", Length = "0xB8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Plane), Member = "op_Inequality", MemberParameters = new object[]
		{
			typeof(Plane),
			typeof(Plane)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Plane), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(Plane),
			typeof(Plane)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Plane), Member = "Equals", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public bool Equals(Plane other)
		{
			throw null;
		}

		// Token: 0x060011C4 RID: 4548 RVA: 0x00025019 File Offset: 0x00023219
		[global::Cpp2ILInjected.Token(Token = "0x6001321")]
		[global::Cpp2ILInjected.Address(RVA = "0xA8D3FC", Offset = "0xA8D3FC", Length = "0x40")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(float), Member = "GetHashCode", ReturnType = typeof(int))]
		public override int GetHashCode()
		{
			throw null;
		}

		// Token: 0x060011C5 RID: 4549 RVA: 0x0002501C File Offset: 0x0002321C
		[global::Cpp2ILInjected.Token(Token = "0x6001322")]
		[global::Cpp2ILInjected.Address(RVA = "0xA8D468", Offset = "0xA8D468", Length = "0xC4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Format", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public override string ToString()
		{
			throw null;
		}

		// Token: 0x04001C89 RID: 7305
		[global::Cpp2ILInjected.Token(Token = "0x4002263")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		public float D;

		// Token: 0x04001C8A RID: 7306
		[global::Cpp2ILInjected.Token(Token = "0x4002264")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x4")]
		public Vector3 Normal;
	}
}
