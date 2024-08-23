using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

namespace InControl
{
	// Token: 0x0200005B RID: 91
	[global::Cpp2ILInjected.Token(Token = "0x2000066")]
	[Serializable]
	public struct OptionalInputDeviceTransportType
	{
		// Token: 0x06000481 RID: 1153 RVA: 0x00002DB0 File Offset: 0x00000FB0
		[global::Cpp2ILInjected.Token(Token = "0x6000495")]
		[global::Cpp2ILInjected.Address(RVA = "0x19B6184", Offset = "0x19B6184", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public OptionalInputDeviceTransportType(InputDeviceTransportType value)
		{
			throw null;
		}

		// Token: 0x17000151 RID: 337
		// (get) Token: 0x06000482 RID: 1154 RVA: 0x00002DB3 File Offset: 0x00000FB3
		[global::Cpp2ILInjected.Token(Token = "0x17000153")]
		public bool HasValue
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000496")]
			[global::Cpp2ILInjected.Address(RVA = "0x19B6194", Offset = "0x19B6194", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000152 RID: 338
		// (get) Token: 0x06000483 RID: 1155 RVA: 0x00002DB6 File Offset: 0x00000FB6
		[global::Cpp2ILInjected.Token(Token = "0x17000154")]
		public bool HasNoValue
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000497")]
			[global::Cpp2ILInjected.Address(RVA = "0x19B619C", Offset = "0x19B619C", Length = "0x10")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000153 RID: 339
		// (get) Token: 0x06000484 RID: 1156 RVA: 0x00002DB9 File Offset: 0x00000FB9
		// (set) Token: 0x06000485 RID: 1157 RVA: 0x00002DBC File Offset: 0x00000FBC
		[global::Cpp2ILInjected.Token(Token = "0x17000155")]
		public InputDeviceTransportType Value
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000498")]
			[global::Cpp2ILInjected.Address(RVA = "0x19B61AC", Offset = "0x19B61AC", Length = "0x5C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(InputDeviceMatcher), Member = "Matches", MemberParameters = new object[] { typeof(InputDeviceInfo) }, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(OptionalInputDeviceTransportType), Member = "op_Explicit", MemberParameters = new object[] { typeof(OptionalInputDeviceTransportType) }, ReturnType = typeof(InputDeviceTransportType))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(OptionalTypeHasNoValueException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6000499")]
			[global::Cpp2ILInjected.Address(RVA = "0x19B6208", Offset = "0x19B6208", Length = "0x10")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x06000486 RID: 1158 RVA: 0x00002DBF File Offset: 0x00000FBF
		[global::Cpp2ILInjected.Token(Token = "0x600049A")]
		[global::Cpp2ILInjected.Address(RVA = "0x19B6218", Offset = "0x19B6218", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public void Clear()
		{
			throw null;
		}

		// Token: 0x06000487 RID: 1159 RVA: 0x00002DC2 File Offset: 0x00000FC2
		[global::Cpp2ILInjected.Token(Token = "0x600049B")]
		[global::Cpp2ILInjected.Address(RVA = "0x19B6224", Offset = "0x19B6224", Length = "0x18")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public InputDeviceTransportType GetValueOrDefault(InputDeviceTransportType defaultValue)
		{
			throw null;
		}

		// Token: 0x06000488 RID: 1160 RVA: 0x00002DC5 File Offset: 0x00000FC5
		[global::Cpp2ILInjected.Token(Token = "0x600049C")]
		[global::Cpp2ILInjected.Address(RVA = "0x19B623C", Offset = "0x19B623C", Length = "0x18")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public InputDeviceTransportType GetValueOrZero()
		{
			throw null;
		}

		// Token: 0x06000489 RID: 1161 RVA: 0x00002DC8 File Offset: 0x00000FC8
		[global::Cpp2ILInjected.Token(Token = "0x600049D")]
		[global::Cpp2ILInjected.Address(RVA = "0x19B6254", Offset = "0x19B6254", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public void SetValue(InputDeviceTransportType value)
		{
			throw null;
		}

		// Token: 0x0600048A RID: 1162 RVA: 0x00002DCB File Offset: 0x00000FCB
		[global::Cpp2ILInjected.Token(Token = "0x600049E")]
		[global::Cpp2ILInjected.Address(RVA = "0x19B6264", Offset = "0x19B6264", Length = "0x88")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Enum), Member = "Equals", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public override bool Equals(object other)
		{
			throw null;
		}

		// Token: 0x0600048B RID: 1163 RVA: 0x00002DCE File Offset: 0x00000FCE
		[global::Cpp2ILInjected.Token(Token = "0x600049F")]
		[global::Cpp2ILInjected.Address(RVA = "0x19B62EC", Offset = "0x19B62EC", Length = "0x24")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public bool Equals(OptionalInputDeviceTransportType other)
		{
			throw null;
		}

		// Token: 0x0600048C RID: 1164 RVA: 0x00002DD1 File Offset: 0x00000FD1
		[global::Cpp2ILInjected.Token(Token = "0x60004A0")]
		[global::Cpp2ILInjected.Address(RVA = "0x19B6310", Offset = "0x19B6310", Length = "0x20")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public bool Equals(InputDeviceTransportType other)
		{
			throw null;
		}

		// Token: 0x0600048D RID: 1165 RVA: 0x00002DD4 File Offset: 0x00000FD4
		[global::Cpp2ILInjected.Token(Token = "0x60004A1")]
		[global::Cpp2ILInjected.Address(RVA = "0x19B6330", Offset = "0x19B6330", Length = "0x18")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public static bool operator ==(OptionalInputDeviceTransportType a, OptionalInputDeviceTransportType b)
		{
			throw null;
		}

		// Token: 0x0600048E RID: 1166 RVA: 0x00002DD7 File Offset: 0x00000FD7
		[global::Cpp2ILInjected.Token(Token = "0x60004A2")]
		[global::Cpp2ILInjected.Address(RVA = "0x19B6348", Offset = "0x19B6348", Length = "0x24")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public static bool operator !=(OptionalInputDeviceTransportType a, OptionalInputDeviceTransportType b)
		{
			throw null;
		}

		// Token: 0x0600048F RID: 1167 RVA: 0x00002DDA File Offset: 0x00000FDA
		[global::Cpp2ILInjected.Token(Token = "0x60004A3")]
		[global::Cpp2ILInjected.Address(RVA = "0x19B636C", Offset = "0x19B636C", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public static bool operator ==(OptionalInputDeviceTransportType a, InputDeviceTransportType b)
		{
			throw null;
		}

		// Token: 0x06000490 RID: 1168 RVA: 0x00002DDD File Offset: 0x00000FDD
		[global::Cpp2ILInjected.Token(Token = "0x60004A4")]
		[global::Cpp2ILInjected.Address(RVA = "0x19B6380", Offset = "0x19B6380", Length = "0x1C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public static bool operator !=(OptionalInputDeviceTransportType a, InputDeviceTransportType b)
		{
			throw null;
		}

		// Token: 0x06000491 RID: 1169 RVA: 0x00002DE0 File Offset: 0x00000FE0
		[global::Cpp2ILInjected.Token(Token = "0x60004A5")]
		[global::Cpp2ILInjected.Address(RVA = "0x19B639C", Offset = "0x19B639C", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private static int CombineHashCodes(int h1, int h2)
		{
			throw null;
		}

		// Token: 0x06000492 RID: 1170 RVA: 0x00002DE3 File Offset: 0x00000FE3
		[global::Cpp2ILInjected.Token(Token = "0x60004A6")]
		[global::Cpp2ILInjected.Address(RVA = "0x19B63A8", Offset = "0x19B63A8", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(bool), Member = "GetHashCode", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ushort), Member = "GetHashCode", ReturnType = typeof(int))]
		public override int GetHashCode()
		{
			throw null;
		}

		// Token: 0x06000493 RID: 1171 RVA: 0x00002DE6 File Offset: 0x00000FE6
		[global::Cpp2ILInjected.Token(Token = "0x60004A7")]
		[global::Cpp2ILInjected.Address(RVA = "0x19B63E0", Offset = "0x19B63E0", Length = "0x8C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Enum), Member = "ToString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public override string ToString()
		{
			throw null;
		}

		// Token: 0x06000494 RID: 1172 RVA: 0x00002DE9 File Offset: 0x00000FE9
		[global::Cpp2ILInjected.Token(Token = "0x60004A8")]
		[global::Cpp2ILInjected.Address(RVA = "0x19B646C", Offset = "0x19B646C", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public static implicit operator OptionalInputDeviceTransportType(InputDeviceTransportType value)
		{
			throw null;
		}

		// Token: 0x06000495 RID: 1173 RVA: 0x00002DEC File Offset: 0x00000FEC
		[global::Cpp2ILInjected.Token(Token = "0x60004A9")]
		[global::Cpp2ILInjected.Address(RVA = "0x19B647C", Offset = "0x19B647C", Length = "0x18")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(OptionalInputDeviceTransportType), Member = "get_Value", ReturnType = typeof(InputDeviceTransportType))]
		public static explicit operator InputDeviceTransportType(OptionalInputDeviceTransportType optional)
		{
			throw null;
		}

		// Token: 0x04000399 RID: 921
		[SerializeField]
		[global::Cpp2ILInjected.Token(Token = "0x40003E6")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private bool hasValue;

		// Token: 0x0400039A RID: 922
		[SerializeField]
		[global::Cpp2ILInjected.Token(Token = "0x40003E7")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x2")]
		private InputDeviceTransportType value;
	}
}
