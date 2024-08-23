using System;
using System.IO;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Ionic.Zip;

namespace Ionic.Crc
{
	// Token: 0x0200004D RID: 77
	[global::Cpp2ILInjected.Token(Token = "0x200005D")]
	public class CrcCalculatorStream : Stream, IDisposable
	{
		// Token: 0x060003ED RID: 1005 RVA: 0x00005A40 File Offset: 0x00003C40
		[global::Cpp2ILInjected.Token(Token = "0x600040B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A77B48", Offset = "0x1A77B48", Length = "0x78")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ZipEntry), Member = "ExtractOne", MemberParameters = new object[] { typeof(Stream) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ZipEntry), Member = "FigureCrc32", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public CrcCalculatorStream(Stream stream)
		{
			throw null;
		}

		// Token: 0x060003EE RID: 1006 RVA: 0x00005A43 File Offset: 0x00003C43
		[global::Cpp2ILInjected.Token(Token = "0x600040C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A77CA0", Offset = "0x1A77CA0", Length = "0x7C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ZipEntry), Member = "_WriteEntryData", MemberParameters = new object[] { typeof(Stream) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ZipEntry), Member = "PrepOutputStream", MemberParameters = new object[]
		{
			typeof(Stream),
			typeof(long),
			typeof(ref CountingStream),
			typeof(ref Stream),
			typeof(ref Stream),
			typeof(ref CrcCalculatorStream)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CrcCalculatorStream), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(bool),
			typeof(long),
			typeof(Stream),
			typeof(CRC32)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public CrcCalculatorStream(Stream stream, bool leaveOpen)
		{
			throw null;
		}

		// Token: 0x060003EF RID: 1007 RVA: 0x00005A46 File Offset: 0x00003C46
		[global::Cpp2ILInjected.Token(Token = "0x600040D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A77D1C", Offset = "0x1A77D1C", Length = "0x6C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ZipEntry), Member = "InternalOpenReader", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(CrcCalculatorStream))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CrcCalculatorStream), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(bool),
			typeof(long),
			typeof(Stream),
			typeof(CRC32)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public CrcCalculatorStream(Stream stream, long length)
		{
			throw null;
		}

		// Token: 0x060003F0 RID: 1008 RVA: 0x00005A49 File Offset: 0x00003C49
		[global::Cpp2ILInjected.Token(Token = "0x600040E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A77D88", Offset = "0x1A77D88", Length = "0x70")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CrcCalculatorStream), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(bool),
			typeof(long),
			typeof(Stream),
			typeof(CRC32)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public CrcCalculatorStream(Stream stream, long length, bool leaveOpen)
		{
			throw null;
		}

		// Token: 0x060003F1 RID: 1009 RVA: 0x00005A4C File Offset: 0x00003C4C
		[global::Cpp2ILInjected.Token(Token = "0x600040F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A77DF8", Offset = "0x1A77DF8", Length = "0x6C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CrcCalculatorStream), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(bool),
			typeof(long),
			typeof(Stream),
			typeof(CRC32)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public CrcCalculatorStream(Stream stream, long length, bool leaveOpen, CRC32 crc32)
		{
			throw null;
		}

		// Token: 0x060003F2 RID: 1010 RVA: 0x00005A4F File Offset: 0x00003C4F
		[global::Cpp2ILInjected.Token(Token = "0x6000410")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A77BC0", Offset = "0x1A77BC0", Length = "0xE0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CrcCalculatorStream), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(Stream),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CrcCalculatorStream), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(Stream),
			typeof(long)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CrcCalculatorStream), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(Stream),
			typeof(long),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CrcCalculatorStream), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(Stream),
			typeof(long),
			typeof(bool),
			typeof(CRC32)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Stream), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CRC32), Member = "GenerateLookupTable", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		private CrcCalculatorStream(bool leaveOpen, long length, Stream stream, CRC32 crc32)
		{
			throw null;
		}

		// Token: 0x170000F5 RID: 245
		// (get) Token: 0x060003F3 RID: 1011 RVA: 0x00005A52 File Offset: 0x00003C52
		[global::Cpp2ILInjected.Token(Token = "0x170000F7")]
		public long TotalBytesSlurped
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000411")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A77E64", Offset = "0x1A77E64", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ZipEntry), Member = "_WriteEntryData", MemberParameters = new object[] { typeof(Stream) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ZipEntry), Member = "FinishOutputStream", MemberParameters = new object[]
			{
				typeof(Stream),
				typeof(CountingStream),
				typeof(Stream),
				typeof(Stream),
				typeof(CrcCalculatorStream)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170000F6 RID: 246
		// (get) Token: 0x060003F4 RID: 1012 RVA: 0x00005A55 File Offset: 0x00003C55
		[global::Cpp2ILInjected.Token(Token = "0x170000F8")]
		public int Crc
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000412")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A77E70", Offset = "0x1A77E70", Length = "0x10")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ZipEntry), Member = "ExtractOne", MemberParameters = new object[] { typeof(Stream) }, ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ZipEntry), Member = "FigureCrc32", ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ZipEntry), Member = "FinishOutputStream", MemberParameters = new object[]
			{
				typeof(Stream),
				typeof(CountingStream),
				typeof(Stream),
				typeof(Stream),
				typeof(CrcCalculatorStream)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ZipInputStream), Member = "Read", MemberParameters = new object[]
			{
				typeof(byte[]),
				typeof(int),
				typeof(int)
			}, ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170000F7 RID: 247
		// (get) Token: 0x060003F5 RID: 1013 RVA: 0x00005A58 File Offset: 0x00003C58
		// (set) Token: 0x060003F6 RID: 1014 RVA: 0x00005A5B File Offset: 0x00003C5B
		[global::Cpp2ILInjected.Token(Token = "0x170000F9")]
		public bool LeaveOpen
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000413")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A77E80", Offset = "0x1A77E80", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6000414")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A77E88", Offset = "0x1A77E88", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x060003F7 RID: 1015 RVA: 0x00005A5E File Offset: 0x00003C5E
		[global::Cpp2ILInjected.Token(Token = "0x6000415")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A77E94", Offset = "0x1A77E94", Length = "0xE8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CRC32), Member = "SlurpBlock", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public override int Read(byte[] buffer, int offset, int count)
		{
			throw null;
		}

		// Token: 0x060003F8 RID: 1016 RVA: 0x00005A61 File Offset: 0x00003C61
		[global::Cpp2ILInjected.Token(Token = "0x6000416")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A77F7C", Offset = "0x1A77F7C", Length = "0x64")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CRC32), Member = "SlurpBlock", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public override void Write(byte[] buffer, int offset, int count)
		{
			throw null;
		}

		// Token: 0x170000F8 RID: 248
		// (get) Token: 0x060003F9 RID: 1017 RVA: 0x00005A64 File Offset: 0x00003C64
		[global::Cpp2ILInjected.Token(Token = "0x170000FA")]
		public override bool CanRead
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000417")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A77FE0", Offset = "0x1A77FE0", Length = "0x10")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170000F9 RID: 249
		// (get) Token: 0x060003FA RID: 1018 RVA: 0x00005A67 File Offset: 0x00003C67
		[global::Cpp2ILInjected.Token(Token = "0x170000FB")]
		public override bool CanSeek
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000418")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A77FF0", Offset = "0x1A77FF0", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170000FA RID: 250
		// (get) Token: 0x060003FB RID: 1019 RVA: 0x00005A6A File Offset: 0x00003C6A
		[global::Cpp2ILInjected.Token(Token = "0x170000FC")]
		public override bool CanWrite
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000419")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A77FF8", Offset = "0x1A77FF8", Length = "0x10")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
		}

		// Token: 0x060003FC RID: 1020 RVA: 0x00005A6D File Offset: 0x00003C6D
		[global::Cpp2ILInjected.Token(Token = "0x600041A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A78008", Offset = "0x1A78008", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public override void Flush()
		{
			throw null;
		}

		// Token: 0x170000FB RID: 251
		// (get) Token: 0x060003FD RID: 1021 RVA: 0x00005A70 File Offset: 0x00003C70
		[global::Cpp2ILInjected.Token(Token = "0x170000FD")]
		public override long Length
		{
			[global::Cpp2ILInjected.Token(Token = "0x600041B")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A7801C", Offset = "0x1A7801C", Length = "0x84")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170000FC RID: 252
		// (get) Token: 0x060003FE RID: 1022 RVA: 0x00005A73 File Offset: 0x00003C73
		// (set) Token: 0x060003FF RID: 1023 RVA: 0x00005A76 File Offset: 0x00003C76
		[global::Cpp2ILInjected.Token(Token = "0x170000FE")]
		public override long Position
		{
			[global::Cpp2ILInjected.Token(Token = "0x600041C")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A780A0", Offset = "0x1A780A0", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x600041D")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A780AC", Offset = "0x1A780AC", Length = "0x38")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
			set
			{
				throw null;
			}
		}

		// Token: 0x06000400 RID: 1024 RVA: 0x00005A79 File Offset: 0x00003C79
		[global::Cpp2ILInjected.Token(Token = "0x600041E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A780E4", Offset = "0x1A780E4", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public override long Seek(long offset, SeekOrigin origin)
		{
			throw null;
		}

		// Token: 0x06000401 RID: 1025 RVA: 0x00005A7C File Offset: 0x00003C7C
		[global::Cpp2ILInjected.Token(Token = "0x600041F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A7811C", Offset = "0x1A7811C", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public override void SetLength(long value)
		{
			throw null;
		}

		// Token: 0x06000402 RID: 1026 RVA: 0x00005A7F File Offset: 0x00003C7F
		[global::Cpp2ILInjected.Token(Token = "0x6000420")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A78154", Offset = "0x1A78154", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		private void System.IDisposable.Dispose()
		{
			throw null;
		}

		// Token: 0x06000403 RID: 1027 RVA: 0x00005A82 File Offset: 0x00003C82
		[global::Cpp2ILInjected.Token(Token = "0x6000421")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A78164", Offset = "0x1A78164", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Stream), Member = "Close", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public override void Close()
		{
			throw null;
		}

		// Token: 0x06000404 RID: 1028 RVA: 0x00005A85 File Offset: 0x00003C85
		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x6000422")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A7819C", Offset = "0x1A7819C", Length = "0x4C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		static CrcCalculatorStream()
		{
			throw null;
		}

		// Token: 0x040002B1 RID: 689
		[global::Cpp2ILInjected.Token(Token = "0x4000321")]
		private static readonly long UnsetLengthLimit;

		// Token: 0x040002B2 RID: 690
		[global::Cpp2ILInjected.Token(Token = "0x4000322")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		internal Stream _innerStream;

		// Token: 0x040002B3 RID: 691
		[global::Cpp2ILInjected.Token(Token = "0x4000323")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		private CRC32 _Crc32;

		// Token: 0x040002B4 RID: 692
		[global::Cpp2ILInjected.Token(Token = "0x4000324")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		private long _lengthLimit;

		// Token: 0x040002B5 RID: 693
		[global::Cpp2ILInjected.Token(Token = "0x4000325")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
		private bool _leaveOpen;
	}
}
