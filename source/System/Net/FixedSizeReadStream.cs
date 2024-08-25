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
	[global::Cpp2ILInjected.Token(Token = "0x2000244")]
	internal class FixedSizeReadStream : WebReadStream
	{
		[global::Cpp2ILInjected.Token(Token = "0x17000306")]
		public long ContentLength
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6000EA6")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F49214", Offset = "0x1F49214", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000EA7")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F4921C", Offset = "0x1F4921C", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebResponseStream), Member = "Initialize", MemberParameters = new object[] { typeof(BufferOffsetSize) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebReadStream), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(WebOperation),
			typeof(Stream)
		}, ReturnType = typeof(void))]
		public FixedSizeReadStream(WebOperation operation, Stream innerStream, long contentLength)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000EA8")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F49244", Offset = "0x1F49244", Length = "0x128")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsyncTaskMethodBuilder<int>), Member = "Create", ReturnType = "System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<TResult>")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsyncTaskMethodBuilder<int>), Member = "Start", MemberTypeParameters = new object[] { typeof(FixedSizeReadStream.<ProcessReadAsync>d__5) }, MemberParameters = new object[] { typeof(ref FixedSizeReadStream.<ProcessReadAsync>d__5) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsyncTaskMethodBuilder<int>), Member = "get_Task", ReturnType = "System.Threading.Tasks.Task`1<TResult>")]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		protected override Task<int> ProcessReadAsync(byte[] buffer, int offset, int size, CancellationToken cancellationToken)
		{
			throw null;
		}

		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x4000BE9")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
		private readonly long <ContentLength>k__BackingField;

		[global::Cpp2ILInjected.Token(Token = "0x4000BEA")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
		private long position;

		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x2000245")]
		[StructLayout(3)]
		private struct <ProcessReadAsync>d__5 : IAsyncStateMachine
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000EA9")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F4936C", Offset = "0x1F4936C", Length = "0x280")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CancellationToken), Member = "ThrowIfCancellationRequested", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Math), Member = "Min", MemberParameters = new object[]
			{
				typeof(long),
				typeof(long)
			}, ReturnType = typeof(long))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Task<int>), Member = "ConfigureAwait", MemberParameters = new object[] { typeof(bool) }, ReturnType = "System.Runtime.CompilerServices.ConfiguredTaskAwaitable`1<TResult>")]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ConfiguredTaskAwaitable<int>.ConfiguredTaskAwaiter), Member = "get_IsCompleted", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsyncTaskMethodBuilder<int>), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new object[]
			{
				typeof(ConfiguredTaskAwaitable<int>.ConfiguredTaskAwaiter),
				typeof(FixedSizeReadStream.<ProcessReadAsync>d__5)
			}, MemberParameters = new object[]
			{
				typeof(ref ConfiguredTaskAwaitable<int>.ConfiguredTaskAwaiter),
				typeof(ref FixedSizeReadStream.<ProcessReadAsync>d__5)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ConfiguredTaskAwaitable<int>.ConfiguredTaskAwaiter), Member = "GetResult", ReturnType = "TResult")]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsyncTaskMethodBuilder<int>), Member = "SetResult", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsyncTaskMethodBuilder<int>), Member = "SetException", MemberParameters = new object[] { typeof(Exception) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 18)]
			private void MoveNext()
			{
				throw null;
			}

			[DebuggerHidden]
			[global::Cpp2ILInjected.Token(Token = "0x6000EAA")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F495EC", Offset = "0x1F495EC", Length = "0x58")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsyncTaskMethodBuilder<int>), Member = "SetStateMachine", MemberParameters = new object[] { typeof(IAsyncStateMachine) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x4000BEB")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			public int <>1__state;

			[global::Cpp2ILInjected.Token(Token = "0x4000BEC")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x8")]
			public AsyncTaskMethodBuilder<int> <>t__builder;

			[global::Cpp2ILInjected.Token(Token = "0x4000BED")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
			public CancellationToken cancellationToken;

			[global::Cpp2ILInjected.Token(Token = "0x4000BEE")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
			public FixedSizeReadStream <>4__this;

			[global::Cpp2ILInjected.Token(Token = "0x4000BEF")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
			public int size;

			[global::Cpp2ILInjected.Token(Token = "0x4000BF0")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
			public byte[] buffer;

			[global::Cpp2ILInjected.Token(Token = "0x4000BF1")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
			public int offset;

			[global::Cpp2ILInjected.Token(Token = "0x4000BF2")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
			private ConfiguredTaskAwaitable<int>.ConfiguredTaskAwaiter <>u__1;
		}
	}
}
