using System;
using System.Diagnostics;
using System.Threading.Tasks;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Runtime.CompilerServices
{
	[global::Cpp2ILInjected.Token(Token = "0x2000485")]
	public readonly struct ValueTaskAwaiter<TResult> : ICriticalNotifyCompletion
	{
		[global::Cpp2ILInjected.Token(Token = "0x6002236")]
		[global::Cpp2ILInjected.Address(RVA = "0x18ABFE8", Offset = "0x18ABFE8", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[MethodImpl(256)]
		internal ValueTaskAwaiter(global::System.Threading.Tasks.ValueTask<TResult> value)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000472")]
		public bool IsCompleted
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002237")]
			[global::Cpp2ILInjected.Address(RVA = "0x18ABFF0", Offset = "0x18ABFF0", Length = "0x34")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			[MethodImpl(256)]
			get
			{
				throw null;
			}
		}

		[global::System.Diagnostics.StackTraceHidden]
		[global::Cpp2ILInjected.Token(Token = "0x6002238")]
		[global::Cpp2ILInjected.Address(RVA = "0x18AC024", Offset = "0x18AC024", Length = "0x34")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		[MethodImpl(256)]
		public TResult GetResult()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6002239")]
		[global::Cpp2ILInjected.Address(RVA = "0x18AC058", Offset = "0x18AC058", Length = "0x22C")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Threading.Tasks.ValueTask), Member = "get_CompletedTask", ReturnType = typeof(global::System.Threading.Tasks.Task))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Threading.Tasks.Task), Member = "GetAwaiter", ReturnType = typeof(TaskAwaiter))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TaskAwaiter), Member = "UnsafeOnCompleted", MemberParameters = new object[] { typeof(global::System.Action) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TaskAwaiter<int>), Member = "UnsafeOnCompleted", MemberParameters = new object[] { typeof(global::System.Action) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 12)]
		public void UnsafeOnCompleted(global::System.Action continuation)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x40012BC")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private readonly global::System.Threading.Tasks.ValueTask<TResult> _value;
	}
}
