using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace Ionic.Zlib
{
	// Token: 0x02000049 RID: 73
	[ComVisible(true)]
	[Guid("ebc25cf6-9120-4283-b972-0e5520d0000D")]
	[global::Cpp2ILInjected.Token(Token = "0x2000059")]
	public sealed class ZlibCodec
	{
		// Token: 0x170000E9 RID: 233
		// (get) Token: 0x060003A9 RID: 937 RVA: 0x00005974 File Offset: 0x00003B74
		[global::Cpp2ILInjected.Token(Token = "0x170000EB")]
		public int Adler32
		{
			[global::Cpp2ILInjected.Token(Token = "0x60003C7")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A75F38", Offset = "0x1A75F38", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x060003AA RID: 938 RVA: 0x00005977 File Offset: 0x00003B77
		[global::Cpp2ILInjected.Token(Token = "0x60003C8")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A74A8C", Offset = "0x1A74A8C", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public ZlibCodec()
		{
			throw null;
		}

		// Token: 0x060003AB RID: 939 RVA: 0x0000597A File Offset: 0x00003B7A
		[global::Cpp2ILInjected.Token(Token = "0x60003C9")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A75F40", Offset = "0x1A75F40", Length = "0xC8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "FileCompressor", Member = "Decompress", MemberParameters = new object[]
		{
			"System.Byte[]",
			typeof(int)
		}, ReturnType = "System.Byte[]")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "FileCompressor", Member = "Compress", MemberParameters = new object[]
		{
			"System.Byte[]",
			typeof(int)
		}, ReturnType = "System.Byte[]")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.Main", Member = "Decompress", MemberParameters = new object[]
		{
			"System.Byte[]",
			typeof(int)
		}, ReturnType = "System.Byte[]")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.Map.WorldMapChunk", Member = ".cctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZlibCodec), Member = "_InternalInitializeDeflate", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZlibCodec), Member = "InitializeInflate", MemberParameters = new object[]
		{
			typeof(int),
			typeof(bool)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZlibException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public ZlibCodec(CompressionMode mode)
		{
			throw null;
		}

		// Token: 0x060003AC RID: 940 RVA: 0x0000597D File Offset: 0x00003B7D
		[global::Cpp2ILInjected.Token(Token = "0x60003CA")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A76010", Offset = "0x1A76010", Length = "0x1C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.Map.WorldMapChunk", Member = "Decompress", MemberParameters = new object[]
		{
			"System.Byte[]",
			typeof(long),
			"System.Byte*",
			typeof(long),
			typeof(ref long)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZlibCodec), Member = "InitializeInflate", MemberParameters = new object[]
		{
			typeof(int),
			typeof(bool)
		}, ReturnType = typeof(int))]
		public int InitializeInflate()
		{
			throw null;
		}

		// Token: 0x060003AD RID: 941 RVA: 0x00005980 File Offset: 0x00003B80
		[global::Cpp2ILInjected.Token(Token = "0x60003CB")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A74AA0", Offset = "0x1A74AA0", Length = "0x20")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZlibCodec), Member = "InitializeInflate", MemberParameters = new object[]
		{
			typeof(int),
			typeof(bool)
		}, ReturnType = typeof(int))]
		public int InitializeInflate(bool expectRfc1950Header)
		{
			throw null;
		}

		// Token: 0x060003AE RID: 942 RVA: 0x00005983 File Offset: 0x00003B83
		[global::Cpp2ILInjected.Token(Token = "0x60003CC")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A7602C", Offset = "0x1A7602C", Length = "0x1C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZlibCodec), Member = "InitializeInflate", MemberParameters = new object[]
		{
			typeof(int),
			typeof(bool)
		}, ReturnType = typeof(int))]
		public int InitializeInflate(int windowBits)
		{
			throw null;
		}

		// Token: 0x060003AF RID: 943 RVA: 0x00005986 File Offset: 0x00003B86
		[global::Cpp2ILInjected.Token(Token = "0x60003CD")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A76048", Offset = "0x1A76048", Length = "0xDC")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ZlibBaseStream), Member = "get_z", ReturnType = typeof(ZlibCodec))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ZlibCodec), Member = ".ctor", MemberParameters = new object[] { typeof(CompressionMode) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ZlibCodec), Member = "InitializeInflate", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ZlibCodec), Member = "InitializeInflate", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ZlibCodec), Member = "InitializeInflate", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InflateManager), Member = "Initialize", MemberParameters = new object[]
		{
			typeof(ZlibCodec),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZlibException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public int InitializeInflate(int windowBits, bool expectRfc1950Header)
		{
			throw null;
		}

		// Token: 0x060003B0 RID: 944 RVA: 0x00005989 File Offset: 0x00003B89
		[global::Cpp2ILInjected.Token(Token = "0x60003CE")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A74DE8", Offset = "0x1A74DE8", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "FileCompressor", Member = "Decompress", MemberParameters = new object[]
		{
			"System.Byte[]",
			typeof(int)
		}, ReturnType = "System.Byte[]")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.Main", Member = "Decompress", MemberParameters = new object[]
		{
			"System.Byte[]",
			typeof(int)
		}, ReturnType = "System.Byte[]")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.Map.WorldMapChunk", Member = "Decompress", MemberParameters = new object[]
		{
			"System.Byte[]",
			typeof(long),
			"System.Byte*",
			typeof(long),
			typeof(ref long)
		}, ReturnType = typeof(void))]
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
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 6)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InflateManager), Member = "Inflate", MemberParameters = new object[] { typeof(FlushType) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZlibException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public int Inflate(FlushType flush)
		{
			throw null;
		}

		// Token: 0x060003B1 RID: 945 RVA: 0x0000598C File Offset: 0x00003B8C
		[global::Cpp2ILInjected.Token(Token = "0x60003CF")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A75454", Offset = "0x1A75454", Length = "0x84")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ZlibBaseStream), Member = "end", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InflateBlocks), Member = "Reset", ReturnType = typeof(uint))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZlibException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public int EndInflate()
		{
			throw null;
		}

		// Token: 0x060003B2 RID: 946 RVA: 0x0000598F File Offset: 0x00003B8F
		[global::Cpp2ILInjected.Token(Token = "0x60003D0")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A76124", Offset = "0x1A76124", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InflateManager), Member = "Sync", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZlibException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public int SyncInflate()
		{
			throw null;
		}

		// Token: 0x060003B3 RID: 947 RVA: 0x00005992 File Offset: 0x00003B92
		[global::Cpp2ILInjected.Token(Token = "0x60003D1")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A76008", Offset = "0x1A76008", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZlibCodec), Member = "_InternalInitializeDeflate", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(int))]
		public int InitializeDeflate()
		{
			throw null;
		}

		// Token: 0x060003B4 RID: 948 RVA: 0x00005995 File Offset: 0x00003B95
		[global::Cpp2ILInjected.Token(Token = "0x60003D2")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A76240", Offset = "0x1A76240", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZlibCodec), Member = "_InternalInitializeDeflate", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(int))]
		public int InitializeDeflate(CompressionLevel level)
		{
			throw null;
		}

		// Token: 0x060003B5 RID: 949 RVA: 0x00005998 File Offset: 0x00003B98
		[global::Cpp2ILInjected.Token(Token = "0x60003D3")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A74AC0", Offset = "0x1A74AC0", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZlibCodec), Member = "_InternalInitializeDeflate", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(int))]
		public int InitializeDeflate(CompressionLevel level, bool wantRfc1950Header)
		{
			throw null;
		}

		// Token: 0x060003B6 RID: 950 RVA: 0x0000599B File Offset: 0x00003B9B
		[global::Cpp2ILInjected.Token(Token = "0x60003D4")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A76250", Offset = "0x1A76250", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZlibCodec), Member = "_InternalInitializeDeflate", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(int))]
		public int InitializeDeflate(CompressionLevel level, int bits)
		{
			throw null;
		}

		// Token: 0x060003B7 RID: 951 RVA: 0x0000599E File Offset: 0x00003B9E
		[global::Cpp2ILInjected.Token(Token = "0x60003D5")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A7625C", Offset = "0x1A7625C", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZlibCodec), Member = "_InternalInitializeDeflate", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(int))]
		public int InitializeDeflate(CompressionLevel level, int bits, bool wantRfc1950Header)
		{
			throw null;
		}

		// Token: 0x060003B8 RID: 952 RVA: 0x000059A1 File Offset: 0x00003BA1
		[global::Cpp2ILInjected.Token(Token = "0x60003D6")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A7617C", Offset = "0x1A7617C", Length = "0xC4")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ZlibBaseStream), Member = "get_z", ReturnType = typeof(ZlibCodec))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ZlibCodec), Member = ".ctor", MemberParameters = new object[] { typeof(CompressionMode) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ZlibCodec), Member = "InitializeDeflate", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ZlibCodec), Member = "InitializeDeflate", MemberParameters = new object[] { typeof(CompressionLevel) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ZlibCodec), Member = "InitializeDeflate", MemberParameters = new object[]
		{
			typeof(CompressionLevel),
			typeof(bool)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ZlibCodec), Member = "InitializeDeflate", MemberParameters = new object[]
		{
			typeof(CompressionLevel),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ZlibCodec), Member = "InitializeDeflate", MemberParameters = new object[]
		{
			typeof(CompressionLevel),
			typeof(int),
			typeof(bool)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 7)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DeflateManager), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DeflateManager), Member = "Initialize", MemberParameters = new object[]
		{
			typeof(ZlibCodec),
			typeof(CompressionLevel),
			typeof(int),
			typeof(CompressionStrategy)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZlibException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		private int _InternalInitializeDeflate(bool wantRfc1950Header)
		{
			throw null;
		}

		// Token: 0x060003B9 RID: 953 RVA: 0x000059A4 File Offset: 0x00003BA4
		[global::Cpp2ILInjected.Token(Token = "0x60003D7")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A74E40", Offset = "0x1A74E40", Length = "0x5C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "FileCompressor", Member = "Compress", MemberParameters = new object[]
		{
			"System.Byte[]",
			typeof(int)
		}, ReturnType = "System.Byte[]")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.Map.WorldMapChunk", Member = "Compress", MemberParameters = new object[]
		{
			"System.Byte*",
			typeof(long),
			typeof(ref long)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DeflateManager), Member = "SetParams", MemberParameters = new object[]
		{
			typeof(CompressionLevel),
			typeof(CompressionStrategy)
		}, ReturnType = typeof(int))]
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
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 7)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DeflateManager), Member = "Deflate", MemberParameters = new object[] { typeof(FlushType) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZlibException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public int Deflate(FlushType flush)
		{
			throw null;
		}

		// Token: 0x060003BA RID: 954 RVA: 0x000059A7 File Offset: 0x00003BA7
		[global::Cpp2ILInjected.Token(Token = "0x60003D8")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A753F4", Offset = "0x1A753F4", Length = "0x60")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ZlibBaseStream), Member = "end", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZlibException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public int EndDeflate()
		{
			throw null;
		}

		// Token: 0x060003BB RID: 955 RVA: 0x000059AA File Offset: 0x00003BAA
		[global::Cpp2ILInjected.Token(Token = "0x60003D9")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A7626C", Offset = "0x1A7626C", Length = "0x5C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.Map.WorldMapChunk", Member = "Compress", MemberParameters = new object[]
		{
			"System.Byte*",
			typeof(long),
			typeof(ref long)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DeflateManager), Member = "Reset", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZlibException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public void ResetDeflate()
		{
			throw null;
		}

		// Token: 0x060003BC RID: 956 RVA: 0x000059AD File Offset: 0x00003BAD
		[global::Cpp2ILInjected.Token(Token = "0x60003DA")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A762C8", Offset = "0x1A762C8", Length = "0x5C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DeflateManager), Member = "SetParams", MemberParameters = new object[]
		{
			typeof(CompressionLevel),
			typeof(CompressionStrategy)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZlibException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public int SetDeflateParams(CompressionLevel level, CompressionStrategy strategy)
		{
			throw null;
		}

		// Token: 0x060003BD RID: 957 RVA: 0x000059B0 File Offset: 0x00003BB0
		[global::Cpp2ILInjected.Token(Token = "0x60003DB")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A76324", Offset = "0x1A76324", Length = "0x70")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InflateManager), Member = "SetDictionary", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DeflateManager), Member = "SetDictionary", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZlibException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public int SetDictionary(byte[] dictionary)
		{
			throw null;
		}

		// Token: 0x060003BE RID: 958 RVA: 0x000059B3 File Offset: 0x00003BB3
		[global::Cpp2ILInjected.Token(Token = "0x60003DC")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A76394", Offset = "0x1A76394", Length = "0x160")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DeflateManager), Member = "flush_block_only", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DeflateManager), Member = "Deflate", MemberParameters = new object[] { typeof(FlushType) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new object[]
		{
			typeof(Array),
			typeof(int),
			typeof(Array),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Format", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZlibException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
		internal void flush_pending()
		{
			throw null;
		}

		// Token: 0x060003BF RID: 959 RVA: 0x000059B6 File Offset: 0x00003BB6
		[global::Cpp2ILInjected.Token(Token = "0x60003DD")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A764F4", Offset = "0x1A764F4", Length = "0xEC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DeflateManager), Member = "_fillWindow", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Adler), Member = "Adler32", MemberParameters = new object[]
		{
			typeof(uint),
			typeof(byte[]),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(uint))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new object[]
		{
			typeof(Array),
			typeof(int),
			typeof(Array),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		internal int read_buf(byte[] buf, int start, int size)
		{
			throw null;
		}

		// Token: 0x04000290 RID: 656
		[global::Cpp2ILInjected.Token(Token = "0x4000300")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		public byte[] InputBuffer;

		// Token: 0x04000291 RID: 657
		[global::Cpp2ILInjected.Token(Token = "0x4000301")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		public int NextIn;

		// Token: 0x04000292 RID: 658
		[global::Cpp2ILInjected.Token(Token = "0x4000302")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x1C")]
		public int AvailableBytesIn;

		// Token: 0x04000293 RID: 659
		[global::Cpp2ILInjected.Token(Token = "0x4000303")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		public long TotalBytesIn;

		// Token: 0x04000294 RID: 660
		[global::Cpp2ILInjected.Token(Token = "0x4000304")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		public byte[] OutputBuffer;

		// Token: 0x04000295 RID: 661
		[global::Cpp2ILInjected.Token(Token = "0x4000305")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		public int NextOut;

		// Token: 0x04000296 RID: 662
		[global::Cpp2ILInjected.Token(Token = "0x4000306")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x34")]
		public int AvailableBytesOut;

		// Token: 0x04000297 RID: 663
		[global::Cpp2ILInjected.Token(Token = "0x4000307")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		public long TotalBytesOut;

		// Token: 0x04000298 RID: 664
		[global::Cpp2ILInjected.Token(Token = "0x4000308")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
		public string Message;

		// Token: 0x04000299 RID: 665
		[global::Cpp2ILInjected.Token(Token = "0x4000309")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
		internal DeflateManager dstate;

		// Token: 0x0400029A RID: 666
		[global::Cpp2ILInjected.Token(Token = "0x400030A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
		internal InflateManager istate;

		// Token: 0x0400029B RID: 667
		[global::Cpp2ILInjected.Token(Token = "0x400030B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x58")]
		internal uint _Adler32;

		// Token: 0x0400029C RID: 668
		[global::Cpp2ILInjected.Token(Token = "0x400030C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x5C")]
		public CompressionLevel CompressLevel;

		// Token: 0x0400029D RID: 669
		[global::Cpp2ILInjected.Token(Token = "0x400030D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x60")]
		public int WindowBits;

		// Token: 0x0400029E RID: 670
		[global::Cpp2ILInjected.Token(Token = "0x400030E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x64")]
		public CompressionStrategy Strategy;
	}
}
