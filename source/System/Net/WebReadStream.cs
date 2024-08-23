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
	// Token: 0x020001B9 RID: 441
	[global::Cpp2ILInjected.Token(Token = "0x200028D")]
	internal abstract class WebReadStream : Stream
	{
		// Token: 0x17000401 RID: 1025
		// (get) Token: 0x06001038 RID: 4152 RVA: 0x00005CC9 File Offset: 0x00003EC9
		[global::Cpp2ILInjected.Token(Token = "0x17000429")]
		public WebOperation Operation
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6001213")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E15530", Offset = "0x1E15530", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000402 RID: 1026
		// (get) Token: 0x06001039 RID: 4153 RVA: 0x00005CCC File Offset: 0x00003ECC
		[global::Cpp2ILInjected.Token(Token = "0x1700042A")]
		protected Stream InnerStream
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6001214")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E15538", Offset = "0x1E15538", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000403 RID: 1027
		// (get) Token: 0x0600103A RID: 4154 RVA: 0x00005CCF File Offset: 0x00003ECF
		[global::Cpp2ILInjected.Token(Token = "0x1700042B")]
		internal string ME
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001215")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E15540", Offset = "0x1E15540", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0600103B RID: 4155 RVA: 0x00005CD2 File Offset: 0x00003ED2
		[global::Cpp2ILInjected.Token(Token = "0x6001216")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E15548", Offset = "0x1E15548", Length = "0x70")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BufferedReadStream), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(WebOperation),
			typeof(Stream),
			typeof(BufferOffsetSize)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ContentDecodeStream), Member = "Create", MemberParameters = new object[]
		{
			typeof(WebOperation),
			typeof(Stream),
			typeof(ContentDecodeStream.Mode)
		}, ReturnType = typeof(ContentDecodeStream))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ContentDecodeStream), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(WebOperation),
			typeof(Stream),
			typeof(Stream)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FixedSizeReadStream), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(WebOperation),
			typeof(Stream),
			typeof(long)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MonoChunkStream), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(WebOperation),
			typeof(Stream),
			typeof(WebHeaderCollection)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Stream), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public WebReadStream(WebOperation operation, Stream innerStream)
		{
			throw null;
		}

		// Token: 0x17000404 RID: 1028
		// (get) Token: 0x0600103C RID: 4156 RVA: 0x00005CD5 File Offset: 0x00003ED5
		[global::Cpp2ILInjected.Token(Token = "0x1700042C")]
		public override long Length
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001217")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E155B8", Offset = "0x1E155B8", Length = "0x38")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000405 RID: 1029
		// (get) Token: 0x0600103D RID: 4157 RVA: 0x00005CD8 File Offset: 0x00003ED8
		// (set) Token: 0x0600103E RID: 4158 RVA: 0x00005CDB File Offset: 0x00003EDB
		[global::Cpp2ILInjected.Token(Token = "0x1700042D")]
		public override long Position
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001218")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E155F0", Offset = "0x1E155F0", Length = "0x38")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6001219")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E15628", Offset = "0x1E15628", Length = "0x38")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
			set
			{
				throw null;
			}
		}

		// Token: 0x17000406 RID: 1030
		// (get) Token: 0x0600103F RID: 4159 RVA: 0x00005CDE File Offset: 0x00003EDE
		[global::Cpp2ILInjected.Token(Token = "0x1700042E")]
		public override bool CanSeek
		{
			[global::Cpp2ILInjected.Token(Token = "0x600121A")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E15660", Offset = "0x1E15660", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000407 RID: 1031
		// (get) Token: 0x06001040 RID: 4160 RVA: 0x00005CE1 File Offset: 0x00003EE1
		[global::Cpp2ILInjected.Token(Token = "0x1700042F")]
		public override bool CanRead
		{
			[global::Cpp2ILInjected.Token(Token = "0x600121B")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E15668", Offset = "0x1E15668", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000408 RID: 1032
		// (get) Token: 0x06001041 RID: 4161 RVA: 0x00005CE4 File Offset: 0x00003EE4
		[global::Cpp2ILInjected.Token(Token = "0x17000430")]
		public override bool CanWrite
		{
			[global::Cpp2ILInjected.Token(Token = "0x600121C")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E15670", Offset = "0x1E15670", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06001042 RID: 4162 RVA: 0x00005CE7 File Offset: 0x00003EE7
		[global::Cpp2ILInjected.Token(Token = "0x600121D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E15678", Offset = "0x1E15678", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public override void SetLength(long value)
		{
			throw null;
		}

		// Token: 0x06001043 RID: 4163 RVA: 0x00005CEA File Offset: 0x00003EEA
		[global::Cpp2ILInjected.Token(Token = "0x600121E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E156B0", Offset = "0x1E156B0", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public override long Seek(long offset, SeekOrigin origin)
		{
			throw null;
		}

		// Token: 0x06001044 RID: 4164 RVA: 0x00005CED File Offset: 0x00003EED
		[global::Cpp2ILInjected.Token(Token = "0x600121F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E156E8", Offset = "0x1E156E8", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public override void Write(byte[] buffer, int offset, int count)
		{
			throw null;
		}

		// Token: 0x06001045 RID: 4165 RVA: 0x00005CF0 File Offset: 0x00003EF0
		[global::Cpp2ILInjected.Token(Token = "0x6001220")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E15720", Offset = "0x1E15720", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public override void Flush()
		{
			throw null;
		}

		// Token: 0x06001046 RID: 4166 RVA: 0x00005CF3 File Offset: 0x00003EF3
		[global::Cpp2ILInjected.Token(Token = "0x6001221")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E15758", Offset = "0x1E15758", Length = "0x160")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebReadStream), Member = "Read", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebReadStream), Member = "EndRead", MemberParameters = new object[] { typeof(IAsyncResult) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HttpWebRequest), Member = "FlattenException", MemberParameters = new object[] { typeof(Exception) }, ReturnType = typeof(Exception))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebOperation), Member = "get_Aborted", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HttpWebRequest), Member = "CreateRequestAbortedException", ReturnType = typeof(WebException))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		protected Exception GetException(Exception e)
		{
			throw null;
		}

		// Token: 0x06001047 RID: 4167 RVA: 0x00005CF6 File Offset: 0x00003EF6
		[global::Cpp2ILInjected.Token(Token = "0x6001222")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E158B8", Offset = "0x1E158B8", Length = "0x248")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebOperation), Member = "ThrowIfClosedOrDisposed", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CancellationToken), Member = "get_None", ReturnType = typeof(CancellationToken))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Task<int>), Member = "get_Result", ReturnType = "TResult")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NotSupportedException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebReadStream), Member = "GetException", MemberParameters = new object[] { typeof(Exception) }, ReturnType = typeof(Exception))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 25)]
		public override int Read(byte[] buffer, int offset, int size)
		{
			throw null;
		}

		// Token: 0x06001048 RID: 4168 RVA: 0x00005CF9 File Offset: 0x00003EF9
		[global::Cpp2ILInjected.Token(Token = "0x6001223")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E15B00", Offset = "0x1E15B00", Length = "0x1B8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebOperation), Member = "ThrowIfClosedOrDisposed", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CancellationToken), Member = "get_None", ReturnType = typeof(CancellationToken))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "System.Threading.Tasks.TaskToApm", Member = "Begin", MemberParameters = new object[]
		{
			typeof(Task),
			typeof(AsyncCallback),
			typeof(object)
		}, ReturnType = typeof(IAsyncResult))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NotSupportedException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 15)]
		public override IAsyncResult BeginRead(byte[] buffer, int offset, int size, AsyncCallback cb, object state)
		{
			throw null;
		}

		// Token: 0x06001049 RID: 4169 RVA: 0x00005CFC File Offset: 0x00003EFC
		[global::Cpp2ILInjected.Token(Token = "0x6001224")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E15CB8", Offset = "0x1E15CB8", Length = "0x120")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "System.Threading.Tasks.TaskToApm", Member = "End", MemberTypeParameters = new object[] { "TResult" }, MemberParameters = new object[] { typeof(IAsyncResult) }, ReturnType = "TResult")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebReadStream), Member = "GetException", MemberParameters = new object[] { typeof(Exception) }, ReturnType = typeof(Exception))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 15)]
		public override int EndRead(IAsyncResult r)
		{
			throw null;
		}

		// Token: 0x0600104A RID: 4170 RVA: 0x00005CFF File Offset: 0x00003EFF
		[global::Cpp2ILInjected.Token(Token = "0x6001225")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E15DD8", Offset = "0x1E15DD8", Length = "0x120")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsyncTaskMethodBuilder<int>), Member = "Create", ReturnType = "System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1<TResult>")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsyncTaskMethodBuilder<int>), Member = "Start", MemberTypeParameters = new object[] { typeof(WebReadStream.<ReadAsync>d__28) }, MemberParameters = new object[] { typeof(ref WebReadStream.<ReadAsync>d__28) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsyncTaskMethodBuilder<int>), Member = "get_Task", ReturnType = "System.Threading.Tasks.Task`1<TResult>")]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public sealed override Task<int> ReadAsync(byte[] buffer, int offset, int size, CancellationToken cancellationToken)
		{
			throw null;
		}

		// Token: 0x0600104B RID: 4171
		[global::Cpp2ILInjected.Token(Token = "0x6001226")]
		protected abstract Task<int> ProcessReadAsync(byte[] buffer, int offset, int size, CancellationToken cancellationToken);

		// Token: 0x0600104C RID: 4172 RVA: 0x00005D02 File Offset: 0x00003F02
		[global::Cpp2ILInjected.Token(Token = "0x6001227")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E15EF8", Offset = "0x1E15EF8", Length = "0xFC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.MonoChunkStream.<FinishReading>d__8", Member = "MoveNext", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MonoChunkStream), Member = "<>n__0", MemberParameters = new object[] { typeof(CancellationToken) }, ReturnType = typeof(Task))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebOperation), Member = "ThrowIfDisposed", MemberParameters = new object[] { typeof(CancellationToken) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		internal virtual Task FinishReading(CancellationToken cancellationToken)
		{
			throw null;
		}

		// Token: 0x0600104D RID: 4173 RVA: 0x00005D05 File Offset: 0x00003F05
		[global::Cpp2ILInjected.Token(Token = "0x6001228")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E15FF4", Offset = "0x1E15FF4", Length = "0x4C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Stream), Member = "Dispose", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Stream), Member = "Dispose", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		protected override void Dispose(bool disposing)
		{
			throw null;
		}

		// Token: 0x04000AA3 RID: 2723
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x4000E0B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private readonly WebOperation <Operation>k__BackingField;

		// Token: 0x04000AA4 RID: 2724
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x4000E0C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		private readonly Stream <InnerStream>k__BackingField;

		// Token: 0x04000AA5 RID: 2725
		[global::Cpp2ILInjected.Token(Token = "0x4000E0D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		private bool disposed;

		// Token: 0x02000437 RID: 1079
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x200028E")]
		[StructLayout(3)]
		private struct <ReadAsync>d__28 : IAsyncStateMachine
		{
			// Token: 0x06001E77 RID: 7799 RVA: 0x000083E4 File Offset: 0x000065E4
			[global::Cpp2ILInjected.Token(Token = "0x6001229")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E16040", Offset = "0x1E16040", Length = "0x530")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebOperation), Member = "ThrowIfDisposed", MemberParameters = new object[] { typeof(CancellationToken) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Task<int>), Member = "ConfigureAwait", MemberParameters = new object[] { typeof(bool) }, ReturnType = "System.Runtime.CompilerServices.ConfiguredTaskAwaitable`1<TResult>")]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ConfiguredTaskAwaitable<int>.ConfiguredTaskAwaiter), Member = "get_IsCompleted", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ConfiguredTaskAwaitable<int>.ConfiguredTaskAwaiter), Member = "GetResult", ReturnType = "TResult")]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Task), Member = "ConfigureAwait", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(ConfiguredTaskAwaitable))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ConfiguredTaskAwaitable.ConfiguredTaskAwaiter), Member = "get_IsCompleted", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ConfiguredTaskAwaitable.ConfiguredTaskAwaiter), Member = "GetResult", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsyncTaskMethodBuilder<int>), Member = "SetResult", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsyncTaskMethodBuilder<int>), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new object[]
			{
				typeof(ConfiguredTaskAwaitable<int>.ConfiguredTaskAwaiter),
				typeof(WebReadStream.<ReadAsync>d__28)
			}, MemberParameters = new object[]
			{
				typeof(ref ConfiguredTaskAwaitable<int>.ConfiguredTaskAwaiter),
				typeof(ref WebReadStream.<ReadAsync>d__28)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsyncTaskMethodBuilder<int>), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new object[]
			{
				typeof(ConfiguredTaskAwaitable.ConfiguredTaskAwaiter),
				typeof(WebReadStream.<ReadAsync>d__28)
			}, MemberParameters = new object[]
			{
				typeof(ref ConfiguredTaskAwaitable.ConfiguredTaskAwaiter),
				typeof(ref WebReadStream.<ReadAsync>d__28)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsyncTaskMethodBuilder<int>), Member = "SetException", MemberParameters = new object[] { typeof(Exception) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 47)]
			private void MoveNext()
			{
				throw null;
			}

			// Token: 0x06001E78 RID: 7800 RVA: 0x000083E7 File Offset: 0x000065E7
			[DebuggerHidden]
			[global::Cpp2ILInjected.Token(Token = "0x600122A")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E16570", Offset = "0x1E16570", Length = "0x58")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsyncTaskMethodBuilder<int>), Member = "SetStateMachine", MemberParameters = new object[] { typeof(IAsyncStateMachine) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				throw null;
			}

			// Token: 0x040012EF RID: 4847
			[global::Cpp2ILInjected.Token(Token = "0x4000E0E")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			public int <>1__state;

			// Token: 0x040012F0 RID: 4848
			[global::Cpp2ILInjected.Token(Token = "0x4000E0F")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x8")]
			public AsyncTaskMethodBuilder<int> <>t__builder;

			// Token: 0x040012F1 RID: 4849
			[global::Cpp2ILInjected.Token(Token = "0x4000E10")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
			public WebReadStream <>4__this;

			// Token: 0x040012F2 RID: 4850
			[global::Cpp2ILInjected.Token(Token = "0x4000E11")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
			public CancellationToken cancellationToken;

			// Token: 0x040012F3 RID: 4851
			[global::Cpp2ILInjected.Token(Token = "0x4000E12")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
			public byte[] buffer;

			// Token: 0x040012F4 RID: 4852
			[global::Cpp2ILInjected.Token(Token = "0x4000E13")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
			public int offset;

			// Token: 0x040012F5 RID: 4853
			[global::Cpp2ILInjected.Token(Token = "0x4000E14")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x3C")]
			public int size;

			// Token: 0x040012F6 RID: 4854
			[global::Cpp2ILInjected.Token(Token = "0x4000E15")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
			private ConfiguredTaskAwaitable<int>.ConfiguredTaskAwaiter <>u__1;

			// Token: 0x040012F7 RID: 4855
			[global::Cpp2ILInjected.Token(Token = "0x4000E16")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
			private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter <>u__2;
		}
	}
}
