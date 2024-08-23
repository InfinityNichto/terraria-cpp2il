using System;
using System.Threading;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Net
{
	// Token: 0x0200011B RID: 283
	[global::Cpp2ILInjected.Token(Token = "0x20001A2")]
	internal struct InterlockedGate
	{
		// Token: 0x06000974 RID: 2420 RVA: 0x000048FB File Offset: 0x00002AFB
		[global::Cpp2ILInjected.Token(Token = "0x6000A83")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F0ED28", Offset = "0x1F0ED28", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		internal void Reset()
		{
			throw null;
		}

		// Token: 0x06000975 RID: 2421 RVA: 0x000048FE File Offset: 0x00002AFE
		[global::Cpp2ILInjected.Token(Token = "0x6000A84")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F0ED30", Offset = "0x1F0ED30", Length = "0x68")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Interlocked), Member = "CompareExchange", MemberParameters = new object[]
		{
			typeof(ref int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InternalException), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		internal bool Trigger(bool exclusive)
		{
			throw null;
		}

		// Token: 0x06000976 RID: 2422 RVA: 0x00004901 File Offset: 0x00002B01
		[global::Cpp2ILInjected.Token(Token = "0x6000A85")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F0ED98", Offset = "0x1F0ED98", Length = "0x68")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Interlocked), Member = "CompareExchange", MemberParameters = new object[]
		{
			typeof(ref int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InternalException), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		internal bool StartTriggering(bool exclusive)
		{
			throw null;
		}

		// Token: 0x06000977 RID: 2423 RVA: 0x00004904 File Offset: 0x00002B04
		[global::Cpp2ILInjected.Token(Token = "0x6000A86")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F0EE00", Offset = "0x1F0EE00", Length = "0x54")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Interlocked), Member = "CompareExchange", MemberParameters = new object[]
		{
			typeof(ref int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InternalException), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		internal void FinishTriggering()
		{
			throw null;
		}

		// Token: 0x06000978 RID: 2424 RVA: 0x00004907 File Offset: 0x00002B07
		[global::Cpp2ILInjected.Token(Token = "0x6000A87")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F0EE54", Offset = "0x1F0EE54", Length = "0x68")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Interlocked), Member = "CompareExchange", MemberParameters = new object[]
		{
			typeof(ref int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InternalException), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		internal bool StartSignaling(bool exclusive)
		{
			throw null;
		}

		// Token: 0x06000979 RID: 2425 RVA: 0x0000490A File Offset: 0x00002B0A
		[global::Cpp2ILInjected.Token(Token = "0x6000A88")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F0EEBC", Offset = "0x1F0EEBC", Length = "0x54")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Interlocked), Member = "CompareExchange", MemberParameters = new object[]
		{
			typeof(ref int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InternalException), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		internal void FinishSignaling()
		{
			throw null;
		}

		// Token: 0x0600097A RID: 2426 RVA: 0x0000490D File Offset: 0x00002B0D
		[global::Cpp2ILInjected.Token(Token = "0x6000A89")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F0EF10", Offset = "0x1F0EF10", Length = "0x24")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Interlocked), Member = "CompareExchange", MemberParameters = new object[]
		{
			typeof(ref int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		internal bool Complete()
		{
			throw null;
		}

		// Token: 0x04000643 RID: 1603
		[global::Cpp2ILInjected.Token(Token = "0x400085C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private int m_State;

		// Token: 0x04000644 RID: 1604
		[global::Cpp2ILInjected.Token(Token = "0x400085D")]
		internal const int Open = 0;

		// Token: 0x04000645 RID: 1605
		[global::Cpp2ILInjected.Token(Token = "0x400085E")]
		internal const int Triggering = 1;

		// Token: 0x04000646 RID: 1606
		[global::Cpp2ILInjected.Token(Token = "0x400085F")]
		internal const int Triggered = 2;

		// Token: 0x04000647 RID: 1607
		[global::Cpp2ILInjected.Token(Token = "0x4000860")]
		internal const int Signaling = 3;

		// Token: 0x04000648 RID: 1608
		[global::Cpp2ILInjected.Token(Token = "0x4000861")]
		internal const int Signaled = 4;

		// Token: 0x04000649 RID: 1609
		[global::Cpp2ILInjected.Token(Token = "0x4000862")]
		internal const int Completed = 5;
	}
}
