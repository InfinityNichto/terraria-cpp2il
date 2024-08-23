using System;
using System.IO;
using System.Runtime.InteropServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Net
{
	// Token: 0x020001AA RID: 426
	[global::Cpp2ILInjected.Token(Token = "0x200026C")]
	internal class RequestStream : Stream
	{
		// Token: 0x06000EFE RID: 3838 RVA: 0x0000592D File Offset: 0x00003B2D
		[global::Cpp2ILInjected.Token(Token = "0x60010A0")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E03A88", Offset = "0x1E03A88", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ChunkedInputStream), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(HttpListenerContext),
			typeof(Stream),
			typeof(byte[]),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		internal RequestStream(Stream stream, byte[] buffer, int offset, int length)
		{
			throw null;
		}

		// Token: 0x06000EFF RID: 3839 RVA: 0x00005930 File Offset: 0x00003B30
		[global::Cpp2ILInjected.Token(Token = "0x60010A1")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E03A90", Offset = "0x1E03A90", Length = "0x98")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HttpConnection), Member = "GetRequestStream", MemberParameters = new object[]
		{
			typeof(bool),
			typeof(long)
		}, ReturnType = typeof(RequestStream))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Stream), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		internal RequestStream(Stream stream, byte[] buffer, int offset, int length, long contentlength)
		{
			throw null;
		}

		// Token: 0x1700039B RID: 923
		// (get) Token: 0x06000F00 RID: 3840 RVA: 0x00005933 File Offset: 0x00003B33
		[global::Cpp2ILInjected.Token(Token = "0x170003B9")]
		public override bool CanRead
		{
			[global::Cpp2ILInjected.Token(Token = "0x60010A2")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E03B28", Offset = "0x1E03B28", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700039C RID: 924
		// (get) Token: 0x06000F01 RID: 3841 RVA: 0x00005936 File Offset: 0x00003B36
		[global::Cpp2ILInjected.Token(Token = "0x170003BA")]
		public override bool CanSeek
		{
			[global::Cpp2ILInjected.Token(Token = "0x60010A3")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E03B30", Offset = "0x1E03B30", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700039D RID: 925
		// (get) Token: 0x06000F02 RID: 3842 RVA: 0x00005939 File Offset: 0x00003B39
		[global::Cpp2ILInjected.Token(Token = "0x170003BB")]
		public override bool CanWrite
		{
			[global::Cpp2ILInjected.Token(Token = "0x60010A4")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E03B38", Offset = "0x1E03B38", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700039E RID: 926
		// (get) Token: 0x06000F03 RID: 3843 RVA: 0x0000593C File Offset: 0x00003B3C
		[global::Cpp2ILInjected.Token(Token = "0x170003BC")]
		public override long Length
		{
			[global::Cpp2ILInjected.Token(Token = "0x60010A5")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E03B40", Offset = "0x1E03B40", Length = "0x38")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700039F RID: 927
		// (get) Token: 0x06000F04 RID: 3844 RVA: 0x0000593F File Offset: 0x00003B3F
		// (set) Token: 0x06000F05 RID: 3845 RVA: 0x00005942 File Offset: 0x00003B42
		[global::Cpp2ILInjected.Token(Token = "0x170003BD")]
		public override long Position
		{
			[global::Cpp2ILInjected.Token(Token = "0x60010A6")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E03B78", Offset = "0x1E03B78", Length = "0x38")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x60010A7")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E03BB0", Offset = "0x1E03BB0", Length = "0x38")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
			set
			{
				throw null;
			}
		}

		// Token: 0x06000F06 RID: 3846 RVA: 0x00005945 File Offset: 0x00003B45
		[global::Cpp2ILInjected.Token(Token = "0x60010A8")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E03BE8", Offset = "0x1E03BE8", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ChunkedInputStream), Member = "Close", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		public override void Close()
		{
			throw null;
		}

		// Token: 0x06000F07 RID: 3847 RVA: 0x00005948 File Offset: 0x00003B48
		[global::Cpp2ILInjected.Token(Token = "0x60010A9")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E03BF4", Offset = "0x1E03BF4", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public override void Flush()
		{
			throw null;
		}

		// Token: 0x06000F08 RID: 3848 RVA: 0x0000594B File Offset: 0x00003B4B
		[global::Cpp2ILInjected.Token(Token = "0x60010AA")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E03BF8", Offset = "0x1E03BF8", Length = "0x280")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RequestStream), Member = "Read", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(RequestStream), Member = "BeginRead", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int),
			typeof(int),
			typeof(AsyncCallback),
			typeof(object)
		}, ReturnType = typeof(IAsyncResult))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Math), Member = "Min", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Math), Member = "Min", MemberParameters = new object[]
		{
			typeof(long),
			typeof(long)
		}, ReturnType = typeof(long))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Buffer), Member = "BlockCopy", MemberParameters = new object[]
		{
			typeof(Array),
			typeof(int),
			typeof(Array),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 20)]
		private int FillFromBuffer(byte[] buffer, int off, int count)
		{
			throw null;
		}

		// Token: 0x06000F09 RID: 3849 RVA: 0x0000594E File Offset: 0x00003B4E
		[global::Cpp2ILInjected.Token(Token = "0x60010AB")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E03E78", Offset = "0x1E03E78", Length = "0x100")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RequestStream), Member = "FillFromBuffer", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(RuntimeTypeHandle) }, ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ObjectDisposedException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public override int Read([In] [Out] byte[] buffer, int offset, int count)
		{
			throw null;
		}

		// Token: 0x06000F0A RID: 3850 RVA: 0x00005951 File Offset: 0x00003B51
		[global::Cpp2ILInjected.Token(Token = "0x60010AC")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E03F78", Offset = "0x1E03F78", Length = "0x1EC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ChunkedInputStream), Member = "BeginRead", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int),
			typeof(int),
			typeof(AsyncCallback),
			typeof(object)
		}, ReturnType = typeof(IAsyncResult))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ChunkedInputStream), Member = "OnRead", MemberParameters = new object[] { typeof(IAsyncResult) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RequestStream), Member = "FillFromBuffer", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Math), Member = "Min", MemberParameters = new object[]
		{
			typeof(long),
			typeof(long)
		}, ReturnType = typeof(long))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HttpStreamAsyncResult), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Math), Member = "Max", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HttpStreamAsyncResult), Member = "Complete", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(RuntimeTypeHandle) }, ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ObjectDisposedException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 13)]
		public override IAsyncResult BeginRead(byte[] buffer, int offset, int count, AsyncCallback cback, object state)
		{
			throw null;
		}

		// Token: 0x06000F0B RID: 3851 RVA: 0x00005954 File Offset: 0x00003B54
		[global::Cpp2ILInjected.Token(Token = "0x60010AD")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E04164", Offset = "0x1E04164", Length = "0x278")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ChunkedInputStream), Member = "OnRead", MemberParameters = new object[] { typeof(IAsyncResult) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(RuntimeTypeHandle) }, ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ObjectDisposedException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 17)]
		public override int EndRead(IAsyncResult ares)
		{
			throw null;
		}

		// Token: 0x06000F0C RID: 3852 RVA: 0x00005957 File Offset: 0x00003B57
		[global::Cpp2ILInjected.Token(Token = "0x60010AE")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E043DC", Offset = "0x1E043DC", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public override long Seek(long offset, SeekOrigin origin)
		{
			throw null;
		}

		// Token: 0x06000F0D RID: 3853 RVA: 0x0000595A File Offset: 0x00003B5A
		[global::Cpp2ILInjected.Token(Token = "0x60010AF")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E04414", Offset = "0x1E04414", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public override void SetLength(long value)
		{
			throw null;
		}

		// Token: 0x06000F0E RID: 3854 RVA: 0x0000595D File Offset: 0x00003B5D
		[global::Cpp2ILInjected.Token(Token = "0x60010B0")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E0444C", Offset = "0x1E0444C", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public override void Write(byte[] buffer, int offset, int count)
		{
			throw null;
		}

		// Token: 0x06000F0F RID: 3855 RVA: 0x00005960 File Offset: 0x00003B60
		[global::Cpp2ILInjected.Token(Token = "0x60010B1")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E04484", Offset = "0x1E04484", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public override IAsyncResult BeginWrite(byte[] buffer, int offset, int count, AsyncCallback cback, object state)
		{
			throw null;
		}

		// Token: 0x06000F10 RID: 3856 RVA: 0x00005963 File Offset: 0x00003B63
		[global::Cpp2ILInjected.Token(Token = "0x60010B2")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E044BC", Offset = "0x1E044BC", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public override void EndWrite(IAsyncResult async_result)
		{
			throw null;
		}

		// Token: 0x04000A1E RID: 2590
		[global::Cpp2ILInjected.Token(Token = "0x4000D20")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private byte[] buffer;

		// Token: 0x04000A1F RID: 2591
		[global::Cpp2ILInjected.Token(Token = "0x4000D21")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		private int offset;

		// Token: 0x04000A20 RID: 2592
		[global::Cpp2ILInjected.Token(Token = "0x4000D22")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x34")]
		private int length;

		// Token: 0x04000A21 RID: 2593
		[global::Cpp2ILInjected.Token(Token = "0x4000D23")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		private long remaining_body;

		// Token: 0x04000A22 RID: 2594
		[global::Cpp2ILInjected.Token(Token = "0x4000D24")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
		private bool disposed;

		// Token: 0x04000A23 RID: 2595
		[global::Cpp2ILInjected.Token(Token = "0x4000D25")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
		private Stream stream;
	}
}
