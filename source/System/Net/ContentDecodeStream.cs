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
	[global::Cpp2ILInjected.Token(Token = "0x2000234")]
	internal class ContentDecodeStream : WebReadStream
	{
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

		[global::Cpp2ILInjected.Token(Token = "0x6000E26")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F401C0", Offset = "0x1F401C0", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		protected override Task<int> ProcessReadAsync(byte[] buffer, int offset, int size, CancellationToken cancellationToken)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000E27")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F401D4", Offset = "0x1F401D4", Length = "0xF0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		internal override Task FinishReading(CancellationToken cancellationToken)
		{
			throw null;
		}

		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x4000BC4")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
		private readonly Stream <OriginalInnerStream>k__BackingField;

		[global::Cpp2ILInjected.Token(Token = "0x2000235")]
		internal enum Mode
		{
			[global::Cpp2ILInjected.Token(Token = "0x4000BC6")]
			GZip,
			[global::Cpp2ILInjected.Token(Token = "0x4000BC7")]
			Deflate
		}
	}
}
