using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks.Sources;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Threading.Tasks
{
	[global::System.Runtime.CompilerServices.AsyncMethodBuilder(typeof(global::System.Runtime.CompilerServices.AsyncValueTaskMethodBuilder))]
	[global::Cpp2ILInjected.Token(Token = "0x200021D")]
	[StructLayout(3)]
	public readonly struct ValueTask : global::System.IEquatable<ValueTask>
	{
		[global::Cpp2ILInjected.Token(Token = "0x170001CA")]
		internal static Task CompletedTask
		{
			[global::Cpp2ILInjected.Token(Token = "0x60012EB")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CA3C10", Offset = "0x1CA3C10", Length = "0x88")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ValueTask), Member = "AsTask", ReturnType = typeof(Task))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ValueTask), Member = "GetTaskForValueTaskSource", MemberParameters = new object[] { typeof(global::System.Threading.Tasks.Sources.IValueTaskSource) }, ReturnType = typeof(Task))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.CompilerServices.ConfiguredValueTaskAwaitable.ConfiguredValueTaskAwaiter), Member = "UnsafeOnCompleted", MemberParameters = new object[] { typeof(global::System.Action) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.CompilerServices.ConfiguredValueTaskAwaitable<>.ConfiguredValueTaskAwaiter), Member = "UnsafeOnCompleted", MemberParameters = new object[] { typeof(global::System.Action) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.CompilerServices.ValueTaskAwaiter), Member = "UnsafeOnCompleted", MemberParameters = new object[] { typeof(global::System.Action) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.CompilerServices.ValueTaskAwaiter<>), Member = "UnsafeOnCompleted", MemberParameters = new object[] { typeof(global::System.Action) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 6)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x60012EC")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CA3C98", Offset = "0x1CA3C98", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ThrowHelper), Member = "ThrowArgumentNullException", MemberParameters = new object[] { typeof(global::System.ExceptionArgument) }, ReturnType = typeof(void))]
		[MethodImpl(256)]
		public ValueTask(Task task)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60012ED")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CA3CD0", Offset = "0x1CA3CD0", Length = "0x3C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ThrowHelper), Member = "ThrowArgumentNullException", MemberParameters = new object[] { typeof(global::System.ExceptionArgument) }, ReturnType = typeof(void))]
		[MethodImpl(256)]
		public ValueTask(global::System.Threading.Tasks.Sources.IValueTaskSource source, short token)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60012EE")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CA3D0C", Offset = "0x1CA3D0C", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[MethodImpl(256)]
		private ValueTask(object obj, short token, bool continueOnCapturedContext)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60012EF")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CA3D20", Offset = "0x1CA3D20", Length = "0x18")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public override int GetHashCode()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60012F0")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CA3D38", Offset = "0x1CA3D38", Length = "0x88")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public override bool Equals(object obj)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60012F1")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CA3DC0", Offset = "0x1CA3DC0", Length = "0x24")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public bool Equals(ValueTask other)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60012F2")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CA3DE4", Offset = "0x1CA3DE4", Length = "0xB8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.Sockets.NetworkStream", Member = "WriteAsync", MemberParameters = new object[]
		{
			"System.Byte[]",
			typeof(int),
			typeof(int),
			typeof(CancellationToken)
		}, ReturnType = typeof(Task))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ValueTask), Member = "get_CompletedTask", ReturnType = typeof(Task))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public Task AsTask()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60012F3")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CA3E9C", Offset = "0x1CA3E9C", Length = "0x2C8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ValueTask.ValueTaskSourceAsTask), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(global::System.Threading.Tasks.Sources.IValueTaskSource),
			typeof(short)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ValueTask), Member = "get_CompletedTask", ReturnType = typeof(Task))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Task), Member = "FromException", MemberParameters = new object[] { typeof(global::System.Exception) }, ReturnType = typeof(Task))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Task<VoidTaskResult>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Task), Member = "TrySetCanceled", MemberParameters = new object[]
		{
			typeof(CancellationToken),
			typeof(object)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 25)]
		private Task GetTaskForValueTaskSource(global::System.Threading.Tasks.Sources.IValueTaskSource t)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x170001CB")]
		public bool IsCompleted
		{
			[global::Cpp2ILInjected.Token(Token = "0x60012F4")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CA433C", Offset = "0x1CA433C", Length = "0x104")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Task), Member = "get_IsCompleted", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			[MethodImpl(256)]
			get
			{
				throw null;
			}
		}

		[global::System.Diagnostics.StackTraceHidden]
		[global::Cpp2ILInjected.Token(Token = "0x60012F5")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CA4440", Offset = "0x1CA4440", Length = "0x104")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.CompilerServices.TaskAwaiter), Member = "ValidateEnd", MemberParameters = new object[] { typeof(Task) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		[MethodImpl(256)]
		internal void ThrowIfCompletedUnsuccessfully()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60012F6")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CA4544", Offset = "0x1CA4544", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Security.Cryptography.CryptoStream.<WriteAsyncCore>d__49", Member = "MoveNext", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		public global::System.Runtime.CompilerServices.ValueTaskAwaiter GetAwaiter()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60012F7")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CA4550", Offset = "0x1CA4550", Length = "0x18")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[MethodImpl(256)]
		public global::System.Runtime.CompilerServices.ConfiguredValueTaskAwaitable ConfigureAwait(bool continueOnCapturedContext)
		{
			throw null;
		}

		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x60012F8")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CA4568", Offset = "0x1CA4568", Length = "0x88")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CancellationToken), Member = ".ctor", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Task), Member = "FromCanceled", MemberParameters = new object[] { typeof(CancellationToken) }, ReturnType = typeof(Task))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		static ValueTask()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x4000A22")]
		private static readonly Task s_canceledTask;

		[global::Cpp2ILInjected.Token(Token = "0x4000A23")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		internal readonly object _obj;

		[global::Cpp2ILInjected.Token(Token = "0x4000A24")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x8")]
		internal readonly short _token;

		[global::Cpp2ILInjected.Token(Token = "0x4000A25")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xA")]
		internal readonly bool _continueOnCapturedContext;

		[global::Cpp2ILInjected.Token(Token = "0x200021E")]
		private sealed class ValueTaskSourceAsTask : Task<VoidTaskResult>
		{
			[global::Cpp2ILInjected.Token(Token = "0x60012F9")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CA4224", Offset = "0x1CA4224", Length = "0x118")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ValueTask), Member = "GetTaskForValueTaskSource", MemberParameters = new object[] { typeof(global::System.Threading.Tasks.Sources.IValueTaskSource) }, ReturnType = typeof(Task))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Task<VoidTaskResult>), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
			public ValueTaskSourceAsTask(global::System.Threading.Tasks.Sources.IValueTaskSource source, short token)
			{
				throw null;
			}

			// Note: this type is marked as 'beforefieldinit'.
			[global::Cpp2ILInjected.Token(Token = "0x60012FA")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CA4644", Offset = "0x1CA4644", Length = "0xC4")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Action<object>), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(object),
				typeof(global::System.IntPtr)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
			static ValueTaskSourceAsTask()
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x4000A26")]
			private static readonly global::System.Action<object> s_completionAction;

			[global::Cpp2ILInjected.Token(Token = "0x4000A27")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x58")]
			private global::System.Threading.Tasks.Sources.IValueTaskSource _source;

			[global::Cpp2ILInjected.Token(Token = "0x4000A28")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x60")]
			private readonly short _token;

			[global::System.Runtime.CompilerServices.CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x200021F")]
			[global::System.Serializable]
			private sealed class <>c
			{
				// Note: this type is marked as 'beforefieldinit'.
				[global::Cpp2ILInjected.Token(Token = "0x60012FB")]
				[global::Cpp2ILInjected.Address(RVA = "0x1CA4708", Offset = "0x1CA4708", Length = "0x5C")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
				[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
				static <>c()
				{
					throw null;
				}

				[global::Cpp2ILInjected.Token(Token = "0x60012FC")]
				[global::Cpp2ILInjected.Address(RVA = "0x1CA4764", Offset = "0x1CA4764", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
				public <>c()
				{
					throw null;
				}

				[global::Cpp2ILInjected.Token(Token = "0x60012FD")]
				[global::Cpp2ILInjected.Address(RVA = "0x1CA476C", Offset = "0x1CA476C", Length = "0x2A4")]
				[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException", MemberParameters = new object[] { typeof(global::System.ExceptionArgument) }, ReturnType = typeof(void))]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Task<VoidTaskResult>), Member = "TrySetResult", MemberParameters = new object[] { typeof(VoidTaskResult) }, ReturnType = typeof(bool))]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CancellationToken), Member = ".ctor", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Task), Member = "TrySetCanceled", MemberParameters = new object[]
				{
					typeof(CancellationToken),
					typeof(object)
				}, ReturnType = typeof(bool))]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Task), Member = "TrySetException", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(bool))]
				[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 15)]
				internal void <.cctor>b__4_0(object state)
				{
					throw null;
				}

				[global::Cpp2ILInjected.Token(Token = "0x4000A29")]
				public static readonly ValueTask.ValueTaskSourceAsTask.<>c <>9;
			}
		}
	}
}
