using System;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Net
{
	// Token: 0x020001A6 RID: 422
	[global::Cpp2ILInjected.Token(Token = "0x2000266")]
	internal class MonoChunkStream : WebReadStream
	{
		// Token: 0x17000397 RID: 919
		// (get) Token: 0x06000EED RID: 3821 RVA: 0x000058FA File Offset: 0x00003AFA
		[global::Cpp2ILInjected.Token(Token = "0x170003B5")]
		protected WebHeaderCollection Headers
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x600108B")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E02DBC", Offset = "0x1E02DBC", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000398 RID: 920
		// (get) Token: 0x06000EEE RID: 3822 RVA: 0x000058FD File Offset: 0x00003AFD
		[global::Cpp2ILInjected.Token(Token = "0x170003B6")]
		protected MonoChunkParser Decoder
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x600108C")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E02DC4", Offset = "0x1E02DC4", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06000EEF RID: 3823 RVA: 0x00005900 File Offset: 0x00003B00
		[global::Cpp2ILInjected.Token(Token = "0x600108D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E02DCC", Offset = "0x1E02DCC", Length = "0x8C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebResponseStream), Member = "Initialize", MemberParameters = new object[] { typeof(BufferOffsetSize) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebReadStream), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(WebOperation),
			typeof(Stream)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MonoChunkParser), Member = ".ctor", MemberParameters = new object[] { typeof(WebHeaderCollection) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public MonoChunkStream(WebOperation operation, Stream innerStream, WebHeaderCollection headers)
		{
			throw null;
		}

		// Token: 0x06000EF0 RID: 3824 RVA: 0x00005903 File Offset: 0x00003B03
		[global::Cpp2ILInjected.Token(Token = "0x600108E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E02E58", Offset = "0x1E02E58", Length = "0x124")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsyncTaskMethodBuilder<int>), Member = "Create", ReturnType = "System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<TResult>")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsyncTaskMethodBuilder<int>), Member = "Start", MemberTypeParameters = new object[] { typeof(MonoChunkStream.<ProcessReadAsync>d__7) }, MemberParameters = new object[] { typeof(ref MonoChunkStream.<ProcessReadAsync>d__7) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsyncTaskMethodBuilder<int>), Member = "get_Task", ReturnType = "System.Threading.Tasks.Task`1<TResult>")]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		protected override Task<int> ProcessReadAsync(byte[] buffer, int offset, int size, CancellationToken cancellationToken)
		{
			throw null;
		}

		// Token: 0x06000EF1 RID: 3825 RVA: 0x00005906 File Offset: 0x00003B06
		[global::Cpp2ILInjected.Token(Token = "0x600108F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E02F7C", Offset = "0x1E02F7C", Length = "0xE0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "Create", ReturnType = typeof(AsyncTaskMethodBuilder))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsyncTaskMethodBuilder[]), Member = "Start", MemberTypeParameters = new object[] { typeof(MonoChunkStream.<FinishReading>d__8) }, MemberParameters = new object[] { typeof(ref MonoChunkStream.<FinishReading>d__8) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "get_Task", ReturnType = typeof(Task))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		internal override Task FinishReading(CancellationToken cancellationToken)
		{
			throw null;
		}

		// Token: 0x06000EF2 RID: 3826 RVA: 0x00005909 File Offset: 0x00003B09
		[global::Cpp2ILInjected.Token(Token = "0x6001090")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E0305C", Offset = "0x1E0305C", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MonoChunkStream.<FinishReading>d__8), Member = "MoveNext", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(Exception),
			typeof(WebExceptionStatus),
			typeof(WebResponse)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		private static void ThrowExpectingChunkTrailer()
		{
			throw null;
		}

		// Token: 0x06000EF3 RID: 3827 RVA: 0x0000590C File Offset: 0x00003B0C
		[DebuggerHidden]
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x6001091")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E030B4", Offset = "0x1E030B4", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebReadStream), Member = "FinishReading", MemberParameters = new object[] { typeof(CancellationToken) }, ReturnType = typeof(Task))]
		private Task <>n__0(CancellationToken cancellationToken)
		{
			throw null;
		}

		// Token: 0x04000A15 RID: 2581
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x4000D07")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
		private readonly WebHeaderCollection <Headers>k__BackingField;

		// Token: 0x04000A16 RID: 2582
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x4000D08")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
		private readonly MonoChunkParser <Decoder>k__BackingField;

		// Token: 0x02000424 RID: 1060
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x2000267")]
		[StructLayout(3)]
		private struct <ProcessReadAsync>d__7 : IAsyncStateMachine
		{
			// Token: 0x06001E3D RID: 7741 RVA: 0x00008336 File Offset: 0x00006536
			[global::Cpp2ILInjected.Token(Token = "0x6001092")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E030BC", Offset = "0x1E030BC", Length = "0x304")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CancellationToken), Member = "ThrowIfCancellationRequested", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MonoChunkParser), Member = "get_DataAvailable", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MonoChunkParser), Member = "ReadFromChunks", MemberParameters = new object[]
			{
				typeof(byte[]),
				typeof(int),
				typeof(int)
			}, ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Task<int>), Member = "ConfigureAwait", MemberParameters = new object[] { typeof(bool) }, ReturnType = "System.Runtime.CompilerServices.ConfiguredTaskAwaitable`1<TResult>")]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ConfiguredTaskAwaitable<int>.ConfiguredTaskAwaiter), Member = "get_IsCompleted", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ConfiguredTaskAwaitable<int>.ConfiguredTaskAwaiter), Member = "GetResult", ReturnType = "TResult")]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MonoChunkParser), Member = "InternalWrite", MemberParameters = new object[]
			{
				typeof(byte[]),
				typeof(ref int),
				typeof(int)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsyncTaskMethodBuilder<int>), Member = "SetResult", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsyncTaskMethodBuilder<int>), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new object[]
			{
				typeof(ConfiguredTaskAwaitable<int>.ConfiguredTaskAwaiter),
				typeof(MonoChunkStream.<ProcessReadAsync>d__7)
			}, MemberParameters = new object[]
			{
				typeof(ref ConfiguredTaskAwaitable<int>.ConfiguredTaskAwaiter),
				typeof(ref MonoChunkStream.<ProcessReadAsync>d__7)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsyncTaskMethodBuilder<int>), Member = "SetException", MemberParameters = new object[] { typeof(Exception) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 18)]
			private void MoveNext()
			{
				throw null;
			}

			// Token: 0x06001E3E RID: 7742 RVA: 0x00008339 File Offset: 0x00006539
			[DebuggerHidden]
			[global::Cpp2ILInjected.Token(Token = "0x6001093")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E033C0", Offset = "0x1E033C0", Length = "0x58")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsyncTaskMethodBuilder<int>), Member = "SetStateMachine", MemberParameters = new object[] { typeof(IAsyncStateMachine) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				throw null;
			}

			// Token: 0x0400127B RID: 4731
			[global::Cpp2ILInjected.Token(Token = "0x4000D09")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			public int <>1__state;

			// Token: 0x0400127C RID: 4732
			[global::Cpp2ILInjected.Token(Token = "0x4000D0A")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x8")]
			public AsyncTaskMethodBuilder<int> <>t__builder;

			// Token: 0x0400127D RID: 4733
			[global::Cpp2ILInjected.Token(Token = "0x4000D0B")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
			public CancellationToken cancellationToken;

			// Token: 0x0400127E RID: 4734
			[global::Cpp2ILInjected.Token(Token = "0x4000D0C")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
			public MonoChunkStream <>4__this;

			// Token: 0x0400127F RID: 4735
			[global::Cpp2ILInjected.Token(Token = "0x4000D0D")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
			public byte[] buffer;

			// Token: 0x04001280 RID: 4736
			[global::Cpp2ILInjected.Token(Token = "0x4000D0E")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
			public int offset;

			// Token: 0x04001281 RID: 4737
			[global::Cpp2ILInjected.Token(Token = "0x4000D0F")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x3C")]
			public int size;

			// Token: 0x04001282 RID: 4738
			[global::Cpp2ILInjected.Token(Token = "0x4000D10")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
			private byte[] <moreBytes>5__2;

			// Token: 0x04001283 RID: 4739
			[global::Cpp2ILInjected.Token(Token = "0x4000D11")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
			private ConfiguredTaskAwaitable<int>.ConfiguredTaskAwaiter <>u__1;
		}

		// Token: 0x02000425 RID: 1061
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x2000268")]
		[StructLayout(3)]
		private struct <FinishReading>d__8 : IAsyncStateMachine
		{
			// Token: 0x06001E3F RID: 7743 RVA: 0x0000833C File Offset: 0x0000653C
			[global::Cpp2ILInjected.Token(Token = "0x6001094")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E03418", Offset = "0x1E03418", Length = "0x35C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebReadStream), Member = "FinishReading", MemberParameters = new object[] { typeof(CancellationToken) }, ReturnType = typeof(Task))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Task), Member = "ConfigureAwait", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(ConfiguredTaskAwaitable))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ConfiguredTaskAwaitable.ConfiguredTaskAwaiter), Member = "get_IsCompleted", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ConfiguredTaskAwaitable.ConfiguredTaskAwaiter), Member = "GetResult", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CancellationToken), Member = "ThrowIfCancellationRequested", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MonoChunkParser), Member = "get_DataAvailable", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MonoChunkStream), Member = "ThrowExpectingChunkTrailer", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsyncTaskMethodBuilder[]), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new object[]
			{
				typeof(ConfiguredTaskAwaitable.ConfiguredTaskAwaiter),
				typeof(MonoChunkStream.<FinishReading>d__8)
			}, MemberParameters = new object[]
			{
				typeof(ref ConfiguredTaskAwaitable.ConfiguredTaskAwaiter),
				typeof(ref MonoChunkStream.<FinishReading>d__8)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Task<int>), Member = "ConfigureAwait", MemberParameters = new object[] { typeof(bool) }, ReturnType = "System.Runtime.CompilerServices.ConfiguredTaskAwaitable`1<TResult>")]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ConfiguredTaskAwaitable<int>.ConfiguredTaskAwaiter), Member = "get_IsCompleted", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ConfiguredTaskAwaitable<int>.ConfiguredTaskAwaiter), Member = "GetResult", ReturnType = "TResult")]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MonoChunkParser), Member = "InternalWrite", MemberParameters = new object[]
			{
				typeof(byte[]),
				typeof(ref int),
				typeof(int)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MonoChunkParser), Member = "ReadFromChunks", MemberParameters = new object[]
			{
				typeof(byte[]),
				typeof(int),
				typeof(int)
			}, ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsyncTaskMethodBuilder[]), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new object[]
			{
				typeof(ConfiguredTaskAwaitable<int>.ConfiguredTaskAwaiter),
				typeof(MonoChunkStream.<FinishReading>d__8)
			}, MemberParameters = new object[]
			{
				typeof(ref ConfiguredTaskAwaitable<int>.ConfiguredTaskAwaiter),
				typeof(ref MonoChunkStream.<FinishReading>d__8)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetResult", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetException", MemberParameters = new object[] { typeof(Exception) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 17)]
			private void MoveNext()
			{
				throw null;
			}

			// Token: 0x06001E40 RID: 7744 RVA: 0x0000833F File Offset: 0x0000653F
			[DebuggerHidden]
			[global::Cpp2ILInjected.Token(Token = "0x6001095")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E03774", Offset = "0x1E03774", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetStateMachine", MemberParameters = new object[] { typeof(IAsyncStateMachine) }, ReturnType = typeof(void))]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				throw null;
			}

			// Token: 0x04001284 RID: 4740
			[global::Cpp2ILInjected.Token(Token = "0x4000D12")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			public int <>1__state;

			// Token: 0x04001285 RID: 4741
			[global::Cpp2ILInjected.Token(Token = "0x4000D13")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x8")]
			public AsyncTaskMethodBuilder <>t__builder;

			// Token: 0x04001286 RID: 4742
			[global::Cpp2ILInjected.Token(Token = "0x4000D14")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
			public MonoChunkStream <>4__this;

			// Token: 0x04001287 RID: 4743
			[global::Cpp2ILInjected.Token(Token = "0x4000D15")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
			public CancellationToken cancellationToken;

			// Token: 0x04001288 RID: 4744
			[global::Cpp2ILInjected.Token(Token = "0x4000D16")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
			private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter <>u__1;

			// Token: 0x04001289 RID: 4745
			[global::Cpp2ILInjected.Token(Token = "0x4000D17")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
			private byte[] <buffer>5__2;

			// Token: 0x0400128A RID: 4746
			[global::Cpp2ILInjected.Token(Token = "0x4000D18")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
			private ConfiguredTaskAwaitable<int>.ConfiguredTaskAwaiter <>u__2;
		}
	}
}
