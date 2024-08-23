using System;
using System.IO;
using System.Text;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace Ionic.Zip
{
	// Token: 0x02000016 RID: 22
	[global::Cpp2ILInjected.Token(Token = "0x2000016")]
	internal class OffsetStream : Stream, IDisposable
	{
		// Token: 0x06000057 RID: 87 RVA: 0x00004F8D File Offset: 0x0000318D
		[global::Cpp2ILInjected.Token(Token = "0x6000057")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A45A18", Offset = "0x1A45A18", Length = "0x7C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ZipFile), Member = "Read", MemberParameters = new object[]
		{
			typeof(Stream),
			typeof(TextWriter),
			typeof(Encoding),
			typeof(EventHandler<ReadProgressEventArgs>)
		}, ReturnType = typeof(ZipFile))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Stream), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public OffsetStream(Stream s)
		{
			throw null;
		}

		// Token: 0x06000058 RID: 88 RVA: 0x00004F90 File Offset: 0x00003190
		[global::Cpp2ILInjected.Token(Token = "0x6000058")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A45A94", Offset = "0x1A45A94", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public override int Read(byte[] buffer, int offset, int count)
		{
			throw null;
		}

		// Token: 0x06000059 RID: 89 RVA: 0x00004F93 File Offset: 0x00003193
		[global::Cpp2ILInjected.Token(Token = "0x6000059")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A45AA8", Offset = "0x1A45AA8", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NotImplementedException), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public override void Write(byte[] buffer, int offset, int count)
		{
			throw null;
		}

		// Token: 0x1700000D RID: 13
		// (get) Token: 0x0600005A RID: 90 RVA: 0x00004F96 File Offset: 0x00003196
		[global::Cpp2ILInjected.Token(Token = "0x1700000D")]
		public override bool CanRead
		{
			[global::Cpp2ILInjected.Token(Token = "0x600005A")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A45AE0", Offset = "0x1A45AE0", Length = "0x10")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700000E RID: 14
		// (get) Token: 0x0600005B RID: 91 RVA: 0x00004F99 File Offset: 0x00003199
		[global::Cpp2ILInjected.Token(Token = "0x1700000E")]
		public override bool CanSeek
		{
			[global::Cpp2ILInjected.Token(Token = "0x600005B")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A45AF0", Offset = "0x1A45AF0", Length = "0x10")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700000F RID: 15
		// (get) Token: 0x0600005C RID: 92 RVA: 0x00004F9C File Offset: 0x0000319C
		[global::Cpp2ILInjected.Token(Token = "0x1700000F")]
		public override bool CanWrite
		{
			[global::Cpp2ILInjected.Token(Token = "0x600005C")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A45B00", Offset = "0x1A45B00", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0600005D RID: 93 RVA: 0x00004F9F File Offset: 0x0000319F
		[global::Cpp2ILInjected.Token(Token = "0x600005D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A45B08", Offset = "0x1A45B08", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public override void Flush()
		{
			throw null;
		}

		// Token: 0x17000010 RID: 16
		// (get) Token: 0x0600005E RID: 94 RVA: 0x00004FA2 File Offset: 0x000031A2
		[global::Cpp2ILInjected.Token(Token = "0x17000010")]
		public override long Length
		{
			[global::Cpp2ILInjected.Token(Token = "0x600005E")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A45B1C", Offset = "0x1A45B1C", Length = "0x10")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000011 RID: 17
		// (get) Token: 0x0600005F RID: 95 RVA: 0x00004FA5 File Offset: 0x000031A5
		// (set) Token: 0x06000060 RID: 96 RVA: 0x00004FA8 File Offset: 0x000031A8
		[global::Cpp2ILInjected.Token(Token = "0x17000011")]
		public override long Position
		{
			[global::Cpp2ILInjected.Token(Token = "0x600005F")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A45B2C", Offset = "0x1A45B2C", Length = "0x28")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6000060")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A45B54", Offset = "0x1A45B54", Length = "0x1C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			set
			{
				throw null;
			}
		}

		// Token: 0x06000061 RID: 97 RVA: 0x00004FAB File Offset: 0x000031AB
		[global::Cpp2ILInjected.Token(Token = "0x6000061")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A45B70", Offset = "0x1A45B70", Length = "0x34")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public override long Seek(long offset, SeekOrigin origin)
		{
			throw null;
		}

		// Token: 0x06000062 RID: 98 RVA: 0x00004FAE File Offset: 0x000031AE
		[global::Cpp2ILInjected.Token(Token = "0x6000062")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A45BA4", Offset = "0x1A45BA4", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NotImplementedException), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public override void SetLength(long value)
		{
			throw null;
		}

		// Token: 0x06000063 RID: 99 RVA: 0x00004FB1 File Offset: 0x000031B1
		[global::Cpp2ILInjected.Token(Token = "0x6000063")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A45BDC", Offset = "0x1A45BDC", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		private void System.IDisposable.Dispose()
		{
			throw null;
		}

		// Token: 0x06000064 RID: 100 RVA: 0x00004FB4 File Offset: 0x000031B4
		[global::Cpp2ILInjected.Token(Token = "0x6000064")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A45BEC", Offset = "0x1A45BEC", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Stream), Member = "Close", ReturnType = typeof(void))]
		public override void Close()
		{
			throw null;
		}

		// Token: 0x0400002E RID: 46
		[global::Cpp2ILInjected.Token(Token = "0x400002E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private long _originalPosition;

		// Token: 0x0400002F RID: 47
		[global::Cpp2ILInjected.Token(Token = "0x400002F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		private Stream _innerStream;
	}
}
