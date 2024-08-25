using System;
using System.Threading.Tasks;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Runtime.CompilerServices
{
	[global::Cpp2ILInjected.Token(Token = "0x2000491")]
	internal static class AsyncTaskCache
	{
		[global::Cpp2ILInjected.Token(Token = "0x6002271")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B74D18", Offset = "0x1B74D18", Length = "0xF4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AsyncTaskCache), Member = ".cctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsyncTaskCache[]), Member = "CreateCacheableTask", MemberTypeParameters = new object[] { typeof(int) }, MemberParameters = new object[] { typeof(int) }, ReturnType = "System.Threading.Tasks.Task`1<TResult>")]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		private static global::System.Threading.Tasks.Task<int>[] CreateInt32Tasks()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6002272")]
		[global::Cpp2ILInjected.Address(RVA = "0x157211C", Offset = "0x157211C", Length = "0x68")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		internal static global::System.Threading.Tasks.Task<TResult> CreateCacheableTask<TResult>(TResult result)
		{
			throw null;
		}

		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x6002273")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B74E0C", Offset = "0x1B74E0C", Length = "0x90")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsyncTaskCache[]), Member = "CreateCacheableTask", MemberTypeParameters = new object[] { typeof(bool) }, MemberParameters = new object[] { typeof(bool) }, ReturnType = "System.Threading.Tasks.Task`1<TResult>")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsyncTaskCache), Member = "CreateInt32Tasks", ReturnType = typeof(global::System.Threading.Tasks.Task<int>[]))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		static AsyncTaskCache()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x40012CF")]
		internal static readonly global::System.Threading.Tasks.Task<bool> TrueTask;

		[global::Cpp2ILInjected.Token(Token = "0x40012D0")]
		internal static readonly global::System.Threading.Tasks.Task<bool> FalseTask;

		[global::Cpp2ILInjected.Token(Token = "0x40012D1")]
		internal static readonly global::System.Threading.Tasks.Task<int>[] Int32Tasks;
	}
}
