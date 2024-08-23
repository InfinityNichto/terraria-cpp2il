using System;
using System.IO;
using System.Text;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Ionic.Crc;

namespace Ionic.Zip
{
	// Token: 0x02000029 RID: 41
	[global::Cpp2ILInjected.Token(Token = "0x200002F")]
	public class ZipInputStream : Stream
	{
		// Token: 0x06000213 RID: 531 RVA: 0x000054B2 File Offset: 0x000036B2
		[global::Cpp2ILInjected.Token(Token = "0x6000227")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A5F854", Offset = "0x1A5F854", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public ZipInputStream(Stream stream)
		{
			throw null;
		}

		// Token: 0x06000214 RID: 532 RVA: 0x000054B5 File Offset: 0x000036B5
		[global::Cpp2ILInjected.Token(Token = "0x6000228")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A5F8D8", Offset = "0x1A5F8D8", Length = "0x90")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Stream), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(File), Member = "Open", MemberParameters = new object[]
		{
			typeof(string),
			typeof(FileMode),
			typeof(FileAccess),
			typeof(FileShare)
		}, ReturnType = typeof(FileStream))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public ZipInputStream(string fileName)
		{
			throw null;
		}

		// Token: 0x06000215 RID: 533 RVA: 0x000054B8 File Offset: 0x000036B8
		[global::Cpp2ILInjected.Token(Token = "0x6000229")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A5F85C", Offset = "0x1A5F85C", Length = "0x7C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Stream), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZipInputStream), Member = "_Init", MemberParameters = new object[]
		{
			typeof(Stream),
			typeof(bool),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public ZipInputStream(Stream stream, bool leaveOpen)
		{
			throw null;
		}

		// Token: 0x06000216 RID: 534 RVA: 0x000054BB File Offset: 0x000036BB
		[global::Cpp2ILInjected.Token(Token = "0x600022A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A5F968", Offset = "0x1A5F968", Length = "0x12C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ZipInputStream), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(Stream),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZipContainer), Member = ".ctor", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Encoding), Member = "GetEncoding", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(Encoding))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZipException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
		private void _Init(Stream stream, bool leaveOpen, string name)
		{
			throw null;
		}

		// Token: 0x06000217 RID: 535 RVA: 0x000054BE File Offset: 0x000036BE
		[global::Cpp2ILInjected.Token(Token = "0x600022B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A5FBC4", Offset = "0x1A5FBC4", Length = "0x8C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Format", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public override string ToString()
		{
			throw null;
		}

		// Token: 0x17000080 RID: 128
		// (get) Token: 0x06000218 RID: 536 RVA: 0x000054C1 File Offset: 0x000036C1
		// (set) Token: 0x06000219 RID: 537 RVA: 0x000054C4 File Offset: 0x000036C4
		[global::Cpp2ILInjected.Token(Token = "0x17000082")]
		public Encoding ProvisionalAlternateEncoding
		{
			[global::Cpp2ILInjected.Token(Token = "0x600022C")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A5FC50", Offset = "0x1A5FC50", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x600022D")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A5FC58", Offset = "0x1A5FC58", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x17000081 RID: 129
		// (get) Token: 0x0600021A RID: 538 RVA: 0x000054C7 File Offset: 0x000036C7
		// (set) Token: 0x0600021B RID: 539 RVA: 0x000054CA File Offset: 0x000036CA
		[global::Cpp2ILInjected.Token(Token = "0x17000083")]
		public int CodecBufferSize
		{
			[global::Cpp2ILInjected.Token(Token = "0x600022E")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A5FC60", Offset = "0x1A5FC60", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x600022F")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A5FC68", Offset = "0x1A5FC68", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x17000082 RID: 130
		// (set) Token: 0x0600021C RID: 540 RVA: 0x000054CD File Offset: 0x000036CD
		[global::Cpp2ILInjected.Token(Token = "0x17000084")]
		public string Password
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000230")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A5FC70", Offset = "0x1A5FC70", Length = "0x68")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
			set
			{
				throw null;
			}
		}

		// Token: 0x0600021D RID: 541 RVA: 0x000054D0 File Offset: 0x000036D0
		[global::Cpp2ILInjected.Token(Token = "0x6000231")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A5FCD8", Offset = "0x1A5FCD8", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZipEntry), Member = "InternalOpenReader", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(CrcCalculatorStream))]
		private void SetupStream()
		{
			throw null;
		}

		// Token: 0x17000083 RID: 131
		// (get) Token: 0x0600021E RID: 542 RVA: 0x000054D3 File Offset: 0x000036D3
		[global::Cpp2ILInjected.Token(Token = "0x17000085")]
		internal Stream ReadStream
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000232")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A5FD10", Offset = "0x1A5FD10", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0600021F RID: 543 RVA: 0x000054D6 File Offset: 0x000036D6
		[global::Cpp2ILInjected.Token(Token = "0x6000233")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A5FD18", Offset = "0x1A5FD18", Length = "0x18C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZipEntry), Member = "InternalOpenReader", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(CrcCalculatorStream))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CrcCalculatorStream), Member = "get_Crc", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZipEntry), Member = "VerifyCrcAfterExtract", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SharedUtilities), Member = "Workaround_Ladybug318918", MemberParameters = new object[] { typeof(Stream) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public override int Read(byte[] buffer, int offset, int count)
		{
			throw null;
		}

		// Token: 0x06000220 RID: 544 RVA: 0x000054D9 File Offset: 0x000036D9
		[global::Cpp2ILInjected.Token(Token = "0x6000234")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A5FEA4", Offset = "0x1A5FEA4", Length = "0x140")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SharedUtilities), Member = "FindSignature", MemberParameters = new object[]
		{
			typeof(Stream),
			typeof(int)
		}, ReturnType = typeof(long))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SharedUtilities), Member = "Workaround_Ladybug318918", MemberParameters = new object[] { typeof(Stream) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZipEntry), Member = "ReadEntry", MemberParameters = new object[]
		{
			typeof(ZipContainer),
			typeof(bool)
		}, ReturnType = typeof(ZipEntry))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public ZipEntry GetNextEntry()
		{
			throw null;
		}

		// Token: 0x06000221 RID: 545 RVA: 0x000054DC File Offset: 0x000036DC
		[global::Cpp2ILInjected.Token(Token = "0x6000235")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A5FFE4", Offset = "0x1A5FFE4", Length = "0x48")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		protected override void Dispose(bool disposing)
		{
			throw null;
		}

		// Token: 0x17000084 RID: 132
		// (get) Token: 0x06000222 RID: 546 RVA: 0x000054DF File Offset: 0x000036DF
		[global::Cpp2ILInjected.Token(Token = "0x17000086")]
		public override bool CanRead
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000236")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A6002C", Offset = "0x1A6002C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000085 RID: 133
		// (get) Token: 0x06000223 RID: 547 RVA: 0x000054E2 File Offset: 0x000036E2
		[global::Cpp2ILInjected.Token(Token = "0x17000087")]
		public override bool CanSeek
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000237")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A60034", Offset = "0x1A60034", Length = "0x10")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000086 RID: 134
		// (get) Token: 0x06000224 RID: 548 RVA: 0x000054E5 File Offset: 0x000036E5
		[global::Cpp2ILInjected.Token(Token = "0x17000088")]
		public override bool CanWrite
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000238")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A60044", Offset = "0x1A60044", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000087 RID: 135
		// (get) Token: 0x06000225 RID: 549 RVA: 0x000054E8 File Offset: 0x000036E8
		[global::Cpp2ILInjected.Token(Token = "0x17000089")]
		public override long Length
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000239")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A6004C", Offset = "0x1A6004C", Length = "0x10")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000088 RID: 136
		// (get) Token: 0x06000226 RID: 550 RVA: 0x000054EB File Offset: 0x000036EB
		// (set) Token: 0x06000227 RID: 551 RVA: 0x000054EE File Offset: 0x000036EE
		[global::Cpp2ILInjected.Token(Token = "0x1700008A")]
		public override long Position
		{
			[global::Cpp2ILInjected.Token(Token = "0x600023A")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A6005C", Offset = "0x1A6005C", Length = "0x10")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x600023B")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A6006C", Offset = "0x1A6006C", Length = "0x14")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			set
			{
				throw null;
			}
		}

		// Token: 0x06000228 RID: 552 RVA: 0x000054F1 File Offset: 0x000036F1
		[global::Cpp2ILInjected.Token(Token = "0x600023C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A60080", Offset = "0x1A60080", Length = "0x4C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NotSupportedException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public override void Flush()
		{
			throw null;
		}

		// Token: 0x06000229 RID: 553 RVA: 0x000054F4 File Offset: 0x000036F4
		[global::Cpp2ILInjected.Token(Token = "0x600023D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A600CC", Offset = "0x1A600CC", Length = "0x4C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NotSupportedException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public override void Write(byte[] buffer, int offset, int count)
		{
			throw null;
		}

		// Token: 0x0600022A RID: 554 RVA: 0x000054F7 File Offset: 0x000036F7
		[global::Cpp2ILInjected.Token(Token = "0x600023E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A60118", Offset = "0x1A60118", Length = "0xA0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SharedUtilities), Member = "Workaround_Ladybug318918", MemberParameters = new object[] { typeof(Stream) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public override long Seek(long offset, SeekOrigin origin)
		{
			throw null;
		}

		// Token: 0x0600022B RID: 555 RVA: 0x000054FA File Offset: 0x000036FA
		[global::Cpp2ILInjected.Token(Token = "0x600023F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A601B8", Offset = "0x1A601B8", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public override void SetLength(long value)
		{
			throw null;
		}

		// Token: 0x040000FE RID: 254
		[global::Cpp2ILInjected.Token(Token = "0x400010E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private Stream _inputStream;

		// Token: 0x040000FF RID: 255
		[global::Cpp2ILInjected.Token(Token = "0x400010F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		private Encoding _provisionalAlternateEncoding;

		// Token: 0x04000100 RID: 256
		[global::Cpp2ILInjected.Token(Token = "0x4000110")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		private ZipEntry _currentEntry;

		// Token: 0x04000101 RID: 257
		[global::Cpp2ILInjected.Token(Token = "0x4000111")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
		private bool _firstEntry;

		// Token: 0x04000102 RID: 258
		[global::Cpp2ILInjected.Token(Token = "0x4000112")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x41")]
		private bool _needSetup;

		// Token: 0x04000103 RID: 259
		[global::Cpp2ILInjected.Token(Token = "0x4000113")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
		private ZipContainer _container;

		// Token: 0x04000104 RID: 260
		[global::Cpp2ILInjected.Token(Token = "0x4000114")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
		private CrcCalculatorStream _crcStream;

		// Token: 0x04000105 RID: 261
		[global::Cpp2ILInjected.Token(Token = "0x4000115")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x58")]
		private long _LeftToRead;

		// Token: 0x04000106 RID: 262
		[global::Cpp2ILInjected.Token(Token = "0x4000116")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x60")]
		internal string _Password;

		// Token: 0x04000107 RID: 263
		[global::Cpp2ILInjected.Token(Token = "0x4000117")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x68")]
		private long _endOfEntry;

		// Token: 0x04000108 RID: 264
		[global::Cpp2ILInjected.Token(Token = "0x4000118")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x70")]
		private string _name;

		// Token: 0x04000109 RID: 265
		[global::Cpp2ILInjected.Token(Token = "0x4000119")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x78")]
		private bool _leaveUnderlyingStreamOpen;

		// Token: 0x0400010A RID: 266
		[global::Cpp2ILInjected.Token(Token = "0x400011A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x79")]
		private bool _closed;

		// Token: 0x0400010B RID: 267
		[global::Cpp2ILInjected.Token(Token = "0x400011B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x7A")]
		private bool _findRequired;

		// Token: 0x0400010C RID: 268
		[global::Cpp2ILInjected.Token(Token = "0x400011C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x7B")]
		private bool _exceptionPending;

		// Token: 0x0400010D RID: 269
		[global::Cpp2ILInjected.Token(Token = "0x400011D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x7C")]
		private int <CodecBufferSize>k__BackingField;
	}
}
