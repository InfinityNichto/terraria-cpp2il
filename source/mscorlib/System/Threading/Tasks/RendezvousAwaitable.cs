﻿using System;
using System.Runtime.CompilerServices;
using System.Runtime.ExceptionServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Threading.Tasks
{
	[global::Cpp2ILInjected.Token(Token = "0x2000227")]
	internal class RendezvousAwaitable<TResult> : global::System.Runtime.CompilerServices.ICriticalNotifyCompletion
	{
		[global::Cpp2ILInjected.Token(Token = "0x170001D0")]
		public bool RunContinuationsAsynchronously
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x600131D")]
			[global::Cpp2ILInjected.Address(RVA = "0x1862964", Offset = "0x1862964", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x600131E")]
			[global::Cpp2ILInjected.Address(RVA = "0x186296C", Offset = "0x186296C", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x600131F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1862978", Offset = "0x1862978", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.WebClient.<GetWebResponseTaskAsync>d__112", Member = "MoveNext", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		public RendezvousAwaitable<TResult> GetAwaiter()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x170001D1")]
		public bool IsCompleted
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001320")]
			[global::Cpp2ILInjected.Address(RVA = "0x186297C", Offset = "0x186297C", Length = "0x1C")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.WebClient.<GetWebResponseTaskAsync>d__112", Member = "MoveNext", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001321")]
		[global::Cpp2ILInjected.Address(RVA = "0x1862998", Offset = "0x1862998", Length = "0x30")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.WebClient.<GetWebResponseTaskAsync>d__112", Member = "MoveNext", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.ExceptionServices.ExceptionDispatchInfo), Member = "Throw", ReturnType = typeof(void))]
		public TResult GetResult()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001322")]
		[global::Cpp2ILInjected.Address(RVA = "0x18629C8", Offset = "0x18629C8", Length = "0x18")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Threading.Tasks.BeginEndAwaitableAdapter.<>c", Member = "<.cctor>b__2_0", MemberParameters = new object[] { typeof(global::System.IAsyncResult) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public void SetResult(TResult result)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001323")]
		[global::Cpp2ILInjected.Address(RVA = "0x18629E0", Offset = "0x18629E0", Length = "0x110")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Task), Member = "Run", MemberParameters = new object[] { typeof(global::System.Action) }, ReturnType = typeof(Task))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		private void NotifyAwaiter()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001324")]
		[global::Cpp2ILInjected.Address(RVA = "0x1862AF0", Offset = "0x1862AF0", Length = "0x84")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Task), Member = "Run", MemberParameters = new object[] { typeof(global::System.Action) }, ReturnType = typeof(Task))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public void OnCompleted(global::System.Action continuation)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001325")]
		[global::Cpp2ILInjected.Address(RVA = "0x1862B74", Offset = "0x1862B74", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public void UnsafeOnCompleted(global::System.Action continuation)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001326")]
		[global::Cpp2ILInjected.Address(RVA = "0x1862B88", Offset = "0x1862B88", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BeginEndAwaitableAdapter), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public RendezvousAwaitable()
		{
			throw null;
		}

		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x6001327")]
		[global::Cpp2ILInjected.Address(RVA = "0x1862B98", Offset = "0x1862B98", Length = "0x130")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Action), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(global::System.IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 12)]
		static RendezvousAwaitable()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x4000A36")]
		private static readonly global::System.Action s_completionSentinel;

		[global::Cpp2ILInjected.Token(Token = "0x4000A37")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private global::System.Action _continuation;

		[global::Cpp2ILInjected.Token(Token = "0x4000A38")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private global::System.Runtime.ExceptionServices.ExceptionDispatchInfo _error;

		[global::Cpp2ILInjected.Token(Token = "0x4000A39")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private TResult _result;

		[global::System.Runtime.CompilerServices.CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x4000A3A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private bool <RunContinuationsAsynchronously>k__BackingField;

		[global::System.Runtime.CompilerServices.CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x2000228")]
		[global::System.Serializable]
		private sealed class <>c
		{
			// Note: this type is marked as 'beforefieldinit'.
			[global::Cpp2ILInjected.Token(Token = "0x6001328")]
			[global::Cpp2ILInjected.Address(RVA = "0x15B016C", Offset = "0x15B016C", Length = "0xEC")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
			static <>c()
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6001329")]
			[global::Cpp2ILInjected.Address(RVA = "0x15B0258", Offset = "0x15B0258", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public <>c()
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x600132A")]
			[global::Cpp2ILInjected.Address(RVA = "0x15B0260", Offset = "0x15B0260", Length = "0x4")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			internal void <.cctor>b__20_0()
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x4000A3B")]
			public static readonly RendezvousAwaitable<TResult>.<>c <>9;
		}
	}
}
