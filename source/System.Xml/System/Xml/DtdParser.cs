using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Schema;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Xml
{
	[global::Cpp2ILInjected.Token(Token = "0x2000089")]
	internal class DtdParser : IDtdParser
	{
		[global::Cpp2ILInjected.Token(Token = "0x6000644")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D9B634", Offset = "0x1D9B634", Length = "0x88")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DtdParser), Member = "Create", ReturnType = typeof(IDtdParser))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlCharType), Member = "get_Instance", ReturnType = typeof(XmlCharType))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		private DtdParser()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000645")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D9612C", Offset = "0x1D9612C", Length = "0x50")]
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
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DtdParser), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		internal static IDtdParser Create()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000646")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D9B6BC", Offset = "0x1D9B6BC", Length = "0x3BC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DtdParser), Member = "InitializeFreeFloatingDtd", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(string),
			typeof(string),
			typeof(string),
			typeof(IDtdParserAdapter)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DtdParser), Member = "System.Xml.IDtdParser.ParseInternalDtd", MemberParameters = new object[]
		{
			typeof(IDtdParserAdapter),
			typeof(bool)
		}, ReturnType = typeof(IDtdInfo))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SchemaInfo), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Uri), Member = "op_Inequality", MemberParameters = new object[]
		{
			typeof(Uri),
			typeof(Uri)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 19)]
		private void Initialize(IDtdParserAdapter readerAdapter)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000647")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D9BA78", Offset = "0x1D9BA78", Length = "0x3A4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DtdParser), Member = "System.Xml.IDtdParser.ParseFreeFloatingDtd", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(string),
			typeof(string),
			typeof(string),
			typeof(IDtdParserAdapter)
		}, ReturnType = typeof(IDtdInfo))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DtdParser), Member = "Initialize", MemberParameters = new object[] { typeof(IDtdParserAdapter) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlConvert), Member = "VerifyName", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "IndexOf", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Substring", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Substring", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlQualifiedName), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlQualifiedName), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlCharType), Member = "IsOnlyCharData", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DtdParser), Member = "ThrowInvalidChar", MemberParameters = new object[]
		{
			typeof(int),
			typeof(string),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlCharType), Member = "IsPublicId", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Uri), Member = "op_Inequality", MemberParameters = new object[]
		{
			typeof(Uri),
			typeof(Uri)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlConvert), Member = "CreateInvalidNameArgumentException", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(ArgumentException))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 15)]
		private void InitializeFreeFloatingDtd(string baseUri, string docTypeName, string publicId, string systemId, string internalSubset, IDtdParserAdapter adapter)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000648")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D9BE98", Offset = "0x1D9BE98", Length = "0x30")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DtdParser), Member = "Initialize", MemberParameters = new object[] { typeof(IDtdParserAdapter) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DtdParser), Member = "Parse", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		private IDtdInfo System.Xml.IDtdParser.ParseInternalDtd(IDtdParserAdapter adapter, bool saveInternalSubset)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000649")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D9C0F8", Offset = "0x1D9C0F8", Length = "0x24")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DtdParser), Member = "InitializeFreeFloatingDtd", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(string),
			typeof(string),
			typeof(string),
			typeof(IDtdParserAdapter)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DtdParser), Member = "Parse", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		private IDtdInfo System.Xml.IDtdParser.ParseFreeFloatingDtd(string baseUri, string docTypeName, string publicId, string systemId, string internalSubset, IDtdParserAdapter adapter)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x170001AE")]
		private bool ParsingInternalSubset
		{
			[global::Cpp2ILInjected.Token(Token = "0x600064A")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D9C11C", Offset = "0x1D9C11C", Length = "0x10")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x170001AF")]
		private bool IgnoreEntityReferences
		{
			[global::Cpp2ILInjected.Token(Token = "0x600064B")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D9C12C", Offset = "0x1D9C12C", Length = "0x10")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x170001B0")]
		private bool SaveInternalSubsetValue
		{
			[global::Cpp2ILInjected.Token(Token = "0x600064C")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D9C13C", Offset = "0x1D9C13C", Length = "0xB8")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DtdParser), Member = "ParseComment", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DtdParser), Member = "ParsePI", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DtdParser), Member = "ScanLiteral", MemberParameters = new object[] { typeof(DtdParser.LiteralType) }, ReturnType = typeof(DtdParser.Token))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DtdParser), Member = "SaveParsingBuffer", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x170001B1")]
		private bool ParsingTopLevelMarkup
		{
			[global::Cpp2ILInjected.Token(Token = "0x600064D")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D9C1F4", Offset = "0x1D9C1F4", Length = "0x30")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x170001B2")]
		private bool SupportNamespaces
		{
			[global::Cpp2ILInjected.Token(Token = "0x600064E")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D9C224", Offset = "0x1D9C224", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x170001B3")]
		private bool Normalize
		{
			[global::Cpp2ILInjected.Token(Token = "0x600064F")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D9C22C", Offset = "0x1D9C22C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000650")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D9BEC8", Offset = "0x1D9BEC8", Length = "0x230")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DtdParser), Member = "System.Xml.IDtdParser.ParseInternalDtd", MemberParameters = new object[]
		{
			typeof(IDtdParserAdapter),
			typeof(bool)
		}, ReturnType = typeof(IDtdInfo))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DtdParser), Member = "System.Xml.IDtdParser.ParseFreeFloatingDtd", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(string),
			typeof(string),
			typeof(string),
			typeof(IDtdParserAdapter)
		}, ReturnType = typeof(IDtdInfo))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DtdParser), Member = "ParseFreeFloatingDtd", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DtdParser), Member = "ParseInDocumentDtd", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SchemaInfo), Member = "Finish", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, object>), Member = "get_Values", ReturnType = "ValueCollection<TKey, TValue>")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, object>.ValueCollection), Member = "GetEnumerator", ReturnType = "Enumerator<TKey, TValue>")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, object>.ValueCollection.Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DtdParser), Member = "get_BaseUriStr", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlSchemaException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(string),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DtdParser), Member = "SendValidationEvent", MemberParameters = new object[]
		{
			typeof(XmlSeverityType),
			typeof(XmlSchemaException)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, object>.ValueCollection.Enumerator), Member = "Dispose", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 14)]
		private void Parse(bool saveInternalSubset)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000651")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D9C288", Offset = "0x1D9C288", Length = "0x144")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DtdParser), Member = "Parse", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DtdParser), Member = "LoadParsingBuffer", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DtdParser), Member = "GetToken", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(DtdParser.Token))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DtdParser), Member = "OnUnexpectedError", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DtdParser), Member = "GetNameQualified", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(XmlQualifiedName))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DtdParser), Member = "ParseExternalId", MemberParameters = new object[]
		{
			typeof(DtdParser.Token),
			typeof(DtdParser.Token),
			typeof(ref string),
			typeof(ref string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DtdParser), Member = "SaveParsingBuffer", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DtdParser), Member = "ParseSubset", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DtdParser), Member = "ParseExternalSubset", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private void ParseInDocumentDtd(bool saveInternalSubset)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000652")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D9C234", Offset = "0x1D9C234", Length = "0x54")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DtdParser), Member = "Parse", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DtdParser), Member = "LoadParsingBuffer", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DtdParser), Member = "ParseSubset", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DtdParser), Member = "SaveParsingBuffer", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DtdParser), Member = "ParseExternalSubset", ReturnType = typeof(void))]
		private void ParseFreeFloatingDtd()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000653")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D9D67C", Offset = "0x1D9D67C", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DtdParser), Member = "ParseSubset", ReturnType = typeof(void))]
		private void ParseInternalSubset()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000654")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D9D680", Offset = "0x1D9D680", Length = "0x194")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DtdParser), Member = "ParseInDocumentDtd", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DtdParser), Member = "ParseFreeFloatingDtd", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Uri), Member = "op_Inequality", MemberParameters = new object[]
		{
			typeof(Uri),
			typeof(Uri)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DtdParser), Member = "LoadParsingBuffer", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		private void ParseExternalSubset()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000655")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D9D814", Offset = "0x1D9D814", Length = "0x33C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DtdParser), Member = "ParseInDocumentDtd", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DtdParser), Member = "ParseFreeFloatingDtd", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DtdParser), Member = "ParseInternalSubset", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DtdParser), Member = "GetToken", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(DtdParser.Token))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DtdParser), Member = "ParseAttlistDecl", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DtdParser), Member = "ParseElementDecl", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DtdParser), Member = "ParseEntityDecl", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DtdParser), Member = "ParseNotationDecl", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DtdParser), Member = "ParseComment", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DtdParser), Member = "ParsePI", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DtdParser), Member = "Throw", MemberParameters = new object[]
		{
			typeof(int),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DtdParser), Member = "ParseCondSection", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DtdParser), Member = "SendValidationEvent", MemberParameters = new object[]
		{
			typeof(int),
			typeof(XmlSeverityType),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DtdParser), Member = "SaveParsingBuffer", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DtdParser), Member = "ThrowUnexpectedToken", MemberParameters = new object[]
		{
			typeof(int),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
		private void ParseSubset()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000656")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D9DB50", Offset = "0x1D9DB50", Length = "0x568")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DtdParser), Member = "ParseSubset", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DtdParser), Member = "GetToken", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(DtdParser.Token))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DtdParser), Member = "GetNameQualified", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(XmlQualifiedName))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, object>), Member = "TryGetValue", MemberParameters = new object[]
		{
			typeof(object),
			typeof(ref object)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SchemaElementDecl), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(XmlQualifiedName),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, object>), Member = "Add", MemberParameters = new object[]
		{
			typeof(object),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SchemaAttDef), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(XmlQualifiedName),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DtdParser), Member = "get_LineNo", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DtdParser), Member = "get_LinePos", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SchemaElementDecl), Member = "GetAttDef", MemberParameters = new object[] { typeof(XmlQualifiedName) }, ReturnType = typeof(SchemaAttDef))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DtdParser), Member = "ParseAttlistType", MemberParameters = new object[]
		{
			typeof(SchemaAttDef),
			typeof(SchemaElementDecl),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DtdParser), Member = "ParseAttlistDefault", MemberParameters = new object[]
		{
			typeof(SchemaAttDef),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SchemaDeclBase), Member = "get_Prefix", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Equals", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SchemaAttDef), Member = "get_DefaultValueExpanded", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Trim", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SchemaAttDef), Member = "get_TokenizedType", ReturnType = typeof(XmlTokenizedType))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DtdParser), Member = "Throw", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SchemaAttDef), Member = "CheckXmlSpace", MemberParameters = new object[] { typeof(IValidationEventHandling) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SchemaElementDecl), Member = "AddAttDef", MemberParameters = new object[] { typeof(SchemaAttDef) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DtdParser), Member = "OnUnexpectedError", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 17)]
		private void ParseAttlistDecl()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000657")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D9F40C", Offset = "0x1D9F40C", Length = "0x514")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DtdParser), Member = "ParseAttlistDecl", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DtdParser), Member = "GetToken", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(DtdParser.Token))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SchemaAttDef), Member = "set_TokenizedType", MemberParameters = new object[] { typeof(XmlTokenizedType) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlSchemaType), Member = "GetBuiltInSimpleType", MemberParameters = new object[] { typeof(XmlTypeCode) }, ReturnType = typeof(XmlSchemaSimpleType))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SchemaElementDecl), Member = "GetAttDef", MemberParameters = new object[] { typeof(XmlQualifiedName) }, ReturnType = typeof(SchemaAttDef))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DtdParser), Member = "SendValidationEvent", MemberParameters = new object[]
		{
			typeof(XmlSeverityType),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "CreateString", MemberParameters = new object[]
		{
			typeof(char[]),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SchemaDeclBase), Member = "AddValue", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "Contains", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DtdParser), Member = "get_BaseUriStr", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DtdParser), Member = "get_LineNo", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DtdParser), Member = "get_LinePos", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlSchemaException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(string),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DtdParser), Member = "SendValidationEvent", MemberParameters = new object[]
		{
			typeof(XmlSeverityType),
			typeof(XmlSchemaException)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DtdParser), Member = "SendValidationEvent", MemberParameters = new object[]
		{
			typeof(int),
			typeof(XmlSeverityType),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SchemaInfo), Member = "get_Notations", ReturnType = typeof(Dictionary<string, SchemaNotation>))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, object>), Member = "ContainsKey", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DtdParser), Member = "AddUndeclaredNotation", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DtdParser), Member = "OnUnexpectedError", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
		private void ParseAttlistType(SchemaAttDef attrDef, SchemaElementDecl elementDecl, bool ignoreErrors)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000658")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D9F920", Offset = "0x1D9F920", Length = "0x194")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DtdParser), Member = "ParseAttlistDecl", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DtdParser), Member = "GetToken", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(DtdParser.Token))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DtdParser), Member = "SendValidationEvent", MemberParameters = new object[]
		{
			typeof(int),
			typeof(XmlSeverityType),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SchemaAttDef), Member = "get_TokenizedType", ReturnType = typeof(XmlTokenizedType))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DtdParser), Member = "GetValueWithStrippedSpaces", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DtdParser), Member = "OnUnexpectedError", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DtdParser), Member = "GetValue", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DtdValidator), Member = "SetDefaultTypedValue", MemberParameters = new object[]
		{
			typeof(SchemaAttDef),
			typeof(IDtdParserAdapter)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		private void ParseAttlistDefault(SchemaAttDef attrDef, bool ignoreErrors)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000659")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D9E0B8", Offset = "0x1D9E0B8", Length = "0x358")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DtdParser), Member = "ParseSubset", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DtdParser), Member = "GetToken", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(DtdParser.Token))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DtdParser), Member = "GetNameQualified", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(XmlQualifiedName))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, object>), Member = "TryGetValue", MemberParameters = new object[]
		{
			typeof(object),
			typeof(ref object)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "CreateString", MemberParameters = new object[]
		{
			typeof(char[]),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DtdParser), Member = "SendValidationEvent", MemberParameters = new object[]
		{
			typeof(int),
			typeof(XmlSeverityType),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, object>), Member = "Remove", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SchemaElementDecl), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(XmlQualifiedName),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, object>), Member = "Add", MemberParameters = new object[]
		{
			typeof(object),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ParticleContentValidator), Member = ".ctor", MemberParameters = new object[] { typeof(XmlSchemaContentType) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ParticleContentValidator), Member = "Start", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ParticleContentValidator), Member = "OpenGroup", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DtdParser), Member = "ParseElementMixedContent", MemberParameters = new object[]
		{
			typeof(ParticleContentValidator),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DtdParser), Member = "OnUnexpectedError", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DtdParser), Member = "ParseElementOnlyContent", MemberParameters = new object[]
		{
			typeof(ParticleContentValidator),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ParticleContentValidator), Member = "Finish", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(ContentValidator))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DtdParser), Member = "ThrowUnexpectedToken", MemberParameters = new object[]
		{
			typeof(int),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 13)]
		private void ParseElementDecl()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600065A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DA003C", Offset = "0x1DA003C", Length = "0x320")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DtdParser), Member = "ParseElementDecl", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Stack<>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DtdParser.ParseElementOnlyContent_LocalFrame), Member = ".ctor", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Stack<>), Member = "Push", MemberParameters = new object[] { "T" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Stack<>), Member = "Peek", ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DtdParser), Member = "Throw", MemberParameters = new object[]
		{
			typeof(int),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ParticleContentValidator), Member = "AddChoice", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DtdParser), Member = "GetToken", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(DtdParser.Token))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DtdParser), Member = "GetNameQualified", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(XmlQualifiedName))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ParticleContentValidator), Member = "AddName", MemberParameters = new object[]
		{
			typeof(XmlQualifiedName),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DtdParser), Member = "ParseHowMany", MemberParameters = new object[] { typeof(ParticleContentValidator) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ParticleContentValidator), Member = "OpenGroup", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ParticleContentValidator), Member = "AddSequence", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DtdParser), Member = "OnUnexpectedError", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ParticleContentValidator), Member = "CloseGroup", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DtdParser), Member = "SendValidationEvent", MemberParameters = new object[]
		{
			typeof(int),
			typeof(XmlSeverityType),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Stack<>), Member = "Pop", ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 13)]
		private void ParseElementOnlyContent(ParticleContentValidator pcv, int startParenEntityId)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600065B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DA035C", Offset = "0x1DA035C", Length = "0x60")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DtdParser), Member = "ParseElementOnlyContent", MemberParameters = new object[]
		{
			typeof(ParticleContentValidator),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DtdParser), Member = "GetToken", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(DtdParser.Token))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ParticleContentValidator), Member = "AddStar", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ParticleContentValidator), Member = "AddPlus", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ParticleContentValidator), Member = "AddQMark", ReturnType = typeof(void))]
		private void ParseHowMany(ParticleContentValidator pcv)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600065C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D9FDAC", Offset = "0x1D9FDAC", Length = "0x290")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DtdParser), Member = "ParseElementDecl", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DtdParser), Member = "GetToken", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(DtdParser.Token))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ParticleContentValidator), Member = "AddChoice", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DtdParser), Member = "SendValidationEvent", MemberParameters = new object[]
		{
			typeof(int),
			typeof(XmlSeverityType),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DtdParser), Member = "GetNameQualified", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(XmlQualifiedName))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ParticleContentValidator), Member = "Exists", MemberParameters = new object[] { typeof(XmlQualifiedName) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DtdParser), Member = "SendValidationEvent", MemberParameters = new object[]
		{
			typeof(XmlSeverityType),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ParticleContentValidator), Member = "AddName", MemberParameters = new object[]
		{
			typeof(XmlQualifiedName),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DtdParser), Member = "OnUnexpectedError", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ParticleContentValidator), Member = "CloseGroup", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ParticleContentValidator), Member = "AddStar", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DtdParser), Member = "ThrowUnexpectedToken", MemberParameters = new object[]
		{
			typeof(int),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		private void ParseElementMixedContent(ParticleContentValidator pcv, int startParenEntityId)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600065D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D9E410", Offset = "0x1D9E410", Length = "0x324")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DtdParser), Member = "ParseSubset", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DtdParser), Member = "GetToken", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(DtdParser.Token))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DtdParser), Member = "GetNameQualified", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(XmlQualifiedName))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SchemaEntity), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(XmlQualifiedName),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DtdParser), Member = "get_BaseUriStr", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SchemaInfo), Member = "get_ParameterEntities", ReturnType = typeof(Dictionary<XmlQualifiedName, SchemaEntity>))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, object>), Member = "ContainsKey", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SchemaInfo), Member = "get_GeneralEntities", ReturnType = typeof(Dictionary<XmlQualifiedName, SchemaEntity>))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, object>), Member = "Add", MemberParameters = new object[]
		{
			typeof(object),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DtdParser), Member = "GetValue", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SchemaEntity), Member = "set_Text", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DtdParser), Member = "ParseExternalId", MemberParameters = new object[]
		{
			typeof(DtdParser.Token),
			typeof(DtdParser.Token),
			typeof(ref string),
			typeof(ref string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SchemaEntity), Member = "set_Url", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DtdParser), Member = "ThrowUnexpectedToken", MemberParameters = new object[]
		{
			typeof(int),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DtdParser), Member = "Throw", MemberParameters = new object[]
		{
			typeof(int),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SchemaInfo), Member = "get_Notations", ReturnType = typeof(Dictionary<string, SchemaNotation>))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DtdParser), Member = "AddUndeclaredNotation", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DtdParser), Member = "OnUnexpectedError", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		private void ParseEntityDecl()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600065E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D9E734", Offset = "0x1D9E734", Length = "0x1DC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DtdParser), Member = "ParseSubset", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DtdParser), Member = "GetToken", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(DtdParser.Token))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DtdParser), Member = "OnUnexpectedError", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DtdParser), Member = "GetNameQualified", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(XmlQualifiedName))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SchemaInfo), Member = "get_Notations", ReturnType = typeof(Dictionary<string, SchemaNotation>))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, object>), Member = "ContainsKey", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DtdParser), Member = "SendValidationEvent", MemberParameters = new object[]
		{
			typeof(int),
			typeof(XmlSeverityType),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, object>), Member = "Remove", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SchemaNotation), Member = ".ctor", MemberParameters = new object[] { typeof(XmlQualifiedName) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, object>), Member = "Add", MemberParameters = new object[]
		{
			typeof(object),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DtdParser), Member = "ParseExternalId", MemberParameters = new object[]
		{
			typeof(DtdParser.Token),
			typeof(DtdParser.Token),
			typeof(ref string),
			typeof(ref string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		private void ParseNotationDecl()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600065F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D9FB9C", Offset = "0x1D9FB9C", Length = "0x150")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DtdParser), Member = "ParseAttlistType", MemberParameters = new object[]
		{
			typeof(SchemaAttDef),
			typeof(SchemaElementDecl),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DtdParser), Member = "ParseEntityDecl", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, object>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DtdParser), Member = "get_LineNo", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DtdParser), Member = "get_LinePos", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DtdParser.UndeclaredNotation), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, object>), Member = "TryGetValue", MemberParameters = new object[]
		{
			typeof(object),
			typeof(ref object)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, object>), Member = "Add", MemberParameters = new object[]
		{
			typeof(object),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		private void AddUndeclaredNotation(string notationName)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000660")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D9E910", Offset = "0x1D9E910", Length = "0x220")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DtdParser), Member = "ParseSubset", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DtdParser), Member = "SaveParsingBuffer", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DtdParser), Member = "get_SaveInternalSubsetValue", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(StringBuilder))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DtdParser), Member = "LoadParsingBuffer", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DtdParser), Member = "SendValidationEvent", MemberParameters = new object[]
		{
			typeof(XmlSeverityType),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 16)]
		private void ParseComment()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000661")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D9EB30", Offset = "0x1D9EB30", Length = "0x154")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DtdParser), Member = "ParseSubset", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DtdParser), Member = "SaveParsingBuffer", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DtdParser), Member = "get_SaveInternalSubsetValue", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(StringBuilder))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DtdParser), Member = "LoadParsingBuffer", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		private void ParsePI()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000662")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D9ECEC", Offset = "0x1D9ECEC", Length = "0x208")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DtdParser), Member = "ParseSubset", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DtdParser), Member = "GetToken", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(DtdParser.Token))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DtdParser), Member = "SendValidationEvent", MemberParameters = new object[]
		{
			typeof(int),
			typeof(XmlSeverityType),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new object[]
		{
			typeof(Array),
			typeof(int),
			typeof(Array),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DtdParser), Member = "OnUnexpectedError", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		private void ParseCondSection()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000663")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D9D1A4", Offset = "0x1D9D1A4", Length = "0x4D0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DtdParser), Member = "ParseInDocumentDtd", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DtdParser), Member = "ParseEntityDecl", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DtdParser), Member = "ParseNotationDecl", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DtdParser), Member = "get_LineNo", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DtdParser), Member = "get_LinePos", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DtdParser), Member = "GetToken", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(DtdParser.Token))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DtdParser), Member = "ThrowUnexpectedToken", MemberParameters = new object[]
		{
			typeof(int),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DtdParser), Member = "GetValue", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "IndexOf", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Substring", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DtdParser), Member = "Throw", MemberParameters = new object[]
		{
			typeof(int),
			typeof(string),
			typeof(string[])
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlCharType), Member = "IsPublicId", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DtdParser), Member = "ThrowInvalidChar", MemberParameters = new object[]
		{
			typeof(int),
			typeof(string),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "CreateString", MemberParameters = new object[]
		{
			typeof(char),
			typeof(int)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DtdParser), Member = "Throw", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 15)]
		private void ParseExternalId(DtdParser.Token idTokenType, DtdParser.Token declType, out string publicId, out string systemId)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000664")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D9C788", Offset = "0x1D9C788", Length = "0x878")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DtdParser), Member = "ParseInDocumentDtd", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DtdParser), Member = "ParseSubset", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DtdParser), Member = "ParseAttlistDecl", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DtdParser), Member = "ParseAttlistType", MemberParameters = new object[]
		{
			typeof(SchemaAttDef),
			typeof(SchemaElementDecl),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DtdParser), Member = "ParseAttlistDefault", MemberParameters = new object[]
		{
			typeof(SchemaAttDef),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DtdParser), Member = "ParseElementDecl", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DtdParser), Member = "ParseElementOnlyContent", MemberParameters = new object[]
		{
			typeof(ParticleContentValidator),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DtdParser), Member = "ParseHowMany", MemberParameters = new object[] { typeof(ParticleContentValidator) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DtdParser), Member = "ParseElementMixedContent", MemberParameters = new object[]
		{
			typeof(ParticleContentValidator),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DtdParser), Member = "ParseEntityDecl", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DtdParser), Member = "ParseNotationDecl", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DtdParser), Member = "ParseCondSection", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DtdParser), Member = "ParseExternalId", MemberParameters = new object[]
		{
			typeof(DtdParser.Token),
			typeof(DtdParser.Token),
			typeof(ref string),
			typeof(ref string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 43)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlCharType), Member = "IsWhiteSpace", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DtdParser), Member = "ScanEntityName", ReturnType = typeof(XmlQualifiedName))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DtdParser), Member = "HandleEntityReference", MemberParameters = new object[]
		{
			typeof(XmlQualifiedName),
			typeof(bool),
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DtdParser), Member = "SaveParsingBuffer", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DtdParser), Member = "ThrowInvalidChar", MemberParameters = new object[]
		{
			typeof(char[]),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DtdParser), Member = "ReadData", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DtdParser), Member = "HandleEntityEnd", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DtdParser), Member = "Throw", MemberParameters = new object[]
		{
			typeof(int),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DtdParser), Member = "ParseUnexpectedToken", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DtdParser), Member = "Throw", MemberParameters = new object[]
		{
			typeof(int),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DtdParser), Member = "ScanSubsetContent", ReturnType = typeof(DtdParser.Token))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DtdParser), Member = "ScanQName", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DtdParser), Member = "ScanNmtoken", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DtdParser), Member = "ScanDoctype1", ReturnType = typeof(DtdParser.Token))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DtdParser), Member = "ScanDoctype2", ReturnType = typeof(DtdParser.Token))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DtdParser), Member = "ScanElement1", ReturnType = typeof(DtdParser.Token))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DtdParser), Member = "ScanElement2", ReturnType = typeof(DtdParser.Token))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DtdParser), Member = "ScanElement3", ReturnType = typeof(DtdParser.Token))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DtdParser), Member = "ScanElement4", ReturnType = typeof(DtdParser.Token))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DtdParser), Member = "ScanElement5", ReturnType = typeof(DtdParser.Token))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DtdParser), Member = "ScanElement6", ReturnType = typeof(DtdParser.Token))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DtdParser), Member = "ScanAttlist1", ReturnType = typeof(DtdParser.Token))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DtdParser), Member = "ScanAttlist2", ReturnType = typeof(DtdParser.Token))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DtdParser), Member = "ScanAttlist3", ReturnType = typeof(DtdParser.Token))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DtdParser), Member = "ScanAttlist4", ReturnType = typeof(DtdParser.Token))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DtdParser), Member = "ScanAttlist5", ReturnType = typeof(DtdParser.Token))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DtdParser), Member = "ScanAttlist6", ReturnType = typeof(DtdParser.Token))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DtdParser), Member = "ScanAttlist7", ReturnType = typeof(DtdParser.Token))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DtdParser), Member = "ScanEntity1", ReturnType = typeof(DtdParser.Token))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DtdParser), Member = "ScanEntity2", ReturnType = typeof(DtdParser.Token))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DtdParser), Member = "ScanEntity3", ReturnType = typeof(DtdParser.Token))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DtdParser), Member = "ScanNotation1", ReturnType = typeof(DtdParser.Token))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DtdParser), Member = "ScanCondSection1", ReturnType = typeof(DtdParser.Token))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DtdParser), Member = "ScanCondSection2", ReturnType = typeof(DtdParser.Token))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DtdParser), Member = "ScanCondSection3", ReturnType = typeof(DtdParser.Token))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DtdParser), Member = "ScanSystemId", ReturnType = typeof(DtdParser.Token))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DtdParser), Member = "ScanPublicId1", ReturnType = typeof(DtdParser.Token))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DtdParser), Member = "ScanPublicId2", ReturnType = typeof(DtdParser.Token))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DtdParser), Member = "ScanClosingTag", ReturnType = typeof(DtdParser.Token))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
		private DtdParser.Token GetToken(bool needWhiteSpace)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000665")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DA0A98", Offset = "0x1DA0A98", Length = "0x5E4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DtdParser), Member = "GetToken", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(DtdParser.Token))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DtdParser), Member = "Throw", MemberParameters = new object[]
		{
			typeof(int),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DtdParser), Member = "ReadData", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		private DtdParser.Token ScanSubsetContent()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000666")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DA0A30", Offset = "0x1DA0A30", Length = "0x24")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DtdParser), Member = "ScanQName", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		private DtdParser.Token ScanNameExpected()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000667")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DA0A54", Offset = "0x1DA0A54", Length = "0x24")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DtdParser), Member = "ScanQName", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		private DtdParser.Token ScanQNameExpected()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000668")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DA0A78", Offset = "0x1DA0A78", Length = "0x20")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DtdParser), Member = "ScanNmtoken", ReturnType = typeof(void))]
		private DtdParser.Token ScanNmtokenExpected()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000669")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DA107C", Offset = "0x1DA107C", Length = "0x104")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DtdParser), Member = "GetToken", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(DtdParser.Token))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DtdParser), Member = "EatPublicKeyword", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DtdParser), Member = "Throw", MemberParameters = new object[]
		{
			typeof(int),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DtdParser), Member = "EatSystemKeyword", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		private DtdParser.Token ScanDoctype1()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600066A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DA1180", Offset = "0x1DA1180", Length = "0x90")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DtdParser), Member = "GetToken", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(DtdParser.Token))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DtdParser), Member = "Throw", MemberParameters = new object[]
		{
			typeof(int),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		private DtdParser.Token ScanDoctype2()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600066B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DA2E20", Offset = "0x1DA2E20", Length = "0x78")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DtdParser), Member = "GetToken", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(DtdParser.Token))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DtdParser), Member = "ThrowUnexpectedToken", MemberParameters = new object[]
		{
			typeof(int),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		private DtdParser.Token ScanClosingTag()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600066C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DA1210", Offset = "0x1DA1210", Length = "0x180")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DtdParser), Member = "GetToken", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(DtdParser.Token))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DtdParser), Member = "Throw", MemberParameters = new object[]
		{
			typeof(int),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DtdParser), Member = "ReadData", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private DtdParser.Token ScanElement1()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600066D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DA1390", Offset = "0x1DA1390", Length = "0x150")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DtdParser), Member = "GetToken", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(DtdParser.Token))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DtdParser), Member = "ReadData", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DtdParser), Member = "Throw", MemberParameters = new object[]
		{
			typeof(int),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private DtdParser.Token ScanElement2()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600066E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DA14E0", Offset = "0x1DA14E0", Length = "0x68")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DtdParser), Member = "GetToken", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(DtdParser.Token))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DtdParser), Member = "ScanQName", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		private DtdParser.Token ScanElement3()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600066F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DA1548", Offset = "0x1DA1548", Length = "0xB0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DtdParser), Member = "GetToken", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(DtdParser.Token))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DtdParser), Member = "Throw", MemberParameters = new object[]
		{
			typeof(int),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		private DtdParser.Token ScanElement4()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000670")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DA15F8", Offset = "0x1DA15F8", Length = "0xD4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DtdParser), Member = "GetToken", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(DtdParser.Token))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DtdParser), Member = "Throw", MemberParameters = new object[]
		{
			typeof(int),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		private DtdParser.Token ScanElement5()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000671")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DA16CC", Offset = "0x1DA16CC", Length = "0xB8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DtdParser), Member = "GetToken", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(DtdParser.Token))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DtdParser), Member = "ThrowUnexpectedToken", MemberParameters = new object[]
		{
			typeof(int),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private DtdParser.Token ScanElement6()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000672")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DA1784", Offset = "0x1DA1784", Length = "0x40")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private DtdParser.Token ScanElement7()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000673")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DA17C4", Offset = "0x1DA17C4", Length = "0xAC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DtdParser), Member = "GetToken", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(DtdParser.Token))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DtdParser), Member = "ParseUnexpectedToken", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DtdParser), Member = "Throw", MemberParameters = new object[]
		{
			typeof(int),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DtdParser), Member = "ScanQName", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		private DtdParser.Token ScanAttlist1()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000674")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DA1870", Offset = "0x1DA1870", Length = "0x540")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DtdParser), Member = "GetToken", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(DtdParser.Token))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DtdParser), Member = "Throw", MemberParameters = new object[]
		{
			typeof(int),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DtdParser), Member = "ReadData", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		private DtdParser.Token ScanAttlist2()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000675")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DA1DB0", Offset = "0x1DA1DB0", Length = "0x88")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DtdParser), Member = "GetToken", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(DtdParser.Token))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DtdParser), Member = "ThrowUnexpectedToken", MemberParameters = new object[]
		{
			typeof(int),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		private DtdParser.Token ScanAttlist3()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000676")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DA1E38", Offset = "0x1DA1E38", Length = "0xB8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DtdParser), Member = "GetToken", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(DtdParser.Token))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DtdParser), Member = "ThrowUnexpectedToken", MemberParameters = new object[]
		{
			typeof(int),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private DtdParser.Token ScanAttlist4()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000677")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DA1EF0", Offset = "0x1DA1EF0", Length = "0xB8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DtdParser), Member = "GetToken", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(DtdParser.Token))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DtdParser), Member = "ThrowUnexpectedToken", MemberParameters = new object[]
		{
			typeof(int),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private DtdParser.Token ScanAttlist5()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000678")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DA1FA8", Offset = "0x1DA1FA8", Length = "0x2C4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DtdParser), Member = "GetToken", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(DtdParser.Token))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DtdParser), Member = "Throw", MemberParameters = new object[]
		{
			typeof(int),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DtdParser), Member = "ReadData", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DtdParser), Member = "ScanLiteral", MemberParameters = new object[] { typeof(DtdParser.LiteralType) }, ReturnType = typeof(DtdParser.Token))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private DtdParser.Token ScanAttlist6()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000679")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DA226C", Offset = "0x1DA226C", Length = "0xA4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DtdParser), Member = "GetToken", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(DtdParser.Token))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DtdParser), Member = "ScanLiteral", MemberParameters = new object[] { typeof(DtdParser.LiteralType) }, ReturnType = typeof(DtdParser.Token))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DtdParser), Member = "ThrowUnexpectedToken", MemberParameters = new object[]
		{
			typeof(int),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private DtdParser.Token ScanAttlist7()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600067A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DA33A0", Offset = "0x1DA33A0", Length = "0x9BC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DtdParser), Member = "ScanAttlist6", ReturnType = typeof(DtdParser.Token))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DtdParser), Member = "ScanAttlist7", ReturnType = typeof(DtdParser.Token))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DtdParser), Member = "ScanSystemId", ReturnType = typeof(DtdParser.Token))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DtdParser), Member = "ScanEntity2", ReturnType = typeof(DtdParser.Token))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DtdParser), Member = "ScanPublicId1", ReturnType = typeof(DtdParser.Token))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DtdParser), Member = "ScanPublicId2", ReturnType = typeof(DtdParser.Token))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 6)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DtdParser), Member = "get_LineNo", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DtdParser), Member = "get_LinePos", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = "set_Length", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new object[]
		{
			typeof(char[]),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(StringBuilder))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DtdParser), Member = "ScanEntityName", ReturnType = typeof(XmlQualifiedName))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DtdParser), Member = "HandleEntityReference", MemberParameters = new object[]
		{
			typeof(XmlQualifiedName),
			typeof(bool),
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlCharType), Member = "IsHighSurrogate", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlCharType), Member = "IsLowSurrogate", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlException), Member = "BuildCharExceptionArgs", MemberParameters = new object[]
		{
			typeof(char),
			typeof(char)
		}, ReturnType = typeof(string[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DtdParser), Member = "Throw", MemberParameters = new object[]
		{
			typeof(int),
			typeof(string),
			typeof(string[])
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DtdParser), Member = "SaveParsingBuffer", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DtdParser), Member = "get_SaveInternalSubsetValue", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(StringBuilder))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DtdParser), Member = "ReadData", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DtdParser), Member = "HandleEntityEnd", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DtdParser), Member = "Throw", MemberParameters = new object[]
		{
			typeof(int),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(StringBuilder))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DtdParser), Member = "LoadParsingBuffer", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DtdParser), Member = "VerifyEntityReference", MemberParameters = new object[]
		{
			typeof(XmlQualifiedName),
			typeof(bool),
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(SchemaEntity))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = "get_Length", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DtdParser), Member = "ThrowInvalidChar", MemberParameters = new object[]
		{
			typeof(char[]),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 18)]
		private DtdParser.Token ScanLiteral(DtdParser.LiteralType literalType)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600067B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DA3D5C", Offset = "0x1DA3D5C", Length = "0x144")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DtdParser), Member = "GetToken", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(DtdParser.Token))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DtdParser), Member = "ScanLiteral", MemberParameters = new object[] { typeof(DtdParser.LiteralType) }, ReturnType = typeof(DtdParser.Token))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DtdParser), Member = "HandleEntityReference", MemberParameters = new object[]
		{
			typeof(bool),
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DtdParser), Member = "ScanQName", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DtdParser), Member = "ThrowUnexpectedToken", MemberParameters = new object[]
		{
			typeof(int),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DtdParser), Member = "GetNameQualified", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(XmlQualifiedName))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DtdParser), Member = "Throw", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 12)]
		private XmlQualifiedName ScanEntityName()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600067C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DA2310", Offset = "0x1DA2310", Length = "0xE0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DtdParser), Member = "GetToken", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(DtdParser.Token))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DtdParser), Member = "EatPublicKeyword", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DtdParser), Member = "Throw", MemberParameters = new object[]
		{
			typeof(int),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DtdParser), Member = "EatSystemKeyword", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private DtdParser.Token ScanNotation1()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600067D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DA23F0", Offset = "0x1DA23F0", Length = "0x9C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DtdParser), Member = "GetToken", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(DtdParser.Token))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DtdParser), Member = "ThrowUnexpectedToken", MemberParameters = new object[]
		{
			typeof(int),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DtdParser), Member = "ScanLiteral", MemberParameters = new object[] { typeof(DtdParser.LiteralType) }, ReturnType = typeof(DtdParser.Token))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private DtdParser.Token ScanSystemId()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600067E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DA2578", Offset = "0x1DA2578", Length = "0x5C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DtdParser), Member = "GetToken", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(DtdParser.Token))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DtdParser), Member = "ScanQName", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		private DtdParser.Token ScanEntity1()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600067F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DA25D4", Offset = "0x1DA25D4", Length = "0x114")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DtdParser), Member = "GetToken", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(DtdParser.Token))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DtdParser), Member = "ScanLiteral", MemberParameters = new object[] { typeof(DtdParser.LiteralType) }, ReturnType = typeof(DtdParser.Token))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DtdParser), Member = "EatPublicKeyword", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DtdParser), Member = "Throw", MemberParameters = new object[]
		{
			typeof(int),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DtdParser), Member = "EatSystemKeyword", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private DtdParser.Token ScanEntity2()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000680")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DA26E8", Offset = "0x1DA26E8", Length = "0xD0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DtdParser), Member = "GetToken", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(DtdParser.Token))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DtdParser), Member = "ReadData", ReturnType = typeof(int))]
		private DtdParser.Token ScanEntity3()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000681")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DA248C", Offset = "0x1DA248C", Length = "0x9C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DtdParser), Member = "GetToken", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(DtdParser.Token))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DtdParser), Member = "ThrowUnexpectedToken", MemberParameters = new object[]
		{
			typeof(int),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DtdParser), Member = "ScanLiteral", MemberParameters = new object[] { typeof(DtdParser.LiteralType) }, ReturnType = typeof(DtdParser.Token))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private DtdParser.Token ScanPublicId1()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000682")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DA2528", Offset = "0x1DA2528", Length = "0x50")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DtdParser), Member = "GetToken", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(DtdParser.Token))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DtdParser), Member = "ScanLiteral", MemberParameters = new object[] { typeof(DtdParser.LiteralType) }, ReturnType = typeof(DtdParser.Token))]
		private DtdParser.Token ScanPublicId2()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000683")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DA27B8", Offset = "0x1DA27B8", Length = "0x218")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DtdParser), Member = "GetToken", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(DtdParser.Token))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DtdParser), Member = "Throw", MemberParameters = new object[]
		{
			typeof(int),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DtdParser), Member = "ReadData", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlCharType), Member = "IsNameSingleChar", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private DtdParser.Token ScanCondSection1()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000684")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DA29D0", Offset = "0x1DA29D0", Length = "0x7C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DtdParser), Member = "GetToken", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(DtdParser.Token))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DtdParser), Member = "ThrowUnexpectedToken", MemberParameters = new object[]
		{
			typeof(int),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		private DtdParser.Token ScanCondSection2()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000685")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DA2A4C", Offset = "0x1DA2A4C", Length = "0x3D4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DtdParser), Member = "GetToken", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(DtdParser.Token))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlCharType), Member = "IsHighSurrogate", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlCharType), Member = "IsLowSurrogate", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DtdParser), Member = "ReadData", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DtdParser), Member = "HandleEntityEnd", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DtdParser), Member = "Throw", MemberParameters = new object[]
		{
			typeof(int),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DtdParser), Member = "ThrowInvalidChar", MemberParameters = new object[]
		{
			typeof(char[]),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		private DtdParser.Token ScanCondSection3()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000686")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DA30F4", Offset = "0x1DA30F4", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DtdParser), Member = "ScanQName", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		private void ScanName()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000687")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DA30FC", Offset = "0x1DA30FC", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DtdParser), Member = "ScanQName", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		private void ScanQName()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000688")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DA4060", Offset = "0x1DA4060", Length = "0x22C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DtdParser), Member = "GetToken", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(DtdParser.Token))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DtdParser), Member = "ScanNameExpected", ReturnType = typeof(DtdParser.Token))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DtdParser), Member = "ScanQNameExpected", ReturnType = typeof(DtdParser.Token))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DtdParser), Member = "ScanElement3", ReturnType = typeof(DtdParser.Token))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DtdParser), Member = "ScanAttlist1", ReturnType = typeof(DtdParser.Token))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DtdParser), Member = "ScanEntityName", ReturnType = typeof(XmlQualifiedName))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DtdParser), Member = "ScanEntity1", ReturnType = typeof(DtdParser.Token))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DtdParser), Member = "ScanName", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DtdParser), Member = "ScanQName", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 10)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DtdParser), Member = "ReadData", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DtdParser), Member = "Throw", MemberParameters = new object[]
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
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DtdParser), Member = "Throw", MemberParameters = new object[]
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
		private void ScanQName(bool isQName)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000689")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DA428C", Offset = "0x1DA428C", Length = "0x44")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DtdParser), Member = "ReadData", ReturnType = typeof(int))]
		private bool ReadDataInName()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600068A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DA3104", Offset = "0x1DA3104", Length = "0x144")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DtdParser), Member = "GetToken", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(DtdParser.Token))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DtdParser), Member = "ScanNmtokenExpected", ReturnType = typeof(DtdParser.Token))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DtdParser), Member = "ReadData", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DtdParser), Member = "Throw", MemberParameters = new object[]
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
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DtdParser), Member = "Throw", MemberParameters = new object[]
		{
			typeof(int),
			typeof(string),
			typeof(string[])
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		private void ScanNmtoken()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600068B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DA3248", Offset = "0x1DA3248", Length = "0xAC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DtdParser), Member = "ScanDoctype1", ReturnType = typeof(DtdParser.Token))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DtdParser), Member = "ScanNotation1", ReturnType = typeof(DtdParser.Token))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DtdParser), Member = "ScanEntity2", ReturnType = typeof(DtdParser.Token))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DtdParser), Member = "ReadData", ReturnType = typeof(int))]
		private bool EatPublicKeyword()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600068C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DA32F4", Offset = "0x1DA32F4", Length = "0xAC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DtdParser), Member = "ScanDoctype1", ReturnType = typeof(DtdParser.Token))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DtdParser), Member = "ScanNotation1", ReturnType = typeof(DtdParser.Token))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DtdParser), Member = "ScanEntity2", ReturnType = typeof(DtdParser.Token))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DtdParser), Member = "ReadData", ReturnType = typeof(int))]
		private bool EatSystemKeyword()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600068D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D9D04C", Offset = "0x1D9D04C", Length = "0x158")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DtdParser), Member = "ParseInDocumentDtd", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DtdParser), Member = "ParseAttlistDecl", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DtdParser), Member = "ParseElementDecl", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DtdParser), Member = "ParseElementOnlyContent", MemberParameters = new object[]
		{
			typeof(ParticleContentValidator),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DtdParser), Member = "ParseElementMixedContent", MemberParameters = new object[]
		{
			typeof(ParticleContentValidator),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DtdParser), Member = "ParseEntityDecl", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DtdParser), Member = "ParseNotationDecl", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DtdParser), Member = "ScanEntityName", ReturnType = typeof(XmlQualifiedName))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 10)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlQualifiedName), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlQualifiedName), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "CreateString", MemberParameters = new object[]
		{
			typeof(char[]),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DtdParser), Member = "Throw", MemberParameters = new object[]
		{
			typeof(int),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		private XmlQualifiedName GetNameQualified(bool canHavePrefix)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600068E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D9FB80", Offset = "0x1D9FB80", Length = "0x1C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "CreateString", MemberParameters = new object[]
		{
			typeof(char[]),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(string))]
		private string GetNameString()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600068F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D9FCEC", Offset = "0x1D9FCEC", Length = "0x1C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "CreateString", MemberParameters = new object[]
		{
			typeof(char[]),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(string))]
		private string GetNmtokenString()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000690")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D9FD5C", Offset = "0x1D9FD5C", Length = "0x50")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DtdParser), Member = "ParseAttlistDefault", MemberParameters = new object[]
		{
			typeof(SchemaAttDef),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DtdParser), Member = "ParseEntityDecl", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DtdParser), Member = "ParseExternalId", MemberParameters = new object[]
		{
			typeof(DtdParser.Token),
			typeof(DtdParser.Token),
			typeof(ref string),
			typeof(ref string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = "get_Length", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "CreateString", MemberParameters = new object[]
		{
			typeof(char[]),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		private string GetValue()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000691")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D9FD08", Offset = "0x1D9FD08", Length = "0x54")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DtdParser), Member = "ParseAttlistDefault", MemberParameters = new object[]
		{
			typeof(SchemaAttDef),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = "get_Length", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "CreateString", MemberParameters = new object[]
		{
			typeof(char[]),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DtdParser), Member = "StripSpaces", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		private string GetValueWithStrippedSpaces()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000692")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DA2E98", Offset = "0x1DA2E98", Length = "0xBC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DtdParser), Member = "GetToken", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(DtdParser.Token))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DtdParser), Member = "ScanSubsetContent", ReturnType = typeof(DtdParser.Token))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DtdParser), Member = "ScanElement1", ReturnType = typeof(DtdParser.Token))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DtdParser), Member = "ScanElement2", ReturnType = typeof(DtdParser.Token))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DtdParser), Member = "ScanAttlist2", ReturnType = typeof(DtdParser.Token))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DtdParser), Member = "ScanAttlist6", ReturnType = typeof(DtdParser.Token))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DtdParser), Member = "ScanLiteral", MemberParameters = new object[] { typeof(DtdParser.LiteralType) }, ReturnType = typeof(DtdParser.Token))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DtdParser), Member = "ScanEntity3", ReturnType = typeof(DtdParser.Token))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DtdParser), Member = "ScanCondSection1", ReturnType = typeof(DtdParser.Token))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DtdParser), Member = "ScanCondSection3", ReturnType = typeof(DtdParser.Token))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DtdParser), Member = "ScanQName", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DtdParser), Member = "ReadDataInName", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DtdParser), Member = "ScanNmtoken", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DtdParser), Member = "EatPublicKeyword", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DtdParser), Member = "EatSystemKeyword", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 16)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DtdParser), Member = "SaveParsingBuffer", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DtdParser), Member = "LoadParsingBuffer", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private int ReadData()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000693")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D9C61C", Offset = "0x1D9C61C", Length = "0x16C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DtdParser), Member = "ParseInDocumentDtd", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DtdParser), Member = "ParseFreeFloatingDtd", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DtdParser), Member = "ParseExternalSubset", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DtdParser), Member = "ParseComment", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DtdParser), Member = "ParsePI", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DtdParser), Member = "ScanLiteral", MemberParameters = new object[] { typeof(DtdParser.LiteralType) }, ReturnType = typeof(DtdParser.Token))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DtdParser), Member = "ReadData", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DtdParser), Member = "HandleEntityReference", MemberParameters = new object[]
		{
			typeof(XmlQualifiedName),
			typeof(bool),
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DtdParser), Member = "HandleEntityEnd", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 11)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		private void LoadParsingBuffer()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000694")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D9D674", Offset = "0x1D9D674", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DtdParser), Member = "SaveParsingBuffer", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		private void SaveParsingBuffer()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000695")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D9EFC8", Offset = "0x1D9EFC8", Length = "0x13C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DtdParser), Member = "ParseInDocumentDtd", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DtdParser), Member = "ParseFreeFloatingDtd", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DtdParser), Member = "ParseSubset", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DtdParser), Member = "ParseComment", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DtdParser), Member = "ParsePI", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DtdParser), Member = "GetToken", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(DtdParser.Token))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DtdParser), Member = "ScanLiteral", MemberParameters = new object[] { typeof(DtdParser.LiteralType) }, ReturnType = typeof(DtdParser.Token))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DtdParser), Member = "ReadData", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DtdParser), Member = "SaveParsingBuffer", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DtdParser), Member = "HandleEntityReference", MemberParameters = new object[]
		{
			typeof(XmlQualifiedName),
			typeof(bool),
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DtdParser), Member = "HandleEntityEnd", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 13)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DtdParser), Member = "get_SaveInternalSubsetValue", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new object[]
		{
			typeof(char[]),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(StringBuilder))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		private void SaveParsingBuffer(int internalSubsetValueEndPos)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000696")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DA094C", Offset = "0x1DA094C", Length = "0x50")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DtdParser), Member = "ScanEntityName", ReturnType = typeof(XmlQualifiedName))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DtdParser), Member = "HandleEntityReference", MemberParameters = new object[]
		{
			typeof(XmlQualifiedName),
			typeof(bool),
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(bool))]
		private bool HandleEntityReference(bool paramEntity, bool inLiteral, bool inAttribute)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000697")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DA44EC", Offset = "0x1DA44EC", Length = "0x1278")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DtdParser), Member = "GetToken", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(DtdParser.Token))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DtdParser), Member = "ScanLiteral", MemberParameters = new object[] { typeof(DtdParser.LiteralType) }, ReturnType = typeof(DtdParser.Token))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DtdParser), Member = "HandleEntityReference", MemberParameters = new object[]
		{
			typeof(bool),
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DtdParser), Member = "SaveParsingBuffer", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DtdParser), Member = "Throw", MemberParameters = new object[]
		{
			typeof(int),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DtdParser), Member = "VerifyEntityReference", MemberParameters = new object[]
		{
			typeof(XmlQualifiedName),
			typeof(bool),
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(SchemaEntity))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DtdParser), Member = "Throw", MemberParameters = new object[]
		{
			typeof(int),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DtdParser), Member = "LoadParsingBuffer", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		private bool HandleEntityReference(XmlQualifiedName entityName, bool paramEntity, bool inLiteral, bool inAttribute)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000698")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DA2F54", Offset = "0x1DA2F54", Length = "0x1A0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DtdParser), Member = "GetToken", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(DtdParser.Token))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DtdParser), Member = "ScanLiteral", MemberParameters = new object[] { typeof(DtdParser.LiteralType) }, ReturnType = typeof(DtdParser.Token))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DtdParser), Member = "ScanCondSection3", ReturnType = typeof(DtdParser.Token))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DtdParser), Member = "SaveParsingBuffer", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DtdParser), Member = "LoadParsingBuffer", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		private bool HandleEntityEnd(bool inLiteral)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000699")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DA3EA0", Offset = "0x1DA3EA0", Length = "0x1C0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DtdParser), Member = "ScanLiteral", MemberParameters = new object[] { typeof(DtdParser.LiteralType) }, ReturnType = typeof(DtdParser.Token))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DtdParser), Member = "HandleEntityReference", MemberParameters = new object[]
		{
			typeof(XmlQualifiedName),
			typeof(bool),
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SchemaInfo), Member = "get_ParameterEntities", ReturnType = typeof(Dictionary<XmlQualifiedName, SchemaEntity>))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SchemaInfo), Member = "get_GeneralEntities", ReturnType = typeof(Dictionary<XmlQualifiedName, SchemaEntity>))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, object>), Member = "TryGetValue", MemberParameters = new object[]
		{
			typeof(object),
			typeof(ref object)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlQualifiedName), Member = "get_IsEmpty", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DtdParser), Member = "Throw", MemberParameters = new object[]
		{
			typeof(int),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DtdParser), Member = "SendValidationEvent", MemberParameters = new object[]
		{
			typeof(int),
			typeof(XmlSeverityType),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		private SchemaEntity VerifyEntityReference(XmlQualifiedName entityName, bool paramEntity, bool mustBeDeclared, bool inAttribute)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600069A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D9EEF4", Offset = "0x1D9EEF4", Length = "0xD4")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DtdParser), Member = "ParseSubset", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DtdParser), Member = "ParseAttlistType", MemberParameters = new object[]
		{
			typeof(SchemaAttDef),
			typeof(SchemaElementDecl),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DtdParser), Member = "ParseAttlistDefault", MemberParameters = new object[]
		{
			typeof(SchemaAttDef),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DtdParser), Member = "ParseElementDecl", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DtdParser), Member = "ParseElementOnlyContent", MemberParameters = new object[]
		{
			typeof(ParticleContentValidator),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DtdParser), Member = "ParseElementMixedContent", MemberParameters = new object[]
		{
			typeof(ParticleContentValidator),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DtdParser), Member = "ParseNotationDecl", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DtdParser), Member = "ParseCondSection", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DtdParser), Member = "VerifyEntityReference", MemberParameters = new object[]
		{
			typeof(XmlQualifiedName),
			typeof(bool),
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(SchemaEntity))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 14)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DtdParser), Member = "get_BaseUriStr", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DtdParser), Member = "get_LineNo", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DtdParser), Member = "get_LinePos", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlSchemaException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(string),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DtdParser), Member = "SendValidationEvent", MemberParameters = new object[]
		{
			typeof(XmlSeverityType),
			typeof(XmlSchemaException)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private void SendValidationEvent(int pos, XmlSeverityType severity, string code, string arg)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600069B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D9FAC0", Offset = "0x1D9FAC0", Length = "0xC0")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DtdParser), Member = "ParseAttlistType", MemberParameters = new object[]
		{
			typeof(SchemaAttDef),
			typeof(SchemaElementDecl),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DtdParser), Member = "ParseElementMixedContent", MemberParameters = new object[]
		{
			typeof(ParticleContentValidator),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DtdParser), Member = "ParseComment", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DtdParser), Member = "get_BaseUriStr", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DtdParser), Member = "get_LineNo", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DtdParser), Member = "get_LinePos", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlSchemaException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(string),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DtdParser), Member = "SendValidationEvent", MemberParameters = new object[]
		{
			typeof(XmlSeverityType),
			typeof(XmlSchemaException)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private void SendValidationEvent(XmlSeverityType severity, string code, string arg)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600069C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D9C4E4", Offset = "0x1D9C4E4", Length = "0x138")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DtdParser), Member = "Parse", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DtdParser), Member = "ParseAttlistType", MemberParameters = new object[]
		{
			typeof(SchemaAttDef),
			typeof(SchemaElementDecl),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DtdParser), Member = "SendValidationEvent", MemberParameters = new object[]
		{
			typeof(int),
			typeof(XmlSeverityType),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DtdParser), Member = "SendValidationEvent", MemberParameters = new object[]
		{
			typeof(XmlSeverityType),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		private void SendValidationEvent(XmlSeverityType severity, XmlSchemaException e)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600069D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D9FAB4", Offset = "0x1D9FAB4", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private bool IsAttributeValueType(DtdParser.Token token)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x170001B4")]
		private int LineNo
		{
			[global::Cpp2ILInjected.Token(Token = "0x600069E")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D9F10C", Offset = "0x1D9F10C", Length = "0x9C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DtdParser), Member = "ParseAttlistDecl", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DtdParser), Member = "ParseAttlistType", MemberParameters = new object[]
			{
				typeof(SchemaAttDef),
				typeof(SchemaElementDecl),
				typeof(bool)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DtdParser), Member = "AddUndeclaredNotation", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DtdParser), Member = "ParseExternalId", MemberParameters = new object[]
			{
				typeof(DtdParser.Token),
				typeof(DtdParser.Token),
				typeof(ref string),
				typeof(ref string)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DtdParser), Member = "ScanLiteral", MemberParameters = new object[] { typeof(DtdParser.LiteralType) }, ReturnType = typeof(DtdParser.Token))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DtdParser), Member = "SendValidationEvent", MemberParameters = new object[]
			{
				typeof(int),
				typeof(XmlSeverityType),
				typeof(string),
				typeof(string)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DtdParser), Member = "SendValidationEvent", MemberParameters = new object[]
			{
				typeof(XmlSeverityType),
				typeof(string),
				typeof(string)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DtdParser), Member = "Throw", MemberParameters = new object[]
			{
				typeof(int),
				typeof(string),
				typeof(string)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DtdParser), Member = "Throw", MemberParameters = new object[]
			{
				typeof(int),
				typeof(string),
				typeof(string[])
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 10)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x170001B5")]
		private int LinePos
		{
			[global::Cpp2ILInjected.Token(Token = "0x600069F")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D9F1A8", Offset = "0x1D9F1A8", Length = "0xA8")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DtdParser), Member = "ParseAttlistDecl", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DtdParser), Member = "ParseAttlistType", MemberParameters = new object[]
			{
				typeof(SchemaAttDef),
				typeof(SchemaElementDecl),
				typeof(bool)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DtdParser), Member = "AddUndeclaredNotation", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DtdParser), Member = "ParseExternalId", MemberParameters = new object[]
			{
				typeof(DtdParser.Token),
				typeof(DtdParser.Token),
				typeof(ref string),
				typeof(ref string)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DtdParser), Member = "ScanLiteral", MemberParameters = new object[] { typeof(DtdParser.LiteralType) }, ReturnType = typeof(DtdParser.Token))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DtdParser), Member = "SendValidationEvent", MemberParameters = new object[]
			{
				typeof(int),
				typeof(XmlSeverityType),
				typeof(string),
				typeof(string)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DtdParser), Member = "SendValidationEvent", MemberParameters = new object[]
			{
				typeof(XmlSeverityType),
				typeof(string),
				typeof(string)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DtdParser), Member = "Throw", MemberParameters = new object[]
			{
				typeof(int),
				typeof(string),
				typeof(string)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DtdParser), Member = "Throw", MemberParameters = new object[]
			{
				typeof(int),
				typeof(string),
				typeof(string[])
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 10)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x170001B6")]
		private string BaseUriStr
		{
			[global::Cpp2ILInjected.Token(Token = "0x60006A0")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D9C3CC", Offset = "0x1D9C3CC", Length = "0x118")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DtdParser), Member = "Parse", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DtdParser), Member = "ParseAttlistType", MemberParameters = new object[]
			{
				typeof(SchemaAttDef),
				typeof(SchemaElementDecl),
				typeof(bool)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DtdParser), Member = "ParseEntityDecl", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DtdParser), Member = "SendValidationEvent", MemberParameters = new object[]
			{
				typeof(int),
				typeof(XmlSeverityType),
				typeof(string),
				typeof(string)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DtdParser), Member = "SendValidationEvent", MemberParameters = new object[]
			{
				typeof(XmlSeverityType),
				typeof(string),
				typeof(string)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 6)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Uri), Member = "op_Inequality", MemberParameters = new object[]
			{
				typeof(Uri),
				typeof(Uri)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x60006A1")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D9D000", Offset = "0x1D9D000", Length = "0x4C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DtdParser), Member = "ParseInDocumentDtd", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DtdParser), Member = "ParseAttlistDecl", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DtdParser), Member = "ParseAttlistType", MemberParameters = new object[]
		{
			typeof(SchemaAttDef),
			typeof(SchemaElementDecl),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DtdParser), Member = "ParseAttlistDefault", MemberParameters = new object[]
		{
			typeof(SchemaAttDef),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DtdParser), Member = "ParseElementDecl", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DtdParser), Member = "ParseElementOnlyContent", MemberParameters = new object[]
		{
			typeof(ParticleContentValidator),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DtdParser), Member = "ParseElementMixedContent", MemberParameters = new object[]
		{
			typeof(ParticleContentValidator),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DtdParser), Member = "ParseEntityDecl", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DtdParser), Member = "ParseNotationDecl", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DtdParser), Member = "ParseCondSection", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 13)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DtdParser), Member = "Throw", MemberParameters = new object[]
		{
			typeof(int),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		private void OnUnexpectedError()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60006A2")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D9EC84", Offset = "0x1D9EC84", Length = "0x68")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DtdParser), Member = "ParseSubset", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DtdParser), Member = "ParseElementOnlyContent", MemberParameters = new object[]
		{
			typeof(ParticleContentValidator),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DtdParser), Member = "GetToken", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(DtdParser.Token))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DtdParser), Member = "ScanSubsetContent", ReturnType = typeof(DtdParser.Token))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DtdParser), Member = "ScanDoctype1", ReturnType = typeof(DtdParser.Token))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DtdParser), Member = "ScanDoctype2", ReturnType = typeof(DtdParser.Token))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DtdParser), Member = "ScanElement1", ReturnType = typeof(DtdParser.Token))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DtdParser), Member = "ScanElement2", ReturnType = typeof(DtdParser.Token))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DtdParser), Member = "ScanElement4", ReturnType = typeof(DtdParser.Token))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DtdParser), Member = "ScanElement5", ReturnType = typeof(DtdParser.Token))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DtdParser), Member = "ScanAttlist2", ReturnType = typeof(DtdParser.Token))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DtdParser), Member = "ScanAttlist6", ReturnType = typeof(DtdParser.Token))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DtdParser), Member = "ScanLiteral", MemberParameters = new object[] { typeof(DtdParser.LiteralType) }, ReturnType = typeof(DtdParser.Token))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DtdParser), Member = "ScanNotation1", ReturnType = typeof(DtdParser.Token))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DtdParser), Member = "ScanEntity2", ReturnType = typeof(DtdParser.Token))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DtdParser), Member = "ScanCondSection1", ReturnType = typeof(DtdParser.Token))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DtdParser), Member = "ScanCondSection3", ReturnType = typeof(DtdParser.Token))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DtdParser), Member = "HandleEntityReference", MemberParameters = new object[]
		{
			typeof(XmlQualifiedName),
			typeof(bool),
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DtdParser), Member = "OnUnexpectedError", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 54)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DtdParser), Member = "Throw", MemberParameters = new object[]
		{
			typeof(int),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		private void Throw(int curPos, string res)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60006A3")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DA03BC", Offset = "0x1DA03BC", Length = "0x1D4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DtdParser), Member = "ParseEntityDecl", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DtdParser), Member = "GetToken", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(DtdParser.Token))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DtdParser), Member = "ScanAttlist1", ReturnType = typeof(DtdParser.Token))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DtdParser), Member = "ScanQName", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DtdParser), Member = "ScanNmtoken", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DtdParser), Member = "GetNameQualified", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(XmlQualifiedName))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DtdParser), Member = "HandleEntityReference", MemberParameters = new object[]
		{
			typeof(XmlQualifiedName),
			typeof(bool),
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DtdParser), Member = "VerifyEntityReference", MemberParameters = new object[]
		{
			typeof(XmlQualifiedName),
			typeof(bool),
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(SchemaEntity))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DtdParser), Member = "Throw", MemberParameters = new object[]
		{
			typeof(int),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 12)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DtdParser), Member = "get_LineNo", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DtdParser), Member = "get_LinePos", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Uri), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(Uri),
			typeof(Uri)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(int),
			typeof(int),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		private void Throw(int curPos, string res, string arg)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60006A4")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DA06F8", Offset = "0x1DA06F8", Length = "0x1D4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DtdParser), Member = "ParseExternalId", MemberParameters = new object[]
		{
			typeof(DtdParser.Token),
			typeof(DtdParser.Token),
			typeof(ref string),
			typeof(ref string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DtdParser), Member = "ScanLiteral", MemberParameters = new object[] { typeof(DtdParser.LiteralType) }, ReturnType = typeof(DtdParser.Token))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DtdParser), Member = "ScanQName", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DtdParser), Member = "ScanNmtoken", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DtdParser), Member = "ThrowInvalidChar", MemberParameters = new object[]
		{
			typeof(int),
			typeof(string),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DtdParser), Member = "ThrowInvalidChar", MemberParameters = new object[]
		{
			typeof(char[]),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 7)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DtdParser), Member = "get_LineNo", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DtdParser), Member = "get_LinePos", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Uri), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(Uri),
			typeof(Uri)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string[]),
			typeof(int),
			typeof(int),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		private void Throw(int curPos, string res, string[] args)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60006A5")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D9F250", Offset = "0x1D9F250", Length = "0x1BC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DtdParser), Member = "ParseAttlistDecl", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DtdParser), Member = "ParseExternalId", MemberParameters = new object[]
		{
			typeof(DtdParser.Token),
			typeof(DtdParser.Token),
			typeof(ref string),
			typeof(ref string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DtdParser), Member = "ScanEntityName", ReturnType = typeof(XmlQualifiedName))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Uri), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(Uri),
			typeof(Uri)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(int),
			typeof(int),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		private void Throw(string res, string arg, int lineNo, int linePos)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60006A6")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D9BE1C", Offset = "0x1D9BE1C", Length = "0x7C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DtdParser), Member = "InitializeFreeFloatingDtd", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(string),
			typeof(string),
			typeof(string),
			typeof(IDtdParserAdapter)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DtdParser), Member = "ParseExternalId", MemberParameters = new object[]
		{
			typeof(DtdParser.Token),
			typeof(DtdParser.Token),
			typeof(ref string),
			typeof(ref string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlException), Member = "BuildCharExceptionArgs", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int)
		}, ReturnType = typeof(string[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DtdParser), Member = "Throw", MemberParameters = new object[]
		{
			typeof(int),
			typeof(string),
			typeof(string[])
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		private void ThrowInvalidChar(int pos, string data, int invCharPos)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60006A7")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DA08CC", Offset = "0x1DA08CC", Length = "0x80")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DtdParser), Member = "GetToken", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(DtdParser.Token))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DtdParser), Member = "ScanLiteral", MemberParameters = new object[] { typeof(DtdParser.LiteralType) }, ReturnType = typeof(DtdParser.Token))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DtdParser), Member = "ScanCondSection3", ReturnType = typeof(DtdParser.Token))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlException), Member = "BuildCharExceptionArgs", MemberParameters = new object[]
		{
			typeof(char[]),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(string[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DtdParser), Member = "Throw", MemberParameters = new object[]
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

		[global::Cpp2ILInjected.Token(Token = "0x60006A8")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D9F104", Offset = "0x1D9F104", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DtdParser), Member = "ThrowUnexpectedToken", MemberParameters = new object[]
		{
			typeof(int),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		private void ThrowUnexpectedToken(int pos, string expectedToken)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60006A9")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DA0590", Offset = "0x1DA0590", Length = "0x168")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DtdParser), Member = "ParseSubset", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DtdParser), Member = "ParseElementDecl", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DtdParser), Member = "ParseElementMixedContent", MemberParameters = new object[]
		{
			typeof(ParticleContentValidator),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DtdParser), Member = "ParseEntityDecl", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DtdParser), Member = "ParseExternalId", MemberParameters = new object[]
		{
			typeof(DtdParser.Token),
			typeof(DtdParser.Token),
			typeof(ref string),
			typeof(ref string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DtdParser), Member = "ScanClosingTag", ReturnType = typeof(DtdParser.Token))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DtdParser), Member = "ScanElement6", ReturnType = typeof(DtdParser.Token))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DtdParser), Member = "ScanAttlist3", ReturnType = typeof(DtdParser.Token))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DtdParser), Member = "ScanAttlist4", ReturnType = typeof(DtdParser.Token))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DtdParser), Member = "ScanAttlist5", ReturnType = typeof(DtdParser.Token))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DtdParser), Member = "ScanAttlist7", ReturnType = typeof(DtdParser.Token))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DtdParser), Member = "ScanEntityName", ReturnType = typeof(XmlQualifiedName))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DtdParser), Member = "ScanSystemId", ReturnType = typeof(DtdParser.Token))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DtdParser), Member = "ScanPublicId1", ReturnType = typeof(DtdParser.Token))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DtdParser), Member = "ScanCondSection2", ReturnType = typeof(DtdParser.Token))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DtdParser), Member = "ThrowUnexpectedToken", MemberParameters = new object[]
		{
			typeof(int),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 17)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DtdParser), Member = "ParseUnexpectedToken", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 12)]
		private void ThrowUnexpectedToken(int pos, string expectedToken1, string expectedToken2)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60006AA")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DA099C", Offset = "0x1DA099C", Length = "0x94")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DtdParser), Member = "GetToken", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(DtdParser.Token))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DtdParser), Member = "ScanAttlist1", ReturnType = typeof(DtdParser.Token))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DtdParser), Member = "ThrowUnexpectedToken", MemberParameters = new object[]
		{
			typeof(int),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlCharType), Member = "IsNCNameSingleChar", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "CreateString", MemberParameters = new object[]
		{
			typeof(char[]),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(string))]
		private string ParseUnexpectedToken(int startPos)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60006AB")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DA42D0", Offset = "0x1DA42D0", Length = "0x21C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DtdParser), Member = "GetValueWithStrippedSpaces", ReturnType = typeof(string))]
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

		[global::Cpp2ILInjected.Token(Token = "0x4000308")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private IDtdParserAdapter readerAdapter;

		[global::Cpp2ILInjected.Token(Token = "0x4000309")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private IDtdParserAdapterWithValidation readerAdapterWithValidation;

		[global::Cpp2ILInjected.Token(Token = "0x400030A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private XmlNameTable nameTable;

		[global::Cpp2ILInjected.Token(Token = "0x400030B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private SchemaInfo schemaInfo;

		[global::Cpp2ILInjected.Token(Token = "0x400030C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		private XmlCharType xmlCharType;

		[global::Cpp2ILInjected.Token(Token = "0x400030D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		private string systemId;

		[global::Cpp2ILInjected.Token(Token = "0x400030E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
		private string publicId;

		[global::Cpp2ILInjected.Token(Token = "0x400030F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
		private bool normalize;

		[global::Cpp2ILInjected.Token(Token = "0x4000310")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x49")]
		private bool validate;

		[global::Cpp2ILInjected.Token(Token = "0x4000311")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x4A")]
		private bool supportNamespaces;

		[global::Cpp2ILInjected.Token(Token = "0x4000312")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x4B")]
		private bool v1Compat;

		[global::Cpp2ILInjected.Token(Token = "0x4000313")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
		private char[] chars;

		[global::Cpp2ILInjected.Token(Token = "0x4000314")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x58")]
		private int charsUsed;

		[global::Cpp2ILInjected.Token(Token = "0x4000315")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x5C")]
		private int curPos;

		[global::Cpp2ILInjected.Token(Token = "0x4000316")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x60")]
		private DtdParser.ScanningFunction scanningFunction;

		[global::Cpp2ILInjected.Token(Token = "0x4000317")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x64")]
		private DtdParser.ScanningFunction nextScaningFunction;

		[global::Cpp2ILInjected.Token(Token = "0x4000318")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x68")]
		private DtdParser.ScanningFunction savedScanningFunction;

		[global::Cpp2ILInjected.Token(Token = "0x4000319")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x6C")]
		private bool whitespaceSeen;

		[global::Cpp2ILInjected.Token(Token = "0x400031A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x70")]
		private int tokenStartPos;

		[global::Cpp2ILInjected.Token(Token = "0x400031B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x74")]
		private int colonPos;

		[global::Cpp2ILInjected.Token(Token = "0x400031C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x78")]
		private StringBuilder internalSubsetValueSb;

		[global::Cpp2ILInjected.Token(Token = "0x400031D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x80")]
		private int externalEntitiesDepth;

		[global::Cpp2ILInjected.Token(Token = "0x400031E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x84")]
		private int currentEntityId;

		[global::Cpp2ILInjected.Token(Token = "0x400031F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x88")]
		private bool freeFloatingDtd;

		[global::Cpp2ILInjected.Token(Token = "0x4000320")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x89")]
		private bool hasFreeFloatingInternalSubset;

		[global::Cpp2ILInjected.Token(Token = "0x4000321")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x90")]
		private StringBuilder stringBuilder;

		[global::Cpp2ILInjected.Token(Token = "0x4000322")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x98")]
		private int condSectionDepth;

		[global::Cpp2ILInjected.Token(Token = "0x4000323")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x9C")]
		private LineInfo literalLineInfo;

		[global::Cpp2ILInjected.Token(Token = "0x4000324")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xA4")]
		private char literalQuoteChar;

		[global::Cpp2ILInjected.Token(Token = "0x4000325")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xA8")]
		private string documentBaseUri;

		[global::Cpp2ILInjected.Token(Token = "0x4000326")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xB0")]
		private string externalDtdBaseUri;

		[global::Cpp2ILInjected.Token(Token = "0x4000327")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xB8")]
		private Dictionary<string, DtdParser.UndeclaredNotation> undeclaredNotations;

		[global::Cpp2ILInjected.Token(Token = "0x4000328")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xC0")]
		private int[] condSectionEntityIds;

		[global::Cpp2ILInjected.Token(Token = "0x200008A")]
		private enum Token
		{
			[global::Cpp2ILInjected.Token(Token = "0x400032A")]
			CDATA,
			[global::Cpp2ILInjected.Token(Token = "0x400032B")]
			ID,
			[global::Cpp2ILInjected.Token(Token = "0x400032C")]
			IDREF,
			[global::Cpp2ILInjected.Token(Token = "0x400032D")]
			IDREFS,
			[global::Cpp2ILInjected.Token(Token = "0x400032E")]
			ENTITY,
			[global::Cpp2ILInjected.Token(Token = "0x400032F")]
			ENTITIES,
			[global::Cpp2ILInjected.Token(Token = "0x4000330")]
			NMTOKEN,
			[global::Cpp2ILInjected.Token(Token = "0x4000331")]
			NMTOKENS,
			[global::Cpp2ILInjected.Token(Token = "0x4000332")]
			NOTATION,
			[global::Cpp2ILInjected.Token(Token = "0x4000333")]
			None,
			[global::Cpp2ILInjected.Token(Token = "0x4000334")]
			PERef,
			[global::Cpp2ILInjected.Token(Token = "0x4000335")]
			AttlistDecl,
			[global::Cpp2ILInjected.Token(Token = "0x4000336")]
			ElementDecl,
			[global::Cpp2ILInjected.Token(Token = "0x4000337")]
			EntityDecl,
			[global::Cpp2ILInjected.Token(Token = "0x4000338")]
			NotationDecl,
			[global::Cpp2ILInjected.Token(Token = "0x4000339")]
			Comment,
			[global::Cpp2ILInjected.Token(Token = "0x400033A")]
			PI,
			[global::Cpp2ILInjected.Token(Token = "0x400033B")]
			CondSectionStart,
			[global::Cpp2ILInjected.Token(Token = "0x400033C")]
			CondSectionEnd,
			[global::Cpp2ILInjected.Token(Token = "0x400033D")]
			Eof,
			[global::Cpp2ILInjected.Token(Token = "0x400033E")]
			REQUIRED,
			[global::Cpp2ILInjected.Token(Token = "0x400033F")]
			IMPLIED,
			[global::Cpp2ILInjected.Token(Token = "0x4000340")]
			FIXED,
			[global::Cpp2ILInjected.Token(Token = "0x4000341")]
			QName,
			[global::Cpp2ILInjected.Token(Token = "0x4000342")]
			Name,
			[global::Cpp2ILInjected.Token(Token = "0x4000343")]
			Nmtoken,
			[global::Cpp2ILInjected.Token(Token = "0x4000344")]
			Quote,
			[global::Cpp2ILInjected.Token(Token = "0x4000345")]
			LeftParen,
			[global::Cpp2ILInjected.Token(Token = "0x4000346")]
			RightParen,
			[global::Cpp2ILInjected.Token(Token = "0x4000347")]
			GreaterThan,
			[global::Cpp2ILInjected.Token(Token = "0x4000348")]
			Or,
			[global::Cpp2ILInjected.Token(Token = "0x4000349")]
			LeftBracket,
			[global::Cpp2ILInjected.Token(Token = "0x400034A")]
			RightBracket,
			[global::Cpp2ILInjected.Token(Token = "0x400034B")]
			PUBLIC,
			[global::Cpp2ILInjected.Token(Token = "0x400034C")]
			SYSTEM,
			[global::Cpp2ILInjected.Token(Token = "0x400034D")]
			Literal,
			[global::Cpp2ILInjected.Token(Token = "0x400034E")]
			DOCTYPE,
			[global::Cpp2ILInjected.Token(Token = "0x400034F")]
			NData,
			[global::Cpp2ILInjected.Token(Token = "0x4000350")]
			Percent,
			[global::Cpp2ILInjected.Token(Token = "0x4000351")]
			Star,
			[global::Cpp2ILInjected.Token(Token = "0x4000352")]
			QMark,
			[global::Cpp2ILInjected.Token(Token = "0x4000353")]
			Plus,
			[global::Cpp2ILInjected.Token(Token = "0x4000354")]
			PCDATA,
			[global::Cpp2ILInjected.Token(Token = "0x4000355")]
			Comma,
			[global::Cpp2ILInjected.Token(Token = "0x4000356")]
			ANY,
			[global::Cpp2ILInjected.Token(Token = "0x4000357")]
			EMPTY,
			[global::Cpp2ILInjected.Token(Token = "0x4000358")]
			IGNORE,
			[global::Cpp2ILInjected.Token(Token = "0x4000359")]
			INCLUDE
		}

		[global::Cpp2ILInjected.Token(Token = "0x200008B")]
		private enum ScanningFunction
		{
			[global::Cpp2ILInjected.Token(Token = "0x400035B")]
			SubsetContent,
			[global::Cpp2ILInjected.Token(Token = "0x400035C")]
			Name,
			[global::Cpp2ILInjected.Token(Token = "0x400035D")]
			QName,
			[global::Cpp2ILInjected.Token(Token = "0x400035E")]
			Nmtoken,
			[global::Cpp2ILInjected.Token(Token = "0x400035F")]
			Doctype1,
			[global::Cpp2ILInjected.Token(Token = "0x4000360")]
			Doctype2,
			[global::Cpp2ILInjected.Token(Token = "0x4000361")]
			Element1,
			[global::Cpp2ILInjected.Token(Token = "0x4000362")]
			Element2,
			[global::Cpp2ILInjected.Token(Token = "0x4000363")]
			Element3,
			[global::Cpp2ILInjected.Token(Token = "0x4000364")]
			Element4,
			[global::Cpp2ILInjected.Token(Token = "0x4000365")]
			Element5,
			[global::Cpp2ILInjected.Token(Token = "0x4000366")]
			Element6,
			[global::Cpp2ILInjected.Token(Token = "0x4000367")]
			Element7,
			[global::Cpp2ILInjected.Token(Token = "0x4000368")]
			Attlist1,
			[global::Cpp2ILInjected.Token(Token = "0x4000369")]
			Attlist2,
			[global::Cpp2ILInjected.Token(Token = "0x400036A")]
			Attlist3,
			[global::Cpp2ILInjected.Token(Token = "0x400036B")]
			Attlist4,
			[global::Cpp2ILInjected.Token(Token = "0x400036C")]
			Attlist5,
			[global::Cpp2ILInjected.Token(Token = "0x400036D")]
			Attlist6,
			[global::Cpp2ILInjected.Token(Token = "0x400036E")]
			Attlist7,
			[global::Cpp2ILInjected.Token(Token = "0x400036F")]
			Entity1,
			[global::Cpp2ILInjected.Token(Token = "0x4000370")]
			Entity2,
			[global::Cpp2ILInjected.Token(Token = "0x4000371")]
			Entity3,
			[global::Cpp2ILInjected.Token(Token = "0x4000372")]
			Notation1,
			[global::Cpp2ILInjected.Token(Token = "0x4000373")]
			CondSection1,
			[global::Cpp2ILInjected.Token(Token = "0x4000374")]
			CondSection2,
			[global::Cpp2ILInjected.Token(Token = "0x4000375")]
			CondSection3,
			[global::Cpp2ILInjected.Token(Token = "0x4000376")]
			Literal,
			[global::Cpp2ILInjected.Token(Token = "0x4000377")]
			SystemId,
			[global::Cpp2ILInjected.Token(Token = "0x4000378")]
			PublicId1,
			[global::Cpp2ILInjected.Token(Token = "0x4000379")]
			PublicId2,
			[global::Cpp2ILInjected.Token(Token = "0x400037A")]
			ClosingTag,
			[global::Cpp2ILInjected.Token(Token = "0x400037B")]
			ParamEntitySpace,
			[global::Cpp2ILInjected.Token(Token = "0x400037C")]
			None
		}

		[global::Cpp2ILInjected.Token(Token = "0x200008C")]
		private enum LiteralType
		{
			[global::Cpp2ILInjected.Token(Token = "0x400037E")]
			AttributeValue,
			[global::Cpp2ILInjected.Token(Token = "0x400037F")]
			EntityReplText,
			[global::Cpp2ILInjected.Token(Token = "0x4000380")]
			SystemOrPublicID
		}

		[global::Cpp2ILInjected.Token(Token = "0x200008D")]
		private class UndeclaredNotation
		{
			[global::Cpp2ILInjected.Token(Token = "0x60006AC")]
			[global::Cpp2ILInjected.Address(RVA = "0x1DA5764", Offset = "0x1DA5764", Length = "0x40")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DtdParser), Member = "AddUndeclaredNotation", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			internal UndeclaredNotation(string name, int lineNo, int linePos)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x4000381")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
			internal string name;

			[global::Cpp2ILInjected.Token(Token = "0x4000382")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
			internal int lineNo;

			[global::Cpp2ILInjected.Token(Token = "0x4000383")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x1C")]
			internal int linePos;

			[global::Cpp2ILInjected.Token(Token = "0x4000384")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
			internal DtdParser.UndeclaredNotation next;
		}

		[global::Cpp2ILInjected.Token(Token = "0x200008E")]
		private class ParseElementOnlyContent_LocalFrame
		{
			[global::Cpp2ILInjected.Token(Token = "0x60006AD")]
			[global::Cpp2ILInjected.Address(RVA = "0x1DA57A4", Offset = "0x1DA57A4", Length = "0x2C")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DtdParser), Member = "ParseElementOnlyContent", MemberParameters = new object[]
			{
				typeof(ParticleContentValidator),
				typeof(int)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public ParseElementOnlyContent_LocalFrame(int startParentEntityIdParam)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x4000385")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
			public int startParenEntityId;

			[global::Cpp2ILInjected.Token(Token = "0x4000386")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x14")]
			public DtdParser.Token parsingSchema;
		}
	}
}
