using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Xml
{
	// Token: 0x02000035 RID: 53
	[global::Cpp2ILInjected.Token(Token = "0x2000038")]
	internal abstract class XmlRawWriter : XmlWriter
	{
		// Token: 0x060001D1 RID: 465 RVA: 0x000034C4 File Offset: 0x000016C4
		[global::Cpp2ILInjected.Token(Token = "0x60001DE")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D678C4", Offset = "0x1D678C4", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Res), Member = "GetString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public override void WriteStartDocument()
		{
			throw null;
		}

		// Token: 0x060001D2 RID: 466 RVA: 0x000034C7 File Offset: 0x000016C7
		[global::Cpp2ILInjected.Token(Token = "0x60001DF")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D6791C", Offset = "0x1D6791C", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Res), Member = "GetString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public override void WriteStartDocument(bool standalone)
		{
			throw null;
		}

		// Token: 0x060001D3 RID: 467 RVA: 0x000034CA File Offset: 0x000016CA
		[global::Cpp2ILInjected.Token(Token = "0x60001E0")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D67974", Offset = "0x1D67974", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Res), Member = "GetString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public override void WriteEndDocument()
		{
			throw null;
		}

		// Token: 0x060001D4 RID: 468 RVA: 0x000034CD File Offset: 0x000016CD
		[global::Cpp2ILInjected.Token(Token = "0x60001E1")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D679CC", Offset = "0x1D679CC", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public override void WriteDocType(string name, string pubid, string sysid, string subset)
		{
			throw null;
		}

		// Token: 0x060001D5 RID: 469 RVA: 0x000034D0 File Offset: 0x000016D0
		[global::Cpp2ILInjected.Token(Token = "0x60001E2")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D679D0", Offset = "0x1D679D0", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Res), Member = "GetString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public override void WriteEndElement()
		{
			throw null;
		}

		// Token: 0x060001D6 RID: 470 RVA: 0x000034D3 File Offset: 0x000016D3
		[global::Cpp2ILInjected.Token(Token = "0x60001E3")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D67A28", Offset = "0x1D67A28", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Res), Member = "GetString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public override void WriteFullEndElement()
		{
			throw null;
		}

		// Token: 0x060001D7 RID: 471 RVA: 0x000034D6 File Offset: 0x000016D6
		[global::Cpp2ILInjected.Token(Token = "0x60001E4")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D66944", Offset = "0x1D66944", Length = "0x84")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlUtf8RawTextWriterIndent), Member = "WriteBase64", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Base64Encoder), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Base64Encoder), Member = "Encode", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public override void WriteBase64(byte[] buffer, int index, int count)
		{
			throw null;
		}

		// Token: 0x060001D8 RID: 472 RVA: 0x000034D9 File Offset: 0x000016D9
		[global::Cpp2ILInjected.Token(Token = "0x60001E5")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D67A80", Offset = "0x1D67A80", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Res), Member = "GetString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public override string LookupPrefix(string ns)
		{
			throw null;
		}

		// Token: 0x17000046 RID: 70
		// (get) Token: 0x060001D9 RID: 473 RVA: 0x000034DC File Offset: 0x000016DC
		[global::Cpp2ILInjected.Token(Token = "0x1700004B")]
		public override WriteState WriteState
		{
			[global::Cpp2ILInjected.Token(Token = "0x60001E6")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D67AD8", Offset = "0x1D67AD8", Length = "0x58")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Res), Member = "GetString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
			get
			{
				throw null;
			}
		}

		// Token: 0x060001DA RID: 474 RVA: 0x000034DF File Offset: 0x000016DF
		[global::Cpp2ILInjected.Token(Token = "0x60001E7")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D67B30", Offset = "0x1D67B30", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public override void WriteCData(string text)
		{
			throw null;
		}

		// Token: 0x060001DB RID: 475 RVA: 0x000034E2 File Offset: 0x000016E2
		[global::Cpp2ILInjected.Token(Token = "0x60001E8")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D67B40", Offset = "0x1D67B40", Length = "0x80")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "CreateString", MemberParameters = new object[] { typeof(char[]) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public override void WriteCharEntity(char ch)
		{
			throw null;
		}

		// Token: 0x060001DC RID: 476 RVA: 0x000034E5 File Offset: 0x000016E5
		[global::Cpp2ILInjected.Token(Token = "0x60001E9")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D67BC0", Offset = "0x1D67BC0", Length = "0x88")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "CreateString", MemberParameters = new object[] { typeof(char[]) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public override void WriteSurrogateCharEntity(char lowChar, char highChar)
		{
			throw null;
		}

		// Token: 0x060001DD RID: 477 RVA: 0x000034E8 File Offset: 0x000016E8
		[global::Cpp2ILInjected.Token(Token = "0x60001EA")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D67C48", Offset = "0x1D67C48", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public override void WriteWhitespace(string ws)
		{
			throw null;
		}

		// Token: 0x060001DE RID: 478 RVA: 0x000034EB File Offset: 0x000016EB
		[global::Cpp2ILInjected.Token(Token = "0x60001EB")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D67C58", Offset = "0x1D67C58", Length = "0x30")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "CreateString", MemberParameters = new object[]
		{
			typeof(char[]),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public override void WriteChars(char[] buffer, int index, int count)
		{
			throw null;
		}

		// Token: 0x060001DF RID: 479 RVA: 0x000034EE File Offset: 0x000016EE
		[global::Cpp2ILInjected.Token(Token = "0x60001EC")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D67C88", Offset = "0x1D67C88", Length = "0x30")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "CreateString", MemberParameters = new object[]
		{
			typeof(char[]),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public override void WriteRaw(char[] buffer, int index, int count)
		{
			throw null;
		}

		// Token: 0x060001E0 RID: 480 RVA: 0x000034F1 File Offset: 0x000016F1
		[global::Cpp2ILInjected.Token(Token = "0x60001ED")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D67CB8", Offset = "0x1D67CB8", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public override void WriteRaw(string data)
		{
			throw null;
		}

		// Token: 0x060001E1 RID: 481 RVA: 0x000034F4 File Offset: 0x000016F4
		[global::Cpp2ILInjected.Token(Token = "0x60001EE")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D67CC8", Offset = "0x1D67CC8", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public override void WriteValue(string value)
		{
			throw null;
		}

		// Token: 0x17000047 RID: 71
		// (set) Token: 0x060001E2 RID: 482 RVA: 0x000034F7 File Offset: 0x000016F7
		[global::Cpp2ILInjected.Token(Token = "0x1700004C")]
		internal virtual IXmlNamespaceResolver NamespaceResolver
		{
			[global::Cpp2ILInjected.Token(Token = "0x60001EF")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D67CD8", Offset = "0x1D67CD8", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x060001E3 RID: 483 RVA: 0x000034FA File Offset: 0x000016FA
		[global::Cpp2ILInjected.Token(Token = "0x60001F0")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D67CE0", Offset = "0x1D67CE0", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		internal virtual void WriteXmlDeclaration(XmlStandalone standalone)
		{
			throw null;
		}

		// Token: 0x060001E4 RID: 484 RVA: 0x000034FD File Offset: 0x000016FD
		[global::Cpp2ILInjected.Token(Token = "0x60001F1")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D67CE4", Offset = "0x1D67CE4", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		internal virtual void WriteXmlDeclaration(string xmldecl)
		{
			throw null;
		}

		// Token: 0x060001E5 RID: 485
		[global::Cpp2ILInjected.Token(Token = "0x60001F2")]
		internal abstract void StartElementContent();

		// Token: 0x060001E6 RID: 486 RVA: 0x00003500 File Offset: 0x00001700
		[global::Cpp2ILInjected.Token(Token = "0x60001F3")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D67CE8", Offset = "0x1D67CE8", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		internal virtual void OnRootElement(ConformanceLevel conformanceLevel)
		{
			throw null;
		}

		// Token: 0x060001E7 RID: 487
		[global::Cpp2ILInjected.Token(Token = "0x60001F4")]
		internal abstract void WriteEndElement(string prefix, string localName, string ns);

		// Token: 0x060001E8 RID: 488 RVA: 0x00003503 File Offset: 0x00001703
		[global::Cpp2ILInjected.Token(Token = "0x60001F5")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D67CEC", Offset = "0x1D67CEC", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		internal virtual void WriteFullEndElement(string prefix, string localName, string ns)
		{
			throw null;
		}

		// Token: 0x060001E9 RID: 489
		[global::Cpp2ILInjected.Token(Token = "0x60001F6")]
		internal abstract void WriteNamespaceDeclaration(string prefix, string ns);

		// Token: 0x17000048 RID: 72
		// (get) Token: 0x060001EA RID: 490 RVA: 0x00003506 File Offset: 0x00001706
		[global::Cpp2ILInjected.Token(Token = "0x1700004D")]
		internal virtual bool SupportsNamespaceDeclarationInChunks
		{
			[global::Cpp2ILInjected.Token(Token = "0x60001F7")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D67CFC", Offset = "0x1D67CFC", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x060001EB RID: 491 RVA: 0x00003509 File Offset: 0x00001709
		[global::Cpp2ILInjected.Token(Token = "0x60001F8")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D67D04", Offset = "0x1D67D04", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		internal virtual void WriteStartNamespaceDeclaration(string prefix)
		{
			throw null;
		}

		// Token: 0x060001EC RID: 492 RVA: 0x0000350C File Offset: 0x0000170C
		[global::Cpp2ILInjected.Token(Token = "0x60001F9")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D67D3C", Offset = "0x1D67D3C", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		internal virtual void WriteEndNamespaceDeclaration()
		{
			throw null;
		}

		// Token: 0x060001ED RID: 493 RVA: 0x0000350F File Offset: 0x0000170F
		[global::Cpp2ILInjected.Token(Token = "0x60001FA")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D67D74", Offset = "0x1D67D74", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Base64Encoder), Member = "Flush", ReturnType = typeof(void))]
		internal virtual void WriteEndBase64()
		{
			throw null;
		}

		// Token: 0x060001EE RID: 494 RVA: 0x00003512 File Offset: 0x00001712
		[global::Cpp2ILInjected.Token(Token = "0x60001FB")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D67D7C", Offset = "0x1D67D7C", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		internal virtual void Close(WriteState currentState)
		{
			throw null;
		}

		// Token: 0x060001EF RID: 495 RVA: 0x00003515 File Offset: 0x00001715
		[global::Cpp2ILInjected.Token(Token = "0x60001FC")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D62354", Offset = "0x1D62354", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlUtf8RawTextWriter), Member = ".ctor", MemberParameters = new object[] { typeof(XmlWriterSettings) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlWriter), Member = ".ctor", ReturnType = typeof(void))]
		protected XmlRawWriter()
		{
			throw null;
		}

		// Token: 0x040000BD RID: 189
		[global::Cpp2ILInjected.Token(Token = "0x40000DD")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		protected XmlRawWriterBase64Encoder base64Encoder;

		// Token: 0x040000BE RID: 190
		[global::Cpp2ILInjected.Token(Token = "0x40000DE")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		protected IXmlNamespaceResolver resolver;
	}
}
