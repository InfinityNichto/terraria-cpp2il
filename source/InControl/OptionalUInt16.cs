using System;
using System.Globalization;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

namespace InControl
{
	// Token: 0x0200005E RID: 94
	[global::Cpp2ILInjected.Token(Token = "0x2000069")]
	[Serializable]
	public struct OptionalUInt16
	{
		// Token: 0x060004C0 RID: 1216 RVA: 0x00002E6D File Offset: 0x0000106D
		[global::Cpp2ILInjected.Token(Token = "0x60004D4")]
		[global::Cpp2ILInjected.Address(RVA = "0x19B6A14", Offset = "0x19B6A14", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public OptionalUInt16(ushort value)
		{
			throw null;
		}

		// Token: 0x1700015A RID: 346
		// (get) Token: 0x060004C1 RID: 1217 RVA: 0x00002E70 File Offset: 0x00001070
		[global::Cpp2ILInjected.Token(Token = "0x1700015C")]
		public bool HasValue
		{
			[global::Cpp2ILInjected.Token(Token = "0x60004D5")]
			[global::Cpp2ILInjected.Address(RVA = "0x19B6A24", Offset = "0x19B6A24", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700015B RID: 347
		// (get) Token: 0x060004C2 RID: 1218 RVA: 0x00002E73 File Offset: 0x00001073
		[global::Cpp2ILInjected.Token(Token = "0x1700015D")]
		public bool HasNoValue
		{
			[global::Cpp2ILInjected.Token(Token = "0x60004D6")]
			[global::Cpp2ILInjected.Address(RVA = "0x19B6A2C", Offset = "0x19B6A2C", Length = "0x10")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700015C RID: 348
		// (get) Token: 0x060004C3 RID: 1219 RVA: 0x00002E76 File Offset: 0x00001076
		// (set) Token: 0x060004C4 RID: 1220 RVA: 0x00002E79 File Offset: 0x00001079
		[global::Cpp2ILInjected.Token(Token = "0x1700015E")]
		public ushort Value
		{
			[global::Cpp2ILInjected.Token(Token = "0x60004D7")]
			[global::Cpp2ILInjected.Address(RVA = "0x19B6A3C", Offset = "0x19B6A3C", Length = "0x5C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(InputDeviceMatcher), Member = "Matches", MemberParameters = new object[] { typeof(InputDeviceInfo) }, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(OptionalUInt16), Member = "op_Explicit", MemberParameters = new object[] { typeof(OptionalUInt16) }, ReturnType = typeof(ushort))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(OptionalTypeHasNoValueException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x60004D8")]
			[global::Cpp2ILInjected.Address(RVA = "0x19B6A98", Offset = "0x19B6A98", Length = "0x10")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x060004C5 RID: 1221 RVA: 0x00002E7C File Offset: 0x0000107C
		[global::Cpp2ILInjected.Token(Token = "0x60004D9")]
		[global::Cpp2ILInjected.Address(RVA = "0x19B6AA8", Offset = "0x19B6AA8", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public void Clear()
		{
			throw null;
		}

		// Token: 0x060004C6 RID: 1222 RVA: 0x00002E7F File Offset: 0x0000107F
		[global::Cpp2ILInjected.Token(Token = "0x60004DA")]
		[global::Cpp2ILInjected.Address(RVA = "0x19B6AB4", Offset = "0x19B6AB4", Length = "0x18")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public ushort GetValueOrDefault(ushort defaultValue)
		{
			throw null;
		}

		// Token: 0x060004C7 RID: 1223 RVA: 0x00002E82 File Offset: 0x00001082
		[global::Cpp2ILInjected.Token(Token = "0x60004DB")]
		[global::Cpp2ILInjected.Address(RVA = "0x19B6ACC", Offset = "0x19B6ACC", Length = "0x18")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public ushort GetValueOrZero()
		{
			throw null;
		}

		// Token: 0x060004C8 RID: 1224 RVA: 0x00002E85 File Offset: 0x00001085
		[global::Cpp2ILInjected.Token(Token = "0x60004DC")]
		[global::Cpp2ILInjected.Address(RVA = "0x19B6AE4", Offset = "0x19B6AE4", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public void SetValue(ushort value)
		{
			throw null;
		}

		// Token: 0x060004C9 RID: 1225 RVA: 0x00002E88 File Offset: 0x00001088
		[global::Cpp2ILInjected.Token(Token = "0x60004DD")]
		[global::Cpp2ILInjected.Address(RVA = "0x19B6AF4", Offset = "0x19B6AF4", Length = "0x20")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ushort), Member = "Equals", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(bool))]
		public override bool Equals(object other)
		{
			throw null;
		}

		// Token: 0x060004CA RID: 1226 RVA: 0x00002E8B File Offset: 0x0000108B
		[global::Cpp2ILInjected.Token(Token = "0x60004DE")]
		[global::Cpp2ILInjected.Address(RVA = "0x19B6B14", Offset = "0x19B6B14", Length = "0x24")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public bool Equals(OptionalUInt16 other)
		{
			throw null;
		}

		// Token: 0x060004CB RID: 1227 RVA: 0x00002E8E File Offset: 0x0000108E
		[global::Cpp2ILInjected.Token(Token = "0x60004DF")]
		[global::Cpp2ILInjected.Address(RVA = "0x19B6B38", Offset = "0x19B6B38", Length = "0x20")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public bool Equals(ushort other)
		{
			throw null;
		}

		// Token: 0x060004CC RID: 1228 RVA: 0x00002E91 File Offset: 0x00001091
		[global::Cpp2ILInjected.Token(Token = "0x60004E0")]
		[global::Cpp2ILInjected.Address(RVA = "0x19B6B58", Offset = "0x19B6B58", Length = "0x18")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public static bool operator ==(OptionalUInt16 a, OptionalUInt16 b)
		{
			throw null;
		}

		// Token: 0x060004CD RID: 1229 RVA: 0x00002E94 File Offset: 0x00001094
		[global::Cpp2ILInjected.Token(Token = "0x60004E1")]
		[global::Cpp2ILInjected.Address(RVA = "0x19B6B70", Offset = "0x19B6B70", Length = "0x24")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public static bool operator !=(OptionalUInt16 a, OptionalUInt16 b)
		{
			throw null;
		}

		// Token: 0x060004CE RID: 1230 RVA: 0x00002E97 File Offset: 0x00001097
		[global::Cpp2ILInjected.Token(Token = "0x60004E2")]
		[global::Cpp2ILInjected.Address(RVA = "0x19B6B94", Offset = "0x19B6B94", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public static bool operator ==(OptionalUInt16 a, ushort b)
		{
			throw null;
		}

		// Token: 0x060004CF RID: 1231 RVA: 0x00002E9A File Offset: 0x0000109A
		[global::Cpp2ILInjected.Token(Token = "0x60004E3")]
		[global::Cpp2ILInjected.Address(RVA = "0x19B6BA8", Offset = "0x19B6BA8", Length = "0x1C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public static bool operator !=(OptionalUInt16 a, ushort b)
		{
			throw null;
		}

		// Token: 0x060004D0 RID: 1232 RVA: 0x00002E9D File Offset: 0x0000109D
		[global::Cpp2ILInjected.Token(Token = "0x60004E4")]
		[global::Cpp2ILInjected.Address(RVA = "0x19B6BC4", Offset = "0x19B6BC4", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private static int CombineHashCodes(int h1, int h2)
		{
			throw null;
		}

		// Token: 0x060004D1 RID: 1233 RVA: 0x00002EA0 File Offset: 0x000010A0
		[global::Cpp2ILInjected.Token(Token = "0x60004E5")]
		[global::Cpp2ILInjected.Address(RVA = "0x19B6BD0", Offset = "0x19B6BD0", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(bool), Member = "GetHashCode", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ushort), Member = "GetHashCode", ReturnType = typeof(int))]
		public override int GetHashCode()
		{
			throw null;
		}

		// Token: 0x060004D2 RID: 1234 RVA: 0x00002EA3 File Offset: 0x000010A3
		[global::Cpp2ILInjected.Token(Token = "0x60004E6")]
		[global::Cpp2ILInjected.Address(RVA = "0x19B6C08", Offset = "0x19B6C08", Length = "0x94")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ushort), Member = "ToString", MemberParameters = new object[] { typeof(IFormatProvider) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public override string ToString()
		{
			throw null;
		}

		// Token: 0x060004D3 RID: 1235 RVA: 0x00002EA6 File Offset: 0x000010A6
		[global::Cpp2ILInjected.Token(Token = "0x60004E7")]
		[global::Cpp2ILInjected.Address(RVA = "0x19B6C9C", Offset = "0x19B6C9C", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 592)]
		public static implicit operator OptionalUInt16(ushort value)
		{
			throw null;
		}

		// Token: 0x060004D4 RID: 1236 RVA: 0x00002EA9 File Offset: 0x000010A9
		[global::Cpp2ILInjected.Token(Token = "0x60004E8")]
		[global::Cpp2ILInjected.Address(RVA = "0x19B6CAC", Offset = "0x19B6CAC", Length = "0x18")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(OptionalUInt16), Member = "get_Value", ReturnType = typeof(ushort))]
		public static explicit operator ushort(OptionalUInt16 optional)
		{
			throw null;
		}

		// Token: 0x0400039F RID: 927
		[SerializeField]
		[global::Cpp2ILInjected.Token(Token = "0x40003EC")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private bool hasValue;

		// Token: 0x040003A0 RID: 928
		[SerializeField]
		[global::Cpp2ILInjected.Token(Token = "0x40003ED")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x2")]
		private ushort value;
	}
}
