using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Ionic.Crc;

namespace Ionic.Zlib
{
	// Token: 0x02000048 RID: 72
	[global::Cpp2ILInjected.Token(Token = "0x2000057")]
	internal class ZlibBaseStream : Stream
	{
		// Token: 0x170000E0 RID: 224
		// (get) Token: 0x06000390 RID: 912 RVA: 0x00005929 File Offset: 0x00003B29
		[global::Cpp2ILInjected.Token(Token = "0x170000E2")]
		internal int Crc32
		{
			[global::Cpp2ILInjected.Token(Token = "0x60003AE")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A6EC50", Offset = "0x1A6EC50", Length = "0x1C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06000391 RID: 913 RVA: 0x0000592C File Offset: 0x00003B2C
		[global::Cpp2ILInjected.Token(Token = "0x60003AF")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A6CDA4", Offset = "0x1A6CDA4", Length = "0x120")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DeflateStream), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(Stream),
			typeof(CompressionMode),
			typeof(CompressionLevel),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GZipStream), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(Stream),
			typeof(CompressionMode),
			typeof(CompressionLevel),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ZlibStream), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(Stream),
			typeof(CompressionMode),
			typeof(CompressionLevel),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Stream), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CRC32), Member = "GenerateLookupTable", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		public ZlibBaseStream(Stream stream, CompressionMode compressionMode, CompressionLevel level, ZlibStreamFlavor flavor, bool leaveOpen)
		{
			throw null;
		}

		// Token: 0x170000E1 RID: 225
		// (get) Token: 0x06000392 RID: 914 RVA: 0x0000592F File Offset: 0x00003B2F
		[global::Cpp2ILInjected.Token(Token = "0x170000E3")]
		protected internal bool _wantCompress
		{
			[global::Cpp2ILInjected.Token(Token = "0x60003B0")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A6F074", Offset = "0x1A6F074", Length = "0x10")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170000E2 RID: 226
		// (get) Token: 0x06000393 RID: 915 RVA: 0x00005932 File Offset: 0x00003B32
		[global::Cpp2ILInjected.Token(Token = "0x170000E4")]
		private ZlibCodec z
		{
			[global::Cpp2ILInjected.Token(Token = "0x60003B1")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A749D4", Offset = "0x1A749D4", Length = "0xB8")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ZlibBaseStream), Member = "Write", MemberParameters = new object[]
			{
				typeof(byte[]),
				typeof(int),
				typeof(int)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ZlibBaseStream), Member = "end", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ZlibBaseStream), Member = "Read", MemberParameters = new object[]
			{
				typeof(byte[]),
				typeof(int),
				typeof(int)
			}, ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZlibCodec), Member = "InitializeInflate", MemberParameters = new object[]
			{
				typeof(int),
				typeof(bool)
			}, ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZlibCodec), Member = "_InternalInitializeDeflate", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170000E3 RID: 227
		// (get) Token: 0x06000394 RID: 916 RVA: 0x00005935 File Offset: 0x00003B35
		[global::Cpp2ILInjected.Token(Token = "0x170000E5")]
		private byte[] workingBuffer
		{
			[global::Cpp2ILInjected.Token(Token = "0x60003B2")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A74AD0", Offset = "0x1A74AD0", Length = "0x58")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ZlibBaseStream), Member = "Write", MemberParameters = new object[]
			{
				typeof(byte[]),
				typeof(int),
				typeof(int)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ZlibBaseStream), Member = "finish", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ZlibBaseStream), Member = "Read", MemberParameters = new object[]
			{
				typeof(byte[]),
				typeof(int),
				typeof(int)
			}, ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06000395 RID: 917 RVA: 0x00005938 File Offset: 0x00003B38
		[global::Cpp2ILInjected.Token(Token = "0x60003B3")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A74B28", Offset = "0x1A74B28", Length = "0x1FC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CRC32), Member = "SlurpBlock", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZlibBaseStream), Member = "get_z", ReturnType = typeof(ZlibCodec))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZlibBaseStream), Member = "get_workingBuffer", ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZlibCodec), Member = "Inflate", MemberParameters = new object[] { typeof(FlushType) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZlibCodec), Member = "Deflate", MemberParameters = new object[] { typeof(FlushType) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZlibException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 11)]
		public override void Write(byte[] buffer, int offset, int count)
		{
			throw null;
		}

		// Token: 0x06000396 RID: 918 RVA: 0x0000593B File Offset: 0x00003B3B
		[global::Cpp2ILInjected.Token(Token = "0x60003B4")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A74E9C", Offset = "0x1A74E9C", Length = "0x524")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ZlibBaseStream), Member = "Close", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZlibBaseStream), Member = "get_workingBuffer", ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZlibCodec), Member = "Inflate", MemberParameters = new object[] { typeof(FlushType) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZlibCodec), Member = "Deflate", MemberParameters = new object[] { typeof(FlushType) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BitConverter), Member = "GetBytes", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new object[]
		{
			typeof(Array),
			typeof(int),
			typeof(Array),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BitConverter), Member = "ToInt32", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Format", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZlibException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Format", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 36)]
		private void finish()
		{
			throw null;
		}

		// Token: 0x06000397 RID: 919 RVA: 0x0000593E File Offset: 0x00003B3E
		[global::Cpp2ILInjected.Token(Token = "0x60003B5")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A753C0", Offset = "0x1A753C0", Length = "0x34")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ZlibBaseStream), Member = "Close", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZlibBaseStream), Member = "get_z", ReturnType = typeof(ZlibCodec))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZlibCodec), Member = "EndInflate", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZlibCodec), Member = "EndDeflate", ReturnType = typeof(int))]
		private void end()
		{
			throw null;
		}

		// Token: 0x06000398 RID: 920 RVA: 0x00005941 File Offset: 0x00003B41
		[global::Cpp2ILInjected.Token(Token = "0x60003B6")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A754D8", Offset = "0x1A754D8", Length = "0xC8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZlibBaseStream), Member = "finish", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZlibBaseStream), Member = "end", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		public override void Close()
		{
			throw null;
		}

		// Token: 0x06000399 RID: 921 RVA: 0x00005944 File Offset: 0x00003B44
		[global::Cpp2ILInjected.Token(Token = "0x60003B7")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A755A0", Offset = "0x1A755A0", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public override void Flush()
		{
			throw null;
		}

		// Token: 0x0600039A RID: 922 RVA: 0x00005947 File Offset: 0x00003B47
		[global::Cpp2ILInjected.Token(Token = "0x60003B8")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A755B4", Offset = "0x1A755B4", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NotImplementedException), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public override long Seek(long offset, SeekOrigin origin)
		{
			throw null;
		}

		// Token: 0x0600039B RID: 923 RVA: 0x0000594A File Offset: 0x00003B4A
		[global::Cpp2ILInjected.Token(Token = "0x60003B9")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A755EC", Offset = "0x1A755EC", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public override void SetLength(long value)
		{
			throw null;
		}

		// Token: 0x0600039C RID: 924 RVA: 0x0000594D File Offset: 0x00003B4D
		[global::Cpp2ILInjected.Token(Token = "0x60003BA")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A75600", Offset = "0x1A75600", Length = "0x1DC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ZlibBaseStream), Member = "_ReadAndValidateGzipHeader", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<byte>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZlibException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<byte>), Member = "ToArray", ReturnType = "T[]")]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 13)]
		private string ReadZeroTerminatedString()
		{
			throw null;
		}

		// Token: 0x0600039D RID: 925 RVA: 0x00005950 File Offset: 0x00003B50
		[global::Cpp2ILInjected.Token(Token = "0x60003BB")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A757DC", Offset = "0x1A757DC", Length = "0x2A0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ZlibBaseStream), Member = "Read", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BitConverter), Member = "ToInt32", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTime), Member = "AddSeconds", MemberParameters = new object[] { typeof(double) }, ReturnType = typeof(DateTime))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZlibBaseStream), Member = "ReadZeroTerminatedString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZlibException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 16)]
		private int _ReadAndValidateGzipHeader()
		{
			throw null;
		}

		// Token: 0x0600039E RID: 926 RVA: 0x00005953 File Offset: 0x00003B53
		[global::Cpp2ILInjected.Token(Token = "0x60003BC")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A75A7C", Offset = "0x1A75A7C", Length = "0x40C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZlibBaseStream), Member = "get_z", ReturnType = typeof(ZlibCodec))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZlibBaseStream), Member = "_ReadAndValidateGzipHeader", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Array), Member = "GetLowerBound", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Array), Member = "GetLength", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZlibBaseStream), Member = "get_workingBuffer", ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZlibCodec), Member = "Inflate", MemberParameters = new object[] { typeof(FlushType) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZlibCodec), Member = "Deflate", MemberParameters = new object[] { typeof(FlushType) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CRC32), Member = "SlurpBlock", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Format", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object),
			typeof(object),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZlibException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Format", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 27)]
		public override int Read(byte[] buffer, int offset, int count)
		{
			throw null;
		}

		// Token: 0x170000E4 RID: 228
		// (get) Token: 0x0600039F RID: 927 RVA: 0x00005956 File Offset: 0x00003B56
		[global::Cpp2ILInjected.Token(Token = "0x170000E6")]
		public override bool CanRead
		{
			[global::Cpp2ILInjected.Token(Token = "0x60003BD")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A75E88", Offset = "0x1A75E88", Length = "0x10")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170000E5 RID: 229
		// (get) Token: 0x060003A0 RID: 928 RVA: 0x00005959 File Offset: 0x00003B59
		[global::Cpp2ILInjected.Token(Token = "0x170000E7")]
		public override bool CanSeek
		{
			[global::Cpp2ILInjected.Token(Token = "0x60003BE")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A75E98", Offset = "0x1A75E98", Length = "0x10")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170000E6 RID: 230
		// (get) Token: 0x060003A1 RID: 929 RVA: 0x0000595C File Offset: 0x00003B5C
		[global::Cpp2ILInjected.Token(Token = "0x170000E8")]
		public override bool CanWrite
		{
			[global::Cpp2ILInjected.Token(Token = "0x60003BF")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A75EA8", Offset = "0x1A75EA8", Length = "0x10")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170000E7 RID: 231
		// (get) Token: 0x060003A2 RID: 930 RVA: 0x0000595F File Offset: 0x00003B5F
		[global::Cpp2ILInjected.Token(Token = "0x170000E9")]
		public override long Length
		{
			[global::Cpp2ILInjected.Token(Token = "0x60003C0")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A75EB8", Offset = "0x1A75EB8", Length = "0x10")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170000E8 RID: 232
		// (get) Token: 0x060003A3 RID: 931 RVA: 0x00005962 File Offset: 0x00003B62
		// (set) Token: 0x060003A4 RID: 932 RVA: 0x00005965 File Offset: 0x00003B65
		[global::Cpp2ILInjected.Token(Token = "0x170000EA")]
		public override long Position
		{
			[global::Cpp2ILInjected.Token(Token = "0x60003C1")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A75EC8", Offset = "0x1A75EC8", Length = "0x38")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NotImplementedException), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x60003C2")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A75F00", Offset = "0x1A75F00", Length = "0x38")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NotImplementedException), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
			set
			{
				throw null;
			}
		}

		// Token: 0x060003A5 RID: 933 RVA: 0x00005968 File Offset: 0x00003B68
		[global::Cpp2ILInjected.Token(Token = "0x60003C3")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A6D764", Offset = "0x1A6D764", Length = "0x18C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DeflateStream), Member = "CompressString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GZipStream), Member = "CompressString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ZlibStream), Member = "CompressString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Encoding), Member = "get_UTF8", ReturnType = typeof(Encoding))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
		public static void CompressString(string s, Stream compressor)
		{
			throw null;
		}

		// Token: 0x060003A6 RID: 934 RVA: 0x0000596B File Offset: 0x00003B6B
		[global::Cpp2ILInjected.Token(Token = "0x60003C4")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A6DAD8", Offset = "0x1A6DAD8", Length = "0x170")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DeflateStream), Member = "CompressBuffer", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GZipStream), Member = "CompressBuffer", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ZlibStream), Member = "CompressBuffer", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
		public static void CompressBuffer(byte[] b, Stream compressor)
		{
			throw null;
		}

		// Token: 0x060003A7 RID: 935 RVA: 0x0000596E File Offset: 0x00003B6E
		[global::Cpp2ILInjected.Token(Token = "0x60003C5")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A6DE1C", Offset = "0x1A6DE1C", Length = "0x398")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DeflateStream), Member = "UncompressString", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GZipStream), Member = "UncompressString", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ZlibStream), Member = "UncompressString", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Encoding), Member = "get_UTF8", ReturnType = typeof(Encoding))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MemoryStream), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StreamReader), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(Stream),
			typeof(Encoding)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 21)]
		public static string UncompressString(byte[] compressed, Stream decompressor)
		{
			throw null;
		}

		// Token: 0x060003A8 RID: 936 RVA: 0x00005971 File Offset: 0x00003B71
		[global::Cpp2ILInjected.Token(Token = "0x60003C6")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A6E388", Offset = "0x1A6E388", Length = "0x334")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DeflateStream), Member = "UncompressBuffer", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GZipStream), Member = "UncompressBuffer", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ZlibStream), Member = "UncompressBuffer", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MemoryStream), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 19)]
		public static byte[] UncompressBuffer(byte[] compressed, Stream decompressor)
		{
			throw null;
		}

		// Token: 0x0400027E RID: 638
		[global::Cpp2ILInjected.Token(Token = "0x40002EA")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		protected internal ZlibCodec _z;

		// Token: 0x0400027F RID: 639
		[global::Cpp2ILInjected.Token(Token = "0x40002EB")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		protected internal ZlibBaseStream.StreamMode _streamMode;

		// Token: 0x04000280 RID: 640
		[global::Cpp2ILInjected.Token(Token = "0x40002EC")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x34")]
		protected internal FlushType _flushMode;

		// Token: 0x04000281 RID: 641
		[global::Cpp2ILInjected.Token(Token = "0x40002ED")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		protected internal ZlibStreamFlavor _flavor;

		// Token: 0x04000282 RID: 642
		[global::Cpp2ILInjected.Token(Token = "0x40002EE")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x3C")]
		protected internal CompressionMode _compressionMode;

		// Token: 0x04000283 RID: 643
		[global::Cpp2ILInjected.Token(Token = "0x40002EF")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
		protected internal CompressionLevel _level;

		// Token: 0x04000284 RID: 644
		[global::Cpp2ILInjected.Token(Token = "0x40002F0")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x44")]
		protected internal bool _leaveOpen;

		// Token: 0x04000285 RID: 645
		[global::Cpp2ILInjected.Token(Token = "0x40002F1")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
		protected internal byte[] _workingBuffer;

		// Token: 0x04000286 RID: 646
		[global::Cpp2ILInjected.Token(Token = "0x40002F2")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
		protected internal int _bufferSize;

		// Token: 0x04000287 RID: 647
		[global::Cpp2ILInjected.Token(Token = "0x40002F3")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x58")]
		protected internal byte[] _buf1;

		// Token: 0x04000288 RID: 648
		[global::Cpp2ILInjected.Token(Token = "0x40002F4")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x60")]
		protected internal Stream _stream;

		// Token: 0x04000289 RID: 649
		[global::Cpp2ILInjected.Token(Token = "0x40002F5")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x68")]
		protected internal CompressionStrategy Strategy;

		// Token: 0x0400028A RID: 650
		[global::Cpp2ILInjected.Token(Token = "0x40002F6")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x70")]
		private CRC32 crc;

		// Token: 0x0400028B RID: 651
		[global::Cpp2ILInjected.Token(Token = "0x40002F7")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x78")]
		protected internal string _GzipFileName;

		// Token: 0x0400028C RID: 652
		[global::Cpp2ILInjected.Token(Token = "0x40002F8")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x80")]
		protected internal string _GzipComment;

		// Token: 0x0400028D RID: 653
		[global::Cpp2ILInjected.Token(Token = "0x40002F9")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x88")]
		protected internal DateTime _GzipMtime;

		// Token: 0x0400028E RID: 654
		[global::Cpp2ILInjected.Token(Token = "0x40002FA")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x90")]
		protected internal int _gzipHeaderByteCount;

		// Token: 0x0400028F RID: 655
		[global::Cpp2ILInjected.Token(Token = "0x40002FB")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x94")]
		private bool nomoreinput;

		// Token: 0x0200006A RID: 106
		[global::Cpp2ILInjected.Token(Token = "0x2000058")]
		internal enum StreamMode
		{
			// Token: 0x0400034B RID: 843
			[global::Cpp2ILInjected.Token(Token = "0x40002FD")]
			Writer,
			// Token: 0x0400034C RID: 844
			[global::Cpp2ILInjected.Token(Token = "0x40002FE")]
			Reader,
			// Token: 0x0400034D RID: 845
			[global::Cpp2ILInjected.Token(Token = "0x40002FF")]
			Undefined
		}
	}
}
