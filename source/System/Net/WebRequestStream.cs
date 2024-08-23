using System;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.ExceptionServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Net
{
	// Token: 0x020001BA RID: 442
	[global::Cpp2ILInjected.Token(Token = "0x200028F")]
	internal class WebRequestStream : WebConnectionStream
	{
		// Token: 0x0600104E RID: 4174 RVA: 0x00005D08 File Offset: 0x00003F08
		[global::Cpp2ILInjected.Token(Token = "0x600122B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E165C8", Offset = "0x1E165C8", Length = "0x14C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.WebConnection.<InitConnection>d__19", Member = "MoveNext", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebConnectionStream), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(WebConnection),
			typeof(WebOperation)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HttpWebRequest), Member = "get_InternalAllowBuffering", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MemoryStream), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Version), Member = "op_Inequality", MemberParameters = new object[]
		{
			typeof(Version),
			typeof(Version)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public WebRequestStream(WebConnection connection, WebOperation operation, Stream stream, WebConnectionTunnel tunnel)
		{
			throw null;
		}

		// Token: 0x17000409 RID: 1033
		// (get) Token: 0x0600104F RID: 4175 RVA: 0x00005D0B File Offset: 0x00003F0B
		[global::Cpp2ILInjected.Token(Token = "0x17000431")]
		internal Stream InnerStream
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x600122C")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E16714", Offset = "0x1E16714", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700040A RID: 1034
		// (get) Token: 0x06001050 RID: 4176 RVA: 0x00005D0E File Offset: 0x00003F0E
		[global::Cpp2ILInjected.Token(Token = "0x17000432")]
		public bool KeepAlive
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x600122D")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E1671C", Offset = "0x1E1671C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700040B RID: 1035
		// (get) Token: 0x06001051 RID: 4177 RVA: 0x00005D11 File Offset: 0x00003F11
		[global::Cpp2ILInjected.Token(Token = "0x17000433")]
		public override bool CanRead
		{
			[global::Cpp2ILInjected.Token(Token = "0x600122E")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E16724", Offset = "0x1E16724", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700040C RID: 1036
		// (get) Token: 0x06001052 RID: 4178 RVA: 0x00005D14 File Offset: 0x00003F14
		[global::Cpp2ILInjected.Token(Token = "0x17000434")]
		public override bool CanWrite
		{
			[global::Cpp2ILInjected.Token(Token = "0x600122F")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E1672C", Offset = "0x1E1672C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700040D RID: 1037
		// (get) Token: 0x06001053 RID: 4179 RVA: 0x00005D17 File Offset: 0x00003F17
		// (set) Token: 0x06001054 RID: 4180 RVA: 0x00005D1A File Offset: 0x00003F1A
		[global::Cpp2ILInjected.Token(Token = "0x17000435")]
		internal bool SendChunked
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001230")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E16734", Offset = "0x1E16734", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6001231")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E1673C", Offset = "0x1E1673C", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x1700040E RID: 1038
		// (get) Token: 0x06001055 RID: 4181 RVA: 0x00005D1D File Offset: 0x00003F1D
		[global::Cpp2ILInjected.Token(Token = "0x17000436")]
		internal bool HasWriteBuffer
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001232")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E16748", Offset = "0x1E16748", Length = "0x24")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700040F RID: 1039
		// (get) Token: 0x06001056 RID: 4182 RVA: 0x00005D20 File Offset: 0x00003F20
		[global::Cpp2ILInjected.Token(Token = "0x17000437")]
		internal int WriteBufferLength
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001233")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E1676C", Offset = "0x1E1676C", Length = "0x3C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HttpWebRequest), Member = "Redirect", MemberParameters = new object[]
			{
				typeof(HttpStatusCode),
				typeof(WebResponse)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HttpWebRequest), Member = "GetRewriteHandler", MemberParameters = new object[]
			{
				typeof(HttpWebResponse),
				typeof(bool)
			}, ReturnType = typeof(ValueTuple<Task<BufferOffsetSize>, WebException>))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06001057 RID: 4183 RVA: 0x00005D23 File Offset: 0x00003F23
		[global::Cpp2ILInjected.Token(Token = "0x6001234")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E167A8", Offset = "0x1E167A8", Length = "0xC0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HttpWebRequest), Member = "GetRewriteHandler", MemberParameters = new object[]
		{
			typeof(HttpWebResponse),
			typeof(bool)
		}, ReturnType = typeof(ValueTuple<Task<BufferOffsetSize>, WebException>))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebRequestStream.<WriteRequestAsync>d__38), Member = "MoveNext", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BufferOffsetSize), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int),
			typeof(int),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		internal BufferOffsetSize GetWriteBuffer()
		{
			throw null;
		}

		// Token: 0x06001058 RID: 4184 RVA: 0x00005D26 File Offset: 0x00003F26
		[global::Cpp2ILInjected.Token(Token = "0x6001235")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E16868", Offset = "0x1E16868", Length = "0xD8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebRequestStream.<WriteAsyncInner>d__33), Member = "MoveNext", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebRequestStream.<WriteRequestAsync>d__38), Member = "MoveNext", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "Create", ReturnType = typeof(AsyncTaskMethodBuilder))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsyncTaskMethodBuilder[]), Member = "Start", MemberTypeParameters = new object[] { typeof(WebRequestStream.<FinishWriting>d__31) }, MemberParameters = new object[] { typeof(ref WebRequestStream.<FinishWriting>d__31) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "get_Task", ReturnType = typeof(Task))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		private Task FinishWriting(CancellationToken cancellationToken)
		{
			throw null;
		}

		// Token: 0x06001059 RID: 4185 RVA: 0x00005D29 File Offset: 0x00003F29
		[global::Cpp2ILInjected.Token(Token = "0x6001236")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E16940", Offset = "0x1E16940", Length = "0x230")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CancellationToken), Member = "get_IsCancellationRequested", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Task), Member = "FromCanceled", MemberParameters = new object[] { typeof(CancellationToken) }, ReturnType = typeof(Task))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebOperation), Member = "ThrowIfClosedOrDisposed", MemberParameters = new object[] { typeof(CancellationToken) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebCompletionSource), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebRequestStream), Member = "WriteAsyncInner", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int),
			typeof(int),
			typeof(WebCompletionSource),
			typeof(CancellationToken)
		}, ReturnType = typeof(Task))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InvalidOperationException), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "SR", Member = "GetString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 22)]
		public override Task WriteAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken)
		{
			throw null;
		}

		// Token: 0x0600105A RID: 4186 RVA: 0x00005D2C File Offset: 0x00003F2C
		[global::Cpp2ILInjected.Token(Token = "0x6001237")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E16B70", Offset = "0x1E16B70", Length = "0x104")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebRequestStream), Member = "WriteAsync", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int),
			typeof(int),
			typeof(CancellationToken)
		}, ReturnType = typeof(Task))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "Create", ReturnType = typeof(AsyncTaskMethodBuilder))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsyncTaskMethodBuilder[]), Member = "Start", MemberTypeParameters = new object[] { typeof(WebRequestStream.<WriteAsyncInner>d__33) }, MemberParameters = new object[] { typeof(ref WebRequestStream.<WriteAsyncInner>d__33) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "get_Task", ReturnType = typeof(Task))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		private Task WriteAsyncInner(byte[] buffer, int offset, int size, WebCompletionSource completion, CancellationToken cancellationToken)
		{
			throw null;
		}

		// Token: 0x0600105B RID: 4187 RVA: 0x00005D2F File Offset: 0x00003F2F
		[global::Cpp2ILInjected.Token(Token = "0x6001238")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E16C74", Offset = "0x1E16C74", Length = "0x100")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebRequestStream.<WriteAsyncInner>d__33), Member = "MoveNext", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "Create", ReturnType = typeof(AsyncTaskMethodBuilder))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsyncTaskMethodBuilder[]), Member = "Start", MemberTypeParameters = new object[] { typeof(WebRequestStream.<ProcessWrite>d__34) }, MemberParameters = new object[] { typeof(ref WebRequestStream.<ProcessWrite>d__34) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "get_Task", ReturnType = typeof(Task))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		private Task ProcessWrite(byte[] buffer, int offset, int size, CancellationToken cancellationToken)
		{
			throw null;
		}

		// Token: 0x0600105C RID: 4188 RVA: 0x00005D32 File Offset: 0x00003F32
		[global::Cpp2ILInjected.Token(Token = "0x6001239")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E16D74", Offset = "0x1E16D74", Length = "0x8C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebRequestStream.<ProcessWrite>d__34), Member = "MoveNext", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ProtocolViolationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebOperation), Member = "CompleteRequestWritten", MemberParameters = new object[]
		{
			typeof(WebRequestStream),
			typeof(Exception)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		private void CheckWriteOverflow(long contentLength, long totalWritten, long size)
		{
			throw null;
		}

		// Token: 0x0600105D RID: 4189 RVA: 0x00005D35 File Offset: 0x00003F35
		[global::Cpp2ILInjected.Token(Token = "0x600123A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E152F4", Offset = "0x1E152F4", Length = "0xDC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.WebOperation.<Run>d__58", Member = "MoveNext", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "Create", ReturnType = typeof(AsyncTaskMethodBuilder))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsyncTaskMethodBuilder[]), Member = "Start", MemberTypeParameters = new object[] { typeof(WebRequestStream.<Initialize>d__36) }, MemberParameters = new object[] { typeof(ref WebRequestStream.<Initialize>d__36) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "get_Task", ReturnType = typeof(Task))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		internal Task Initialize(CancellationToken cancellationToken)
		{
			throw null;
		}

		// Token: 0x0600105E RID: 4190 RVA: 0x00005D38 File Offset: 0x00003F38
		[global::Cpp2ILInjected.Token(Token = "0x600123B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E16E08", Offset = "0x1E16E08", Length = "0xE4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebRequestStream.<Initialize>d__36), Member = "MoveNext", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebRequestStream.<WriteRequestAsync>d__38), Member = "MoveNext", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "Create", ReturnType = typeof(AsyncTaskMethodBuilder))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsyncTaskMethodBuilder[]), Member = "Start", MemberTypeParameters = new object[] { typeof(WebRequestStream.<SetHeadersAsync>d__37) }, MemberParameters = new object[] { typeof(ref WebRequestStream.<SetHeadersAsync>d__37) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "get_Task", ReturnType = typeof(Task))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		private Task SetHeadersAsync(bool setInternalLength, CancellationToken cancellationToken)
		{
			throw null;
		}

		// Token: 0x0600105F RID: 4191 RVA: 0x00005D3B File Offset: 0x00003F3B
		[global::Cpp2ILInjected.Token(Token = "0x600123C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E16EEC", Offset = "0x1E16EEC", Length = "0xDC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.HttpWebRequest.<MyGetResponseAsync>d__243", Member = "MoveNext", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebRequestStream.<Initialize>d__36), Member = "MoveNext", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "Create", ReturnType = typeof(AsyncTaskMethodBuilder))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsyncTaskMethodBuilder[]), Member = "Start", MemberTypeParameters = new object[] { typeof(WebRequestStream.<WriteRequestAsync>d__38) }, MemberParameters = new object[] { typeof(ref WebRequestStream.<WriteRequestAsync>d__38) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "get_Task", ReturnType = typeof(Task))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		internal Task WriteRequestAsync(CancellationToken cancellationToken)
		{
			throw null;
		}

		// Token: 0x06001060 RID: 4192 RVA: 0x00005D3E File Offset: 0x00003F3E
		[global::Cpp2ILInjected.Token(Token = "0x600123D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E16FC8", Offset = "0x1E16FC8", Length = "0xD8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebRequestStream.<FinishWriting>d__31), Member = "MoveNext", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebRequestStream.<WriteChunkTrailer>d__40), Member = "MoveNext", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "Create", ReturnType = typeof(AsyncTaskMethodBuilder))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsyncTaskMethodBuilder[]), Member = "Start", MemberTypeParameters = new object[] { typeof(WebRequestStream.<WriteChunkTrailer_inner>d__39) }, MemberParameters = new object[] { typeof(ref WebRequestStream.<WriteChunkTrailer_inner>d__39) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "get_Task", ReturnType = typeof(Task))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		private Task WriteChunkTrailer_inner(CancellationToken cancellationToken)
		{
			throw null;
		}

		// Token: 0x06001061 RID: 4193 RVA: 0x00005D41 File Offset: 0x00003F41
		[global::Cpp2ILInjected.Token(Token = "0x600123E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E170A0", Offset = "0x1E170A0", Length = "0xD4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebRequestStream), Member = "Close_internal", MemberParameters = new object[] { typeof(ref bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "Create", ReturnType = typeof(AsyncTaskMethodBuilder))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsyncTaskMethodBuilder[]), Member = "Start", MemberTypeParameters = new object[] { typeof(WebRequestStream.<WriteChunkTrailer>d__40) }, MemberParameters = new object[] { typeof(ref WebRequestStream.<WriteChunkTrailer>d__40) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "get_Task", ReturnType = typeof(Task))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		private Task WriteChunkTrailer()
		{
			throw null;
		}

		// Token: 0x06001062 RID: 4194 RVA: 0x00005D44 File Offset: 0x00003F44
		[global::Cpp2ILInjected.Token(Token = "0x600123F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E16E00", Offset = "0x1E16E00", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.HttpWebRequest.<GetResponseFromData>d__244", Member = "MoveNext", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		internal void KillBuffer()
		{
			throw null;
		}

		// Token: 0x06001063 RID: 4195 RVA: 0x00005D47 File Offset: 0x00003F47
		[global::Cpp2ILInjected.Token(Token = "0x6001240")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E17174", Offset = "0x1E17174", Length = "0xB0")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NotSupportedException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Task), Member = "FromException", MemberTypeParameters = new object[] { "TResult" }, MemberParameters = new object[] { typeof(Exception) }, ReturnType = "System.Threading.Tasks.Task`1<TResult>")]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		public override Task<int> ReadAsync(byte[] buffer, int offset, int size, CancellationToken cancellationToken)
		{
			throw null;
		}

		// Token: 0x06001064 RID: 4196 RVA: 0x00005D4A File Offset: 0x00003F4A
		[global::Cpp2ILInjected.Token(Token = "0x6001241")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E17224", Offset = "0x1E17224", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InvalidOperationException), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		protected override bool TryReadFromBufferedContent(byte[] buffer, int offset, int count, out int result)
		{
			throw null;
		}

		// Token: 0x06001065 RID: 4197 RVA: 0x00005D4D File Offset: 0x00003F4D
		[global::Cpp2ILInjected.Token(Token = "0x6001242")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E1725C", Offset = "0x1E1725C", Length = "0x158")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebRequestStream), Member = "WriteChunkTrailer", ReturnType = typeof(Task))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Task), Member = "Wait", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebOperation), Member = "CompleteRequestWritten", MemberParameters = new object[]
		{
			typeof(WebRequestStream),
			typeof(Exception)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(IOException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(WebExceptionStatus),
			typeof(WebExceptionInternalStatus),
			typeof(Exception)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		protected override void Close_internal(ref bool disposed)
		{
			throw null;
		}

		// Token: 0x06001066 RID: 4198 RVA: 0x00005D50 File Offset: 0x00003F50
		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x6001243")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E173B4", Offset = "0x1E173B4", Length = "0x70")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		static WebRequestStream()
		{
			throw null;
		}

		// Token: 0x04000AA6 RID: 2726
		[global::Cpp2ILInjected.Token(Token = "0x4000E17")]
		private static byte[] crlf;

		// Token: 0x04000AA7 RID: 2727
		[global::Cpp2ILInjected.Token(Token = "0x4000E18")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x60")]
		private MemoryStream writeBuffer;

		// Token: 0x04000AA8 RID: 2728
		[global::Cpp2ILInjected.Token(Token = "0x4000E19")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x68")]
		private bool requestWritten;

		// Token: 0x04000AA9 RID: 2729
		[global::Cpp2ILInjected.Token(Token = "0x4000E1A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x69")]
		private bool allowBuffering;

		// Token: 0x04000AAA RID: 2730
		[global::Cpp2ILInjected.Token(Token = "0x4000E1B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x6A")]
		private bool sendChunked;

		// Token: 0x04000AAB RID: 2731
		[global::Cpp2ILInjected.Token(Token = "0x4000E1C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x70")]
		private WebCompletionSource pendingWrite;

		// Token: 0x04000AAC RID: 2732
		[global::Cpp2ILInjected.Token(Token = "0x4000E1D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x78")]
		private long totalWritten;

		// Token: 0x04000AAD RID: 2733
		[global::Cpp2ILInjected.Token(Token = "0x4000E1E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x80")]
		private byte[] headers;

		// Token: 0x04000AAE RID: 2734
		[global::Cpp2ILInjected.Token(Token = "0x4000E1F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x88")]
		private bool headersSent;

		// Token: 0x04000AAF RID: 2735
		[global::Cpp2ILInjected.Token(Token = "0x4000E20")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x8C")]
		private int completeRequestWritten;

		// Token: 0x04000AB0 RID: 2736
		[global::Cpp2ILInjected.Token(Token = "0x4000E21")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x90")]
		private int chunkTrailerWritten;

		// Token: 0x04000AB1 RID: 2737
		[global::Cpp2ILInjected.Token(Token = "0x4000E22")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x98")]
		internal readonly string ME;

		// Token: 0x04000AB2 RID: 2738
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x4000E23")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xA0")]
		private readonly Stream <InnerStream>k__BackingField;

		// Token: 0x04000AB3 RID: 2739
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x4000E24")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xA8")]
		private readonly bool <KeepAlive>k__BackingField;

		// Token: 0x02000438 RID: 1080
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x2000290")]
		[StructLayout(3)]
		private struct <FinishWriting>d__31 : IAsyncStateMachine
		{
			// Token: 0x06001E79 RID: 7801 RVA: 0x000083EA File Offset: 0x000065EA
			[global::Cpp2ILInjected.Token(Token = "0x6001244")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E17424", Offset = "0x1E17424", Length = "0x29C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Interlocked), Member = "CompareExchange", MemberParameters = new object[]
			{
				typeof(ref int),
				typeof(int),
				typeof(int)
			}, ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebOperation), Member = "ThrowIfClosedOrDisposed", MemberParameters = new object[] { typeof(CancellationToken) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebRequestStream), Member = "WriteChunkTrailer_inner", MemberParameters = new object[] { typeof(CancellationToken) }, ReturnType = typeof(Task))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Task), Member = "ConfigureAwait", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(ConfiguredTaskAwaitable))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ConfiguredTaskAwaitable.ConfiguredTaskAwaiter), Member = "get_IsCompleted", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsyncTaskMethodBuilder[]), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new object[]
			{
				typeof(ConfiguredTaskAwaitable.ConfiguredTaskAwaiter),
				typeof(WebRequestStream.<FinishWriting>d__31)
			}, MemberParameters = new object[]
			{
				typeof(ref ConfiguredTaskAwaitable.ConfiguredTaskAwaiter),
				typeof(ref WebRequestStream.<FinishWriting>d__31)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ConfiguredTaskAwaitable.ConfiguredTaskAwaiter), Member = "GetResult", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebOperation), Member = "CompleteRequestWritten", MemberParameters = new object[]
			{
				typeof(WebRequestStream),
				typeof(Exception)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetResult", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetException", MemberParameters = new object[] { typeof(Exception) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 22)]
			private void MoveNext()
			{
				throw null;
			}

			// Token: 0x06001E7A RID: 7802 RVA: 0x000083ED File Offset: 0x000065ED
			[DebuggerHidden]
			[global::Cpp2ILInjected.Token(Token = "0x6001245")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E176C0", Offset = "0x1E176C0", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetStateMachine", MemberParameters = new object[] { typeof(IAsyncStateMachine) }, ReturnType = typeof(void))]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				throw null;
			}

			// Token: 0x040012F8 RID: 4856
			[global::Cpp2ILInjected.Token(Token = "0x4000E25")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			public int <>1__state;

			// Token: 0x040012F9 RID: 4857
			[global::Cpp2ILInjected.Token(Token = "0x4000E26")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x8")]
			public AsyncTaskMethodBuilder <>t__builder;

			// Token: 0x040012FA RID: 4858
			[global::Cpp2ILInjected.Token(Token = "0x4000E27")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
			public WebRequestStream <>4__this;

			// Token: 0x040012FB RID: 4859
			[global::Cpp2ILInjected.Token(Token = "0x4000E28")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
			public CancellationToken cancellationToken;

			// Token: 0x040012FC RID: 4860
			[global::Cpp2ILInjected.Token(Token = "0x4000E29")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
			private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter <>u__1;
		}

		// Token: 0x02000439 RID: 1081
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x2000291")]
		[StructLayout(3)]
		private struct <WriteAsyncInner>d__33 : IAsyncStateMachine
		{
			// Token: 0x06001E7B RID: 7803 RVA: 0x000083F0 File Offset: 0x000065F0
			[global::Cpp2ILInjected.Token(Token = "0x6001246")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E176CC", Offset = "0x1E176CC", Length = "0x424")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TaskAwaiter), Member = "GetResult", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebRequestStream), Member = "ProcessWrite", MemberParameters = new object[]
			{
				typeof(byte[]),
				typeof(int),
				typeof(int),
				typeof(CancellationToken)
			}, ReturnType = typeof(Task))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Task), Member = "ConfigureAwait", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(ConfiguredTaskAwaitable))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ConfiguredTaskAwaitable.ConfiguredTaskAwaiter), Member = "get_IsCompleted", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ConfiguredTaskAwaitable.ConfiguredTaskAwaiter), Member = "GetResult", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebRequestStream), Member = "FinishWriting", MemberParameters = new object[] { typeof(CancellationToken) }, ReturnType = typeof(Task))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Task), Member = "GetAwaiter", ReturnType = typeof(TaskAwaiter))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TaskAwaiter), Member = "get_IsCompleted", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsyncTaskMethodBuilder[]), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new object[]
			{
				typeof(TaskAwaiter),
				typeof(WebRequestStream.<WriteAsyncInner>d__33)
			}, MemberParameters = new object[]
			{
				typeof(ref TaskAwaiter),
				typeof(ref WebRequestStream.<WriteAsyncInner>d__33)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebCompletionSource<object>), Member = "TrySetCompleted", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetResult", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsyncTaskMethodBuilder[]), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new object[]
			{
				typeof(ConfiguredTaskAwaitable.ConfiguredTaskAwaiter),
				typeof(WebRequestStream.<WriteAsyncInner>d__33)
			}, MemberParameters = new object[]
			{
				typeof(ref ConfiguredTaskAwaitable.ConfiguredTaskAwaiter),
				typeof(ref WebRequestStream.<WriteAsyncInner>d__33)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetException", MemberParameters = new object[] { typeof(Exception) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebOperation), Member = "CheckDisposed", MemberParameters = new object[] { typeof(CancellationToken) }, ReturnType = typeof(ExceptionDispatchInfo))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(IOException), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(string),
				typeof(Exception)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebOperation), Member = "CompleteRequestWritten", MemberParameters = new object[]
			{
				typeof(WebRequestStream),
				typeof(Exception)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebCompletionSource<object>), Member = "TrySetException", MemberParameters = new object[] { typeof(Exception) }, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ExceptionDispatchInfo), Member = "Throw", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 25)]
			private void MoveNext()
			{
				throw null;
			}

			// Token: 0x06001E7C RID: 7804 RVA: 0x000083F3 File Offset: 0x000065F3
			[DebuggerHidden]
			[global::Cpp2ILInjected.Token(Token = "0x6001247")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E17AF0", Offset = "0x1E17AF0", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetStateMachine", MemberParameters = new object[] { typeof(IAsyncStateMachine) }, ReturnType = typeof(void))]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				throw null;
			}

			// Token: 0x040012FD RID: 4861
			[global::Cpp2ILInjected.Token(Token = "0x4000E2A")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			public int <>1__state;

			// Token: 0x040012FE RID: 4862
			[global::Cpp2ILInjected.Token(Token = "0x4000E2B")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x8")]
			public AsyncTaskMethodBuilder <>t__builder;

			// Token: 0x040012FF RID: 4863
			[global::Cpp2ILInjected.Token(Token = "0x4000E2C")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
			public WebRequestStream <>4__this;

			// Token: 0x04001300 RID: 4864
			[global::Cpp2ILInjected.Token(Token = "0x4000E2D")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
			public byte[] buffer;

			// Token: 0x04001301 RID: 4865
			[global::Cpp2ILInjected.Token(Token = "0x4000E2E")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
			public int offset;

			// Token: 0x04001302 RID: 4866
			[global::Cpp2ILInjected.Token(Token = "0x4000E2F")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x34")]
			public int size;

			// Token: 0x04001303 RID: 4867
			[global::Cpp2ILInjected.Token(Token = "0x4000E30")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
			public CancellationToken cancellationToken;

			// Token: 0x04001304 RID: 4868
			[global::Cpp2ILInjected.Token(Token = "0x4000E31")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
			public WebCompletionSource completion;

			// Token: 0x04001305 RID: 4869
			[global::Cpp2ILInjected.Token(Token = "0x4000E32")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
			private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter <>u__1;

			// Token: 0x04001306 RID: 4870
			[global::Cpp2ILInjected.Token(Token = "0x4000E33")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x58")]
			private TaskAwaiter <>u__2;
		}

		// Token: 0x0200043A RID: 1082
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x2000292")]
		[StructLayout(3)]
		private struct <ProcessWrite>d__34 : IAsyncStateMachine
		{
			// Token: 0x06001E7D RID: 7805 RVA: 0x000083F6 File Offset: 0x000065F6
			[global::Cpp2ILInjected.Token(Token = "0x6001248")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E17AFC", Offset = "0x1E17AFC", Length = "0x4B0")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebOperation), Member = "ThrowIfClosedOrDisposed", MemberParameters = new object[] { typeof(CancellationToken) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Format", MemberParameters = new object[]
			{
				typeof(string),
				typeof(object)
			}, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Encoding), Member = "get_ASCII", ReturnType = typeof(Encoding))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Buffer), Member = "BlockCopy", MemberParameters = new object[]
			{
				typeof(Array),
				typeof(int),
				typeof(Array),
				typeof(int),
				typeof(int)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MemoryStream), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Task), Member = "ConfigureAwait", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(ConfiguredTaskAwaitable))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ConfiguredTaskAwaitable.ConfiguredTaskAwaiter), Member = "get_IsCompleted", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsyncTaskMethodBuilder[]), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new object[]
			{
				typeof(ConfiguredTaskAwaitable.ConfiguredTaskAwaiter),
				typeof(WebRequestStream.<ProcessWrite>d__34)
			}, MemberParameters = new object[]
			{
				typeof(ref ConfiguredTaskAwaitable.ConfiguredTaskAwaiter),
				typeof(ref WebRequestStream.<ProcessWrite>d__34)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ConfiguredTaskAwaitable.ConfiguredTaskAwaiter), Member = "GetResult", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetResult", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebRequestStream), Member = "CheckWriteOverflow", MemberParameters = new object[]
			{
				typeof(long),
				typeof(long),
				typeof(long)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetException", MemberParameters = new object[] { typeof(Exception) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 20)]
			private void MoveNext()
			{
				throw null;
			}

			// Token: 0x06001E7E RID: 7806 RVA: 0x000083F9 File Offset: 0x000065F9
			[DebuggerHidden]
			[global::Cpp2ILInjected.Token(Token = "0x6001249")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E17FAC", Offset = "0x1E17FAC", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetStateMachine", MemberParameters = new object[] { typeof(IAsyncStateMachine) }, ReturnType = typeof(void))]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				throw null;
			}

			// Token: 0x04001307 RID: 4871
			[global::Cpp2ILInjected.Token(Token = "0x4000E34")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			public int <>1__state;

			// Token: 0x04001308 RID: 4872
			[global::Cpp2ILInjected.Token(Token = "0x4000E35")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x8")]
			public AsyncTaskMethodBuilder <>t__builder;

			// Token: 0x04001309 RID: 4873
			[global::Cpp2ILInjected.Token(Token = "0x4000E36")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
			public WebRequestStream <>4__this;

			// Token: 0x0400130A RID: 4874
			[global::Cpp2ILInjected.Token(Token = "0x4000E37")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
			public CancellationToken cancellationToken;

			// Token: 0x0400130B RID: 4875
			[global::Cpp2ILInjected.Token(Token = "0x4000E38")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
			public int size;

			// Token: 0x0400130C RID: 4876
			[global::Cpp2ILInjected.Token(Token = "0x4000E39")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
			public byte[] buffer;

			// Token: 0x0400130D RID: 4877
			[global::Cpp2ILInjected.Token(Token = "0x4000E3A")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
			public int offset;

			// Token: 0x0400130E RID: 4878
			[global::Cpp2ILInjected.Token(Token = "0x4000E3B")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
			private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter <>u__1;
		}

		// Token: 0x0200043B RID: 1083
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x2000293")]
		[StructLayout(3)]
		private struct <Initialize>d__36 : IAsyncStateMachine
		{
			// Token: 0x06001E7F RID: 7807 RVA: 0x000083FC File Offset: 0x000065FC
			[global::Cpp2ILInjected.Token(Token = "0x600124A")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E17FB8", Offset = "0x1E17FB8", Length = "0x298")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TaskAwaiter), Member = "GetResult", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebOperation), Member = "ThrowIfClosedOrDisposed", MemberParameters = new object[] { typeof(CancellationToken) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebRequestStream), Member = "SetHeadersAsync", MemberParameters = new object[]
			{
				typeof(bool),
				typeof(CancellationToken)
			}, ReturnType = typeof(Task))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Task), Member = "ConfigureAwait", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(ConfiguredTaskAwaitable))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ConfiguredTaskAwaitable.ConfiguredTaskAwaiter), Member = "get_IsCompleted", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ConfiguredTaskAwaitable.ConfiguredTaskAwaiter), Member = "GetResult", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetResult", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsyncTaskMethodBuilder[]), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new object[]
			{
				typeof(ConfiguredTaskAwaitable.ConfiguredTaskAwaiter),
				typeof(WebRequestStream.<Initialize>d__36)
			}, MemberParameters = new object[]
			{
				typeof(ref ConfiguredTaskAwaitable.ConfiguredTaskAwaiter),
				typeof(ref WebRequestStream.<Initialize>d__36)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebRequestStream), Member = "WriteRequestAsync", MemberParameters = new object[] { typeof(CancellationToken) }, ReturnType = typeof(Task))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Task), Member = "GetAwaiter", ReturnType = typeof(TaskAwaiter))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TaskAwaiter), Member = "get_IsCompleted", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsyncTaskMethodBuilder[]), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new object[]
			{
				typeof(TaskAwaiter),
				typeof(WebRequestStream.<Initialize>d__36)
			}, MemberParameters = new object[]
			{
				typeof(ref TaskAwaiter),
				typeof(ref WebRequestStream.<Initialize>d__36)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetException", MemberParameters = new object[] { typeof(Exception) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 11)]
			private void MoveNext()
			{
				throw null;
			}

			// Token: 0x06001E80 RID: 7808 RVA: 0x000083FF File Offset: 0x000065FF
			[DebuggerHidden]
			[global::Cpp2ILInjected.Token(Token = "0x600124B")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E18250", Offset = "0x1E18250", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetStateMachine", MemberParameters = new object[] { typeof(IAsyncStateMachine) }, ReturnType = typeof(void))]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				throw null;
			}

			// Token: 0x0400130F RID: 4879
			[global::Cpp2ILInjected.Token(Token = "0x4000E3C")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			public int <>1__state;

			// Token: 0x04001310 RID: 4880
			[global::Cpp2ILInjected.Token(Token = "0x4000E3D")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x8")]
			public AsyncTaskMethodBuilder <>t__builder;

			// Token: 0x04001311 RID: 4881
			[global::Cpp2ILInjected.Token(Token = "0x4000E3E")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
			public WebRequestStream <>4__this;

			// Token: 0x04001312 RID: 4882
			[global::Cpp2ILInjected.Token(Token = "0x4000E3F")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
			public CancellationToken cancellationToken;

			// Token: 0x04001313 RID: 4883
			[global::Cpp2ILInjected.Token(Token = "0x4000E40")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
			private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter <>u__1;

			// Token: 0x04001314 RID: 4884
			[global::Cpp2ILInjected.Token(Token = "0x4000E41")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
			private TaskAwaiter <>u__2;
		}

		// Token: 0x0200043C RID: 1084
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x2000294")]
		[StructLayout(3)]
		private struct <SetHeadersAsync>d__37 : IAsyncStateMachine
		{
			// Token: 0x06001E81 RID: 7809 RVA: 0x00008402 File Offset: 0x00006602
			[global::Cpp2ILInjected.Token(Token = "0x600124C")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E1825C", Offset = "0x1E1825C", Length = "0x610")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebOperation), Member = "ThrowIfClosedOrDisposed", MemberParameters = new object[] { typeof(CancellationToken) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "op_Equality", MemberParameters = new object[]
			{
				typeof(string),
				typeof(string)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ConfiguredTaskAwaitable.ConfiguredTaskAwaiter), Member = "GetResult", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HttpWebRequest), Member = "GetRequestHeaders", ReturnType = typeof(byte[]))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Task), Member = "ConfigureAwait", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(ConfiguredTaskAwaitable))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ConfiguredTaskAwaitable.ConfiguredTaskAwaiter), Member = "get_IsCompleted", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsyncTaskMethodBuilder[]), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new object[]
			{
				typeof(ConfiguredTaskAwaitable.ConfiguredTaskAwaiter),
				typeof(WebRequestStream.<SetHeadersAsync>d__37)
			}, MemberParameters = new object[]
			{
				typeof(ref ConfiguredTaskAwaitable.ConfiguredTaskAwaiter),
				typeof(ref WebRequestStream.<SetHeadersAsync>d__37)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetResult", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebException), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(string),
				typeof(WebExceptionStatus),
				typeof(WebExceptionInternalStatus),
				typeof(Exception)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetException", MemberParameters = new object[] { typeof(Exception) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 36)]
			private void MoveNext()
			{
				throw null;
			}

			// Token: 0x06001E82 RID: 7810 RVA: 0x00008405 File Offset: 0x00006605
			[DebuggerHidden]
			[global::Cpp2ILInjected.Token(Token = "0x600124D")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E1886C", Offset = "0x1E1886C", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetStateMachine", MemberParameters = new object[] { typeof(IAsyncStateMachine) }, ReturnType = typeof(void))]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				throw null;
			}

			// Token: 0x04001315 RID: 4885
			[global::Cpp2ILInjected.Token(Token = "0x4000E42")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			public int <>1__state;

			// Token: 0x04001316 RID: 4886
			[global::Cpp2ILInjected.Token(Token = "0x4000E43")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x8")]
			public AsyncTaskMethodBuilder <>t__builder;

			// Token: 0x04001317 RID: 4887
			[global::Cpp2ILInjected.Token(Token = "0x4000E44")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
			public WebRequestStream <>4__this;

			// Token: 0x04001318 RID: 4888
			[global::Cpp2ILInjected.Token(Token = "0x4000E45")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
			public CancellationToken cancellationToken;

			// Token: 0x04001319 RID: 4889
			[global::Cpp2ILInjected.Token(Token = "0x4000E46")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
			public bool setInternalLength;

			// Token: 0x0400131A RID: 4890
			[global::Cpp2ILInjected.Token(Token = "0x4000E47")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
			private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter <>u__1;
		}

		// Token: 0x0200043D RID: 1085
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x2000295")]
		[StructLayout(3)]
		private struct <WriteRequestAsync>d__38 : IAsyncStateMachine
		{
			// Token: 0x06001E83 RID: 7811 RVA: 0x00008408 File Offset: 0x00006608
			[global::Cpp2ILInjected.Token(Token = "0x600124E")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E18878", Offset = "0x1E18878", Length = "0x40C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TaskAwaiter), Member = "GetResult", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ConfiguredTaskAwaitable.ConfiguredTaskAwaiter), Member = "GetResult", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebOperation), Member = "ThrowIfClosedOrDisposed", MemberParameters = new object[] { typeof(CancellationToken) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Task), Member = "GetAwaiter", ReturnType = typeof(TaskAwaiter))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TaskAwaiter), Member = "get_IsCompleted", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsyncTaskMethodBuilder[]), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new object[]
			{
				typeof(TaskAwaiter),
				typeof(WebRequestStream.<WriteRequestAsync>d__38)
			}, MemberParameters = new object[]
			{
				typeof(ref TaskAwaiter),
				typeof(ref WebRequestStream.<WriteRequestAsync>d__38)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebRequestStream), Member = "FinishWriting", MemberParameters = new object[] { typeof(CancellationToken) }, ReturnType = typeof(Task))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetResult", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebRequestStream), Member = "GetWriteBuffer", ReturnType = typeof(BufferOffsetSize))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebRequestStream), Member = "SetHeadersAsync", MemberParameters = new object[]
			{
				typeof(bool),
				typeof(CancellationToken)
			}, ReturnType = typeof(Task))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Task), Member = "ConfigureAwait", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(ConfiguredTaskAwaitable))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ConfiguredTaskAwaitable.ConfiguredTaskAwaiter), Member = "get_IsCompleted", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsyncTaskMethodBuilder[]), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new object[]
			{
				typeof(ConfiguredTaskAwaitable.ConfiguredTaskAwaiter),
				typeof(WebRequestStream.<WriteRequestAsync>d__38)
			}, MemberParameters = new object[]
			{
				typeof(ref ConfiguredTaskAwaitable.ConfiguredTaskAwaiter),
				typeof(ref WebRequestStream.<WriteRequestAsync>d__38)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebException), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(string),
				typeof(Exception),
				typeof(WebExceptionStatus),
				typeof(WebResponse)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebOperation), Member = "CompleteRequestWritten", MemberParameters = new object[]
			{
				typeof(WebRequestStream),
				typeof(Exception)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetException", MemberParameters = new object[] { typeof(Exception) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 16)]
			private void MoveNext()
			{
				throw null;
			}

			// Token: 0x06001E84 RID: 7812 RVA: 0x0000840B File Offset: 0x0000660B
			[DebuggerHidden]
			[global::Cpp2ILInjected.Token(Token = "0x600124F")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E18C84", Offset = "0x1E18C84", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetStateMachine", MemberParameters = new object[] { typeof(IAsyncStateMachine) }, ReturnType = typeof(void))]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				throw null;
			}

			// Token: 0x0400131B RID: 4891
			[global::Cpp2ILInjected.Token(Token = "0x4000E48")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			public int <>1__state;

			// Token: 0x0400131C RID: 4892
			[global::Cpp2ILInjected.Token(Token = "0x4000E49")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x8")]
			public AsyncTaskMethodBuilder <>t__builder;

			// Token: 0x0400131D RID: 4893
			[global::Cpp2ILInjected.Token(Token = "0x4000E4A")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
			public WebRequestStream <>4__this;

			// Token: 0x0400131E RID: 4894
			[global::Cpp2ILInjected.Token(Token = "0x4000E4B")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
			public CancellationToken cancellationToken;

			// Token: 0x0400131F RID: 4895
			[global::Cpp2ILInjected.Token(Token = "0x4000E4C")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
			private BufferOffsetSize <buffer>5__2;

			// Token: 0x04001320 RID: 4896
			[global::Cpp2ILInjected.Token(Token = "0x4000E4D")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
			private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter <>u__1;

			// Token: 0x04001321 RID: 4897
			[global::Cpp2ILInjected.Token(Token = "0x4000E4E")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
			private TaskAwaiter <>u__2;
		}

		// Token: 0x0200043E RID: 1086
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x2000296")]
		[StructLayout(3)]
		private struct <WriteChunkTrailer_inner>d__39 : IAsyncStateMachine
		{
			// Token: 0x06001E85 RID: 7813 RVA: 0x0000840E File Offset: 0x0000660E
			[global::Cpp2ILInjected.Token(Token = "0x6001250")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E18C90", Offset = "0x1E18C90", Length = "0x1F4")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Interlocked), Member = "CompareExchange", MemberParameters = new object[]
			{
				typeof(ref int),
				typeof(int),
				typeof(int)
			}, ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebOperation), Member = "ThrowIfClosedOrDisposed", MemberParameters = new object[] { typeof(CancellationToken) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Encoding), Member = "get_ASCII", ReturnType = typeof(Encoding))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Task), Member = "ConfigureAwait", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(ConfiguredTaskAwaitable))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ConfiguredTaskAwaitable.ConfiguredTaskAwaiter), Member = "get_IsCompleted", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsyncTaskMethodBuilder[]), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new object[]
			{
				typeof(ConfiguredTaskAwaitable.ConfiguredTaskAwaiter),
				typeof(WebRequestStream.<WriteChunkTrailer_inner>d__39)
			}, MemberParameters = new object[]
			{
				typeof(ref ConfiguredTaskAwaitable.ConfiguredTaskAwaiter),
				typeof(ref WebRequestStream.<WriteChunkTrailer_inner>d__39)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ConfiguredTaskAwaitable.ConfiguredTaskAwaiter), Member = "GetResult", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetResult", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetException", MemberParameters = new object[] { typeof(Exception) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 11)]
			private void MoveNext()
			{
				throw null;
			}

			// Token: 0x06001E86 RID: 7814 RVA: 0x00008411 File Offset: 0x00006611
			[DebuggerHidden]
			[global::Cpp2ILInjected.Token(Token = "0x6001251")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E18E84", Offset = "0x1E18E84", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetStateMachine", MemberParameters = new object[] { typeof(IAsyncStateMachine) }, ReturnType = typeof(void))]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				throw null;
			}

			// Token: 0x04001322 RID: 4898
			[global::Cpp2ILInjected.Token(Token = "0x4000E4F")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			public int <>1__state;

			// Token: 0x04001323 RID: 4899
			[global::Cpp2ILInjected.Token(Token = "0x4000E50")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x8")]
			public AsyncTaskMethodBuilder <>t__builder;

			// Token: 0x04001324 RID: 4900
			[global::Cpp2ILInjected.Token(Token = "0x4000E51")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
			public WebRequestStream <>4__this;

			// Token: 0x04001325 RID: 4901
			[global::Cpp2ILInjected.Token(Token = "0x4000E52")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
			public CancellationToken cancellationToken;

			// Token: 0x04001326 RID: 4902
			[global::Cpp2ILInjected.Token(Token = "0x4000E53")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
			private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter <>u__1;
		}

		// Token: 0x0200043F RID: 1087
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x2000297")]
		[StructLayout(3)]
		private struct <WriteChunkTrailer>d__40 : IAsyncStateMachine
		{
			// Token: 0x06001E87 RID: 7815 RVA: 0x00008414 File Offset: 0x00006614
			[global::Cpp2ILInjected.Token(Token = "0x6001252")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E18E90", Offset = "0x1E18E90", Length = "0x608")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CancellationTokenSource), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CancellationTokenSource), Member = "CancelAfter", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CancellationTokenSource), Member = "get_Token", ReturnType = typeof(CancellationToken))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Task), Member = "Delay", MemberParameters = new object[]
			{
				typeof(int),
				typeof(CancellationToken)
			}, ReturnType = typeof(Task))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebCompletionSource), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebCompletionSource<object>), Member = "WaitForCompletion", ReturnType = "System.Threading.Tasks.Task`1<T>")]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Task), Member = "WhenAny", MemberParameters = new object[] { typeof(Task[]) }, ReturnType = typeof(Task<Task>))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Task<object>), Member = "ConfigureAwait", MemberParameters = new object[] { typeof(bool) }, ReturnType = "System.Runtime.CompilerServices.ConfiguredTaskAwaitable`1<TResult>")]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ConfiguredTaskAwaitable<object>.ConfiguredTaskAwaiter), Member = "get_IsCompleted", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ConfiguredTaskAwaitable<object>.ConfiguredTaskAwaiter), Member = "GetResult", ReturnType = "TResult")]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebException), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(string),
				typeof(WebExceptionStatus)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebRequestStream), Member = "WriteChunkTrailer_inner", MemberParameters = new object[] { typeof(CancellationToken) }, ReturnType = typeof(Task))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Task), Member = "ConfigureAwait", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(ConfiguredTaskAwaitable))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ConfiguredTaskAwaitable.ConfiguredTaskAwaiter), Member = "get_IsCompleted", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ConfiguredTaskAwaitable.ConfiguredTaskAwaiter), Member = "GetResult", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CancellationTokenSource), Member = "Cancel", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CancellationTokenSource), Member = "Dispose", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetResult", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsyncTaskMethodBuilder[]), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new object[]
			{
				typeof(ConfiguredTaskAwaitable<object>.ConfiguredTaskAwaiter),
				typeof(WebRequestStream.<WriteChunkTrailer>d__40)
			}, MemberParameters = new object[]
			{
				typeof(ref ConfiguredTaskAwaitable<object>.ConfiguredTaskAwaiter),
				typeof(ref WebRequestStream.<WriteChunkTrailer>d__40)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsyncTaskMethodBuilder[]), Member = "AwaitUnsafeOnCompleted", MemberTypeParameters = new object[]
			{
				typeof(ConfiguredTaskAwaitable.ConfiguredTaskAwaiter),
				typeof(WebRequestStream.<WriteChunkTrailer>d__40)
			}, MemberParameters = new object[]
			{
				typeof(ref ConfiguredTaskAwaitable.ConfiguredTaskAwaiter),
				typeof(ref WebRequestStream.<WriteChunkTrailer>d__40)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetException", MemberParameters = new object[] { typeof(Exception) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 48)]
			private void MoveNext()
			{
				throw null;
			}

			// Token: 0x06001E88 RID: 7816 RVA: 0x00008417 File Offset: 0x00006617
			[DebuggerHidden]
			[global::Cpp2ILInjected.Token(Token = "0x6001253")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E19498", Offset = "0x1E19498", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsyncTaskMethodBuilder), Member = "SetStateMachine", MemberParameters = new object[] { typeof(IAsyncStateMachine) }, ReturnType = typeof(void))]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				throw null;
			}

			// Token: 0x04001327 RID: 4903
			[global::Cpp2ILInjected.Token(Token = "0x4000E54")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			public int <>1__state;

			// Token: 0x04001328 RID: 4904
			[global::Cpp2ILInjected.Token(Token = "0x4000E55")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x8")]
			public AsyncTaskMethodBuilder <>t__builder;

			// Token: 0x04001329 RID: 4905
			[global::Cpp2ILInjected.Token(Token = "0x4000E56")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
			public WebRequestStream <>4__this;

			// Token: 0x0400132A RID: 4906
			[global::Cpp2ILInjected.Token(Token = "0x4000E57")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
			private CancellationTokenSource <cts>5__2;

			// Token: 0x0400132B RID: 4907
			[global::Cpp2ILInjected.Token(Token = "0x4000E58")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
			private Task <timeoutTask>5__3;

			// Token: 0x0400132C RID: 4908
			[global::Cpp2ILInjected.Token(Token = "0x4000E59")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
			private ConfiguredTaskAwaitable<Task>.ConfiguredTaskAwaiter <>u__1;

			// Token: 0x0400132D RID: 4909
			[global::Cpp2ILInjected.Token(Token = "0x4000E5A")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
			private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter <>u__2;
		}
	}
}
