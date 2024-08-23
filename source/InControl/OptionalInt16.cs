using System;
using System.Globalization;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

namespace InControl
{
	// Token: 0x0200005C RID: 92
	[global::Cpp2ILInjected.Token(Token = "0x2000067")]
	[Serializable]
	public struct OptionalInt16
	{
		// Token: 0x06000496 RID: 1174 RVA: 0x00002DEF File Offset: 0x00000FEF
		[global::Cpp2ILInjected.Token(Token = "0x60004AA")]
		[global::Cpp2ILInjected.Address(RVA = "0x19B6494", Offset = "0x19B6494", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public OptionalInt16(short value)
		{
			throw null;
		}

		// Token: 0x17000154 RID: 340
		// (get) Token: 0x06000497 RID: 1175 RVA: 0x00002DF2 File Offset: 0x00000FF2
		[global::Cpp2ILInjected.Token(Token = "0x17000156")]
		public bool HasValue
		{
			[global::Cpp2ILInjected.Token(Token = "0x60004AB")]
			[global::Cpp2ILInjected.Address(RVA = "0x19B64A4", Offset = "0x19B64A4", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000155 RID: 341
		// (get) Token: 0x06000498 RID: 1176 RVA: 0x00002DF5 File Offset: 0x00000FF5
		[global::Cpp2ILInjected.Token(Token = "0x17000157")]
		public bool HasNoValue
		{
			[global::Cpp2ILInjected.Token(Token = "0x60004AC")]
			[global::Cpp2ILInjected.Address(RVA = "0x19B64AC", Offset = "0x19B64AC", Length = "0x10")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000156 RID: 342
		// (get) Token: 0x06000499 RID: 1177 RVA: 0x00002DF8 File Offset: 0x00000FF8
		// (set) Token: 0x0600049A RID: 1178 RVA: 0x00002DFB File Offset: 0x00000FFB
		[global::Cpp2ILInjected.Token(Token = "0x17000158")]
		public short Value
		{
			[global::Cpp2ILInjected.Token(Token = "0x60004AD")]
			[global::Cpp2ILInjected.Address(RVA = "0x19B64BC", Offset = "0x19B64BC", Length = "0x5C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(OptionalInt16), Member = "op_Explicit", MemberParameters = new object[] { typeof(OptionalInt16) }, ReturnType = typeof(short))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(OptionalTypeHasNoValueException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x60004AE")]
			[global::Cpp2ILInjected.Address(RVA = "0x19B6518", Offset = "0x19B6518", Length = "0x10")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x0600049B RID: 1179 RVA: 0x00002DFE File Offset: 0x00000FFE
		[global::Cpp2ILInjected.Token(Token = "0x60004AF")]
		[global::Cpp2ILInjected.Address(RVA = "0x19B6528", Offset = "0x19B6528", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public void Clear()
		{
			throw null;
		}

		// Token: 0x0600049C RID: 1180 RVA: 0x00002E01 File Offset: 0x00001001
		[global::Cpp2ILInjected.Token(Token = "0x60004B0")]
		[global::Cpp2ILInjected.Address(RVA = "0x19B6534", Offset = "0x19B6534", Length = "0x18")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public short GetValueOrDefault(short defaultValue)
		{
			throw null;
		}

		// Token: 0x0600049D RID: 1181 RVA: 0x00002E04 File Offset: 0x00001004
		[global::Cpp2ILInjected.Token(Token = "0x60004B1")]
		[global::Cpp2ILInjected.Address(RVA = "0x19B654C", Offset = "0x19B654C", Length = "0x18")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public short GetValueOrZero()
		{
			throw null;
		}

		// Token: 0x0600049E RID: 1182 RVA: 0x00002E07 File Offset: 0x00001007
		[global::Cpp2ILInjected.Token(Token = "0x60004B2")]
		[global::Cpp2ILInjected.Address(RVA = "0x19B6564", Offset = "0x19B6564", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public void SetValue(short value)
		{
			throw null;
		}

		// Token: 0x0600049F RID: 1183 RVA: 0x00002E0A File Offset: 0x0000100A
		[global::Cpp2ILInjected.Token(Token = "0x60004B3")]
		[global::Cpp2ILInjected.Address(RVA = "0x19B6574", Offset = "0x19B6574", Length = "0x20")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(short), Member = "Equals", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(bool))]
		public override bool Equals(object other)
		{
			throw null;
		}

		// Token: 0x060004A0 RID: 1184 RVA: 0x00002E0D File Offset: 0x0000100D
		[global::Cpp2ILInjected.Token(Token = "0x60004B4")]
		[global::Cpp2ILInjected.Address(RVA = "0x19B6594", Offset = "0x19B6594", Length = "0x24")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public bool Equals(OptionalInt16 other)
		{
			throw null;
		}

		// Token: 0x060004A1 RID: 1185 RVA: 0x00002E10 File Offset: 0x00001010
		[global::Cpp2ILInjected.Token(Token = "0x60004B5")]
		[global::Cpp2ILInjected.Address(RVA = "0x19B65B8", Offset = "0x19B65B8", Length = "0x20")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public bool Equals(short other)
		{
			throw null;
		}

		// Token: 0x060004A2 RID: 1186 RVA: 0x00002E13 File Offset: 0x00001013
		[global::Cpp2ILInjected.Token(Token = "0x60004B6")]
		[global::Cpp2ILInjected.Address(RVA = "0x19B65D8", Offset = "0x19B65D8", Length = "0x18")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public static bool operator ==(OptionalInt16 a, OptionalInt16 b)
		{
			throw null;
		}

		// Token: 0x060004A3 RID: 1187 RVA: 0x00002E16 File Offset: 0x00001016
		[global::Cpp2ILInjected.Token(Token = "0x60004B7")]
		[global::Cpp2ILInjected.Address(RVA = "0x19B65F0", Offset = "0x19B65F0", Length = "0x24")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public static bool operator !=(OptionalInt16 a, OptionalInt16 b)
		{
			throw null;
		}

		// Token: 0x060004A4 RID: 1188 RVA: 0x00002E19 File Offset: 0x00001019
		[global::Cpp2ILInjected.Token(Token = "0x60004B8")]
		[global::Cpp2ILInjected.Address(RVA = "0x19B6614", Offset = "0x19B6614", Length = "0x1C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public static bool operator ==(OptionalInt16 a, short b)
		{
			throw null;
		}

		// Token: 0x060004A5 RID: 1189 RVA: 0x00002E1C File Offset: 0x0000101C
		[global::Cpp2ILInjected.Token(Token = "0x60004B9")]
		[global::Cpp2ILInjected.Address(RVA = "0x19B6630", Offset = "0x19B6630", Length = "0x1C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public static bool operator !=(OptionalInt16 a, short b)
		{
			throw null;
		}

		// Token: 0x060004A6 RID: 1190 RVA: 0x00002E1F File Offset: 0x0000101F
		[global::Cpp2ILInjected.Token(Token = "0x60004BA")]
		[global::Cpp2ILInjected.Address(RVA = "0x19B664C", Offset = "0x19B664C", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private static int CombineHashCodes(int h1, int h2)
		{
			throw null;
		}

		// Token: 0x060004A7 RID: 1191 RVA: 0x00002E22 File Offset: 0x00001022
		[global::Cpp2ILInjected.Token(Token = "0x60004BB")]
		[global::Cpp2ILInjected.Address(RVA = "0x19B6658", Offset = "0x19B6658", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(bool), Member = "GetHashCode", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(short), Member = "GetHashCode", ReturnType = typeof(int))]
		public override int GetHashCode()
		{
			throw null;
		}

		// Token: 0x060004A8 RID: 1192 RVA: 0x00002E25 File Offset: 0x00001025
		[global::Cpp2ILInjected.Token(Token = "0x60004BC")]
		[global::Cpp2ILInjected.Address(RVA = "0x19B6690", Offset = "0x19B6690", Length = "0x94")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(short), Member = "ToString", MemberParameters = new object[] { typeof(IFormatProvider) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public override string ToString()
		{
			throw null;
		}

		// Token: 0x060004A9 RID: 1193 RVA: 0x00002E28 File Offset: 0x00001028
		[global::Cpp2ILInjected.Token(Token = "0x60004BD")]
		[global::Cpp2ILInjected.Address(RVA = "0x19B6724", Offset = "0x19B6724", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public static implicit operator OptionalInt16(short value)
		{
			throw null;
		}

		// Token: 0x060004AA RID: 1194 RVA: 0x00002E2B File Offset: 0x0000102B
		[global::Cpp2ILInjected.Token(Token = "0x60004BE")]
		[global::Cpp2ILInjected.Address(RVA = "0x19B6734", Offset = "0x19B6734", Length = "0x18")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(OptionalInt16), Member = "get_Value", ReturnType = typeof(short))]
		public static explicit operator short(OptionalInt16 optional)
		{
			throw null;
		}

		// Token: 0x0400039B RID: 923
		[SerializeField]
		[global::Cpp2ILInjected.Token(Token = "0x40003E8")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private bool hasValue;

		// Token: 0x0400039C RID: 924
		[SerializeField]
		[global::Cpp2ILInjected.Token(Token = "0x40003E9")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x2")]
		private short value;
	}
}
