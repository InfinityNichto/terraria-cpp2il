using System;
using System.Globalization;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

namespace InControl
{
	// Token: 0x02000059 RID: 89
	[global::Cpp2ILInjected.Token(Token = "0x2000064")]
	[Serializable]
	public struct OptionalFloat
	{
		// Token: 0x06000455 RID: 1109 RVA: 0x00002D2C File Offset: 0x00000F2C
		[global::Cpp2ILInjected.Token(Token = "0x6000469")]
		[global::Cpp2ILInjected.Address(RVA = "0x19B5A6C", Offset = "0x19B5A6C", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public OptionalFloat(float value)
		{
			throw null;
		}

		// Token: 0x1700014B RID: 331
		// (get) Token: 0x06000456 RID: 1110 RVA: 0x00002D2F File Offset: 0x00000F2F
		[global::Cpp2ILInjected.Token(Token = "0x1700014D")]
		public bool HasValue
		{
			[global::Cpp2ILInjected.Token(Token = "0x600046A")]
			[global::Cpp2ILInjected.Address(RVA = "0x19B5A7C", Offset = "0x19B5A7C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700014C RID: 332
		// (get) Token: 0x06000457 RID: 1111 RVA: 0x00002D32 File Offset: 0x00000F32
		[global::Cpp2ILInjected.Token(Token = "0x1700014E")]
		public bool HasNoValue
		{
			[global::Cpp2ILInjected.Token(Token = "0x600046B")]
			[global::Cpp2ILInjected.Address(RVA = "0x19B5A84", Offset = "0x19B5A84", Length = "0x10")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700014D RID: 333
		// (get) Token: 0x06000458 RID: 1112 RVA: 0x00002D35 File Offset: 0x00000F35
		// (set) Token: 0x06000459 RID: 1113 RVA: 0x00002D38 File Offset: 0x00000F38
		[global::Cpp2ILInjected.Token(Token = "0x1700014F")]
		public float Value
		{
			[global::Cpp2ILInjected.Token(Token = "0x600046C")]
			[global::Cpp2ILInjected.Address(RVA = "0x19B5A94", Offset = "0x19B5A94", Length = "0x5C")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(OptionalFloat), Member = "op_Explicit", MemberParameters = new object[] { typeof(OptionalFloat) }, ReturnType = typeof(float))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(OptionalTypeHasNoValueException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x600046D")]
			[global::Cpp2ILInjected.Address(RVA = "0x19B5AF0", Offset = "0x19B5AF0", Length = "0x10")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x0600045A RID: 1114 RVA: 0x00002D3B File Offset: 0x00000F3B
		[global::Cpp2ILInjected.Token(Token = "0x600046E")]
		[global::Cpp2ILInjected.Address(RVA = "0x19B5B00", Offset = "0x19B5B00", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public void Clear()
		{
			throw null;
		}

		// Token: 0x0600045B RID: 1115 RVA: 0x00002D3E File Offset: 0x00000F3E
		[global::Cpp2ILInjected.Token(Token = "0x600046F")]
		[global::Cpp2ILInjected.Address(RVA = "0x19B5B0C", Offset = "0x19B5B0C", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public float GetValueOrDefault(float defaultValue)
		{
			throw null;
		}

		// Token: 0x0600045C RID: 1116 RVA: 0x00002D41 File Offset: 0x00000F41
		[global::Cpp2ILInjected.Token(Token = "0x6000470")]
		[global::Cpp2ILInjected.Address(RVA = "0x19B5B1C", Offset = "0x19B5B1C", Length = "0x18")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public float GetValueOrZero()
		{
			throw null;
		}

		// Token: 0x0600045D RID: 1117 RVA: 0x00002D44 File Offset: 0x00000F44
		[global::Cpp2ILInjected.Token(Token = "0x6000471")]
		[global::Cpp2ILInjected.Address(RVA = "0x19B5B34", Offset = "0x19B5B34", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public void SetValue(float value)
		{
			throw null;
		}

		// Token: 0x0600045E RID: 1118 RVA: 0x00002D47 File Offset: 0x00000F47
		[global::Cpp2ILInjected.Token(Token = "0x6000472")]
		[global::Cpp2ILInjected.Address(RVA = "0x19B5B44", Offset = "0x19B5B44", Length = "0x20")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(float), Member = "Equals", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(bool))]
		public override bool Equals(object other)
		{
			throw null;
		}

		// Token: 0x0600045F RID: 1119 RVA: 0x00002D4A File Offset: 0x00000F4A
		[global::Cpp2ILInjected.Token(Token = "0x6000473")]
		[global::Cpp2ILInjected.Address(RVA = "0x19B5B64", Offset = "0x19B5B64", Length = "0x4C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public bool Equals(OptionalFloat other)
		{
			throw null;
		}

		// Token: 0x06000460 RID: 1120 RVA: 0x00002D4D File Offset: 0x00000F4D
		[global::Cpp2ILInjected.Token(Token = "0x6000474")]
		[global::Cpp2ILInjected.Address(RVA = "0x19B5BDC", Offset = "0x19B5BDC", Length = "0x40")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public bool Equals(float other)
		{
			throw null;
		}

		// Token: 0x06000461 RID: 1121 RVA: 0x00002D50 File Offset: 0x00000F50
		[global::Cpp2ILInjected.Token(Token = "0x6000475")]
		[global::Cpp2ILInjected.Address(RVA = "0x19B5C1C", Offset = "0x19B5C1C", Length = "0x4C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public static bool operator ==(OptionalFloat a, OptionalFloat b)
		{
			throw null;
		}

		// Token: 0x06000462 RID: 1122 RVA: 0x00002D53 File Offset: 0x00000F53
		[global::Cpp2ILInjected.Token(Token = "0x6000476")]
		[global::Cpp2ILInjected.Address(RVA = "0x19B5C68", Offset = "0x19B5C68", Length = "0x4C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public static bool operator !=(OptionalFloat a, OptionalFloat b)
		{
			throw null;
		}

		// Token: 0x06000463 RID: 1123 RVA: 0x00002D56 File Offset: 0x00000F56
		[global::Cpp2ILInjected.Token(Token = "0x6000477")]
		[global::Cpp2ILInjected.Address(RVA = "0x19B5CB4", Offset = "0x19B5CB4", Length = "0x40")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public static bool operator ==(OptionalFloat a, float b)
		{
			throw null;
		}

		// Token: 0x06000464 RID: 1124 RVA: 0x00002D59 File Offset: 0x00000F59
		[global::Cpp2ILInjected.Token(Token = "0x6000478")]
		[global::Cpp2ILInjected.Address(RVA = "0x19B5CF4", Offset = "0x19B5CF4", Length = "0x40")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public static bool operator !=(OptionalFloat a, float b)
		{
			throw null;
		}

		// Token: 0x06000465 RID: 1125 RVA: 0x00002D5C File Offset: 0x00000F5C
		[global::Cpp2ILInjected.Token(Token = "0x6000479")]
		[global::Cpp2ILInjected.Address(RVA = "0x19B5D34", Offset = "0x19B5D34", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private static int CombineHashCodes(int h1, int h2)
		{
			throw null;
		}

		// Token: 0x06000466 RID: 1126 RVA: 0x00002D5F File Offset: 0x00000F5F
		[global::Cpp2ILInjected.Token(Token = "0x600047A")]
		[global::Cpp2ILInjected.Address(RVA = "0x19B5D40", Offset = "0x19B5D40", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(bool), Member = "GetHashCode", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(float), Member = "GetHashCode", ReturnType = typeof(int))]
		public override int GetHashCode()
		{
			throw null;
		}

		// Token: 0x06000467 RID: 1127 RVA: 0x00002D62 File Offset: 0x00000F62
		[global::Cpp2ILInjected.Token(Token = "0x600047B")]
		[global::Cpp2ILInjected.Address(RVA = "0x19B5D78", Offset = "0x19B5D78", Length = "0x94")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(float), Member = "ToString", MemberParameters = new object[] { typeof(IFormatProvider) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public override string ToString()
		{
			throw null;
		}

		// Token: 0x06000468 RID: 1128 RVA: 0x00002D65 File Offset: 0x00000F65
		[global::Cpp2ILInjected.Token(Token = "0x600047C")]
		[global::Cpp2ILInjected.Address(RVA = "0x19B5E0C", Offset = "0x19B5E0C", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public static implicit operator OptionalFloat(float value)
		{
			throw null;
		}

		// Token: 0x06000469 RID: 1129 RVA: 0x00002D68 File Offset: 0x00000F68
		[global::Cpp2ILInjected.Token(Token = "0x600047D")]
		[global::Cpp2ILInjected.Address(RVA = "0x19B5E1C", Offset = "0x19B5E1C", Length = "0x18")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(OptionalFloat), Member = "get_Value", ReturnType = typeof(float))]
		public static explicit operator float(OptionalFloat optional)
		{
			throw null;
		}

		// Token: 0x0600046A RID: 1130 RVA: 0x00002D6B File Offset: 0x00000F6B
		[global::Cpp2ILInjected.Token(Token = "0x600047E")]
		[global::Cpp2ILInjected.Address(RVA = "0x19B5BB0", Offset = "0x19B5BB0", Length = "0x2C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private static bool IsApproximatelyEqual(float a, float b)
		{
			throw null;
		}

		// Token: 0x0600046B RID: 1131 RVA: 0x00002D6E File Offset: 0x00000F6E
		[global::Cpp2ILInjected.Token(Token = "0x600047F")]
		[global::Cpp2ILInjected.Address(RVA = "0x19B5E34", Offset = "0x19B5E34", Length = "0x40")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public bool ApproximatelyEquals(float other)
		{
			throw null;
		}

		// Token: 0x04000394 RID: 916
		[SerializeField]
		[global::Cpp2ILInjected.Token(Token = "0x40003E1")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private bool hasValue;

		// Token: 0x04000395 RID: 917
		[SerializeField]
		[global::Cpp2ILInjected.Token(Token = "0x40003E2")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x4")]
		private float value;

		// Token: 0x04000396 RID: 918
		[global::Cpp2ILInjected.Token(Token = "0x40003E3")]
		private const float epsilon = 1E-07f;
	}
}
