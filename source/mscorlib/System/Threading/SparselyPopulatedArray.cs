using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Threading
{
	// Token: 0x02000181 RID: 385
	[global::Cpp2ILInjected.Token(Token = "0x20001D9")]
	internal class SparselyPopulatedArray<T> where T : class
	{
		// Token: 0x06000FF1 RID: 4081 RVA: 0x00017228 File Offset: 0x00015428
		[global::Cpp2ILInjected.Token(Token = "0x600112F")]
		[global::Cpp2ILInjected.Address(RVA = "0x186EDBC", Offset = "0x186EDBC", Length = "0x68")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CancellationTokenSource), Member = "InternalRegister", MemberParameters = new object[]
		{
			typeof(global::System.Action<object>),
			typeof(object),
			typeof(SynchronizationContext),
			typeof(ExecutionContext)
		}, ReturnType = typeof(CancellationTokenRegistration))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		internal SparselyPopulatedArray(int initialSize)
		{
			throw null;
		}

		// Token: 0x17000161 RID: 353
		// (get) Token: 0x06000FF2 RID: 4082 RVA: 0x0001722B File Offset: 0x0001542B
		[global::Cpp2ILInjected.Token(Token = "0x17000197")]
		internal SparselyPopulatedArrayFragment<T> Tail
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001130")]
			[global::Cpp2ILInjected.Address(RVA = "0x186EE24", Offset = "0x186EE24", Length = "0x18")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CancellationTokenSource), Member = "ExecuteCallbackHandlers", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06000FF3 RID: 4083 RVA: 0x0001722E File Offset: 0x0001542E
		[global::Cpp2ILInjected.Token(Token = "0x6001131")]
		[global::Cpp2ILInjected.Address(RVA = "0x186EE3C", Offset = "0x186EE3C", Length = "0x1E4")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CancellationTokenSource), Member = "InternalRegister", MemberParameters = new object[]
		{
			typeof(global::System.Action<object>),
			typeof(object),
			typeof(SynchronizationContext),
			typeof(ExecutionContext)
		}, ReturnType = typeof(CancellationTokenRegistration))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 21)]
		internal SparselyPopulatedArrayAddInfo<T> Add(T element)
		{
			throw null;
		}

		// Token: 0x0400073C RID: 1852
		[global::Cpp2ILInjected.Token(Token = "0x4000943")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private readonly SparselyPopulatedArrayFragment<T> _head;

		// Token: 0x0400073D RID: 1853
		[global::Cpp2ILInjected.Token(Token = "0x4000944")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private SparselyPopulatedArrayFragment<T> _tail;
	}
}
