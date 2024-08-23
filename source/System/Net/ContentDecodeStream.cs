using System;
using System.IO;
using System.IO.Compression;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Net
{
	// Token: 0x02000189 RID: 393
	[global::Cpp2ILInjected.Token(Token = "0x2000234")]
	internal class ContentDecodeStream : WebReadStream
	{
		// Token: 0x06000CB9 RID: 3257 RVA: 0x00005273 File Offset: 0x00003473
		[global::Cpp2ILInjected.Token(Token = "0x6000E23")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F400B4", Offset = "0x1F400B4", Length = "0xDC")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebResponseStream), Member = "Initialize", MemberParameters = new object[] { typeof(BufferOffsetSize) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DeflateStream), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(Stream),
			typeof(CompressionMode)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GZipStream), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(Stream),
			typeof(CompressionMode)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebReadStream), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(WebOperation),
			typeof(Stream)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		public static ContentDecodeStream Create(WebOperation operation, Stream innerStream, ContentDecodeStream.Mode mode)
		{
			throw null;
		}

		// Token: 0x170002D7 RID: 727
		// (get) Token: 0x06000CBA RID: 3258 RVA: 0x00005276 File Offset: 0x00003476
		[global::Cpp2ILInjected.Token(Token = "0x170002F2")]
		private Stream OriginalInnerStream
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6000E24")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F401B8", Offset = "0x1F401B8", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06000CBB RID: 3259 RVA: 0x00005279 File Offset: 0x00003479
		[global::Cpp2ILInjected.Token(Token = "0x6000E25")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F40190", Offset = "0x1F40190", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WebReadStream), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(WebOperation),
			typeof(Stream)
		}, ReturnType = typeof(void))]
		private ContentDecodeStream(WebOperation operation, Stream decodeStream, Stream originalInnerStream)
		{
			throw null;
		}

		// Token: 0x06000CBC RID: 3260 RVA: 0x0000527C File Offset: 0x0000347C
		[global::Cpp2ILInjected.Token(Token = "0x6000E26")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F401C0", Offset = "0x1F401C0", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		protected override Task<int> ProcessReadAsync(byte[] buffer, int offset, int size, CancellationToken cancellationToken)
		{
			throw null;
		}

		// Token: 0x06000CBD RID: 3261 RVA: 0x0000527F File Offset: 0x0000347F
		[global::Cpp2ILInjected.Token(Token = "0x6000E27")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F401D4", Offset = "0x1F401D4", Length = "0xF0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		internal override Task FinishReading(CancellationToken cancellationToken)
		{
			throw null;
		}

		// Token: 0x0400091F RID: 2335
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x4000BC4")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
		private readonly Stream <OriginalInnerStream>k__BackingField;

		// Token: 0x0200040F RID: 1039
		[global::Cpp2ILInjected.Token(Token = "0x2000235")]
		internal enum Mode
		{
			// Token: 0x0400122F RID: 4655
			[global::Cpp2ILInjected.Token(Token = "0x4000BC6")]
			GZip,
			// Token: 0x04001230 RID: 4656
			[global::Cpp2ILInjected.Token(Token = "0x4000BC7")]
			Deflate
		}
	}
}
