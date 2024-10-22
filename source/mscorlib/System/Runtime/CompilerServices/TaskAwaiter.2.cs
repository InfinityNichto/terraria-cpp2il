﻿using System;
using System.Diagnostics;
using System.Threading.Tasks;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Runtime.CompilerServices
{
	[global::Cpp2ILInjected.Token(Token = "0x2000488")]
	public readonly struct TaskAwaiter<TResult> : ICriticalNotifyCompletion
	{
		[global::Cpp2ILInjected.Token(Token = "0x6002245")]
		[global::Cpp2ILInjected.Address(RVA = "0x186FDEC", Offset = "0x186FDEC", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		internal TaskAwaiter(global::System.Threading.Tasks.Task<TResult> task)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000474")]
		public bool IsCompleted
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002246")]
			[global::Cpp2ILInjected.Address(RVA = "0x186FDF4", Offset = "0x186FDF4", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Threading.Tasks.Task), Member = "get_IsCompleted", ReturnType = typeof(bool))]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x6002247")]
		[global::Cpp2ILInjected.Address(RVA = "0x186FE00", Offset = "0x186FE00", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TaskAwaiter), Member = "OnCompletedInternal", MemberParameters = new object[]
		{
			typeof(global::System.Threading.Tasks.Task),
			typeof(global::System.Action),
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(void))]
		public void UnsafeOnCompleted(global::System.Action continuation)
		{
			throw null;
		}

		[global::System.Diagnostics.StackTraceHidden]
		[global::Cpp2ILInjected.Token(Token = "0x6002248")]
		[global::Cpp2ILInjected.Address(RVA = "0x186FE14", Offset = "0x186FE14", Length = "0x80")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TaskAwaiter), Member = "ValidateEnd", MemberParameters = new object[] { typeof(global::System.Threading.Tasks.Task) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public TResult GetResult()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x40012C0")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private readonly global::System.Threading.Tasks.Task<TResult> m_task;
	}
}
