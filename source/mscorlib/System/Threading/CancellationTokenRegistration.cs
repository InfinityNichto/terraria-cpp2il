﻿using System;
using System.Threading.Tasks;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Threading
{
	// Token: 0x0200017D RID: 381
	[global::Cpp2ILInjected.Token(Token = "0x20001D0")]
	public readonly struct CancellationTokenRegistration : global::System.IEquatable<CancellationTokenRegistration>, global::System.IDisposable
	{
		// Token: 0x06000FCE RID: 4046 RVA: 0x000171BF File Offset: 0x000153BF
		[global::Cpp2ILInjected.Token(Token = "0x6001103")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C9654C", Offset = "0x1C9654C", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		internal CancellationTokenRegistration(CancellationCallbackInfo callbackInfo, SparselyPopulatedArrayAddInfo<CancellationCallbackInfo> registrationInfo)
		{
			throw null;
		}

		// Token: 0x06000FCF RID: 4047 RVA: 0x000171C2 File Offset: 0x000153C2
		[global::Cpp2ILInjected.Token(Token = "0x6001104")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C96558", Offset = "0x1C96558", Length = "0x7C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CancellationTokenRegistration), Member = "Dispose", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CancellationTokenSource), Member = "InternalRegister", MemberParameters = new object[]
		{
			typeof(global::System.Action<object>),
			typeof(object),
			typeof(SynchronizationContext),
			typeof(ExecutionContext)
		}, ReturnType = typeof(CancellationTokenRegistration))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SparselyPopulatedArrayFragment<>), Member = "SafeAtomicRemove", MemberParameters = new object[]
		{
			typeof(int),
			"T"
		}, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public bool Unregister()
		{
			throw null;
		}

		// Token: 0x06000FD0 RID: 4048 RVA: 0x000171C5 File Offset: 0x000153C5
		[global::Cpp2ILInjected.Token(Token = "0x6001105")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C965D4", Offset = "0x1C965D4", Length = "0x8C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ManualResetEventSlim), Member = "Wait", MemberParameters = new object[]
		{
			typeof(int),
			typeof(CancellationToken)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Threading.CancellationTokenSource.Linked1CancellationTokenSource", Member = "Dispose", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Threading.CancellationTokenSource.Linked2CancellationTokenSource", Member = "Dispose", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SemaphoreSlim), Member = "Wait", MemberParameters = new object[]
		{
			typeof(int),
			typeof(CancellationToken)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Threading.Tasks.Task.ContingentProperties), Member = "UnregisterCancellationCallback", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Threading.Tasks.Task.DelayPromise", Member = "Complete", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 10)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CancellationTokenRegistration), Member = "Unregister", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Environment), Member = "get_CurrentManagedThreadId", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CancellationTokenSource), Member = "WaitForCallbackToComplete", MemberParameters = new object[] { typeof(CancellationCallbackInfo) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public void Dispose()
		{
			throw null;
		}

		// Token: 0x06000FD1 RID: 4049 RVA: 0x000171C8 File Offset: 0x000153C8
		[global::Cpp2ILInjected.Token(Token = "0x6001106")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C966E0", Offset = "0x1C966E0", Length = "0x90")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CancellationTokenRegistration), Member = "Equals", MemberParameters = new object[] { typeof(CancellationTokenRegistration) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public override bool Equals(object obj)
		{
			throw null;
		}

		// Token: 0x06000FD2 RID: 4050 RVA: 0x000171CB File Offset: 0x000153CB
		[global::Cpp2ILInjected.Token(Token = "0x6001107")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C96770", Offset = "0x1C96770", Length = "0x80")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CancellationTokenRegistration), Member = "Equals", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public bool Equals(CancellationTokenRegistration other)
		{
			throw null;
		}

		// Token: 0x06000FD3 RID: 4051 RVA: 0x000171CE File Offset: 0x000153CE
		[global::Cpp2ILInjected.Token(Token = "0x6001108")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C967F0", Offset = "0x1C967F0", Length = "0x90")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(int), Member = "GetHashCode", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public override int GetHashCode()
		{
			throw null;
		}

		// Token: 0x04000728 RID: 1832
		[global::Cpp2ILInjected.Token(Token = "0x4000929")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private readonly CancellationCallbackInfo m_callbackInfo;

		// Token: 0x04000729 RID: 1833
		[global::Cpp2ILInjected.Token(Token = "0x400092A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x8")]
		private readonly SparselyPopulatedArrayAddInfo<CancellationCallbackInfo> m_registrationInfo;
	}
}