using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace InControl
{
	// Token: 0x02000021 RID: 33
	[global::Cpp2ILInjected.Token(Token = "0x2000022")]
	public struct InputControlState
	{
		// Token: 0x06000164 RID: 356 RVA: 0x0000247A File Offset: 0x0000067A
		[global::Cpp2ILInjected.Token(Token = "0x6000164")]
		[global::Cpp2ILInjected.Address(RVA = "0x1986A74", Offset = "0x1986A74", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public void Reset()
		{
			throw null;
		}

		// Token: 0x06000165 RID: 357 RVA: 0x0000247D File Offset: 0x0000067D
		[global::Cpp2ILInjected.Token(Token = "0x6000165")]
		[global::Cpp2ILInjected.Address(RVA = "0x1986A80", Offset = "0x1986A80", Length = "0x74")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utility), Member = "IsNotZero", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public void Set(float value)
		{
			throw null;
		}

		// Token: 0x06000166 RID: 358 RVA: 0x00002480 File Offset: 0x00000680
		[global::Cpp2ILInjected.Token(Token = "0x6000166")]
		[global::Cpp2ILInjected.Address(RVA = "0x1986AF4", Offset = "0x1986AF4", Length = "0x7C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(OneAxisInputControl), Member = "UpdateWithValue", MemberParameters = new object[]
		{
			typeof(float),
			typeof(ulong),
			typeof(float)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(OneAxisInputControl), Member = "UpdateWithRawValue", MemberParameters = new object[]
		{
			typeof(float),
			typeof(ulong),
			typeof(float)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(OneAxisInputControl), Member = "SetValue", MemberParameters = new object[]
		{
			typeof(float),
			typeof(ulong)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utility), Member = "AbsoluteIsOverThreshold", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public void Set(float value, float threshold)
		{
			throw null;
		}

		// Token: 0x06000167 RID: 359 RVA: 0x00002483 File Offset: 0x00000683
		[global::Cpp2ILInjected.Token(Token = "0x6000167")]
		[global::Cpp2ILInjected.Address(RVA = "0x1986B70", Offset = "0x1986B70", Length = "0x20")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public void Set(bool state)
		{
			throw null;
		}

		// Token: 0x06000168 RID: 360 RVA: 0x00002486 File Offset: 0x00000686
		[global::Cpp2ILInjected.Token(Token = "0x6000168")]
		[global::Cpp2ILInjected.Address(RVA = "0x1986B90", Offset = "0x1986B90", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public static implicit operator bool(InputControlState state)
		{
			throw null;
		}

		// Token: 0x06000169 RID: 361 RVA: 0x00002489 File Offset: 0x00000689
		[global::Cpp2ILInjected.Token(Token = "0x6000169")]
		[global::Cpp2ILInjected.Address(RVA = "0x1986B98", Offset = "0x1986B98", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public static implicit operator float(InputControlState state)
		{
			throw null;
		}

		// Token: 0x0600016A RID: 362 RVA: 0x0000248C File Offset: 0x0000068C
		[global::Cpp2ILInjected.Token(Token = "0x600016A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1986BA4", Offset = "0x1986BA4", Length = "0x94")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utility), Member = "Approximately", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static bool operator ==(InputControlState a, InputControlState b)
		{
			throw null;
		}

		// Token: 0x0600016B RID: 363 RVA: 0x0000248F File Offset: 0x0000068F
		[global::Cpp2ILInjected.Token(Token = "0x600016B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1986C38", Offset = "0x1986C38", Length = "0x94")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(OneAxisInputControl), Member = "Commit", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(OneAxisInputControl), Member = "get_HasChanged", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utility), Member = "Approximately", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static bool operator !=(InputControlState a, InputControlState b)
		{
			throw null;
		}

		// Token: 0x0400013D RID: 317
		[global::Cpp2ILInjected.Token(Token = "0x4000141")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		public bool State;

		// Token: 0x0400013E RID: 318
		[global::Cpp2ILInjected.Token(Token = "0x4000142")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x4")]
		public float Value;

		// Token: 0x0400013F RID: 319
		[global::Cpp2ILInjected.Token(Token = "0x4000143")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x8")]
		public float RawValue;
	}
}
