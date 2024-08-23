using System;
using System.IO;
using System.Text;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace Ionic.Zlib
{
	// Token: 0x02000037 RID: 55
	[global::Cpp2ILInjected.Token(Token = "0x2000044")]
	public class GZipStream : Stream
	{
		// Token: 0x170000D3 RID: 211
		// (get) Token: 0x0600033B RID: 827 RVA: 0x0000582A File Offset: 0x00003A2A
		// (set) Token: 0x0600033C RID: 828 RVA: 0x0000582D File Offset: 0x00003A2D
		[global::Cpp2ILInjected.Token(Token = "0x170000D5")]
		public string Comment
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000359")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A6E6BC", Offset = "0x1A6E6BC", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x600035A")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A6E6C4", Offset = "0x1A6E6C4", Length = "0x60")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GZipStream), Member = "Read", MemberParameters = new object[]
			{
				typeof(byte[]),
				typeof(int),
				typeof(int)
			}, ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ObjectDisposedException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
			set
			{
				throw null;
			}
		}

		// Token: 0x170000D4 RID: 212
		// (get) Token: 0x0600033D RID: 829 RVA: 0x00005830 File Offset: 0x00003A30
		// (set) Token: 0x0600033E RID: 830 RVA: 0x00005833 File Offset: 0x00003A33
		[global::Cpp2ILInjected.Token(Token = "0x170000D6")]
		public string FileName
		{
			[global::Cpp2ILInjected.Token(Token = "0x600035B")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A6E724", Offset = "0x1A6E724", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x600035C")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A6E72C", Offset = "0x1A6E72C", Length = "0x188")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GZipStream), Member = "Read", MemberParameters = new object[]
			{
				typeof(byte[]),
				typeof(int),
				typeof(int)
			}, ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "IndexOf", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Replace", MemberParameters = new object[]
			{
				typeof(string),
				typeof(string)
			}, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "EndsWith", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Path), Member = "GetFileName", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ObjectDisposedException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Exception), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 12)]
			set
			{
				throw null;
			}
		}

		// Token: 0x170000D5 RID: 213
		// (get) Token: 0x0600033F RID: 831 RVA: 0x00005836 File Offset: 0x00003A36
		[global::Cpp2ILInjected.Token(Token = "0x170000D7")]
		public int Crc32
		{
			[global::Cpp2ILInjected.Token(Token = "0x600035D")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A6E8B4", Offset = "0x1A6E8B4", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06000340 RID: 832 RVA: 0x00005839 File Offset: 0x00003A39
		[global::Cpp2ILInjected.Token(Token = "0x600035E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A6E8BC", Offset = "0x1A6E8BC", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public GZipStream(Stream stream, CompressionMode mode)
		{
			throw null;
		}

		// Token: 0x06000341 RID: 833 RVA: 0x0000583C File Offset: 0x00003A3C
		[global::Cpp2ILInjected.Token(Token = "0x600035F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A6E980", Offset = "0x1A6E980", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GZipStream), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(Stream),
			typeof(CompressionMode),
			typeof(CompressionLevel),
			typeof(bool)
		}, ReturnType = typeof(void))]
		public GZipStream(Stream stream, CompressionMode mode, CompressionLevel level)
		{
			throw null;
		}

		// Token: 0x06000342 RID: 834 RVA: 0x0000583F File Offset: 0x00003A3F
		[global::Cpp2ILInjected.Token(Token = "0x6000360")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A6E988", Offset = "0x1A6E988", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GZipStream), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(Stream),
			typeof(CompressionMode),
			typeof(CompressionLevel),
			typeof(bool)
		}, ReturnType = typeof(void))]
		public GZipStream(Stream stream, CompressionMode mode, bool leaveOpen)
		{
			throw null;
		}

		// Token: 0x06000343 RID: 835 RVA: 0x00005842 File Offset: 0x00003A42
		[global::Cpp2ILInjected.Token(Token = "0x6000361")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A6E8C8", Offset = "0x1A6E8C8", Length = "0xB8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GZipStream), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(Stream),
			typeof(CompressionMode),
			typeof(CompressionLevel)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GZipStream), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(Stream),
			typeof(CompressionMode),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GZipStream), Member = "CompressString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GZipStream), Member = "CompressBuffer", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GZipStream), Member = "UncompressString", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GZipStream), Member = "UncompressBuffer", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 6)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Stream), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZlibBaseStream), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(Stream),
			typeof(CompressionMode),
			typeof(CompressionLevel),
			typeof(ZlibStreamFlavor),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public GZipStream(Stream stream, CompressionMode mode, CompressionLevel level, bool leaveOpen)
		{
			throw null;
		}

		// Token: 0x170000D6 RID: 214
		// (get) Token: 0x06000344 RID: 836 RVA: 0x00005845 File Offset: 0x00003A45
		// (set) Token: 0x06000345 RID: 837 RVA: 0x00005848 File Offset: 0x00003A48
		[global::Cpp2ILInjected.Token(Token = "0x170000D8")]
		public virtual FlushType FlushMode
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000362")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A6E994", Offset = "0x1A6E994", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6000363")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A6E9A0", Offset = "0x1A6E9A0", Length = "0x64")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ObjectDisposedException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
			set
			{
				throw null;
			}
		}

		// Token: 0x170000D7 RID: 215
		// (get) Token: 0x06000346 RID: 838 RVA: 0x0000584B File Offset: 0x00003A4B
		// (set) Token: 0x06000347 RID: 839 RVA: 0x0000584E File Offset: 0x00003A4E
		[global::Cpp2ILInjected.Token(Token = "0x170000D9")]
		public int BufferSize
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000364")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A6EA04", Offset = "0x1A6EA04", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6000365")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A6EA10", Offset = "0x1A6EA10", Length = "0x13C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ObjectDisposedException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZlibException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Format", MemberParameters = new object[]
			{
				typeof(string),
				typeof(object),
				typeof(object)
			}, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 17)]
			set
			{
				throw null;
			}
		}

		// Token: 0x170000D8 RID: 216
		// (get) Token: 0x06000348 RID: 840 RVA: 0x00005851 File Offset: 0x00003A51
		[global::Cpp2ILInjected.Token(Token = "0x170000DA")]
		public virtual long TotalIn
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000366")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A6EB4C", Offset = "0x1A6EB4C", Length = "0x10")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170000D9 RID: 217
		// (get) Token: 0x06000349 RID: 841 RVA: 0x00005854 File Offset: 0x00003A54
		[global::Cpp2ILInjected.Token(Token = "0x170000DB")]
		public virtual long TotalOut
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000367")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A6EB5C", Offset = "0x1A6EB5C", Length = "0x10")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0600034A RID: 842 RVA: 0x00005857 File Offset: 0x00003A57
		[global::Cpp2ILInjected.Token(Token = "0x6000368")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A6EB6C", Offset = "0x1A6EB6C", Length = "0xE4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Stream), Member = "Dispose", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		protected override void Dispose(bool disposing)
		{
			throw null;
		}

		// Token: 0x170000DA RID: 218
		// (get) Token: 0x0600034B RID: 843 RVA: 0x0000585A File Offset: 0x00003A5A
		[global::Cpp2ILInjected.Token(Token = "0x170000DC")]
		public override bool CanRead
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000369")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A6EC6C", Offset = "0x1A6EC6C", Length = "0x6C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ObjectDisposedException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170000DB RID: 219
		// (get) Token: 0x0600034C RID: 844 RVA: 0x0000585D File Offset: 0x00003A5D
		[global::Cpp2ILInjected.Token(Token = "0x170000DD")]
		public override bool CanSeek
		{
			[global::Cpp2ILInjected.Token(Token = "0x600036A")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A6ECD8", Offset = "0x1A6ECD8", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170000DC RID: 220
		// (get) Token: 0x0600034D RID: 845 RVA: 0x00005860 File Offset: 0x00003A60
		[global::Cpp2ILInjected.Token(Token = "0x170000DE")]
		public override bool CanWrite
		{
			[global::Cpp2ILInjected.Token(Token = "0x600036B")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A6ECE0", Offset = "0x1A6ECE0", Length = "0x6C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ObjectDisposedException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0600034E RID: 846 RVA: 0x00005863 File Offset: 0x00003A63
		[global::Cpp2ILInjected.Token(Token = "0x600036C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A6ED4C", Offset = "0x1A6ED4C", Length = "0x6C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ObjectDisposedException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		public override void Flush()
		{
			throw null;
		}

		// Token: 0x170000DD RID: 221
		// (get) Token: 0x0600034F RID: 847 RVA: 0x00005866 File Offset: 0x00003A66
		[global::Cpp2ILInjected.Token(Token = "0x170000DF")]
		public override long Length
		{
			[global::Cpp2ILInjected.Token(Token = "0x600036D")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A6EDB8", Offset = "0x1A6EDB8", Length = "0x38")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NotImplementedException), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170000DE RID: 222
		// (get) Token: 0x06000350 RID: 848 RVA: 0x00005869 File Offset: 0x00003A69
		// (set) Token: 0x06000351 RID: 849 RVA: 0x0000586C File Offset: 0x00003A6C
		[global::Cpp2ILInjected.Token(Token = "0x170000E0")]
		public override long Position
		{
			[global::Cpp2ILInjected.Token(Token = "0x600036E")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A6EDF0", Offset = "0x1A6EDF0", Length = "0x48")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x600036F")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A6EE38", Offset = "0x1A6EE38", Length = "0x38")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NotImplementedException), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
			set
			{
				throw null;
			}
		}

		// Token: 0x06000352 RID: 850 RVA: 0x0000586F File Offset: 0x00003A6F
		[global::Cpp2ILInjected.Token(Token = "0x6000370")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A6EE70", Offset = "0x1A6EE70", Length = "0xB4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GZipStream), Member = "set_FileName", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GZipStream), Member = "set_Comment", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ObjectDisposedException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public override int Read(byte[] buffer, int offset, int count)
		{
			throw null;
		}

		// Token: 0x06000353 RID: 851 RVA: 0x00005872 File Offset: 0x00003A72
		[global::Cpp2ILInjected.Token(Token = "0x6000371")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A6EF24", Offset = "0x1A6EF24", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NotImplementedException), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public override long Seek(long offset, SeekOrigin origin)
		{
			throw null;
		}

		// Token: 0x06000354 RID: 852 RVA: 0x00005875 File Offset: 0x00003A75
		[global::Cpp2ILInjected.Token(Token = "0x6000372")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A6EF5C", Offset = "0x1A6EF5C", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NotImplementedException), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public override void SetLength(long value)
		{
			throw null;
		}

		// Token: 0x06000355 RID: 853 RVA: 0x00005878 File Offset: 0x00003A78
		[global::Cpp2ILInjected.Token(Token = "0x6000373")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A6EF94", Offset = "0x1A6EF94", Length = "0xE0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GZipStream), Member = "EmitHeader", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ObjectDisposedException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InvalidOperationException), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		public override void Write(byte[] buffer, int offset, int count)
		{
			throw null;
		}

		// Token: 0x06000356 RID: 854 RVA: 0x0000587B File Offset: 0x00003A7B
		[global::Cpp2ILInjected.Token(Token = "0x6000374")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A6F084", Offset = "0x1A6F084", Length = "0x350")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GZipStream), Member = "Write", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTime), Member = "get_Now", ReturnType = typeof(DateTime))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTime?), Member = ".ctor", MemberParameters = new object[] { typeof(DateTime) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTime?), Member = "get_Value", ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTime), Member = "op_Subtraction", MemberParameters = new object[]
		{
			typeof(DateTime),
			typeof(DateTime)
		}, ReturnType = typeof(TimeSpan))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TimeSpan), Member = "get_TotalSeconds", ReturnType = typeof(double))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BitConverter), Member = "GetBytes", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new object[]
		{
			typeof(Array),
			typeof(int),
			typeof(Array),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 14)]
		private int EmitHeader()
		{
			throw null;
		}

		// Token: 0x06000357 RID: 855 RVA: 0x0000587E File Offset: 0x00003A7E
		[global::Cpp2ILInjected.Token(Token = "0x6000375")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A6F3D4", Offset = "0x1A6F3D4", Length = "0x1E8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MemoryStream), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GZipStream), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(Stream),
			typeof(CompressionMode),
			typeof(CompressionLevel),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZlibBaseStream), Member = "CompressString", MemberParameters = new object[]
		{
			typeof(string),
			typeof(Stream)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 13)]
		public static byte[] CompressString(string s)
		{
			throw null;
		}

		// Token: 0x06000358 RID: 856 RVA: 0x00005881 File Offset: 0x00003A81
		[global::Cpp2ILInjected.Token(Token = "0x6000376")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A6F5BC", Offset = "0x1A6F5BC", Length = "0x1E8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MemoryStream), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GZipStream), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(Stream),
			typeof(CompressionMode),
			typeof(CompressionLevel),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZlibBaseStream), Member = "CompressBuffer", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(Stream)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 13)]
		public static byte[] CompressBuffer(byte[] b)
		{
			throw null;
		}

		// Token: 0x06000359 RID: 857 RVA: 0x00005884 File Offset: 0x00003A84
		[global::Cpp2ILInjected.Token(Token = "0x6000377")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A6F7A4", Offset = "0x1A6F7A4", Length = "0x1D4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MemoryStream), Member = ".ctor", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GZipStream), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(Stream),
			typeof(CompressionMode),
			typeof(CompressionLevel),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZlibBaseStream), Member = "UncompressString", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(Stream)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 13)]
		public static string UncompressString(byte[] compressed)
		{
			throw null;
		}

		// Token: 0x0600035A RID: 858 RVA: 0x00005887 File Offset: 0x00003A87
		[global::Cpp2ILInjected.Token(Token = "0x6000378")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A6F978", Offset = "0x1A6F978", Length = "0x1D4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MemoryStream), Member = ".ctor", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GZipStream), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(Stream),
			typeof(CompressionMode),
			typeof(CompressionLevel),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZlibBaseStream), Member = "UncompressBuffer", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(Stream)
		}, ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 13)]
		public static byte[] UncompressBuffer(byte[] compressed)
		{
			throw null;
		}

		// Token: 0x0600035B RID: 859 RVA: 0x0000588A File Offset: 0x00003A8A
		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x6000379")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A6FB4C", Offset = "0x1A6FB4C", Length = "0xA8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTime), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(DateTimeKind)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Encoding), Member = "GetEncoding", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(Encoding))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		static GZipStream()
		{
			throw null;
		}

		// Token: 0x040001DD RID: 477
		[global::Cpp2ILInjected.Token(Token = "0x400022F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		public DateTime? LastModified;

		// Token: 0x040001DE RID: 478
		[global::Cpp2ILInjected.Token(Token = "0x4000230")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		private int _headerByteCount;

		// Token: 0x040001DF RID: 479
		[global::Cpp2ILInjected.Token(Token = "0x4000231")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
		internal ZlibBaseStream _baseStream;

		// Token: 0x040001E0 RID: 480
		[global::Cpp2ILInjected.Token(Token = "0x4000232")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
		private bool _disposed;

		// Token: 0x040001E1 RID: 481
		[global::Cpp2ILInjected.Token(Token = "0x4000233")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x49")]
		private bool _firstReadDone;

		// Token: 0x040001E2 RID: 482
		[global::Cpp2ILInjected.Token(Token = "0x4000234")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
		private string _FileName;

		// Token: 0x040001E3 RID: 483
		[global::Cpp2ILInjected.Token(Token = "0x4000235")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x58")]
		private string _Comment;

		// Token: 0x040001E4 RID: 484
		[global::Cpp2ILInjected.Token(Token = "0x4000236")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x60")]
		private int _Crc32;

		// Token: 0x040001E5 RID: 485
		[global::Cpp2ILInjected.Token(Token = "0x4000237")]
		internal static readonly DateTime _unixEpoch;

		// Token: 0x040001E6 RID: 486
		[global::Cpp2ILInjected.Token(Token = "0x4000238")]
		internal static readonly Encoding iso8859dash1;
	}
}
