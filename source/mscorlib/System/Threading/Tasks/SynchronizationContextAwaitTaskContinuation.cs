using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Threading.Tasks
{
	// Token: 0x020001C7 RID: 455
	[global::Cpp2ILInjected.Token(Token = "0x2000246")]
	internal sealed class SynchronizationContextAwaitTaskContinuation : AwaitTaskContinuation
	{
		// Token: 0x0600125D RID: 4701 RVA: 0x00017894 File Offset: 0x00015A94
		[global::Cpp2ILInjected.Token(Token = "0x600140A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CA9128", Offset = "0x1CA9128", Length = "0x30")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AwaitTaskContinuation), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(global::System.Action),
			typeof(bool)
		}, ReturnType = typeof(void))]
		internal SynchronizationContextAwaitTaskContinuation(SynchronizationContext context, global::System.Action action, bool flowExecutionContext)
		{
			throw null;
		}

		// Token: 0x0600125E RID: 4702 RVA: 0x00017897 File Offset: 0x00015A97
		[global::Cpp2ILInjected.Token(Token = "0x600140B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CACD88", Offset = "0x1CACD88", Length = "0x1E0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SynchronizationContext), Member = "get_Current", ReturnType = typeof(SynchronizationContext))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ContextCallback), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(global::System.IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 15)]
		internal sealed override void Run(Task ignored, bool canInlineContinuationTask)
		{
			throw null;
		}

		// Token: 0x0600125F RID: 4703 RVA: 0x0001789A File Offset: 0x00015A9A
		[global::Cpp2ILInjected.Token(Token = "0x600140C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CAD0DC", Offset = "0x1CAD0DC", Length = "0x8C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		private static void PostAction(object state)
		{
			throw null;
		}

		// Token: 0x06001260 RID: 4704 RVA: 0x0001789D File Offset: 0x00015A9D
		[global::Cpp2ILInjected.Token(Token = "0x600140D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CAD168", Offset = "0x1CAD168", Length = "0xC0")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ContextCallback), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(global::System.IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		[MethodImpl(256)]
		private static ContextCallback GetPostActionCallback()
		{
			throw null;
		}

		// Token: 0x06001261 RID: 4705 RVA: 0x000178A0 File Offset: 0x00015AA0
		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x600140E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CAD228", Offset = "0x1CAD228", Length = "0xC4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SendOrPostCallback), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(global::System.IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		static SynchronizationContextAwaitTaskContinuation()
		{
			throw null;
		}

		// Token: 0x04000843 RID: 2115
		[global::Cpp2ILInjected.Token(Token = "0x4000AAA")]
		private static readonly SendOrPostCallback s_postCallback;

		// Token: 0x04000844 RID: 2116
		[global::Cpp2ILInjected.Token(Token = "0x4000AAB")]
		private static ContextCallback s_postActionCallback;

		// Token: 0x04000845 RID: 2117
		[global::Cpp2ILInjected.Token(Token = "0x4000AAC")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private readonly SynchronizationContext m_syncContext;

		// Token: 0x020005CA RID: 1482
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x2000247")]
		[global::System.Serializable]
		private sealed class <>c
		{
			// Token: 0x06004084 RID: 16516 RVA: 0x0001FC3D File Offset: 0x0001DE3D
			// Note: this type is marked as 'beforefieldinit'.
			[global::Cpp2ILInjected.Token(Token = "0x600140F")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CAD2EC", Offset = "0x1CAD2EC", Length = "0x5C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			static <>c()
			{
				throw null;
			}

			// Token: 0x06004085 RID: 16517 RVA: 0x0001FC40 File Offset: 0x0001DE40
			[global::Cpp2ILInjected.Token(Token = "0x6001410")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CAD348", Offset = "0x1CAD348", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public <>c()
			{
				throw null;
			}

			// Token: 0x06004086 RID: 16518 RVA: 0x0001FC43 File Offset: 0x0001DE43
			[global::Cpp2ILInjected.Token(Token = "0x6001411")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CAD350", Offset = "0x1CAD350", Length = "0x68")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			internal void <.cctor>b__7_0(object state)
			{
				throw null;
			}

			// Token: 0x040018EF RID: 6383
			[global::Cpp2ILInjected.Token(Token = "0x4000AAD")]
			public static readonly SynchronizationContextAwaitTaskContinuation.<>c <>9;
		}
	}
}
