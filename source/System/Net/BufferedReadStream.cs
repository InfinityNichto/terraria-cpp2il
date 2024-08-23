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
	// Token: 0x02000187 RID: 391
	[global::Cpp2ILInjected.Token(Token = "0x2000230")]
	internal class BufferedReadStream : WebReadStream
	{
		// Token: 0x06000CAE RID: 3246 RVA: 0x00005252 File Offset: 0x00003452
		[global::Cpp2ILInjected.Token(Token = "0x6000E15")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F3EECC", Offset = "0x1F3EECC", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.WebResponseStream.<ReadAllAsync>d__48", Member = "MoveNext", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebResponseStream), Member = "Initialize", MemberParameters = new object[] { typeof(BufferOffsetSize) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebReadStream), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(WebOperation),
			typeof(Stream)
		}, ReturnType = typeof(void))]
		public BufferedReadStream(WebOperation operation, Stream innerStream, BufferOffsetSize readBuffer)
		{
			throw null;
		}

		// Token: 0x06000CAF RID: 3247 RVA: 0x00005255 File Offset: 0x00003455
		[global::Cpp2ILInjected.Token(Token = "0x6000E16")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F3EEF4", Offset = "0x1F3EEF4", Length = "0x128")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsyncTaskMethodBuilder<int>), Member = "Create", ReturnType = "System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<TResult>")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsyncTaskMethodBuilder<int>), Member = "Start", MemberTypeParameters = new object[] { typeof(BufferedReadStream.<ProcessReadAsync>d__2) }, MemberParameters = new object[] { typeof(ref BufferedReadStream.<ProcessReadAsync>d__2) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsyncTaskMethodBuilder<int>), Member = "get_Task", ReturnType = "System.Threading.Tasks.Task`1<TResult>")]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		protected override Task<int> ProcessReadAsync(byte[] buffer, int offset, int size, CancellationToken cancellationToken)
		{
			throw null;
		}

		// Token: 0x06000CB0 RID: 3248 RVA: 0x00005258 File Offset: 0x00003458
		[global::Cpp2ILInjected.Token(Token = "0x6000E17")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F3F01C", Offset = "0x1F3F01C", Length = "0x88")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebResponseStream), Member = "TryReadFromBufferedContent", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int),
			typeof(int),
			typeof(ref int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Buffer), Member = "BlockCopy", MemberParameters = new object[]
		{
			typeof(Array),
			typeof(int),
			typeof(Array),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		internal bool TryReadFromBuffer(byte[] buffer, int offset, int size, out int result)
		{
			throw null;
		}

		// Token: 0x0400091A RID: 2330
		[global::Cpp2ILInjected.Token(Token = "0x4000BB2")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
		private readonly BufferOffsetSize readBuffer;

		// Token: 0x0200040D RID: 1037
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x2000231")]
		[StructLayout(3)]
		private struct <ProcessReadAsync>d__2 : IAsyncStateMachine
		{
			// Token: 0x06001E06 RID: 7686 RVA: 0x000082E5 File Offset: 0x000064E5
			[global::Cpp2ILInjected.Token(Token = "0x6000E18")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F3F0A4", Offset = "0x1F3F0A4", Length = "0x290")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CancellationToken), Member = "ThrowIfCancellationRequested", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Buffer), Member = "BlockCopy", MemberParameters = new object[]
			{
				typeof(Array),
				typeof(int),
				typeof(Array),
				typeof(int),
				typeof(int)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Task<int>), Member = "ConfigureAwait", MemberParameters = new object[] { typeof(bool) }, ReturnType = "System.Runtime.CompilerServices.ConfiguredTaskAwaitable`1<TResult>")]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ConfiguredTaskAwaitable<int>.ConfiguredTaskAwaiter), Member = "get_IsCompleted", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsyncTaskMethodBuilder<int>), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new object[]
			{
				typeof(ConfiguredTaskAwaitable<int>.ConfiguredTaskAwaiter),
				typeof(BufferedReadStream.<ProcessReadAsync>d__2)
			}, MemberParameters = new object[]
			{
				typeof(ref ConfiguredTaskAwaitable<int>.ConfiguredTaskAwaiter),
				typeof(ref BufferedReadStream.<ProcessReadAsync>d__2)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ConfiguredTaskAwaitable<int>.ConfiguredTaskAwaiter), Member = "GetResult", ReturnType = "TResult")]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsyncTaskMethodBuilder<int>), Member = "SetResult", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsyncTaskMethodBuilder<int>), Member = "SetException", MemberParameters = new object[] { typeof(Exception) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 16)]
			private void MoveNext()
			{
				throw null;
			}

			// Token: 0x06001E07 RID: 7687 RVA: 0x000082E8 File Offset: 0x000064E8
			[DebuggerHidden]
			[global::Cpp2ILInjected.Token(Token = "0x6000E19")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F3F334", Offset = "0x1F3F334", Length = "0x58")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsyncTaskMethodBuilder<int>), Member = "SetStateMachine", MemberParameters = new object[] { typeof(IAsyncStateMachine) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				throw null;
			}

			// Token: 0x04001221 RID: 4641
			[global::Cpp2ILInjected.Token(Token = "0x4000BB3")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			public int <>1__state;

			// Token: 0x04001222 RID: 4642
			[global::Cpp2ILInjected.Token(Token = "0x4000BB4")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x8")]
			public AsyncTaskMethodBuilder<int> <>t__builder;

			// Token: 0x04001223 RID: 4643
			[global::Cpp2ILInjected.Token(Token = "0x4000BB5")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
			public CancellationToken cancellationToken;

			// Token: 0x04001224 RID: 4644
			[global::Cpp2ILInjected.Token(Token = "0x4000BB6")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
			public BufferedReadStream <>4__this;

			// Token: 0x04001225 RID: 4645
			[global::Cpp2ILInjected.Token(Token = "0x4000BB7")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
			public int size;

			// Token: 0x04001226 RID: 4646
			[global::Cpp2ILInjected.Token(Token = "0x4000BB8")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
			public byte[] buffer;

			// Token: 0x04001227 RID: 4647
			[global::Cpp2ILInjected.Token(Token = "0x4000BB9")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
			public int offset;

			// Token: 0x04001228 RID: 4648
			[global::Cpp2ILInjected.Token(Token = "0x4000BBA")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
			private ConfiguredTaskAwaitable<int>.ConfiguredTaskAwaiter <>u__1;
		}
	}
}
