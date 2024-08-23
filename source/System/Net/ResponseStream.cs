using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Net
{
	// Token: 0x020001AB RID: 427
	[global::Cpp2ILInjected.Token(Token = "0x200026D")]
	internal class ResponseStream : Stream
	{
		// Token: 0x06000F11 RID: 3857 RVA: 0x00005966 File Offset: 0x00003B66
		[global::Cpp2ILInjected.Token(Token = "0x60010B3")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E044F4", Offset = "0x1E044F4", Length = "0x84")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HttpConnection), Member = "GetResponseStream", ReturnType = typeof(ResponseStream))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Stream), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		internal ResponseStream(Stream stream, HttpListenerResponse response, bool ignore_errors)
		{
			throw null;
		}

		// Token: 0x170003A0 RID: 928
		// (get) Token: 0x06000F12 RID: 3858 RVA: 0x00005969 File Offset: 0x00003B69
		[global::Cpp2ILInjected.Token(Token = "0x170003BE")]
		public override bool CanRead
		{
			[global::Cpp2ILInjected.Token(Token = "0x60010B4")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E04578", Offset = "0x1E04578", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170003A1 RID: 929
		// (get) Token: 0x06000F13 RID: 3859 RVA: 0x0000596C File Offset: 0x00003B6C
		[global::Cpp2ILInjected.Token(Token = "0x170003BF")]
		public override bool CanSeek
		{
			[global::Cpp2ILInjected.Token(Token = "0x60010B5")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E04580", Offset = "0x1E04580", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170003A2 RID: 930
		// (get) Token: 0x06000F14 RID: 3860 RVA: 0x0000596F File Offset: 0x00003B6F
		[global::Cpp2ILInjected.Token(Token = "0x170003C0")]
		public override bool CanWrite
		{
			[global::Cpp2ILInjected.Token(Token = "0x60010B6")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E04588", Offset = "0x1E04588", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170003A3 RID: 931
		// (get) Token: 0x06000F15 RID: 3861 RVA: 0x00005972 File Offset: 0x00003B72
		[global::Cpp2ILInjected.Token(Token = "0x170003C1")]
		public override long Length
		{
			[global::Cpp2ILInjected.Token(Token = "0x60010B7")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E04590", Offset = "0x1E04590", Length = "0x38")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170003A4 RID: 932
		// (get) Token: 0x06000F16 RID: 3862 RVA: 0x00005975 File Offset: 0x00003B75
		// (set) Token: 0x06000F17 RID: 3863 RVA: 0x00005978 File Offset: 0x00003B78
		[global::Cpp2ILInjected.Token(Token = "0x170003C2")]
		public override long Position
		{
			[global::Cpp2ILInjected.Token(Token = "0x60010B8")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E045C8", Offset = "0x1E045C8", Length = "0x38")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x60010B9")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E04600", Offset = "0x1E04600", Length = "0x38")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
			set
			{
				throw null;
			}
		}

		// Token: 0x06000F18 RID: 3864 RVA: 0x0000597B File Offset: 0x00003B7B
		[global::Cpp2ILInjected.Token(Token = "0x60010BA")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E04638", Offset = "0x1E04638", Length = "0x244")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ResponseStream), Member = "GetHeaders", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(MemoryStream))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ResponseStream), Member = "GetChunkSizeBytes", MemberParameters = new object[]
		{
			typeof(int),
			typeof(bool)
		}, ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ResponseStream), Member = "InternalWrite", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HttpListenerResponse), Member = "Close", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 12)]
		public override void Close()
		{
			throw null;
		}

		// Token: 0x06000F19 RID: 3865 RVA: 0x0000597E File Offset: 0x00003B7E
		[global::Cpp2ILInjected.Token(Token = "0x60010BB")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E0487C", Offset = "0x1E0487C", Length = "0x130")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ResponseStream), Member = "Close", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ResponseStream), Member = "Write", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ResponseStream), Member = "BeginWrite", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int),
			typeof(int),
			typeof(AsyncCallback),
			typeof(object)
		}, ReturnType = typeof(IAsyncResult))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new object[]
		{
			typeof(object),
			typeof(ref bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MemoryStream), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HttpListenerResponse), Member = "SendHeaders", MemberParameters = new object[]
		{
			typeof(bool),
			typeof(MemoryStream)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		private MemoryStream GetHeaders(bool closing)
		{
			throw null;
		}

		// Token: 0x06000F1A RID: 3866 RVA: 0x00005981 File Offset: 0x00003B81
		[global::Cpp2ILInjected.Token(Token = "0x60010BC")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E04B38", Offset = "0x1E04B38", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public override void Flush()
		{
			throw null;
		}

		// Token: 0x06000F1B RID: 3867 RVA: 0x00005984 File Offset: 0x00003B84
		[global::Cpp2ILInjected.Token(Token = "0x60010BD")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E049AC", Offset = "0x1E049AC", Length = "0xE8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ResponseStream), Member = "Close", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ResponseStream), Member = "Write", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ResponseStream), Member = "BeginWrite", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int),
			typeof(int),
			typeof(AsyncCallback),
			typeof(object)
		}, ReturnType = typeof(IAsyncResult))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 6)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Format", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Encoding), Member = "get_ASCII", ReturnType = typeof(Encoding))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		private static byte[] GetChunkSizeBytes(int size, bool final)
		{
			throw null;
		}

		// Token: 0x06000F1C RID: 3868 RVA: 0x00005987 File Offset: 0x00003B87
		[global::Cpp2ILInjected.Token(Token = "0x60010BE")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E04A94", Offset = "0x1E04A94", Length = "0xA4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HttpListenerRequest), Member = "FinishInitialization", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ResponseStream), Member = "Close", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ResponseStream), Member = "Write", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ResponseStream), Member = "BeginWrite", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int),
			typeof(int),
			typeof(AsyncCallback),
			typeof(object)
		}, ReturnType = typeof(IAsyncResult))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 8)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
		internal void InternalWrite(byte[] buffer, int offset, int count)
		{
			throw null;
		}

		// Token: 0x06000F1D RID: 3869 RVA: 0x0000598A File Offset: 0x00003B8A
		[global::Cpp2ILInjected.Token(Token = "0x60010BF")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E04B3C", Offset = "0x1E04B3C", Length = "0x2D8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ResponseStream), Member = "GetHeaders", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(MemoryStream))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ResponseStream), Member = "GetChunkSizeBytes", MemberParameters = new object[]
		{
			typeof(int),
			typeof(bool)
		}, ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Math), Member = "Min", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ResponseStream), Member = "InternalWrite", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ObjectDisposedException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
		public override void Write(byte[] buffer, int offset, int count)
		{
			throw null;
		}

		// Token: 0x06000F1E RID: 3870 RVA: 0x0000598D File Offset: 0x00003B8D
		[global::Cpp2ILInjected.Token(Token = "0x60010C0")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E04E14", Offset = "0x1E04E14", Length = "0x210")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ResponseStream), Member = "GetHeaders", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(MemoryStream))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ResponseStream), Member = "GetChunkSizeBytes", MemberParameters = new object[]
		{
			typeof(int),
			typeof(bool)
		}, ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ResponseStream), Member = "InternalWrite", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ObjectDisposedException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		public override IAsyncResult BeginWrite(byte[] buffer, int offset, int count, AsyncCallback cback, object state)
		{
			throw null;
		}

		// Token: 0x06000F1F RID: 3871 RVA: 0x00005990 File Offset: 0x00003B90
		[global::Cpp2ILInjected.Token(Token = "0x60010C1")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E05024", Offset = "0x1E05024", Length = "0x1E0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ObjectDisposedException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 17)]
		public override void EndWrite(IAsyncResult ares)
		{
			throw null;
		}

		// Token: 0x06000F20 RID: 3872 RVA: 0x00005993 File Offset: 0x00003B93
		[global::Cpp2ILInjected.Token(Token = "0x60010C2")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E05204", Offset = "0x1E05204", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public override int Read([In] [Out] byte[] buffer, int offset, int count)
		{
			throw null;
		}

		// Token: 0x06000F21 RID: 3873 RVA: 0x00005996 File Offset: 0x00003B96
		[global::Cpp2ILInjected.Token(Token = "0x60010C3")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E0523C", Offset = "0x1E0523C", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public override IAsyncResult BeginRead(byte[] buffer, int offset, int count, AsyncCallback cback, object state)
		{
			throw null;
		}

		// Token: 0x06000F22 RID: 3874 RVA: 0x00005999 File Offset: 0x00003B99
		[global::Cpp2ILInjected.Token(Token = "0x60010C4")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E05274", Offset = "0x1E05274", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public override int EndRead(IAsyncResult ares)
		{
			throw null;
		}

		// Token: 0x06000F23 RID: 3875 RVA: 0x0000599C File Offset: 0x00003B9C
		[global::Cpp2ILInjected.Token(Token = "0x60010C5")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E052AC", Offset = "0x1E052AC", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public override long Seek(long offset, SeekOrigin origin)
		{
			throw null;
		}

		// Token: 0x06000F24 RID: 3876 RVA: 0x0000599F File Offset: 0x00003B9F
		[global::Cpp2ILInjected.Token(Token = "0x60010C6")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E052E4", Offset = "0x1E052E4", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public override void SetLength(long value)
		{
			throw null;
		}

		// Token: 0x06000F25 RID: 3877 RVA: 0x000059A2 File Offset: 0x00003BA2
		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x60010C7")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E0531C", Offset = "0x1E0531C", Length = "0x70")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		static ResponseStream()
		{
			throw null;
		}

		// Token: 0x04000A24 RID: 2596
		[global::Cpp2ILInjected.Token(Token = "0x4000D26")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private HttpListenerResponse response;

		// Token: 0x04000A25 RID: 2597
		[global::Cpp2ILInjected.Token(Token = "0x4000D27")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		private bool ignore_errors;

		// Token: 0x04000A26 RID: 2598
		[global::Cpp2ILInjected.Token(Token = "0x4000D28")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x31")]
		private bool disposed;

		// Token: 0x04000A27 RID: 2599
		[global::Cpp2ILInjected.Token(Token = "0x4000D29")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x32")]
		private bool trailer_sent;

		// Token: 0x04000A28 RID: 2600
		[global::Cpp2ILInjected.Token(Token = "0x4000D2A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		private Stream stream;

		// Token: 0x04000A29 RID: 2601
		[global::Cpp2ILInjected.Token(Token = "0x4000D2B")]
		private static byte[] crlf;
	}
}
