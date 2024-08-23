using System;
using System.Globalization;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

namespace InControl
{
	// Token: 0x0200005D RID: 93
	[global::Cpp2ILInjected.Token(Token = "0x2000068")]
	[Serializable]
	public struct OptionalInt32
	{
		// Token: 0x060004AB RID: 1195 RVA: 0x00002E2E File Offset: 0x0000102E
		[global::Cpp2ILInjected.Token(Token = "0x60004BF")]
		[global::Cpp2ILInjected.Address(RVA = "0x19B674C", Offset = "0x19B674C", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public OptionalInt32(int value)
		{
			throw null;
		}

		// Token: 0x17000157 RID: 343
		// (get) Token: 0x060004AC RID: 1196 RVA: 0x00002E31 File Offset: 0x00001031
		[global::Cpp2ILInjected.Token(Token = "0x17000159")]
		public bool HasValue
		{
			[global::Cpp2ILInjected.Token(Token = "0x60004C0")]
			[global::Cpp2ILInjected.Address(RVA = "0x19B675C", Offset = "0x19B675C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000158 RID: 344
		// (get) Token: 0x060004AD RID: 1197 RVA: 0x00002E34 File Offset: 0x00001034
		[global::Cpp2ILInjected.Token(Token = "0x1700015A")]
		public bool HasNoValue
		{
			[global::Cpp2ILInjected.Token(Token = "0x60004C1")]
			[global::Cpp2ILInjected.Address(RVA = "0x19B6764", Offset = "0x19B6764", Length = "0x10")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000159 RID: 345
		// (get) Token: 0x060004AE RID: 1198 RVA: 0x00002E37 File Offset: 0x00001037
		// (set) Token: 0x060004AF RID: 1199 RVA: 0x00002E3A File Offset: 0x0000103A
		[global::Cpp2ILInjected.Token(Token = "0x1700015B")]
		public int Value
		{
			[global::Cpp2ILInjected.Token(Token = "0x60004C2")]
			[global::Cpp2ILInjected.Address(RVA = "0x19B6774", Offset = "0x19B6774", Length = "0x5C")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(OptionalInt32), Member = "op_Explicit", MemberParameters = new object[] { typeof(OptionalInt32) }, ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(OptionalTypeHasNoValueException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x60004C3")]
			[global::Cpp2ILInjected.Address(RVA = "0x19B67D0", Offset = "0x19B67D0", Length = "0x10")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x060004B0 RID: 1200 RVA: 0x00002E3D File Offset: 0x0000103D
		[global::Cpp2ILInjected.Token(Token = "0x60004C4")]
		[global::Cpp2ILInjected.Address(RVA = "0x19B67E0", Offset = "0x19B67E0", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public void Clear()
		{
			throw null;
		}

		// Token: 0x060004B1 RID: 1201 RVA: 0x00002E40 File Offset: 0x00001040
		[global::Cpp2ILInjected.Token(Token = "0x60004C5")]
		[global::Cpp2ILInjected.Address(RVA = "0x19B67EC", Offset = "0x19B67EC", Length = "0x18")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public int GetValueOrDefault(int defaultValue)
		{
			throw null;
		}

		// Token: 0x060004B2 RID: 1202 RVA: 0x00002E43 File Offset: 0x00001043
		[global::Cpp2ILInjected.Token(Token = "0x60004C6")]
		[global::Cpp2ILInjected.Address(RVA = "0x19B6804", Offset = "0x19B6804", Length = "0x18")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public int GetValueOrZero()
		{
			throw null;
		}

		// Token: 0x060004B3 RID: 1203 RVA: 0x00002E46 File Offset: 0x00001046
		[global::Cpp2ILInjected.Token(Token = "0x60004C7")]
		[global::Cpp2ILInjected.Address(RVA = "0x19B681C", Offset = "0x19B681C", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public void SetValue(int value)
		{
			throw null;
		}

		// Token: 0x060004B4 RID: 1204 RVA: 0x00002E49 File Offset: 0x00001049
		[global::Cpp2ILInjected.Token(Token = "0x60004C8")]
		[global::Cpp2ILInjected.Address(RVA = "0x19B682C", Offset = "0x19B682C", Length = "0x20")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(int), Member = "Equals", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(bool))]
		public override bool Equals(object other)
		{
			throw null;
		}

		// Token: 0x060004B5 RID: 1205 RVA: 0x00002E4C File Offset: 0x0000104C
		[global::Cpp2ILInjected.Token(Token = "0x60004C9")]
		[global::Cpp2ILInjected.Address(RVA = "0x19B684C", Offset = "0x19B684C", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public bool Equals(OptionalInt32 other)
		{
			throw null;
		}

		// Token: 0x060004B6 RID: 1206 RVA: 0x00002E4F File Offset: 0x0000104F
		[global::Cpp2ILInjected.Token(Token = "0x60004CA")]
		[global::Cpp2ILInjected.Address(RVA = "0x19B6874", Offset = "0x19B6874", Length = "0x20")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public bool Equals(int other)
		{
			throw null;
		}

		// Token: 0x060004B7 RID: 1207 RVA: 0x00002E52 File Offset: 0x00001052
		[global::Cpp2ILInjected.Token(Token = "0x60004CB")]
		[global::Cpp2ILInjected.Address(RVA = "0x19B6894", Offset = "0x19B6894", Length = "0x24")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public static bool operator ==(OptionalInt32 a, OptionalInt32 b)
		{
			throw null;
		}

		// Token: 0x060004B8 RID: 1208 RVA: 0x00002E55 File Offset: 0x00001055
		[global::Cpp2ILInjected.Token(Token = "0x60004CC")]
		[global::Cpp2ILInjected.Address(RVA = "0x19B68B8", Offset = "0x19B68B8", Length = "0x2C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public static bool operator !=(OptionalInt32 a, OptionalInt32 b)
		{
			throw null;
		}

		// Token: 0x060004B9 RID: 1209 RVA: 0x00002E58 File Offset: 0x00001058
		[global::Cpp2ILInjected.Token(Token = "0x60004CD")]
		[global::Cpp2ILInjected.Address(RVA = "0x19B68E4", Offset = "0x19B68E4", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public static bool operator ==(OptionalInt32 a, int b)
		{
			throw null;
		}

		// Token: 0x060004BA RID: 1210 RVA: 0x00002E5B File Offset: 0x0000105B
		[global::Cpp2ILInjected.Token(Token = "0x60004CE")]
		[global::Cpp2ILInjected.Address(RVA = "0x19B68F8", Offset = "0x19B68F8", Length = "0x1C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public static bool operator !=(OptionalInt32 a, int b)
		{
			throw null;
		}

		// Token: 0x060004BB RID: 1211 RVA: 0x00002E5E File Offset: 0x0000105E
		[global::Cpp2ILInjected.Token(Token = "0x60004CF")]
		[global::Cpp2ILInjected.Address(RVA = "0x19B6914", Offset = "0x19B6914", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private static int CombineHashCodes(int h1, int h2)
		{
			throw null;
		}

		// Token: 0x060004BC RID: 1212 RVA: 0x00002E61 File Offset: 0x00001061
		[global::Cpp2ILInjected.Token(Token = "0x60004D0")]
		[global::Cpp2ILInjected.Address(RVA = "0x19B6920", Offset = "0x19B6920", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(bool), Member = "GetHashCode", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(int), Member = "GetHashCode", ReturnType = typeof(int))]
		public override int GetHashCode()
		{
			throw null;
		}

		// Token: 0x060004BD RID: 1213 RVA: 0x00002E64 File Offset: 0x00001064
		[global::Cpp2ILInjected.Token(Token = "0x60004D1")]
		[global::Cpp2ILInjected.Address(RVA = "0x19B6958", Offset = "0x19B6958", Length = "0x94")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(int), Member = "ToString", MemberParameters = new object[] { typeof(IFormatProvider) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public override string ToString()
		{
			throw null;
		}

		// Token: 0x060004BE RID: 1214 RVA: 0x00002E67 File Offset: 0x00001067
		[global::Cpp2ILInjected.Token(Token = "0x60004D2")]
		[global::Cpp2ILInjected.Address(RVA = "0x19B69EC", Offset = "0x19B69EC", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public static implicit operator OptionalInt32(int value)
		{
			throw null;
		}

		// Token: 0x060004BF RID: 1215 RVA: 0x00002E6A File Offset: 0x0000106A
		[global::Cpp2ILInjected.Token(Token = "0x60004D3")]
		[global::Cpp2ILInjected.Address(RVA = "0x19B69FC", Offset = "0x19B69FC", Length = "0x18")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(OptionalInt32), Member = "get_Value", ReturnType = typeof(int))]
		public static explicit operator int(OptionalInt32 optional)
		{
			throw null;
		}

		// Token: 0x0400039D RID: 925
		[SerializeField]
		[global::Cpp2ILInjected.Token(Token = "0x40003EA")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private bool hasValue;

		// Token: 0x0400039E RID: 926
		[SerializeField]
		[global::Cpp2ILInjected.Token(Token = "0x40003EB")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x4")]
		private int value;
	}
}
