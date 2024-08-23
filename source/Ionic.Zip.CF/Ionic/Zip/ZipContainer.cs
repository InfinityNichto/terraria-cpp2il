using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Ionic.Crc;
using Ionic.Zlib;

namespace Ionic.Zip
{
	// Token: 0x0200002B RID: 43
	[global::Cpp2ILInjected.Token(Token = "0x2000031")]
	internal class ZipContainer
	{
		// Token: 0x06000261 RID: 609 RVA: 0x0000559C File Offset: 0x0000379C
		[global::Cpp2ILInjected.Token(Token = "0x6000275")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A5FA94", Offset = "0x1A5FA94", Length = "0x130")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ZipEntry), Member = "ReadDirEntry", MemberParameters = new object[]
		{
			typeof(ZipFile),
			typeof(Dictionary<string, object>)
		}, ReturnType = typeof(ZipEntry))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ZipFile), Member = "_InternalAddEntry", MemberParameters = new object[] { typeof(ZipEntry) }, ReturnType = typeof(ZipEntry))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ZipFile), Member = "AddDirectoryByName", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(ZipEntry))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ZipFile), Member = "AddOrUpdateDirectoryImpl", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(AddOrUpdateAction),
			typeof(bool),
			typeof(int)
		}, ReturnType = typeof(ZipEntry))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ZipFile), Member = "ReadIntoInstance_Orig", MemberParameters = new object[] { typeof(ZipFile) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ZipFile), Member = "Save", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ZipInputStream), Member = "_Init", MemberParameters = new object[]
		{
			typeof(Stream),
			typeof(bool),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ZipOutputStream), Member = "PutNextEntry", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(ZipEntry))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ZipOutputStream), Member = "Dispose", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 9)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public ZipContainer(object o)
		{
			throw null;
		}

		// Token: 0x170000A0 RID: 160
		// (get) Token: 0x06000262 RID: 610 RVA: 0x0000559F File Offset: 0x0000379F
		[global::Cpp2ILInjected.Token(Token = "0x170000A2")]
		public ZipFile ZipFile
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000276")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A6137C", Offset = "0x1A6137C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170000A1 RID: 161
		// (get) Token: 0x06000263 RID: 611 RVA: 0x000055A2 File Offset: 0x000037A2
		[global::Cpp2ILInjected.Token(Token = "0x170000A3")]
		public ZipOutputStream ZipOutputStream
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000277")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A61384", Offset = "0x1A61384", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170000A2 RID: 162
		// (get) Token: 0x06000264 RID: 612 RVA: 0x000055A5 File Offset: 0x000037A5
		[global::Cpp2ILInjected.Token(Token = "0x170000A4")]
		public string Name
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000278")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A6138C", Offset = "0x1A6138C", Length = "0x64")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170000A3 RID: 163
		// (get) Token: 0x06000265 RID: 613 RVA: 0x000055A8 File Offset: 0x000037A8
		[global::Cpp2ILInjected.Token(Token = "0x170000A5")]
		public string Password
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000279")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A613F0", Offset = "0x1A613F0", Length = "0x30")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ZipEntry), Member = "OpenReader", ReturnType = typeof(CrcCalculatorStream))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ZipEntry), Member = "InternalExtract", MemberParameters = new object[]
			{
				typeof(string),
				typeof(Stream),
				typeof(string)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ZipEntry), Member = "SetInputAndFigureFileLength", MemberParameters = new object[] { typeof(ref Stream) }, ReturnType = typeof(long))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ZipEntry), Member = "WriteSecurityMetadata", MemberParameters = new object[] { typeof(Stream) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170000A4 RID: 164
		// (get) Token: 0x06000266 RID: 614 RVA: 0x000055AB File Offset: 0x000037AB
		[global::Cpp2ILInjected.Token(Token = "0x170000A6")]
		public Zip64Option Zip64
		{
			[global::Cpp2ILInjected.Token(Token = "0x600027A")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A61420", Offset = "0x1A61420", Length = "0x64")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ZipEntry), Member = "WriteCentralDirectoryEntry", MemberParameters = new object[] { typeof(Stream) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ZipEntry), Member = "ConstructExtraField", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(byte[]))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ZipEntry), Member = "WriteHeader", MemberParameters = new object[]
			{
				typeof(Stream),
				typeof(int)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ZipEntry), Member = "SetZip64Flags", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ZipEntry), Member = "Write", MemberParameters = new object[] { typeof(Stream) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ZipEntry), Member = "CopyThroughOneEntry", MemberParameters = new object[] { typeof(Stream) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 10)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170000A5 RID: 165
		// (get) Token: 0x06000267 RID: 615 RVA: 0x000055AE File Offset: 0x000037AE
		[global::Cpp2ILInjected.Token(Token = "0x170000A7")]
		public int BufferSize
		{
			[global::Cpp2ILInjected.Token(Token = "0x600027B")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A61484", Offset = "0x1A61484", Length = "0x5C")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ZipEntry), Member = "get_BufferSize", ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ZipEntry), Member = "ExtractOne", MemberParameters = new object[] { typeof(Stream) }, ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ZipEntry), Member = "_WriteEntryData", MemberParameters = new object[] { typeof(Stream) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ZipEntry), Member = "CopyThroughWithRecompute", MemberParameters = new object[] { typeof(Stream) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ZipEntry), Member = "CopyThroughWithNoChange", MemberParameters = new object[] { typeof(Stream) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170000A6 RID: 166
		// (get) Token: 0x06000268 RID: 616 RVA: 0x000055B1 File Offset: 0x000037B1
		[global::Cpp2ILInjected.Token(Token = "0x170000A8")]
		public int CodecBufferSize
		{
			[global::Cpp2ILInjected.Token(Token = "0x600027C")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A614E0", Offset = "0x1A614E0", Length = "0x30")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ZipEntry), Member = "MaybeApplyCompression", MemberParameters = new object[]
			{
				typeof(Stream),
				typeof(long)
			}, ReturnType = typeof(Stream))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170000A7 RID: 167
		// (get) Token: 0x06000269 RID: 617 RVA: 0x000055B4 File Offset: 0x000037B4
		[global::Cpp2ILInjected.Token(Token = "0x170000A9")]
		public CompressionStrategy Strategy
		{
			[global::Cpp2ILInjected.Token(Token = "0x600027D")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A61510", Offset = "0x1A61510", Length = "0x20")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ZipEntry), Member = "MaybeApplyCompression", MemberParameters = new object[]
			{
				typeof(Stream),
				typeof(long)
			}, ReturnType = typeof(Stream))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170000A8 RID: 168
		// (get) Token: 0x0600026A RID: 618 RVA: 0x000055B7 File Offset: 0x000037B7
		[global::Cpp2ILInjected.Token(Token = "0x170000AA")]
		public Zip64Option UseZip64WhenSaving
		{
			[global::Cpp2ILInjected.Token(Token = "0x600027E")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A61530", Offset = "0x1A61530", Length = "0x20")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ZipEntry), Member = "CopyThroughOneEntry", MemberParameters = new object[] { typeof(Stream) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ZipEntry), Member = "CopyThroughWithRecompute", MemberParameters = new object[] { typeof(Stream) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170000A9 RID: 169
		// (get) Token: 0x0600026B RID: 619 RVA: 0x000055BA File Offset: 0x000037BA
		[global::Cpp2ILInjected.Token(Token = "0x170000AB")]
		public Encoding AlternateEncoding
		{
			[global::Cpp2ILInjected.Token(Token = "0x600027F")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A5F778", Offset = "0x1A5F778", Length = "0x2C")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ZipEntry), Member = "ReadEntry", MemberParameters = new object[]
			{
				typeof(ZipContainer),
				typeof(bool)
			}, ReturnType = typeof(ZipEntry))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170000AA RID: 170
		// (get) Token: 0x0600026C RID: 620 RVA: 0x000055BD File Offset: 0x000037BD
		[global::Cpp2ILInjected.Token(Token = "0x170000AC")]
		public Encoding DefaultEncoding
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000280")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A5F7A4", Offset = "0x1A5F7A4", Length = "0xB0")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ZipOutput), Member = "GetEncoding", MemberParameters = new object[]
			{
				typeof(ZipContainer),
				typeof(string)
			}, ReturnType = typeof(Encoding))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZipOutputStream), Member = "get_DefaultEncoding", ReturnType = typeof(Encoding))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170000AB RID: 171
		// (get) Token: 0x0600026D RID: 621 RVA: 0x000055C0 File Offset: 0x000037C0
		[global::Cpp2ILInjected.Token(Token = "0x170000AD")]
		public ZipOption AlternateEncodingUsage
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000281")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A5F750", Offset = "0x1A5F750", Length = "0x28")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170000AC RID: 172
		// (get) Token: 0x0600026E RID: 622 RVA: 0x000055C3 File Offset: 0x000037C3
		[global::Cpp2ILInjected.Token(Token = "0x170000AE")]
		public Stream ReadStream
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000282")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A61550", Offset = "0x1A61550", Length = "0x20")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ZipEntry), Member = "ReadEntry", MemberParameters = new object[]
			{
				typeof(ZipContainer),
				typeof(bool)
			}, ReturnType = typeof(ZipEntry))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZipFile), Member = "get_ReadStream", ReturnType = typeof(Stream))]
			get
			{
				throw null;
			}
		}

		// Token: 0x04000129 RID: 297
		[global::Cpp2ILInjected.Token(Token = "0x4000139")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private ZipFile _zf;

		// Token: 0x0400012A RID: 298
		[global::Cpp2ILInjected.Token(Token = "0x400013A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private ZipOutputStream _zos;

		// Token: 0x0400012B RID: 299
		[global::Cpp2ILInjected.Token(Token = "0x400013B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private ZipInputStream _zis;
	}
}
