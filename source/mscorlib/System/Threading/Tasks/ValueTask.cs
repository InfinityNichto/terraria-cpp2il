using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks.Sources;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Threading.Tasks
{
	// Token: 0x020001AD RID: 429
	[global::System.Runtime.CompilerServices.AsyncMethodBuilder(typeof(global::System.Runtime.CompilerServices.AsyncValueTaskMethodBuilder))]
	[global::Cpp2ILInjected.Token(Token = "0x200021D")]
	[StructLayout(3)]
	public readonly struct ValueTask : global::System.IEquatable<ValueTask>
	{
		// Token: 0x17000189 RID: 393
		// (get) Token: 0x0600116A RID: 4458 RVA: 0x000175C4 File Offset: 0x000157C4
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

		// Token: 0x0600116B RID: 4459 RVA: 0x000175C7 File Offset: 0x000157C7
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

		// Token: 0x0600116C RID: 4460 RVA: 0x000175CA File Offset: 0x000157CA
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

		// Token: 0x0600116D RID: 4461 RVA: 0x000175CD File Offset: 0x000157CD
		[global::Cpp2ILInjected.Token(Token = "0x60012EE")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CA3D0C", Offset = "0x1CA3D0C", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[MethodImpl(256)]
		private ValueTask(object obj, short token, bool continueOnCapturedContext)
		{
			throw null;
		}

		// Token: 0x0600116E RID: 4462 RVA: 0x000175D0 File Offset: 0x000157D0
		[global::Cpp2ILInjected.Token(Token = "0x60012EF")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CA3D20", Offset = "0x1CA3D20", Length = "0x18")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public override int GetHashCode()
		{
			throw null;
		}

		// Token: 0x0600116F RID: 4463 RVA: 0x000175D3 File Offset: 0x000157D3
		[global::Cpp2ILInjected.Token(Token = "0x60012F0")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CA3D38", Offset = "0x1CA3D38", Length = "0x88")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public override bool Equals(object obj)
		{
			throw null;
		}

		// Token: 0x06001170 RID: 4464 RVA: 0x000175D6 File Offset: 0x000157D6
		[global::Cpp2ILInjected.Token(Token = "0x60012F1")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CA3DC0", Offset = "0x1CA3DC0", Length = "0x24")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public bool Equals(ValueTask other)
		{
			throw null;
		}

		// Token: 0x06001171 RID: 4465 RVA: 0x000175D9 File Offset: 0x000157D9
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

		// Token: 0x06001172 RID: 4466 RVA: 0x000175DC File Offset: 0x000157DC
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

		// Token: 0x1700018A RID: 394
		// (get) Token: 0x06001173 RID: 4467 RVA: 0x000175DF File Offset: 0x000157DF
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

		// Token: 0x06001174 RID: 4468 RVA: 0x000175E2 File Offset: 0x000157E2
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

		// Token: 0x06001175 RID: 4469 RVA: 0x000175E5 File Offset: 0x000157E5
		[global::Cpp2ILInjected.Token(Token = "0x60012F6")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CA4544", Offset = "0x1CA4544", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Security.Cryptography.CryptoStream.<WriteAsyncCore>d__49", Member = "MoveNext", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		public global::System.Runtime.CompilerServices.ValueTaskAwaiter GetAwaiter()
		{
			throw null;
		}

		// Token: 0x06001176 RID: 4470 RVA: 0x000175E8 File Offset: 0x000157E8
		[global::Cpp2ILInjected.Token(Token = "0x60012F7")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CA4550", Offset = "0x1CA4550", Length = "0x18")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[MethodImpl(256)]
		public global::System.Runtime.CompilerServices.ConfiguredValueTaskAwaitable ConfigureAwait(bool continueOnCapturedContext)
		{
			throw null;
		}

		// Token: 0x06001177 RID: 4471 RVA: 0x000175EB File Offset: 0x000157EB
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

		// Token: 0x040007E1 RID: 2017
		[global::Cpp2ILInjected.Token(Token = "0x4000A22")]
		private static readonly Task s_canceledTask;

		// Token: 0x040007E2 RID: 2018
		[global::Cpp2ILInjected.Token(Token = "0x4000A23")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		internal readonly object _obj;

		// Token: 0x040007E3 RID: 2019
		[global::Cpp2ILInjected.Token(Token = "0x4000A24")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x8")]
		internal readonly short _token;

		// Token: 0x040007E4 RID: 2020
		[global::Cpp2ILInjected.Token(Token = "0x4000A25")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xA")]
		internal readonly bool _continueOnCapturedContext;

		// Token: 0x020005BD RID: 1469
		[global::Cpp2ILInjected.Token(Token = "0x200021E")]
		private sealed class ValueTaskSourceAsTask : Task<VoidTaskResult>
		{
			// Token: 0x0600405E RID: 16478 RVA: 0x0001FBCB File Offset: 0x0001DDCB
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

			// Token: 0x0600405F RID: 16479 RVA: 0x0001FBCE File Offset: 0x0001DDCE
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

			// Token: 0x040018CB RID: 6347
			[global::Cpp2ILInjected.Token(Token = "0x4000A26")]
			private static readonly global::System.Action<object> s_completionAction;

			// Token: 0x040018CC RID: 6348
			[global::Cpp2ILInjected.Token(Token = "0x4000A27")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x58")]
			private global::System.Threading.Tasks.Sources.IValueTaskSource _source;

			// Token: 0x040018CD RID: 6349
			[global::Cpp2ILInjected.Token(Token = "0x4000A28")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x60")]
			private readonly short _token;

			// Token: 0x020006AF RID: 1711
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x200021F")]
			[global::System.Serializable]
			private sealed class <>c
			{
				// Token: 0x06004370 RID: 17264 RVA: 0x0002049E File Offset: 0x0001E69E
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

				// Token: 0x06004371 RID: 17265 RVA: 0x000204A1 File Offset: 0x0001E6A1
				[global::Cpp2ILInjected.Token(Token = "0x60012FC")]
				[global::Cpp2ILInjected.Address(RVA = "0x1CA4764", Offset = "0x1CA4764", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
				public <>c()
				{
					throw null;
				}

				// Token: 0x06004372 RID: 17266 RVA: 0x000204A4 File Offset: 0x0001E6A4
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

				// Token: 0x04001B3D RID: 6973
				[global::Cpp2ILInjected.Token(Token = "0x4000A29")]
				public static readonly ValueTask.ValueTaskSourceAsTask.<>c <>9;
			}
		}
	}
}
