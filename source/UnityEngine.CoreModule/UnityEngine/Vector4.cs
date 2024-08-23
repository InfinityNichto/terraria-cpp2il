using System;
using System.Globalization;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Unity.IL2CPP.CompilerServices;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x020000BA RID: 186
	[NativeClass("Vector4f")]
	[NativeHeader("Runtime/Math/Vector4.h")]
	[Il2CppEagerStaticClassConstruction]
	[RequiredByNativeCode(Optional = true, GenerateProxy = true)]
	[global::Cpp2ILInjected.Token(Token = "0x20000CC")]
	public struct Vector4 : IEquatable<Vector4>, IFormattable
	{
		// Token: 0x170000C0 RID: 192
		[global::Cpp2ILInjected.Token(Token = "0x170000C2")]
		public float this[int index]
		{
			[global::Cpp2ILInjected.Token(Token = "0x60003BA")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F8050C", Offset = "0x1F8050C", Length = "0x90")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(IndexOutOfRangeException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
			[MethodImpl(256)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x60003BB")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F8059C", Offset = "0x1F8059C", Length = "0x90")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(IndexOutOfRangeException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
			[MethodImpl(256)]
			set
			{
				throw null;
			}
		}

		// Token: 0x060003A8 RID: 936 RVA: 0x000027E8 File Offset: 0x000009E8
		[global::Cpp2ILInjected.Token(Token = "0x60003BC")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F8062C", Offset = "0x1F8062C", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[MethodImpl(256)]
		public Vector4(float x, float y, float z, float w)
		{
			throw null;
		}

		// Token: 0x060003A9 RID: 937 RVA: 0x000027EB File Offset: 0x000009EB
		[global::Cpp2ILInjected.Token(Token = "0x60003BD")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F80638", Offset = "0x1F80638", Length = "0x64")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(float), Member = "GetHashCode", ReturnType = typeof(int))]
		[MethodImpl(256)]
		public override int GetHashCode()
		{
			throw null;
		}

		// Token: 0x060003AA RID: 938 RVA: 0x000027EE File Offset: 0x000009EE
		[global::Cpp2ILInjected.Token(Token = "0x60003BE")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F8069C", Offset = "0x1F8069C", Length = "0xA8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		[MethodImpl(256)]
		public override bool Equals(object other)
		{
			throw null;
		}

		// Token: 0x060003AB RID: 939 RVA: 0x000027F1 File Offset: 0x000009F1
		[global::Cpp2ILInjected.Token(Token = "0x60003BF")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F80744", Offset = "0x1F80744", Length = "0x3C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[MethodImpl(256)]
		public bool Equals(Vector4 other)
		{
			throw null;
		}

		// Token: 0x060003AC RID: 940 RVA: 0x000027F4 File Offset: 0x000009F4
		[global::Cpp2ILInjected.Token(Token = "0x60003C0")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F80780", Offset = "0x1F80780", Length = "0x20")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[MethodImpl(256)]
		public static float Dot(Vector4 a, Vector4 b)
		{
			throw null;
		}

		// Token: 0x170000C1 RID: 193
		// (get) Token: 0x060003AD RID: 941 RVA: 0x000027F7 File Offset: 0x000009F7
		[global::Cpp2ILInjected.Token(Token = "0x170000C3")]
		public float sqrMagnitude
		{
			[global::Cpp2ILInjected.Token(Token = "0x60003C1")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F807A0", Offset = "0x1F807A0", Length = "0x28")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[MethodImpl(256)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170000C2 RID: 194
		// (get) Token: 0x060003AE RID: 942 RVA: 0x000027FA File Offset: 0x000009FA
		[global::Cpp2ILInjected.Token(Token = "0x170000C4")]
		public static Vector4 zero
		{
			[global::Cpp2ILInjected.Token(Token = "0x60003C2")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F807C8", Offset = "0x1F807C8", Length = "0x4C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			[MethodImpl(256)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170000C3 RID: 195
		// (get) Token: 0x060003AF RID: 943 RVA: 0x000027FD File Offset: 0x000009FD
		[global::Cpp2ILInjected.Token(Token = "0x170000C5")]
		public static Vector4 one
		{
			[global::Cpp2ILInjected.Token(Token = "0x60003C3")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F80814", Offset = "0x1F80814", Length = "0x4C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			[MethodImpl(256)]
			get
			{
				throw null;
			}
		}

		// Token: 0x060003B0 RID: 944 RVA: 0x00002800 File Offset: 0x00000A00
		[global::Cpp2ILInjected.Token(Token = "0x60003C4")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F80860", Offset = "0x1F80860", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[MethodImpl(256)]
		public static Vector4 operator /(Vector4 a, float d)
		{
			throw null;
		}

		// Token: 0x060003B1 RID: 945 RVA: 0x00002803 File Offset: 0x00000A03
		[global::Cpp2ILInjected.Token(Token = "0x60003C5")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F80874", Offset = "0x1F80874", Length = "0x40")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[MethodImpl(256)]
		public static bool operator ==(Vector4 lhs, Vector4 rhs)
		{
			throw null;
		}

		// Token: 0x060003B2 RID: 946 RVA: 0x00002806 File Offset: 0x00000A06
		[global::Cpp2ILInjected.Token(Token = "0x60003C6")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F808B4", Offset = "0x1F808B4", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[MethodImpl(256)]
		public static implicit operator Vector4(Vector3 v)
		{
			throw null;
		}

		// Token: 0x060003B3 RID: 947 RVA: 0x00002809 File Offset: 0x00000A09
		[global::Cpp2ILInjected.Token(Token = "0x60003C7")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F808BC", Offset = "0x1F808BC", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[MethodImpl(256)]
		public static implicit operator Vector4(Vector2 v)
		{
			throw null;
		}

		// Token: 0x060003B4 RID: 948 RVA: 0x0000280C File Offset: 0x00000A0C
		[global::Cpp2ILInjected.Token(Token = "0x60003C8")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F808C8", Offset = "0x1F808C8", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public override string ToString()
		{
			throw null;
		}

		// Token: 0x060003B5 RID: 949 RVA: 0x0000280F File Offset: 0x00000A0F
		[global::Cpp2ILInjected.Token(Token = "0x60003C9")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F808D4", Offset = "0x1F808D4", Length = "0x1CC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(float), Member = "ToString", MemberParameters = new object[]
		{
			typeof(string),
			typeof(IFormatProvider)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "UnityEngine.UnityString", Member = "Format", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object[])
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 12)]
		public string ToString(string format, IFormatProvider formatProvider)
		{
			throw null;
		}

		// Token: 0x060003B6 RID: 950 RVA: 0x00002812 File Offset: 0x00000A12
		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x60003CA")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F80AA0", Offset = "0x1F80AA0", Length = "0x74")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		static Vector4()
		{
			throw null;
		}

		// Token: 0x0400036B RID: 875
		[global::Cpp2ILInjected.Token(Token = "0x40003A3")]
		public const float kEpsilon = 1E-05f;

		// Token: 0x0400036C RID: 876
		[global::Cpp2ILInjected.Token(Token = "0x40003A4")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		public float x;

		// Token: 0x0400036D RID: 877
		[global::Cpp2ILInjected.Token(Token = "0x40003A5")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x4")]
		public float y;

		// Token: 0x0400036E RID: 878
		[global::Cpp2ILInjected.Token(Token = "0x40003A6")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x8")]
		public float z;

		// Token: 0x0400036F RID: 879
		[global::Cpp2ILInjected.Token(Token = "0x40003A7")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xC")]
		public float w;

		// Token: 0x04000370 RID: 880
		[global::Cpp2ILInjected.Token(Token = "0x40003A8")]
		private static readonly Vector4 zeroVector;

		// Token: 0x04000371 RID: 881
		[global::Cpp2ILInjected.Token(Token = "0x40003A9")]
		private static readonly Vector4 oneVector;

		// Token: 0x04000372 RID: 882
		[global::Cpp2ILInjected.Token(Token = "0x40003AA")]
		private static readonly Vector4 positiveInfinityVector;

		// Token: 0x04000373 RID: 883
		[global::Cpp2ILInjected.Token(Token = "0x40003AB")]
		private static readonly Vector4 negativeInfinityVector;
	}
}
