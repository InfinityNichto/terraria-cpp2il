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
	// Token: 0x0200002A RID: 42
	[global::Cpp2ILInjected.Token(Token = "0x2000030")]
	public class ZipOutputStream : Stream
	{
		// Token: 0x0600022C RID: 556 RVA: 0x000054FD File Offset: 0x000036FD
		[global::Cpp2ILInjected.Token(Token = "0x6000240")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A601F0", Offset = "0x1A601F0", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public ZipOutputStream(Stream stream)
		{
			throw null;
		}

		// Token: 0x0600022D RID: 557 RVA: 0x00005500 File Offset: 0x00003700
		[global::Cpp2ILInjected.Token(Token = "0x6000241")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A602A0", Offset = "0x1A602A0", Length = "0xB4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Encoding), Member = "GetEncoding", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(Encoding))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Stream), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(File), Member = "Open", MemberParameters = new object[]
		{
			typeof(string),
			typeof(FileMode),
			typeof(FileAccess),
			typeof(FileShare)
		}, ReturnType = typeof(FileStream))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public ZipOutputStream(string fileName)
		{
			throw null;
		}

		// Token: 0x0600022E RID: 558 RVA: 0x00005503 File Offset: 0x00003703
		[global::Cpp2ILInjected.Token(Token = "0x6000242")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A601F8", Offset = "0x1A601F8", Length = "0xA8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Encoding), Member = "GetEncoding", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(Encoding))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Stream), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZipOutputStream), Member = "_Init", MemberParameters = new object[]
		{
			typeof(Stream),
			typeof(bool),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public ZipOutputStream(Stream stream, bool leaveOpen)
		{
			throw null;
		}

		// Token: 0x0600022F RID: 559 RVA: 0x00005506 File Offset: 0x00003706
		[global::Cpp2ILInjected.Token(Token = "0x6000243")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A60354", Offset = "0x1A60354", Length = "0x184")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ZipOutputStream), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(Stream),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CountingStream), Member = ".ctor", MemberParameters = new object[] { typeof(Stream) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, object>), Member = ".ctor", MemberParameters = new object[] { typeof(IEqualityComparer<object>) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
		private void _Init(Stream stream, bool leaveOpen, string name)
		{
			throw null;
		}

		// Token: 0x06000230 RID: 560 RVA: 0x00005509 File Offset: 0x00003709
		[global::Cpp2ILInjected.Token(Token = "0x6000244")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A604D8", Offset = "0x1A604D8", Length = "0x8C")]
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

		// Token: 0x17000089 RID: 137
		// (set) Token: 0x06000231 RID: 561 RVA: 0x0000550C File Offset: 0x0000370C
		[global::Cpp2ILInjected.Token(Token = "0x1700008B")]
		public string Password
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000245")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A60564", Offset = "0x1A60564", Length = "0x84")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
			set
			{
				throw null;
			}
		}

		// Token: 0x1700008A RID: 138
		// (get) Token: 0x06000232 RID: 562 RVA: 0x0000550F File Offset: 0x0000370F
		// (set) Token: 0x06000233 RID: 563 RVA: 0x00005512 File Offset: 0x00003712
		[global::Cpp2ILInjected.Token(Token = "0x1700008C")]
		public EncryptionAlgorithm Encryption
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000246")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A605E8", Offset = "0x1A605E8", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6000247")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A605F0", Offset = "0x1A605F0", Length = "0x98")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
			set
			{
				throw null;
			}
		}

		// Token: 0x1700008B RID: 139
		// (get) Token: 0x06000234 RID: 564 RVA: 0x00005515 File Offset: 0x00003715
		// (set) Token: 0x06000235 RID: 565 RVA: 0x00005518 File Offset: 0x00003718
		[global::Cpp2ILInjected.Token(Token = "0x1700008D")]
		public int CodecBufferSize
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000248")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A60688", Offset = "0x1A60688", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6000249")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A60690", Offset = "0x1A60690", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x1700008C RID: 140
		// (get) Token: 0x06000236 RID: 566 RVA: 0x0000551B File Offset: 0x0000371B
		// (set) Token: 0x06000237 RID: 567 RVA: 0x0000551E File Offset: 0x0000371E
		[global::Cpp2ILInjected.Token(Token = "0x1700008E")]
		public CompressionStrategy Strategy
		{
			[global::Cpp2ILInjected.Token(Token = "0x600024A")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A60698", Offset = "0x1A60698", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x600024B")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A606A0", Offset = "0x1A606A0", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x1700008D RID: 141
		// (get) Token: 0x06000238 RID: 568 RVA: 0x00005521 File Offset: 0x00003721
		// (set) Token: 0x06000239 RID: 569 RVA: 0x00005524 File Offset: 0x00003724
		[global::Cpp2ILInjected.Token(Token = "0x1700008F")]
		public ZipEntryTimestamp Timestamp
		{
			[global::Cpp2ILInjected.Token(Token = "0x600024C")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A606A8", Offset = "0x1A606A8", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x600024D")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A606B0", Offset = "0x1A606B0", Length = "0x68")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
			set
			{
				throw null;
			}
		}

		// Token: 0x1700008E RID: 142
		// (get) Token: 0x0600023A RID: 570 RVA: 0x00005527 File Offset: 0x00003727
		// (set) Token: 0x0600023B RID: 571 RVA: 0x0000552A File Offset: 0x0000372A
		[global::Cpp2ILInjected.Token(Token = "0x17000090")]
		public CompressionLevel CompressionLevel
		{
			[global::Cpp2ILInjected.Token(Token = "0x600024E")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A60718", Offset = "0x1A60718", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x600024F")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A60720", Offset = "0x1A60720", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x1700008F RID: 143
		// (get) Token: 0x0600023C RID: 572 RVA: 0x0000552D File Offset: 0x0000372D
		// (set) Token: 0x0600023D RID: 573 RVA: 0x00005530 File Offset: 0x00003730
		[global::Cpp2ILInjected.Token(Token = "0x17000091")]
		public CompressionMethod CompressionMethod
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000250")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A60728", Offset = "0x1A60728", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6000251")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A60730", Offset = "0x1A60730", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x17000090 RID: 144
		// (get) Token: 0x0600023E RID: 574 RVA: 0x00005533 File Offset: 0x00003733
		// (set) Token: 0x0600023F RID: 575 RVA: 0x00005536 File Offset: 0x00003736
		[global::Cpp2ILInjected.Token(Token = "0x17000092")]
		public string Comment
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000252")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A60738", Offset = "0x1A60738", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6000253")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A60740", Offset = "0x1A60740", Length = "0x68")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
			set
			{
				throw null;
			}
		}

		// Token: 0x17000091 RID: 145
		// (get) Token: 0x06000240 RID: 576 RVA: 0x00005539 File Offset: 0x00003739
		// (set) Token: 0x06000241 RID: 577 RVA: 0x0000553C File Offset: 0x0000373C
		[global::Cpp2ILInjected.Token(Token = "0x17000093")]
		public Zip64Option EnableZip64
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000254")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A607A8", Offset = "0x1A607A8", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6000255")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A607B0", Offset = "0x1A607B0", Length = "0x68")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
			set
			{
				throw null;
			}
		}

		// Token: 0x17000092 RID: 146
		// (get) Token: 0x06000242 RID: 578 RVA: 0x0000553F File Offset: 0x0000373F
		[global::Cpp2ILInjected.Token(Token = "0x17000094")]
		public bool OutputUsedZip64
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000256")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A60818", Offset = "0x1A60818", Length = "0x20")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000093 RID: 147
		// (get) Token: 0x06000243 RID: 579 RVA: 0x00005542 File Offset: 0x00003742
		// (set) Token: 0x06000244 RID: 580 RVA: 0x00005545 File Offset: 0x00003745
		[global::Cpp2ILInjected.Token(Token = "0x17000095")]
		public bool IgnoreCase
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000257")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A60838", Offset = "0x1A60838", Length = "0x10")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6000258")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A60848", Offset = "0x1A60848", Length = "0x10")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x17000094 RID: 148
		// (get) Token: 0x06000245 RID: 581 RVA: 0x00005548 File Offset: 0x00003748
		// (set) Token: 0x06000246 RID: 582 RVA: 0x0000554B File Offset: 0x0000374B
		[Obsolete("Beginning with v1.9.1.6 of DotNetZip, this property is obsolete. It will be removed in a future version of the library. Use AlternateEncoding and AlternateEncodingUsage instead.")]
		[global::Cpp2ILInjected.Token(Token = "0x17000096")]
		public bool UseUnicodeAsNecessary
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000259")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A60858", Offset = "0x1A60858", Length = "0x40")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Encoding), Member = "get_UTF8", ReturnType = typeof(Encoding))]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x600025A")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A60898", Offset = "0x1A60898", Length = "0x34")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Encoding), Member = "get_UTF8", ReturnType = typeof(Encoding))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZipOutputStream), Member = "get_DefaultEncoding", ReturnType = typeof(Encoding))]
			set
			{
				throw null;
			}
		}

		// Token: 0x17000095 RID: 149
		// (get) Token: 0x06000247 RID: 583 RVA: 0x0000554E File Offset: 0x0000374E
		// (set) Token: 0x06000248 RID: 584 RVA: 0x00005551 File Offset: 0x00003751
		[Obsolete("use AlternateEncoding and AlternateEncodingUsage instead.")]
		[global::Cpp2ILInjected.Token(Token = "0x17000097")]
		public Encoding ProvisionalAlternateEncoding
		{
			[global::Cpp2ILInjected.Token(Token = "0x600025B")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A60910", Offset = "0x1A60910", Length = "0x1C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x600025C")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A6092C", Offset = "0x1A6092C", Length = "0x10")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x17000096 RID: 150
		// (get) Token: 0x06000249 RID: 585 RVA: 0x00005554 File Offset: 0x00003754
		// (set) Token: 0x0600024A RID: 586 RVA: 0x00005557 File Offset: 0x00003757
		[global::Cpp2ILInjected.Token(Token = "0x17000098")]
		public Encoding AlternateEncoding
		{
			[global::Cpp2ILInjected.Token(Token = "0x600025D")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A6093C", Offset = "0x1A6093C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x600025E")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A60944", Offset = "0x1A60944", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x17000097 RID: 151
		// (get) Token: 0x0600024B RID: 587 RVA: 0x0000555A File Offset: 0x0000375A
		// (set) Token: 0x0600024C RID: 588 RVA: 0x0000555D File Offset: 0x0000375D
		[global::Cpp2ILInjected.Token(Token = "0x17000099")]
		public ZipOption AlternateEncodingUsage
		{
			[global::Cpp2ILInjected.Token(Token = "0x600025F")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A6094C", Offset = "0x1A6094C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6000260")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A60954", Offset = "0x1A60954", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x17000098 RID: 152
		// (get) Token: 0x0600024D RID: 589 RVA: 0x00005560 File Offset: 0x00003760
		[global::Cpp2ILInjected.Token(Token = "0x1700009A")]
		public static Encoding DefaultEncoding
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000261")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A608CC", Offset = "0x1A608CC", Length = "0x44")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ZipOutputStream), Member = "set_UseUnicodeAsNecessary", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ZipContainer), Member = "get_DefaultEncoding", ReturnType = typeof(Encoding))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Encoding), Member = "GetEncoding", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(Encoding))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0600024E RID: 590 RVA: 0x00005563 File Offset: 0x00003763
		[global::Cpp2ILInjected.Token(Token = "0x6000262")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A6095C", Offset = "0x1A6095C", Length = "0xC0")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ZipOutputStream), Member = "PutNextEntry", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(ZipEntry))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, object>), Member = "ContainsKey", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Format", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		private void InsureUniqueEntry(ZipEntry ze1)
		{
			throw null;
		}

		// Token: 0x17000099 RID: 153
		// (get) Token: 0x0600024F RID: 591 RVA: 0x00005566 File Offset: 0x00003766
		[global::Cpp2ILInjected.Token(Token = "0x1700009B")]
		internal Stream OutputStream
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000263")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A60A1C", Offset = "0x1A60A1C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700009A RID: 154
		// (get) Token: 0x06000250 RID: 592 RVA: 0x00005569 File Offset: 0x00003769
		[global::Cpp2ILInjected.Token(Token = "0x1700009C")]
		internal string Name
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000264")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A60A24", Offset = "0x1A60A24", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06000251 RID: 593 RVA: 0x0000556C File Offset: 0x0000376C
		[global::Cpp2ILInjected.Token(Token = "0x6000265")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A60A2C", Offset = "0x1A60A2C", Length = "0x8C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SharedUtilities), Member = "NormalizePathForUseInZipFile", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, object>), Member = "ContainsKey", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public bool ContainsEntry(string name)
		{
			throw null;
		}

		// Token: 0x06000252 RID: 594 RVA: 0x0000556F File Offset: 0x0000376F
		[global::Cpp2ILInjected.Token(Token = "0x6000266")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A60AB8", Offset = "0x1A60AB8", Length = "0x168")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZipOutputStream), Member = "_InitiateCurrentEntry", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 13)]
		public override void Write(byte[] buffer, int offset, int count)
		{
			throw null;
		}

		// Token: 0x06000253 RID: 595 RVA: 0x00005572 File Offset: 0x00003772
		[global::Cpp2ILInjected.Token(Token = "0x6000267")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A60D54", Offset = "0x1A60D54", Length = "0x27C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZipOutputStream), Member = "_FinishCurrentEntry", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZipEntry), Member = "CreateForZipOutputStream", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(ZipEntry))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZipContainer), Member = ".ctor", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTime), Member = "get_Now", ReturnType = typeof(DateTime))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZipEntry), Member = "SetEntryTimes", MemberParameters = new object[]
		{
			typeof(DateTime),
			typeof(DateTime),
			typeof(DateTime)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZipEntry), Member = "set_CompressionLevel", MemberParameters = new object[] { typeof(CompressionLevel) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZipEntry), Member = "set_CompressionMethod", MemberParameters = new object[] { typeof(CompressionMethod) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZipEntry), Member = "set_Password", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZipEntry), Member = "set_Encryption", MemberParameters = new object[] { typeof(EncryptionAlgorithm) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "EndsWith", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZipEntry), Member = "MarkAsDirectory", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZipEntry), Member = "set_EmitTimesInWindowsFormatWhenSaving", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZipEntry), Member = "set_EmitTimesInUnixFormatWhenSaving", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZipOutputStream), Member = "InsureUniqueEntry", MemberParameters = new object[] { typeof(ZipEntry) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 15)]
		public ZipEntry PutNextEntry(string entryName)
		{
			throw null;
		}

		// Token: 0x06000254 RID: 596 RVA: 0x00005575 File Offset: 0x00003775
		[global::Cpp2ILInjected.Token(Token = "0x6000268")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A60C20", Offset = "0x1A60C20", Length = "0x134")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ZipOutputStream), Member = "Write", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ZipOutputStream), Member = "_FinishCurrentEntry", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, object>), Member = "Add", MemberParameters = new object[]
		{
			typeof(object),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZipEntry), Member = "WriteHeader", MemberParameters = new object[]
		{
			typeof(Stream),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZipEntry), Member = "StoreRelativeOffset", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZipEntry), Member = "WriteSecurityMetadata", MemberParameters = new object[] { typeof(Stream) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZipEntry), Member = "PrepOutputStream", MemberParameters = new object[]
		{
			typeof(Stream),
			typeof(long),
			typeof(ref CountingStream),
			typeof(ref Stream),
			typeof(ref Stream),
			typeof(ref CrcCalculatorStream)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		private void _InitiateCurrentEntry(bool finishing)
		{
			throw null;
		}

		// Token: 0x06000255 RID: 597 RVA: 0x00005578 File Offset: 0x00003778
		[global::Cpp2ILInjected.Token(Token = "0x6000269")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A60FD0", Offset = "0x1A60FD0", Length = "0xDC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ZipOutputStream), Member = "PutNextEntry", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(ZipEntry))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ZipOutputStream), Member = "Dispose", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZipOutputStream), Member = "_InitiateCurrentEntry", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZipEntry), Member = "FinishOutputStream", MemberParameters = new object[]
		{
			typeof(Stream),
			typeof(CountingStream),
			typeof(Stream),
			typeof(Stream),
			typeof(CrcCalculatorStream)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZipEntry), Member = "PostProcessOutput", MemberParameters = new object[] { typeof(Stream) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Nullable<>), Member = "get_Value", ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private void _FinishCurrentEntry()
		{
			throw null;
		}

		// Token: 0x06000256 RID: 598 RVA: 0x0000557B File Offset: 0x0000377B
		[global::Cpp2ILInjected.Token(Token = "0x600026A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A610AC", Offset = "0x1A610AC", Length = "0x164")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZipOutputStream), Member = "_FinishCurrentEntry", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, object>), Member = "get_Values", ReturnType = "ValueCollection<TKey, TValue>")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZipContainer), Member = ".ctor", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZipOutput), Member = "WriteCentralDirectoryStructure", MemberParameters = new object[]
		{
			typeof(Stream),
			typeof(ICollection<ZipEntry>),
			typeof(uint),
			typeof(Zip64Option),
			typeof(string),
			typeof(ZipContainer)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		protected override void Dispose(bool disposing)
		{
			throw null;
		}

		// Token: 0x1700009B RID: 155
		// (get) Token: 0x06000257 RID: 599 RVA: 0x0000557E File Offset: 0x0000377E
		[global::Cpp2ILInjected.Token(Token = "0x1700009D")]
		public override bool CanRead
		{
			[global::Cpp2ILInjected.Token(Token = "0x600026B")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A61210", Offset = "0x1A61210", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700009C RID: 156
		// (get) Token: 0x06000258 RID: 600 RVA: 0x00005581 File Offset: 0x00003781
		[global::Cpp2ILInjected.Token(Token = "0x1700009E")]
		public override bool CanSeek
		{
			[global::Cpp2ILInjected.Token(Token = "0x600026C")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A61218", Offset = "0x1A61218", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700009D RID: 157
		// (get) Token: 0x06000259 RID: 601 RVA: 0x00005584 File Offset: 0x00003784
		[global::Cpp2ILInjected.Token(Token = "0x1700009F")]
		public override bool CanWrite
		{
			[global::Cpp2ILInjected.Token(Token = "0x600026D")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A61220", Offset = "0x1A61220", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700009E RID: 158
		// (get) Token: 0x0600025A RID: 602 RVA: 0x00005587 File Offset: 0x00003787
		[global::Cpp2ILInjected.Token(Token = "0x170000A0")]
		public override long Length
		{
			[global::Cpp2ILInjected.Token(Token = "0x600026E")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A61228", Offset = "0x1A61228", Length = "0x38")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700009F RID: 159
		// (get) Token: 0x0600025B RID: 603 RVA: 0x0000558A File Offset: 0x0000378A
		// (set) Token: 0x0600025C RID: 604 RVA: 0x0000558D File Offset: 0x0000378D
		[global::Cpp2ILInjected.Token(Token = "0x170000A1")]
		public override long Position
		{
			[global::Cpp2ILInjected.Token(Token = "0x600026F")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A61260", Offset = "0x1A61260", Length = "0x10")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6000270")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A61270", Offset = "0x1A61270", Length = "0x38")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
			set
			{
				throw null;
			}
		}

		// Token: 0x0600025D RID: 605 RVA: 0x00005590 File Offset: 0x00003790
		[global::Cpp2ILInjected.Token(Token = "0x6000271")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A612A8", Offset = "0x1A612A8", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public override void Flush()
		{
			throw null;
		}

		// Token: 0x0600025E RID: 606 RVA: 0x00005593 File Offset: 0x00003793
		[global::Cpp2ILInjected.Token(Token = "0x6000272")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A612AC", Offset = "0x1A612AC", Length = "0x4C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NotSupportedException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public override int Read(byte[] buffer, int offset, int count)
		{
			throw null;
		}

		// Token: 0x0600025F RID: 607 RVA: 0x00005596 File Offset: 0x00003796
		[global::Cpp2ILInjected.Token(Token = "0x6000273")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A612F8", Offset = "0x1A612F8", Length = "0x4C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NotSupportedException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public override long Seek(long offset, SeekOrigin origin)
		{
			throw null;
		}

		// Token: 0x06000260 RID: 608 RVA: 0x00005599 File Offset: 0x00003799
		[global::Cpp2ILInjected.Token(Token = "0x6000274")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A61344", Offset = "0x1A61344", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public override void SetLength(long value)
		{
			throw null;
		}

		// Token: 0x0400010E RID: 270
		[global::Cpp2ILInjected.Token(Token = "0x400011E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private EncryptionAlgorithm _encryption;

		// Token: 0x0400010F RID: 271
		[global::Cpp2ILInjected.Token(Token = "0x400011F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x2C")]
		private ZipEntryTimestamp _timestamp;

		// Token: 0x04000110 RID: 272
		[global::Cpp2ILInjected.Token(Token = "0x4000120")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		internal string _password;

		// Token: 0x04000111 RID: 273
		[global::Cpp2ILInjected.Token(Token = "0x4000121")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		private string _comment;

		// Token: 0x04000112 RID: 274
		[global::Cpp2ILInjected.Token(Token = "0x4000122")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
		private Stream _outputStream;

		// Token: 0x04000113 RID: 275
		[global::Cpp2ILInjected.Token(Token = "0x4000123")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
		private ZipEntry _currentEntry;

		// Token: 0x04000114 RID: 276
		[global::Cpp2ILInjected.Token(Token = "0x4000124")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
		internal Zip64Option _zip64;

		// Token: 0x04000115 RID: 277
		[global::Cpp2ILInjected.Token(Token = "0x4000125")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x58")]
		private Dictionary<string, ZipEntry> _entriesWritten;

		// Token: 0x04000116 RID: 278
		[global::Cpp2ILInjected.Token(Token = "0x4000126")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x60")]
		private int _entryCount;

		// Token: 0x04000117 RID: 279
		[global::Cpp2ILInjected.Token(Token = "0x4000127")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x64")]
		private ZipOption _alternateEncodingUsage;

		// Token: 0x04000118 RID: 280
		[global::Cpp2ILInjected.Token(Token = "0x4000128")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x68")]
		private Encoding _alternateEncoding;

		// Token: 0x04000119 RID: 281
		[global::Cpp2ILInjected.Token(Token = "0x4000129")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x70")]
		private bool _leaveUnderlyingStreamOpen;

		// Token: 0x0400011A RID: 282
		[global::Cpp2ILInjected.Token(Token = "0x400012A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x71")]
		private bool _disposed;

		// Token: 0x0400011B RID: 283
		[global::Cpp2ILInjected.Token(Token = "0x400012B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x72")]
		private bool _exceptionPending;

		// Token: 0x0400011C RID: 284
		[global::Cpp2ILInjected.Token(Token = "0x400012C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x73")]
		private bool _anyEntriesUsedZip64;

		// Token: 0x0400011D RID: 285
		[global::Cpp2ILInjected.Token(Token = "0x400012D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x74")]
		private bool _directoryNeededZip64;

		// Token: 0x0400011E RID: 286
		[global::Cpp2ILInjected.Token(Token = "0x400012E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x78")]
		private CountingStream _outputCounter;

		// Token: 0x0400011F RID: 287
		[global::Cpp2ILInjected.Token(Token = "0x400012F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x80")]
		private Stream _encryptor;

		// Token: 0x04000120 RID: 288
		[global::Cpp2ILInjected.Token(Token = "0x4000130")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x88")]
		private Stream _deflater;

		// Token: 0x04000121 RID: 289
		[global::Cpp2ILInjected.Token(Token = "0x4000131")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x90")]
		private CrcCalculatorStream _entryOutputStream;

		// Token: 0x04000122 RID: 290
		[global::Cpp2ILInjected.Token(Token = "0x4000132")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x98")]
		private bool _needToWriteEntryHeader;

		// Token: 0x04000123 RID: 291
		[global::Cpp2ILInjected.Token(Token = "0x4000133")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xA0")]
		private string _name;

		// Token: 0x04000124 RID: 292
		[global::Cpp2ILInjected.Token(Token = "0x4000134")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xA8")]
		private bool _DontIgnoreCase;

		// Token: 0x04000125 RID: 293
		[global::Cpp2ILInjected.Token(Token = "0x4000135")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xAC")]
		private int <CodecBufferSize>k__BackingField;

		// Token: 0x04000126 RID: 294
		[global::Cpp2ILInjected.Token(Token = "0x4000136")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xB0")]
		private CompressionStrategy <Strategy>k__BackingField;

		// Token: 0x04000127 RID: 295
		[global::Cpp2ILInjected.Token(Token = "0x4000137")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xB4")]
		private CompressionLevel <CompressionLevel>k__BackingField;

		// Token: 0x04000128 RID: 296
		[global::Cpp2ILInjected.Token(Token = "0x4000138")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xB8")]
		private CompressionMethod <CompressionMethod>k__BackingField;
	}
}
