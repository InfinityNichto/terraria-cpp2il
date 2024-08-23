using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks.Sources;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Threading.Tasks
{
	// Token: 0x020001AE RID: 430
	[global::System.Runtime.CompilerServices.AsyncMethodBuilder(typeof(global::System.Runtime.CompilerServices.AsyncValueTaskMethodBuilder<>))]
	[global::Cpp2ILInjected.Token(Token = "0x2000220")]
	[StructLayout(3)]
	public readonly struct ValueTask<TResult> : global::System.IEquatable<ValueTask<TResult>>
	{
		// Token: 0x06001178 RID: 4472 RVA: 0x000175EE File Offset: 0x000157EE
		[global::Cpp2ILInjected.Token(Token = "0x60012FE")]
		[global::Cpp2ILInjected.Address(RVA = "0x18AC9AC", Offset = "0x18AC9AC", Length = "0x18")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[MethodImpl(256)]
		public ValueTask(TResult result)
		{
			throw null;
		}

		// Token: 0x06001179 RID: 4473 RVA: 0x000175F1 File Offset: 0x000157F1
		[global::Cpp2ILInjected.Token(Token = "0x60012FF")]
		[global::Cpp2ILInjected.Address(RVA = "0x18AC9C4", Offset = "0x18AC9C4", Length = "0x3C")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ThrowHelper), Member = "ThrowArgumentNullException", MemberParameters = new object[] { typeof(global::System.ExceptionArgument) }, ReturnType = typeof(void))]
		[MethodImpl(256)]
		public ValueTask(Task<TResult> task)
		{
			throw null;
		}

		// Token: 0x0600117A RID: 4474 RVA: 0x000175F4 File Offset: 0x000157F4
		[global::Cpp2ILInjected.Token(Token = "0x6001300")]
		[global::Cpp2ILInjected.Address(RVA = "0x18ACA00", Offset = "0x18ACA00", Length = "0x40")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ThrowHelper), Member = "ThrowArgumentNullException", MemberParameters = new object[] { typeof(global::System.ExceptionArgument) }, ReturnType = typeof(void))]
		[MethodImpl(256)]
		public ValueTask(global::System.Threading.Tasks.Sources.IValueTaskSource<TResult> source, short token)
		{
			throw null;
		}

		// Token: 0x0600117B RID: 4475 RVA: 0x000175F7 File Offset: 0x000157F7
		[global::Cpp2ILInjected.Token(Token = "0x6001301")]
		[global::Cpp2ILInjected.Address(RVA = "0x18ACA40", Offset = "0x18ACA40", Length = "0x18")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[MethodImpl(256)]
		private ValueTask(object obj, TResult result, short token, bool continueOnCapturedContext)
		{
			throw null;
		}

		// Token: 0x0600117C RID: 4476 RVA: 0x000175FA File Offset: 0x000157FA
		[global::Cpp2ILInjected.Token(Token = "0x6001302")]
		[global::Cpp2ILInjected.Address(RVA = "0x18ACA58", Offset = "0x18ACA58", Length = "0x54")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(int), Member = "GetHashCode", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public override int GetHashCode()
		{
			throw null;
		}

		// Token: 0x0600117D RID: 4477 RVA: 0x000175FD File Offset: 0x000157FD
		[global::Cpp2ILInjected.Token(Token = "0x6001303")]
		[global::Cpp2ILInjected.Address(RVA = "0x18ACAAC", Offset = "0x18ACAAC", Length = "0xE4")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public override bool Equals(object obj)
		{
			throw null;
		}

		// Token: 0x0600117E RID: 4478 RVA: 0x00017600 File Offset: 0x00015800
		[global::Cpp2ILInjected.Token(Token = "0x6001304")]
		[global::Cpp2ILInjected.Address(RVA = "0x18ACB90", Offset = "0x18ACB90", Length = "0xB8")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public bool Equals(ValueTask<TResult> other)
		{
			throw null;
		}

		// Token: 0x0600117F RID: 4479 RVA: 0x00017603 File Offset: 0x00015803
		[global::Cpp2ILInjected.Token(Token = "0x6001305")]
		[global::Cpp2ILInjected.Address(RVA = "0x18ACC48", Offset = "0x18ACC48", Length = "0x144")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.Sockets.NetworkStream", Member = "ReadAsync", MemberParameters = new object[]
		{
			"System.Byte[]",
			typeof(int),
			typeof(int),
			typeof(CancellationToken)
		}, ReturnType = "System.Threading.Tasks.Task`1<Int32>")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
		public Task<TResult> AsTask()
		{
			throw null;
		}

		// Token: 0x06001180 RID: 4480 RVA: 0x00017606 File Offset: 0x00015806
		[global::Cpp2ILInjected.Token(Token = "0x6001306")]
		[global::Cpp2ILInjected.Address(RVA = "0x18ACD8C", Offset = "0x18ACD8C", Length = "0x530")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CancellationToken), Member = ".ctor", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Task), Member = "TrySetCanceled", MemberParameters = new object[]
		{
			typeof(CancellationToken),
			typeof(object)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 45)]
		private Task<TResult> GetTaskForValueTaskSource(global::System.Threading.Tasks.Sources.IValueTaskSource<TResult> t)
		{
			throw null;
		}

		// Token: 0x1700018B RID: 395
		// (get) Token: 0x06001181 RID: 4481 RVA: 0x00017609 File Offset: 0x00015809
		[global::Cpp2ILInjected.Token(Token = "0x170001CC")]
		public bool IsCompleted
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001307")]
			[global::Cpp2ILInjected.Address(RVA = "0x18AD2BC", Offset = "0x18AD2BC", Length = "0x11C")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Task), Member = "get_IsCompleted", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
			[MethodImpl(256)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700018C RID: 396
		// (get) Token: 0x06001182 RID: 4482 RVA: 0x0001760C File Offset: 0x0001580C
		[global::Cpp2ILInjected.Token(Token = "0x170001CD")]
		public bool IsCompletedSuccessfully
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001308")]
			[global::Cpp2ILInjected.Address(RVA = "0x18AD3D8", Offset = "0x18AD3D8", Length = "0x11C")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Task), Member = "get_IsCompletedSuccessfully", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
			[MethodImpl(256)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700018D RID: 397
		// (get) Token: 0x06001183 RID: 4483 RVA: 0x0001760F File Offset: 0x0001580F
		[global::Cpp2ILInjected.Token(Token = "0x170001CE")]
		public TResult Result
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001309")]
			[global::Cpp2ILInjected.Address(RVA = "0x18AD4F4", Offset = "0x18AD4F4", Length = "0x184")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.CompilerServices.TaskAwaiter), Member = "ValidateEnd", MemberParameters = new object[] { typeof(Task) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
			[MethodImpl(256)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06001184 RID: 4484 RVA: 0x00017612 File Offset: 0x00015812
		[global::Cpp2ILInjected.Token(Token = "0x600130A")]
		[global::Cpp2ILInjected.Address(RVA = "0x18AD678", Offset = "0x18AD678", Length = "0x34")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		[MethodImpl(256)]
		public global::System.Runtime.CompilerServices.ValueTaskAwaiter<TResult> GetAwaiter()
		{
			throw null;
		}

		// Token: 0x06001185 RID: 4485 RVA: 0x00017615 File Offset: 0x00015815
		[global::Cpp2ILInjected.Token(Token = "0x600130B")]
		[global::Cpp2ILInjected.Address(RVA = "0x18AD6AC", Offset = "0x18AD6AC", Length = "0x68")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		[MethodImpl(256)]
		public global::System.Runtime.CompilerServices.ConfiguredValueTaskAwaitable<TResult> ConfigureAwait(bool continueOnCapturedContext)
		{
			throw null;
		}

		// Token: 0x06001186 RID: 4486 RVA: 0x00017618 File Offset: 0x00015818
		[global::Cpp2ILInjected.Token(Token = "0x600130C")]
		[global::Cpp2ILInjected.Address(RVA = "0x18AD714", Offset = "0x18AD714", Length = "0xC8")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(int), Member = "ToString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		public override string ToString()
		{
			throw null;
		}

		// Token: 0x040007E5 RID: 2021
		[global::Cpp2ILInjected.Token(Token = "0x4000A2A")]
		private static Task<TResult> s_canceledTask;

		// Token: 0x040007E6 RID: 2022
		[global::Cpp2ILInjected.Token(Token = "0x4000A2B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		internal readonly object _obj;

		// Token: 0x040007E7 RID: 2023
		[global::Cpp2ILInjected.Token(Token = "0x4000A2C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		internal readonly TResult _result;

		// Token: 0x040007E8 RID: 2024
		[global::Cpp2ILInjected.Token(Token = "0x4000A2D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		internal readonly short _token;

		// Token: 0x040007E9 RID: 2025
		[global::Cpp2ILInjected.Token(Token = "0x4000A2E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		internal readonly bool _continueOnCapturedContext;

		// Token: 0x020005BE RID: 1470
		[global::Cpp2ILInjected.Token(Token = "0x2000221")]
		private sealed class ValueTaskSourceAsTask : Task<TResult>
		{
			// Token: 0x06004060 RID: 16480 RVA: 0x0001FBD1 File Offset: 0x0001DDD1
			[global::Cpp2ILInjected.Token(Token = "0x600130D")]
			[global::Cpp2ILInjected.Address(RVA = "0x18AC52C", Offset = "0x18AC52C", Length = "0x110")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
			public ValueTaskSourceAsTask(global::System.Threading.Tasks.Sources.IValueTaskSource<TResult> source, short token)
			{
				throw null;
			}

			// Token: 0x06004061 RID: 16481 RVA: 0x0001FBD4 File Offset: 0x0001DDD4
			// Note: this type is marked as 'beforefieldinit'.
			[global::Cpp2ILInjected.Token(Token = "0x600130E")]
			[global::Cpp2ILInjected.Address(RVA = "0x18AC63C", Offset = "0x18AC63C", Length = "0x130")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Action<object>), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(object),
				typeof(global::System.IntPtr)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 12)]
			static ValueTaskSourceAsTask()
			{
				throw null;
			}

			// Token: 0x040018CE RID: 6350
			[global::Cpp2ILInjected.Token(Token = "0x4000A2F")]
			private static readonly global::System.Action<object> s_completionAction;

			// Token: 0x040018CF RID: 6351
			[global::Cpp2ILInjected.Token(Token = "0x4000A30")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			private global::System.Threading.Tasks.Sources.IValueTaskSource<TResult> _source;

			// Token: 0x040018D0 RID: 6352
			[global::Cpp2ILInjected.Token(Token = "0x4000A31")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			private readonly short _token;

			// Token: 0x020006B0 RID: 1712
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x2000222")]
			[global::System.Serializable]
			private sealed class <>c
			{
				// Token: 0x06004373 RID: 17267 RVA: 0x000204A7 File Offset: 0x0001E6A7
				// Note: this type is marked as 'beforefieldinit'.
				[global::Cpp2ILInjected.Token(Token = "0x600130F")]
				[global::Cpp2ILInjected.Address(RVA = "0x15AFCC4", Offset = "0x15AFCC4", Length = "0xEC")]
				[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
				[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
				static <>c()
				{
					throw null;
				}

				// Token: 0x06004374 RID: 17268 RVA: 0x000204AA File Offset: 0x0001E6AA
				[global::Cpp2ILInjected.Token(Token = "0x6001310")]
				[global::Cpp2ILInjected.Address(RVA = "0x15AFDB0", Offset = "0x15AFDB0", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
				public <>c()
				{
					throw null;
				}

				// Token: 0x06004375 RID: 17269 RVA: 0x000204AD File Offset: 0x0001E6AD
				[global::Cpp2ILInjected.Token(Token = "0x6001311")]
				[global::Cpp2ILInjected.Address(RVA = "0x15AFDB8", Offset = "0x15AFDB8", Length = "0x2B8")]
				[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
				[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException", MemberParameters = new object[] { typeof(global::System.ExceptionArgument) }, ReturnType = typeof(void))]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CancellationToken), Member = ".ctor", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Task), Member = "TrySetCanceled", MemberParameters = new object[] { typeof(CancellationToken) }, ReturnType = typeof(bool))]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Task), Member = "TrySetException", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(bool))]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Task), Member = "TrySetCanceled", MemberParameters = new object[]
				{
					typeof(CancellationToken),
					typeof(object)
				}, ReturnType = typeof(bool))]
				[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 15)]
				internal void <.cctor>b__4_0(object state)
				{
					throw null;
				}

				// Token: 0x04001B3E RID: 6974
				[global::Cpp2ILInjected.Token(Token = "0x4000A32")]
				public static readonly ValueTask<TResult>.ValueTaskSourceAsTask.<>c <>9;
			}
		}
	}
}
