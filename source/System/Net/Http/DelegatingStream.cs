using System;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Net.Http
{
	[global::Cpp2ILInjected.Token(Token = "0x200032A")]
	internal abstract class DelegatingStream : Stream
	{
		[global::Cpp2ILInjected.Token(Token = "0x170004CD")]
		public override bool CanRead
		{
			[global::Cpp2ILInjected.Token(Token = "0x60014FA")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E3935C", Offset = "0x1E3935C", Length = "0x10")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x170004CE")]
		public override bool CanSeek
		{
			[global::Cpp2ILInjected.Token(Token = "0x60014FB")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E3936C", Offset = "0x1E3936C", Length = "0x10")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x170004CF")]
		public override bool CanWrite
		{
			[global::Cpp2ILInjected.Token(Token = "0x60014FC")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E3937C", Offset = "0x1E3937C", Length = "0x10")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x170004D0")]
		public override long Length
		{
			[global::Cpp2ILInjected.Token(Token = "0x60014FD")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E3938C", Offset = "0x1E3938C", Length = "0x10")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x170004D1")]
		public override long Position
		{
			[global::Cpp2ILInjected.Token(Token = "0x60014FE")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E3939C", Offset = "0x1E3939C", Length = "0x10")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x60014FF")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E393AC", Offset = "0x1E393AC", Length = "0x14")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			set
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x170004D2")]
		public override int ReadTimeout
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001500")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E393C0", Offset = "0x1E393C0", Length = "0x14")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6001501")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E393D4", Offset = "0x1E393D4", Length = "0x14")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			set
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x170004D3")]
		public override bool CanTimeout
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001502")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E393E8", Offset = "0x1E393E8", Length = "0x10")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x170004D4")]
		public override int WriteTimeout
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001503")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E393F8", Offset = "0x1E393F8", Length = "0x14")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6001504")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E3940C", Offset = "0x1E3940C", Length = "0x14")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			set
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001505")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E39420", Offset = "0x1E39420", Length = "0x6C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.WebClient.WebClientWriteStream", Member = ".ctor", MemberParameters = new object[]
		{
			typeof(Stream),
			typeof(WebRequest),
			typeof(WebClient)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.WebClient.<>c__DisplayClass167_0", Member = "<OpenWriteAsync>b__0", MemberParameters = new object[] { typeof(IAsyncResult) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebClient), Member = "OpenWrite", MemberParameters = new object[]
		{
			typeof(Uri),
			typeof(string)
		}, ReturnType = typeof(Stream))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Stream), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		protected DelegatingStream(Stream innerStream)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001506")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E3948C", Offset = "0x1E3948C", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.WebClient.WebClientWriteStream", Member = "Dispose", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Stream), Member = "Dispose", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Stream), Member = "Dispose", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		protected override void Dispose(bool disposing)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001507")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E394C4", Offset = "0x1E394C4", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public override long Seek(long offset, SeekOrigin origin)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001508")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E394D8", Offset = "0x1E394D8", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public override int Read(byte[] buffer, int offset, int count)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001509")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E394EC", Offset = "0x1E394EC", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public override int Read(Span<byte> buffer)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600150A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E39500", Offset = "0x1E39500", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public override int ReadByte()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600150B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E39514", Offset = "0x1E39514", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public override Task<int> ReadAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600150C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E39528", Offset = "0x1E39528", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public override ValueTask<int> ReadAsync(Memory<byte> buffer, CancellationToken cancellationToken = default(CancellationToken))
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600150D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E3953C", Offset = "0x1E3953C", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public override IAsyncResult BeginRead(byte[] buffer, int offset, int count, AsyncCallback callback, object state)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600150E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E39550", Offset = "0x1E39550", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public override int EndRead(IAsyncResult asyncResult)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600150F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E39564", Offset = "0x1E39564", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public override void Flush()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001510")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E39578", Offset = "0x1E39578", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public override Task FlushAsync(CancellationToken cancellationToken)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001511")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E3958C", Offset = "0x1E3958C", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public override void SetLength(long value)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001512")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E395A0", Offset = "0x1E395A0", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public override void Write(byte[] buffer, int offset, int count)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001513")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E395B4", Offset = "0x1E395B4", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public override void Write(ReadOnlySpan<byte> buffer)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001514")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E395C8", Offset = "0x1E395C8", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public override void WriteByte(byte value)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001515")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E395DC", Offset = "0x1E395DC", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public override Task WriteAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001516")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E395F0", Offset = "0x1E395F0", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public override ValueTask WriteAsync(ReadOnlyMemory<byte> buffer, CancellationToken cancellationToken = default(CancellationToken))
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001517")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E39604", Offset = "0x1E39604", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public override IAsyncResult BeginWrite(byte[] buffer, int offset, int count, AsyncCallback callback, object state)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001518")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E39618", Offset = "0x1E39618", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public override void EndWrite(IAsyncResult asyncResult)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x400116B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private readonly Stream _innerStream;
	}
}
