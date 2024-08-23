using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;
using System.Xml.XmlConfiguration;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Xml
{
	// Token: 0x0200003A RID: 58
	[global::Cpp2ILInjected.Token(Token = "0x200003D")]
	internal class XmlTextReaderImpl : XmlReader, IXmlNamespaceResolver
	{
		// Token: 0x06000241 RID: 577 RVA: 0x000035D8 File Offset: 0x000017D8
		[global::Cpp2ILInjected.Token(Token = "0x600024E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D6F528", Offset = "0x1D6F528", Length = "0x348")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(TextReader),
			typeof(XmlNameTable)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(XmlNodeType),
			typeof(XmlParserContext)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(XmlParserContext)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlCharType), Member = "get_Instance", ReturnType = typeof(XmlCharType))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tuple<, , , >), Member = ".ctor", MemberParameters = new object[] { "T1", "T2", "T3", "T4" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Task[]), Member = "FromResult", MemberTypeParameters = new object[] { typeof(object) }, MemberParameters = new object[] { typeof(object) }, ReturnType = "System.Threading.Tasks.Task`1<TResult>")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlReader), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlReaderSettings), Member = "EnableLegacyXmlSettings", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlUrlResolver), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlTextReaderImpl.NodeData), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlTextReaderImpl.XmlContext), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 24)]
		internal XmlTextReaderImpl(XmlNameTable nt)
		{
			throw null;
		}

		// Token: 0x06000242 RID: 578 RVA: 0x000035DB File Offset: 0x000017DB
		[global::Cpp2ILInjected.Token(Token = "0x600024F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D6F870", Offset = "0x1D6F870", Length = "0x68")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReader), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(TextReader),
			typeof(XmlNameTable)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		internal XmlTextReaderImpl(TextReader input, XmlNameTable nt)
		{
			throw null;
		}

		// Token: 0x06000243 RID: 579 RVA: 0x000035DE File Offset: 0x000017DE
		[global::Cpp2ILInjected.Token(Token = "0x6000250")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D6F8D8", Offset = "0x1D6F8D8", Length = "0xC8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlTextReaderImpl), Member = ".ctor", MemberParameters = new object[] { typeof(XmlNameTable) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlNamespaceManager), Member = ".ctor", MemberParameters = new object[] { typeof(XmlNameTable) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlTextReaderImpl), Member = "InitTextReaderInput", MemberParameters = new object[]
		{
			typeof(string),
			typeof(Uri),
			typeof(TextReader)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		internal XmlTextReaderImpl(string url, TextReader input, XmlNameTable nt)
		{
			throw null;
		}

		// Token: 0x06000244 RID: 580 RVA: 0x000035E1 File Offset: 0x000017E1
		[global::Cpp2ILInjected.Token(Token = "0x6000251")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D6F9AC", Offset = "0x1D6F9AC", Length = "0x104")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlLoader), Member = "ParseDocumentType", MemberParameters = new object[]
		{
			typeof(XmlDocumentType),
			typeof(bool),
			typeof(XmlResolver)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlLoader), Member = "CreateInnerXmlReader", MemberParameters = new object[]
		{
			typeof(string),
			typeof(XmlNodeType),
			typeof(XmlParserContext),
			typeof(XmlDocument)
		}, ReturnType = typeof(XmlReader))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NameTable), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlTextReaderImpl), Member = ".ctor", MemberParameters = new object[] { typeof(XmlNameTable) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Encoding), Member = "get_Unicode", ReturnType = typeof(Encoding))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlTextReaderImpl), Member = "InitStringInput", MemberParameters = new object[]
		{
			typeof(string),
			typeof(Encoding),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlTextReaderImpl), Member = "InitFragmentReader", MemberParameters = new object[]
		{
			typeof(XmlNodeType),
			typeof(XmlParserContext),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		internal XmlTextReaderImpl(string xmlFragment, XmlNodeType fragType, XmlParserContext context)
		{
			throw null;
		}

		// Token: 0x06000245 RID: 581 RVA: 0x000035E4 File Offset: 0x000017E4
		[global::Cpp2ILInjected.Token(Token = "0x6000252")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D6FD40", Offset = "0x1D6FD40", Length = "0x144")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlLoader), Member = "ParseXmlDeclarationValue", MemberParameters = new object[]
		{
			typeof(string),
			typeof(ref string),
			typeof(ref string),
			typeof(ref string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NameTable), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlTextReaderImpl), Member = ".ctor", MemberParameters = new object[] { typeof(XmlNameTable) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Encoding), Member = "get_Unicode", ReturnType = typeof(Encoding))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlTextReaderImpl), Member = "InitStringInput", MemberParameters = new object[]
		{
			typeof(string),
			typeof(Encoding),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlTextReaderImpl), Member = "InitFragmentReader", MemberParameters = new object[]
		{
			typeof(XmlNodeType),
			typeof(XmlParserContext),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		internal XmlTextReaderImpl(string xmlFragment, XmlParserContext context)
		{
			throw null;
		}

		// Token: 0x06000246 RID: 582 RVA: 0x000035E7 File Offset: 0x000017E7
		[global::Cpp2ILInjected.Token(Token = "0x6000253")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D6FE84", Offset = "0x1D6FE84", Length = "0x2B0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl), Member = "FinishInit", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(RuntimeTypeHandle) }, ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Task), Member = "Wait", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Task<object>), Member = "get_Result", ReturnType = "TResult")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlTextReaderImpl), Member = "InitStreamInput", MemberParameters = new object[]
		{
			typeof(Uri),
			typeof(string),
			typeof(Stream),
			typeof(byte[]),
			typeof(int),
			typeof(Encoding)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlParserContext), Member = "get_HasDtdInfo", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlTextReaderImpl), Member = "ProcessDtdFromParserContext", MemberParameters = new object[] { typeof(XmlParserContext) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 22)]
		private void FinishInitUriString()
		{
			throw null;
		}

		// Token: 0x06000247 RID: 583 RVA: 0x000035EA File Offset: 0x000017EA
		[global::Cpp2ILInjected.Token(Token = "0x6000254")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D703E8", Offset = "0x1D703E8", Length = "0x6C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl), Member = "FinishInit", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlTextReaderImpl), Member = "InitStreamInput", MemberParameters = new object[]
		{
			typeof(Uri),
			typeof(string),
			typeof(Stream),
			typeof(byte[]),
			typeof(int),
			typeof(Encoding)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlParserContext), Member = "get_HasDtdInfo", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlTextReaderImpl), Member = "ProcessDtdFromParserContext", MemberParameters = new object[] { typeof(XmlParserContext) }, ReturnType = typeof(void))]
		private void FinishInitStream()
		{
			throw null;
		}

		// Token: 0x06000248 RID: 584 RVA: 0x000035ED File Offset: 0x000017ED
		[global::Cpp2ILInjected.Token(Token = "0x6000255")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D70454", Offset = "0x1D70454", Length = "0x50")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl), Member = "FinishInit", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlTextReaderImpl), Member = "InitTextReaderInput", MemberParameters = new object[]
		{
			typeof(string),
			typeof(Uri),
			typeof(TextReader)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlParserContext), Member = "get_HasDtdInfo", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlTextReaderImpl), Member = "ProcessDtdFromParserContext", MemberParameters = new object[] { typeof(XmlParserContext) }, ReturnType = typeof(void))]
		private void FinishInitTextReader()
		{
			throw null;
		}

		// Token: 0x17000079 RID: 121
		// (get) Token: 0x06000249 RID: 585 RVA: 0x000035F0 File Offset: 0x000017F0
		[global::Cpp2ILInjected.Token(Token = "0x1700007E")]
		public override XmlReaderSettings Settings
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000256")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D704A4", Offset = "0x1D704A4", Length = "0x150")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlReaderSettings), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlReaderSettings), Member = "set_NameTable", MemberParameters = new object[] { typeof(XmlNameTable) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlReaderSettings), Member = "set_ConformanceLevel", MemberParameters = new object[] { typeof(ConformanceLevel) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlReaderSettings), Member = "set_CheckCharacters", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlReaderSettings), Member = "set_LineNumberOffset", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlReaderSettings), Member = "set_LinePositionOffset", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlReaderSettings), Member = "set_IgnoreWhitespace", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlReaderSettings), Member = "set_IgnoreProcessingInstructions", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlReaderSettings), Member = "set_IgnoreComments", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlReaderSettings), Member = "set_DtdProcessing", MemberParameters = new object[] { typeof(DtdProcessing) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlReaderSettings), Member = "set_MaxCharactersInDocument", MemberParameters = new object[] { typeof(long) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlReaderSettings), Member = "set_MaxCharactersFromEntities", MemberParameters = new object[] { typeof(long) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlReaderSettings), Member = "EnableLegacyXmlSettings", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlReaderSettings), Member = "set_XmlResolver", MemberParameters = new object[] { typeof(XmlResolver) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700007A RID: 122
		// (get) Token: 0x0600024A RID: 586 RVA: 0x000035F3 File Offset: 0x000017F3
		[global::Cpp2ILInjected.Token(Token = "0x1700007F")]
		public override XmlNodeType NodeType
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000257")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D705F4", Offset = "0x1D705F4", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700007B RID: 123
		// (get) Token: 0x0600024B RID: 587 RVA: 0x000035F6 File Offset: 0x000017F6
		[global::Cpp2ILInjected.Token(Token = "0x17000080")]
		public override string Name
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000258")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D70600", Offset = "0x1D70600", Length = "0x14")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlTextReaderImpl.NodeData), Member = "GetNameWPrefix", MemberParameters = new object[] { typeof(XmlNameTable) }, ReturnType = typeof(string))]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700007C RID: 124
		// (get) Token: 0x0600024C RID: 588 RVA: 0x000035F9 File Offset: 0x000017F9
		[global::Cpp2ILInjected.Token(Token = "0x17000081")]
		public override string LocalName
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000259")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D70614", Offset = "0x1D70614", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700007D RID: 125
		// (get) Token: 0x0600024D RID: 589 RVA: 0x000035FC File Offset: 0x000017FC
		[global::Cpp2ILInjected.Token(Token = "0x17000082")]
		public override string NamespaceURI
		{
			[global::Cpp2ILInjected.Token(Token = "0x600025A")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D70620", Offset = "0x1D70620", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700007E RID: 126
		// (get) Token: 0x0600024E RID: 590 RVA: 0x000035FF File Offset: 0x000017FF
		[global::Cpp2ILInjected.Token(Token = "0x17000083")]
		public override string Prefix
		{
			[global::Cpp2ILInjected.Token(Token = "0x600025B")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D7062C", Offset = "0x1D7062C", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700007F RID: 127
		// (get) Token: 0x0600024F RID: 591 RVA: 0x00003602 File Offset: 0x00001802
		[global::Cpp2ILInjected.Token(Token = "0x17000084")]
		public override string Value
		{
			[global::Cpp2ILInjected.Token(Token = "0x600025C")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D70638", Offset = "0x1D70638", Length = "0x40")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlTextReaderImpl), Member = "FinishPartialValue", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlTextReaderImpl), Member = "FinishOtherValueIterator", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlTextReaderImpl.NodeData), Member = "get_StringValue", ReturnType = typeof(string))]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000080 RID: 128
		// (get) Token: 0x06000250 RID: 592 RVA: 0x00003605 File Offset: 0x00001805
		[global::Cpp2ILInjected.Token(Token = "0x17000085")]
		public override string BaseURI
		{
			[global::Cpp2ILInjected.Token(Token = "0x600025D")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D70814", Offset = "0x1D70814", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000081 RID: 129
		// (get) Token: 0x06000251 RID: 593 RVA: 0x00003608 File Offset: 0x00001808
		[global::Cpp2ILInjected.Token(Token = "0x17000086")]
		public override bool IsEmptyElement
		{
			[global::Cpp2ILInjected.Token(Token = "0x600025E")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D7081C", Offset = "0x1D7081C", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlTextReaderImpl.NodeData), Member = "get_IsEmptyElement", ReturnType = typeof(bool))]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000082 RID: 130
		// (get) Token: 0x06000252 RID: 594 RVA: 0x0000360B File Offset: 0x0000180B
		[global::Cpp2ILInjected.Token(Token = "0x17000087")]
		public override bool IsDefault
		{
			[global::Cpp2ILInjected.Token(Token = "0x600025F")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D70828", Offset = "0x1D70828", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlTextReaderImpl.NodeData), Member = "get_IsDefaultAttribute", ReturnType = typeof(bool))]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000083 RID: 131
		// (get) Token: 0x06000253 RID: 595 RVA: 0x0000360E File Offset: 0x0000180E
		[global::Cpp2ILInjected.Token(Token = "0x17000088")]
		public override ReadState ReadState
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000260")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D70834", Offset = "0x1D70834", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000084 RID: 132
		// (get) Token: 0x06000254 RID: 596 RVA: 0x00003611 File Offset: 0x00001811
		[global::Cpp2ILInjected.Token(Token = "0x17000089")]
		public override XmlNameTable NameTable
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000261")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D7083C", Offset = "0x1D7083C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000085 RID: 133
		// (get) Token: 0x06000255 RID: 597 RVA: 0x00003614 File Offset: 0x00001814
		[global::Cpp2ILInjected.Token(Token = "0x1700008A")]
		public override bool CanResolveEntity
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000262")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D70844", Offset = "0x1D70844", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06000256 RID: 598 RVA: 0x00003617 File Offset: 0x00001817
		[global::Cpp2ILInjected.Token(Token = "0x6000263")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D7084C", Offset = "0x1D7084C", Length = "0xA4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "IndexOf", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlTextReaderImpl), Member = "GetIndexOfAttributeWithPrefix", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlTextReaderImpl), Member = "GetIndexOfAttributeWithoutPrefix", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlTextReaderImpl), Member = "FinishAttributeValueIterator", ReturnType = typeof(void))]
		public override bool MoveToAttribute(string name)
		{
			throw null;
		}

		// Token: 0x06000257 RID: 599 RVA: 0x0000361A File Offset: 0x0000181A
		[global::Cpp2ILInjected.Token(Token = "0x6000264")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D70AFC", Offset = "0x1D70AFC", Length = "0x5C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlTextReaderImpl), Member = "FinishAttributeValueIterator", ReturnType = typeof(void))]
		public override bool MoveToFirstAttribute()
		{
			throw null;
		}

		// Token: 0x06000258 RID: 600 RVA: 0x0000361D File Offset: 0x0000181D
		[global::Cpp2ILInjected.Token(Token = "0x6000265")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D70B58", Offset = "0x1D70B58", Length = "0x70")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlTextReaderImpl), Member = "FinishAttributeValueIterator", ReturnType = typeof(void))]
		public override bool MoveToNextAttribute()
		{
			throw null;
		}

		// Token: 0x06000259 RID: 601 RVA: 0x00003620 File Offset: 0x00001820
		[global::Cpp2ILInjected.Token(Token = "0x6000266")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D70BC8", Offset = "0x1D70BC8", Length = "0x6C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlTextReaderImpl), Member = "FinishAttributeValueIterator", ReturnType = typeof(void))]
		public override bool MoveToElement()
		{
			throw null;
		}

		// Token: 0x0600025A RID: 602 RVA: 0x00003623 File Offset: 0x00001823
		[global::Cpp2ILInjected.Token(Token = "0x6000267")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D70C34", Offset = "0x1D70C34", Length = "0x2C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl), Member = "Read", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlTextReaderImpl), Member = "FinishInitUriString", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlTextReaderImpl), Member = "FinishInitTextReader", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlTextReaderImpl), Member = "FinishInitStream", ReturnType = typeof(void))]
		private void FinishInit()
		{
			throw null;
		}

		// Token: 0x0600025B RID: 603 RVA: 0x00003626 File Offset: 0x00001826
		[global::Cpp2ILInjected.Token(Token = "0x6000268")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D70C60", Offset = "0x1D70C60", Length = "0x384")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlTextReaderImpl), Member = "FinishInit", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlTextReaderImpl), Member = "OpenUrl", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlTextReaderImpl), Member = "ParseXmlDeclaration", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlTextReaderImpl), Member = "ResetAttributes", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlTextReaderImpl), Member = "FinishReadElementContentAsBinary", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlTextReaderImpl), Member = "FinishAttributeValueIterator", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlTextReaderImpl), Member = "SkipPartialTextValue", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlTextReaderImpl), Member = "FinishReadContentAsBinary", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlTextReaderImpl), Member = "AllocNode", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(XmlTextReaderImpl.NodeData))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlTextReaderImpl), Member = "ParseXmlDeclarationFragment", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlTextReaderImpl), Member = "FinishIncrementalRead", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlTextReaderImpl), Member = "SetupEndEntityNodeInContent", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlTextReaderImpl), Member = "ParseDocumentContent", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlTextReaderImpl), Member = "ParseEntityReference", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlTextReaderImpl), Member = "ParseFragmentAttribute", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlTextReaderImpl), Member = "OnEof", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlTextReaderImpl.NodeData), Member = "SetValueNode", MemberParameters = new object[]
		{
			typeof(XmlNodeType),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlTextReaderImpl.ParsingState), Member = "get_LinePos", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlTextReaderImpl.NodeData), Member = "SetLineInfo", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlTextReaderImpl), Member = "ThrowWithoutLineInfo", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public override bool Read()
		{
			throw null;
		}

		// Token: 0x0600025C RID: 604 RVA: 0x00003629 File Offset: 0x00001829
		[global::Cpp2ILInjected.Token(Token = "0x6000269")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D72B00", Offset = "0x1D72B00", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public override void Close()
		{
			throw null;
		}

		// Token: 0x0600025D RID: 605 RVA: 0x0000362C File Offset: 0x0000182C
		[global::Cpp2ILInjected.Token(Token = "0x600026A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D72C00", Offset = "0x1D72C00", Length = "0x24")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public override string LookupNamespace(string prefix)
		{
			throw null;
		}

		// Token: 0x0600025E RID: 606 RVA: 0x0000362F File Offset: 0x0000182F
		[global::Cpp2ILInjected.Token(Token = "0x600026B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D72C24", Offset = "0x1D72C24", Length = "0x234")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlTextReaderImpl), Member = "SkipPartialTextValue", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlTextReaderImpl), Member = "ParseAttributeValueChunk", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlTextReaderImpl), Member = "FinishReadContentAsBinary", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlTextReaderImpl), Member = "AllocNode", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(XmlTextReaderImpl.NodeData))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlTextReaderImpl.NodeData), Member = "get_StringValue", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlTextReaderImpl.NodeData), Member = "SetValueNode", MemberParameters = new object[]
		{
			typeof(XmlNodeType),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public override bool ReadAttributeValue()
		{
			throw null;
		}

		// Token: 0x0600025F RID: 607 RVA: 0x00003632 File Offset: 0x00001832
		[global::Cpp2ILInjected.Token(Token = "0x600026C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D73280", Offset = "0x1D73280", Length = "0x23C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlTextReaderImpl.NodeData), Member = "get_LinePos", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlTextReaderImpl), Member = "HandleGeneralEntityReference", MemberParameters = new object[]
		{
			typeof(string),
			typeof(bool),
			typeof(bool),
			typeof(int)
		}, ReturnType = typeof(XmlTextReaderImpl.EntityType))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Res), Member = "GetString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 11)]
		public override void ResolveEntity()
		{
			throw null;
		}

		// Token: 0x17000086 RID: 134
		// (set) Token: 0x06000260 RID: 608 RVA: 0x00003635 File Offset: 0x00001835
		[global::Cpp2ILInjected.Token(Token = "0x1700008B")]
		internal XmlReader OuterReader
		{
			[global::Cpp2ILInjected.Token(Token = "0x600026D")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D73930", Offset = "0x1D73930", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x06000261 RID: 609 RVA: 0x00003638 File Offset: 0x00001838
		[global::Cpp2ILInjected.Token(Token = "0x600026E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D73938", Offset = "0x1D73938", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		private string System.Xml.IXmlNamespaceResolver.LookupNamespace(string prefix)
		{
			throw null;
		}

		// Token: 0x06000262 RID: 610 RVA: 0x0000363B File Offset: 0x0000183B
		[global::Cpp2ILInjected.Token(Token = "0x600026F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D73948", Offset = "0x1D73948", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		private string System.Xml.IXmlNamespaceResolver.LookupPrefix(string namespaceName)
		{
			throw null;
		}

		// Token: 0x06000263 RID: 611 RVA: 0x0000363E File Offset: 0x0000183E
		[global::Cpp2ILInjected.Token(Token = "0x6000270")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D7395C", Offset = "0x1D7395C", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReader), Member = "System.Xml.IXmlNamespaceResolver.LookupPrefix", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		internal string LookupPrefix(string namespaceName)
		{
			throw null;
		}

		// Token: 0x17000087 RID: 135
		// (set) Token: 0x06000264 RID: 612 RVA: 0x00003641 File Offset: 0x00001841
		[global::Cpp2ILInjected.Token(Token = "0x1700008C")]
		internal bool Namespaces
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000271")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D73970", Offset = "0x1D73970", Length = "0x1A8")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlLoader), Member = "ParseDocumentType", MemberParameters = new object[]
			{
				typeof(XmlDocumentType),
				typeof(bool),
				typeof(XmlResolver)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlLoader), Member = "CreateInnerXmlReader", MemberParameters = new object[]
			{
				typeof(string),
				typeof(XmlNodeType),
				typeof(XmlParserContext),
				typeof(XmlDocument)
			}, ReturnType = typeof(XmlReader))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlNamespaceManager), Member = ".ctor", MemberParameters = new object[] { typeof(XmlNameTable) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlTextReaderImpl.NoNamespaceManager), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Res), Member = "GetString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
			set
			{
				throw null;
			}
		}

		// Token: 0x17000088 RID: 136
		// (set) Token: 0x06000265 RID: 613 RVA: 0x00003644 File Offset: 0x00001844
		[global::Cpp2ILInjected.Token(Token = "0x1700008D")]
		internal EntityHandling EntityHandling
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000272")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D73B18", Offset = "0x1D73B18", Length = "0x84")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReader), Member = "set_EntityHandling", MemberParameters = new object[] { typeof(EntityHandling) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlDocument), Member = "SetupReader", MemberParameters = new object[] { typeof(XmlTextReader) }, ReturnType = typeof(XmlTextReader))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlException), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(string),
				typeof(string)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
			set
			{
				throw null;
			}
		}

		// Token: 0x17000089 RID: 137
		// (set) Token: 0x06000266 RID: 614 RVA: 0x00003647 File Offset: 0x00001847
		[global::Cpp2ILInjected.Token(Token = "0x1700008E")]
		internal XmlResolver XmlResolver
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000273")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D73B9C", Offset = "0x1D73B9C", Length = "0x3C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReader), Member = "set_XmlResolver", MemberParameters = new object[] { typeof(XmlResolver) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlDocument), Member = "SetupReader", MemberParameters = new object[] { typeof(XmlTextReader) }, ReturnType = typeof(XmlTextReader))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlLoader), Member = "ParseDocumentType", MemberParameters = new object[]
			{
				typeof(XmlDocumentType),
				typeof(bool),
				typeof(XmlResolver)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlLoader), Member = "CreateInnerXmlReader", MemberParameters = new object[]
			{
				typeof(string),
				typeof(XmlNodeType),
				typeof(XmlParserContext),
				typeof(XmlDocument)
			}, ReturnType = typeof(XmlReader))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
			set
			{
				throw null;
			}
		}

		// Token: 0x1700008A RID: 138
		// (get) Token: 0x06000267 RID: 615 RVA: 0x0000364A File Offset: 0x0000184A
		[global::Cpp2ILInjected.Token(Token = "0x1700008F")]
		internal XmlNameTable DtdParserProxy_NameTable
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000274")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D73BD8", Offset = "0x1D73BD8", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700008B RID: 139
		// (get) Token: 0x06000268 RID: 616 RVA: 0x0000364D File Offset: 0x0000184D
		[global::Cpp2ILInjected.Token(Token = "0x17000090")]
		internal IXmlNamespaceResolver DtdParserProxy_NamespaceResolver
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000275")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D73BE0", Offset = "0x1D73BE0", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700008C RID: 140
		// (get) Token: 0x06000269 RID: 617 RVA: 0x00003650 File Offset: 0x00001850
		[global::Cpp2ILInjected.Token(Token = "0x17000091")]
		internal bool DtdParserProxy_DtdValidation
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000276")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D73BE8", Offset = "0x1D73BE8", Length = "0x10")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl.DtdParserProxy), Member = "System.Xml.IDtdParserAdapterWithValidation.get_DtdValidation", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700008D RID: 141
		// (get) Token: 0x0600026A RID: 618 RVA: 0x00003653 File Offset: 0x00001853
		[global::Cpp2ILInjected.Token(Token = "0x17000092")]
		internal bool DtdParserProxy_Normalization
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000277")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D73C08", Offset = "0x1D73C08", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700008E RID: 142
		// (get) Token: 0x0600026B RID: 619 RVA: 0x00003656 File Offset: 0x00001856
		[global::Cpp2ILInjected.Token(Token = "0x17000093")]
		internal bool DtdParserProxy_Namespaces
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000278")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D73C10", Offset = "0x1D73C10", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700008F RID: 143
		// (get) Token: 0x0600026C RID: 620 RVA: 0x00003659 File Offset: 0x00001859
		[global::Cpp2ILInjected.Token(Token = "0x17000094")]
		internal bool DtdParserProxy_V1CompatibilityMode
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000279")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D73C18", Offset = "0x1D73C18", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000090 RID: 144
		// (get) Token: 0x0600026D RID: 621 RVA: 0x0000365C File Offset: 0x0000185C
		[global::Cpp2ILInjected.Token(Token = "0x17000095")]
		internal Uri DtdParserProxy_BaseUri
		{
			[global::Cpp2ILInjected.Token(Token = "0x600027A")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D73C20", Offset = "0x1D73C20", Length = "0x9C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl.DtdParserProxy), Member = "System.Xml.IDtdParserAdapter.get_BaseUri", ReturnType = typeof(Uri))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Uri), Member = "op_Equality", MemberParameters = new object[]
			{
				typeof(Uri),
				typeof(Uri)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000091 RID: 145
		// (get) Token: 0x0600026E RID: 622 RVA: 0x0000365F File Offset: 0x0000185F
		[global::Cpp2ILInjected.Token(Token = "0x17000096")]
		internal bool DtdParserProxy_IsEof
		{
			[global::Cpp2ILInjected.Token(Token = "0x600027B")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D73CBC", Offset = "0x1D73CBC", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl.DtdParserProxy), Member = "System.Xml.IDtdParserAdapter.get_IsEof", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000092 RID: 146
		// (get) Token: 0x0600026F RID: 623 RVA: 0x00003662 File Offset: 0x00001862
		[global::Cpp2ILInjected.Token(Token = "0x17000097")]
		internal char[] DtdParserProxy_ParsingBuffer
		{
			[global::Cpp2ILInjected.Token(Token = "0x600027C")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D73CC4", Offset = "0x1D73CC4", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl.DtdParserProxy), Member = "System.Xml.IDtdParserAdapter.get_ParsingBuffer", ReturnType = typeof(char[]))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000093 RID: 147
		// (get) Token: 0x06000270 RID: 624 RVA: 0x00003665 File Offset: 0x00001865
		[global::Cpp2ILInjected.Token(Token = "0x17000098")]
		internal int DtdParserProxy_ParsingBufferLength
		{
			[global::Cpp2ILInjected.Token(Token = "0x600027D")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D73CCC", Offset = "0x1D73CCC", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl.DtdParserProxy), Member = "System.Xml.IDtdParserAdapter.get_ParsingBufferLength", ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000094 RID: 148
		// (get) Token: 0x06000271 RID: 625 RVA: 0x00003668 File Offset: 0x00001868
		// (set) Token: 0x06000272 RID: 626 RVA: 0x0000366B File Offset: 0x0000186B
		[global::Cpp2ILInjected.Token(Token = "0x17000099")]
		internal int DtdParserProxy_CurrentPosition
		{
			[global::Cpp2ILInjected.Token(Token = "0x600027E")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D73CD4", Offset = "0x1D73CD4", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl.DtdParserProxy), Member = "System.Xml.IDtdParserAdapter.get_CurrentPosition", ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x600027F")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D73CDC", Offset = "0x1D73CDC", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl.DtdParserProxy), Member = "System.Xml.IDtdParserAdapter.set_CurrentPosition", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			set
			{
				throw null;
			}
		}

		// Token: 0x17000095 RID: 149
		// (get) Token: 0x06000273 RID: 627 RVA: 0x0000366E File Offset: 0x0000186E
		[global::Cpp2ILInjected.Token(Token = "0x1700009A")]
		internal int DtdParserProxy_EntityStackLength
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000280")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D73CE4", Offset = "0x1D73CE4", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl.DtdParserProxy), Member = "System.Xml.IDtdParserAdapter.get_EntityStackLength", ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000096 RID: 150
		// (get) Token: 0x06000274 RID: 628 RVA: 0x00003671 File Offset: 0x00001871
		[global::Cpp2ILInjected.Token(Token = "0x1700009B")]
		internal bool DtdParserProxy_IsEntityEolNormalized
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000281")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D73CF0", Offset = "0x1D73CF0", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl.DtdParserProxy), Member = "System.Xml.IDtdParserAdapter.get_IsEntityEolNormalized", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000097 RID: 151
		// (get) Token: 0x06000275 RID: 629 RVA: 0x00003674 File Offset: 0x00001874
		[global::Cpp2ILInjected.Token(Token = "0x1700009C")]
		internal IValidationEventHandling DtdParserProxy_ValidationEventHandling
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000282")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D73CF8", Offset = "0x1D73CF8", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06000276 RID: 630 RVA: 0x00003677 File Offset: 0x00001877
		[global::Cpp2ILInjected.Token(Token = "0x6000283")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D73D00", Offset = "0x1D73D00", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl.DtdParserProxy), Member = "System.Xml.IDtdParserAdapter.OnNewLine", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		internal void DtdParserProxy_OnNewLine(int pos)
		{
			throw null;
		}

		// Token: 0x17000098 RID: 152
		// (get) Token: 0x06000277 RID: 631 RVA: 0x0000367A File Offset: 0x0000187A
		[global::Cpp2ILInjected.Token(Token = "0x1700009D")]
		internal int DtdParserProxy_LineNo
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000284")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D73D28", Offset = "0x1D73D28", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl.DtdParserProxy), Member = "System.Xml.IDtdParserAdapter.get_LineNo", ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000099 RID: 153
		// (get) Token: 0x06000278 RID: 632 RVA: 0x0000367D File Offset: 0x0000187D
		[global::Cpp2ILInjected.Token(Token = "0x1700009E")]
		internal int DtdParserProxy_LineStartPosition
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000285")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D73D30", Offset = "0x1D73D30", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl.DtdParserProxy), Member = "System.Xml.IDtdParserAdapter.get_LineStartPosition", ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06000279 RID: 633 RVA: 0x00003680 File Offset: 0x00001880
		[global::Cpp2ILInjected.Token(Token = "0x6000286")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D73D38", Offset = "0x1D73D38", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallAnalysisNotSupported]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl.DtdParserProxy), Member = "System.Xml.IDtdParserAdapter.ReadData", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		internal int DtdParserProxy_ReadData()
		{
			throw null;
		}

		// Token: 0x0600027A RID: 634 RVA: 0x00003683 File Offset: 0x00001883
		[global::Cpp2ILInjected.Token(Token = "0x6000287")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D74104", Offset = "0x1D74104", Length = "0x20")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl.DtdParserProxy), Member = "System.Xml.IDtdParserAdapter.ParseNumericCharRef", MemberParameters = new object[] { typeof(StringBuilder) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlTextReaderImpl), Member = "ParseNumericCharRef", MemberParameters = new object[]
		{
			typeof(bool),
			typeof(StringBuilder),
			typeof(ref XmlTextReaderImpl.EntityType)
		}, ReturnType = typeof(int))]
		internal int DtdParserProxy_ParseNumericCharRef(StringBuilder internalSubsetBuilder)
		{
			throw null;
		}

		// Token: 0x0600027B RID: 635 RVA: 0x00003686 File Offset: 0x00001886
		[global::Cpp2ILInjected.Token(Token = "0x6000288")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D741D0", Offset = "0x1D741D0", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl.DtdParserProxy), Member = "System.Xml.IDtdParserAdapter.ParseNamedCharRef", MemberParameters = new object[]
		{
			typeof(bool),
			typeof(StringBuilder)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		internal int DtdParserProxy_ParseNamedCharRef(bool expand, StringBuilder internalSubsetBuilder)
		{
			throw null;
		}

		// Token: 0x0600027C RID: 636 RVA: 0x00003689 File Offset: 0x00001889
		[global::Cpp2ILInjected.Token(Token = "0x6000289")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D7423C", Offset = "0x1D7423C", Length = "0x44")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl.DtdParserProxy), Member = "System.Xml.IDtdParserAdapter.ParsePI", MemberParameters = new object[] { typeof(StringBuilder) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlTextReaderImpl), Member = "ParsePI", MemberParameters = new object[] { typeof(StringBuilder) }, ReturnType = typeof(bool))]
		internal void DtdParserProxy_ParsePI(StringBuilder sb)
		{
			throw null;
		}

		// Token: 0x0600027D RID: 637 RVA: 0x0000368C File Offset: 0x0000188C
		[global::Cpp2ILInjected.Token(Token = "0x600028A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D74594", Offset = "0x1D74594", Length = "0x188")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl.DtdParserProxy), Member = "System.Xml.IDtdParserAdapter.ParseComment", MemberParameters = new object[] { typeof(StringBuilder) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlTextReaderImpl), Member = "ParseCDataOrComment", MemberParameters = new object[] { typeof(XmlNodeType) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlTextReaderImpl), Member = "AllocNode", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(XmlTextReaderImpl.NodeData))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlTextReaderImpl.NodeData), Member = "CopyTo", MemberParameters = new object[]
		{
			typeof(int),
			typeof(StringBuilder)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlTextReaderImpl.ParsingState), Member = "get_LinePos", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlTextReaderImpl), Member = "SendValidationEvent", MemberParameters = new object[]
		{
			typeof(XmlSeverityType),
			typeof(string),
			typeof(string),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 12)]
		internal void DtdParserProxy_ParseComment(StringBuilder sb)
		{
			throw null;
		}

		// Token: 0x1700009A RID: 154
		// (get) Token: 0x0600027E RID: 638 RVA: 0x0000368F File Offset: 0x0000188F
		[global::Cpp2ILInjected.Token(Token = "0x1700009F")]
		private bool IsResolverNull
		{
			[global::Cpp2ILInjected.Token(Token = "0x600028B")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D748EC", Offset = "0x1D748EC", Length = "0x40")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlReaderSection), Member = "get_ProhibitDefaultUrlResolver", ReturnType = typeof(bool))]
			get
			{
				throw null;
			}
		}

		// Token: 0x0600027F RID: 639 RVA: 0x00003692 File Offset: 0x00001892
		[global::Cpp2ILInjected.Token(Token = "0x600028C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D7492C", Offset = "0x1D7492C", Length = "0x60")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl), Member = "OpenUrl", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl), Member = "OpenUrlDelegate", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlUrlResolver), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private XmlResolver GetTempResolver()
		{
			throw null;
		}

		// Token: 0x06000280 RID: 640 RVA: 0x00003695 File Offset: 0x00001895
		[global::Cpp2ILInjected.Token(Token = "0x600028D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D7498C", Offset = "0x1D7498C", Length = "0x104")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl.DtdParserProxy), Member = "System.Xml.IDtdParserAdapter.PushEntity", MemberParameters = new object[]
		{
			typeof(IDtdEntityInfo),
			typeof(ref int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlReaderSection), Member = "get_ProhibitDefaultUrlResolver", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlTextReaderImpl), Member = "PushExternalEntity", MemberParameters = new object[] { typeof(IDtdEntityInfo) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlTextReaderImpl), Member = "PushInternalEntity", MemberParameters = new object[] { typeof(IDtdEntityInfo) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		internal bool DtdParserProxy_PushEntity(IDtdEntityInfo entity, out int entityId)
		{
			throw null;
		}

		// Token: 0x06000281 RID: 641 RVA: 0x00003698 File Offset: 0x00001898
		[global::Cpp2ILInjected.Token(Token = "0x600028E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D75120", Offset = "0x1D75120", Length = "0x4C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl.DtdParserProxy), Member = "System.Xml.IDtdParserAdapter.PopEntity", MemberParameters = new object[]
		{
			typeof(ref IDtdEntityInfo),
			typeof(ref int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlTextReaderImpl), Member = "PopEntity", ReturnType = typeof(void))]
		internal bool DtdParserProxy_PopEntity(out IDtdEntityInfo oldEntity, out int newEntityId)
		{
			throw null;
		}

		// Token: 0x06000282 RID: 642 RVA: 0x0000369B File Offset: 0x0000189B
		[global::Cpp2ILInjected.Token(Token = "0x600028F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D751EC", Offset = "0x1D751EC", Length = "0x120")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl.DtdParserProxy), Member = "System.Xml.IDtdParserAdapter.PushExternalSubset", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlReaderSection), Member = "get_ProhibitDefaultUrlResolver", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Uri), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(Uri),
			typeof(Uri)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlTextReaderImpl), Member = "PushExternalEntityOrSubset", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(Uri),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlTextReaderImpl), Member = "EatWhitespaces", MemberParameters = new object[] { typeof(StringBuilder) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlTextReaderImpl), Member = "ParseXmlDeclaration", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		internal bool DtdParserProxy_PushExternalSubset(string systemId, string publicId)
		{
			throw null;
		}

		// Token: 0x06000283 RID: 643 RVA: 0x0000369E File Offset: 0x0000189E
		[global::Cpp2ILInjected.Token(Token = "0x6000290")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D75844", Offset = "0x1D75844", Length = "0x5C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl.DtdParserProxy), Member = "System.Xml.IDtdParserAdapter.PushInternalDtd", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlTextReaderImpl), Member = "PushParsingState", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlTextReaderImpl), Member = "RegisterConsumedCharacters", MemberParameters = new object[]
		{
			typeof(long),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Encoding), Member = "get_Unicode", ReturnType = typeof(Encoding))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlTextReaderImpl), Member = "InitStringInput", MemberParameters = new object[]
		{
			typeof(string),
			typeof(Encoding),
			typeof(string)
		}, ReturnType = typeof(void))]
		internal void DtdParserProxy_PushInternalDtd(string baseUri, string internalDtd)
		{
			throw null;
		}

		// Token: 0x06000284 RID: 644 RVA: 0x000036A1 File Offset: 0x000018A1
		[global::Cpp2ILInjected.Token(Token = "0x6000291")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D75A54", Offset = "0x1D75A54", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl.DtdParserProxy), Member = "System.Xml.IDtdParserAdapter.Throw", MemberParameters = new object[] { typeof(Exception) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlTextReaderImpl), Member = "Throw", MemberParameters = new object[] { typeof(Exception) }, ReturnType = typeof(void))]
		internal void DtdParserProxy_Throw(Exception e)
		{
			throw null;
		}

		// Token: 0x06000285 RID: 645 RVA: 0x000036A4 File Offset: 0x000018A4
		[global::Cpp2ILInjected.Token(Token = "0x6000292")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D75AE0", Offset = "0x1D75AE0", Length = "0x84")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl.DtdParserProxy), Member = "System.Xml.IDtdParserAdapter.OnSystemId", MemberParameters = new object[]
		{
			typeof(string),
			typeof(LineInfo),
			typeof(LineInfo)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlTextReaderImpl), Member = "AddAttributeNoChecks", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int)
		}, ReturnType = typeof(XmlTextReaderImpl.NodeData))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlTextReaderImpl.NodeData), Member = "SetValue", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		internal void DtdParserProxy_OnSystemId(string systemId, LineInfo keywordLineInfo, LineInfo systemLiteralLineInfo)
		{
			throw null;
		}

		// Token: 0x06000286 RID: 646 RVA: 0x000036A7 File Offset: 0x000018A7
		[global::Cpp2ILInjected.Token(Token = "0x6000293")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D75BF0", Offset = "0x1D75BF0", Length = "0x84")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl.DtdParserProxy), Member = "System.Xml.IDtdParserAdapter.OnPublicId", MemberParameters = new object[]
		{
			typeof(string),
			typeof(LineInfo),
			typeof(LineInfo)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlTextReaderImpl), Member = "AddAttributeNoChecks", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int)
		}, ReturnType = typeof(XmlTextReaderImpl.NodeData))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlTextReaderImpl.NodeData), Member = "SetValue", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		internal void DtdParserProxy_OnPublicId(string publicId, LineInfo keywordLineInfo, LineInfo publicLiteralLineInfo)
		{
			throw null;
		}

		// Token: 0x06000287 RID: 647 RVA: 0x000036AA File Offset: 0x000018AA
		[global::Cpp2ILInjected.Token(Token = "0x6000294")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D75C74", Offset = "0x1D75C74", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ThrowUnclosedElements", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseElement", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParsePIValue", MemberParameters = new object[]
		{
			typeof(ref int),
			typeof(ref int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseQName", MemberParameters = new object[]
		{
			typeof(bool),
			typeof(int),
			typeof(ref int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ThrowExpectingWhitespace", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlTextReaderImpl), Member = "Throw", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		private void Throw(int pos, string res, string arg)
		{
			throw null;
		}

		// Token: 0x06000288 RID: 648 RVA: 0x000036AD File Offset: 0x000018AD
		[global::Cpp2ILInjected.Token(Token = "0x6000295")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D75D1C", Offset = "0x1D75D1C", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ThrowInvalidChar", MemberParameters = new object[]
		{
			typeof(char[]),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseElement", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseAttributes", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseAttributeValueSlow", MemberParameters = new object[]
		{
			typeof(int),
			typeof(char),
			typeof(XmlTextReaderImpl.NodeData)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseNumericCharRefInline", MemberParameters = new object[]
		{
			typeof(int),
			typeof(bool),
			typeof(StringBuilder),
			typeof(ref int),
			typeof(ref XmlTextReaderImpl.EntityType)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseQName", MemberParameters = new object[]
		{
			typeof(bool),
			typeof(int),
			typeof(ref int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseAttributeValueChunk", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 8)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlTextReaderImpl), Member = "Throw", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string[])
		}, ReturnType = typeof(void))]
		private void Throw(int pos, string res, string[] args)
		{
			throw null;
		}

		// Token: 0x06000289 RID: 649 RVA: 0x000036B0 File Offset: 0x000018B0
		[global::Cpp2ILInjected.Token(Token = "0x6000296")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D75DC4", Offset = "0x1D75DC4", Length = "0x5C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl), Member = "InvalidCharRecovery", MemberParameters = new object[]
		{
			typeof(ref int),
			typeof(ref int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseDocumentContent", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ThrowUnclosedElements", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseText", MemberParameters = new object[]
		{
			typeof(ref int),
			typeof(ref int),
			typeof(ref int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseCDataOrComment", MemberParameters = new object[]
		{
			typeof(XmlNodeType),
			typeof(ref int),
			typeof(ref int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseDoctypeDecl", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseNumericCharRefInline", MemberParameters = new object[]
		{
			typeof(int),
			typeof(bool),
			typeof(StringBuilder),
			typeof(ref int),
			typeof(ref XmlTextReaderImpl.EntityType)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ThrowExpectingWhitespace", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 8)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlTextReaderImpl), Member = "Throw", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		private void Throw(int pos, string res)
		{
			throw null;
		}

		// Token: 0x0600028A RID: 650 RVA: 0x000036B3 File Offset: 0x000018B3
		[global::Cpp2ILInjected.Token(Token = "0x6000297")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D75E20", Offset = "0x1D75E20", Length = "0x54")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseXmlDeclaration", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseDocumentContent", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseElementContent", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ThrowTagMismatch", MemberParameters = new object[] { typeof(XmlTextReaderImpl.NodeData) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseAttributeValueSlow", MemberParameters = new object[]
		{
			typeof(int),
			typeof(char),
			typeof(XmlTextReaderImpl.NodeData)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseText", MemberParameters = new object[]
		{
			typeof(ref int),
			typeof(ref int),
			typeof(ref int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseRootLevelWhitespace", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl), Member = "HandleEntityReference", MemberParameters = new object[]
		{
			typeof(bool),
			typeof(XmlTextReaderImpl.EntityExpandType),
			typeof(ref int)
		}, ReturnType = typeof(XmlTextReaderImpl.EntityType))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl), Member = "HandleEntityEnd", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl), Member = "SkipDtd", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl), Member = "SkipUntil", MemberParameters = new object[]
		{
			typeof(char),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl), Member = "EatWhitespaces", MemberParameters = new object[] { typeof(StringBuilder) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseNumericCharRef", MemberParameters = new object[]
		{
			typeof(bool),
			typeof(StringBuilder),
			typeof(ref XmlTextReaderImpl.EntityType)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseEntityName", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ThrowUnexpectedToken", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 16)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlTextReaderImpl), Member = "Throw", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		private void Throw(string res)
		{
			throw null;
		}

		// Token: 0x0600028B RID: 651 RVA: 0x000036B6 File Offset: 0x000018B6
		[global::Cpp2ILInjected.Token(Token = "0x6000298")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D75E74", Offset = "0x1D75E74", Length = "0xA0")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseXmlDeclaration", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl), Member = "OnNamespaceDecl", MemberParameters = new object[] { typeof(XmlTextReaderImpl.NodeData) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl), Member = "HandleEntityReference", MemberParameters = new object[]
		{
			typeof(bool),
			typeof(XmlTextReaderImpl.EntityExpandType),
			typeof(ref int)
		}, ReturnType = typeof(XmlTextReaderImpl.EntityType))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl), Member = "AddNamespace", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(XmlTextReaderImpl.NodeData)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(int),
			typeof(int),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlTextReaderImpl), Member = "Throw", MemberParameters = new object[] { typeof(Exception) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		private void Throw(string res, int lineNo, int linePos)
		{
			throw null;
		}

		// Token: 0x0600028C RID: 652 RVA: 0x000036B9 File Offset: 0x000018B9
		[global::Cpp2ILInjected.Token(Token = "0x6000299")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D75C88", Offset = "0x1D75C88", Length = "0x94")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl), Member = "Throw", MemberParameters = new object[]
		{
			typeof(int),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl), Member = "Throw", MemberParameters = new object[]
		{
			typeof(int),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl), Member = "Throw", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl), Member = "InitFragmentReader", MemberParameters = new object[]
		{
			typeof(XmlNodeType),
			typeof(XmlParserContext),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl), Member = "DetectEncoding", ReturnType = typeof(Encoding))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl), Member = "CheckEncoding", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(Encoding))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseXmlDeclaration", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl), Member = "FinishReadElementContentAsBinary", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParsePI", MemberParameters = new object[] { typeof(StringBuilder) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseCDataOrComment", MemberParameters = new object[]
		{
			typeof(XmlNodeType),
			typeof(ref int),
			typeof(ref int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseDoctypeDecl", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl), Member = "PushExternalEntityOrSubset", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(Uri),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 13)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlTextReaderImpl.ParsingState), Member = "get_LinePos", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(int),
			typeof(int),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlTextReaderImpl), Member = "Throw", MemberParameters = new object[] { typeof(Exception) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private void Throw(string res, string arg)
		{
			throw null;
		}

		// Token: 0x0600028D RID: 653 RVA: 0x000036BC File Offset: 0x000018BC
		[global::Cpp2ILInjected.Token(Token = "0x600029A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D75F14", Offset = "0x1D75F14", Length = "0x84")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl), Member = "AttributeDuplCheck", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl), Member = "OnXmlReservedAttribute", MemberParameters = new object[] { typeof(XmlTextReaderImpl.NodeData) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl), Member = "HandleGeneralEntityReference", MemberParameters = new object[]
		{
			typeof(string),
			typeof(bool),
			typeof(bool),
			typeof(int)
		}, ReturnType = typeof(XmlTextReaderImpl.EntityType))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl), Member = "LookupNamespace", MemberParameters = new object[] { typeof(XmlTextReaderImpl.NodeData) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl), Member = "AddNamespace", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(XmlTextReaderImpl.NodeData)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl), Member = "RegisterEntity", MemberParameters = new object[] { typeof(IDtdEntityInfo) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 7)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(int),
			typeof(int),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlTextReaderImpl), Member = "Throw", MemberParameters = new object[] { typeof(Exception) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private void Throw(string res, string arg, int lineNo, int linePos)
		{
			throw null;
		}

		// Token: 0x0600028E RID: 654 RVA: 0x000036BF File Offset: 0x000018BF
		[global::Cpp2ILInjected.Token(Token = "0x600029B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D75D30", Offset = "0x1D75D30", Length = "0x94")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl), Member = "Throw", MemberParameters = new object[]
		{
			typeof(int),
			typeof(string),
			typeof(string[])
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ThrowTagMismatch", MemberParameters = new object[] { typeof(XmlTextReaderImpl.NodeData) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParsePI", MemberParameters = new object[] { typeof(StringBuilder) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ThrowUnexpectedToken", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlTextReaderImpl.ParsingState), Member = "get_LinePos", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string[]),
			typeof(int),
			typeof(int),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlTextReaderImpl), Member = "Throw", MemberParameters = new object[] { typeof(Exception) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private void Throw(string res, string[] args)
		{
			throw null;
		}

		// Token: 0x0600028F RID: 655 RVA: 0x000036C2 File Offset: 0x000018C2
		[global::Cpp2ILInjected.Token(Token = "0x600029C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D75F98", Offset = "0x1D75F98", Length = "0x78")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl), Member = "CheckEncoding", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(Encoding))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseNumericCharRefInline", MemberParameters = new object[]
		{
			typeof(int),
			typeof(bool),
			typeof(StringBuilder),
			typeof(ref int),
			typeof(ref XmlTextReaderImpl.EntityType)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlTextReaderImpl), Member = "Throw", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string[]),
			typeof(Exception)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		private void Throw(string res, string arg, Exception innerException)
		{
			throw null;
		}

		// Token: 0x06000290 RID: 656 RVA: 0x000036C5 File Offset: 0x000018C5
		[global::Cpp2ILInjected.Token(Token = "0x600029D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D76010", Offset = "0x1D76010", Length = "0xA0")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl), Member = "Throw", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(Exception)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlTextReaderImpl.ParsingState), Member = "get_LinePos", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string[]),
			typeof(Exception),
			typeof(int),
			typeof(int),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlTextReaderImpl), Member = "Throw", MemberParameters = new object[] { typeof(Exception) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private void Throw(string res, string[] args, Exception innerException)
		{
			throw null;
		}

		// Token: 0x06000291 RID: 657 RVA: 0x000036C8 File Offset: 0x000018C8
		[global::Cpp2ILInjected.Token(Token = "0x600029E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D75A5C", Offset = "0x1D75A5C", Length = "0x84")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl), Member = "DtdParserProxy_Throw", MemberParameters = new object[] { typeof(Exception) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl), Member = "Throw", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl), Member = "Throw", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl), Member = "Throw", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl), Member = "Throw", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string[])
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl), Member = "Throw", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string[]),
			typeof(Exception)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ReThrow", MemberParameters = new object[]
		{
			typeof(Exception),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ThrowWithoutLineInfo", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ThrowWithoutLineInfo", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ThrowWithoutLineInfo", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string[]),
			typeof(Exception)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl), Member = "PushExternalEntityOrSubset", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(Uri),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 11)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlTextReaderImpl.NodeData), Member = "SetLineInfo", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		private void Throw(Exception e)
		{
			throw null;
		}

		// Token: 0x06000292 RID: 658 RVA: 0x000036CB File Offset: 0x000018CB
		[global::Cpp2ILInjected.Token(Token = "0x600029F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D760C4", Offset = "0x1D760C4", Length = "0x98")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl), Member = "AddNamespace", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(XmlTextReaderImpl.NodeData)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl), Member = "IncrementalRead", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseXmlDeclarationFragment", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(Exception),
			typeof(int),
			typeof(int),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlTextReaderImpl), Member = "Throw", MemberParameters = new object[] { typeof(Exception) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private void ReThrow(Exception e, int lineNo, int linePos)
		{
			throw null;
		}

		// Token: 0x06000293 RID: 659 RVA: 0x000036CE File Offset: 0x000018CE
		[global::Cpp2ILInjected.Token(Token = "0x60002A0")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D72914", Offset = "0x1D72914", Length = "0x8C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl), Member = "Read", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ProcessDtdFromParserContext", MemberParameters = new object[] { typeof(XmlParserContext) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl), Member = "CheckEncoding", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(Encoding))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseDocumentContent", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseDoctypeDecl", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlTextReaderImpl), Member = "Throw", MemberParameters = new object[] { typeof(Exception) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		private void ThrowWithoutLineInfo(string res)
		{
			throw null;
		}

		// Token: 0x06000294 RID: 660 RVA: 0x000036D1 File Offset: 0x000018D1
		[global::Cpp2ILInjected.Token(Token = "0x60002A1")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D7615C", Offset = "0x1D7615C", Length = "0x70")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl), Member = "OpenUrl", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl), Member = "RegisterConsumedCharacters", MemberParameters = new object[]
		{
			typeof(long),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlTextReaderImpl), Member = "Throw", MemberParameters = new object[] { typeof(Exception) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private void ThrowWithoutLineInfo(string res, string arg)
		{
			throw null;
		}

		// Token: 0x06000295 RID: 661 RVA: 0x000036D4 File Offset: 0x000018D4
		[global::Cpp2ILInjected.Token(Token = "0x60002A2")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D761CC", Offset = "0x1D761CC", Length = "0x84")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl), Member = "PushExternalEntityOrSubset", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(Uri),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string[]),
			typeof(Exception),
			typeof(int),
			typeof(int),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlTextReaderImpl), Member = "Throw", MemberParameters = new object[] { typeof(Exception) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private void ThrowWithoutLineInfo(string res, string[] args, Exception innerException)
		{
			throw null;
		}

		// Token: 0x06000296 RID: 662 RVA: 0x000036D7 File Offset: 0x000018D7
		[global::Cpp2ILInjected.Token(Token = "0x60002A3")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D76250", Offset = "0x1D76250", Length = "0x70")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseAttributeValueSlow", MemberParameters = new object[]
		{
			typeof(int),
			typeof(char),
			typeof(XmlTextReaderImpl.NodeData)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseText", MemberParameters = new object[]
		{
			typeof(ref int),
			typeof(ref int),
			typeof(ref int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseRootLevelWhitespace", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParsePIValue", MemberParameters = new object[]
		{
			typeof(ref int),
			typeof(ref int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseCDataOrComment", MemberParameters = new object[]
		{
			typeof(XmlNodeType),
			typeof(ref int),
			typeof(ref int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl), Member = "SkipUntil", MemberParameters = new object[]
		{
			typeof(char),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseAttributeValueChunk", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 7)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlException), Member = "BuildCharExceptionArgs", MemberParameters = new object[]
		{
			typeof(char[]),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(string[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlTextReaderImpl), Member = "Throw", MemberParameters = new object[]
		{
			typeof(int),
			typeof(string),
			typeof(string[])
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		private void ThrowInvalidChar(char[] data, int length, int invCharPos)
		{
			throw null;
		}

		// Token: 0x06000297 RID: 663 RVA: 0x000036DA File Offset: 0x000018DA
		[global::Cpp2ILInjected.Token(Token = "0x60002A4")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D760B0", Offset = "0x1D760B0", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private void SetErrorState()
		{
			throw null;
		}

		// Token: 0x06000298 RID: 664 RVA: 0x000036DD File Offset: 0x000018DD
		[global::Cpp2ILInjected.Token(Token = "0x60002A5")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D74848", Offset = "0x1D74848", Length = "0xA4")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl), Member = "DtdParserProxy_ParseComment", MemberParameters = new object[] { typeof(StringBuilder) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl), Member = "AddDefaultAttributesAndNormalize", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlSchemaException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(string),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlTextReaderImpl), Member = "SendValidationEvent", MemberParameters = new object[]
		{
			typeof(XmlSeverityType),
			typeof(XmlSchemaException)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private void SendValidationEvent(XmlSeverityType severity, string code, string arg, int lineNo, int linePos)
		{
			throw null;
		}

		// Token: 0x06000299 RID: 665 RVA: 0x000036E0 File Offset: 0x000018E0
		[global::Cpp2ILInjected.Token(Token = "0x60002A6")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D762C0", Offset = "0x1D762C0", Length = "0xC4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl), Member = "SendValidationEvent", MemberParameters = new object[]
		{
			typeof(XmlSeverityType),
			typeof(string),
			typeof(string),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		private void SendValidationEvent(XmlSeverityType severity, XmlSchemaException exception)
		{
			throw null;
		}

		// Token: 0x1700009B RID: 155
		// (get) Token: 0x0600029A RID: 666 RVA: 0x000036E3 File Offset: 0x000018E3
		[global::Cpp2ILInjected.Token(Token = "0x170000A0")]
		private bool InAttributeValueIterator
		{
			[global::Cpp2ILInjected.Token(Token = "0x60002A7")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D70A34", Offset = "0x1D70A34", Length = "0x24")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0600029B RID: 667 RVA: 0x000036E6 File Offset: 0x000018E6
		[global::Cpp2ILInjected.Token(Token = "0x60002A8")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D70A58", Offset = "0x1D70A58", Length = "0xA4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl), Member = "MoveToAttribute", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl), Member = "MoveToFirstAttribute", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl), Member = "MoveToNextAttribute", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl), Member = "MoveToElement", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl), Member = "Read", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlTextReaderImpl), Member = "SkipPartialTextValue", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlTextReaderImpl), Member = "FinishReadContentAsBinary", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlTextReaderImpl), Member = "HandleEntityEnd", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(bool))]
		private void FinishAttributeValueIterator()
		{
			throw null;
		}

		// Token: 0x1700009C RID: 156
		// (get) Token: 0x0600029C RID: 668 RVA: 0x000036E9 File Offset: 0x000018E9
		[global::Cpp2ILInjected.Token(Token = "0x170000A1")]
		private bool DtdValidation
		{
			[global::Cpp2ILInjected.Token(Token = "0x60002A9")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D73BF8", Offset = "0x1D73BF8", Length = "0x10")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0600029D RID: 669 RVA: 0x000036EC File Offset: 0x000018EC
		[global::Cpp2ILInjected.Token(Token = "0x60002AA")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D7647C", Offset = "0x1D7647C", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlTextReaderImpl), Member = "InitStreamInput", MemberParameters = new object[]
		{
			typeof(Uri),
			typeof(string),
			typeof(Stream),
			typeof(byte[]),
			typeof(int),
			typeof(Encoding)
		}, ReturnType = typeof(void))]
		private void InitStreamInput(Uri baseUri, Stream stream, Encoding encoding)
		{
			throw null;
		}

		// Token: 0x0600029E RID: 670 RVA: 0x000036EF File Offset: 0x000018EF
		[global::Cpp2ILInjected.Token(Token = "0x60002AB")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D764D4", Offset = "0x1D764D4", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlTextReaderImpl), Member = "InitStreamInput", MemberParameters = new object[]
		{
			typeof(Uri),
			typeof(string),
			typeof(Stream),
			typeof(byte[]),
			typeof(int),
			typeof(Encoding)
		}, ReturnType = typeof(void))]
		private void InitStreamInput(Uri baseUri, string baseUriStr, Stream stream, Encoding encoding)
		{
			throw null;
		}

		// Token: 0x0600029F RID: 671 RVA: 0x000036F2 File Offset: 0x000018F2
		[global::Cpp2ILInjected.Token(Token = "0x60002AC")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D70134", Offset = "0x1D70134", Length = "0x248")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl), Member = "FinishInitUriString", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl), Member = "FinishInitStream", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl), Member = "InitStreamInput", MemberParameters = new object[]
		{
			typeof(Uri),
			typeof(Stream),
			typeof(Encoding)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl), Member = "InitStreamInput", MemberParameters = new object[]
		{
			typeof(Uri),
			typeof(string),
			typeof(Stream),
			typeof(Encoding)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl), Member = "OpenUrl", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl), Member = "OpenAndPush", MemberParameters = new object[] { typeof(Uri) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 6)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlReader), Member = "CalcBufferSize", MemberParameters = new object[] { typeof(Stream) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlTextReaderImpl), Member = "DetectEncoding", ReturnType = typeof(Encoding))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlTextReaderImpl), Member = "SetupEncoding", MemberParameters = new object[] { typeof(Encoding) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlTextReaderImpl), Member = "ReadData", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		private void InitStreamInput(Uri baseUri, string baseUriStr, Stream stream, byte[] bytes, int byteCount, Encoding encoding)
		{
			throw null;
		}

		// Token: 0x060002A0 RID: 672 RVA: 0x000036F5 File Offset: 0x000018F5
		[global::Cpp2ILInjected.Token(Token = "0x60002AD")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D6F9A0", Offset = "0x1D6F9A0", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlTextReaderImpl), Member = "InitTextReaderInput", MemberParameters = new object[]
		{
			typeof(string),
			typeof(Uri),
			typeof(TextReader)
		}, ReturnType = typeof(void))]
		private void InitTextReaderInput(string baseUriStr, TextReader input)
		{
			throw null;
		}

		// Token: 0x060002A1 RID: 673 RVA: 0x000036F8 File Offset: 0x000018F8
		[global::Cpp2ILInjected.Token(Token = "0x60002AE")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D76818", Offset = "0x1D76818", Length = "0xB0")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(TextReader),
			typeof(XmlNameTable)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl), Member = "FinishInitTextReader", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl), Member = "InitTextReaderInput", MemberParameters = new object[]
		{
			typeof(string),
			typeof(TextReader)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl), Member = "OpenAndPush", MemberParameters = new object[] { typeof(Uri) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Encoding), Member = "get_Unicode", ReturnType = typeof(Encoding))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlTextReaderImpl), Member = "ReadData", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private void InitTextReaderInput(string baseUriStr, Uri baseUri, TextReader input)
		{
			throw null;
		}

		// Token: 0x060002A2 RID: 674 RVA: 0x000036FB File Offset: 0x000018FB
		[global::Cpp2ILInjected.Token(Token = "0x60002AF")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D6FAB0", Offset = "0x1D6FAB0", Length = "0xB8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(XmlNodeType),
			typeof(XmlParserContext)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(XmlParserContext)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl), Member = "DtdParserProxy_PushInternalDtd", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl), Member = "PushExternalEntity", MemberParameters = new object[] { typeof(IDtdEntityInfo) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl), Member = "PushInternalEntity", MemberParameters = new object[] { typeof(IDtdEntityInfo) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "CopyTo", MemberParameters = new object[]
		{
			typeof(int),
			typeof(char[]),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private void InitStringInput(string baseUriStr, Encoding originalEncoding, string str)
		{
			throw null;
		}

		// Token: 0x060002A3 RID: 675 RVA: 0x000036FE File Offset: 0x000018FE
		[global::Cpp2ILInjected.Token(Token = "0x60002B0")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D6FB68", Offset = "0x1D6FB68", Length = "0x1D8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(XmlNodeType),
			typeof(XmlParserContext)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(XmlParserContext)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlNamespaceManager), Member = ".ctor", MemberParameters = new object[] { typeof(XmlNameTable) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Enum), Member = "ToString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlTextReaderImpl), Member = "Throw", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		private void InitFragmentReader(XmlNodeType fragmentType, XmlParserContext parserContext, bool allowXmlDeclFragment)
		{
			throw null;
		}

		// Token: 0x060002A4 RID: 676 RVA: 0x00003701 File Offset: 0x00001901
		[global::Cpp2ILInjected.Token(Token = "0x60002B1")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D7037C", Offset = "0x1D7037C", Length = "0x6C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl), Member = "FinishInitUriString", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl), Member = "FinishInitStream", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl), Member = "FinishInitTextReader", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlTextReaderImpl), Member = "ParseDtdFromParserContext", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlTextReaderImpl), Member = "ThrowWithoutLineInfo", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		private void ProcessDtdFromParserContext(XmlParserContext context)
		{
			throw null;
		}

		// Token: 0x060002A5 RID: 677 RVA: 0x00003704 File Offset: 0x00001904
		[global::Cpp2ILInjected.Token(Token = "0x60002B2")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D71798", Offset = "0x1D71798", Length = "0x180")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl), Member = "Read", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlTextReaderImpl), Member = "GetTempResolver", ReturnType = typeof(XmlResolver))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Uri), Member = "op_Inequality", MemberParameters = new object[]
		{
			typeof(Uri),
			typeof(Uri)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlTextReaderImpl), Member = "OpenUrlDelegate", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlTextReaderImpl), Member = "InitStreamInput", MemberParameters = new object[]
		{
			typeof(Uri),
			typeof(string),
			typeof(Stream),
			typeof(byte[]),
			typeof(int),
			typeof(Encoding)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlTextReaderImpl), Member = "ThrowWithoutLineInfo", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 13)]
		private void OpenUrl()
		{
			throw null;
		}

		// Token: 0x060002A6 RID: 678 RVA: 0x00003707 File Offset: 0x00001907
		[global::Cpp2ILInjected.Token(Token = "0x60002B3")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D76ADC", Offset = "0x1D76ADC", Length = "0x11C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl), Member = "OpenUrl", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlTextReaderImpl), Member = "GetTempResolver", ReturnType = typeof(XmlResolver))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(RuntimeTypeHandle) }, ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		private void OpenUrlDelegate(object xmlResolver)
		{
			throw null;
		}

		// Token: 0x060002A7 RID: 679 RVA: 0x0000370A File Offset: 0x0000190A
		[global::Cpp2ILInjected.Token(Token = "0x60002B4")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D764E4", Offset = "0x1D764E4", Length = "0x1FC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl), Member = "InitStreamInput", MemberParameters = new object[]
		{
			typeof(Uri),
			typeof(string),
			typeof(Stream),
			typeof(byte[]),
			typeof(int),
			typeof(Encoding)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Encoding), Member = "get_Unicode", ReturnType = typeof(Encoding))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Encoding), Member = "get_BigEndianUnicode", ReturnType = typeof(Encoding))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UTF8Encoding), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Ucs4Encoding), Member = "get_UCS4_Littleendian", ReturnType = typeof(Encoding))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Ucs4Encoding), Member = "get_UCS4_3412", ReturnType = typeof(Encoding))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlTextReaderImpl), Member = "Throw", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Ucs4Encoding), Member = "get_UCS4_2143", ReturnType = typeof(Encoding))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Ucs4Encoding), Member = "get_UCS4_Bigendian", ReturnType = typeof(Encoding))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		private Encoding DetectEncoding()
		{
			throw null;
		}

		// Token: 0x060002A8 RID: 680 RVA: 0x0000370D File Offset: 0x0000190D
		[global::Cpp2ILInjected.Token(Token = "0x60002B5")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D766E0", Offset = "0x1D766E0", Length = "0x138")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl), Member = "InitStreamInput", MemberParameters = new object[]
		{
			typeof(Uri),
			typeof(string),
			typeof(Stream),
			typeof(byte[]),
			typeof(int),
			typeof(Encoding)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl), Member = "SwitchEncoding", MemberParameters = new object[] { typeof(Encoding) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Encoding), Member = "get_UTF8", ReturnType = typeof(Encoding))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SafeAsciiDecoder), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UTF16Decoder), Member = ".ctor", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		private void SetupEncoding(Encoding encoding)
		{
			throw null;
		}

		// Token: 0x060002A9 RID: 681 RVA: 0x00003710 File Offset: 0x00001910
		[global::Cpp2ILInjected.Token(Token = "0x60002B6")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D76BF8", Offset = "0x1D76BF8", Length = "0xE4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl), Member = "SwitchEncodingToUTF8", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseXmlDeclaration", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "op_Inequality", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlTextReaderImpl), Member = "UnDecodeChars", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlTextReaderImpl), Member = "SetupEncoding", MemberParameters = new object[] { typeof(Encoding) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlTextReaderImpl), Member = "ReadData", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		private void SwitchEncoding(Encoding newEncoding)
		{
			throw null;
		}

		// Token: 0x060002AA RID: 682 RVA: 0x00003713 File Offset: 0x00001913
		[global::Cpp2ILInjected.Token(Token = "0x60002B7")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D76D7C", Offset = "0x1D76D7C", Length = "0x318")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseXmlDeclaration", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Compare", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(StringComparison)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Encoding), Member = "GetEncoding", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(Encoding))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "op_Inequality", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UTF8Encoding), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlTextReaderImpl), Member = "ThrowWithoutLineInfo", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlTextReaderImpl), Member = "Throw", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlTextReaderImpl), Member = "Throw", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(Exception)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 22)]
		private Encoding CheckEncoding(string newEncodingName)
		{
			throw null;
		}

		// Token: 0x060002AB RID: 683 RVA: 0x00003716 File Offset: 0x00001916
		[global::Cpp2ILInjected.Token(Token = "0x60002B8")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D76CDC", Offset = "0x1D76CDC", Length = "0xA0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl), Member = "SwitchEncoding", MemberParameters = new object[] { typeof(Encoding) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		private void UnDecodeChars()
		{
			throw null;
		}

		// Token: 0x060002AC RID: 684 RVA: 0x00003719 File Offset: 0x00001919
		[global::Cpp2ILInjected.Token(Token = "0x60002B9")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D770A4", Offset = "0x1D770A4", Length = "0x64")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseXmlDeclaration", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UTF8Encoding), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlTextReaderImpl), Member = "SwitchEncoding", MemberParameters = new object[] { typeof(Encoding) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private void SwitchEncodingToUTF8()
		{
			throw null;
		}

		// Token: 0x060002AD RID: 685 RVA: 0x0000371C File Offset: 0x0000191C
		[global::Cpp2ILInjected.Token(Token = "0x60002BA")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D73D3C", Offset = "0x1D73D3C", Length = "0x3C8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 31)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlTextReaderImpl.NodeData), Member = "OnBufferInvalidated", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Buffer), Member = "BlockCopy", MemberParameters = new object[]
		{
			typeof(Array),
			typeof(int),
			typeof(Array),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlTextReaderImpl), Member = "GetChars", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlTextReaderImpl), Member = "RegisterConsumedCharacters", MemberParameters = new object[]
		{
			typeof(long),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		private int ReadData()
		{
			throw null;
		}

		// Token: 0x060002AE RID: 686 RVA: 0x0000371F File Offset: 0x0000191F
		[global::Cpp2ILInjected.Token(Token = "0x60002BB")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D77124", Offset = "0x1D77124", Length = "0x110")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ReadData", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlTextReaderImpl), Member = "InvalidCharRecovery", MemberParameters = new object[]
		{
			typeof(ref int),
			typeof(ref int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
		private int GetChars(int maxCharsCount)
		{
			throw null;
		}

		// Token: 0x060002AF RID: 687 RVA: 0x00003722 File Offset: 0x00001922
		[global::Cpp2ILInjected.Token(Token = "0x60002BC")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D77234", Offset = "0x1D77234", Length = "0x16C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl), Member = "GetChars", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlTextReaderImpl), Member = "Throw", MemberParameters = new object[]
		{
			typeof(int),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
		private void InvalidCharRecovery(ref int bytesCount, out int charsCount)
		{
			throw null;
		}

		// Token: 0x060002B0 RID: 688 RVA: 0x00003725 File Offset: 0x00001925
		[global::Cpp2ILInjected.Token(Token = "0x60002BD")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D72B08", Offset = "0x1D72B08", Length = "0xF8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlTextReaderImpl.ParsingState), Member = "Close", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlTextReaderImpl.NodeData), Member = "get_None", ReturnType = typeof(XmlTextReaderImpl.NodeData))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlTextReaderImpl), Member = "ResetAttributes", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		internal void Close(bool closeInput)
		{
			throw null;
		}

		// Token: 0x060002B1 RID: 689 RVA: 0x00003728 File Offset: 0x00001928
		[global::Cpp2ILInjected.Token(Token = "0x60002BE")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D773F4", Offset = "0x1D773F4", Length = "0x20")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Buffer), Member = "BlockCopy", MemberParameters = new object[]
		{
			typeof(Array),
			typeof(int),
			typeof(Array),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		private void ShiftBuffer(int sourcePos, int destPos, int count)
		{
			throw null;
		}

		// Token: 0x060002B2 RID: 690 RVA: 0x0000372B File Offset: 0x0000192B
		[global::Cpp2ILInjected.Token(Token = "0x60002BF")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D71918", Offset = "0x1D71918", Length = "0xBD8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl), Member = "Read", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl), Member = "DtdParserProxy_PushExternalSubset", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl), Member = "PushExternalEntity", MemberParameters = new object[] { typeof(IDtdEntityInfo) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseXmlDeclarationFragment", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlTextReaderImpl), Member = "ReadData", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlConvert), Member = "StrEqual", MemberParameters = new object[]
		{
			typeof(char[]),
			typeof(int),
			typeof(int),
			typeof(string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlCharType), Member = "IsNameSingleChar", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "op_Inequality", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlTextReaderImpl), Member = "SwitchEncodingToUTF8", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlTextReaderImpl.ParsingState), Member = "get_LinePos", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlTextReaderImpl.NodeData), Member = "SetLineInfo", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlTextReaderImpl.NodeData), Member = "SetNamedNode", MemberParameters = new object[]
		{
			typeof(XmlNodeType),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = "get_Length", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlTextReaderImpl), Member = "EatWhitespaces", MemberParameters = new object[] { typeof(StringBuilder) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = "set_Length", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlTextReaderImpl), Member = "ThrowUnexpectedToken", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlTextReaderImpl), Member = "ParseQName", MemberParameters = new object[]
		{
			typeof(bool),
			typeof(int),
			typeof(ref int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlTextReaderImpl), Member = "AddAttributeNoChecks", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int)
		}, ReturnType = typeof(XmlTextReaderImpl.NodeData))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new object[]
		{
			typeof(char[]),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(StringBuilder))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(StringBuilder))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlTextReaderImpl.NodeData), Member = "SetLineInfo2", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlTextReaderImpl.NodeData), Member = "SetValue", MemberParameters = new object[]
		{
			typeof(char[]),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "CreateString", MemberParameters = new object[]
		{
			typeof(char[]),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlTextReaderImpl), Member = "CheckEncoding", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(Encoding))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlTextReaderImpl.NodeData), Member = "SetValue", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlTextReaderImpl), Member = "SwitchEncoding", MemberParameters = new object[] { typeof(Encoding) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlTextReaderImpl), Member = "Throw", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlTextReaderImpl), Member = "Throw", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlTextReaderImpl), Member = "Throw", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 36)]
		private bool ParseXmlDeclaration(bool isTextDecl)
		{
			throw null;
		}

		// Token: 0x060002B3 RID: 691 RVA: 0x0000372E File Offset: 0x0000192E
		[global::Cpp2ILInjected.Token(Token = "0x60002C0")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D712E4", Offset = "0x1D712E4", Length = "0x4B4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl), Member = "Read", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlTextReaderImpl), Member = "ReadData", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlTextReaderImpl), Member = "HandleEntityEnd", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlTextReaderImpl), Member = "ParsePI", MemberParameters = new object[] { typeof(StringBuilder) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlTextReaderImpl), Member = "HandleEntityReference", MemberParameters = new object[]
		{
			typeof(bool),
			typeof(XmlTextReaderImpl.EntityExpandType),
			typeof(ref int)
		}, ReturnType = typeof(XmlTextReaderImpl.EntityType))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlTextReaderImpl), Member = "ParseText", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlTextReaderImpl), Member = "ParseRootLevelWhitespace", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlTextReaderImpl), Member = "ParseComment", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlConvert), Member = "StrEqual", MemberParameters = new object[]
		{
			typeof(char[]),
			typeof(int),
			typeof(int),
			typeof(string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlTextReaderImpl), Member = "ThrowUnexpectedToken", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlTextReaderImpl), Member = "ParseDoctypeDecl", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlTextReaderImpl), Member = "ParseUnexpectedToken", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlTextReaderImpl), Member = "ParseElement", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlTextReaderImpl), Member = "OnEof", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlTextReaderImpl), Member = "SetupEndEntityNodeInContent", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlTextReaderImpl), Member = "ParseEntityReference", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlTextReaderImpl), Member = "ParseCDataOrComment", MemberParameters = new object[] { typeof(XmlNodeType) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlTextReaderImpl), Member = "Throw", MemberParameters = new object[]
		{
			typeof(int),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlTextReaderImpl), Member = "Throw", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlTextReaderImpl), Member = "ThrowWithoutLineInfo", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 12)]
		private bool ParseDocumentContent()
		{
			throw null;
		}

		// Token: 0x060002B4 RID: 692 RVA: 0x00003731 File Offset: 0x00001931
		[global::Cpp2ILInjected.Token(Token = "0x60002C1")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D70FE4", Offset = "0x1D70FE4", Length = "0x300")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlTextReaderImpl), Member = "ParseText", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlTextReaderImpl), Member = "ParsePI", MemberParameters = new object[] { typeof(StringBuilder) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlTextReaderImpl), Member = "ParseComment", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlConvert), Member = "StrEqual", MemberParameters = new object[]
		{
			typeof(char[]),
			typeof(int),
			typeof(int),
			typeof(string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlTextReaderImpl), Member = "ParseUnexpectedToken", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlTextReaderImpl), Member = "ThrowUnexpectedToken", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlTextReaderImpl), Member = "ReadData", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlTextReaderImpl), Member = "ThrowUnclosedElements", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlTextReaderImpl), Member = "HandleEntityEnd", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlTextReaderImpl), Member = "SetupEndEntityNodeInContent", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlTextReaderImpl), Member = "ParseEndElement", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlTextReaderImpl), Member = "ParseElement", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlTextReaderImpl), Member = "OnEof", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlTextReaderImpl), Member = "ParseCDataOrComment", MemberParameters = new object[] { typeof(XmlNodeType) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlTextReaderImpl), Member = "Throw", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		private bool ParseElementContent()
		{
			throw null;
		}

		// Token: 0x060002B5 RID: 693 RVA: 0x00003734 File Offset: 0x00001934
		[global::Cpp2ILInjected.Token(Token = "0x60002C2")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D7874C", Offset = "0x1D7874C", Length = "0x15C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseElementContent", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseEndElement", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseAttributes", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl), Member = "IncrementalRead", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = "set_Length", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlTextReaderImpl.NodeData), Member = "GetNameWPrefix", MemberParameters = new object[] { typeof(XmlNameTable) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(StringBuilder))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlTextReaderImpl), Member = "Throw", MemberParameters = new object[]
		{
			typeof(int),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlTextReaderImpl), Member = "Throw", MemberParameters = new object[]
		{
			typeof(int),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		private void ThrowUnclosedElements()
		{
			throw null;
		}

		// Token: 0x060002B6 RID: 694 RVA: 0x00003737 File Offset: 0x00001937
		[global::Cpp2ILInjected.Token(Token = "0x60002C3")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D7784C", Offset = "0x1D7784C", Length = "0x3F0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseDocumentContent", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseElementContent", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlTextReaderImpl.ParsingState), Member = "get_LinePos", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlTextReaderImpl.NodeData), Member = "SetLineInfo", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlTextReaderImpl), Member = "ParseQName", MemberParameters = new object[]
		{
			typeof(bool),
			typeof(int),
			typeof(ref int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlConvert), Member = "StrEqual", MemberParameters = new object[]
		{
			typeof(char[]),
			typeof(int),
			typeof(int),
			typeof(string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlTextReaderImpl.NodeData), Member = "SetNamedNode", MemberParameters = new object[]
		{
			typeof(XmlNodeType),
			typeof(string),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlTextReaderImpl.NodeData), Member = "SetNamedNode", MemberParameters = new object[]
		{
			typeof(XmlNodeType),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlTextReaderImpl), Member = "ParseAttributes", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlTextReaderImpl), Member = "ReadData", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlTextReaderImpl), Member = "ThrowUnexpectedToken", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlTextReaderImpl), Member = "AddDefaultAttributesAndNormalize", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlTextReaderImpl), Member = "ElementNamespaceLookup", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlException), Member = "BuildCharExceptionArgs", MemberParameters = new object[]
		{
			typeof(char),
			typeof(char)
		}, ReturnType = typeof(string[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlTextReaderImpl), Member = "Throw", MemberParameters = new object[]
		{
			typeof(int),
			typeof(string),
			typeof(string[])
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlException), Member = "BuildCharExceptionArgs", MemberParameters = new object[]
		{
			typeof(char[]),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(string[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlTextReaderImpl), Member = "Throw", MemberParameters = new object[]
		{
			typeof(int),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		private void ParseElement()
		{
			throw null;
		}

		// Token: 0x060002B7 RID: 695 RVA: 0x0000373A File Offset: 0x0000193A
		[global::Cpp2ILInjected.Token(Token = "0x60002C4")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D78E18", Offset = "0x1D78E18", Length = "0x9B8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseElement", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseAttributes", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlTextReaderImpl.NodeData), Member = "get_StringValue", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlTextReaderImpl.NodeData), Member = "TrimSpacesInValue", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "op_Inequality", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlTextReaderImpl.NodeData), Member = "GetNameWPrefix", MemberParameters = new object[] { typeof(XmlNameTable) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlTextReaderImpl.NodeData), Member = "get_LineNo", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlTextReaderImpl.NodeData), Member = "get_LinePos", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlTextReaderImpl), Member = "SendValidationEvent", MemberParameters = new object[]
		{
			typeof(XmlSeverityType),
			typeof(string),
			typeof(string),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new object[]
		{
			typeof(Array),
			typeof(int),
			typeof(Array),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Array[]), Member = "Sort", MemberTypeParameters = new object[] { typeof(object) }, MemberParameters = new object[]
		{
			typeof(object[]),
			typeof(IComparer<object>)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlTextReaderImpl), Member = "AddDefaultAttributeDtd", MemberParameters = new object[]
		{
			typeof(IDtdDefaultAttributeInfo),
			typeof(bool),
			typeof(XmlTextReaderImpl.NodeData[])
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlTextReaderImpl), Member = "AttributeNamespaceLookup", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 38)]
		private void AddDefaultAttributesAndNormalize()
		{
			throw null;
		}

		// Token: 0x060002B8 RID: 696 RVA: 0x0000373D File Offset: 0x0000193D
		[global::Cpp2ILInjected.Token(Token = "0x60002C5")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D783FC", Offset = "0x1D783FC", Length = "0x350")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseElementContent", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlTextReaderImpl), Member = "ReadData", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlConvert), Member = "StrEqual", MemberParameters = new object[]
		{
			typeof(char[]),
			typeof(int),
			typeof(int),
			typeof(string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlTextReaderImpl), Member = "ThrowTagMismatch", MemberParameters = new object[] { typeof(XmlTextReaderImpl.NodeData) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlTextReaderImpl.ParsingState), Member = "get_LinePos", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LineInfo), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlCharType), Member = "IsWhiteSpace", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlTextReaderImpl), Member = "ThrowUnexpectedToken", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlTextReaderImpl), Member = "ThrowUnclosedElements", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		private void ParseEndElement()
		{
			throw null;
		}

		// Token: 0x060002B9 RID: 697 RVA: 0x00003740 File Offset: 0x00001940
		[global::Cpp2ILInjected.Token(Token = "0x60002C6")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D79ED0", Offset = "0x1D79ED0", Length = "0x188")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseEndElement", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlTextReaderImpl), Member = "ParseQName", MemberParameters = new object[] { typeof(ref int) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlTextReaderImpl.NodeData), Member = "GetNameWPrefix", MemberParameters = new object[] { typeof(XmlNameTable) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(int), Member = "ToString", MemberParameters = new object[] { typeof(IFormatProvider) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "CreateString", MemberParameters = new object[]
		{
			typeof(char[]),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlTextReaderImpl), Member = "Throw", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string[])
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlTextReaderImpl), Member = "Throw", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
		private void ThrowTagMismatch(XmlTextReaderImpl.NodeData startTag)
		{
			throw null;
		}

		// Token: 0x060002BA RID: 698 RVA: 0x00003743 File Offset: 0x00001943
		[global::Cpp2ILInjected.Token(Token = "0x60002C7")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D788B8", Offset = "0x1D788B8", Length = "0x560")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseElement", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlTextReaderImpl), Member = "ReadData", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlTextReaderImpl), Member = "ThrowUnclosedElements", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlTextReaderImpl), Member = "ThrowUnexpectedToken", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlTextReaderImpl), Member = "ThrowExpectingWhitespace", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlTextReaderImpl.ParsingState), Member = "get_LinePos", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlTextReaderImpl), Member = "ParseQName", MemberParameters = new object[]
		{
			typeof(bool),
			typeof(int),
			typeof(ref int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlTextReaderImpl), Member = "AddAttribute", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(XmlTextReaderImpl.NodeData))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlTextReaderImpl.NodeData), Member = "SetLineInfo", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlTextReaderImpl), Member = "EatWhitespaces", MemberParameters = new object[] { typeof(StringBuilder) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlTextReaderImpl.NodeData), Member = "SetLineInfo2", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlTextReaderImpl.NodeData), Member = "SetValue", MemberParameters = new object[]
		{
			typeof(char[]),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlTextReaderImpl), Member = "ParseAttributeValueSlow", MemberParameters = new object[]
		{
			typeof(int),
			typeof(char),
			typeof(XmlTextReaderImpl.NodeData)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Ref), Member = "Equal", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlTextReaderImpl), Member = "OnNamespaceDecl", MemberParameters = new object[] { typeof(XmlTextReaderImpl.NodeData) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlTextReaderImpl), Member = "OnDefaultNamespaceDecl", MemberParameters = new object[] { typeof(XmlTextReaderImpl.NodeData) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlTextReaderImpl), Member = "OnXmlReservedAttribute", MemberParameters = new object[] { typeof(XmlTextReaderImpl.NodeData) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlTextReaderImpl), Member = "AddDefaultAttributesAndNormalize", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlTextReaderImpl), Member = "ElementNamespaceLookup", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlTextReaderImpl), Member = "AttributeNamespaceLookup", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlTextReaderImpl), Member = "AttributeDuplCheck", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlException), Member = "BuildCharExceptionArgs", MemberParameters = new object[]
		{
			typeof(char),
			typeof(char)
		}, ReturnType = typeof(string[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlTextReaderImpl), Member = "Throw", MemberParameters = new object[]
		{
			typeof(int),
			typeof(string),
			typeof(string[])
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlException), Member = "BuildCharExceptionArgs", MemberParameters = new object[]
		{
			typeof(char[]),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(string[]))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		private void ParseAttributes()
		{
			throw null;
		}

		// Token: 0x060002BB RID: 699 RVA: 0x00003746 File Offset: 0x00001946
		[global::Cpp2ILInjected.Token(Token = "0x60002C8")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D797D0", Offset = "0x1D797D0", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseElement", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseAttributes", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlTextReaderImpl), Member = "LookupNamespace", MemberParameters = new object[] { typeof(XmlTextReaderImpl.NodeData) }, ReturnType = typeof(string))]
		private void ElementNamespaceLookup()
		{
			throw null;
		}

		// Token: 0x060002BC RID: 700 RVA: 0x00003749 File Offset: 0x00001949
		[global::Cpp2ILInjected.Token(Token = "0x60002C9")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D79E48", Offset = "0x1D79E48", Length = "0x88")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl), Member = "AddDefaultAttributesAndNormalize", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseAttributes", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlTextReaderImpl), Member = "LookupNamespace", MemberParameters = new object[] { typeof(XmlTextReaderImpl.NodeData) }, ReturnType = typeof(string))]
		private void AttributeNamespaceLookup()
		{
			throw null;
		}

		// Token: 0x060002BD RID: 701 RVA: 0x0000374C File Offset: 0x0000194C
		[global::Cpp2ILInjected.Token(Token = "0x60002CA")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D7AE2C", Offset = "0x1D7AE2C", Length = "0x2CC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseAttributes", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new object[]
		{
			typeof(Array),
			typeof(int),
			typeof(Array),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Array), Member = "Sort", MemberTypeParameters = new object[] { "T" }, MemberParameters = new object[]
		{
			"T[]",
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Ref), Member = "Equal", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlTextReaderImpl.NodeData), Member = "GetNameWPrefix", MemberParameters = new object[] { typeof(XmlNameTable) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlTextReaderImpl.NodeData), Member = "get_LineNo", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlTextReaderImpl.NodeData), Member = "get_LinePos", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlTextReaderImpl), Member = "Throw", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		private void AttributeDuplCheck()
		{
			throw null;
		}

		// Token: 0x060002BE RID: 702 RVA: 0x0000374F File Offset: 0x0000194F
		[global::Cpp2ILInjected.Token(Token = "0x60002CB")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D7AAE8", Offset = "0x1D7AAE8", Length = "0xF0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseAttributes", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl), Member = "AddDefaultAttributeInternal", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(string),
			typeof(string),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(bool)
		}, ReturnType = typeof(XmlTextReaderImpl.NodeData))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlTextReaderImpl.NodeData), Member = "get_StringValue", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlTextReaderImpl), Member = "PushXmlContext", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlTextReaderImpl), Member = "AddNamespace", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(XmlTextReaderImpl.NodeData)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private void OnDefaultNamespaceDecl(XmlTextReaderImpl.NodeData attr)
		{
			throw null;
		}

		// Token: 0x060002BF RID: 703 RVA: 0x00003752 File Offset: 0x00001952
		[global::Cpp2ILInjected.Token(Token = "0x60002CC")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D7ABD8", Offset = "0x1D7ABD8", Length = "0xA8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseAttributes", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl), Member = "AddDefaultAttributeInternal", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(string),
			typeof(string),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(bool)
		}, ReturnType = typeof(XmlTextReaderImpl.NodeData))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlTextReaderImpl.NodeData), Member = "get_StringValue", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlTextReaderImpl), Member = "AddNamespace", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(XmlTextReaderImpl.NodeData)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlTextReaderImpl), Member = "Throw", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		private void OnNamespaceDecl(XmlTextReaderImpl.NodeData attr)
		{
			throw null;
		}

		// Token: 0x060002C0 RID: 704 RVA: 0x00003755 File Offset: 0x00001955
		[global::Cpp2ILInjected.Token(Token = "0x60002CD")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D7AC80", Offset = "0x1D7AC80", Length = "0x1AC")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseAttributes", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl), Member = "AddDefaultAttributeInternal", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(string),
			typeof(string),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(bool)
		}, ReturnType = typeof(XmlTextReaderImpl.NodeData))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlTextReaderImpl), Member = "PushXmlContext", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlTextReaderImpl.NodeData), Member = "get_StringValue", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlConvert), Member = "TrimString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlTextReaderImpl), Member = "Throw", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		private void OnXmlReservedAttribute(XmlTextReaderImpl.NodeData attr)
		{
			throw null;
		}

		// Token: 0x060002C1 RID: 705 RVA: 0x00003758 File Offset: 0x00001958
		[global::Cpp2ILInjected.Token(Token = "0x60002CE")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D7A260", Offset = "0x1D7A260", Length = "0x888")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseAttributes", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseFragmentAttribute", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlTextReaderImpl.ParsingState), Member = "get_LinePos", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LineInfo), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new object[]
		{
			typeof(char[]),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(StringBuilder))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlTextReaderImpl), Member = "HandleEntityReference", MemberParameters = new object[]
		{
			typeof(bool),
			typeof(XmlTextReaderImpl.EntityExpandType),
			typeof(ref int)
		}, ReturnType = typeof(XmlTextReaderImpl.EntityType))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = "get_Length", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlTextReaderImpl.NodeData), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = "ToString", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlTextReaderImpl.NodeData), Member = "SetValueNode", MemberParameters = new object[]
		{
			typeof(XmlNodeType),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlTextReaderImpl), Member = "ParseEntityName", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlTextReaderImpl.NodeData), Member = "SetNamedNode", MemberParameters = new object[]
		{
			typeof(XmlNodeType),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(StringBuilder))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(StringBuilder))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LineInfo), Member = "Set", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlCharType), Member = "IsHighSurrogate", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlTextReaderImpl), Member = "ReadData", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlCharType), Member = "IsLowSurrogate", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlTextReaderImpl), Member = "HandleEntityEnd", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlTextReaderImpl.NodeData), Member = "SetValue", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = "set_Length", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlException), Member = "BuildCharExceptionArgs", MemberParameters = new object[]
		{
			typeof(char),
			typeof(char)
		}, ReturnType = typeof(string[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlTextReaderImpl), Member = "Throw", MemberParameters = new object[]
		{
			typeof(int),
			typeof(string),
			typeof(string[])
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlTextReaderImpl), Member = "ThrowInvalidChar", MemberParameters = new object[]
		{
			typeof(char[]),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlTextReaderImpl), Member = "Throw", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 15)]
		private void ParseAttributeValueSlow(int curPos, char quoteChar, XmlTextReaderImpl.NodeData attr)
		{
			throw null;
		}

		// Token: 0x060002C2 RID: 706 RVA: 0x0000375B File Offset: 0x0000195B
		[global::Cpp2ILInjected.Token(Token = "0x60002CF")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D7B3EC", Offset = "0x1D7B3EC", Length = "0x20")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private void AddAttributeChunkToList(XmlTextReaderImpl.NodeData attr, XmlTextReaderImpl.NodeData chunk, ref XmlTextReaderImpl.NodeData lastChunk)
		{
			throw null;
		}

		// Token: 0x060002C3 RID: 707 RVA: 0x0000375E File Offset: 0x0000195E
		[global::Cpp2ILInjected.Token(Token = "0x60002D0")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D77EB8", Offset = "0x1D77EB8", Length = "0x398")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseDocumentContent", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseElementContent", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlTextReaderImpl), Member = "ParseText", MemberParameters = new object[]
		{
			typeof(ref int),
			typeof(ref int),
			typeof(ref int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlTextReaderImpl), Member = "SetupEndEntityNodeInContent", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlTextReaderImpl.ParsingState), Member = "get_LinePos", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlTextReaderImpl.NodeData), Member = "SetLineInfo", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlTextReaderImpl), Member = "ParseEntityReference", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new object[]
		{
			typeof(char[]),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(StringBuilder))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = "get_Length", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlTextReaderImpl.NodeData), Member = "SetValueNode", MemberParameters = new object[]
		{
			typeof(XmlNodeType),
			typeof(char[]),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = "set_Length", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlTextReaderImpl.NodeData), Member = "SetValueNode", MemberParameters = new object[]
		{
			typeof(XmlNodeType),
			typeof(string)
		}, ReturnType = typeof(void))]
		private bool ParseText()
		{
			throw null;
		}

		// Token: 0x060002C4 RID: 708 RVA: 0x00003761 File Offset: 0x00001961
		[global::Cpp2ILInjected.Token(Token = "0x60002D1")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D7B52C", Offset = "0x1D7B52C", Length = "0x524")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseText", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl), Member = "FinishPartialValue", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl), Member = "SkipPartialTextValue", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 7)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlCharType), Member = "IsHighSurrogate", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlCharType), Member = "IsLowSurrogate", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlTextReaderImpl), Member = "ParseCharRefInline", MemberParameters = new object[]
		{
			typeof(int),
			typeof(ref int),
			typeof(ref XmlTextReaderImpl.EntityType)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Buffer), Member = "BlockCopy", MemberParameters = new object[]
		{
			typeof(Array),
			typeof(int),
			typeof(Array),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlCharType), Member = "IsWhiteSpace", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlTextReaderImpl), Member = "ReadData", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlTextReaderImpl), Member = "HandleEntityEnd", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlTextReaderImpl), Member = "HandleEntityReference", MemberParameters = new object[]
		{
			typeof(bool),
			typeof(XmlTextReaderImpl.EntityExpandType),
			typeof(ref int)
		}, ReturnType = typeof(XmlTextReaderImpl.EntityType))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlTextReaderImpl), Member = "ZeroEndingStream", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlTextReaderImpl), Member = "Throw", MemberParameters = new object[]
		{
			typeof(int),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlTextReaderImpl), Member = "Throw", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlTextReaderImpl), Member = "ThrowInvalidChar", MemberParameters = new object[]
		{
			typeof(char[]),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private bool ParseText(out int startPos, out int endPos, ref int outOrChars)
		{
			throw null;
		}

		// Token: 0x060002C5 RID: 709 RVA: 0x00003764 File Offset: 0x00001964
		[global::Cpp2ILInjected.Token(Token = "0x60002D2")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D70678", Offset = "0x1D70678", Length = "0x9C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl), Member = "get_Value", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl), Member = "FinishOtherValueIterator", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlTextReaderImpl.NodeData), Member = "CopyTo", MemberParameters = new object[]
		{
			typeof(int),
			typeof(StringBuilder)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlTextReaderImpl), Member = "ParseText", MemberParameters = new object[]
		{
			typeof(ref int),
			typeof(ref int),
			typeof(ref int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new object[]
		{
			typeof(char[]),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(StringBuilder))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlTextReaderImpl.NodeData), Member = "SetValue", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = "set_Length", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		private void FinishPartialValue()
		{
			throw null;
		}

		// Token: 0x060002C6 RID: 710 RVA: 0x00003767 File Offset: 0x00001967
		[global::Cpp2ILInjected.Token(Token = "0x60002D3")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D70714", Offset = "0x1D70714", Length = "0x100")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl), Member = "get_Value", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlTextReaderImpl), Member = "FinishPartialValue", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlTextReaderImpl.NodeData), Member = "get_StringValue", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Substring", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlTextReaderImpl.NodeData), Member = "SetValue", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		private void FinishOtherValueIterator()
		{
			throw null;
		}

		// Token: 0x060002C7 RID: 711 RVA: 0x0000376A File Offset: 0x0000196A
		[global::Cpp2ILInjected.Token(Token = "0x60002D4")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D729A0", Offset = "0x1D729A0", Length = "0x40")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl), Member = "Read", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ReadAttributeValue", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl), Member = "FinishAttributeValueIterator", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl), Member = "FinishReadValueChunk", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl), Member = "FinishReadContentAsBinary", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlTextReaderImpl), Member = "ParseText", MemberParameters = new object[]
		{
			typeof(ref int),
			typeof(ref int),
			typeof(ref int)
		}, ReturnType = typeof(bool))]
		[MethodImpl(8)]
		private void SkipPartialTextValue()
		{
			throw null;
		}

		// Token: 0x060002C8 RID: 712 RVA: 0x0000376D File Offset: 0x0000196D
		[global::Cpp2ILInjected.Token(Token = "0x60002D5")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D729E0", Offset = "0x1D729E0", Length = "0x20")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlTextReaderImpl), Member = "SkipPartialTextValue", ReturnType = typeof(void))]
		private void FinishReadValueChunk()
		{
			throw null;
		}

		// Token: 0x060002C9 RID: 713 RVA: 0x00003770 File Offset: 0x00001970
		[global::Cpp2ILInjected.Token(Token = "0x60002D6")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D72A00", Offset = "0x1D72A00", Length = "0x50")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl), Member = "Read", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ReadAttributeValue", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl), Member = "FinishAttributeValueIterator", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl), Member = "FinishReadElementContentAsBinary", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlTextReaderImpl), Member = "SkipPartialTextValue", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlTextReaderImpl), Member = "MoveToNextContentNode", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(bool))]
		private void FinishReadContentAsBinary()
		{
			throw null;
		}

		// Token: 0x060002CA RID: 714 RVA: 0x00003773 File Offset: 0x00001973
		[global::Cpp2ILInjected.Token(Token = "0x60002D7")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D72A50", Offset = "0x1D72A50", Length = "0xB0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl), Member = "Read", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlTextReaderImpl), Member = "FinishReadContentAsBinary", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Enum), Member = "ToString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlTextReaderImpl), Member = "Throw", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		private void FinishReadElementContentAsBinary()
		{
			throw null;
		}

		// Token: 0x060002CB RID: 715 RVA: 0x00003776 File Offset: 0x00001976
		[global::Cpp2ILInjected.Token(Token = "0x60002D8")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D78250", Offset = "0x1D78250", Length = "0x1AC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseDocumentContent", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlTextReaderImpl), Member = "EatWhitespaces", MemberParameters = new object[] { typeof(StringBuilder) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlTextReaderImpl), Member = "ZeroEndingStream", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlTextReaderImpl.ParsingState), Member = "get_LinePos", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlTextReaderImpl.NodeData), Member = "SetLineInfo", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = "get_Length", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlTextReaderImpl.NodeData), Member = "SetValueNode", MemberParameters = new object[]
		{
			typeof(XmlNodeType),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = "set_Length", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlCharType), Member = "IsCharData", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlTextReaderImpl), Member = "Throw", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlTextReaderImpl), Member = "ThrowInvalidChar", MemberParameters = new object[]
		{
			typeof(char[]),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		private bool ParseRootLevelWhitespace()
		{
			throw null;
		}

		// Token: 0x060002CC RID: 716 RVA: 0x00003779 File Offset: 0x00001979
		[global::Cpp2ILInjected.Token(Token = "0x60002D9")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D725A0", Offset = "0x1D725A0", Length = "0x68")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl), Member = "Read", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseDocumentContent", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseText", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlTextReaderImpl.ParsingState), Member = "get_LinePos", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlTextReaderImpl.NodeData), Member = "SetLineInfo", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlTextReaderImpl), Member = "ParseEntityName", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlTextReaderImpl.NodeData), Member = "SetNamedNode", MemberParameters = new object[]
		{
			typeof(XmlNodeType),
			typeof(string)
		}, ReturnType = typeof(void))]
		private void ParseEntityReference()
		{
			throw null;
		}

		// Token: 0x060002CD RID: 717 RVA: 0x0000377C File Offset: 0x0000197C
		[global::Cpp2ILInjected.Token(Token = "0x60002DA")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D77C3C", Offset = "0x1D77C3C", Length = "0x27C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseDocumentContent", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseAttributeValueSlow", MemberParameters = new object[]
		{
			typeof(int),
			typeof(char),
			typeof(XmlTextReaderImpl.NodeData)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseText", MemberParameters = new object[]
		{
			typeof(ref int),
			typeof(ref int),
			typeof(ref int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseAttributeValueChunk", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlTextReaderImpl), Member = "ReadData", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlTextReaderImpl), Member = "ParseNumericCharRef", MemberParameters = new object[]
		{
			typeof(bool),
			typeof(StringBuilder),
			typeof(ref XmlTextReaderImpl.EntityType)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlTextReaderImpl), Member = "ParseNamedCharRef", MemberParameters = new object[]
		{
			typeof(bool),
			typeof(StringBuilder)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlTextReaderImpl.ParsingState), Member = "get_LinePos", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlTextReaderImpl), Member = "ParseQName", MemberParameters = new object[]
		{
			typeof(bool),
			typeof(int),
			typeof(ref int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlTextReaderImpl), Member = "ThrowUnexpectedToken", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlTextReaderImpl), Member = "HandleGeneralEntityReference", MemberParameters = new object[]
		{
			typeof(string),
			typeof(bool),
			typeof(bool),
			typeof(int)
		}, ReturnType = typeof(XmlTextReaderImpl.EntityType))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlTextReaderImpl), Member = "Throw", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlTextReaderImpl), Member = "Throw", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 12)]
		private XmlTextReaderImpl.EntityType HandleEntityReference(bool isInAttributeValue, XmlTextReaderImpl.EntityExpandType expandType, out int charRefEndPos)
		{
			throw null;
		}

		// Token: 0x060002CE RID: 718 RVA: 0x0000377F File Offset: 0x0000197F
		[global::Cpp2ILInjected.Token(Token = "0x60002DB")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D734BC", Offset = "0x1D734BC", Length = "0x474")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ResolveEntity", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl), Member = "HandleEntityReference", MemberParameters = new object[]
		{
			typeof(bool),
			typeof(XmlTextReaderImpl.EntityExpandType),
			typeof(ref int)
		}, ReturnType = typeof(XmlTextReaderImpl.EntityType))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlParserContext), Member = "get_HasDtdInfo", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlTextReaderImpl), Member = "ParseDtdFromParserContext", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlQualifiedName), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SchemaEntity), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(XmlQualifiedName),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SchemaEntity), Member = "set_Text", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlReaderSection), Member = "get_ProhibitDefaultUrlResolver", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlTextReaderImpl), Member = "PushExternalEntity", MemberParameters = new object[] { typeof(IDtdEntityInfo) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlTextReaderImpl), Member = "PushInternalEntity", MemberParameters = new object[] { typeof(IDtdEntityInfo) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlTextReaderImpl), Member = "Throw", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 18)]
		private XmlTextReaderImpl.EntityType HandleGeneralEntityReference(string name, bool isInAttributeValue, bool pushFakeEntityIfNullResolver, int entityStartLinePos)
		{
			throw null;
		}

		// Token: 0x1700009D RID: 157
		// (get) Token: 0x060002CF RID: 719 RVA: 0x00003782 File Offset: 0x00001982
		[global::Cpp2ILInjected.Token(Token = "0x170000A2")]
		private bool InEntity
		{
			[global::Cpp2ILInjected.Token(Token = "0x60002DC")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D77094", Offset = "0x1D77094", Length = "0x10")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x060002D0 RID: 720 RVA: 0x00003785 File Offset: 0x00001985
		[global::Cpp2ILInjected.Token(Token = "0x60002DD")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D76384", Offset = "0x1D76384", Length = "0xF8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl), Member = "FinishAttributeValueIterator", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseDocumentContent", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseElementContent", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseAttributeValueSlow", MemberParameters = new object[]
		{
			typeof(int),
			typeof(char),
			typeof(XmlTextReaderImpl.NodeData)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseText", MemberParameters = new object[]
		{
			typeof(ref int),
			typeof(ref int),
			typeof(ref int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseAttributeValueChunk", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 6)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlTextReaderImpl), Member = "PopEntity", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlTextReaderImpl), Member = "Throw", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private bool HandleEntityEnd(bool checkEntityNesting)
		{
			throw null;
		}

		// Token: 0x060002D1 RID: 721 RVA: 0x00003788 File Offset: 0x00001988
		[global::Cpp2ILInjected.Token(Token = "0x60002DE")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D72608", Offset = "0x1D72608", Length = "0x120")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl), Member = "Read", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseDocumentContent", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseElementContent", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseText", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlTextReaderImpl.NodeData), Member = "SetNamedNode", MemberParameters = new object[]
		{
			typeof(XmlNodeType),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlTextReaderImpl.ParsingState), Member = "get_LinePos", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LineInfo), Member = "Set", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private void SetupEndEntityNodeInContent()
		{
			throw null;
		}

		// Token: 0x060002D2 RID: 722 RVA: 0x0000378B File Offset: 0x0000198B
		[global::Cpp2ILInjected.Token(Token = "0x60002DF")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D7BC14", Offset = "0x1D7BC14", Length = "0x40")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private void SetupEndEntityNodeInAttribute()
		{
			throw null;
		}

		// Token: 0x060002D3 RID: 723 RVA: 0x0000378E File Offset: 0x0000198E
		[global::Cpp2ILInjected.Token(Token = "0x60002E0")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D77560", Offset = "0x1D77560", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlTextReaderImpl), Member = "ParsePI", MemberParameters = new object[] { typeof(StringBuilder) }, ReturnType = typeof(bool))]
		private bool ParsePI()
		{
			throw null;
		}

		// Token: 0x060002D4 RID: 724 RVA: 0x00003791 File Offset: 0x00001991
		[global::Cpp2ILInjected.Token(Token = "0x60002E1")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D74280", Offset = "0x1D74280", Length = "0x314")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl), Member = "DtdParserProxy_ParsePI", MemberParameters = new object[] { typeof(StringBuilder) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseDocumentContent", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseElementContent", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParsePI", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlTextReaderImpl.ParsingState), Member = "get_LinePos", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlTextReaderImpl.NodeData), Member = "SetLineInfo", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlTextReaderImpl), Member = "ParseQName", MemberParameters = new object[]
		{
			typeof(bool),
			typeof(int),
			typeof(ref int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Compare", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(StringComparison)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(StringBuilder))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlTextReaderImpl.NodeData), Member = "SetNamedNode", MemberParameters = new object[]
		{
			typeof(XmlNodeType),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlTextReaderImpl), Member = "EatWhitespaces", MemberParameters = new object[] { typeof(StringBuilder) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlTextReaderImpl), Member = "ReadData", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlTextReaderImpl), Member = "ParsePIValue", MemberParameters = new object[]
		{
			typeof(ref int),
			typeof(ref int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new object[]
		{
			typeof(char[]),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(StringBuilder))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlTextReaderImpl.NodeData), Member = "SetValue", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = "set_Length", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlTextReaderImpl.NodeData), Member = "SetValue", MemberParameters = new object[]
		{
			typeof(char[]),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Equals", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlTextReaderImpl), Member = "Throw", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlException), Member = "BuildCharExceptionArgs", MemberParameters = new object[]
		{
			typeof(char[]),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(string[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlTextReaderImpl), Member = "Throw", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string[])
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		private bool ParsePI(StringBuilder piInDtdStringBuilder)
		{
			throw null;
		}

		// Token: 0x060002D5 RID: 725 RVA: 0x00003794 File Offset: 0x00001994
		[global::Cpp2ILInjected.Token(Token = "0x60002E2")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D7BC54", Offset = "0x1D7BC54", Length = "0x308")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParsePI", MemberParameters = new object[] { typeof(StringBuilder) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl), Member = "IncrementalRead", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlTextReaderImpl), Member = "ReadData", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlCharType), Member = "IsHighSurrogate", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlCharType), Member = "IsLowSurrogate", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Buffer), Member = "BlockCopy", MemberParameters = new object[]
		{
			typeof(Array),
			typeof(int),
			typeof(Array),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlTextReaderImpl), Member = "ThrowInvalidChar", MemberParameters = new object[]
		{
			typeof(char[]),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlTextReaderImpl), Member = "Throw", MemberParameters = new object[]
		{
			typeof(int),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private bool ParsePIValue(out int outStartPos, out int outEndPos)
		{
			throw null;
		}

		// Token: 0x060002D6 RID: 726 RVA: 0x00003797 File Offset: 0x00001997
		[global::Cpp2ILInjected.Token(Token = "0x60002E3")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D77568", Offset = "0x1D77568", Length = "0x54")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseDocumentContent", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseElementContent", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlTextReaderImpl), Member = "ParseCDataOrComment", MemberParameters = new object[] { typeof(XmlNodeType) }, ReturnType = typeof(void))]
		private bool ParseComment()
		{
			throw null;
		}

		// Token: 0x060002D7 RID: 727 RVA: 0x0000379A File Offset: 0x0000199A
		[global::Cpp2ILInjected.Token(Token = "0x60002E4")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D775CC", Offset = "0x1D775CC", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlTextReaderImpl), Member = "ParseCDataOrComment", MemberParameters = new object[] { typeof(XmlNodeType) }, ReturnType = typeof(void))]
		private void ParseCData()
		{
			throw null;
		}

		// Token: 0x060002D8 RID: 728 RVA: 0x0000379D File Offset: 0x0000199D
		[global::Cpp2ILInjected.Token(Token = "0x60002E5")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D7471C", Offset = "0x1D7471C", Length = "0x12C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl), Member = "DtdParserProxy_ParseComment", MemberParameters = new object[] { typeof(StringBuilder) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseDocumentContent", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseElementContent", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseComment", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseCData", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 7)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlTextReaderImpl), Member = "ParseCDataOrComment", MemberParameters = new object[]
		{
			typeof(XmlNodeType),
			typeof(ref int),
			typeof(ref int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlTextReaderImpl.ParsingState), Member = "get_LinePos", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlTextReaderImpl.NodeData), Member = "SetLineInfo", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlTextReaderImpl.NodeData), Member = "SetValueNode", MemberParameters = new object[]
		{
			typeof(XmlNodeType),
			typeof(char[]),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new object[]
		{
			typeof(char[]),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(StringBuilder))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlTextReaderImpl.NodeData), Member = "SetValueNode", MemberParameters = new object[]
		{
			typeof(XmlNodeType),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = "set_Length", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		private void ParseCDataOrComment(XmlNodeType type)
		{
			throw null;
		}

		// Token: 0x060002D9 RID: 729 RVA: 0x000037A0 File Offset: 0x000019A0
		[global::Cpp2ILInjected.Token(Token = "0x60002E6")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D7BF5C", Offset = "0x1D7BF5C", Length = "0x390")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseCDataOrComment", MemberParameters = new object[] { typeof(XmlNodeType) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl), Member = "IncrementalRead", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlTextReaderImpl), Member = "ReadData", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlCharType), Member = "IsHighSurrogate", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlCharType), Member = "IsLowSurrogate", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Buffer), Member = "BlockCopy", MemberParameters = new object[]
		{
			typeof(Array),
			typeof(int),
			typeof(Array),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlTextReaderImpl), Member = "Throw", MemberParameters = new object[]
		{
			typeof(int),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlTextReaderImpl), Member = "ThrowInvalidChar", MemberParameters = new object[]
		{
			typeof(char[]),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlTextReaderImpl), Member = "Throw", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		private bool ParseCDataOrComment(XmlNodeType type, out int outStartPos, out int outEndPos)
		{
			throw null;
		}

		// Token: 0x060002DA RID: 730 RVA: 0x000037A3 File Offset: 0x000019A3
		[global::Cpp2ILInjected.Token(Token = "0x60002E7")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D775D4", Offset = "0x1D775D4", Length = "0x260")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseDocumentContent", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlTextReaderImpl), Member = "ReadData", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlTextReaderImpl), Member = "Throw", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlConvert), Member = "StrEqual", MemberParameters = new object[]
		{
			typeof(char[]),
			typeof(int),
			typeof(int),
			typeof(string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlTextReaderImpl), Member = "ThrowUnexpectedToken", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlCharType), Member = "IsWhiteSpace", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlTextReaderImpl), Member = "ThrowExpectingWhitespace", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlTextReaderImpl), Member = "EatWhitespaces", MemberParameters = new object[] { typeof(StringBuilder) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlTextReaderImpl.ParsingState), Member = "get_LinePos", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlTextReaderImpl.NodeData), Member = "SetLineInfo", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlTextReaderImpl), Member = "ParseDtd", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlTextReaderImpl), Member = "SkipDtd", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlTextReaderImpl), Member = "ThrowWithoutLineInfo", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlTextReaderImpl), Member = "Throw", MemberParameters = new object[]
		{
			typeof(int),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
		private bool ParseDoctypeDecl()
		{
			throw null;
		}

		// Token: 0x060002DB RID: 731 RVA: 0x000037A6 File Offset: 0x000019A6
		[global::Cpp2ILInjected.Token(Token = "0x60002E8")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D7C2EC", Offset = "0x1D7C2EC", Length = "0x2F4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseDoctypeDecl", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DtdParser), Member = "Create", ReturnType = typeof(IDtdParser))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlTextReaderImpl.DtdParserProxy), Member = ".ctor", MemberParameters = new object[] { typeof(XmlTextReaderImpl) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlTextReaderImpl.NodeData), Member = "SetNamedNode", MemberParameters = new object[]
		{
			typeof(XmlNodeType),
			typeof(string),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlTextReaderImpl.NodeData), Member = "SetValue", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
		private void ParseDtd()
		{
			throw null;
		}

		// Token: 0x060002DC RID: 732 RVA: 0x000037A9 File Offset: 0x000019A9
		[global::Cpp2ILInjected.Token(Token = "0x60002E9")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D7C5E0", Offset = "0x1D7C5E0", Length = "0x318")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseDoctypeDecl", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlTextReaderImpl), Member = "ParseQName", MemberParameters = new object[]
		{
			typeof(bool),
			typeof(int),
			typeof(ref int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlTextReaderImpl), Member = "EatWhitespaces", MemberParameters = new object[] { typeof(StringBuilder) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlTextReaderImpl), Member = "ReadData", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlConvert), Member = "StrEqual", MemberParameters = new object[]
		{
			typeof(char[]),
			typeof(int),
			typeof(int),
			typeof(string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlTextReaderImpl), Member = "ThrowUnexpectedToken", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlTextReaderImpl), Member = "ThrowExpectingWhitespace", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlTextReaderImpl), Member = "SkipPublicOrSystemIdLiteral", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlTextReaderImpl), Member = "SkipUntil", MemberParameters = new object[]
		{
			typeof(char),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlTextReaderImpl.NodeData), Member = "SetValue", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlTextReaderImpl), Member = "Throw", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
		private void SkipDtd()
		{
			throw null;
		}

		// Token: 0x060002DD RID: 733 RVA: 0x000037AC File Offset: 0x000019AC
		[global::Cpp2ILInjected.Token(Token = "0x60002EA")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D7C8F8", Offset = "0x1D7C8F8", Length = "0x9C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl), Member = "SkipDtd", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlTextReaderImpl), Member = "ThrowUnexpectedToken", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private void SkipPublicOrSystemIdLiteral()
		{
			throw null;
		}

		// Token: 0x060002DE RID: 734 RVA: 0x000037AF File Offset: 0x000019AF
		[global::Cpp2ILInjected.Token(Token = "0x60002EB")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D7C994", Offset = "0x1D7C994", Length = "0x400")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl), Member = "SkipDtd", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlCharType), Member = "IsHighSurrogate", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlTextReaderImpl), Member = "ReadData", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlCharType), Member = "IsLowSurrogate", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlTextReaderImpl), Member = "Throw", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlTextReaderImpl), Member = "ThrowInvalidChar", MemberParameters = new object[]
		{
			typeof(char[]),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		private void SkipUntil(char stopChar, bool recognizeLiterals)
		{
			throw null;
		}

		// Token: 0x060002DF RID: 735 RVA: 0x000037B2 File Offset: 0x000019B2
		[global::Cpp2ILInjected.Token(Token = "0x60002EC")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D75644", Offset = "0x1D75644", Length = "0x200")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl), Member = "DtdParserProxy_PushExternalSubset", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseXmlDeclaration", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseAttributes", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseRootLevelWhitespace", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParsePI", MemberParameters = new object[] { typeof(StringBuilder) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseDoctypeDecl", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl), Member = "SkipDtd", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl), Member = "PushExternalEntity", MemberParameters = new object[] { typeof(IDtdEntityInfo) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl), Member = "IncrementalRead", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 17)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new object[]
		{
			typeof(char[]),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(StringBuilder))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlTextReaderImpl), Member = "ReadData", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlTextReaderImpl), Member = "Throw", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		private int EatWhitespaces(StringBuilder sb)
		{
			throw null;
		}

		// Token: 0x060002E0 RID: 736 RVA: 0x000037B5 File Offset: 0x000019B5
		[global::Cpp2ILInjected.Token(Token = "0x60002ED")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D7BA98", Offset = "0x1D7BA98", Length = "0x48")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseText", MemberParameters = new object[]
		{
			typeof(ref int),
			typeof(ref int),
			typeof(ref int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlTextReaderImpl), Member = "ParseNumericCharRefInline", MemberParameters = new object[]
		{
			typeof(int),
			typeof(bool),
			typeof(StringBuilder),
			typeof(ref int),
			typeof(ref XmlTextReaderImpl.EntityType)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlTextReaderImpl), Member = "ParseNamedCharRefInline", MemberParameters = new object[]
		{
			typeof(int),
			typeof(bool),
			typeof(StringBuilder)
		}, ReturnType = typeof(int))]
		private int ParseCharRefInline(int startPos, out int charCount, out XmlTextReaderImpl.EntityType entityType)
		{
			throw null;
		}

		// Token: 0x060002E1 RID: 737 RVA: 0x000037B8 File Offset: 0x000019B8
		[global::Cpp2ILInjected.Token(Token = "0x60002EE")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D74124", Offset = "0x1D74124", Length = "0xAC")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl), Member = "DtdParserProxy_ParseNumericCharRef", MemberParameters = new object[] { typeof(StringBuilder) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl), Member = "HandleEntityReference", MemberParameters = new object[]
		{
			typeof(bool),
			typeof(XmlTextReaderImpl.EntityExpandType),
			typeof(ref int)
		}, ReturnType = typeof(XmlTextReaderImpl.EntityType))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlTextReaderImpl), Member = "ParseNumericCharRefInline", MemberParameters = new object[]
		{
			typeof(int),
			typeof(bool),
			typeof(StringBuilder),
			typeof(ref int),
			typeof(ref XmlTextReaderImpl.EntityType)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlTextReaderImpl), Member = "ReadData", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlTextReaderImpl), Member = "Throw", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		private int ParseNumericCharRef(bool expand, StringBuilder internalSubsetBuilder, out XmlTextReaderImpl.EntityType entityType)
		{
			throw null;
		}

		// Token: 0x060002E2 RID: 738 RVA: 0x000037BB File Offset: 0x000019BB
		[global::Cpp2ILInjected.Token(Token = "0x60002EF")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D7CD94", Offset = "0x1D7CD94", Length = "0x51C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseCharRefInline", MemberParameters = new object[]
		{
			typeof(int),
			typeof(ref int),
			typeof(ref XmlTextReaderImpl.EntityType)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseNumericCharRef", MemberParameters = new object[]
		{
			typeof(bool),
			typeof(StringBuilder),
			typeof(ref XmlTextReaderImpl.EntityType)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlCharType), Member = "SplitSurrogateChar", MemberParameters = new object[]
		{
			typeof(int),
			typeof(ref char),
			typeof(ref char)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlCharType), Member = "IsHighSurrogate", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlCharType), Member = "IsLowSurrogate", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new object[]
		{
			typeof(char[]),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(StringBuilder))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlCharType), Member = "IsCharData", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlTextReaderImpl), Member = "Throw", MemberParameters = new object[]
		{
			typeof(int),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlException), Member = "BuildCharExceptionArgs", MemberParameters = new object[]
		{
			typeof(char),
			typeof(char)
		}, ReturnType = typeof(string[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlTextReaderImpl), Member = "Throw", MemberParameters = new object[]
		{
			typeof(int),
			typeof(string),
			typeof(string[])
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlTextReaderImpl), Member = "Throw", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(Exception)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 38)]
		private int ParseNumericCharRefInline(int startPos, bool expand, StringBuilder internalSubsetBuilder, out int charCount, out XmlTextReaderImpl.EntityType entityType)
		{
			throw null;
		}

		// Token: 0x060002E3 RID: 739 RVA: 0x000037BE File Offset: 0x000019BE
		[global::Cpp2ILInjected.Token(Token = "0x60002F0")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D741D8", Offset = "0x1D741D8", Length = "0x64")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl), Member = "HandleEntityReference", MemberParameters = new object[]
		{
			typeof(bool),
			typeof(XmlTextReaderImpl.EntityExpandType),
			typeof(ref int)
		}, ReturnType = typeof(XmlTextReaderImpl.EntityType))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlTextReaderImpl), Member = "ParseNamedCharRefInline", MemberParameters = new object[]
		{
			typeof(int),
			typeof(bool),
			typeof(StringBuilder)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlTextReaderImpl), Member = "ReadData", ReturnType = typeof(int))]
		private int ParseNamedCharRef(bool expand, StringBuilder internalSubsetBuilder)
		{
			throw null;
		}

		// Token: 0x060002E4 RID: 740 RVA: 0x000037C1 File Offset: 0x000019C1
		[global::Cpp2ILInjected.Token(Token = "0x60002F1")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D7D2B0", Offset = "0x1D7D2B0", Length = "0x244")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseCharRefInline", MemberParameters = new object[]
		{
			typeof(int),
			typeof(ref int),
			typeof(ref XmlTextReaderImpl.EntityType)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseNamedCharRef", MemberParameters = new object[]
		{
			typeof(bool),
			typeof(StringBuilder)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new object[]
		{
			typeof(char[]),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(StringBuilder))]
		private int ParseNamedCharRefInline(int startPos, bool expand, StringBuilder internalSubsetBuilder)
		{
			throw null;
		}

		// Token: 0x060002E5 RID: 741 RVA: 0x000037C4 File Offset: 0x000019C4
		[global::Cpp2ILInjected.Token(Token = "0x60002F2")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D7741C", Offset = "0x1D7741C", Length = "0x20")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlTextReaderImpl), Member = "ParseQName", MemberParameters = new object[]
		{
			typeof(bool),
			typeof(int),
			typeof(ref int)
		}, ReturnType = typeof(int))]
		private int ParseName()
		{
			throw null;
		}

		// Token: 0x060002E6 RID: 742 RVA: 0x000037C7 File Offset: 0x000019C7
		[global::Cpp2ILInjected.Token(Token = "0x60002F3")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D788A8", Offset = "0x1D788A8", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ThrowTagMismatch", MemberParameters = new object[] { typeof(XmlTextReaderImpl.NodeData) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlTextReaderImpl), Member = "ParseQName", MemberParameters = new object[]
		{
			typeof(bool),
			typeof(int),
			typeof(ref int)
		}, ReturnType = typeof(int))]
		private int ParseQName(out int colonPos)
		{
			throw null;
		}

		// Token: 0x060002E7 RID: 743 RVA: 0x000037CA File Offset: 0x000019CA
		[global::Cpp2ILInjected.Token(Token = "0x60002F4")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D7D4F4", Offset = "0x1D7D4F4", Length = "0x21C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseXmlDeclaration", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseElement", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseAttributes", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl), Member = "HandleEntityReference", MemberParameters = new object[]
		{
			typeof(bool),
			typeof(XmlTextReaderImpl.EntityExpandType),
			typeof(ref int)
		}, ReturnType = typeof(XmlTextReaderImpl.EntityType))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParsePI", MemberParameters = new object[] { typeof(StringBuilder) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl), Member = "SkipDtd", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseName", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseQName", MemberParameters = new object[] { typeof(ref int) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseEntityName", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl), Member = "IncrementalRead", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 11)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlTextReaderImpl), Member = "ReadData", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlTextReaderImpl), Member = "Throw", MemberParameters = new object[]
		{
			typeof(int),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlException), Member = "BuildCharExceptionArgs", MemberParameters = new object[]
		{
			typeof(char[]),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(string[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlTextReaderImpl), Member = "Throw", MemberParameters = new object[]
		{
			typeof(int),
			typeof(string),
			typeof(string[])
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlException), Member = "BuildCharExceptionArgs", MemberParameters = new object[]
		{
			typeof(char),
			typeof(char)
		}, ReturnType = typeof(string[]))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		private int ParseQName(bool isQName, int startOffset, out int colonPos)
		{
			throw null;
		}

		// Token: 0x060002E8 RID: 744 RVA: 0x000037CD File Offset: 0x000019CD
		[global::Cpp2ILInjected.Token(Token = "0x60002F5")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D7D710", Offset = "0x1D7D710", Length = "0x40")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlTextReaderImpl), Member = "ReadData", ReturnType = typeof(int))]
		private bool ReadDataInName(ref int pos)
		{
			throw null;
		}

		// Token: 0x060002E9 RID: 745 RVA: 0x000037D0 File Offset: 0x000019D0
		[global::Cpp2ILInjected.Token(Token = "0x60002F6")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D7B40C", Offset = "0x1D7B40C", Length = "0x120")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseAttributeValueSlow", MemberParameters = new object[]
		{
			typeof(int),
			typeof(char),
			typeof(XmlTextReaderImpl.NodeData)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseEntityReference", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseAttributeValueChunk", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlTextReaderImpl), Member = "ParseQName", MemberParameters = new object[]
		{
			typeof(bool),
			typeof(int),
			typeof(ref int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlTextReaderImpl), Member = "Throw", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 11)]
		private string ParseEntityName()
		{
			throw null;
		}

		// Token: 0x060002EA RID: 746 RVA: 0x000037D3 File Offset: 0x000019D3
		[global::Cpp2ILInjected.Token(Token = "0x60002F7")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D72544", Offset = "0x1D72544", Length = "0x20")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlTextReaderImpl), Member = "AllocNode", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(XmlTextReaderImpl.NodeData))]
		private XmlTextReaderImpl.NodeData AddNode(int nodeIndex, int nodeDepth)
		{
			throw null;
		}

		// Token: 0x060002EB RID: 747 RVA: 0x000037D6 File Offset: 0x000019D6
		[global::Cpp2ILInjected.Token(Token = "0x60002F8")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D7D750", Offset = "0x1D7D750", Length = "0x108")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl), Member = "Read", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ReadAttributeValue", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl), Member = "DtdParserProxy_ParseComment", MemberParameters = new object[] { typeof(StringBuilder) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl), Member = "AddNode", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(XmlTextReaderImpl.NodeData))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl), Member = "AddAttributeNoChecks", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int)
		}, ReturnType = typeof(XmlTextReaderImpl.NodeData))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl), Member = "AddAttribute", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(XmlTextReaderImpl.NodeData))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseAttributeValueChunk", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 10)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new object[]
		{
			typeof(Array),
			typeof(int),
			typeof(Array),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlTextReaderImpl.NodeData), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		private XmlTextReaderImpl.NodeData AllocNode(int nodeIndex, int nodeDepth)
		{
			throw null;
		}

		// Token: 0x060002EC RID: 748 RVA: 0x000037D9 File Offset: 0x000019D9
		[global::Cpp2ILInjected.Token(Token = "0x60002F9")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D75B64", Offset = "0x1D75B64", Length = "0x8C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl), Member = "DtdParserProxy_OnSystemId", MemberParameters = new object[]
		{
			typeof(string),
			typeof(LineInfo),
			typeof(LineInfo)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl), Member = "DtdParserProxy_OnPublicId", MemberParameters = new object[]
		{
			typeof(string),
			typeof(LineInfo),
			typeof(LineInfo)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseXmlDeclaration", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlTextReaderImpl), Member = "AllocNode", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(XmlTextReaderImpl.NodeData))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlTextReaderImpl.NodeData), Member = "SetNamedNode", MemberParameters = new object[]
		{
			typeof(XmlNodeType),
			typeof(string)
		}, ReturnType = typeof(void))]
		private XmlTextReaderImpl.NodeData AddAttributeNoChecks(string name, int attrDepth)
		{
			throw null;
		}

		// Token: 0x060002ED RID: 749 RVA: 0x000037DC File Offset: 0x000019DC
		[global::Cpp2ILInjected.Token(Token = "0x60002FA")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D7A0D8", Offset = "0x1D7A0D8", Length = "0x188")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseAttributes", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlConvert), Member = "StrEqual", MemberParameters = new object[]
		{
			typeof(char[]),
			typeof(int),
			typeof(int),
			typeof(string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlTextReaderImpl), Member = "AddAttribute", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(XmlTextReaderImpl.NodeData))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		private XmlTextReaderImpl.NodeData AddAttribute(int endNamePos, int colonPos)
		{
			throw null;
		}

		// Token: 0x060002EE RID: 750 RVA: 0x000037DF File Offset: 0x000019DF
		[global::Cpp2ILInjected.Token(Token = "0x60002FB")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D7D858", Offset = "0x1D7D858", Length = "0x138")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl), Member = "AddAttribute", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(XmlTextReaderImpl.NodeData))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl), Member = "AddDefaultAttributeInternal", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(string),
			typeof(string),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(bool)
		}, ReturnType = typeof(XmlTextReaderImpl.NodeData))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlTextReaderImpl), Member = "AllocNode", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(XmlTextReaderImpl.NodeData))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlTextReaderImpl.NodeData), Member = "SetNamedNode", MemberParameters = new object[]
		{
			typeof(XmlNodeType),
			typeof(string),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(char))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Ref), Member = "Equal", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(bool))]
		private XmlTextReaderImpl.NodeData AddAttribute(string localName, string prefix, string nameWPrefix)
		{
			throw null;
		}

		// Token: 0x060002EF RID: 751 RVA: 0x000037E2 File Offset: 0x000019E2
		[global::Cpp2ILInjected.Token(Token = "0x60002FC")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D72564", Offset = "0x1D72564", Length = "0x3C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private void PopElementContext()
		{
			throw null;
		}

		// Token: 0x060002F0 RID: 752 RVA: 0x000037E5 File Offset: 0x000019E5
		[global::Cpp2ILInjected.Token(Token = "0x60002FD")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D73D14", Offset = "0x1D73D14", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private void OnNewLine(int pos)
		{
			throw null;
		}

		// Token: 0x060002F1 RID: 753 RVA: 0x000037E8 File Offset: 0x000019E8
		[global::Cpp2ILInjected.Token(Token = "0x60002FE")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D728A8", Offset = "0x1D728A8", Length = "0x6C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl), Member = "Read", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseDocumentContent", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseElementContent", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseFragmentAttribute", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlTextReaderImpl.NodeData), Member = "Clear", MemberParameters = new object[] { typeof(XmlNodeType) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlTextReaderImpl.ParsingState), Member = "get_LinePos", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlTextReaderImpl.NodeData), Member = "SetLineInfo", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		private void OnEof()
		{
			throw null;
		}

		// Token: 0x060002F2 RID: 754 RVA: 0x000037EB File Offset: 0x000019EB
		[global::Cpp2ILInjected.Token(Token = "0x60002FF")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D7B0F8", Offset = "0x1D7B0F8", Length = "0xA0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ElementNamespaceLookup", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl), Member = "AttributeNamespaceLookup", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlTextReaderImpl.NodeData), Member = "get_LineNo", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlTextReaderImpl.NodeData), Member = "get_LinePos", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlTextReaderImpl), Member = "Throw", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		private string LookupNamespace(XmlTextReaderImpl.NodeData node)
		{
			throw null;
		}

		// Token: 0x060002F3 RID: 755 RVA: 0x000037EE File Offset: 0x000019EE
		[global::Cpp2ILInjected.Token(Token = "0x6000300")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D7B204", Offset = "0x1D7B204", Length = "0x1E8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl), Member = "OnDefaultNamespaceDecl", MemberParameters = new object[] { typeof(XmlTextReaderImpl.NodeData) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl), Member = "OnNamespaceDecl", MemberParameters = new object[] { typeof(XmlTextReaderImpl.NodeData) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Ref), Member = "Equal", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlTextReaderImpl), Member = "Throw", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlTextReaderImpl), Member = "Throw", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlTextReaderImpl), Member = "ReThrow", MemberParameters = new object[]
		{
			typeof(Exception),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 14)]
		private void AddNamespace(string prefix, string uri, XmlTextReaderImpl.NodeData attr)
		{
			throw null;
		}

		// Token: 0x060002F4 RID: 756 RVA: 0x000037F1 File Offset: 0x000019F1
		[global::Cpp2ILInjected.Token(Token = "0x6000301")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D724F0", Offset = "0x1D724F0", Length = "0x54")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl), Member = "Read", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl), Member = "Close", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		private void ResetAttributes()
		{
			throw null;
		}

		// Token: 0x060002F5 RID: 757 RVA: 0x000037F4 File Offset: 0x000019F4
		[global::Cpp2ILInjected.Token(Token = "0x6000302")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D7D9A8", Offset = "0x1D7D9A8", Length = "0x44")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private void FullAttributeCleanup()
		{
			throw null;
		}

		// Token: 0x060002F6 RID: 758 RVA: 0x000037F7 File Offset: 0x000019F7
		[global::Cpp2ILInjected.Token(Token = "0x6000303")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D7B198", Offset = "0x1D7B198", Length = "0x6C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl), Member = "OnDefaultNamespaceDecl", MemberParameters = new object[] { typeof(XmlTextReaderImpl.NodeData) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl), Member = "OnXmlReservedAttribute", MemberParameters = new object[] { typeof(XmlTextReaderImpl.NodeData) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlTextReaderImpl.XmlContext), Member = ".ctor", MemberParameters = new object[] { typeof(XmlTextReaderImpl.XmlContext) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private void PushXmlContext()
		{
			throw null;
		}

		// Token: 0x060002F7 RID: 759 RVA: 0x000037FA File Offset: 0x000019FA
		[global::Cpp2ILInjected.Token(Token = "0x6000304")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D7D990", Offset = "0x1D7D990", Length = "0x18")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private void PopXmlContext()
		{
			throw null;
		}

		// Token: 0x060002F8 RID: 760 RVA: 0x000037FD File Offset: 0x000019FD
		[global::Cpp2ILInjected.Token(Token = "0x6000305")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D7BBDC", Offset = "0x1D7BBDC", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private XmlNodeType GetWhitespaceType()
		{
			throw null;
		}

		// Token: 0x060002F9 RID: 761 RVA: 0x00003800 File Offset: 0x00001A00
		[global::Cpp2ILInjected.Token(Token = "0x6000306")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D7BA50", Offset = "0x1D7BA50", Length = "0x48")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private XmlNodeType GetTextNodeType(int orChars)
		{
			throw null;
		}

		// Token: 0x060002FA RID: 762 RVA: 0x00003803 File Offset: 0x00001A03
		[global::Cpp2ILInjected.Token(Token = "0x6000307")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D7530C", Offset = "0x1D7530C", Length = "0x338")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl), Member = "DtdParserProxy_PushExternalSubset", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl), Member = "PushExternalEntity", MemberParameters = new object[] { typeof(IDtdEntityInfo) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlTextReaderImpl), Member = "OpenAndPush", MemberParameters = new object[] { typeof(Uri) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlTextReaderImpl), Member = "ThrowWithoutLineInfo", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string[]),
			typeof(Exception)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlTextReaderImpl), Member = "Throw", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string[]),
			typeof(Exception),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlTextReaderImpl), Member = "Throw", MemberParameters = new object[] { typeof(Exception) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 32)]
		private void PushExternalEntityOrSubset(string publicId, string systemId, Uri baseUri, string entityName)
		{
			throw null;
		}

		// Token: 0x060002FB RID: 763 RVA: 0x00003806 File Offset: 0x00001A06
		[global::Cpp2ILInjected.Token(Token = "0x6000308")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D7D9EC", Offset = "0x1D7D9EC", Length = "0x23C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl), Member = "PushExternalEntityOrSubset", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(Uri),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(RuntimeTypeHandle) }, ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlTextReaderImpl), Member = "PushParsingState", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlTextReaderImpl), Member = "InitTextReaderInput", MemberParameters = new object[]
		{
			typeof(string),
			typeof(Uri),
			typeof(TextReader)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlTextReaderImpl), Member = "InitStreamInput", MemberParameters = new object[]
		{
			typeof(Uri),
			typeof(string),
			typeof(Stream),
			typeof(byte[]),
			typeof(int),
			typeof(Encoding)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
		private bool OpenAndPush(Uri uri)
		{
			throw null;
		}

		// Token: 0x060002FC RID: 764 RVA: 0x00003809 File Offset: 0x00001A09
		[global::Cpp2ILInjected.Token(Token = "0x6000309")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D74A90", Offset = "0x1D74A90", Length = "0x380")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl), Member = "DtdParserProxy_PushEntity", MemberParameters = new object[]
		{
			typeof(IDtdEntityInfo),
			typeof(ref int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl), Member = "HandleGeneralEntityReference", MemberParameters = new object[]
		{
			typeof(string),
			typeof(bool),
			typeof(bool),
			typeof(int)
		}, ReturnType = typeof(XmlTextReaderImpl.EntityType))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlReaderSection), Member = "get_ProhibitDefaultUrlResolver", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlTextReaderImpl), Member = "PushParsingState", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlTextReaderImpl), Member = "InitStringInput", MemberParameters = new object[]
		{
			typeof(string),
			typeof(Encoding),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlTextReaderImpl), Member = "RegisterEntity", MemberParameters = new object[] { typeof(IDtdEntityInfo) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlTextReaderImpl), Member = "RegisterConsumedCharacters", MemberParameters = new object[]
		{
			typeof(long),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlTextReaderImpl), Member = "PushExternalEntityOrSubset", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(Uri),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlTextReaderImpl), Member = "EatWhitespaces", MemberParameters = new object[] { typeof(StringBuilder) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlTextReaderImpl), Member = "ParseXmlDeclaration", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		private bool PushExternalEntity(IDtdEntityInfo entity)
		{
			throw null;
		}

		// Token: 0x060002FD RID: 765 RVA: 0x0000380C File Offset: 0x00001A0C
		[global::Cpp2ILInjected.Token(Token = "0x600030A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D74E10", Offset = "0x1D74E10", Length = "0x310")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl), Member = "DtdParserProxy_PushEntity", MemberParameters = new object[]
		{
			typeof(IDtdEntityInfo),
			typeof(ref int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl), Member = "HandleGeneralEntityReference", MemberParameters = new object[]
		{
			typeof(string),
			typeof(bool),
			typeof(bool),
			typeof(int)
		}, ReturnType = typeof(XmlTextReaderImpl.EntityType))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlTextReaderImpl), Member = "PushParsingState", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlTextReaderImpl), Member = "InitStringInput", MemberParameters = new object[]
		{
			typeof(string),
			typeof(Encoding),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlTextReaderImpl), Member = "RegisterEntity", MemberParameters = new object[] { typeof(IDtdEntityInfo) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlTextReaderImpl), Member = "RegisterConsumedCharacters", MemberParameters = new object[]
		{
			typeof(long),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		private void PushInternalEntity(IDtdEntityInfo entity)
		{
			throw null;
		}

		// Token: 0x060002FE RID: 766 RVA: 0x0000380F File Offset: 0x00001A0F
		[global::Cpp2ILInjected.Token(Token = "0x600030B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D7516C", Offset = "0x1D7516C", Length = "0x80")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl), Member = "DtdParserProxy_PopEntity", MemberParameters = new object[]
		{
			typeof(ref IDtdEntityInfo),
			typeof(ref int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl), Member = "HandleEntityEnd", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlTextReaderImpl), Member = "UnregisterEntity", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlTextReaderImpl.ParsingState), Member = "Close", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		private void PopEntity()
		{
			throw null;
		}

		// Token: 0x060002FF RID: 767 RVA: 0x00003812 File Offset: 0x00001A12
		[global::Cpp2ILInjected.Token(Token = "0x600030C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D7DC28", Offset = "0x1D7DC28", Length = "0x19C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl), Member = "PushExternalEntity", MemberParameters = new object[] { typeof(IDtdEntityInfo) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl), Member = "PushInternalEntity", MemberParameters = new object[] { typeof(IDtdEntityInfo) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, object>), Member = "ContainsKey", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, object>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, object>), Member = "Add", MemberParameters = new object[]
		{
			typeof(object),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlTextReaderImpl.ParsingState), Member = "get_LinePos", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlTextReaderImpl), Member = "Throw", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
		private void RegisterEntity(IDtdEntityInfo entity)
		{
			throw null;
		}

		// Token: 0x06000300 RID: 768 RVA: 0x00003815 File Offset: 0x00001A15
		[global::Cpp2ILInjected.Token(Token = "0x600030D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D7DDC4", Offset = "0x1D7DDC4", Length = "0x5C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl), Member = "PopEntity", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, object>), Member = "Remove", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		private void UnregisterEntity()
		{
			throw null;
		}

		// Token: 0x06000301 RID: 769 RVA: 0x00003818 File Offset: 0x00001A18
		[global::Cpp2ILInjected.Token(Token = "0x600030E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D758A0", Offset = "0x1D758A0", Length = "0xD8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl), Member = "DtdParserProxy_PushInternalDtd", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl), Member = "OpenAndPush", MemberParameters = new object[] { typeof(Uri) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl), Member = "PushExternalEntity", MemberParameters = new object[] { typeof(IDtdEntityInfo) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl), Member = "PushInternalEntity", MemberParameters = new object[] { typeof(IDtdEntityInfo) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new object[]
		{
			typeof(Array),
			typeof(int),
			typeof(Array),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlTextReaderImpl.ParsingState), Member = "Clear", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		private void PushParsingState()
		{
			throw null;
		}

		// Token: 0x06000302 RID: 770 RVA: 0x0000381B File Offset: 0x00001A1B
		[global::Cpp2ILInjected.Token(Token = "0x600030F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D773A0", Offset = "0x1D773A0", Length = "0x54")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlTextReaderImpl.ParsingState), Member = "Close", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		private void PopParsingState()
		{
			throw null;
		}

		// Token: 0x06000303 RID: 771 RVA: 0x0000381E File Offset: 0x00001A1E
		[global::Cpp2ILInjected.Token(Token = "0x6000310")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D7DE20", Offset = "0x1D7DE20", Length = "0x854")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl), Member = "FinishIncrementalRead", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlTextReaderImpl), Member = "ParsePIValue", MemberParameters = new object[]
		{
			typeof(ref int),
			typeof(ref int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlTextReaderImpl), Member = "ReadData", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlTextReaderImpl), Member = "ThrowUnclosedElements", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlTextReaderImpl), Member = "ParseCDataOrComment", MemberParameters = new object[]
		{
			typeof(XmlNodeType),
			typeof(ref int),
			typeof(ref int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlTextReaderImpl.ParsingState), Member = "get_LinePos", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LineInfo), Member = "Set", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlTextReaderImpl), Member = "ParseQName", MemberParameters = new object[]
		{
			typeof(bool),
			typeof(int),
			typeof(ref int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlConvert), Member = "StrEqual", MemberParameters = new object[]
		{
			typeof(char[]),
			typeof(int),
			typeof(int),
			typeof(string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlCharType), Member = "IsWhiteSpace", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlTextReaderImpl.NodeData), Member = "GetNameWPrefix", MemberParameters = new object[] { typeof(XmlNameTable) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlTextReaderImpl), Member = "EatWhitespaces", MemberParameters = new object[] { typeof(StringBuilder) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlTextReaderImpl), Member = "ThrowUnexpectedToken", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlTextReaderImpl), Member = "ReThrow", MemberParameters = new object[]
		{
			typeof(Exception),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 22)]
		private int IncrementalRead()
		{
			throw null;
		}

		// Token: 0x06000304 RID: 772 RVA: 0x00003821 File Offset: 0x00001A21
		[global::Cpp2ILInjected.Token(Token = "0x6000311")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D72728", Offset = "0x1D72728", Length = "0x64")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl), Member = "Read", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(IncrementalReadDummyDecoder), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlTextReaderImpl), Member = "IncrementalRead", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private void FinishIncrementalRead()
		{
			throw null;
		}

		// Token: 0x06000305 RID: 773 RVA: 0x00003824 File Offset: 0x00001A24
		[global::Cpp2ILInjected.Token(Token = "0x6000312")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D7278C", Offset = "0x1D7278C", Length = "0x78")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl), Member = "Read", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlTextReaderImpl), Member = "ParseAttributeValueSlow", MemberParameters = new object[]
		{
			typeof(int),
			typeof(char),
			typeof(XmlTextReaderImpl.NodeData)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlTextReaderImpl), Member = "OnEof", ReturnType = typeof(void))]
		private bool ParseFragmentAttribute()
		{
			throw null;
		}

		// Token: 0x06000306 RID: 774 RVA: 0x00003827 File Offset: 0x00001A27
		[global::Cpp2ILInjected.Token(Token = "0x6000313")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D72E58", Offset = "0x1D72E58", Length = "0x428")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ReadAttributeValue", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlTextReaderImpl), Member = "AllocNode", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(XmlTextReaderImpl.NodeData))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlTextReaderImpl.ParsingState), Member = "get_LinePos", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlTextReaderImpl.NodeData), Member = "SetLineInfo", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlTextReaderImpl.NodeData), Member = "SetValueNode", MemberParameters = new object[]
		{
			typeof(XmlNodeType),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlCharType), Member = "IsHighSurrogate", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlCharType), Member = "IsLowSurrogate", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new object[]
		{
			typeof(char[]),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(StringBuilder))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlTextReaderImpl), Member = "ReadData", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = "get_Length", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlTextReaderImpl), Member = "HandleEntityEnd", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlTextReaderImpl), Member = "HandleEntityReference", MemberParameters = new object[]
		{
			typeof(bool),
			typeof(XmlTextReaderImpl.EntityExpandType),
			typeof(ref int)
		}, ReturnType = typeof(XmlTextReaderImpl.EntityType))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlCharType), Member = "IsWhiteSpace", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = "set_Length", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlTextReaderImpl), Member = "ParseEntityName", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlTextReaderImpl.NodeData), Member = "SetNamedNode", MemberParameters = new object[]
		{
			typeof(XmlNodeType),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlException), Member = "BuildCharExceptionArgs", MemberParameters = new object[]
		{
			typeof(char),
			typeof(char)
		}, ReturnType = typeof(string[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlTextReaderImpl), Member = "Throw", MemberParameters = new object[]
		{
			typeof(int),
			typeof(string),
			typeof(string[])
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlTextReaderImpl), Member = "ThrowInvalidChar", MemberParameters = new object[]
		{
			typeof(char[]),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private bool ParseAttributeValueChunk()
		{
			throw null;
		}

		// Token: 0x06000307 RID: 775 RVA: 0x0000382A File Offset: 0x00001A2A
		[global::Cpp2ILInjected.Token(Token = "0x6000314")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D72804", Offset = "0x1D72804", Length = "0xA4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl), Member = "Read", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlTextReaderImpl), Member = "ParseXmlDeclaration", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlTextReaderImpl), Member = "ReThrow", MemberParameters = new object[]
		{
			typeof(Exception),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
		private void ParseXmlDeclarationFragment()
		{
			throw null;
		}

		// Token: 0x06000308 RID: 776 RVA: 0x0000382D File Offset: 0x00001A2D
		[global::Cpp2ILInjected.Token(Token = "0x6000315")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D775BC", Offset = "0x1D775BC", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlTextReaderImpl), Member = "ThrowUnexpectedToken", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		private void ThrowUnexpectedToken(int pos, string expectedToken)
		{
			throw null;
		}

		// Token: 0x06000309 RID: 777 RVA: 0x00003830 File Offset: 0x00001A30
		[global::Cpp2ILInjected.Token(Token = "0x6000316")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D77414", Offset = "0x1D77414", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlTextReaderImpl), Member = "ThrowUnexpectedToken", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		private void ThrowUnexpectedToken(string expectedToken1)
		{
			throw null;
		}

		// Token: 0x0600030A RID: 778 RVA: 0x00003833 File Offset: 0x00001A33
		[global::Cpp2ILInjected.Token(Token = "0x6000317")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D7783C", Offset = "0x1D7783C", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlTextReaderImpl), Member = "ThrowUnexpectedToken", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		private void ThrowUnexpectedToken(int pos, string expectedToken1, string expectedToken2)
		{
			throw null;
		}

		// Token: 0x0600030B RID: 779 RVA: 0x00003836 File Offset: 0x00001A36
		[global::Cpp2ILInjected.Token(Token = "0x6000318")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D7743C", Offset = "0x1D7743C", Length = "0x124")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseXmlDeclaration", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseDocumentContent", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseElementContent", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseElement", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseEndElement", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseAttributes", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl), Member = "HandleEntityReference", MemberParameters = new object[]
		{
			typeof(bool),
			typeof(XmlTextReaderImpl.EntityExpandType),
			typeof(ref int)
		}, ReturnType = typeof(XmlTextReaderImpl.EntityType))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseDoctypeDecl", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl), Member = "SkipDtd", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl), Member = "SkipPublicOrSystemIdLiteral", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl), Member = "IncrementalRead", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ThrowUnexpectedToken", MemberParameters = new object[]
		{
			typeof(int),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ThrowUnexpectedToken", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ThrowUnexpectedToken", MemberParameters = new object[]
		{
			typeof(int),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 21)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlTextReaderImpl), Member = "ParseUnexpectedToken", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlTextReaderImpl), Member = "Throw", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlTextReaderImpl), Member = "Throw", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string[])
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 11)]
		private void ThrowUnexpectedToken(string expectedToken1, string expectedToken2)
		{
			throw null;
		}

		// Token: 0x0600030C RID: 780 RVA: 0x00003839 File Offset: 0x00001A39
		[global::Cpp2ILInjected.Token(Token = "0x6000319")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D77834", Offset = "0x1D77834", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlTextReaderImpl), Member = "ParseUnexpectedToken", ReturnType = typeof(string))]
		private string ParseUnexpectedToken(int pos)
		{
			throw null;
		}

		// Token: 0x0600030D RID: 781 RVA: 0x0000383C File Offset: 0x00001A3C
		[global::Cpp2ILInjected.Token(Token = "0x600031A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D7E674", Offset = "0x1D7E674", Length = "0xA0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseDocumentContent", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseElementContent", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ThrowUnexpectedToken", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseUnexpectedToken", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ThrowExpectingWhitespace", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlCharType), Member = "IsNCNameSingleChar", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "CreateString", MemberParameters = new object[]
		{
			typeof(char[]),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(string))]
		private string ParseUnexpectedToken()
		{
			throw null;
		}

		// Token: 0x0600030E RID: 782 RVA: 0x0000383F File Offset: 0x00001A3F
		[global::Cpp2ILInjected.Token(Token = "0x600031B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D7A058", Offset = "0x1D7A058", Length = "0x80")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseAttributes", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseDoctypeDecl", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl), Member = "SkipDtd", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlTextReaderImpl), Member = "ParseUnexpectedToken", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlTextReaderImpl), Member = "Throw", MemberParameters = new object[]
		{
			typeof(int),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlTextReaderImpl), Member = "Throw", MemberParameters = new object[]
		{
			typeof(int),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private void ThrowExpectingWhitespace(int pos)
		{
			throw null;
		}

		// Token: 0x0600030F RID: 783 RVA: 0x00003842 File Offset: 0x00001A42
		[global::Cpp2ILInjected.Token(Token = "0x600031C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D708F0", Offset = "0x1D708F0", Length = "0xAC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl), Member = "MoveToAttribute", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Ref), Member = "Equal", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(bool))]
		private int GetIndexOfAttributeWithoutPrefix(string name)
		{
			throw null;
		}

		// Token: 0x06000310 RID: 784 RVA: 0x00003845 File Offset: 0x00001A45
		[global::Cpp2ILInjected.Token(Token = "0x600031D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D7099C", Offset = "0x1D7099C", Length = "0x98")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl), Member = "MoveToAttribute", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlTextReaderImpl.NodeData), Member = "GetNameWPrefix", MemberParameters = new object[] { typeof(XmlNameTable) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Ref), Member = "Equal", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(bool))]
		private int GetIndexOfAttributeWithPrefix(string name)
		{
			throw null;
		}

		// Token: 0x06000311 RID: 785 RVA: 0x00003848 File Offset: 0x00001A48
		[global::Cpp2ILInjected.Token(Token = "0x600031E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D7BAE0", Offset = "0x1D7BAE0", Length = "0x64")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseText", MemberParameters = new object[]
		{
			typeof(ref int),
			typeof(ref int),
			typeof(ref int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseRootLevelWhitespace", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlTextReaderImpl), Member = "ReadData", ReturnType = typeof(int))]
		private bool ZeroEndingStream(int pos)
		{
			throw null;
		}

		// Token: 0x06000312 RID: 786 RVA: 0x0000384B File Offset: 0x00001A4B
		[global::Cpp2ILInjected.Token(Token = "0x600031F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D768C8", Offset = "0x1D768C8", Length = "0x214")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ProcessDtdFromParserContext", MemberParameters = new object[] { typeof(XmlParserContext) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl), Member = "HandleGeneralEntityReference", MemberParameters = new object[]
		{
			typeof(string),
			typeof(bool),
			typeof(bool),
			typeof(int)
		}, ReturnType = typeof(XmlTextReaderImpl.EntityType))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DtdParser), Member = "Create", ReturnType = typeof(IDtdParser))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlTextReaderImpl.DtdParserProxy), Member = ".ctor", MemberParameters = new object[] { typeof(XmlTextReaderImpl) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		private void ParseDtdFromParserContext()
		{
			throw null;
		}

		// Token: 0x06000313 RID: 787 RVA: 0x0000384E File Offset: 0x00001A4E
		[global::Cpp2ILInjected.Token(Token = "0x6000320")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D7BB44", Offset = "0x1D7BB44", Length = "0x98")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl), Member = "FinishReadContentAsBinary", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		private bool MoveToNextContentNode(bool moveIfOnContentNode)
		{
			throw null;
		}

		// Token: 0x1700009E RID: 158
		// (get) Token: 0x06000314 RID: 788 RVA: 0x00003851 File Offset: 0x00001A51
		[global::Cpp2ILInjected.Token(Token = "0x170000A3")]
		internal override IDtdInfo DtdInfo
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000321")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D7E714", Offset = "0x1D7E714", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06000315 RID: 789 RVA: 0x00003854 File Offset: 0x00001A54
		[global::Cpp2ILInjected.Token(Token = "0x6000322")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D7E71C", Offset = "0x1D7E71C", Length = "0x12C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlLoader), Member = "CreateInnerXmlReader", MemberParameters = new object[]
		{
			typeof(string),
			typeof(XmlNodeType),
			typeof(XmlParserContext),
			typeof(XmlDocument)
		}, ReturnType = typeof(XmlReader))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		internal void SetDtdInfo(IDtdInfo newDtdInfo)
		{
			throw null;
		}

		// Token: 0x1700009F RID: 159
		// (set) Token: 0x06000316 RID: 790 RVA: 0x00003857 File Offset: 0x00001A57
		[global::Cpp2ILInjected.Token(Token = "0x170000A4")]
		internal bool XmlValidatingReaderCompatibilityMode
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000323")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D7E848", Offset = "0x1D7E848", Length = "0xC8")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReader), Member = "set_XmlValidatingReaderCompatibilityMode", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlDocument), Member = "SetupReader", MemberParameters = new object[] { typeof(XmlTextReader) }, ReturnType = typeof(XmlTextReader))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlLoader), Member = "CreateInnerXmlReader", MemberParameters = new object[]
			{
				typeof(string),
				typeof(XmlNodeType),
				typeof(XmlParserContext),
				typeof(XmlDocument)
			}, ReturnType = typeof(XmlReader))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
			set
			{
				throw null;
			}
		}

		// Token: 0x06000317 RID: 791 RVA: 0x0000385A File Offset: 0x00001A5A
		[global::Cpp2ILInjected.Token(Token = "0x6000324")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D79808", Offset = "0x1D79808", Length = "0x640")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl), Member = "AddDefaultAttributesAndNormalize", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Array), Member = "BinarySearch", MemberTypeParameters = new object[] { "T" }, MemberParameters = new object[] { "T[]", "T", "System.Collections.Generic.IComparer`1<T>" }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlTextReaderImpl), Member = "AddDefaultAttributeInternal", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(string),
			typeof(string),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(bool)
		}, ReturnType = typeof(XmlTextReaderImpl.NodeData))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 19)]
		private bool AddDefaultAttributeDtd(IDtdDefaultAttributeInfo defAttrInfo, bool definedInDtd, XmlTextReaderImpl.NodeData[] nameSortedNodeData)
		{
			throw null;
		}

		// Token: 0x06000318 RID: 792 RVA: 0x0000385D File Offset: 0x00001A5D
		[global::Cpp2ILInjected.Token(Token = "0x6000325")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D7E910", Offset = "0x1D7E910", Length = "0x1D4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl), Member = "AddDefaultAttributeDtd", MemberParameters = new object[]
		{
			typeof(IDtdDefaultAttributeInfo),
			typeof(bool),
			typeof(XmlTextReaderImpl.NodeData[])
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlTextReaderImpl), Member = "AddAttribute", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(XmlTextReaderImpl.NodeData))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlTextReaderImpl.NodeData), Member = "SetValue", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LineInfo), Member = "Set", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Ref), Member = "Equal", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlTextReaderImpl), Member = "OnNamespaceDecl", MemberParameters = new object[] { typeof(XmlTextReaderImpl.NodeData) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Equals", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlTextReaderImpl), Member = "OnDefaultNamespaceDecl", MemberParameters = new object[] { typeof(XmlTextReaderImpl.NodeData) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlTextReaderImpl), Member = "OnXmlReservedAttribute", MemberParameters = new object[] { typeof(XmlTextReaderImpl.NodeData) }, ReturnType = typeof(void))]
		private XmlTextReaderImpl.NodeData AddDefaultAttributeInternal(string localName, string ns, string prefix, string value, int lineNo, int linePos, int valueLineNo, int valueLinePos, bool isXmlAttribute)
		{
			throw null;
		}

		// Token: 0x170000A0 RID: 160
		// (set) Token: 0x06000319 RID: 793 RVA: 0x00003860 File Offset: 0x00001A60
		[global::Cpp2ILInjected.Token(Token = "0x170000A5")]
		internal bool DisableUndeclaredEntityCheck
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000326")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D7EAE4", Offset = "0x1D7EAE4", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x0600031A RID: 794 RVA: 0x00003863 File Offset: 0x00001A63
		[global::Cpp2ILInjected.Token(Token = "0x6000327")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D75978", Offset = "0x1D75978", Length = "0xDC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl), Member = "DtdParserProxy_PushInternalDtd", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ReadData", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl), Member = "PushExternalEntity", MemberParameters = new object[] { typeof(IDtdEntityInfo) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl), Member = "PushInternalEntity", MemberParameters = new object[] { typeof(IDtdEntityInfo) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlTextReaderImpl), Member = "ThrowWithoutLineInfo", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		private void RegisterConsumedCharacters(long characters, bool inEntityReference)
		{
			throw null;
		}

		// Token: 0x0600031B RID: 795 RVA: 0x00003866 File Offset: 0x00001A66
		[global::Cpp2ILInjected.Token(Token = "0x6000328")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D7EAF0", Offset = "0x1D7EAF0", Length = "0x21C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl.NodeData), Member = "TrimSpacesInValue", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(char))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = ".ctor", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(StringBuilder))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Substring", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		internal static string StripSpaces(string value)
		{
			throw null;
		}

		// Token: 0x0600031C RID: 796 RVA: 0x00003869 File Offset: 0x00001A69
		[global::Cpp2ILInjected.Token(Token = "0x6000329")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D7ED0C", Offset = "0x1D7ED0C", Length = "0xDC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl.NodeData), Member = "TrimSpacesInValue", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		internal static void StripSpaces(char[] value, int index, ref int len)
		{
			throw null;
		}

		// Token: 0x0600031D RID: 797 RVA: 0x0000386C File Offset: 0x00001A6C
		[global::Cpp2ILInjected.Token(Token = "0x600032A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D77108", Offset = "0x1D77108", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Buffer), Member = "BlockCopy", MemberParameters = new object[]
		{
			typeof(Array),
			typeof(int),
			typeof(Array),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		internal static void BlockCopyChars(char[] src, int srcOffset, char[] dst, int dstOffset, int count)
		{
			throw null;
		}

		// Token: 0x0600031E RID: 798 RVA: 0x0000386F File Offset: 0x00001A6F
		[global::Cpp2ILInjected.Token(Token = "0x600032B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D7711C", Offset = "0x1D7711C", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Buffer), Member = "BlockCopy", MemberParameters = new object[]
		{
			typeof(Array),
			typeof(int),
			typeof(Array),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		internal static void BlockCopy(byte[] src, int srcOffset, byte[] dst, int dstOffset, int count)
		{
			throw null;
		}

		// Token: 0x040000DB RID: 219
		[global::Cpp2ILInjected.Token(Token = "0x40000FB")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private XmlTextReaderImpl.LaterInitParam laterInitParam;

		// Token: 0x040000DC RID: 220
		[global::Cpp2ILInjected.Token(Token = "0x40000FC")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private XmlCharType xmlCharType;

		// Token: 0x040000DD RID: 221
		[global::Cpp2ILInjected.Token(Token = "0x40000FD")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private XmlTextReaderImpl.ParsingState ps;

		// Token: 0x040000DE RID: 222
		[global::Cpp2ILInjected.Token(Token = "0x40000FE")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x98")]
		private XmlTextReaderImpl.ParsingFunction parsingFunction;

		// Token: 0x040000DF RID: 223
		[global::Cpp2ILInjected.Token(Token = "0x40000FF")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x9C")]
		private XmlTextReaderImpl.ParsingFunction nextParsingFunction;

		// Token: 0x040000E0 RID: 224
		[global::Cpp2ILInjected.Token(Token = "0x4000100")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xA0")]
		private XmlTextReaderImpl.ParsingFunction nextNextParsingFunction;

		// Token: 0x040000E1 RID: 225
		[global::Cpp2ILInjected.Token(Token = "0x4000101")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xA8")]
		private XmlTextReaderImpl.NodeData[] nodes;

		// Token: 0x040000E2 RID: 226
		[global::Cpp2ILInjected.Token(Token = "0x4000102")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xB0")]
		private XmlTextReaderImpl.NodeData curNode;

		// Token: 0x040000E3 RID: 227
		[global::Cpp2ILInjected.Token(Token = "0x4000103")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xB8")]
		private int index;

		// Token: 0x040000E4 RID: 228
		[global::Cpp2ILInjected.Token(Token = "0x4000104")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xBC")]
		private int curAttrIndex;

		// Token: 0x040000E5 RID: 229
		[global::Cpp2ILInjected.Token(Token = "0x4000105")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xC0")]
		private int attrCount;

		// Token: 0x040000E6 RID: 230
		[global::Cpp2ILInjected.Token(Token = "0x4000106")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xC4")]
		private int attrHashtable;

		// Token: 0x040000E7 RID: 231
		[global::Cpp2ILInjected.Token(Token = "0x4000107")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xC8")]
		private int attrDuplWalkCount;

		// Token: 0x040000E8 RID: 232
		[global::Cpp2ILInjected.Token(Token = "0x4000108")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xCC")]
		private bool attrNeedNamespaceLookup;

		// Token: 0x040000E9 RID: 233
		[global::Cpp2ILInjected.Token(Token = "0x4000109")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xCD")]
		private bool fullAttrCleanup;

		// Token: 0x040000EA RID: 234
		[global::Cpp2ILInjected.Token(Token = "0x400010A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xD0")]
		private XmlTextReaderImpl.NodeData[] attrDuplSortingArray;

		// Token: 0x040000EB RID: 235
		[global::Cpp2ILInjected.Token(Token = "0x400010B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xD8")]
		private XmlNameTable nameTable;

		// Token: 0x040000EC RID: 236
		[global::Cpp2ILInjected.Token(Token = "0x400010C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xE0")]
		private bool nameTableFromSettings;

		// Token: 0x040000ED RID: 237
		[global::Cpp2ILInjected.Token(Token = "0x400010D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xE8")]
		private XmlResolver xmlResolver;

		// Token: 0x040000EE RID: 238
		[global::Cpp2ILInjected.Token(Token = "0x400010E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xF0")]
		private string url;

		// Token: 0x040000EF RID: 239
		[global::Cpp2ILInjected.Token(Token = "0x400010F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xF8")]
		private bool normalize;

		// Token: 0x040000F0 RID: 240
		[global::Cpp2ILInjected.Token(Token = "0x4000110")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xF9")]
		private bool supportNamespaces;

		// Token: 0x040000F1 RID: 241
		[global::Cpp2ILInjected.Token(Token = "0x4000111")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xFC")]
		private WhitespaceHandling whitespaceHandling;

		// Token: 0x040000F2 RID: 242
		[global::Cpp2ILInjected.Token(Token = "0x4000112")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x100")]
		private DtdProcessing dtdProcessing;

		// Token: 0x040000F3 RID: 243
		[global::Cpp2ILInjected.Token(Token = "0x4000113")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x104")]
		private EntityHandling entityHandling;

		// Token: 0x040000F4 RID: 244
		[global::Cpp2ILInjected.Token(Token = "0x4000114")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x108")]
		private bool ignorePIs;

		// Token: 0x040000F5 RID: 245
		[global::Cpp2ILInjected.Token(Token = "0x4000115")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x109")]
		private bool ignoreComments;

		// Token: 0x040000F6 RID: 246
		[global::Cpp2ILInjected.Token(Token = "0x4000116")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10A")]
		private bool checkCharacters;

		// Token: 0x040000F7 RID: 247
		[global::Cpp2ILInjected.Token(Token = "0x4000117")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10C")]
		private int lineNumberOffset;

		// Token: 0x040000F8 RID: 248
		[global::Cpp2ILInjected.Token(Token = "0x4000118")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x110")]
		private int linePositionOffset;

		// Token: 0x040000F9 RID: 249
		[global::Cpp2ILInjected.Token(Token = "0x4000119")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x114")]
		private bool closeInput;

		// Token: 0x040000FA RID: 250
		[global::Cpp2ILInjected.Token(Token = "0x400011A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x118")]
		private long maxCharactersInDocument;

		// Token: 0x040000FB RID: 251
		[global::Cpp2ILInjected.Token(Token = "0x400011B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x120")]
		private long maxCharactersFromEntities;

		// Token: 0x040000FC RID: 252
		[global::Cpp2ILInjected.Token(Token = "0x400011C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x128")]
		private bool v1Compat;

		// Token: 0x040000FD RID: 253
		[global::Cpp2ILInjected.Token(Token = "0x400011D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x130")]
		private XmlNamespaceManager namespaceManager;

		// Token: 0x040000FE RID: 254
		[global::Cpp2ILInjected.Token(Token = "0x400011E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x138")]
		private string lastPrefix;

		// Token: 0x040000FF RID: 255
		[global::Cpp2ILInjected.Token(Token = "0x400011F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x140")]
		private XmlTextReaderImpl.XmlContext xmlContext;

		// Token: 0x04000100 RID: 256
		[global::Cpp2ILInjected.Token(Token = "0x4000120")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x148")]
		private XmlTextReaderImpl.ParsingState[] parsingStatesStack;

		// Token: 0x04000101 RID: 257
		[global::Cpp2ILInjected.Token(Token = "0x4000121")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x150")]
		private int parsingStatesStackTop;

		// Token: 0x04000102 RID: 258
		[global::Cpp2ILInjected.Token(Token = "0x4000122")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x158")]
		private string reportedBaseUri;

		// Token: 0x04000103 RID: 259
		[global::Cpp2ILInjected.Token(Token = "0x4000123")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x160")]
		private Encoding reportedEncoding;

		// Token: 0x04000104 RID: 260
		[global::Cpp2ILInjected.Token(Token = "0x4000124")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x168")]
		private IDtdInfo dtdInfo;

		// Token: 0x04000105 RID: 261
		[global::Cpp2ILInjected.Token(Token = "0x4000125")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x170")]
		private XmlNodeType fragmentType;

		// Token: 0x04000106 RID: 262
		[global::Cpp2ILInjected.Token(Token = "0x4000126")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x178")]
		private XmlParserContext fragmentParserContext;

		// Token: 0x04000107 RID: 263
		[global::Cpp2ILInjected.Token(Token = "0x4000127")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x180")]
		private bool fragment;

		// Token: 0x04000108 RID: 264
		[global::Cpp2ILInjected.Token(Token = "0x4000128")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x188")]
		private IncrementalReadDecoder incReadDecoder;

		// Token: 0x04000109 RID: 265
		[global::Cpp2ILInjected.Token(Token = "0x4000129")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x190")]
		private XmlTextReaderImpl.IncrementalReadState incReadState;

		// Token: 0x0400010A RID: 266
		[global::Cpp2ILInjected.Token(Token = "0x400012A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x194")]
		private LineInfo incReadLineInfo;

		// Token: 0x0400010B RID: 267
		[global::Cpp2ILInjected.Token(Token = "0x400012B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x19C")]
		private int incReadDepth;

		// Token: 0x0400010C RID: 268
		[global::Cpp2ILInjected.Token(Token = "0x400012C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x1A0")]
		private int incReadLeftStartPos;

		// Token: 0x0400010D RID: 269
		[global::Cpp2ILInjected.Token(Token = "0x400012D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x1A4")]
		private int incReadLeftEndPos;

		// Token: 0x0400010E RID: 270
		[global::Cpp2ILInjected.Token(Token = "0x400012E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x1A8")]
		private int attributeValueBaseEntityId;

		// Token: 0x0400010F RID: 271
		[global::Cpp2ILInjected.Token(Token = "0x400012F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x1AC")]
		private bool emptyEntityInAttributeResolved;

		// Token: 0x04000110 RID: 272
		[global::Cpp2ILInjected.Token(Token = "0x4000130")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x1B0")]
		private IValidationEventHandling validationEventHandling;

		// Token: 0x04000111 RID: 273
		[global::Cpp2ILInjected.Token(Token = "0x4000131")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x1B8")]
		private XmlTextReaderImpl.OnDefaultAttributeUseDelegate onDefaultAttributeUse;

		// Token: 0x04000112 RID: 274
		[global::Cpp2ILInjected.Token(Token = "0x4000132")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x1C0")]
		private bool validatingReaderCompatFlag;

		// Token: 0x04000113 RID: 275
		[global::Cpp2ILInjected.Token(Token = "0x4000133")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x1C1")]
		private bool addDefaultAttributesAndNormalize;

		// Token: 0x04000114 RID: 276
		[global::Cpp2ILInjected.Token(Token = "0x4000134")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x1C8")]
		private StringBuilder stringBuilder;

		// Token: 0x04000115 RID: 277
		[global::Cpp2ILInjected.Token(Token = "0x4000135")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x1D0")]
		private bool rootElementParsed;

		// Token: 0x04000116 RID: 278
		[global::Cpp2ILInjected.Token(Token = "0x4000136")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x1D1")]
		private bool standalone;

		// Token: 0x04000117 RID: 279
		[global::Cpp2ILInjected.Token(Token = "0x4000137")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x1D4")]
		private int nextEntityId;

		// Token: 0x04000118 RID: 280
		[global::Cpp2ILInjected.Token(Token = "0x4000138")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x1D8")]
		private XmlTextReaderImpl.ParsingMode parsingMode;

		// Token: 0x04000119 RID: 281
		[global::Cpp2ILInjected.Token(Token = "0x4000139")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x1DC")]
		private ReadState readState;

		// Token: 0x0400011A RID: 282
		[global::Cpp2ILInjected.Token(Token = "0x400013A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x1E0")]
		private IDtdEntityInfo lastEntity;

		// Token: 0x0400011B RID: 283
		[global::Cpp2ILInjected.Token(Token = "0x400013B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x1E8")]
		private bool afterResetState;

		// Token: 0x0400011C RID: 284
		[global::Cpp2ILInjected.Token(Token = "0x400013C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x1EC")]
		private int documentStartBytePos;

		// Token: 0x0400011D RID: 285
		[global::Cpp2ILInjected.Token(Token = "0x400013D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x1F0")]
		private int readValueOffset;

		// Token: 0x0400011E RID: 286
		[global::Cpp2ILInjected.Token(Token = "0x400013E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x1F8")]
		private long charactersInDocument;

		// Token: 0x0400011F RID: 287
		[global::Cpp2ILInjected.Token(Token = "0x400013F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x200")]
		private long charactersFromEntities;

		// Token: 0x04000120 RID: 288
		[global::Cpp2ILInjected.Token(Token = "0x4000140")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x208")]
		private Dictionary<IDtdEntityInfo, IDtdEntityInfo> currentEntities;

		// Token: 0x04000121 RID: 289
		[global::Cpp2ILInjected.Token(Token = "0x4000141")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x210")]
		private bool disableUndeclaredEntityCheck;

		// Token: 0x04000122 RID: 290
		[global::Cpp2ILInjected.Token(Token = "0x4000142")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x218")]
		private XmlReader outerReader;

		// Token: 0x04000123 RID: 291
		[global::Cpp2ILInjected.Token(Token = "0x4000143")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x220")]
		private bool xmlResolverIsSet;

		// Token: 0x04000124 RID: 292
		[global::Cpp2ILInjected.Token(Token = "0x4000144")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x228")]
		private string Xml;

		// Token: 0x04000125 RID: 293
		[global::Cpp2ILInjected.Token(Token = "0x4000145")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x230")]
		private string XmlNs;

		// Token: 0x04000126 RID: 294
		[global::Cpp2ILInjected.Token(Token = "0x4000146")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x238")]
		private Task<Tuple<int, int, int, bool>> parseText_dummyTask;

		// Token: 0x0200014D RID: 333
		[global::Cpp2ILInjected.Token(Token = "0x200003E")]
		private enum ParsingFunction
		{
			// Token: 0x04000520 RID: 1312
			[global::Cpp2ILInjected.Token(Token = "0x4000148")]
			ElementContent,
			// Token: 0x04000521 RID: 1313
			[global::Cpp2ILInjected.Token(Token = "0x4000149")]
			NoData,
			// Token: 0x04000522 RID: 1314
			[global::Cpp2ILInjected.Token(Token = "0x400014A")]
			OpenUrl,
			// Token: 0x04000523 RID: 1315
			[global::Cpp2ILInjected.Token(Token = "0x400014B")]
			SwitchToInteractive,
			// Token: 0x04000524 RID: 1316
			[global::Cpp2ILInjected.Token(Token = "0x400014C")]
			SwitchToInteractiveXmlDecl,
			// Token: 0x04000525 RID: 1317
			[global::Cpp2ILInjected.Token(Token = "0x400014D")]
			DocumentContent,
			// Token: 0x04000526 RID: 1318
			[global::Cpp2ILInjected.Token(Token = "0x400014E")]
			MoveToElementContent,
			// Token: 0x04000527 RID: 1319
			[global::Cpp2ILInjected.Token(Token = "0x400014F")]
			PopElementContext,
			// Token: 0x04000528 RID: 1320
			[global::Cpp2ILInjected.Token(Token = "0x4000150")]
			PopEmptyElementContext,
			// Token: 0x04000529 RID: 1321
			[global::Cpp2ILInjected.Token(Token = "0x4000151")]
			ResetAttributesRootLevel,
			// Token: 0x0400052A RID: 1322
			[global::Cpp2ILInjected.Token(Token = "0x4000152")]
			Error,
			// Token: 0x0400052B RID: 1323
			[global::Cpp2ILInjected.Token(Token = "0x4000153")]
			Eof,
			// Token: 0x0400052C RID: 1324
			[global::Cpp2ILInjected.Token(Token = "0x4000154")]
			ReaderClosed,
			// Token: 0x0400052D RID: 1325
			[global::Cpp2ILInjected.Token(Token = "0x4000155")]
			EntityReference,
			// Token: 0x0400052E RID: 1326
			[global::Cpp2ILInjected.Token(Token = "0x4000156")]
			InIncrementalRead,
			// Token: 0x0400052F RID: 1327
			[global::Cpp2ILInjected.Token(Token = "0x4000157")]
			FragmentAttribute,
			// Token: 0x04000530 RID: 1328
			[global::Cpp2ILInjected.Token(Token = "0x4000158")]
			ReportEndEntity,
			// Token: 0x04000531 RID: 1329
			[global::Cpp2ILInjected.Token(Token = "0x4000159")]
			AfterResolveEntityInContent,
			// Token: 0x04000532 RID: 1330
			[global::Cpp2ILInjected.Token(Token = "0x400015A")]
			AfterResolveEmptyEntityInContent,
			// Token: 0x04000533 RID: 1331
			[global::Cpp2ILInjected.Token(Token = "0x400015B")]
			XmlDeclarationFragment,
			// Token: 0x04000534 RID: 1332
			[global::Cpp2ILInjected.Token(Token = "0x400015C")]
			GoToEof,
			// Token: 0x04000535 RID: 1333
			[global::Cpp2ILInjected.Token(Token = "0x400015D")]
			PartialTextValue,
			// Token: 0x04000536 RID: 1334
			[global::Cpp2ILInjected.Token(Token = "0x400015E")]
			InReadAttributeValue,
			// Token: 0x04000537 RID: 1335
			[global::Cpp2ILInjected.Token(Token = "0x400015F")]
			InReadValueChunk,
			// Token: 0x04000538 RID: 1336
			[global::Cpp2ILInjected.Token(Token = "0x4000160")]
			InReadContentAsBinary,
			// Token: 0x04000539 RID: 1337
			[global::Cpp2ILInjected.Token(Token = "0x4000161")]
			InReadElementContentAsBinary
		}

		// Token: 0x0200014E RID: 334
		[global::Cpp2ILInjected.Token(Token = "0x200003F")]
		private enum ParsingMode
		{
			// Token: 0x0400053B RID: 1339
			[global::Cpp2ILInjected.Token(Token = "0x4000163")]
			Full,
			// Token: 0x0400053C RID: 1340
			[global::Cpp2ILInjected.Token(Token = "0x4000164")]
			SkipNode,
			// Token: 0x0400053D RID: 1341
			[global::Cpp2ILInjected.Token(Token = "0x4000165")]
			SkipContent
		}

		// Token: 0x0200014F RID: 335
		[global::Cpp2ILInjected.Token(Token = "0x2000040")]
		private enum EntityType
		{
			// Token: 0x0400053F RID: 1343
			[global::Cpp2ILInjected.Token(Token = "0x4000167")]
			CharacterDec,
			// Token: 0x04000540 RID: 1344
			[global::Cpp2ILInjected.Token(Token = "0x4000168")]
			CharacterHex,
			// Token: 0x04000541 RID: 1345
			[global::Cpp2ILInjected.Token(Token = "0x4000169")]
			CharacterNamed,
			// Token: 0x04000542 RID: 1346
			[global::Cpp2ILInjected.Token(Token = "0x400016A")]
			Expanded,
			// Token: 0x04000543 RID: 1347
			[global::Cpp2ILInjected.Token(Token = "0x400016B")]
			Skipped,
			// Token: 0x04000544 RID: 1348
			[global::Cpp2ILInjected.Token(Token = "0x400016C")]
			FakeExpanded,
			// Token: 0x04000545 RID: 1349
			[global::Cpp2ILInjected.Token(Token = "0x400016D")]
			Unexpanded,
			// Token: 0x04000546 RID: 1350
			[global::Cpp2ILInjected.Token(Token = "0x400016E")]
			ExpandedInAttribute
		}

		// Token: 0x02000150 RID: 336
		[global::Cpp2ILInjected.Token(Token = "0x2000041")]
		private enum EntityExpandType
		{
			// Token: 0x04000548 RID: 1352
			[global::Cpp2ILInjected.Token(Token = "0x4000170")]
			All,
			// Token: 0x04000549 RID: 1353
			[global::Cpp2ILInjected.Token(Token = "0x4000171")]
			OnlyGeneral,
			// Token: 0x0400054A RID: 1354
			[global::Cpp2ILInjected.Token(Token = "0x4000172")]
			OnlyCharacter
		}

		// Token: 0x02000151 RID: 337
		[global::Cpp2ILInjected.Token(Token = "0x2000042")]
		private enum IncrementalReadState
		{
			// Token: 0x0400054C RID: 1356
			[global::Cpp2ILInjected.Token(Token = "0x4000174")]
			Text,
			// Token: 0x0400054D RID: 1357
			[global::Cpp2ILInjected.Token(Token = "0x4000175")]
			StartTag,
			// Token: 0x0400054E RID: 1358
			[global::Cpp2ILInjected.Token(Token = "0x4000176")]
			PI,
			// Token: 0x0400054F RID: 1359
			[global::Cpp2ILInjected.Token(Token = "0x4000177")]
			CDATA,
			// Token: 0x04000550 RID: 1360
			[global::Cpp2ILInjected.Token(Token = "0x4000178")]
			Comment,
			// Token: 0x04000551 RID: 1361
			[global::Cpp2ILInjected.Token(Token = "0x4000179")]
			Attributes,
			// Token: 0x04000552 RID: 1362
			[global::Cpp2ILInjected.Token(Token = "0x400017A")]
			AttributeValue,
			// Token: 0x04000553 RID: 1363
			[global::Cpp2ILInjected.Token(Token = "0x400017B")]
			ReadData,
			// Token: 0x04000554 RID: 1364
			[global::Cpp2ILInjected.Token(Token = "0x400017C")]
			EndElement,
			// Token: 0x04000555 RID: 1365
			[global::Cpp2ILInjected.Token(Token = "0x400017D")]
			End,
			// Token: 0x04000556 RID: 1366
			[global::Cpp2ILInjected.Token(Token = "0x400017E")]
			ReadValueChunk_OnCachedValue,
			// Token: 0x04000557 RID: 1367
			[global::Cpp2ILInjected.Token(Token = "0x400017F")]
			ReadValueChunk_OnPartialValue,
			// Token: 0x04000558 RID: 1368
			[global::Cpp2ILInjected.Token(Token = "0x4000180")]
			ReadContentAsBinary_OnCachedValue,
			// Token: 0x04000559 RID: 1369
			[global::Cpp2ILInjected.Token(Token = "0x4000181")]
			ReadContentAsBinary_OnPartialValue,
			// Token: 0x0400055A RID: 1370
			[global::Cpp2ILInjected.Token(Token = "0x4000182")]
			ReadContentAsBinary_End
		}

		// Token: 0x02000152 RID: 338
		[global::Cpp2ILInjected.Token(Token = "0x2000043")]
		private class LaterInitParam
		{
			// Token: 0x0400055B RID: 1371
			[global::Cpp2ILInjected.Token(Token = "0x4000183")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
			public bool useAsync;

			// Token: 0x0400055C RID: 1372
			[global::Cpp2ILInjected.Token(Token = "0x4000184")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
			public Stream inputStream;

			// Token: 0x0400055D RID: 1373
			[global::Cpp2ILInjected.Token(Token = "0x4000185")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
			public byte[] inputBytes;

			// Token: 0x0400055E RID: 1374
			[global::Cpp2ILInjected.Token(Token = "0x4000186")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
			public int inputByteCount;

			// Token: 0x0400055F RID: 1375
			[global::Cpp2ILInjected.Token(Token = "0x4000187")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
			public Uri inputbaseUri;

			// Token: 0x04000560 RID: 1376
			[global::Cpp2ILInjected.Token(Token = "0x4000188")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
			public string inputUriStr;

			// Token: 0x04000561 RID: 1377
			[global::Cpp2ILInjected.Token(Token = "0x4000189")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
			public XmlResolver inputUriResolver;

			// Token: 0x04000562 RID: 1378
			[global::Cpp2ILInjected.Token(Token = "0x400018A")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
			public XmlParserContext inputContext;

			// Token: 0x04000563 RID: 1379
			[global::Cpp2ILInjected.Token(Token = "0x400018B")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
			public TextReader inputTextReader;

			// Token: 0x04000564 RID: 1380
			[global::Cpp2ILInjected.Token(Token = "0x400018C")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x58")]
			public XmlTextReaderImpl.InitInputType initType;
		}

		// Token: 0x02000153 RID: 339
		[global::Cpp2ILInjected.Token(Token = "0x2000044")]
		private enum InitInputType
		{
			// Token: 0x04000566 RID: 1382
			[global::Cpp2ILInjected.Token(Token = "0x400018E")]
			UriString,
			// Token: 0x04000567 RID: 1383
			[global::Cpp2ILInjected.Token(Token = "0x400018F")]
			Stream,
			// Token: 0x04000568 RID: 1384
			[global::Cpp2ILInjected.Token(Token = "0x4000190")]
			TextReader,
			// Token: 0x04000569 RID: 1385
			[global::Cpp2ILInjected.Token(Token = "0x4000191")]
			Invalid
		}

		// Token: 0x02000154 RID: 340
		[global::Cpp2ILInjected.Token(Token = "0x2000045")]
		private struct ParsingState
		{
			// Token: 0x06000C47 RID: 3143 RVA: 0x0000523D File Offset: 0x0000343D
			[global::Cpp2ILInjected.Token(Token = "0x600032C")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D7F088", Offset = "0x1D7F088", Length = "0x7C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl), Member = "PushParsingState", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			internal void Clear()
			{
				throw null;
			}

			// Token: 0x06000C48 RID: 3144 RVA: 0x00005240 File Offset: 0x00003440
			[global::Cpp2ILInjected.Token(Token = "0x600032D")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D7F104", Offset = "0x1D7F104", Length = "0x38")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl), Member = "Close", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl), Member = "PopEntity", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl), Member = "PopParsingState", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			internal void Close(bool closeInput)
			{
				throw null;
			}

			// Token: 0x1700034B RID: 843
			// (get) Token: 0x06000C49 RID: 3145 RVA: 0x00005243 File Offset: 0x00003443
			[global::Cpp2ILInjected.Token(Token = "0x170000A6")]
			internal int LineNo
			{
				[global::Cpp2ILInjected.Token(Token = "0x600032E")]
				[global::Cpp2ILInjected.Address(RVA = "0x1D7F13C", Offset = "0x1D7F13C", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				get
				{
					throw null;
				}
			}

			// Token: 0x1700034C RID: 844
			// (get) Token: 0x06000C4A RID: 3146 RVA: 0x00005246 File Offset: 0x00003446
			[global::Cpp2ILInjected.Token(Token = "0x170000A7")]
			internal int LinePos
			{
				[global::Cpp2ILInjected.Token(Token = "0x600032F")]
				[global::Cpp2ILInjected.Address(RVA = "0x1D7F144", Offset = "0x1D7F144", Length = "0x10")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 30)]
				get
				{
					throw null;
				}
			}

			// Token: 0x0400056A RID: 1386
			[global::Cpp2ILInjected.Token(Token = "0x4000192")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			internal char[] chars;

			// Token: 0x0400056B RID: 1387
			[global::Cpp2ILInjected.Token(Token = "0x4000193")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x8")]
			internal int charPos;

			// Token: 0x0400056C RID: 1388
			[global::Cpp2ILInjected.Token(Token = "0x4000194")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0xC")]
			internal int charsUsed;

			// Token: 0x0400056D RID: 1389
			[global::Cpp2ILInjected.Token(Token = "0x4000195")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
			internal Encoding encoding;

			// Token: 0x0400056E RID: 1390
			[global::Cpp2ILInjected.Token(Token = "0x4000196")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
			internal bool appendMode;

			// Token: 0x0400056F RID: 1391
			[global::Cpp2ILInjected.Token(Token = "0x4000197")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
			internal Stream stream;

			// Token: 0x04000570 RID: 1392
			[global::Cpp2ILInjected.Token(Token = "0x4000198")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
			internal Decoder decoder;

			// Token: 0x04000571 RID: 1393
			[global::Cpp2ILInjected.Token(Token = "0x4000199")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
			internal byte[] bytes;

			// Token: 0x04000572 RID: 1394
			[global::Cpp2ILInjected.Token(Token = "0x400019A")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
			internal int bytePos;

			// Token: 0x04000573 RID: 1395
			[global::Cpp2ILInjected.Token(Token = "0x400019B")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x3C")]
			internal int bytesUsed;

			// Token: 0x04000574 RID: 1396
			[global::Cpp2ILInjected.Token(Token = "0x400019C")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
			internal TextReader textReader;

			// Token: 0x04000575 RID: 1397
			[global::Cpp2ILInjected.Token(Token = "0x400019D")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
			internal int lineNo;

			// Token: 0x04000576 RID: 1398
			[global::Cpp2ILInjected.Token(Token = "0x400019E")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x4C")]
			internal int lineStartPos;

			// Token: 0x04000577 RID: 1399
			[global::Cpp2ILInjected.Token(Token = "0x400019F")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
			internal string baseUriStr;

			// Token: 0x04000578 RID: 1400
			[global::Cpp2ILInjected.Token(Token = "0x40001A0")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x58")]
			internal Uri baseUri;

			// Token: 0x04000579 RID: 1401
			[global::Cpp2ILInjected.Token(Token = "0x40001A1")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x60")]
			internal bool isEof;

			// Token: 0x0400057A RID: 1402
			[global::Cpp2ILInjected.Token(Token = "0x40001A2")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x61")]
			internal bool isStreamEof;

			// Token: 0x0400057B RID: 1403
			[global::Cpp2ILInjected.Token(Token = "0x40001A3")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x68")]
			internal IDtdEntityInfo entity;

			// Token: 0x0400057C RID: 1404
			[global::Cpp2ILInjected.Token(Token = "0x40001A4")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x70")]
			internal int entityId;

			// Token: 0x0400057D RID: 1405
			[global::Cpp2ILInjected.Token(Token = "0x40001A5")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x74")]
			internal bool eolNormalized;

			// Token: 0x0400057E RID: 1406
			[global::Cpp2ILInjected.Token(Token = "0x40001A6")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x75")]
			internal bool entityResolvedManually;
		}

		// Token: 0x02000155 RID: 341
		[global::Cpp2ILInjected.Token(Token = "0x2000046")]
		private class XmlContext
		{
			// Token: 0x06000C4B RID: 3147 RVA: 0x00005249 File Offset: 0x00003449
			[global::Cpp2ILInjected.Token(Token = "0x6000330")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D7F154", Offset = "0x1D7F154", Length = "0x64")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl), Member = ".ctor", MemberParameters = new object[] { typeof(XmlNameTable) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			internal XmlContext()
			{
				throw null;
			}

			// Token: 0x06000C4C RID: 3148 RVA: 0x0000524C File Offset: 0x0000344C
			[global::Cpp2ILInjected.Token(Token = "0x6000331")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D7F1B8", Offset = "0x1D7F1B8", Length = "0x38")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl), Member = "PushXmlContext", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			internal XmlContext(XmlTextReaderImpl.XmlContext previousContext)
			{
				throw null;
			}

			// Token: 0x0400057F RID: 1407
			[global::Cpp2ILInjected.Token(Token = "0x40001A7")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
			internal XmlSpace xmlSpace;

			// Token: 0x04000580 RID: 1408
			[global::Cpp2ILInjected.Token(Token = "0x40001A8")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
			internal string xmlLang;

			// Token: 0x04000581 RID: 1409
			[global::Cpp2ILInjected.Token(Token = "0x40001A9")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
			internal string defaultNamespace;

			// Token: 0x04000582 RID: 1410
			[global::Cpp2ILInjected.Token(Token = "0x40001AA")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
			internal XmlTextReaderImpl.XmlContext previousContext;
		}

		// Token: 0x02000156 RID: 342
		[global::Cpp2ILInjected.Token(Token = "0x2000047")]
		private class NoNamespaceManager : XmlNamespaceManager
		{
			// Token: 0x06000C4D RID: 3149 RVA: 0x0000524F File Offset: 0x0000344F
			[global::Cpp2ILInjected.Token(Token = "0x6000332")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D7F1F0", Offset = "0x1D7F1F0", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl), Member = "set_Namespaces", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlNamespaceManager), Member = ".ctor", ReturnType = typeof(void))]
			public NoNamespaceManager()
			{
				throw null;
			}

			// Token: 0x1700034D RID: 845
			// (get) Token: 0x06000C4E RID: 3150 RVA: 0x00005252 File Offset: 0x00003452
			[global::Cpp2ILInjected.Token(Token = "0x170000A8")]
			public override string DefaultNamespace
			{
				[global::Cpp2ILInjected.Token(Token = "0x6000333")]
				[global::Cpp2ILInjected.Address(RVA = "0x1D7F1F8", Offset = "0x1D7F1F8", Length = "0x48")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
				get
				{
					throw null;
				}
			}

			// Token: 0x06000C4F RID: 3151 RVA: 0x00005255 File Offset: 0x00003455
			[global::Cpp2ILInjected.Token(Token = "0x6000334")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D7F240", Offset = "0x1D7F240", Length = "0x4")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public override void PushScope()
			{
				throw null;
			}

			// Token: 0x06000C50 RID: 3152 RVA: 0x00005258 File Offset: 0x00003458
			[global::Cpp2ILInjected.Token(Token = "0x6000335")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D7F244", Offset = "0x1D7F244", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public override bool PopScope()
			{
				throw null;
			}

			// Token: 0x06000C51 RID: 3153 RVA: 0x0000525B File Offset: 0x0000345B
			[global::Cpp2ILInjected.Token(Token = "0x6000336")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D7F24C", Offset = "0x1D7F24C", Length = "0x4")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public override void AddNamespace(string prefix, string uri)
			{
				throw null;
			}

			// Token: 0x06000C52 RID: 3154 RVA: 0x0000525E File Offset: 0x0000345E
			[global::Cpp2ILInjected.Token(Token = "0x6000337")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D7F250", Offset = "0x1D7F250", Length = "0x4")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public override void RemoveNamespace(string prefix, string uri)
			{
				throw null;
			}

			// Token: 0x06000C53 RID: 3155 RVA: 0x00005261 File Offset: 0x00003461
			[global::Cpp2ILInjected.Token(Token = "0x6000338")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D7F254", Offset = "0x1D7F254", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public override IEnumerator GetEnumerator()
			{
				throw null;
			}

			// Token: 0x06000C54 RID: 3156 RVA: 0x00005264 File Offset: 0x00003464
			[global::Cpp2ILInjected.Token(Token = "0x6000339")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D7F25C", Offset = "0x1D7F25C", Length = "0x48")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			public override string LookupNamespace(string prefix)
			{
				throw null;
			}

			// Token: 0x06000C55 RID: 3157 RVA: 0x00005267 File Offset: 0x00003467
			[global::Cpp2ILInjected.Token(Token = "0x600033A")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D7F2A4", Offset = "0x1D7F2A4", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public override string LookupPrefix(string uri)
			{
				throw null;
			}
		}

		// Token: 0x02000157 RID: 343
		[global::Cpp2ILInjected.Token(Token = "0x2000048")]
		internal class DtdParserProxy : IDtdParserAdapterV1, IDtdParserAdapterWithValidation, IDtdParserAdapter
		{
			// Token: 0x06000C56 RID: 3158 RVA: 0x0000526A File Offset: 0x0000346A
			[global::Cpp2ILInjected.Token(Token = "0x600033B")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D7F2AC", Offset = "0x1D7F2AC", Length = "0x28")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseDtd", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseDtdFromParserContext", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlLoader), Member = "ParseDocumentType", MemberParameters = new object[]
			{
				typeof(XmlDocumentType),
				typeof(bool),
				typeof(XmlResolver)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlLoader), Member = "CreateInnerXmlReader", MemberParameters = new object[]
			{
				typeof(string),
				typeof(XmlNodeType),
				typeof(XmlParserContext),
				typeof(XmlDocument)
			}, ReturnType = typeof(XmlReader))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			internal DtdParserProxy(XmlTextReaderImpl reader)
			{
				throw null;
			}

			// Token: 0x1700034E RID: 846
			// (get) Token: 0x06000C57 RID: 3159 RVA: 0x0000526D File Offset: 0x0000346D
			[global::Cpp2ILInjected.Token(Token = "0x170000A9")]
			private XmlNameTable System.Xml.IDtdParserAdapter.NameTable
			{
				[global::Cpp2ILInjected.Token(Token = "0x600033C")]
				[global::Cpp2ILInjected.Address(RVA = "0x1D7F2D4", Offset = "0x1D7F2D4", Length = "0xC")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				get
				{
					throw null;
				}
			}

			// Token: 0x1700034F RID: 847
			// (get) Token: 0x06000C58 RID: 3160 RVA: 0x00005270 File Offset: 0x00003470
			[global::Cpp2ILInjected.Token(Token = "0x170000AA")]
			private IXmlNamespaceResolver System.Xml.IDtdParserAdapter.NamespaceResolver
			{
				[global::Cpp2ILInjected.Token(Token = "0x600033D")]
				[global::Cpp2ILInjected.Address(RVA = "0x1D7F2E0", Offset = "0x1D7F2E0", Length = "0xC")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				get
				{
					throw null;
				}
			}

			// Token: 0x17000350 RID: 848
			// (get) Token: 0x06000C59 RID: 3161 RVA: 0x00005273 File Offset: 0x00003473
			[global::Cpp2ILInjected.Token(Token = "0x170000AB")]
			private Uri System.Xml.IDtdParserAdapter.BaseUri
			{
				[global::Cpp2ILInjected.Token(Token = "0x600033E")]
				[global::Cpp2ILInjected.Address(RVA = "0x1D7F2EC", Offset = "0x1D7F2EC", Length = "0xC")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlTextReaderImpl), Member = "get_DtdParserProxy_BaseUri", ReturnType = typeof(Uri))]
				get
				{
					throw null;
				}
			}

			// Token: 0x17000351 RID: 849
			// (get) Token: 0x06000C5A RID: 3162 RVA: 0x00005276 File Offset: 0x00003476
			[global::Cpp2ILInjected.Token(Token = "0x170000AC")]
			private bool System.Xml.IDtdParserAdapter.IsEof
			{
				[global::Cpp2ILInjected.Token(Token = "0x600033F")]
				[global::Cpp2ILInjected.Address(RVA = "0x1D7F2F8", Offset = "0x1D7F2F8", Length = "0xC")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlTextReaderImpl), Member = "get_DtdParserProxy_IsEof", ReturnType = typeof(bool))]
				get
				{
					throw null;
				}
			}

			// Token: 0x17000352 RID: 850
			// (get) Token: 0x06000C5B RID: 3163 RVA: 0x00005279 File Offset: 0x00003479
			[global::Cpp2ILInjected.Token(Token = "0x170000AD")]
			private char[] System.Xml.IDtdParserAdapter.ParsingBuffer
			{
				[global::Cpp2ILInjected.Token(Token = "0x6000340")]
				[global::Cpp2ILInjected.Address(RVA = "0x1D7F304", Offset = "0x1D7F304", Length = "0xC")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlTextReaderImpl), Member = "get_DtdParserProxy_ParsingBuffer", ReturnType = typeof(char[]))]
				get
				{
					throw null;
				}
			}

			// Token: 0x17000353 RID: 851
			// (get) Token: 0x06000C5C RID: 3164 RVA: 0x0000527C File Offset: 0x0000347C
			[global::Cpp2ILInjected.Token(Token = "0x170000AE")]
			private int System.Xml.IDtdParserAdapter.ParsingBufferLength
			{
				[global::Cpp2ILInjected.Token(Token = "0x6000341")]
				[global::Cpp2ILInjected.Address(RVA = "0x1D7F310", Offset = "0x1D7F310", Length = "0xC")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlTextReaderImpl), Member = "get_DtdParserProxy_ParsingBufferLength", ReturnType = typeof(int))]
				get
				{
					throw null;
				}
			}

			// Token: 0x17000354 RID: 852
			// (get) Token: 0x06000C5D RID: 3165 RVA: 0x0000527F File Offset: 0x0000347F
			// (set) Token: 0x06000C5E RID: 3166 RVA: 0x00005282 File Offset: 0x00003482
			[global::Cpp2ILInjected.Token(Token = "0x170000AF")]
			private int System.Xml.IDtdParserAdapter.CurrentPosition
			{
				[global::Cpp2ILInjected.Token(Token = "0x6000342")]
				[global::Cpp2ILInjected.Address(RVA = "0x1D7F31C", Offset = "0x1D7F31C", Length = "0xC")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlTextReaderImpl), Member = "get_DtdParserProxy_CurrentPosition", ReturnType = typeof(int))]
				get
				{
					throw null;
				}
				[global::Cpp2ILInjected.Token(Token = "0x6000343")]
				[global::Cpp2ILInjected.Address(RVA = "0x1D7F328", Offset = "0x1D7F328", Length = "0xC")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlTextReaderImpl), Member = "set_DtdParserProxy_CurrentPosition", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
				set
				{
					throw null;
				}
			}

			// Token: 0x17000355 RID: 853
			// (get) Token: 0x06000C5F RID: 3167 RVA: 0x00005285 File Offset: 0x00003485
			[global::Cpp2ILInjected.Token(Token = "0x170000B0")]
			private int System.Xml.IDtdParserAdapter.EntityStackLength
			{
				[global::Cpp2ILInjected.Token(Token = "0x6000344")]
				[global::Cpp2ILInjected.Address(RVA = "0x1D7F334", Offset = "0x1D7F334", Length = "0xC")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlTextReaderImpl), Member = "get_DtdParserProxy_EntityStackLength", ReturnType = typeof(int))]
				get
				{
					throw null;
				}
			}

			// Token: 0x17000356 RID: 854
			// (get) Token: 0x06000C60 RID: 3168 RVA: 0x00005288 File Offset: 0x00003488
			[global::Cpp2ILInjected.Token(Token = "0x170000B1")]
			private bool System.Xml.IDtdParserAdapter.IsEntityEolNormalized
			{
				[global::Cpp2ILInjected.Token(Token = "0x6000345")]
				[global::Cpp2ILInjected.Address(RVA = "0x1D7F340", Offset = "0x1D7F340", Length = "0xC")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlTextReaderImpl), Member = "get_DtdParserProxy_IsEntityEolNormalized", ReturnType = typeof(bool))]
				get
				{
					throw null;
				}
			}

			// Token: 0x06000C61 RID: 3169 RVA: 0x0000528B File Offset: 0x0000348B
			[global::Cpp2ILInjected.Token(Token = "0x6000346")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D7F34C", Offset = "0x1D7F34C", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlTextReaderImpl), Member = "DtdParserProxy_OnNewLine", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
			private void System.Xml.IDtdParserAdapter.OnNewLine(int pos)
			{
				throw null;
			}

			// Token: 0x17000357 RID: 855
			// (get) Token: 0x06000C62 RID: 3170 RVA: 0x0000528E File Offset: 0x0000348E
			[global::Cpp2ILInjected.Token(Token = "0x170000B2")]
			private int System.Xml.IDtdParserAdapter.LineNo
			{
				[global::Cpp2ILInjected.Token(Token = "0x6000347")]
				[global::Cpp2ILInjected.Address(RVA = "0x1D7F358", Offset = "0x1D7F358", Length = "0xC")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlTextReaderImpl), Member = "get_DtdParserProxy_LineNo", ReturnType = typeof(int))]
				get
				{
					throw null;
				}
			}

			// Token: 0x17000358 RID: 856
			// (get) Token: 0x06000C63 RID: 3171 RVA: 0x00005291 File Offset: 0x00003491
			[global::Cpp2ILInjected.Token(Token = "0x170000B3")]
			private int System.Xml.IDtdParserAdapter.LineStartPosition
			{
				[global::Cpp2ILInjected.Token(Token = "0x6000348")]
				[global::Cpp2ILInjected.Address(RVA = "0x1D7F364", Offset = "0x1D7F364", Length = "0xC")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlTextReaderImpl), Member = "get_DtdParserProxy_LineStartPosition", ReturnType = typeof(int))]
				get
				{
					throw null;
				}
			}

			// Token: 0x06000C64 RID: 3172 RVA: 0x00005294 File Offset: 0x00003494
			[global::Cpp2ILInjected.Token(Token = "0x6000349")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D7F370", Offset = "0x1D7F370", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlTextReaderImpl), Member = "DtdParserProxy_ReadData", ReturnType = typeof(int))]
			private int System.Xml.IDtdParserAdapter.ReadData()
			{
				throw null;
			}

			// Token: 0x06000C65 RID: 3173 RVA: 0x00005297 File Offset: 0x00003497
			[global::Cpp2ILInjected.Token(Token = "0x600034A")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D7F37C", Offset = "0x1D7F37C", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlTextReaderImpl), Member = "DtdParserProxy_ParseNumericCharRef", MemberParameters = new object[] { typeof(StringBuilder) }, ReturnType = typeof(int))]
			private int System.Xml.IDtdParserAdapter.ParseNumericCharRef(StringBuilder internalSubsetBuilder)
			{
				throw null;
			}

			// Token: 0x06000C66 RID: 3174 RVA: 0x0000529A File Offset: 0x0000349A
			[global::Cpp2ILInjected.Token(Token = "0x600034B")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D7F388", Offset = "0x1D7F388", Length = "0x10")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlTextReaderImpl), Member = "DtdParserProxy_ParseNamedCharRef", MemberParameters = new object[]
			{
				typeof(bool),
				typeof(StringBuilder)
			}, ReturnType = typeof(int))]
			private int System.Xml.IDtdParserAdapter.ParseNamedCharRef(bool expand, StringBuilder internalSubsetBuilder)
			{
				throw null;
			}

			// Token: 0x06000C67 RID: 3175 RVA: 0x0000529D File Offset: 0x0000349D
			[global::Cpp2ILInjected.Token(Token = "0x600034C")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D7F398", Offset = "0x1D7F398", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlTextReaderImpl), Member = "DtdParserProxy_ParsePI", MemberParameters = new object[] { typeof(StringBuilder) }, ReturnType = typeof(void))]
			private void System.Xml.IDtdParserAdapter.ParsePI(StringBuilder sb)
			{
				throw null;
			}

			// Token: 0x06000C68 RID: 3176 RVA: 0x000052A0 File Offset: 0x000034A0
			[global::Cpp2ILInjected.Token(Token = "0x600034D")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D7F3A4", Offset = "0x1D7F3A4", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlTextReaderImpl), Member = "DtdParserProxy_ParseComment", MemberParameters = new object[] { typeof(StringBuilder) }, ReturnType = typeof(void))]
			private void System.Xml.IDtdParserAdapter.ParseComment(StringBuilder sb)
			{
				throw null;
			}

			// Token: 0x06000C69 RID: 3177 RVA: 0x000052A3 File Offset: 0x000034A3
			[global::Cpp2ILInjected.Token(Token = "0x600034E")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D7F3B0", Offset = "0x1D7F3B0", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlTextReaderImpl), Member = "DtdParserProxy_PushEntity", MemberParameters = new object[]
			{
				typeof(IDtdEntityInfo),
				typeof(ref int)
			}, ReturnType = typeof(bool))]
			private bool System.Xml.IDtdParserAdapter.PushEntity(IDtdEntityInfo entity, out int entityId)
			{
				throw null;
			}

			// Token: 0x06000C6A RID: 3178 RVA: 0x000052A6 File Offset: 0x000034A6
			[global::Cpp2ILInjected.Token(Token = "0x600034F")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D7F3BC", Offset = "0x1D7F3BC", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlTextReaderImpl), Member = "DtdParserProxy_PopEntity", MemberParameters = new object[]
			{
				typeof(ref IDtdEntityInfo),
				typeof(ref int)
			}, ReturnType = typeof(bool))]
			private bool System.Xml.IDtdParserAdapter.PopEntity(out IDtdEntityInfo oldEntity, out int newEntityId)
			{
				throw null;
			}

			// Token: 0x06000C6B RID: 3179 RVA: 0x000052A9 File Offset: 0x000034A9
			[global::Cpp2ILInjected.Token(Token = "0x6000350")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D7F3C8", Offset = "0x1D7F3C8", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlTextReaderImpl), Member = "DtdParserProxy_PushExternalSubset", MemberParameters = new object[]
			{
				typeof(string),
				typeof(string)
			}, ReturnType = typeof(bool))]
			private bool System.Xml.IDtdParserAdapter.PushExternalSubset(string systemId, string publicId)
			{
				throw null;
			}

			// Token: 0x06000C6C RID: 3180 RVA: 0x000052AC File Offset: 0x000034AC
			[global::Cpp2ILInjected.Token(Token = "0x6000351")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D7F3D4", Offset = "0x1D7F3D4", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlTextReaderImpl), Member = "DtdParserProxy_PushInternalDtd", MemberParameters = new object[]
			{
				typeof(string),
				typeof(string)
			}, ReturnType = typeof(void))]
			private void System.Xml.IDtdParserAdapter.PushInternalDtd(string baseUri, string internalDtd)
			{
				throw null;
			}

			// Token: 0x06000C6D RID: 3181 RVA: 0x000052AF File Offset: 0x000034AF
			[global::Cpp2ILInjected.Token(Token = "0x6000352")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D7F3E0", Offset = "0x1D7F3E0", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlTextReaderImpl), Member = "DtdParserProxy_Throw", MemberParameters = new object[] { typeof(Exception) }, ReturnType = typeof(void))]
			private void System.Xml.IDtdParserAdapter.Throw(Exception e)
			{
				throw null;
			}

			// Token: 0x06000C6E RID: 3182 RVA: 0x000052B2 File Offset: 0x000034B2
			[global::Cpp2ILInjected.Token(Token = "0x6000353")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D7F3EC", Offset = "0x1D7F3EC", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlTextReaderImpl), Member = "DtdParserProxy_OnSystemId", MemberParameters = new object[]
			{
				typeof(string),
				typeof(LineInfo),
				typeof(LineInfo)
			}, ReturnType = typeof(void))]
			private void System.Xml.IDtdParserAdapter.OnSystemId(string systemId, LineInfo keywordLineInfo, LineInfo systemLiteralLineInfo)
			{
				throw null;
			}

			// Token: 0x06000C6F RID: 3183 RVA: 0x000052B5 File Offset: 0x000034B5
			[global::Cpp2ILInjected.Token(Token = "0x6000354")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D7F3F8", Offset = "0x1D7F3F8", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlTextReaderImpl), Member = "DtdParserProxy_OnPublicId", MemberParameters = new object[]
			{
				typeof(string),
				typeof(LineInfo),
				typeof(LineInfo)
			}, ReturnType = typeof(void))]
			private void System.Xml.IDtdParserAdapter.OnPublicId(string publicId, LineInfo keywordLineInfo, LineInfo publicLiteralLineInfo)
			{
				throw null;
			}

			// Token: 0x17000359 RID: 857
			// (get) Token: 0x06000C70 RID: 3184 RVA: 0x000052B8 File Offset: 0x000034B8
			[global::Cpp2ILInjected.Token(Token = "0x170000B4")]
			private bool System.Xml.IDtdParserAdapterWithValidation.DtdValidation
			{
				[global::Cpp2ILInjected.Token(Token = "0x6000355")]
				[global::Cpp2ILInjected.Address(RVA = "0x1D7F404", Offset = "0x1D7F404", Length = "0xC")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlTextReaderImpl), Member = "get_DtdParserProxy_DtdValidation", ReturnType = typeof(bool))]
				get
				{
					throw null;
				}
			}

			// Token: 0x1700035A RID: 858
			// (get) Token: 0x06000C71 RID: 3185 RVA: 0x000052BB File Offset: 0x000034BB
			[global::Cpp2ILInjected.Token(Token = "0x170000B5")]
			private IValidationEventHandling System.Xml.IDtdParserAdapterWithValidation.ValidationEventHandling
			{
				[global::Cpp2ILInjected.Token(Token = "0x6000356")]
				[global::Cpp2ILInjected.Address(RVA = "0x1D7F410", Offset = "0x1D7F410", Length = "0xC")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				get
				{
					throw null;
				}
			}

			// Token: 0x1700035B RID: 859
			// (get) Token: 0x06000C72 RID: 3186 RVA: 0x000052BE File Offset: 0x000034BE
			[global::Cpp2ILInjected.Token(Token = "0x170000B6")]
			private bool System.Xml.IDtdParserAdapterV1.Normalization
			{
				[global::Cpp2ILInjected.Token(Token = "0x6000357")]
				[global::Cpp2ILInjected.Address(RVA = "0x1D7F41C", Offset = "0x1D7F41C", Length = "0xC")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				get
				{
					throw null;
				}
			}

			// Token: 0x1700035C RID: 860
			// (get) Token: 0x06000C73 RID: 3187 RVA: 0x000052C1 File Offset: 0x000034C1
			[global::Cpp2ILInjected.Token(Token = "0x170000B7")]
			private bool System.Xml.IDtdParserAdapterV1.Namespaces
			{
				[global::Cpp2ILInjected.Token(Token = "0x6000358")]
				[global::Cpp2ILInjected.Address(RVA = "0x1D7F428", Offset = "0x1D7F428", Length = "0xC")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				get
				{
					throw null;
				}
			}

			// Token: 0x1700035D RID: 861
			// (get) Token: 0x06000C74 RID: 3188 RVA: 0x000052C4 File Offset: 0x000034C4
			[global::Cpp2ILInjected.Token(Token = "0x170000B8")]
			private bool System.Xml.IDtdParserAdapterV1.V1CompatibilityMode
			{
				[global::Cpp2ILInjected.Token(Token = "0x6000359")]
				[global::Cpp2ILInjected.Address(RVA = "0x1D7F434", Offset = "0x1D7F434", Length = "0xC")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				get
				{
					throw null;
				}
			}

			// Token: 0x04000583 RID: 1411
			[global::Cpp2ILInjected.Token(Token = "0x40001AB")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
			private XmlTextReaderImpl reader;
		}

		// Token: 0x02000158 RID: 344
		[global::Cpp2ILInjected.Token(Token = "0x2000049")]
		private class NodeData : IComparable
		{
			// Token: 0x1700035E RID: 862
			// (get) Token: 0x06000C75 RID: 3189 RVA: 0x000052C7 File Offset: 0x000034C7
			[global::Cpp2ILInjected.Token(Token = "0x170000B9")]
			internal static XmlTextReaderImpl.NodeData None
			{
				[global::Cpp2ILInjected.Token(Token = "0x600035A")]
				[global::Cpp2ILInjected.Address(RVA = "0x1D7F440", Offset = "0x1D7F440", Length = "0x98")]
				[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl), Member = "Close", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlTextReaderImpl.NodeData), Member = "Clear", MemberParameters = new object[] { typeof(XmlNodeType) }, ReturnType = typeof(void))]
				[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
				get
				{
					throw null;
				}
			}

			// Token: 0x06000C76 RID: 3190 RVA: 0x000052CA File Offset: 0x000034CA
			[global::Cpp2ILInjected.Token(Token = "0x600035B")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D7F4D8", Offset = "0x1D7F4D8", Length = "0x28")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl), Member = ".ctor", MemberParameters = new object[] { typeof(XmlNameTable) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseAttributeValueSlow", MemberParameters = new object[]
			{
				typeof(int),
				typeof(char),
				typeof(XmlTextReaderImpl.NodeData)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl), Member = "AllocNode", MemberParameters = new object[]
			{
				typeof(int),
				typeof(int)
			}, ReturnType = typeof(XmlTextReaderImpl.NodeData))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 7)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlTextReaderImpl.NodeData), Member = "Clear", MemberParameters = new object[] { typeof(XmlNodeType) }, ReturnType = typeof(void))]
			internal NodeData()
			{
				throw null;
			}

			// Token: 0x1700035F RID: 863
			// (get) Token: 0x06000C77 RID: 3191 RVA: 0x000052CD File Offset: 0x000034CD
			[global::Cpp2ILInjected.Token(Token = "0x170000BA")]
			internal int LineNo
			{
				[global::Cpp2ILInjected.Token(Token = "0x600035C")]
				[global::Cpp2ILInjected.Address(RVA = "0x1D7F58C", Offset = "0x1D7F58C", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl), Member = "AddDefaultAttributesAndNormalize", ReturnType = typeof(void))]
				[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl), Member = "AttributeDuplCheck", ReturnType = typeof(void))]
				[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl), Member = "LookupNamespace", MemberParameters = new object[] { typeof(XmlTextReaderImpl.NodeData) }, ReturnType = typeof(string))]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
				get
				{
					throw null;
				}
			}

			// Token: 0x17000360 RID: 864
			// (get) Token: 0x06000C78 RID: 3192 RVA: 0x000052D0 File Offset: 0x000034D0
			[global::Cpp2ILInjected.Token(Token = "0x170000BB")]
			internal int LinePos
			{
				[global::Cpp2ILInjected.Token(Token = "0x600035D")]
				[global::Cpp2ILInjected.Address(RVA = "0x1D7F594", Offset = "0x1D7F594", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ResolveEntity", ReturnType = typeof(void))]
				[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl), Member = "AddDefaultAttributesAndNormalize", ReturnType = typeof(void))]
				[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl), Member = "AttributeDuplCheck", ReturnType = typeof(void))]
				[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl), Member = "LookupNamespace", MemberParameters = new object[] { typeof(XmlTextReaderImpl.NodeData) }, ReturnType = typeof(string))]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 7)]
				get
				{
					throw null;
				}
			}

			// Token: 0x17000361 RID: 865
			// (get) Token: 0x06000C79 RID: 3193 RVA: 0x000052D3 File Offset: 0x000034D3
			// (set) Token: 0x06000C7A RID: 3194 RVA: 0x000052D6 File Offset: 0x000034D6
			[global::Cpp2ILInjected.Token(Token = "0x170000BC")]
			internal bool IsEmptyElement
			{
				[global::Cpp2ILInjected.Token(Token = "0x600035E")]
				[global::Cpp2ILInjected.Address(RVA = "0x1D7F59C", Offset = "0x1D7F59C", Length = "0x24")]
				[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
				[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl), Member = "get_IsEmptyElement", ReturnType = typeof(bool))]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
				get
				{
					throw null;
				}
				[global::Cpp2ILInjected.Token(Token = "0x600035F")]
				[global::Cpp2ILInjected.Address(RVA = "0x1D7F5C0", Offset = "0x1D7F5C0", Length = "0xC")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				set
				{
					throw null;
				}
			}

			// Token: 0x17000362 RID: 866
			// (get) Token: 0x06000C7B RID: 3195 RVA: 0x000052D9 File Offset: 0x000034D9
			// (set) Token: 0x06000C7C RID: 3196 RVA: 0x000052DC File Offset: 0x000034DC
			[global::Cpp2ILInjected.Token(Token = "0x170000BD")]
			internal bool IsDefaultAttribute
			{
				[global::Cpp2ILInjected.Token(Token = "0x6000360")]
				[global::Cpp2ILInjected.Address(RVA = "0x1D7F5CC", Offset = "0x1D7F5CC", Length = "0x24")]
				[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
				[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl), Member = "get_IsDefault", ReturnType = typeof(bool))]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
				get
				{
					throw null;
				}
				[global::Cpp2ILInjected.Token(Token = "0x6000361")]
				[global::Cpp2ILInjected.Address(RVA = "0x1D7F5F0", Offset = "0x1D7F5F0", Length = "0xC")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				set
				{
					throw null;
				}
			}

			// Token: 0x17000363 RID: 867
			// (get) Token: 0x06000C7D RID: 3197 RVA: 0x000052DF File Offset: 0x000034DF
			[global::Cpp2ILInjected.Token(Token = "0x170000BE")]
			internal bool ValueBuffered
			{
				[global::Cpp2ILInjected.Token(Token = "0x6000362")]
				[global::Cpp2ILInjected.Address(RVA = "0x1D7F5FC", Offset = "0x1D7F5FC", Length = "0x10")]
				[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				get
				{
					throw null;
				}
			}

			// Token: 0x17000364 RID: 868
			// (get) Token: 0x06000C7E RID: 3198 RVA: 0x000052E2 File Offset: 0x000034E2
			[global::Cpp2ILInjected.Token(Token = "0x170000BF")]
			internal string StringValue
			{
				[global::Cpp2ILInjected.Token(Token = "0x6000363")]
				[global::Cpp2ILInjected.Address(RVA = "0x1D7F60C", Offset = "0x1D7F60C", Length = "0x2C")]
				[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl), Member = "get_Value", ReturnType = typeof(string))]
				[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ReadAttributeValue", ReturnType = typeof(bool))]
				[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl), Member = "AddDefaultAttributesAndNormalize", ReturnType = typeof(void))]
				[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl), Member = "OnDefaultNamespaceDecl", MemberParameters = new object[] { typeof(XmlTextReaderImpl.NodeData) }, ReturnType = typeof(void))]
				[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl), Member = "OnNamespaceDecl", MemberParameters = new object[] { typeof(XmlTextReaderImpl.NodeData) }, ReturnType = typeof(void))]
				[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl), Member = "OnXmlReservedAttribute", MemberParameters = new object[] { typeof(XmlTextReaderImpl.NodeData) }, ReturnType = typeof(void))]
				[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl), Member = "FinishOtherValueIterator", ReturnType = typeof(void))]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 10)]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "CreateString", MemberParameters = new object[]
				{
					typeof(char[]),
					typeof(int),
					typeof(int)
				}, ReturnType = typeof(string))]
				get
				{
					throw null;
				}
			}

			// Token: 0x06000C7F RID: 3199 RVA: 0x000052E5 File Offset: 0x000034E5
			[global::Cpp2ILInjected.Token(Token = "0x6000364")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D7F638", Offset = "0x1D7F638", Length = "0x3C")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl), Member = "AddDefaultAttributesAndNormalize", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlTextReaderImpl), Member = "StripSpaces", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlTextReaderImpl), Member = "StripSpaces", MemberParameters = new object[]
			{
				typeof(char[]),
				typeof(int),
				typeof(ref int)
			}, ReturnType = typeof(void))]
			internal void TrimSpacesInValue()
			{
				throw null;
			}

			// Token: 0x06000C80 RID: 3200 RVA: 0x000052E8 File Offset: 0x000034E8
			[global::Cpp2ILInjected.Token(Token = "0x6000365")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D7F500", Offset = "0x1D7F500", Length = "0x8C")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl.NodeData), Member = "get_None", ReturnType = typeof(XmlTextReaderImpl.NodeData))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl.NodeData), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl), Member = "OnEof", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			internal void Clear(XmlNodeType type)
			{
				throw null;
			}

			// Token: 0x06000C81 RID: 3201 RVA: 0x000052EB File Offset: 0x000034EB
			[global::Cpp2ILInjected.Token(Token = "0x6000366")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D7F674", Offset = "0x1D7F674", Length = "0x54")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			internal void ClearName()
			{
				throw null;
			}

			// Token: 0x06000C82 RID: 3202 RVA: 0x000052EE File Offset: 0x000034EE
			[global::Cpp2ILInjected.Token(Token = "0x6000367")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D7F6C8", Offset = "0x1D7F6C8", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl), Member = "Read", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl), Member = "Throw", MemberParameters = new object[] { typeof(Exception) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseXmlDeclaration", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseElement", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseAttributes", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseText", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseRootLevelWhitespace", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseEntityReference", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParsePI", MemberParameters = new object[] { typeof(StringBuilder) }, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseCDataOrComment", MemberParameters = new object[] { typeof(XmlNodeType) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseDoctypeDecl", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl), Member = "OnEof", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseAttributeValueChunk", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 14)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LineInfo), Member = "Set", MemberParameters = new object[]
			{
				typeof(int),
				typeof(int)
			}, ReturnType = typeof(void))]
			internal void SetLineInfo(int lineNo, int linePos)
			{
				throw null;
			}

			// Token: 0x06000C83 RID: 3203 RVA: 0x000052F1 File Offset: 0x000034F1
			[global::Cpp2ILInjected.Token(Token = "0x6000368")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D7F6D4", Offset = "0x1D7F6D4", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseXmlDeclaration", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseAttributes", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LineInfo), Member = "Set", MemberParameters = new object[]
			{
				typeof(int),
				typeof(int)
			}, ReturnType = typeof(void))]
			internal void SetLineInfo2(int lineNo, int linePos)
			{
				throw null;
			}

			// Token: 0x06000C84 RID: 3204 RVA: 0x000052F4 File Offset: 0x000034F4
			[global::Cpp2ILInjected.Token(Token = "0x6000369")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D7F6E0", Offset = "0x1D7F6E0", Length = "0x70")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl), Member = "Read", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ReadAttributeValue", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseAttributeValueSlow", MemberParameters = new object[]
			{
				typeof(int),
				typeof(char),
				typeof(XmlTextReaderImpl.NodeData)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseText", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseRootLevelWhitespace", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseCDataOrComment", MemberParameters = new object[] { typeof(XmlNodeType) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseAttributeValueChunk", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 11)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			internal void SetValueNode(XmlNodeType type, string value)
			{
				throw null;
			}

			// Token: 0x06000C85 RID: 3205 RVA: 0x000052F7 File Offset: 0x000034F7
			[global::Cpp2ILInjected.Token(Token = "0x600036A")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D7F750", Offset = "0x1D7F750", Length = "0x7C")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseText", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseCDataOrComment", MemberParameters = new object[] { typeof(XmlNodeType) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			internal void SetValueNode(XmlNodeType type, char[] chars, int startPos, int len)
			{
				throw null;
			}

			// Token: 0x06000C86 RID: 3206 RVA: 0x000052FA File Offset: 0x000034FA
			[global::Cpp2ILInjected.Token(Token = "0x600036B")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D7F7CC", Offset = "0x1D7F7CC", Length = "0xA8")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseXmlDeclaration", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseElement", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseAttributeValueSlow", MemberParameters = new object[]
			{
				typeof(int),
				typeof(char),
				typeof(XmlTextReaderImpl.NodeData)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseEntityReference", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl), Member = "SetupEndEntityNodeInContent", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParsePI", MemberParameters = new object[] { typeof(StringBuilder) }, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl), Member = "AddAttributeNoChecks", MemberParameters = new object[]
			{
				typeof(string),
				typeof(int)
			}, ReturnType = typeof(XmlTextReaderImpl.NodeData))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseAttributeValueChunk", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 9)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			internal void SetNamedNode(XmlNodeType type, string localName)
			{
				throw null;
			}

			// Token: 0x06000C87 RID: 3207 RVA: 0x000052FD File Offset: 0x000034FD
			[global::Cpp2ILInjected.Token(Token = "0x600036C")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D7F874", Offset = "0x1D7F874", Length = "0x88")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseElement", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseDtd", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl), Member = "AddAttribute", MemberParameters = new object[]
			{
				typeof(string),
				typeof(string),
				typeof(string)
			}, ReturnType = typeof(XmlTextReaderImpl.NodeData))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			internal void SetNamedNode(XmlNodeType type, string localName, string prefix, string nameWPrefix)
			{
				throw null;
			}

			// Token: 0x06000C88 RID: 3208 RVA: 0x00005300 File Offset: 0x00003500
			[global::Cpp2ILInjected.Token(Token = "0x600036D")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D7F8FC", Offset = "0x1D7F8FC", Length = "0x10")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl), Member = "DtdParserProxy_OnSystemId", MemberParameters = new object[]
			{
				typeof(string),
				typeof(LineInfo),
				typeof(LineInfo)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl), Member = "DtdParserProxy_OnPublicId", MemberParameters = new object[]
			{
				typeof(string),
				typeof(LineInfo),
				typeof(LineInfo)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseXmlDeclaration", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseAttributeValueSlow", MemberParameters = new object[]
			{
				typeof(int),
				typeof(char),
				typeof(XmlTextReaderImpl.NodeData)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl), Member = "FinishPartialValue", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl), Member = "FinishOtherValueIterator", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParsePI", MemberParameters = new object[] { typeof(StringBuilder) }, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseDtd", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl), Member = "SkipDtd", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl), Member = "AddDefaultAttributeInternal", MemberParameters = new object[]
			{
				typeof(string),
				typeof(string),
				typeof(string),
				typeof(string),
				typeof(int),
				typeof(int),
				typeof(int),
				typeof(int),
				typeof(bool)
			}, ReturnType = typeof(XmlTextReaderImpl.NodeData))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 12)]
			internal void SetValue(string value)
			{
				throw null;
			}

			// Token: 0x06000C89 RID: 3209 RVA: 0x00005303 File Offset: 0x00003503
			[global::Cpp2ILInjected.Token(Token = "0x600036E")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D7F90C", Offset = "0x1D7F90C", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseXmlDeclaration", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParseAttributes", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ParsePI", MemberParameters = new object[] { typeof(StringBuilder) }, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
			internal void SetValue(char[] chars, int startPos, int len)
			{
				throw null;
			}

			// Token: 0x06000C8A RID: 3210 RVA: 0x00005306 File Offset: 0x00003506
			[global::Cpp2ILInjected.Token(Token = "0x600036F")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D7F918", Offset = "0x1D7F918", Length = "0x38")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ReadData", ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "CreateString", MemberParameters = new object[]
			{
				typeof(char[]),
				typeof(int),
				typeof(int)
			}, ReturnType = typeof(string))]
			internal void OnBufferInvalidated()
			{
				throw null;
			}

			// Token: 0x06000C8B RID: 3211 RVA: 0x00005309 File Offset: 0x00003509
			[global::Cpp2ILInjected.Token(Token = "0x6000370")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D7F950", Offset = "0x1D7F950", Length = "0x60")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl), Member = "DtdParserProxy_ParseComment", MemberParameters = new object[] { typeof(StringBuilder) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl), Member = "FinishPartialValue", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new object[]
			{
				typeof(string),
				typeof(int),
				typeof(int)
			}, ReturnType = typeof(StringBuilder))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new object[]
			{
				typeof(char[]),
				typeof(int),
				typeof(int)
			}, ReturnType = typeof(StringBuilder))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(StringBuilder))]
			internal void CopyTo(int valueOffset, StringBuilder sb)
			{
				throw null;
			}

			// Token: 0x06000C8C RID: 3212 RVA: 0x0000530C File Offset: 0x0000350C
			[global::Cpp2ILInjected.Token(Token = "0x6000371")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D7F9B0", Offset = "0x1D7F9B0", Length = "0x14")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsInvalidInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl), Member = "get_Name", ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ThrowUnclosedElements", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl), Member = "AddDefaultAttributesAndNormalize", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl), Member = "ThrowTagMismatch", MemberParameters = new object[] { typeof(XmlTextReaderImpl.NodeData) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl), Member = "AttributeDuplCheck", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl), Member = "IncrementalRead", ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl), Member = "GetIndexOfAttributeWithPrefix", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 8)]
			internal string GetNameWPrefix(XmlNameTable nt)
			{
				throw null;
			}

			// Token: 0x06000C8D RID: 3213 RVA: 0x0000530F File Offset: 0x0000350F
			[global::Cpp2ILInjected.Token(Token = "0x6000372")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D7F9C4", Offset = "0x1D7F9C4", Length = "0x7C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
			{
				typeof(string),
				typeof(string),
				typeof(string)
			}, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			internal string CreateNameWPrefix(XmlNameTable nt)
			{
				throw null;
			}

			// Token: 0x06000C8E RID: 3214 RVA: 0x00005312 File Offset: 0x00003512
			[global::Cpp2ILInjected.Token(Token = "0x6000373")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D7FA40", Offset = "0x1D7FA40", Length = "0xD0")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Ref), Member = "Equal", MemberParameters = new object[]
			{
				typeof(string),
				typeof(string)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "CompareOrdinal", MemberParameters = new object[]
			{
				typeof(string),
				typeof(string)
			}, ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			private int System.IComparable.CompareTo(object obj)
			{
				throw null;
			}

			// Token: 0x04000584 RID: 1412
			[global::Cpp2ILInjected.Token(Token = "0x40001AC")]
			private static XmlTextReaderImpl.NodeData s_None;

			// Token: 0x04000585 RID: 1413
			[global::Cpp2ILInjected.Token(Token = "0x40001AD")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
			internal XmlNodeType type;

			// Token: 0x04000586 RID: 1414
			[global::Cpp2ILInjected.Token(Token = "0x40001AE")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
			internal string localName;

			// Token: 0x04000587 RID: 1415
			[global::Cpp2ILInjected.Token(Token = "0x40001AF")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
			internal string prefix;

			// Token: 0x04000588 RID: 1416
			[global::Cpp2ILInjected.Token(Token = "0x40001B0")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
			internal string ns;

			// Token: 0x04000589 RID: 1417
			[global::Cpp2ILInjected.Token(Token = "0x40001B1")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
			internal string nameWPrefix;

			// Token: 0x0400058A RID: 1418
			[global::Cpp2ILInjected.Token(Token = "0x40001B2")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
			private string value;

			// Token: 0x0400058B RID: 1419
			[global::Cpp2ILInjected.Token(Token = "0x40001B3")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
			private char[] chars;

			// Token: 0x0400058C RID: 1420
			[global::Cpp2ILInjected.Token(Token = "0x40001B4")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
			private int valueStartPos;

			// Token: 0x0400058D RID: 1421
			[global::Cpp2ILInjected.Token(Token = "0x40001B5")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x4C")]
			private int valueLength;

			// Token: 0x0400058E RID: 1422
			[global::Cpp2ILInjected.Token(Token = "0x40001B6")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
			internal LineInfo lineInfo;

			// Token: 0x0400058F RID: 1423
			[global::Cpp2ILInjected.Token(Token = "0x40001B7")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x58")]
			internal LineInfo lineInfo2;

			// Token: 0x04000590 RID: 1424
			[global::Cpp2ILInjected.Token(Token = "0x40001B8")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x60")]
			internal char quoteChar;

			// Token: 0x04000591 RID: 1425
			[global::Cpp2ILInjected.Token(Token = "0x40001B9")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x64")]
			internal int depth;

			// Token: 0x04000592 RID: 1426
			[global::Cpp2ILInjected.Token(Token = "0x40001BA")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x68")]
			private bool isEmptyOrDefault;

			// Token: 0x04000593 RID: 1427
			[global::Cpp2ILInjected.Token(Token = "0x40001BB")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x6C")]
			internal int entityId;

			// Token: 0x04000594 RID: 1428
			[global::Cpp2ILInjected.Token(Token = "0x40001BC")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x70")]
			internal bool xmlContextPushed;

			// Token: 0x04000595 RID: 1429
			[global::Cpp2ILInjected.Token(Token = "0x40001BD")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x78")]
			internal XmlTextReaderImpl.NodeData nextAttrValueChunk;

			// Token: 0x04000596 RID: 1430
			[global::Cpp2ILInjected.Token(Token = "0x40001BE")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x80")]
			internal object schemaType;

			// Token: 0x04000597 RID: 1431
			[global::Cpp2ILInjected.Token(Token = "0x40001BF")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x88")]
			internal object typedValue;
		}

		// Token: 0x02000159 RID: 345
		[global::Cpp2ILInjected.Token(Token = "0x200004A")]
		private class DtdDefaultAttributeInfoToNodeDataComparer : IComparer<object>
		{
			// Token: 0x17000365 RID: 869
			// (get) Token: 0x06000C8F RID: 3215 RVA: 0x00005315 File Offset: 0x00003515
			[global::Cpp2ILInjected.Token(Token = "0x170000C0")]
			internal static IComparer<object> Instance
			{
				[global::Cpp2ILInjected.Token(Token = "0x6000374")]
				[global::Cpp2ILInjected.Address(RVA = "0x1D7FB10", Offset = "0x1D7FB10", Length = "0x58")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
				get
				{
					throw null;
				}
			}

			// Token: 0x06000C90 RID: 3216 RVA: 0x00005318 File Offset: 0x00003518
			[global::Cpp2ILInjected.Token(Token = "0x6000375")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D7FB68", Offset = "0x1D7FB68", Length = "0x344")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Compare", MemberParameters = new object[]
			{
				typeof(string),
				typeof(string),
				typeof(StringComparison)
			}, ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlException), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(string),
				typeof(string)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 15)]
			public int Compare(object x, object y)
			{
				throw null;
			}

			// Token: 0x06000C91 RID: 3217 RVA: 0x0000531B File Offset: 0x0000351B
			[global::Cpp2ILInjected.Token(Token = "0x6000376")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D7FEAC", Offset = "0x1D7FEAC", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public DtdDefaultAttributeInfoToNodeDataComparer()
			{
				throw null;
			}

			// Token: 0x06000C92 RID: 3218 RVA: 0x0000531E File Offset: 0x0000351E
			// Note: this type is marked as 'beforefieldinit'.
			[global::Cpp2ILInjected.Token(Token = "0x6000377")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D7FEB4", Offset = "0x1D7FEB4", Length = "0x5C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			static DtdDefaultAttributeInfoToNodeDataComparer()
			{
				throw null;
			}

			// Token: 0x04000598 RID: 1432
			[global::Cpp2ILInjected.Token(Token = "0x40001C0")]
			private static IComparer<object> s_instance;
		}

		// Token: 0x0200015A RID: 346
		// (Invoke) Token: 0x06000C94 RID: 3220
		[global::Cpp2ILInjected.Token(Token = "0x200004B")]
		internal delegate void OnDefaultAttributeUseDelegate(IDtdDefaultAttributeInfo defaultAttribute, XmlTextReaderImpl coreReader);
	}
}
