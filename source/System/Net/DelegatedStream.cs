using System;
using System.IO;
using System.Net.Mime;
using System.Net.Sockets;
using System.Threading;
using System.Threading.Tasks;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Net
{
	// Token: 0x020000D4 RID: 212
	[global::Cpp2ILInjected.Token(Token = "0x2000139")]
	internal class DelegatedStream : Stream
	{
		// Token: 0x060006A0 RID: 1696 RVA: 0x00004133 File Offset: 0x00002333
		[global::Cpp2ILInjected.Token(Token = "0x6000761")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EE5824", Offset = "0x1EE5824", Length = "0x104")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Base64Stream), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(Stream),
			typeof(Base64WriteStateInfo)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Base64Stream), Member = ".ctor", MemberParameters = new object[] { typeof(Base64WriteStateInfo) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ClosableStream), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(Stream),
			typeof(EventHandler)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Stream), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		protected DelegatedStream(Stream stream)
		{
			throw null;
		}

		// Token: 0x1700017E RID: 382
		// (get) Token: 0x060006A1 RID: 1697 RVA: 0x00004136 File Offset: 0x00002336
		[global::Cpp2ILInjected.Token(Token = "0x17000188")]
		protected Stream BaseStream
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000762")]
			[global::Cpp2ILInjected.Address(RVA = "0x1EE76F4", Offset = "0x1EE76F4", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700017F RID: 383
		// (get) Token: 0x060006A2 RID: 1698 RVA: 0x00004139 File Offset: 0x00002339
		[global::Cpp2ILInjected.Token(Token = "0x17000189")]
		public override bool CanRead
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000763")]
			[global::Cpp2ILInjected.Address(RVA = "0x1EE76FC", Offset = "0x1EE76FC", Length = "0x10")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000180 RID: 384
		// (get) Token: 0x060006A3 RID: 1699 RVA: 0x0000413C File Offset: 0x0000233C
		[global::Cpp2ILInjected.Token(Token = "0x1700018A")]
		public override bool CanSeek
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000764")]
			[global::Cpp2ILInjected.Address(RVA = "0x1EE770C", Offset = "0x1EE770C", Length = "0x10")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000181 RID: 385
		// (get) Token: 0x060006A4 RID: 1700 RVA: 0x0000413F File Offset: 0x0000233F
		[global::Cpp2ILInjected.Token(Token = "0x1700018B")]
		public override bool CanWrite
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000765")]
			[global::Cpp2ILInjected.Address(RVA = "0x1EE771C", Offset = "0x1EE771C", Length = "0x10")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000182 RID: 386
		// (get) Token: 0x060006A5 RID: 1701 RVA: 0x00004142 File Offset: 0x00002342
		[global::Cpp2ILInjected.Token(Token = "0x1700018C")]
		public override long Length
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000766")]
			[global::Cpp2ILInjected.Address(RVA = "0x1EE772C", Offset = "0x1EE772C", Length = "0x74")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NotSupportedException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000183 RID: 387
		// (get) Token: 0x060006A6 RID: 1702 RVA: 0x00004145 File Offset: 0x00002345
		// (set) Token: 0x060006A7 RID: 1703 RVA: 0x00004148 File Offset: 0x00002348
		[global::Cpp2ILInjected.Token(Token = "0x1700018D")]
		public override long Position
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000767")]
			[global::Cpp2ILInjected.Address(RVA = "0x1EE77A0", Offset = "0x1EE77A0", Length = "0x74")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NotSupportedException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6000768")]
			[global::Cpp2ILInjected.Address(RVA = "0x1EE7814", Offset = "0x1EE7814", Length = "0x8C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NotSupportedException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
			set
			{
				throw null;
			}
		}

		// Token: 0x060006A8 RID: 1704 RVA: 0x0000414B File Offset: 0x0000234B
		[global::Cpp2ILInjected.Token(Token = "0x6000769")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EE78A0", Offset = "0x1EE78A0", Length = "0xC4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NotSupportedException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		public override IAsyncResult BeginRead(byte[] buffer, int offset, int count, AsyncCallback callback, object state)
		{
			throw null;
		}

		// Token: 0x060006A9 RID: 1705 RVA: 0x0000414E File Offset: 0x0000234E
		[global::Cpp2ILInjected.Token(Token = "0x600076A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EE7964", Offset = "0x1EE7964", Length = "0xC4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NotSupportedException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		public override IAsyncResult BeginWrite(byte[] buffer, int offset, int count, AsyncCallback callback, object state)
		{
			throw null;
		}

		// Token: 0x060006AA RID: 1706 RVA: 0x00004151 File Offset: 0x00002351
		[global::Cpp2ILInjected.Token(Token = "0x600076B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EE61BC", Offset = "0x1EE61BC", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public override void Close()
		{
			throw null;
		}

		// Token: 0x060006AB RID: 1707 RVA: 0x00004154 File Offset: 0x00002354
		[global::Cpp2ILInjected.Token(Token = "0x600076C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EE7A28", Offset = "0x1EE7A28", Length = "0x8C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NotSupportedException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		public override int EndRead(IAsyncResult asyncResult)
		{
			throw null;
		}

		// Token: 0x060006AC RID: 1708 RVA: 0x00004157 File Offset: 0x00002357
		[global::Cpp2ILInjected.Token(Token = "0x600076D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EE7AB4", Offset = "0x1EE7AB4", Length = "0x8C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NotSupportedException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		public override void EndWrite(IAsyncResult asyncResult)
		{
			throw null;
		}

		// Token: 0x060006AD RID: 1709 RVA: 0x0000415A File Offset: 0x0000235A
		[global::Cpp2ILInjected.Token(Token = "0x600076E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EE6BE8", Offset = "0x1EE6BE8", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public override void Flush()
		{
			throw null;
		}

		// Token: 0x060006AE RID: 1710 RVA: 0x0000415D File Offset: 0x0000235D
		[global::Cpp2ILInjected.Token(Token = "0x600076F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EE7B40", Offset = "0x1EE7B40", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public override Task FlushAsync(CancellationToken cancellationToken)
		{
			throw null;
		}

		// Token: 0x060006AF RID: 1711 RVA: 0x00004160 File Offset: 0x00002360
		[global::Cpp2ILInjected.Token(Token = "0x6000770")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EE6DBC", Offset = "0x1EE6DBC", Length = "0xA4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Base64Stream), Member = "Read", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NotSupportedException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		public override int Read(byte[] buffer, int offset, int count)
		{
			throw null;
		}

		// Token: 0x060006B0 RID: 1712 RVA: 0x00004163 File Offset: 0x00002363
		[global::Cpp2ILInjected.Token(Token = "0x6000771")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EE7B54", Offset = "0x1EE7B54", Length = "0xAC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NotSupportedException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		public override Task<int> ReadAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken)
		{
			throw null;
		}

		// Token: 0x060006B1 RID: 1713 RVA: 0x00004166 File Offset: 0x00002366
		[global::Cpp2ILInjected.Token(Token = "0x6000772")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EE7C00", Offset = "0x1EE7C00", Length = "0x94")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NotSupportedException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		public override long Seek(long offset, SeekOrigin origin)
		{
			throw null;
		}

		// Token: 0x060006B2 RID: 1714 RVA: 0x00004169 File Offset: 0x00002369
		[global::Cpp2ILInjected.Token(Token = "0x6000773")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EE7C94", Offset = "0x1EE7C94", Length = "0x8C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NotSupportedException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		public override void SetLength(long value)
		{
			throw null;
		}

		// Token: 0x060006B3 RID: 1715 RVA: 0x0000416C File Offset: 0x0000236C
		[global::Cpp2ILInjected.Token(Token = "0x6000774")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EE6BFC", Offset = "0x1EE6BFC", Length = "0xA4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Base64Stream), Member = "FlushInternal", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NotSupportedException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		public override void Write(byte[] buffer, int offset, int count)
		{
			throw null;
		}

		// Token: 0x060006B4 RID: 1716 RVA: 0x0000416F File Offset: 0x0000236F
		[global::Cpp2ILInjected.Token(Token = "0x6000775")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EE7D20", Offset = "0x1EE7D20", Length = "0xAC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NotSupportedException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		public override Task WriteAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken)
		{
			throw null;
		}

		// Token: 0x04000465 RID: 1125
		[global::Cpp2ILInjected.Token(Token = "0x40005EB")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private readonly Stream _stream;

		// Token: 0x04000466 RID: 1126
		[global::Cpp2ILInjected.Token(Token = "0x40005EC")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		private readonly NetworkStream _netStream;
	}
}
