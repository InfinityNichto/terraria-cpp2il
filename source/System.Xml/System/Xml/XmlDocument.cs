using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Security;
using System.Xml.Schema;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Xml
{
	// Token: 0x0200004D RID: 77
	[global::Cpp2ILInjected.Token(Token = "0x200006A")]
	public class XmlDocument : XmlNode
	{
		// Token: 0x0600044A RID: 1098 RVA: 0x00003BAB File Offset: 0x00001DAB
		[global::Cpp2ILInjected.Token(Token = "0x60004C2")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D8DF20", Offset = "0x1D8DF20", Length = "0x5C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Newtonsoft.Json.Converters.XmlNodeConverter", Member = "ReadJson", MemberParameters = new object[]
		{
			"Newtonsoft.Json.JsonReader",
			typeof(Type),
			typeof(object),
			"Newtonsoft.Json.JsonSerializer"
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlImplementation), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public XmlDocument()
		{
			throw null;
		}

		// Token: 0x0600044B RID: 1099 RVA: 0x00003BAE File Offset: 0x00001DAE
		[global::Cpp2ILInjected.Token(Token = "0x60004C3")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D8DF7C", Offset = "0x1D8DF7C", Length = "0x3B4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlImplementation), Member = "CreateDocument", ReturnType = typeof(XmlDocument))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlNode), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DomNameTable), Member = ".ctor", MemberParameters = new object[] { typeof(XmlDocument) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 20)]
		protected internal XmlDocument(XmlImplementation imp)
		{
			throw null;
		}

		// Token: 0x170000EB RID: 235
		// (get) Token: 0x0600044C RID: 1100 RVA: 0x00003BB1 File Offset: 0x00001DB1
		// (set) Token: 0x0600044D RID: 1101 RVA: 0x00003BB4 File Offset: 0x00001DB4
		[global::Cpp2ILInjected.Token(Token = "0x1700010C")]
		internal SchemaInfo DtdSchemaInfo
		{
			[global::Cpp2ILInjected.Token(Token = "0x60004C4")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D8E330", Offset = "0x1D8E330", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x60004C5")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D8E338", Offset = "0x1D8E338", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x0600044E RID: 1102 RVA: 0x00003BB7 File Offset: 0x00001DB7
		[global::Cpp2ILInjected.Token(Token = "0x60004C6")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D8B390", Offset = "0x1D8B390", Length = "0xCC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlAttribute), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(XmlName),
			typeof(XmlDocument)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlElement), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(XmlName),
			typeof(bool),
			typeof(XmlDocument)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ValidateNames), Member = "ParseNmtoken", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlException), Member = "BuildCharExceptionArgs", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int)
		}, ReturnType = typeof(string[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string[])
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		internal static void CheckName(string name)
		{
			throw null;
		}

		// Token: 0x0600044F RID: 1103 RVA: 0x00003BBA File Offset: 0x00001DBA
		[global::Cpp2ILInjected.Token(Token = "0x60004C7")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D8E340", Offset = "0x1D8E340", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlElement), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(string),
			typeof(XmlDocument)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlLoader), Member = "LoadNode", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(XmlNode))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlLoader), Member = "LoadNodeDirect", ReturnType = typeof(XmlNode))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlLoader), Member = "LoadDocumentType", MemberParameters = new object[]
		{
			typeof(IDtdInfo),
			typeof(XmlDocumentType)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DomNameTable), Member = "AddName", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(string),
			typeof(IXmlSchemaInfo)
		}, ReturnType = typeof(XmlName))]
		internal XmlName AddXmlName(string prefix, string localName, string namespaceURI, IXmlSchemaInfo schemaInfo)
		{
			throw null;
		}

		// Token: 0x06000450 RID: 1104 RVA: 0x00003BBD File Offset: 0x00001DBD
		[global::Cpp2ILInjected.Token(Token = "0x60004C8")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D8E348", Offset = "0x1D8E348", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DomNameTable), Member = "GetName", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(string),
			typeof(IXmlSchemaInfo)
		}, ReturnType = typeof(XmlName))]
		internal XmlName GetXmlName(string prefix, string localName, string namespaceURI, IXmlSchemaInfo schemaInfo)
		{
			throw null;
		}

		// Token: 0x06000451 RID: 1105 RVA: 0x00003BC0 File Offset: 0x00001DC0
		[global::Cpp2ILInjected.Token(Token = "0x60004C9")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D8B490", Offset = "0x1D8B490", Length = "0xF4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlAttribute), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(string),
			typeof(XmlDocument)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlDocument), Member = "CreateAttribute", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(XmlAttribute))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlLoader), Member = "LoadAttributeNode", ReturnType = typeof(XmlAttribute))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlLoader), Member = "LoadDefaultAttribute", ReturnType = typeof(XmlAttribute))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlLoader), Member = "LoadDocumentType", MemberParameters = new object[]
		{
			typeof(IDtdInfo),
			typeof(XmlDocumentType)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DomNameTable), Member = "AddName", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(string),
			typeof(IXmlSchemaInfo)
		}, ReturnType = typeof(XmlName))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Res), Member = "GetString", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object[])
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		internal XmlName AddAttrXmlName(string prefix, string localName, string namespaceURI, IXmlSchemaInfo schemaInfo)
		{
			throw null;
		}

		// Token: 0x06000452 RID: 1106 RVA: 0x00003BC3 File Offset: 0x00001DC3
		[global::Cpp2ILInjected.Token(Token = "0x60004CA")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D8E350", Offset = "0x1D8E350", Length = "0xB8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlLoader), Member = "LoadDocumentType", MemberParameters = new object[]
		{
			typeof(IDtdInfo),
			typeof(XmlDocumentType)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Hashtable), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		internal bool AddIdInfo(XmlName eleName, XmlName attrName)
		{
			throw null;
		}

		// Token: 0x06000453 RID: 1107 RVA: 0x00003BC6 File Offset: 0x00001DC6
		[global::Cpp2ILInjected.Token(Token = "0x60004CB")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D8E408", Offset = "0x1D8E408", Length = "0xCC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlAttributeCollection), Member = "InsertParentIntoElementIdAttrMap", MemberParameters = new object[] { typeof(XmlAttribute) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlAttributeCollection), Member = "RemoveParentFromElementIdAttrMap", MemberParameters = new object[] { typeof(XmlAttribute) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlAttributeCollection), Member = "PrepareParentInElementIdAttrMap", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlDocument), Member = "GetIDInfoByElement", MemberParameters = new object[] { typeof(XmlName) }, ReturnType = typeof(XmlName))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DomNameTable), Member = "GetName", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(string),
			typeof(IXmlSchemaInfo)
		}, ReturnType = typeof(XmlName))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		private XmlName GetIDInfoByElement_(XmlName eleName)
		{
			throw null;
		}

		// Token: 0x06000454 RID: 1108 RVA: 0x00003BC9 File Offset: 0x00001DC9
		[global::Cpp2ILInjected.Token(Token = "0x60004CC")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D8CE90", Offset = "0x1D8CE90", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlDocument), Member = "GetIDInfoByElement_", MemberParameters = new object[] { typeof(XmlName) }, ReturnType = typeof(XmlName))]
		internal XmlName GetIDInfoByElement(XmlName eleName)
		{
			throw null;
		}

		// Token: 0x06000455 RID: 1109 RVA: 0x00003BCC File Offset: 0x00001DCC
		[global::Cpp2ILInjected.Token(Token = "0x60004CD")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D8E4D4", Offset = "0x1D8E4D4", Length = "0x60C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlDocument), Member = "AddElementWithId", MemberParameters = new object[]
		{
			typeof(string),
			typeof(XmlElement)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlDocument), Member = "RemoveElementWithId", MemberParameters = new object[]
		{
			typeof(string),
			typeof(XmlElement)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArrayList), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 31)]
		private WeakReference GetElement(ArrayList elementList, XmlElement elem)
		{
			throw null;
		}

		// Token: 0x06000456 RID: 1110 RVA: 0x00003BCF File Offset: 0x00001DCF
		[global::Cpp2ILInjected.Token(Token = "0x60004CE")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D8CEA4", Offset = "0x1D8CEA4", Length = "0x1D4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlAttributeCollection), Member = "InsertParentIntoElementIdAttrMap", MemberParameters = new object[] { typeof(XmlAttribute) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlAttributeCollection), Member = "ResetParentInElementIdAttrMap", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlDocument), Member = "GetElement", MemberParameters = new object[]
		{
			typeof(ArrayList),
			typeof(XmlElement)
		}, ReturnType = typeof(WeakReference))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Hashtable), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArrayList), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WeakReference), Member = ".ctor", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
		internal void AddElementWithId(string id, XmlElement elem)
		{
			throw null;
		}

		// Token: 0x06000457 RID: 1111 RVA: 0x00003BD2 File Offset: 0x00001DD2
		[global::Cpp2ILInjected.Token(Token = "0x60004CF")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D8D078", Offset = "0x1D8D078", Length = "0x128")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlAttributeCollection), Member = "RemoveParentFromElementIdAttrMap", MemberParameters = new object[] { typeof(XmlAttribute) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlAttributeCollection), Member = "ResetParentInElementIdAttrMap", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlDocument), Member = "GetElement", MemberParameters = new object[]
		{
			typeof(ArrayList),
			typeof(XmlElement)
		}, ReturnType = typeof(WeakReference))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		internal void RemoveElementWithId(string id, XmlElement elem)
		{
			throw null;
		}

		// Token: 0x06000458 RID: 1112 RVA: 0x00003BD5 File Offset: 0x00001DD5
		[global::Cpp2ILInjected.Token(Token = "0x60004D0")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D8EAE0", Offset = "0x1D8EAE0", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlDocument), Member = "ImportChildren", MemberParameters = new object[]
		{
			typeof(XmlNode),
			typeof(XmlNode),
			typeof(bool)
		}, ReturnType = typeof(void))]
		public override XmlNode CloneNode(bool deep)
		{
			throw null;
		}

		// Token: 0x170000EC RID: 236
		// (get) Token: 0x06000459 RID: 1113 RVA: 0x00003BD8 File Offset: 0x00001DD8
		[global::Cpp2ILInjected.Token(Token = "0x1700010D")]
		public override XmlNodeType NodeType
		{
			[global::Cpp2ILInjected.Token(Token = "0x60004D1")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D8EBC8", Offset = "0x1D8EBC8", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170000ED RID: 237
		// (get) Token: 0x0600045A RID: 1114 RVA: 0x00003BDB File Offset: 0x00001DDB
		[global::Cpp2ILInjected.Token(Token = "0x1700010E")]
		public override XmlNode ParentNode
		{
			[global::Cpp2ILInjected.Token(Token = "0x60004D2")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D8EBD0", Offset = "0x1D8EBD0", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170000EE RID: 238
		// (get) Token: 0x0600045B RID: 1115 RVA: 0x00003BDE File Offset: 0x00001DDE
		[global::Cpp2ILInjected.Token(Token = "0x1700010F")]
		public virtual XmlDocumentType DocumentType
		{
			[global::Cpp2ILInjected.Token(Token = "0x60004D3")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D8EBD8", Offset = "0x1D8EBD8", Length = "0x8C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170000EF RID: 239
		// (get) Token: 0x0600045C RID: 1116 RVA: 0x00003BE1 File Offset: 0x00001DE1
		[global::Cpp2ILInjected.Token(Token = "0x17000110")]
		internal virtual XmlDeclaration Declaration
		{
			[global::Cpp2ILInjected.Token(Token = "0x60004D4")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D8EC64", Offset = "0x1D8EC64", Length = "0xA4")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170000F0 RID: 240
		// (get) Token: 0x0600045D RID: 1117 RVA: 0x00003BE4 File Offset: 0x00001DE4
		[global::Cpp2ILInjected.Token(Token = "0x17000111")]
		public XmlImplementation Implementation
		{
			[global::Cpp2ILInjected.Token(Token = "0x60004D5")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D8ED08", Offset = "0x1D8ED08", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170000F1 RID: 241
		// (get) Token: 0x0600045E RID: 1118 RVA: 0x00003BE7 File Offset: 0x00001DE7
		[global::Cpp2ILInjected.Token(Token = "0x17000112")]
		public override string Name
		{
			[global::Cpp2ILInjected.Token(Token = "0x60004D6")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D8ED10", Offset = "0x1D8ED10", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170000F2 RID: 242
		// (get) Token: 0x0600045F RID: 1119 RVA: 0x00003BEA File Offset: 0x00001DEA
		[global::Cpp2ILInjected.Token(Token = "0x17000113")]
		public override string LocalName
		{
			[global::Cpp2ILInjected.Token(Token = "0x60004D7")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D8ED18", Offset = "0x1D8ED18", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170000F3 RID: 243
		// (get) Token: 0x06000460 RID: 1120 RVA: 0x00003BED File Offset: 0x00001DED
		[global::Cpp2ILInjected.Token(Token = "0x17000114")]
		public XmlElement DocumentElement
		{
			[global::Cpp2ILInjected.Token(Token = "0x60004D8")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D8ED20", Offset = "0x1D8ED20", Length = "0x8C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlDocument), Member = "IsValidChildType", MemberParameters = new object[] { typeof(XmlNodeType) }, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Newtonsoft.Json.Converters.XmlDocumentWrapper", Member = "get_DocumentElement", ReturnType = "Newtonsoft.Json.Converters.IXmlElement")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170000F4 RID: 244
		// (get) Token: 0x06000461 RID: 1121 RVA: 0x00003BF0 File Offset: 0x00001DF0
		[global::Cpp2ILInjected.Token(Token = "0x17000115")]
		internal override bool IsContainer
		{
			[global::Cpp2ILInjected.Token(Token = "0x60004D9")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D8EDAC", Offset = "0x1D8EDAC", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170000F5 RID: 245
		// (get) Token: 0x06000462 RID: 1122 RVA: 0x00003BF3 File Offset: 0x00001DF3
		// (set) Token: 0x06000463 RID: 1123 RVA: 0x00003BF6 File Offset: 0x00001DF6
		[global::Cpp2ILInjected.Token(Token = "0x17000116")]
		internal override XmlLinkedNode LastNode
		{
			[global::Cpp2ILInjected.Token(Token = "0x60004DA")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D8EDB4", Offset = "0x1D8EDB4", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x60004DB")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D8EDBC", Offset = "0x1D8EDBC", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x170000F6 RID: 246
		// (get) Token: 0x06000464 RID: 1124 RVA: 0x00003BF9 File Offset: 0x00001DF9
		[global::Cpp2ILInjected.Token(Token = "0x17000117")]
		public override XmlDocument OwnerDocument
		{
			[global::Cpp2ILInjected.Token(Token = "0x60004DC")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D8EDC4", Offset = "0x1D8EDC4", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170000F7 RID: 247
		// (set) Token: 0x06000465 RID: 1125 RVA: 0x00003BFC File Offset: 0x00001DFC
		[global::Cpp2ILInjected.Token(Token = "0x17000118")]
		public XmlSchemaSet Schemas
		{
			[global::Cpp2ILInjected.Token(Token = "0x60004DD")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D8EDCC", Offset = "0x1D8EDCC", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x170000F8 RID: 248
		// (get) Token: 0x06000466 RID: 1126 RVA: 0x00003BFF File Offset: 0x00001DFF
		[global::Cpp2ILInjected.Token(Token = "0x17000119")]
		internal bool CanReportValidity
		{
			[global::Cpp2ILInjected.Token(Token = "0x60004DE")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D8EDD4", Offset = "0x1D8EDD4", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170000F9 RID: 249
		// (get) Token: 0x06000467 RID: 1127 RVA: 0x00003C02 File Offset: 0x00001E02
		[global::Cpp2ILInjected.Token(Token = "0x1700011A")]
		internal bool HasSetResolver
		{
			[global::Cpp2ILInjected.Token(Token = "0x60004DF")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D8EDDC", Offset = "0x1D8EDDC", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06000468 RID: 1128 RVA: 0x00003C05 File Offset: 0x00001E05
		[global::Cpp2ILInjected.Token(Token = "0x60004E0")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D8EDE4", Offset = "0x1D8EDE4", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		internal XmlResolver GetResolver()
		{
			throw null;
		}

		// Token: 0x170000FA RID: 250
		// (set) Token: 0x06000469 RID: 1129 RVA: 0x00003C08 File Offset: 0x00001E08
		[global::Cpp2ILInjected.Token(Token = "0x1700011B")]
		public virtual XmlResolver XmlResolver
		{
			[global::Cpp2ILInjected.Token(Token = "0x60004E1")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D8EDEC", Offset = "0x1D8EDEC", Length = "0x174")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NamedPermissionSet), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PermissionSet), Member = "Demand", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Res), Member = "GetString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SecurityException), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(string),
				typeof(Exception)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 17)]
			set
			{
				throw null;
			}
		}

		// Token: 0x0600046A RID: 1130 RVA: 0x00003C0B File Offset: 0x00001E0B
		[global::Cpp2ILInjected.Token(Token = "0x60004E2")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D8EF60", Offset = "0x1D8EF60", Length = "0xE8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlDocument), Member = "get_DocumentElement", ReturnType = typeof(XmlElement))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Res), Member = "GetString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		internal override bool IsValidChildType(XmlNodeType type)
		{
			throw null;
		}

		// Token: 0x0600046B RID: 1131 RVA: 0x00003C0E File Offset: 0x00001E0E
		[global::Cpp2ILInjected.Token(Token = "0x60004E3")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D8F048", Offset = "0x1D8F048", Length = "0xA8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlDocument), Member = "CanInsertAfter", MemberParameters = new object[]
		{
			typeof(XmlNode),
			typeof(XmlNode)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		private bool HasNodeTypeInPrevSiblings(XmlNodeType nt, XmlNode refNode)
		{
			throw null;
		}

		// Token: 0x0600046C RID: 1132 RVA: 0x00003C11 File Offset: 0x00001E11
		[global::Cpp2ILInjected.Token(Token = "0x60004E4")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D8F0F0", Offset = "0x1D8F0F0", Length = "0x64")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private bool HasNodeTypeInNextSiblings(XmlNodeType nt, XmlNode refNode)
		{
			throw null;
		}

		// Token: 0x0600046D RID: 1133 RVA: 0x00003C14 File Offset: 0x00001E14
		[global::Cpp2ILInjected.Token(Token = "0x60004E5")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D8F154", Offset = "0x1D8F154", Length = "0xF0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlDocument), Member = "HasNodeTypeInPrevSiblings", MemberParameters = new object[]
		{
			typeof(XmlNodeType),
			typeof(XmlNode)
		}, ReturnType = typeof(bool))]
		internal override bool CanInsertAfter(XmlNode newChild, XmlNode refChild)
		{
			throw null;
		}

		// Token: 0x0600046E RID: 1134 RVA: 0x00003C17 File Offset: 0x00001E17
		[global::Cpp2ILInjected.Token(Token = "0x60004E6")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D8F244", Offset = "0x1D8F244", Length = "0xC0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Newtonsoft.Json.Converters.XmlDocumentWrapper", Member = "CreateAttribute", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = "Newtonsoft.Json.Converters.IXmlNode")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlNode), Member = "SplitName", MemberParameters = new object[]
		{
			typeof(string),
			typeof(ref string),
			typeof(ref string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlDocument), Member = "SetDefaultNamespace", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(ref string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public XmlAttribute CreateAttribute(string name)
		{
			throw null;
		}

		// Token: 0x0600046F RID: 1135 RVA: 0x00003C1A File Offset: 0x00001E1A
		[global::Cpp2ILInjected.Token(Token = "0x60004E7")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D8F304", Offset = "0x1D8F304", Length = "0x88")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlDocument), Member = "CreateAttribute", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(XmlAttribute))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlDocument), Member = "PrepareDefaultAttribute", MemberParameters = new object[]
		{
			typeof(SchemaAttDef),
			typeof(string),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(XmlAttribute))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(bool))]
		internal void SetDefaultNamespace(string prefix, string localName, ref string namespaceURI)
		{
			throw null;
		}

		// Token: 0x06000470 RID: 1136 RVA: 0x00003C1D File Offset: 0x00001E1D
		[global::Cpp2ILInjected.Token(Token = "0x60004E8")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D8F38C", Offset = "0x1D8F38C", Length = "0x74")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlLinkedNode), Member = ".ctor", MemberParameters = new object[] { typeof(XmlDocument) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public virtual XmlCDataSection CreateCDataSection(string data)
		{
			throw null;
		}

		// Token: 0x06000471 RID: 1137 RVA: 0x00003C20 File Offset: 0x00001E20
		[global::Cpp2ILInjected.Token(Token = "0x60004E9")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D8F400", Offset = "0x1D8F400", Length = "0x6C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlLinkedNode), Member = ".ctor", MemberParameters = new object[] { typeof(XmlDocument) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public virtual XmlComment CreateComment(string data)
		{
			throw null;
		}

		// Token: 0x06000472 RID: 1138 RVA: 0x00003C23 File Offset: 0x00001E23
		[global::Cpp2ILInjected.Token(Token = "0x60004EA")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D8F46C", Offset = "0x1D8F46C", Length = "0x8C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlDocumentType), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(string),
			typeof(string),
			typeof(XmlDocument)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public virtual XmlDocumentType CreateDocumentType(string name, string publicId, string systemId, string internalSubset)
		{
			throw null;
		}

		// Token: 0x06000473 RID: 1139 RVA: 0x00003C26 File Offset: 0x00001E26
		[global::Cpp2ILInjected.Token(Token = "0x60004EB")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D8F4F8", Offset = "0x1D8F4F8", Length = "0x5C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlDocumentFragment), Member = ".ctor", MemberParameters = new object[] { typeof(XmlDocument) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public virtual XmlDocumentFragment CreateDocumentFragment()
		{
			throw null;
		}

		// Token: 0x06000474 RID: 1140 RVA: 0x00003C29 File Offset: 0x00001E29
		[global::Cpp2ILInjected.Token(Token = "0x60004EC")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D8F554", Offset = "0x1D8F554", Length = "0xB0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Newtonsoft.Json.Converters.XmlDocumentWrapper", Member = "CreateElement", MemberParameters = new object[] { typeof(string) }, ReturnType = "Newtonsoft.Json.Converters.IXmlElement")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlNode), Member = "SplitName", MemberParameters = new object[]
		{
			typeof(string),
			typeof(ref string),
			typeof(ref string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public XmlElement CreateElement(string name)
		{
			throw null;
		}

		// Token: 0x06000475 RID: 1141 RVA: 0x00003C2C File Offset: 0x00001E2C
		[global::Cpp2ILInjected.Token(Token = "0x60004ED")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D8F604", Offset = "0x1D8F604", Length = "0x270")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlDocument), Member = "CreateElement", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(XmlElement))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlDocument), Member = "GetSchemaElementDecl", MemberParameters = new object[] { typeof(XmlElement) }, ReturnType = typeof(SchemaElementDecl))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, object>), Member = "GetEnumerator", ReturnType = "Enumerator<TKey, TValue>")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SchemaDeclBase), Member = "get_Prefix", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlDocument), Member = "PrepareDefaultAttribute", MemberParameters = new object[]
		{
			typeof(SchemaAttDef),
			typeof(string),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(XmlAttribute))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
		internal void AddDefaultAttributes(XmlElement elem)
		{
			throw null;
		}

		// Token: 0x06000476 RID: 1142 RVA: 0x00003C2F File Offset: 0x00001E2F
		[global::Cpp2ILInjected.Token(Token = "0x60004EE")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D8F874", Offset = "0x1D8F874", Length = "0x100")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlDocument), Member = "AddDefaultAttributes", MemberParameters = new object[] { typeof(XmlElement) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlDocument), Member = "GetDefaultAttribute", MemberParameters = new object[]
		{
			typeof(XmlElement),
			typeof(string),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(XmlAttribute))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlQualifiedName), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, object>), Member = "TryGetValue", MemberParameters = new object[]
		{
			typeof(object),
			typeof(ref object)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		private SchemaElementDecl GetSchemaElementDecl(XmlElement elem)
		{
			throw null;
		}

		// Token: 0x06000477 RID: 1143 RVA: 0x00003C32 File Offset: 0x00001E32
		[global::Cpp2ILInjected.Token(Token = "0x60004EF")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D8F974", Offset = "0x1D8F974", Length = "0xF4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlDocument), Member = "AddDefaultAttributes", MemberParameters = new object[] { typeof(XmlElement) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlDocument), Member = "GetDefaultAttribute", MemberParameters = new object[]
		{
			typeof(XmlElement),
			typeof(string),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(XmlAttribute))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlDocument), Member = "SetDefaultNamespace", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(ref string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SchemaDeclBase), Member = "get_DefaultValueRaw", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		private XmlAttribute PrepareDefaultAttribute(SchemaAttDef attdef, string attrPrefix, string attrLocalname, string attrNamespaceURI)
		{
			throw null;
		}

		// Token: 0x06000478 RID: 1144 RVA: 0x00003C35 File Offset: 0x00001E35
		[global::Cpp2ILInjected.Token(Token = "0x60004F0")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D8FA68", Offset = "0x1D8FA68", Length = "0x6C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlEntityReference), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(XmlDocument)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public virtual XmlEntityReference CreateEntityReference(string name)
		{
			throw null;
		}

		// Token: 0x06000479 RID: 1145 RVA: 0x00003C38 File Offset: 0x00001E38
		[global::Cpp2ILInjected.Token(Token = "0x60004F1")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D8FAD4", Offset = "0x1D8FAD4", Length = "0x74")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlProcessingInstruction), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(XmlDocument)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public virtual XmlProcessingInstruction CreateProcessingInstruction(string target, string data)
		{
			throw null;
		}

		// Token: 0x0600047A RID: 1146 RVA: 0x00003C3B File Offset: 0x00001E3B
		[global::Cpp2ILInjected.Token(Token = "0x60004F2")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D8FB48", Offset = "0x1D8FB48", Length = "0x80")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlDeclaration), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(string),
			typeof(XmlDocument)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public virtual XmlDeclaration CreateXmlDeclaration(string version, string encoding, string standalone)
		{
			throw null;
		}

		// Token: 0x0600047B RID: 1147 RVA: 0x00003C3E File Offset: 0x00001E3E
		[global::Cpp2ILInjected.Token(Token = "0x60004F3")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D8FBC8", Offset = "0x1D8FBC8", Length = "0x6C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlText), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(XmlDocument)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public virtual XmlText CreateTextNode(string text)
		{
			throw null;
		}

		// Token: 0x0600047C RID: 1148 RVA: 0x00003C41 File Offset: 0x00001E41
		[global::Cpp2ILInjected.Token(Token = "0x60004F4")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D8FC34", Offset = "0x1D8FC34", Length = "0x6C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlSignificantWhitespace), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(XmlDocument)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public virtual XmlSignificantWhitespace CreateSignificantWhitespace(string text)
		{
			throw null;
		}

		// Token: 0x0600047D RID: 1149 RVA: 0x00003C44 File Offset: 0x00001E44
		[global::Cpp2ILInjected.Token(Token = "0x60004F5")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D8FCA0", Offset = "0x1D8FCA0", Length = "0x6C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlWhitespace), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(XmlDocument)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public virtual XmlWhitespace CreateWhitespace(string text)
		{
			throw null;
		}

		// Token: 0x0600047E RID: 1150 RVA: 0x00003C47 File Offset: 0x00001E47
		[global::Cpp2ILInjected.Token(Token = "0x60004F6")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D8FD0C", Offset = "0x1D8FD0C", Length = "0xA4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Newtonsoft.Json.Converters.XmlDocumentWrapper", Member = "CreateAttribute", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(string)
		}, ReturnType = "Newtonsoft.Json.Converters.IXmlNode")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlNode), Member = "SplitName", MemberParameters = new object[]
		{
			typeof(string),
			typeof(ref string),
			typeof(ref string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public XmlAttribute CreateAttribute(string qualifiedName, string namespaceURI)
		{
			throw null;
		}

		// Token: 0x0600047F RID: 1151 RVA: 0x00003C4A File Offset: 0x00001E4A
		[global::Cpp2ILInjected.Token(Token = "0x60004F7")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D8FDB0", Offset = "0x1D8FDB0", Length = "0xA4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Newtonsoft.Json.Converters.XmlDocumentWrapper", Member = "CreateElement", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = "Newtonsoft.Json.Converters.IXmlElement")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlNode), Member = "SplitName", MemberParameters = new object[]
		{
			typeof(string),
			typeof(ref string),
			typeof(ref string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public XmlElement CreateElement(string qualifiedName, string namespaceURI)
		{
			throw null;
		}

		// Token: 0x06000480 RID: 1152 RVA: 0x00003C4D File Offset: 0x00001E4D
		[global::Cpp2ILInjected.Token(Token = "0x60004F8")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D8FE54", Offset = "0x1D8FE54", Length = "0x4A0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlDocument), Member = "ImportAttributes", MemberParameters = new object[]
		{
			typeof(XmlNode),
			typeof(XmlNode)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlDocument), Member = "ImportChildren", MemberParameters = new object[]
		{
			typeof(XmlNode),
			typeof(XmlNode),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlDocument), Member = "ImportAttributes", MemberParameters = new object[]
		{
			typeof(XmlNode),
			typeof(XmlNode)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlDocument), Member = "ImportChildren", MemberParameters = new object[]
		{
			typeof(XmlNode),
			typeof(XmlNode),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Res), Member = "GetString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Enum), Member = "ToString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Format", MemberParameters = new object[]
		{
			typeof(IFormatProvider),
			typeof(string),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 17)]
		private XmlNode ImportNodeInternal(XmlNode node, bool deep)
		{
			throw null;
		}

		// Token: 0x06000481 RID: 1153 RVA: 0x00003C50 File Offset: 0x00001E50
		[global::Cpp2ILInjected.Token(Token = "0x60004F9")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D902F4", Offset = "0x1D902F4", Length = "0xF4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlDocument), Member = "ImportNodeInternal", MemberParameters = new object[]
		{
			typeof(XmlNode),
			typeof(bool)
		}, ReturnType = typeof(XmlNode))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlAttributeCollection), Member = "get_ItemOf", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(XmlAttribute))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlDocument), Member = "ImportNodeInternal", MemberParameters = new object[]
		{
			typeof(XmlNode),
			typeof(bool)
		}, ReturnType = typeof(XmlNode))]
		private void ImportAttributes(XmlNode fromElem, XmlNode toElem)
		{
			throw null;
		}

		// Token: 0x06000482 RID: 1154 RVA: 0x00003C53 File Offset: 0x00001E53
		[global::Cpp2ILInjected.Token(Token = "0x60004FA")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D8EB38", Offset = "0x1D8EB38", Length = "0x90")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlDocument), Member = "CloneNode", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(XmlNode))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlDocument), Member = "ImportNodeInternal", MemberParameters = new object[]
		{
			typeof(XmlNode),
			typeof(bool)
		}, ReturnType = typeof(XmlNode))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlDocument), Member = "ImportNodeInternal", MemberParameters = new object[]
		{
			typeof(XmlNode),
			typeof(bool)
		}, ReturnType = typeof(XmlNode))]
		private void ImportChildren(XmlNode fromNode, XmlNode toNode, bool deep)
		{
			throw null;
		}

		// Token: 0x170000FB RID: 251
		// (get) Token: 0x06000483 RID: 1155 RVA: 0x00003C56 File Offset: 0x00001E56
		[global::Cpp2ILInjected.Token(Token = "0x1700011C")]
		public XmlNameTable NameTable
		{
			[global::Cpp2ILInjected.Token(Token = "0x60004FB")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D8AE60", Offset = "0x1D8AE60", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlEntity), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(string),
				typeof(string),
				typeof(string),
				typeof(string),
				typeof(string),
				typeof(XmlDocument)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlEntityReference), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(string),
				typeof(XmlDocument)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlLoader), Member = "ParseDocumentType", MemberParameters = new object[]
			{
				typeof(XmlDocumentType),
				typeof(bool),
				typeof(XmlResolver)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlLoader), Member = "GetContext", MemberParameters = new object[] { typeof(XmlNode) }, ReturnType = typeof(XmlParserContext))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlName), Member = "get_Name", ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlNode), Member = "GetPrefixOfNamespaceStrict", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlNotation), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(string),
				typeof(string),
				typeof(string),
				typeof(XmlDocument)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 8)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06000484 RID: 1156 RVA: 0x00003C59 File Offset: 0x00001E59
		[global::Cpp2ILInjected.Token(Token = "0x60004FC")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D903E8", Offset = "0x1D903E8", Length = "0x98")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlDocument), Member = "AddAttrXmlName", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(string),
			typeof(IXmlSchemaInfo)
		}, ReturnType = typeof(XmlName))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlAttribute), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(XmlName),
			typeof(XmlDocument)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public virtual XmlAttribute CreateAttribute(string prefix, string localName, string namespaceURI)
		{
			throw null;
		}

		// Token: 0x06000485 RID: 1157 RVA: 0x00003C5C File Offset: 0x00001E5C
		[global::Cpp2ILInjected.Token(Token = "0x60004FD")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D90480", Offset = "0x1D90480", Length = "0x84")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlUnspecifiedAttribute), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(string),
			typeof(XmlDocument)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		protected internal virtual XmlAttribute CreateDefaultAttribute(string prefix, string localName, string namespaceURI)
		{
			throw null;
		}

		// Token: 0x06000486 RID: 1158 RVA: 0x00003C5F File Offset: 0x00001E5F
		[global::Cpp2ILInjected.Token(Token = "0x60004FE")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D90504", Offset = "0x1D90504", Length = "0xB4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DomNameTable), Member = "AddName", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(string),
			typeof(IXmlSchemaInfo)
		}, ReturnType = typeof(XmlName))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlElement), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(XmlName),
			typeof(bool),
			typeof(XmlDocument)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlDocument), Member = "AddDefaultAttributes", MemberParameters = new object[] { typeof(XmlElement) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public virtual XmlElement CreateElement(string prefix, string localName, string namespaceURI)
		{
			throw null;
		}

		// Token: 0x170000FC RID: 252
		// (get) Token: 0x06000487 RID: 1159 RVA: 0x00003C62 File Offset: 0x00001E62
		[global::Cpp2ILInjected.Token(Token = "0x1700011D")]
		public override bool IsReadOnly
		{
			[global::Cpp2ILInjected.Token(Token = "0x60004FF")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D905B8", Offset = "0x1D905B8", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170000FD RID: 253
		// (get) Token: 0x06000488 RID: 1160 RVA: 0x00003C65 File Offset: 0x00001E65
		// (set) Token: 0x06000489 RID: 1161 RVA: 0x00003C68 File Offset: 0x00001E68
		[global::Cpp2ILInjected.Token(Token = "0x1700011E")]
		internal XmlNamedNodeMap Entities
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000500")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D905C0", Offset = "0x1D905C0", Length = "0x68")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlLoader), Member = "ExpandEntityReference", MemberParameters = new object[] { typeof(XmlEntityReference) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlNamedNodeMap), Member = ".ctor", MemberParameters = new object[] { typeof(XmlNode) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6000501")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D90628", Offset = "0x1D90628", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x170000FE RID: 254
		// (get) Token: 0x0600048A RID: 1162 RVA: 0x00003C6B File Offset: 0x00001E6B
		// (set) Token: 0x0600048B RID: 1163 RVA: 0x00003C6E File Offset: 0x00001E6E
		[global::Cpp2ILInjected.Token(Token = "0x1700011F")]
		internal bool IsLoading
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000502")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D90630", Offset = "0x1D90630", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6000503")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D90638", Offset = "0x1D90638", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x170000FF RID: 255
		// (get) Token: 0x0600048C RID: 1164 RVA: 0x00003C71 File Offset: 0x00001E71
		[global::Cpp2ILInjected.Token(Token = "0x17000120")]
		internal bool ActualLoadingStatus
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000504")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D90644", Offset = "0x1D90644", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0600048D RID: 1165 RVA: 0x00003C74 File Offset: 0x00001E74
		[global::Cpp2ILInjected.Token(Token = "0x6000505")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D9064C", Offset = "0x1D9064C", Length = "0x5C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlDocument), Member = "LoadXml", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlTextReaderImpl), Member = "set_XmlValidatingReaderCompatibilityMode", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlTextReaderImpl), Member = "set_EntityHandling", MemberParameters = new object[] { typeof(EntityHandling) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlTextReaderImpl), Member = "set_XmlResolver", MemberParameters = new object[] { typeof(XmlResolver) }, ReturnType = typeof(void))]
		private XmlTextReader SetupReader(XmlTextReader tr)
		{
			throw null;
		}

		// Token: 0x0600048E RID: 1166 RVA: 0x00003C77 File Offset: 0x00001E77
		[global::Cpp2ILInjected.Token(Token = "0x6000506")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D906A8", Offset = "0x1D906A8", Length = "0x108")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlLoader), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlLoader), Member = "Load", MemberParameters = new object[]
		{
			typeof(XmlDocument),
			typeof(XmlReader),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
		public virtual void Load(XmlReader reader)
		{
			throw null;
		}

		// Token: 0x0600048F RID: 1167 RVA: 0x00003C7A File Offset: 0x00001E7A
		[global::Cpp2ILInjected.Token(Token = "0x6000507")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D907B0", Offset = "0x1D907B0", Length = "0x13C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringReader), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlTextReader), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(TextReader),
			typeof(XmlNameTable)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlDocument), Member = "SetupReader", MemberParameters = new object[] { typeof(XmlTextReader) }, ReturnType = typeof(XmlTextReader))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
		public virtual void LoadXml(string xml)
		{
			throw null;
		}

		// Token: 0x17000100 RID: 256
		// (set) Token: 0x06000490 RID: 1168 RVA: 0x00003C7D File Offset: 0x00001E7D
		[global::Cpp2ILInjected.Token(Token = "0x17000121")]
		public override string InnerText
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000508")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D908EC", Offset = "0x1D908EC", Length = "0x58")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Res), Member = "GetString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
			set
			{
				throw null;
			}
		}

		// Token: 0x17000101 RID: 257
		// (set) Token: 0x06000491 RID: 1169 RVA: 0x00003C80 File Offset: 0x00001E80
		[global::Cpp2ILInjected.Token(Token = "0x17000122")]
		public override string InnerXml
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000509")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D90944", Offset = "0x1D90944", Length = "0x10")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			set
			{
				throw null;
			}
		}

		// Token: 0x06000492 RID: 1170 RVA: 0x00003C83 File Offset: 0x00001E83
		[global::Cpp2ILInjected.Token(Token = "0x600050A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D90954", Offset = "0x1D90954", Length = "0xF8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlNodeChangedEventArgs), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(XmlNode),
			typeof(XmlNode),
			typeof(XmlNode),
			typeof(string),
			typeof(string),
			typeof(XmlNodeChangedAction)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		internal override XmlNodeChangedEventArgs GetEventArgs(XmlNode node, XmlNode oldParent, XmlNode newParent, string oldValue, string newValue, XmlNodeChangedAction action)
		{
			throw null;
		}

		// Token: 0x06000493 RID: 1171 RVA: 0x00003C86 File Offset: 0x00001E86
		[global::Cpp2ILInjected.Token(Token = "0x600050B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D8BB30", Offset = "0x1D8BB30", Length = "0xB0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlAttribute), Member = "AppendChildForLoad", MemberParameters = new object[]
		{
			typeof(XmlNode),
			typeof(XmlDocument)
		}, ReturnType = typeof(XmlNode))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlDocument), Member = "AppendChildForLoad", MemberParameters = new object[]
		{
			typeof(XmlNode),
			typeof(XmlDocument)
		}, ReturnType = typeof(XmlNode))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlElement), Member = "AppendChildForLoad", MemberParameters = new object[]
		{
			typeof(XmlNode),
			typeof(XmlDocument)
		}, ReturnType = typeof(XmlNode))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlNamedNodeMap), Member = "AddNodeForLoad", MemberParameters = new object[]
		{
			typeof(XmlNode),
			typeof(XmlDocument)
		}, ReturnType = typeof(XmlNode))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlNode), Member = "AppendChildForLoad", MemberParameters = new object[]
		{
			typeof(XmlNode),
			typeof(XmlDocument)
		}, ReturnType = typeof(XmlNode))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlNodeChangedEventArgs), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(XmlNode),
			typeof(XmlNode),
			typeof(XmlNode),
			typeof(string),
			typeof(string),
			typeof(XmlNodeChangedAction)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		internal XmlNodeChangedEventArgs GetInsertEventArgsForLoad(XmlNode node, XmlNode newParent)
		{
			throw null;
		}

		// Token: 0x06000494 RID: 1172 RVA: 0x00003C89 File Offset: 0x00001E89
		[global::Cpp2ILInjected.Token(Token = "0x600050C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D90A4C", Offset = "0x1D90A4C", Length = "0x54")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		internal override void BeforeEvent(XmlNodeChangedEventArgs args)
		{
			throw null;
		}

		// Token: 0x06000495 RID: 1173 RVA: 0x00003C8C File Offset: 0x00001E8C
		[global::Cpp2ILInjected.Token(Token = "0x600050D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D90AA0", Offset = "0x1D90AA0", Length = "0x54")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		internal override void AfterEvent(XmlNodeChangedEventArgs args)
		{
			throw null;
		}

		// Token: 0x06000496 RID: 1174 RVA: 0x00003C8F File Offset: 0x00001E8F
		[global::Cpp2ILInjected.Token(Token = "0x600050E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D8CC14", Offset = "0x1D8CC14", Length = "0x27C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlAttributeCollection), Member = "RemoveNodeAt", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(XmlNode))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlDocument), Member = "GetSchemaElementDecl", MemberParameters = new object[] { typeof(XmlElement) }, ReturnType = typeof(SchemaElementDecl))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, object>), Member = "GetEnumerator", ReturnType = "Enumerator<TKey, TValue>")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlDocument), Member = "PrepareDefaultAttribute", MemberParameters = new object[]
		{
			typeof(SchemaAttDef),
			typeof(string),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(XmlAttribute))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
		internal XmlAttribute GetDefaultAttribute(XmlElement elem, string attrPrefix, string attrLocalname, string attrNamespaceURI)
		{
			throw null;
		}

		// Token: 0x06000497 RID: 1175 RVA: 0x00003C92 File Offset: 0x00001E92
		[global::Cpp2ILInjected.Token(Token = "0x600050F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D90AF4", Offset = "0x1D90AF4", Length = "0xC0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlEntityReference), Member = "get_ChildBaseURI", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlDocumentType), Member = "get_Entities", ReturnType = typeof(XmlNamedNodeMap))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		internal XmlEntity GetEntityNode(string name)
		{
			throw null;
		}

		// Token: 0x17000102 RID: 258
		// (get) Token: 0x06000498 RID: 1176 RVA: 0x00003C95 File Offset: 0x00001E95
		[global::Cpp2ILInjected.Token(Token = "0x17000123")]
		public override string BaseURI
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000510")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D90BB4", Offset = "0x1D90BB4", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06000499 RID: 1177 RVA: 0x00003C98 File Offset: 0x00001E98
		[global::Cpp2ILInjected.Token(Token = "0x6000511")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D90BBC", Offset = "0x1D90BBC", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		internal void SetBaseURI(string inBaseURI)
		{
			throw null;
		}

		// Token: 0x0600049A RID: 1178 RVA: 0x00003C9B File Offset: 0x00001E9B
		[global::Cpp2ILInjected.Token(Token = "0x6000512")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D90BC4", Offset = "0x1D90BC4", Length = "0x1C4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlDocument), Member = "GetInsertEventArgsForLoad", MemberParameters = new object[]
		{
			typeof(XmlNode),
			typeof(XmlNode)
		}, ReturnType = typeof(XmlNodeChangedEventArgs))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Res), Member = "GetString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		internal override XmlNode AppendChildForLoad(XmlNode newChild, XmlDocument doc)
		{
			throw null;
		}

		// Token: 0x0600049B RID: 1179 RVA: 0x00003C9E File Offset: 0x00001E9E
		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x6000513")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D90D88", Offset = "0x1D90D88", Length = "0xF8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(EmptyEnumerator), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlSchemaInfo), Member = ".ctor", MemberParameters = new object[] { typeof(XmlSchemaValidity) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		static XmlDocument()
		{
			throw null;
		}

		// Token: 0x0400019D RID: 413
		[global::Cpp2ILInjected.Token(Token = "0x4000297")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private XmlImplementation implementation;

		// Token: 0x0400019E RID: 414
		[global::Cpp2ILInjected.Token(Token = "0x4000298")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private DomNameTable domNameTable;

		// Token: 0x0400019F RID: 415
		[global::Cpp2ILInjected.Token(Token = "0x4000299")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private XmlLinkedNode lastChild;

		// Token: 0x040001A0 RID: 416
		[global::Cpp2ILInjected.Token(Token = "0x400029A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		private XmlNamedNodeMap entities;

		// Token: 0x040001A1 RID: 417
		[global::Cpp2ILInjected.Token(Token = "0x400029B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		private Hashtable htElementIdMap;

		// Token: 0x040001A2 RID: 418
		[global::Cpp2ILInjected.Token(Token = "0x400029C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
		private Hashtable htElementIDAttrDecl;

		// Token: 0x040001A3 RID: 419
		[global::Cpp2ILInjected.Token(Token = "0x400029D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
		private SchemaInfo schemaInfo;

		// Token: 0x040001A4 RID: 420
		[global::Cpp2ILInjected.Token(Token = "0x400029E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
		private XmlSchemaSet schemas;

		// Token: 0x040001A5 RID: 421
		[global::Cpp2ILInjected.Token(Token = "0x400029F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x58")]
		private bool reportValidity;

		// Token: 0x040001A6 RID: 422
		[global::Cpp2ILInjected.Token(Token = "0x40002A0")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x59")]
		private bool actualLoadingStatus;

		// Token: 0x040001A7 RID: 423
		[global::Cpp2ILInjected.Token(Token = "0x40002A1")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x60")]
		private XmlNodeChangedEventHandler onNodeInsertingDelegate;

		// Token: 0x040001A8 RID: 424
		[global::Cpp2ILInjected.Token(Token = "0x40002A2")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x68")]
		private XmlNodeChangedEventHandler onNodeInsertedDelegate;

		// Token: 0x040001A9 RID: 425
		[global::Cpp2ILInjected.Token(Token = "0x40002A3")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x70")]
		private XmlNodeChangedEventHandler onNodeRemovingDelegate;

		// Token: 0x040001AA RID: 426
		[global::Cpp2ILInjected.Token(Token = "0x40002A4")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x78")]
		private XmlNodeChangedEventHandler onNodeRemovedDelegate;

		// Token: 0x040001AB RID: 427
		[global::Cpp2ILInjected.Token(Token = "0x40002A5")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x80")]
		private XmlNodeChangedEventHandler onNodeChangingDelegate;

		// Token: 0x040001AC RID: 428
		[global::Cpp2ILInjected.Token(Token = "0x40002A6")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x88")]
		private XmlNodeChangedEventHandler onNodeChangedDelegate;

		// Token: 0x040001AD RID: 429
		[global::Cpp2ILInjected.Token(Token = "0x40002A7")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x90")]
		internal bool fEntRefNodesPresent;

		// Token: 0x040001AE RID: 430
		[global::Cpp2ILInjected.Token(Token = "0x40002A8")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x91")]
		internal bool fCDataNodesPresent;

		// Token: 0x040001AF RID: 431
		[global::Cpp2ILInjected.Token(Token = "0x40002A9")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x92")]
		private bool preserveWhitespace;

		// Token: 0x040001B0 RID: 432
		[global::Cpp2ILInjected.Token(Token = "0x40002AA")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x93")]
		private bool isLoading;

		// Token: 0x040001B1 RID: 433
		[global::Cpp2ILInjected.Token(Token = "0x40002AB")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x98")]
		internal string strDocumentName;

		// Token: 0x040001B2 RID: 434
		[global::Cpp2ILInjected.Token(Token = "0x40002AC")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xA0")]
		internal string strDocumentFragmentName;

		// Token: 0x040001B3 RID: 435
		[global::Cpp2ILInjected.Token(Token = "0x40002AD")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xA8")]
		internal string strCommentName;

		// Token: 0x040001B4 RID: 436
		[global::Cpp2ILInjected.Token(Token = "0x40002AE")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xB0")]
		internal string strTextName;

		// Token: 0x040001B5 RID: 437
		[global::Cpp2ILInjected.Token(Token = "0x40002AF")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xB8")]
		internal string strCDataSectionName;

		// Token: 0x040001B6 RID: 438
		[global::Cpp2ILInjected.Token(Token = "0x40002B0")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xC0")]
		internal string strEntityName;

		// Token: 0x040001B7 RID: 439
		[global::Cpp2ILInjected.Token(Token = "0x40002B1")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xC8")]
		internal string strID;

		// Token: 0x040001B8 RID: 440
		[global::Cpp2ILInjected.Token(Token = "0x40002B2")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xD0")]
		internal string strXmlns;

		// Token: 0x040001B9 RID: 441
		[global::Cpp2ILInjected.Token(Token = "0x40002B3")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xD8")]
		internal string strXml;

		// Token: 0x040001BA RID: 442
		[global::Cpp2ILInjected.Token(Token = "0x40002B4")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xE0")]
		internal string strSpace;

		// Token: 0x040001BB RID: 443
		[global::Cpp2ILInjected.Token(Token = "0x40002B5")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xE8")]
		internal string strLang;

		// Token: 0x040001BC RID: 444
		[global::Cpp2ILInjected.Token(Token = "0x40002B6")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xF0")]
		internal string strEmpty;

		// Token: 0x040001BD RID: 445
		[global::Cpp2ILInjected.Token(Token = "0x40002B7")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xF8")]
		internal string strNonSignificantWhitespaceName;

		// Token: 0x040001BE RID: 446
		[global::Cpp2ILInjected.Token(Token = "0x40002B8")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x100")]
		internal string strSignificantWhitespaceName;

		// Token: 0x040001BF RID: 447
		[global::Cpp2ILInjected.Token(Token = "0x40002B9")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x108")]
		internal string strReservedXmlns;

		// Token: 0x040001C0 RID: 448
		[global::Cpp2ILInjected.Token(Token = "0x40002BA")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x110")]
		internal string strReservedXml;

		// Token: 0x040001C1 RID: 449
		[global::Cpp2ILInjected.Token(Token = "0x40002BB")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x118")]
		internal string baseURI;

		// Token: 0x040001C2 RID: 450
		[global::Cpp2ILInjected.Token(Token = "0x40002BC")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x120")]
		private XmlResolver resolver;

		// Token: 0x040001C3 RID: 451
		[global::Cpp2ILInjected.Token(Token = "0x40002BD")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x128")]
		internal bool bSetResolver;

		// Token: 0x040001C4 RID: 452
		[global::Cpp2ILInjected.Token(Token = "0x40002BE")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x130")]
		internal object objLock;

		// Token: 0x040001C5 RID: 453
		[global::Cpp2ILInjected.Token(Token = "0x40002BF")]
		internal static EmptyEnumerator EmptyEnumerator;

		// Token: 0x040001C6 RID: 454
		[global::Cpp2ILInjected.Token(Token = "0x40002C0")]
		internal static IXmlSchemaInfo NotKnownSchemaInfo;

		// Token: 0x040001C7 RID: 455
		[global::Cpp2ILInjected.Token(Token = "0x40002C1")]
		internal static IXmlSchemaInfo ValidSchemaInfo;

		// Token: 0x040001C8 RID: 456
		[global::Cpp2ILInjected.Token(Token = "0x40002C2")]
		internal static IXmlSchemaInfo InvalidSchemaInfo;
	}
}
