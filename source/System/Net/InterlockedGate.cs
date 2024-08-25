using System;
using System.Threading;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Net
{
	[global::Cpp2ILInjected.Token(Token = "0x20001A2")]
	internal struct InterlockedGate
	{
		[global::Cpp2ILInjected.Token(Token = "0x6000A83")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F0ED28", Offset = "0x1F0ED28", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		internal void Reset()
		{
			throw null;
		}

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

		[global::Cpp2ILInjected.Token(Token = "0x400085C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private int m_State;

		[global::Cpp2ILInjected.Token(Token = "0x400085D")]
		internal const int Open = 0;

		[global::Cpp2ILInjected.Token(Token = "0x400085E")]
		internal const int Triggering = 1;

		[global::Cpp2ILInjected.Token(Token = "0x400085F")]
		internal const int Triggered = 2;

		[global::Cpp2ILInjected.Token(Token = "0x4000860")]
		internal const int Signaling = 3;

		[global::Cpp2ILInjected.Token(Token = "0x4000861")]
		internal const int Signaled = 4;

		[global::Cpp2ILInjected.Token(Token = "0x4000862")]
		internal const int Completed = 5;
	}
}
