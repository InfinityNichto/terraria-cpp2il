using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Threading
{
	[global::Cpp2ILInjected.Token(Token = "0x20001D9")]
	internal class SparselyPopulatedArray<T> where T : class
	{
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

		[global::Cpp2ILInjected.Token(Token = "0x4000943")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private readonly SparselyPopulatedArrayFragment<T> _head;

		[global::Cpp2ILInjected.Token(Token = "0x4000944")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private SparselyPopulatedArrayFragment<T> _tail;
	}
}
