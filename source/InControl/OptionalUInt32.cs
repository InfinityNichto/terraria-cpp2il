using System;
using System.Globalization;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using InControl.NativeDeviceProfiles;
using UnityEngine;

namespace InControl
{
	// Token: 0x0200005F RID: 95
	[global::Cpp2ILInjected.Token(Token = "0x200006A")]
	[Serializable]
	public struct OptionalUInt32
	{
		// Token: 0x060004D5 RID: 1237 RVA: 0x00002EAC File Offset: 0x000010AC
		[global::Cpp2ILInjected.Token(Token = "0x60004E9")]
		[global::Cpp2ILInjected.Address(RVA = "0x19B6CC4", Offset = "0x19B6CC4", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public OptionalUInt32(uint value)
		{
			throw null;
		}

		// Token: 0x1700015D RID: 349
		// (get) Token: 0x060004D6 RID: 1238 RVA: 0x00002EAF File Offset: 0x000010AF
		[global::Cpp2ILInjected.Token(Token = "0x1700015F")]
		public bool HasValue
		{
			[global::Cpp2ILInjected.Token(Token = "0x60004EA")]
			[global::Cpp2ILInjected.Address(RVA = "0x19B6CD4", Offset = "0x19B6CD4", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700015E RID: 350
		// (get) Token: 0x060004D7 RID: 1239 RVA: 0x00002EB2 File Offset: 0x000010B2
		[global::Cpp2ILInjected.Token(Token = "0x17000160")]
		public bool HasNoValue
		{
			[global::Cpp2ILInjected.Token(Token = "0x60004EB")]
			[global::Cpp2ILInjected.Address(RVA = "0x19B6CDC", Offset = "0x19B6CDC", Length = "0x10")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700015F RID: 351
		// (get) Token: 0x060004D8 RID: 1240 RVA: 0x00002EB5 File Offset: 0x000010B5
		// (set) Token: 0x060004D9 RID: 1241 RVA: 0x00002EB8 File Offset: 0x000010B8
		[global::Cpp2ILInjected.Token(Token = "0x17000161")]
		public uint Value
		{
			[global::Cpp2ILInjected.Token(Token = "0x60004EC")]
			[global::Cpp2ILInjected.Address(RVA = "0x19B6CEC", Offset = "0x19B6CEC", Length = "0x5C")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(InputDeviceMatcher), Member = "Matches", MemberParameters = new object[] { typeof(InputDeviceInfo) }, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(OptionalUInt32), Member = "op_Explicit", MemberParameters = new object[] { typeof(OptionalUInt32) }, ReturnType = typeof(uint))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(OptionalTypeHasNoValueException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x60004ED")]
			[global::Cpp2ILInjected.Address(RVA = "0x19B6D48", Offset = "0x19B6D48", Length = "0x10")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x060004DA RID: 1242 RVA: 0x00002EBB File Offset: 0x000010BB
		[global::Cpp2ILInjected.Token(Token = "0x60004EE")]
		[global::Cpp2ILInjected.Address(RVA = "0x19B6D58", Offset = "0x19B6D58", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public void Clear()
		{
			throw null;
		}

		// Token: 0x060004DB RID: 1243 RVA: 0x00002EBE File Offset: 0x000010BE
		[global::Cpp2ILInjected.Token(Token = "0x60004EF")]
		[global::Cpp2ILInjected.Address(RVA = "0x19B6D64", Offset = "0x19B6D64", Length = "0x18")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public uint GetValueOrDefault(uint defaultValue)
		{
			throw null;
		}

		// Token: 0x060004DC RID: 1244 RVA: 0x00002EC1 File Offset: 0x000010C1
		[global::Cpp2ILInjected.Token(Token = "0x60004F0")]
		[global::Cpp2ILInjected.Address(RVA = "0x19B6D7C", Offset = "0x19B6D7C", Length = "0x18")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public uint GetValueOrZero()
		{
			throw null;
		}

		// Token: 0x060004DD RID: 1245 RVA: 0x00002EC4 File Offset: 0x000010C4
		[global::Cpp2ILInjected.Token(Token = "0x60004F1")]
		[global::Cpp2ILInjected.Address(RVA = "0x19B6D94", Offset = "0x19B6D94", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public void SetValue(uint value)
		{
			throw null;
		}

		// Token: 0x060004DE RID: 1246 RVA: 0x00002EC7 File Offset: 0x000010C7
		[global::Cpp2ILInjected.Token(Token = "0x60004F2")]
		[global::Cpp2ILInjected.Address(RVA = "0x19B6DA4", Offset = "0x19B6DA4", Length = "0x20")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(uint), Member = "Equals", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(bool))]
		public override bool Equals(object other)
		{
			throw null;
		}

		// Token: 0x060004DF RID: 1247 RVA: 0x00002ECA File Offset: 0x000010CA
		[global::Cpp2ILInjected.Token(Token = "0x60004F3")]
		[global::Cpp2ILInjected.Address(RVA = "0x19B6DC4", Offset = "0x19B6DC4", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public bool Equals(OptionalUInt32 other)
		{
			throw null;
		}

		// Token: 0x060004E0 RID: 1248 RVA: 0x00002ECD File Offset: 0x000010CD
		[global::Cpp2ILInjected.Token(Token = "0x60004F4")]
		[global::Cpp2ILInjected.Address(RVA = "0x19B6DEC", Offset = "0x19B6DEC", Length = "0x20")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public bool Equals(uint other)
		{
			throw null;
		}

		// Token: 0x060004E1 RID: 1249 RVA: 0x00002ED0 File Offset: 0x000010D0
		[global::Cpp2ILInjected.Token(Token = "0x60004F5")]
		[global::Cpp2ILInjected.Address(RVA = "0x19B6E0C", Offset = "0x19B6E0C", Length = "0x24")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public static bool operator ==(OptionalUInt32 a, OptionalUInt32 b)
		{
			throw null;
		}

		// Token: 0x060004E2 RID: 1250 RVA: 0x00002ED3 File Offset: 0x000010D3
		[global::Cpp2ILInjected.Token(Token = "0x60004F6")]
		[global::Cpp2ILInjected.Address(RVA = "0x19B6E30", Offset = "0x19B6E30", Length = "0x2C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public static bool operator !=(OptionalUInt32 a, OptionalUInt32 b)
		{
			throw null;
		}

		// Token: 0x060004E3 RID: 1251 RVA: 0x00002ED6 File Offset: 0x000010D6
		[global::Cpp2ILInjected.Token(Token = "0x60004F7")]
		[global::Cpp2ILInjected.Address(RVA = "0x19B6E5C", Offset = "0x19B6E5C", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public static bool operator ==(OptionalUInt32 a, uint b)
		{
			throw null;
		}

		// Token: 0x060004E4 RID: 1252 RVA: 0x00002ED9 File Offset: 0x000010D9
		[global::Cpp2ILInjected.Token(Token = "0x60004F8")]
		[global::Cpp2ILInjected.Address(RVA = "0x19B6E70", Offset = "0x19B6E70", Length = "0x1C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public static bool operator !=(OptionalUInt32 a, uint b)
		{
			throw null;
		}

		// Token: 0x060004E5 RID: 1253 RVA: 0x00002EDC File Offset: 0x000010DC
		[global::Cpp2ILInjected.Token(Token = "0x60004F9")]
		[global::Cpp2ILInjected.Address(RVA = "0x19B6E8C", Offset = "0x19B6E8C", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private static int CombineHashCodes(int h1, int h2)
		{
			throw null;
		}

		// Token: 0x060004E6 RID: 1254 RVA: 0x00002EDF File Offset: 0x000010DF
		[global::Cpp2ILInjected.Token(Token = "0x60004FA")]
		[global::Cpp2ILInjected.Address(RVA = "0x19B6E98", Offset = "0x19B6E98", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(bool), Member = "GetHashCode", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(uint), Member = "GetHashCode", ReturnType = typeof(int))]
		public override int GetHashCode()
		{
			throw null;
		}

		// Token: 0x060004E7 RID: 1255 RVA: 0x00002EE2 File Offset: 0x000010E2
		[global::Cpp2ILInjected.Token(Token = "0x60004FB")]
		[global::Cpp2ILInjected.Address(RVA = "0x19B6ED0", Offset = "0x19B6ED0", Length = "0x94")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(uint), Member = "ToString", MemberParameters = new object[] { typeof(IFormatProvider) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public override string ToString()
		{
			throw null;
		}

		// Token: 0x060004E8 RID: 1256 RVA: 0x00002EE5 File Offset: 0x000010E5
		[global::Cpp2ILInjected.Token(Token = "0x60004FC")]
		[global::Cpp2ILInjected.Address(RVA = "0x19B6F64", Offset = "0x19B6F64", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BuffaloClassicMacNativeProfile), Member = "Define", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AppleMFiExtendedGamepadNativeProfile), Member = "Define", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AppleMFiMicroGamepadNativeProfile), Member = "Define", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DualShock4MFiNativeProfile), Member = "Define", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XboxOneMFiNativeProfile), Member = "Define", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
		public static implicit operator OptionalUInt32(uint value)
		{
			throw null;
		}

		// Token: 0x060004E9 RID: 1257 RVA: 0x00002EE8 File Offset: 0x000010E8
		[global::Cpp2ILInjected.Token(Token = "0x60004FD")]
		[global::Cpp2ILInjected.Address(RVA = "0x19B6F74", Offset = "0x19B6F74", Length = "0x18")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(OptionalUInt32), Member = "get_Value", ReturnType = typeof(uint))]
		public static explicit operator uint(OptionalUInt32 optional)
		{
			throw null;
		}

		// Token: 0x040003A1 RID: 929
		[SerializeField]
		[global::Cpp2ILInjected.Token(Token = "0x40003EE")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private bool hasValue;

		// Token: 0x040003A2 RID: 930
		[SerializeField]
		[global::Cpp2ILInjected.Token(Token = "0x40003EF")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x4")]
		private uint value;
	}
}
