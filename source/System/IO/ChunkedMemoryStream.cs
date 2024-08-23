using System;
using System.Net;
using System.Threading;
using System.Threading.Tasks;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.IO
{
	// Token: 0x02000317 RID: 791
	[global::Cpp2ILInjected.Token(Token = "0x2000439")]
	internal sealed class ChunkedMemoryStream : Stream
	{
		// Token: 0x06001A43 RID: 6723 RVA: 0x00007826 File Offset: 0x00005A26
		[global::Cpp2ILInjected.Token(Token = "0x6001D8E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E93478", Offset = "0x1E93478", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.WebClient.<UploadBitsAsync>d__152", Member = "MoveNext", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebClient), Member = "DownloadDataInternal", MemberParameters = new object[]
		{
			typeof(Uri),
			typeof(ref WebRequest)
		}, ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebClient), Member = "UploadBits", MemberParameters = new object[]
		{
			typeof(WebRequest),
			typeof(Stream),
			typeof(byte[]),
			typeof(int),
			typeof(byte[]),
			typeof(byte[])
		}, ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebClient), Member = "DownloadStringAsync", MemberParameters = new object[]
		{
			typeof(Uri),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebClient), Member = "DownloadDataAsync", MemberParameters = new object[]
		{
			typeof(Uri),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Stream), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		internal ChunkedMemoryStream()
		{
			throw null;
		}

		// Token: 0x06001A44 RID: 6724 RVA: 0x00007829 File Offset: 0x00005A29
		[global::Cpp2ILInjected.Token(Token = "0x6001D8F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E934D0", Offset = "0x1E934D0", Length = "0x8C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.WebClient.<DownloadBitsAsync>d__150", Member = "MoveNext", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebClient), Member = "DownloadBits", MemberParameters = new object[]
		{
			typeof(WebRequest),
			typeof(Stream)
		}, ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Buffer), Member = "BlockCopy", MemberParameters = new object[]
		{
			typeof(Array),
			typeof(int),
			typeof(Array),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public byte[] ToArray()
		{
			throw null;
		}

		// Token: 0x06001A45 RID: 6725 RVA: 0x0000782C File Offset: 0x00005A2C
		[global::Cpp2ILInjected.Token(Token = "0x6001D90")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E9355C", Offset = "0x1E9355C", Length = "0x108")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ChunkedMemoryStream), Member = "AppendChunk", MemberParameters = new object[] { typeof(long) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Math), Member = "Min", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Buffer), Member = "BlockCopy", MemberParameters = new object[]
		{
			typeof(Array),
			typeof(int),
			typeof(Array),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public override void Write(byte[] buffer, int offset, int count)
		{
			throw null;
		}

		// Token: 0x06001A46 RID: 6726 RVA: 0x0000782F File Offset: 0x00005A2F
		[global::Cpp2ILInjected.Token(Token = "0x6001D91")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E93744", Offset = "0x1E93744", Length = "0x100")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CancellationToken), Member = "get_IsCancellationRequested", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Task), Member = "FromCanceled", MemberParameters = new object[] { typeof(CancellationToken) }, ReturnType = typeof(Task))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public override Task WriteAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken)
		{
			throw null;
		}

		// Token: 0x06001A47 RID: 6727 RVA: 0x00007832 File Offset: 0x00005A32
		[global::Cpp2ILInjected.Token(Token = "0x6001D92")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E93664", Offset = "0x1E93664", Length = "0xE0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ChunkedMemoryStream), Member = "Write", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ChunkedMemoryStream), Member = "SetLength", MemberParameters = new object[] { typeof(long) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Math), Member = "Min", MemberParameters = new object[]
		{
			typeof(long),
			typeof(long)
		}, ReturnType = typeof(long))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ChunkedMemoryStream.MemoryChunk), Member = ".ctor", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		private void AppendChunk(long count)
		{
			throw null;
		}

		// Token: 0x17000642 RID: 1602
		// (get) Token: 0x06001A48 RID: 6728 RVA: 0x00007835 File Offset: 0x00005A35
		[global::Cpp2ILInjected.Token(Token = "0x170006AC")]
		public override bool CanRead
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001D93")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E938AC", Offset = "0x1E938AC", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000643 RID: 1603
		// (get) Token: 0x06001A49 RID: 6729 RVA: 0x00007838 File Offset: 0x00005A38
		[global::Cpp2ILInjected.Token(Token = "0x170006AD")]
		public override bool CanSeek
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001D94")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E938B4", Offset = "0x1E938B4", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000644 RID: 1604
		// (get) Token: 0x06001A4A RID: 6730 RVA: 0x0000783B File Offset: 0x00005A3B
		[global::Cpp2ILInjected.Token(Token = "0x170006AE")]
		public override bool CanWrite
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001D95")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E938BC", Offset = "0x1E938BC", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000645 RID: 1605
		// (get) Token: 0x06001A4B RID: 6731 RVA: 0x0000783E File Offset: 0x00005A3E
		[global::Cpp2ILInjected.Token(Token = "0x170006AF")]
		public override long Length
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001D96")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E938C4", Offset = "0x1E938C4", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06001A4C RID: 6732 RVA: 0x00007841 File Offset: 0x00005A41
		[global::Cpp2ILInjected.Token(Token = "0x6001D97")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E938CC", Offset = "0x1E938CC", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public override void Flush()
		{
			throw null;
		}

		// Token: 0x06001A4D RID: 6733 RVA: 0x00007844 File Offset: 0x00005A44
		[global::Cpp2ILInjected.Token(Token = "0x6001D98")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E938D0", Offset = "0x1E938D0", Length = "0x88")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public override Task FlushAsync(CancellationToken cancellationToken)
		{
			throw null;
		}

		// Token: 0x17000646 RID: 1606
		// (get) Token: 0x06001A4E RID: 6734 RVA: 0x00007847 File Offset: 0x00005A47
		// (set) Token: 0x06001A4F RID: 6735 RVA: 0x0000784A File Offset: 0x00005A4A
		[global::Cpp2ILInjected.Token(Token = "0x170006B0")]
		public override long Position
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001D99")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E93958", Offset = "0x1E93958", Length = "0x38")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6001D9A")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E93990", Offset = "0x1E93990", Length = "0x38")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
			set
			{
				throw null;
			}
		}

		// Token: 0x06001A50 RID: 6736 RVA: 0x0000784D File Offset: 0x00005A4D
		[global::Cpp2ILInjected.Token(Token = "0x6001D9B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E939C8", Offset = "0x1E939C8", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public override int Read(byte[] buffer, int offset, int count)
		{
			throw null;
		}

		// Token: 0x06001A51 RID: 6737 RVA: 0x00007850 File Offset: 0x00005A50
		[global::Cpp2ILInjected.Token(Token = "0x6001D9C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E93A00", Offset = "0x1E93A00", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public override long Seek(long offset, SeekOrigin origin)
		{
			throw null;
		}

		// Token: 0x06001A52 RID: 6738 RVA: 0x00007853 File Offset: 0x00005A53
		[global::Cpp2ILInjected.Token(Token = "0x6001D9D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E93A38", Offset = "0x1E93A38", Length = "0x48")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ChunkedMemoryStream), Member = "AppendChunk", MemberParameters = new object[] { typeof(long) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public override void SetLength(long value)
		{
			throw null;
		}

		// Token: 0x04000F92 RID: 3986
		[global::Cpp2ILInjected.Token(Token = "0x4001400")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private ChunkedMemoryStream.MemoryChunk _headChunk;

		// Token: 0x04000F93 RID: 3987
		[global::Cpp2ILInjected.Token(Token = "0x4001401")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		private ChunkedMemoryStream.MemoryChunk _currentChunk;

		// Token: 0x04000F94 RID: 3988
		[global::Cpp2ILInjected.Token(Token = "0x4001402")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		private int _totalLength;

		// Token: 0x0200047F RID: 1151
		[global::Cpp2ILInjected.Token(Token = "0x200043A")]
		private sealed class MemoryChunk
		{
			// Token: 0x06001FB4 RID: 8116 RVA: 0x0000879B File Offset: 0x0000699B
			[global::Cpp2ILInjected.Token(Token = "0x6001D9E")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E93844", Offset = "0x1E93844", Length = "0x68")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ChunkedMemoryStream), Member = "AppendChunk", MemberParameters = new object[] { typeof(long) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			internal MemoryChunk(int bufferSize)
			{
				throw null;
			}

			// Token: 0x040013E5 RID: 5093
			[global::Cpp2ILInjected.Token(Token = "0x4001403")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
			internal readonly byte[] _buffer;

			// Token: 0x040013E6 RID: 5094
			[global::Cpp2ILInjected.Token(Token = "0x4001404")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
			internal int _freeOffset;

			// Token: 0x040013E7 RID: 5095
			[global::Cpp2ILInjected.Token(Token = "0x4001405")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
			internal ChunkedMemoryStream.MemoryChunk _next;
		}
	}
}
