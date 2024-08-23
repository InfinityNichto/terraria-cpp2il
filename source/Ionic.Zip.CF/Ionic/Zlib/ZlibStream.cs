using System;
using System.IO;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace Ionic.Zlib
{
	// Token: 0x0200004B RID: 75
	[global::Cpp2ILInjected.Token(Token = "0x200005B")]
	public class ZlibStream : Stream
	{
		// Token: 0x060003C0 RID: 960 RVA: 0x000059B9 File Offset: 0x00003BB9
		[global::Cpp2ILInjected.Token(Token = "0x60003DE")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A765E0", Offset = "0x1A765E0", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public ZlibStream(Stream stream, CompressionMode mode)
		{
			throw null;
		}

		// Token: 0x060003C1 RID: 961 RVA: 0x000059BC File Offset: 0x00003BBC
		[global::Cpp2ILInjected.Token(Token = "0x60003DF")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A766A4", Offset = "0x1A766A4", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZlibStream), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(Stream),
			typeof(CompressionMode),
			typeof(CompressionLevel),
			typeof(bool)
		}, ReturnType = typeof(void))]
		public ZlibStream(Stream stream, CompressionMode mode, CompressionLevel level)
		{
			throw null;
		}

		// Token: 0x060003C2 RID: 962 RVA: 0x000059BF File Offset: 0x00003BBF
		[global::Cpp2ILInjected.Token(Token = "0x60003E0")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A766AC", Offset = "0x1A766AC", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZlibStream), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(Stream),
			typeof(CompressionMode),
			typeof(CompressionLevel),
			typeof(bool)
		}, ReturnType = typeof(void))]
		public ZlibStream(Stream stream, CompressionMode mode, bool leaveOpen)
		{
			throw null;
		}

		// Token: 0x060003C3 RID: 963 RVA: 0x000059C2 File Offset: 0x00003BC2
		[global::Cpp2ILInjected.Token(Token = "0x60003E1")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A765EC", Offset = "0x1A765EC", Length = "0xB8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ZlibStream), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(Stream),
			typeof(CompressionMode),
			typeof(CompressionLevel)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ZlibStream), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(Stream),
			typeof(CompressionMode),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ZlibStream), Member = "CompressString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ZlibStream), Member = "CompressBuffer", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ZlibStream), Member = "UncompressString", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ZlibStream), Member = "UncompressBuffer", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(byte[]))]
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
		public ZlibStream(Stream stream, CompressionMode mode, CompressionLevel level, bool leaveOpen)
		{
			throw null;
		}

		// Token: 0x170000EA RID: 234
		// (get) Token: 0x060003C4 RID: 964 RVA: 0x000059C5 File Offset: 0x00003BC5
		// (set) Token: 0x060003C5 RID: 965 RVA: 0x000059C8 File Offset: 0x00003BC8
		[global::Cpp2ILInjected.Token(Token = "0x170000EC")]
		public virtual FlushType FlushMode
		{
			[global::Cpp2ILInjected.Token(Token = "0x60003E2")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A766B8", Offset = "0x1A766B8", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x60003E3")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A766C4", Offset = "0x1A766C4", Length = "0x64")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ObjectDisposedException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
			set
			{
				throw null;
			}
		}

		// Token: 0x170000EB RID: 235
		// (get) Token: 0x060003C6 RID: 966 RVA: 0x000059CB File Offset: 0x00003BCB
		// (set) Token: 0x060003C7 RID: 967 RVA: 0x000059CE File Offset: 0x00003BCE
		[global::Cpp2ILInjected.Token(Token = "0x170000ED")]
		public int BufferSize
		{
			[global::Cpp2ILInjected.Token(Token = "0x60003E4")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A76728", Offset = "0x1A76728", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x60003E5")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A76734", Offset = "0x1A76734", Length = "0x13C")]
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

		// Token: 0x170000EC RID: 236
		// (get) Token: 0x060003C8 RID: 968 RVA: 0x000059D1 File Offset: 0x00003BD1
		[global::Cpp2ILInjected.Token(Token = "0x170000EE")]
		public virtual long TotalIn
		{
			[global::Cpp2ILInjected.Token(Token = "0x60003E6")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A76870", Offset = "0x1A76870", Length = "0x10")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170000ED RID: 237
		// (get) Token: 0x060003C9 RID: 969 RVA: 0x000059D4 File Offset: 0x00003BD4
		[global::Cpp2ILInjected.Token(Token = "0x170000EF")]
		public virtual long TotalOut
		{
			[global::Cpp2ILInjected.Token(Token = "0x60003E7")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A76880", Offset = "0x1A76880", Length = "0x10")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x060003CA RID: 970 RVA: 0x000059D7 File Offset: 0x00003BD7
		[global::Cpp2ILInjected.Token(Token = "0x60003E8")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A76890", Offset = "0x1A76890", Length = "0xCC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Stream), Member = "Dispose", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		protected override void Dispose(bool disposing)
		{
			throw null;
		}

		// Token: 0x170000EE RID: 238
		// (get) Token: 0x060003CB RID: 971 RVA: 0x000059DA File Offset: 0x00003BDA
		[global::Cpp2ILInjected.Token(Token = "0x170000F0")]
		public override bool CanRead
		{
			[global::Cpp2ILInjected.Token(Token = "0x60003E9")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A7695C", Offset = "0x1A7695C", Length = "0x6C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ObjectDisposedException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170000EF RID: 239
		// (get) Token: 0x060003CC RID: 972 RVA: 0x000059DD File Offset: 0x00003BDD
		[global::Cpp2ILInjected.Token(Token = "0x170000F1")]
		public override bool CanSeek
		{
			[global::Cpp2ILInjected.Token(Token = "0x60003EA")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A769C8", Offset = "0x1A769C8", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170000F0 RID: 240
		// (get) Token: 0x060003CD RID: 973 RVA: 0x000059E0 File Offset: 0x00003BE0
		[global::Cpp2ILInjected.Token(Token = "0x170000F2")]
		public override bool CanWrite
		{
			[global::Cpp2ILInjected.Token(Token = "0x60003EB")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A769D0", Offset = "0x1A769D0", Length = "0x6C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ObjectDisposedException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
			get
			{
				throw null;
			}
		}

		// Token: 0x060003CE RID: 974 RVA: 0x000059E3 File Offset: 0x00003BE3
		[global::Cpp2ILInjected.Token(Token = "0x60003EC")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A76A3C", Offset = "0x1A76A3C", Length = "0x6C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ObjectDisposedException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		public override void Flush()
		{
			throw null;
		}

		// Token: 0x170000F1 RID: 241
		// (get) Token: 0x060003CF RID: 975 RVA: 0x000059E6 File Offset: 0x00003BE6
		[global::Cpp2ILInjected.Token(Token = "0x170000F3")]
		public override long Length
		{
			[global::Cpp2ILInjected.Token(Token = "0x60003ED")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A76AA8", Offset = "0x1A76AA8", Length = "0x38")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170000F2 RID: 242
		// (get) Token: 0x060003D0 RID: 976 RVA: 0x000059E9 File Offset: 0x00003BE9
		// (set) Token: 0x060003D1 RID: 977 RVA: 0x000059EC File Offset: 0x00003BEC
		[global::Cpp2ILInjected.Token(Token = "0x170000F4")]
		public override long Position
		{
			[global::Cpp2ILInjected.Token(Token = "0x60003EE")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A76AE0", Offset = "0x1A76AE0", Length = "0x38")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x60003EF")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A76B18", Offset = "0x1A76B18", Length = "0x38")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
			set
			{
				throw null;
			}
		}

		// Token: 0x060003D2 RID: 978 RVA: 0x000059EF File Offset: 0x00003BEF
		[global::Cpp2ILInjected.Token(Token = "0x60003F0")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A76B50", Offset = "0x1A76B50", Length = "0x6C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ObjectDisposedException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		public override int Read(byte[] buffer, int offset, int count)
		{
			throw null;
		}

		// Token: 0x060003D3 RID: 979 RVA: 0x000059F2 File Offset: 0x00003BF2
		[global::Cpp2ILInjected.Token(Token = "0x60003F1")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A76BBC", Offset = "0x1A76BBC", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public override long Seek(long offset, SeekOrigin origin)
		{
			throw null;
		}

		// Token: 0x060003D4 RID: 980 RVA: 0x000059F5 File Offset: 0x00003BF5
		[global::Cpp2ILInjected.Token(Token = "0x60003F2")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A76BF4", Offset = "0x1A76BF4", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public override void SetLength(long value)
		{
			throw null;
		}

		// Token: 0x060003D5 RID: 981 RVA: 0x000059F8 File Offset: 0x00003BF8
		[global::Cpp2ILInjected.Token(Token = "0x60003F3")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A76C2C", Offset = "0x1A76C2C", Length = "0x6C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ObjectDisposedException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		public override void Write(byte[] buffer, int offset, int count)
		{
			throw null;
		}

		// Token: 0x060003D6 RID: 982 RVA: 0x000059FB File Offset: 0x00003BFB
		[global::Cpp2ILInjected.Token(Token = "0x60003F4")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A76C98", Offset = "0x1A76C98", Length = "0x1E8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MemoryStream), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZlibStream), Member = ".ctor", MemberParameters = new object[]
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

		// Token: 0x060003D7 RID: 983 RVA: 0x000059FE File Offset: 0x00003BFE
		[global::Cpp2ILInjected.Token(Token = "0x60003F5")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A76E80", Offset = "0x1A76E80", Length = "0x1E8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MemoryStream), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZlibStream), Member = ".ctor", MemberParameters = new object[]
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

		// Token: 0x060003D8 RID: 984 RVA: 0x00005A01 File Offset: 0x00003C01
		[global::Cpp2ILInjected.Token(Token = "0x60003F6")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A77068", Offset = "0x1A77068", Length = "0x1D4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MemoryStream), Member = ".ctor", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZlibStream), Member = ".ctor", MemberParameters = new object[]
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

		// Token: 0x060003D9 RID: 985 RVA: 0x00005A04 File Offset: 0x00003C04
		[global::Cpp2ILInjected.Token(Token = "0x60003F7")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A7723C", Offset = "0x1A7723C", Length = "0x1D4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MemoryStream), Member = ".ctor", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZlibStream), Member = ".ctor", MemberParameters = new object[]
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

		// Token: 0x040002A9 RID: 681
		[global::Cpp2ILInjected.Token(Token = "0x4000319")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		internal ZlibBaseStream _baseStream;

		// Token: 0x040002AA RID: 682
		[global::Cpp2ILInjected.Token(Token = "0x400031A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		private bool _disposed;
	}
}
