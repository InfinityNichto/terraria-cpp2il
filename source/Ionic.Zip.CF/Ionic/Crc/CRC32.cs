using System;
using System.IO;
using System.Runtime.InteropServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Ionic.BZip2;
using Ionic.Zip;
using Ionic.Zlib;

namespace Ionic.Crc
{
	// Token: 0x0200004C RID: 76
	[Guid("ebc25cf6-9120-4283-b972-0e5520d0000C")]
	[ComVisible(true)]
	[global::Cpp2ILInjected.Token(Token = "0x200005C")]
	public class CRC32
	{
		// Token: 0x170000F3 RID: 243
		// (get) Token: 0x060003DA RID: 986 RVA: 0x00005A07 File Offset: 0x00003C07
		[global::Cpp2ILInjected.Token(Token = "0x170000F5")]
		public long TotalBytesRead
		{
			[global::Cpp2ILInjected.Token(Token = "0x60003F8")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A77410", Offset = "0x1A77410", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170000F4 RID: 244
		// (get) Token: 0x060003DB RID: 987 RVA: 0x00005A0A File Offset: 0x00003C0A
		[global::Cpp2ILInjected.Token(Token = "0x170000F6")]
		public int Crc32Result
		{
			[global::Cpp2ILInjected.Token(Token = "0x60003F9")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A74994", Offset = "0x1A74994", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BZip2Compressor), Member = "CompressAndWrite", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BZip2InputStream), Member = "EndBlock", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
			get
			{
				throw null;
			}
		}

		// Token: 0x060003DC RID: 988 RVA: 0x00005A0D File Offset: 0x00003C0D
		[global::Cpp2ILInjected.Token(Token = "0x60003FA")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A77418", Offset = "0x1A77418", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ZipEntry), Member = "FigureCrc32", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		public int GetCrc32(Stream input)
		{
			throw null;
		}

		// Token: 0x060003DD RID: 989 RVA: 0x00005A10 File Offset: 0x00003C10
		[global::Cpp2ILInjected.Token(Token = "0x60003FB")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A77420", Offset = "0x1A77420", Length = "0x184")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CRC32), Member = "SlurpBlock", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Exception), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public int GetCrc32AndCopy(Stream input, Stream output)
		{
			throw null;
		}

		// Token: 0x060003DE RID: 990 RVA: 0x00005A13 File Offset: 0x00003C13
		[global::Cpp2ILInjected.Token(Token = "0x60003FC")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A775A4", Offset = "0x1A775A4", Length = "0x1C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ZipCrypto), Member = "UpdateKeys", MemberParameters = new object[] { typeof(byte) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		public int ComputeCrc32(int W, byte B)
		{
			throw null;
		}

		// Token: 0x060003DF RID: 991 RVA: 0x00005A16 File Offset: 0x00003C16
		[global::Cpp2ILInjected.Token(Token = "0x60003FD")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A775C0", Offset = "0x1A775C0", Length = "0x1C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		internal int _InternalComputeCrc32(uint W, byte B)
		{
			throw null;
		}

		// Token: 0x060003E0 RID: 992 RVA: 0x00005A19 File Offset: 0x00003C19
		[global::Cpp2ILInjected.Token(Token = "0x60003FE")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A74D24", Offset = "0x1A74D24", Length = "0xC4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ZlibBaseStream), Member = "Write", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ZlibBaseStream), Member = "Read", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CRC32), Member = "GetCrc32AndCopy", MemberParameters = new object[]
		{
			typeof(Stream),
			typeof(Stream)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CrcCalculatorStream), Member = "Read", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CrcCalculatorStream), Member = "Write", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Exception), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public void SlurpBlock(byte[] block, int offset, int count)
		{
			throw null;
		}

		// Token: 0x060003E1 RID: 993 RVA: 0x00005A1C File Offset: 0x00003C1C
		[global::Cpp2ILInjected.Token(Token = "0x60003FF")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A775DC", Offset = "0x1A775DC", Length = "0x48")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BZip2InputStream), Member = "SetupRandPartA", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BZip2InputStream), Member = "SetupNoRandPartA", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BZip2InputStream), Member = "SetupRandPartC", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BZip2InputStream), Member = "SetupNoRandPartC", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		public void UpdateCRC(byte b)
		{
			throw null;
		}

		// Token: 0x060003E2 RID: 994 RVA: 0x00005A1F File Offset: 0x00003C1F
		[global::Cpp2ILInjected.Token(Token = "0x6000400")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A77624", Offset = "0x1A77624", Length = "0x5C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BZip2Compressor), Member = "AddRunToOutputBlock", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		public void UpdateCRC(byte b, int n)
		{
			throw null;
		}

		// Token: 0x060003E3 RID: 995 RVA: 0x00005A22 File Offset: 0x00003C22
		[global::Cpp2ILInjected.Token(Token = "0x6000401")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A77680", Offset = "0x1A77680", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CRC32), Member = "GenerateLookupTable", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		private static uint ReverseBits(uint data)
		{
			throw null;
		}

		// Token: 0x060003E4 RID: 996 RVA: 0x00005A25 File Offset: 0x00003C25
		[global::Cpp2ILInjected.Token(Token = "0x6000402")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A77688", Offset = "0x1A77688", Length = "0x4C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private static byte ReverseBits(byte data)
		{
			throw null;
		}

		// Token: 0x060003E5 RID: 997 RVA: 0x00005A28 File Offset: 0x00003C28
		[global::Cpp2ILInjected.Token(Token = "0x6000403")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A776D4", Offset = "0x1A776D4", Length = "0x10C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ZlibBaseStream), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(Stream),
			typeof(CompressionMode),
			typeof(CompressionLevel),
			typeof(ZlibStreamFlavor),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CRC32), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CRC32), Member = ".ctor", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CRC32), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CrcCalculatorStream), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(bool),
			typeof(long),
			typeof(Stream),
			typeof(CRC32)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CRC32), Member = "ReverseBits", MemberParameters = new object[] { typeof(uint) }, ReturnType = typeof(uint))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private void GenerateLookupTable()
		{
			throw null;
		}

		// Token: 0x060003E6 RID: 998 RVA: 0x00005A2B File Offset: 0x00003C2B
		[global::Cpp2ILInjected.Token(Token = "0x6000404")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A777E0", Offset = "0x1A777E0", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private uint gf2_matrix_times(uint[] matrix, uint vec)
		{
			throw null;
		}

		// Token: 0x060003E7 RID: 999 RVA: 0x00005A2E File Offset: 0x00003C2E
		[global::Cpp2ILInjected.Token(Token = "0x6000405")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A77808", Offset = "0x1A77808", Length = "0x54")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private void gf2_matrix_square(uint[] square, uint[] mat)
		{
			throw null;
		}

		// Token: 0x060003E8 RID: 1000 RVA: 0x00005A31 File Offset: 0x00003C31
		[global::Cpp2ILInjected.Token(Token = "0x6000406")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A7785C", Offset = "0x1A7785C", Length = "0x264")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public void Combine(int crc, int length)
		{
			throw null;
		}

		// Token: 0x060003E9 RID: 1001 RVA: 0x00005A34 File Offset: 0x00003C34
		[global::Cpp2ILInjected.Token(Token = "0x6000407")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A749A0", Offset = "0x1A749A0", Length = "0x34")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ZipCrypto), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ZipEntry), Member = "FigureCrc32", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CRC32), Member = "GenerateLookupTable", ReturnType = typeof(void))]
		public CRC32()
		{
			throw null;
		}

		// Token: 0x060003EA RID: 1002 RVA: 0x00005A37 File Offset: 0x00003C37
		[global::Cpp2ILInjected.Token(Token = "0x6000408")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A77AC0", Offset = "0x1A77AC0", Length = "0x40")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BZip2Compressor), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(BitWriter),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BZip2InputStream), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(Stream),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CRC32), Member = "GenerateLookupTable", ReturnType = typeof(void))]
		public CRC32(bool reverseBits)
		{
			throw null;
		}

		// Token: 0x060003EB RID: 1003 RVA: 0x00005A3A File Offset: 0x00003C3A
		[global::Cpp2ILInjected.Token(Token = "0x6000409")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A77B00", Offset = "0x1A77B00", Length = "0x3C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CRC32), Member = "GenerateLookupTable", ReturnType = typeof(void))]
		public CRC32(int polynomial, bool reverseBits)
		{
			throw null;
		}

		// Token: 0x060003EC RID: 1004 RVA: 0x00005A3D File Offset: 0x00003C3D
		[global::Cpp2ILInjected.Token(Token = "0x600040A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A77B3C", Offset = "0x1A77B3C", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BZip2Compressor), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(BitWriter),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BZip2Compressor), Member = "Reset", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BZip2Compressor), Member = "CompressAndWrite", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BZip2InputStream), Member = "InitBlock", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		public void Reset()
		{
			throw null;
		}

		// Token: 0x040002AB RID: 683
		[global::Cpp2ILInjected.Token(Token = "0x400031B")]
		private const int BUFFER_SIZE = 8192;

		// Token: 0x040002AC RID: 684
		[global::Cpp2ILInjected.Token(Token = "0x400031C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private uint dwPolynomial;

		// Token: 0x040002AD RID: 685
		[global::Cpp2ILInjected.Token(Token = "0x400031D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private long _TotalBytesRead;

		// Token: 0x040002AE RID: 686
		[global::Cpp2ILInjected.Token(Token = "0x400031E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private bool reverseBits;

		// Token: 0x040002AF RID: 687
		[global::Cpp2ILInjected.Token(Token = "0x400031F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private uint[] crc32Table;

		// Token: 0x040002B0 RID: 688
		[global::Cpp2ILInjected.Token(Token = "0x4000320")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		private uint _register;
	}
}
