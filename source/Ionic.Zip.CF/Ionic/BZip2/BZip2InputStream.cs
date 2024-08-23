using System;
using System.IO;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Ionic.Crc;
using Ionic.Zip;

namespace Ionic.BZip2
{
	// Token: 0x0200002F RID: 47
	[global::Cpp2ILInjected.Token(Token = "0x2000037")]
	public class BZip2InputStream : Stream
	{
		// Token: 0x060002B7 RID: 695 RVA: 0x0000569E File Offset: 0x0000389E
		[global::Cpp2ILInjected.Token(Token = "0x60002CC")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A658BC", Offset = "0x1A658BC", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public BZip2InputStream(Stream input)
		{
			throw null;
		}

		// Token: 0x060002B8 RID: 696 RVA: 0x000056A1 File Offset: 0x000038A1
		[global::Cpp2ILInjected.Token(Token = "0x60002CD")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A658C4", Offset = "0x1A658C4", Length = "0xBC")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ZipEntry), Member = "GetExtractDecompressor", MemberParameters = new object[] { typeof(Stream) }, ReturnType = typeof(Stream))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CRC32), Member = ".ctor", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Stream), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public BZip2InputStream(Stream input, bool leaveOpen)
		{
			throw null;
		}

		// Token: 0x060002B9 RID: 697 RVA: 0x000056A4 File Offset: 0x000038A4
		[global::Cpp2ILInjected.Token(Token = "0x60002CE")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A65AEC", Offset = "0x1A65AEC", Length = "0x1F8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Format", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Format", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object),
			typeof(object),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(IndexOutOfRangeException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(IOException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 21)]
		public override int Read(byte[] buffer, int offset, int count)
		{
			throw null;
		}

		// Token: 0x060002BA RID: 698 RVA: 0x000056A7 File Offset: 0x000038A7
		[global::Cpp2ILInjected.Token(Token = "0x60002CF")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A65CE4", Offset = "0x1A65CE4", Length = "0x3C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private void MakeMaps()
		{
			throw null;
		}

		// Token: 0x060002BB RID: 699 RVA: 0x000056AA File Offset: 0x000038AA
		[global::Cpp2ILInjected.Token(Token = "0x60002D0")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A65D20", Offset = "0x1A65D20", Length = "0xAC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BZip2InputStream), Member = "SetupRandPartB", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BZip2InputStream), Member = "SetupRandPartC", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BZip2InputStream), Member = "SetupNoRandPartC", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BZip2InputStream), Member = "SetupNoRandPartB", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(IOException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		public override int ReadByte()
		{
			throw null;
		}

		// Token: 0x170000BD RID: 189
		// (get) Token: 0x060002BC RID: 700 RVA: 0x000056AD File Offset: 0x000038AD
		[global::Cpp2ILInjected.Token(Token = "0x170000BF")]
		public override bool CanRead
		{
			[global::Cpp2ILInjected.Token(Token = "0x60002D1")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A66014", Offset = "0x1A66014", Length = "0x68")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ObjectDisposedException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170000BE RID: 190
		// (get) Token: 0x060002BD RID: 701 RVA: 0x000056B0 File Offset: 0x000038B0
		[global::Cpp2ILInjected.Token(Token = "0x170000C0")]
		public override bool CanSeek
		{
			[global::Cpp2ILInjected.Token(Token = "0x60002D2")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A6607C", Offset = "0x1A6607C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170000BF RID: 191
		// (get) Token: 0x060002BE RID: 702 RVA: 0x000056B3 File Offset: 0x000038B3
		[global::Cpp2ILInjected.Token(Token = "0x170000C1")]
		public override bool CanWrite
		{
			[global::Cpp2ILInjected.Token(Token = "0x60002D3")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A66084", Offset = "0x1A66084", Length = "0x68")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ObjectDisposedException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
			get
			{
				throw null;
			}
		}

		// Token: 0x060002BF RID: 703 RVA: 0x000056B6 File Offset: 0x000038B6
		[global::Cpp2ILInjected.Token(Token = "0x60002D4")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A660EC", Offset = "0x1A660EC", Length = "0x6C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ObjectDisposedException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		public override void Flush()
		{
			throw null;
		}

		// Token: 0x170000C0 RID: 192
		// (get) Token: 0x060002C0 RID: 704 RVA: 0x000056B9 File Offset: 0x000038B9
		[global::Cpp2ILInjected.Token(Token = "0x170000C2")]
		public override long Length
		{
			[global::Cpp2ILInjected.Token(Token = "0x60002D5")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A66158", Offset = "0x1A66158", Length = "0x38")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NotImplementedException), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170000C1 RID: 193
		// (get) Token: 0x060002C1 RID: 705 RVA: 0x000056BC File Offset: 0x000038BC
		// (set) Token: 0x060002C2 RID: 706 RVA: 0x000056BF File Offset: 0x000038BF
		[global::Cpp2ILInjected.Token(Token = "0x170000C3")]
		public override long Position
		{
			[global::Cpp2ILInjected.Token(Token = "0x60002D6")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A66190", Offset = "0x1A66190", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x60002D7")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A66198", Offset = "0x1A66198", Length = "0x38")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NotImplementedException), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
			set
			{
				throw null;
			}
		}

		// Token: 0x060002C3 RID: 707 RVA: 0x000056C2 File Offset: 0x000038C2
		[global::Cpp2ILInjected.Token(Token = "0x60002D8")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A661D0", Offset = "0x1A661D0", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NotImplementedException), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public override long Seek(long offset, SeekOrigin origin)
		{
			throw null;
		}

		// Token: 0x060002C4 RID: 708 RVA: 0x000056C5 File Offset: 0x000038C5
		[global::Cpp2ILInjected.Token(Token = "0x60002D9")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A66208", Offset = "0x1A66208", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NotImplementedException), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public override void SetLength(long value)
		{
			throw null;
		}

		// Token: 0x060002C5 RID: 709 RVA: 0x000056C8 File Offset: 0x000038C8
		[global::Cpp2ILInjected.Token(Token = "0x60002DA")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A66240", Offset = "0x1A66240", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NotImplementedException), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public override void Write(byte[] buffer, int offset, int count)
		{
			throw null;
		}

		// Token: 0x060002C6 RID: 710 RVA: 0x000056CB File Offset: 0x000038CB
		[global::Cpp2ILInjected.Token(Token = "0x60002DB")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A66278", Offset = "0x1A66278", Length = "0xCC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Stream), Member = "Dispose", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		protected override void Dispose(bool disposing)
		{
			throw null;
		}

		// Token: 0x060002C7 RID: 711 RVA: 0x000056CE File Offset: 0x000038CE
		[global::Cpp2ILInjected.Token(Token = "0x60002DC")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A65980", Offset = "0x1A65980", Length = "0x16C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BZip2InputStream), Member = "CheckMagicChar", MemberParameters = new object[]
		{
			typeof(char),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BZip2InputStream), Member = "InitBlock", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BZip2InputStream), Member = "SetupBlock", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(IOException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(object),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 14)]
		private void init()
		{
			throw null;
		}

		// Token: 0x060002C8 RID: 712 RVA: 0x000056D1 File Offset: 0x000038D1
		[global::Cpp2ILInjected.Token(Token = "0x60002DD")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A66344", Offset = "0x1A66344", Length = "0x100")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BZip2InputStream), Member = "init", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Format", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object),
			typeof(object),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(IOException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 11)]
		private void CheckMagicChar(char expected, int position)
		{
			throw null;
		}

		// Token: 0x060002C9 RID: 713 RVA: 0x000056D4 File Offset: 0x000038D4
		[global::Cpp2ILInjected.Token(Token = "0x60002DE")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A66444", Offset = "0x1A66444", Length = "0x234")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BZip2InputStream), Member = "init", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BZip2InputStream), Member = "SetupRandPartA", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BZip2InputStream), Member = "SetupNoRandPartA", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BZip2InputStream), Member = "GetBits", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BZip2InputStream), Member = "complete", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BZip2InputStream), Member = "bsGetInt", ReturnType = typeof(uint))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BZip2InputStream.DecompressionState), Member = ".ctor", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BZip2InputStream), Member = "getAndMoveToFrontDecode", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CRC32), Member = "Reset", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Format", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(IOException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
		private void InitBlock()
		{
			throw null;
		}

		// Token: 0x060002CA RID: 714 RVA: 0x000056D7 File Offset: 0x000038D7
		[global::Cpp2ILInjected.Token(Token = "0x60002DF")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A6742C", Offset = "0x1A6742C", Length = "0xDC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BZip2InputStream), Member = "SetupRandPartA", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BZip2InputStream), Member = "SetupNoRandPartA", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CRC32), Member = "get_Crc32Result", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Format", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(IOException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
		private void EndBlock()
		{
			throw null;
		}

		// Token: 0x060002CB RID: 715 RVA: 0x000056DA File Offset: 0x000038DA
		[global::Cpp2ILInjected.Token(Token = "0x60002E0")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A66978", Offset = "0x1A66978", Length = "0xD0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BZip2InputStream), Member = "InitBlock", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BZip2InputStream), Member = "bsGetInt", ReturnType = typeof(uint))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Format", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(IOException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
		private void complete()
		{
			throw null;
		}

		// Token: 0x060002CC RID: 716 RVA: 0x000056DD File Offset: 0x000038DD
		[global::Cpp2ILInjected.Token(Token = "0x60002E1")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A67508", Offset = "0x1A67508", Length = "0x90")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public override void Close()
		{
			throw null;
		}

		// Token: 0x060002CD RID: 717 RVA: 0x000056E0 File Offset: 0x000038E0
		[global::Cpp2ILInjected.Token(Token = "0x60002E2")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A66AAC", Offset = "0x1A66AAC", Length = "0xBC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BZip2InputStream), Member = "InitBlock", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BZip2InputStream), Member = "bsGetBit", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BZip2InputStream), Member = "bsGetUByte", ReturnType = typeof(char))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BZip2InputStream), Member = "bsGetInt", ReturnType = typeof(uint))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BZip2InputStream), Member = "recvDecodingTables", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BZip2InputStream), Member = "getAndMoveToFrontDecode", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BZip2InputStream), Member = "getAndMoveToFrontDecode0", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 23)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(IOException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		private int GetBits(int n)
		{
			throw null;
		}

		// Token: 0x060002CE RID: 718 RVA: 0x000056E3 File Offset: 0x000038E3
		[global::Cpp2ILInjected.Token(Token = "0x60002E3")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A67598", Offset = "0x1A67598", Length = "0x1C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BZip2InputStream), Member = "GetBits", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(int))]
		private bool bsGetBit()
		{
			throw null;
		}

		// Token: 0x060002CF RID: 719 RVA: 0x000056E6 File Offset: 0x000038E6
		[global::Cpp2ILInjected.Token(Token = "0x60002E4")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A66964", Offset = "0x1A66964", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BZip2InputStream), Member = "GetBits", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(int))]
		private char bsGetUByte()
		{
			throw null;
		}

		// Token: 0x060002D0 RID: 720 RVA: 0x000056E9 File Offset: 0x000038E9
		[global::Cpp2ILInjected.Token(Token = "0x60002E5")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A66A48", Offset = "0x1A66A48", Length = "0x64")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BZip2InputStream), Member = "InitBlock", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BZip2InputStream), Member = "complete", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BZip2InputStream), Member = "GetBits", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(int))]
		private uint bsGetInt()
		{
			throw null;
		}

		// Token: 0x060002D1 RID: 721 RVA: 0x000056EC File Offset: 0x000038EC
		[global::Cpp2ILInjected.Token(Token = "0x60002E6")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A675B4", Offset = "0x1A675B4", Length = "0x208")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BZip2InputStream), Member = "createHuffmanDecodingTables", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		private static void hbCreateDecodeTables(int[] limit, int[] bbase, int[] perm, char[] length, int minLen, int maxLen, int alphaSize)
		{
			throw null;
		}

		// Token: 0x060002D2 RID: 722 RVA: 0x000056EF File Offset: 0x000038EF
		[global::Cpp2ILInjected.Token(Token = "0x60002E7")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A677BC", Offset = "0x1A677BC", Length = "0x288")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BZip2InputStream), Member = "getAndMoveToFrontDecode", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BZip2InputStream), Member = "GetBits", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		private void recvDecodingTables()
		{
			throw null;
		}

		// Token: 0x060002D3 RID: 723 RVA: 0x000056F2 File Offset: 0x000038F2
		[global::Cpp2ILInjected.Token(Token = "0x60002E8")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A67A44", Offset = "0x1A67A44", Length = "0xDC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BZip2InputStream), Member = "hbCreateDecodeTables", MemberParameters = new object[]
		{
			typeof(int[]),
			typeof(int[]),
			typeof(int[]),
			typeof(char[]),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		private void createHuffmanDecodingTables(int alphaSize, int nGroups)
		{
			throw null;
		}

		// Token: 0x060002D4 RID: 724 RVA: 0x000056F5 File Offset: 0x000038F5
		[global::Cpp2ILInjected.Token(Token = "0x60002E9")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A66D78", Offset = "0x1A66D78", Length = "0x6B4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BZip2InputStream), Member = "InitBlock", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BZip2InputStream), Member = "GetBits", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BZip2InputStream), Member = "recvDecodingTables", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BZip2InputStream), Member = "getAndMoveToFrontDecode0", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Buffer), Member = "BlockCopy", MemberParameters = new object[]
		{
			typeof(Array),
			typeof(int),
			typeof(Array),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(IOException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 19)]
		private void getAndMoveToFrontDecode()
		{
			throw null;
		}

		// Token: 0x060002D5 RID: 725 RVA: 0x000056F8 File Offset: 0x000038F8
		[global::Cpp2ILInjected.Token(Token = "0x60002EA")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A67B20", Offset = "0x1A67B20", Length = "0x144")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BZip2InputStream), Member = "getAndMoveToFrontDecode", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BZip2InputStream), Member = "GetBits", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(IOException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		private int getAndMoveToFrontDecode0(int groupNo)
		{
			throw null;
		}

		// Token: 0x060002D6 RID: 726 RVA: 0x000056FB File Offset: 0x000038FB
		[global::Cpp2ILInjected.Token(Token = "0x60002EB")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A66678", Offset = "0x1A66678", Length = "0x2EC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BZip2InputStream), Member = "init", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BZip2InputStream), Member = "SetupRandPartA", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BZip2InputStream), Member = "SetupNoRandPartA", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BZip2InputStream.DecompressionState), Member = "initTT", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(int[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BZip2InputStream), Member = "SetupRandPartA", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BZip2InputStream), Member = "SetupNoRandPartA", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Exception), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Format", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object),
			typeof(object),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(IOException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 19)]
		private void SetupBlock()
		{
			throw null;
		}

		// Token: 0x060002D7 RID: 727 RVA: 0x000056FE File Offset: 0x000038FE
		[global::Cpp2ILInjected.Token(Token = "0x60002EC")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A67CCC", Offset = "0x1A67CCC", Length = "0x10C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BZip2InputStream), Member = "SetupBlock", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BZip2InputStream), Member = "SetupRandPartB", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BZip2InputStream), Member = "SetupRandPartC", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BZip2InputStream), Member = "EndBlock", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BZip2InputStream), Member = "InitBlock", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BZip2InputStream), Member = "SetupBlock", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rand), Member = "Rnums", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CRC32), Member = "UpdateCRC", MemberParameters = new object[] { typeof(byte) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private void SetupRandPartA()
		{
			throw null;
		}

		// Token: 0x060002D8 RID: 728 RVA: 0x00005701 File Offset: 0x00003901
		[global::Cpp2ILInjected.Token(Token = "0x60002ED")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A67DD8", Offset = "0x1A67DD8", Length = "0x8C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BZip2InputStream), Member = "SetupBlock", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BZip2InputStream), Member = "SetupNoRandPartB", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BZip2InputStream), Member = "SetupNoRandPartC", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BZip2InputStream), Member = "EndBlock", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BZip2InputStream), Member = "InitBlock", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BZip2InputStream), Member = "SetupBlock", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CRC32), Member = "UpdateCRC", MemberParameters = new object[] { typeof(byte) }, ReturnType = typeof(void))]
		private void SetupNoRandPartA()
		{
			throw null;
		}

		// Token: 0x060002D9 RID: 729 RVA: 0x00005704 File Offset: 0x00003904
		[global::Cpp2ILInjected.Token(Token = "0x60002EE")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A65DCC", Offset = "0x1A65DCC", Length = "0x120")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BZip2InputStream), Member = "ReadByte", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BZip2InputStream), Member = "SetupRandPartA", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rand), Member = "Rnums", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private void SetupRandPartB()
		{
			throw null;
		}

		// Token: 0x060002DA RID: 730 RVA: 0x00005707 File Offset: 0x00003907
		[global::Cpp2ILInjected.Token(Token = "0x60002EF")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A65EEC", Offset = "0x1A65EEC", Length = "0x64")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BZip2InputStream), Member = "ReadByte", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CRC32), Member = "UpdateCRC", MemberParameters = new object[] { typeof(byte) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BZip2InputStream), Member = "SetupRandPartA", ReturnType = typeof(void))]
		private void SetupRandPartC()
		{
			throw null;
		}

		// Token: 0x060002DB RID: 731 RVA: 0x0000570A File Offset: 0x0000390A
		[global::Cpp2ILInjected.Token(Token = "0x60002F0")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A65F50", Offset = "0x1A65F50", Length = "0x60")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BZip2InputStream), Member = "ReadByte", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BZip2InputStream), Member = "SetupNoRandPartA", ReturnType = typeof(void))]
		private void SetupNoRandPartB()
		{
			throw null;
		}

		// Token: 0x060002DC RID: 732 RVA: 0x0000570D File Offset: 0x0000390D
		[global::Cpp2ILInjected.Token(Token = "0x60002F1")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A65FB0", Offset = "0x1A65FB0", Length = "0x64")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BZip2InputStream), Member = "ReadByte", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CRC32), Member = "UpdateCRC", MemberParameters = new object[] { typeof(byte) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BZip2InputStream), Member = "SetupNoRandPartA", ReturnType = typeof(void))]
		private void SetupNoRandPartC()
		{
			throw null;
		}

		// Token: 0x04000155 RID: 341
		[global::Cpp2ILInjected.Token(Token = "0x4000184")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private bool _disposed;

		// Token: 0x04000156 RID: 342
		[global::Cpp2ILInjected.Token(Token = "0x4000185")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x29")]
		private bool _leaveOpen;

		// Token: 0x04000157 RID: 343
		[global::Cpp2ILInjected.Token(Token = "0x4000186")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		private long totalBytesRead;

		// Token: 0x04000158 RID: 344
		[global::Cpp2ILInjected.Token(Token = "0x4000187")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		private int last;

		// Token: 0x04000159 RID: 345
		[global::Cpp2ILInjected.Token(Token = "0x4000188")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x3C")]
		private int origPtr;

		// Token: 0x0400015A RID: 346
		[global::Cpp2ILInjected.Token(Token = "0x4000189")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
		private int blockSize100k;

		// Token: 0x0400015B RID: 347
		[global::Cpp2ILInjected.Token(Token = "0x400018A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x44")]
		private bool blockRandomised;

		// Token: 0x0400015C RID: 348
		[global::Cpp2ILInjected.Token(Token = "0x400018B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
		private int bsBuff;

		// Token: 0x0400015D RID: 349
		[global::Cpp2ILInjected.Token(Token = "0x400018C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x4C")]
		private int bsLive;

		// Token: 0x0400015E RID: 350
		[global::Cpp2ILInjected.Token(Token = "0x400018D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
		private readonly CRC32 crc;

		// Token: 0x0400015F RID: 351
		[global::Cpp2ILInjected.Token(Token = "0x400018E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x58")]
		private int nInUse;

		// Token: 0x04000160 RID: 352
		[global::Cpp2ILInjected.Token(Token = "0x400018F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x60")]
		private Stream input;

		// Token: 0x04000161 RID: 353
		[global::Cpp2ILInjected.Token(Token = "0x4000190")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x68")]
		private int currentChar;

		// Token: 0x04000162 RID: 354
		[global::Cpp2ILInjected.Token(Token = "0x4000191")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x6C")]
		private BZip2InputStream.CState currentState;

		// Token: 0x04000163 RID: 355
		[global::Cpp2ILInjected.Token(Token = "0x4000192")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x70")]
		private uint storedBlockCRC;

		// Token: 0x04000164 RID: 356
		[global::Cpp2ILInjected.Token(Token = "0x4000193")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x74")]
		private uint storedCombinedCRC;

		// Token: 0x04000165 RID: 357
		[global::Cpp2ILInjected.Token(Token = "0x4000194")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x78")]
		private uint computedBlockCRC;

		// Token: 0x04000166 RID: 358
		[global::Cpp2ILInjected.Token(Token = "0x4000195")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x7C")]
		private uint computedCombinedCRC;

		// Token: 0x04000167 RID: 359
		[global::Cpp2ILInjected.Token(Token = "0x4000196")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x80")]
		private int su_count;

		// Token: 0x04000168 RID: 360
		[global::Cpp2ILInjected.Token(Token = "0x4000197")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x84")]
		private int su_ch2;

		// Token: 0x04000169 RID: 361
		[global::Cpp2ILInjected.Token(Token = "0x4000198")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x88")]
		private int su_chPrev;

		// Token: 0x0400016A RID: 362
		[global::Cpp2ILInjected.Token(Token = "0x4000199")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x8C")]
		private int su_i2;

		// Token: 0x0400016B RID: 363
		[global::Cpp2ILInjected.Token(Token = "0x400019A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x90")]
		private int su_j2;

		// Token: 0x0400016C RID: 364
		[global::Cpp2ILInjected.Token(Token = "0x400019B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x94")]
		private int su_rNToGo;

		// Token: 0x0400016D RID: 365
		[global::Cpp2ILInjected.Token(Token = "0x400019C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x98")]
		private int su_rTPos;

		// Token: 0x0400016E RID: 366
		[global::Cpp2ILInjected.Token(Token = "0x400019D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x9C")]
		private int su_tPos;

		// Token: 0x0400016F RID: 367
		[global::Cpp2ILInjected.Token(Token = "0x400019E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xA0")]
		private char su_z;

		// Token: 0x04000170 RID: 368
		[global::Cpp2ILInjected.Token(Token = "0x400019F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xA8")]
		private BZip2InputStream.DecompressionState data;

		// Token: 0x02000063 RID: 99
		[global::Cpp2ILInjected.Token(Token = "0x2000038")]
		private enum CState
		{
			// Token: 0x0400030E RID: 782
			[global::Cpp2ILInjected.Token(Token = "0x40001A1")]
			EOF,
			// Token: 0x0400030F RID: 783
			[global::Cpp2ILInjected.Token(Token = "0x40001A2")]
			START_BLOCK,
			// Token: 0x04000310 RID: 784
			[global::Cpp2ILInjected.Token(Token = "0x40001A3")]
			RAND_PART_A,
			// Token: 0x04000311 RID: 785
			[global::Cpp2ILInjected.Token(Token = "0x40001A4")]
			RAND_PART_B,
			// Token: 0x04000312 RID: 786
			[global::Cpp2ILInjected.Token(Token = "0x40001A5")]
			RAND_PART_C,
			// Token: 0x04000313 RID: 787
			[global::Cpp2ILInjected.Token(Token = "0x40001A6")]
			NO_RAND_PART_A,
			// Token: 0x04000314 RID: 788
			[global::Cpp2ILInjected.Token(Token = "0x40001A7")]
			NO_RAND_PART_B,
			// Token: 0x04000315 RID: 789
			[global::Cpp2ILInjected.Token(Token = "0x40001A8")]
			NO_RAND_PART_C
		}

		// Token: 0x02000064 RID: 100
		[global::Cpp2ILInjected.Token(Token = "0x2000039")]
		private sealed class DecompressionState
		{
			// Token: 0x06000426 RID: 1062 RVA: 0x00005ADF File Offset: 0x00003CDF
			[global::Cpp2ILInjected.Token(Token = "0x60002F2")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A66B68", Offset = "0x1A66B68", Length = "0x210")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BZip2InputStream), Member = "InitBlock", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BZip2[]), Member = "InitRectangularArray", MemberTypeParameters = new object[] { typeof(int) }, MemberParameters = new object[]
			{
				typeof(int),
				typeof(int)
			}, ReturnType = "T[][]")]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BZip2[]), Member = "InitRectangularArray", MemberTypeParameters = new object[] { typeof(char) }, MemberParameters = new object[]
			{
				typeof(int),
				typeof(int)
			}, ReturnType = "T[][]")]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 17)]
			public DecompressionState(int blockSize100k)
			{
				throw null;
			}

			// Token: 0x06000427 RID: 1063 RVA: 0x00005AE2 File Offset: 0x00003CE2
			[global::Cpp2ILInjected.Token(Token = "0x60002F3")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A67C64", Offset = "0x1A67C64", Length = "0x68")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BZip2InputStream), Member = "SetupBlock", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			public int[] initTT(int length)
			{
				throw null;
			}

			// Token: 0x04000316 RID: 790
			[global::Cpp2ILInjected.Token(Token = "0x40001A9")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
			public readonly bool[] inUse;

			// Token: 0x04000317 RID: 791
			[global::Cpp2ILInjected.Token(Token = "0x40001AA")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
			public readonly byte[] seqToUnseq;

			// Token: 0x04000318 RID: 792
			[global::Cpp2ILInjected.Token(Token = "0x40001AB")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
			public readonly byte[] selector;

			// Token: 0x04000319 RID: 793
			[global::Cpp2ILInjected.Token(Token = "0x40001AC")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
			public readonly byte[] selectorMtf;

			// Token: 0x0400031A RID: 794
			[global::Cpp2ILInjected.Token(Token = "0x40001AD")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
			public readonly int[] unzftab;

			// Token: 0x0400031B RID: 795
			[global::Cpp2ILInjected.Token(Token = "0x40001AE")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
			public readonly int[][] gLimit;

			// Token: 0x0400031C RID: 796
			[global::Cpp2ILInjected.Token(Token = "0x40001AF")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
			public readonly int[][] gBase;

			// Token: 0x0400031D RID: 797
			[global::Cpp2ILInjected.Token(Token = "0x40001B0")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
			public readonly int[][] gPerm;

			// Token: 0x0400031E RID: 798
			[global::Cpp2ILInjected.Token(Token = "0x40001B1")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
			public readonly int[] gMinlen;

			// Token: 0x0400031F RID: 799
			[global::Cpp2ILInjected.Token(Token = "0x40001B2")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x58")]
			public readonly int[] cftab;

			// Token: 0x04000320 RID: 800
			[global::Cpp2ILInjected.Token(Token = "0x40001B3")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x60")]
			public readonly byte[] getAndMoveToFrontDecode_yy;

			// Token: 0x04000321 RID: 801
			[global::Cpp2ILInjected.Token(Token = "0x40001B4")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x68")]
			public readonly char[][] temp_charArray2d;

			// Token: 0x04000322 RID: 802
			[global::Cpp2ILInjected.Token(Token = "0x40001B5")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x70")]
			public readonly byte[] recvDecodingTables_pos;

			// Token: 0x04000323 RID: 803
			[global::Cpp2ILInjected.Token(Token = "0x40001B6")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x78")]
			public int[] tt;

			// Token: 0x04000324 RID: 804
			[global::Cpp2ILInjected.Token(Token = "0x40001B7")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x80")]
			public byte[] ll8;
		}
	}
}
