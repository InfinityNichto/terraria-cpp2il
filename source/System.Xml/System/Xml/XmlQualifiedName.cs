﻿using System;
using System.Collections;
using System.Reflection;
using System.Xml.Schema;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Xml
{
	[global::Cpp2ILInjected.Token(Token = "0x20000AD")]
	[Serializable]
	public class XmlQualifiedName
	{
		[global::Cpp2ILInjected.Token(Token = "0x60007A2")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DB060C", Offset = "0x1DB060C", Length = "0x54")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(QueryOutputWriter), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(XmlRawWriter),
			typeof(XmlWriterSettings)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public XmlQualifiedName()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60007A3")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DB06E4", Offset = "0x1DB06E4", Length = "0x60")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlTextReaderImpl), Member = "HandleGeneralEntityReference", MemberParameters = new object[]
		{
			typeof(string),
			typeof(bool),
			typeof(bool),
			typeof(int)
		}, ReturnType = "System.Xml.XmlTextReaderImpl.EntityType")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DtdParser), Member = "InitializeFreeFloatingDtd", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(string),
			typeof(string),
			typeof(string),
			typeof(IDtdParserAdapter)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DtdParser), Member = "GetNameQualified", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(XmlQualifiedName))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlQualifiedName), Member = ".cctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SchemaInfo), Member = "System.Xml.IDtdInfo.LookupEntity", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(IDtdEntityInfo))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 6)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlQualifiedName), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public XmlQualifiedName(string name)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60007A4")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DB0660", Offset = "0x1DB0660", Length = "0x84")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlDocument), Member = "GetSchemaElementDecl", MemberParameters = new object[] { typeof(XmlElement) }, ReturnType = typeof(SchemaElementDecl))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DtdParser), Member = "InitializeFreeFloatingDtd", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(string),
			typeof(string),
			typeof(string),
			typeof(IDtdParserAdapter)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DtdParser), Member = "GetNameQualified", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(XmlQualifiedName))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlQualifiedName), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlQualifiedName), Member = "Parse", MemberParameters = new object[]
		{
			typeof(string),
			typeof(IXmlNamespaceResolver),
			typeof(ref string)
		}, ReturnType = typeof(XmlQualifiedName))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DatatypeImplementation), Member = ".cctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DatatypeImplementation), Member = "CreateBuiltinTypes", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SchemaElementDecl), Member = "System.Xml.IDtdAttributeListInfo.LookupAttribute", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(IDtdAttributeInfo))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SchemaInfo), Member = "System.Xml.IDtdInfo.LookupAttributeList", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(IDtdAttributeListInfo))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlSchemaComplexType), Member = ".cctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlBaseConverter), Member = "StringToQName", MemberParameters = new object[]
		{
			typeof(string),
			typeof(IXmlNamespaceResolver)
		}, ReturnType = typeof(XmlQualifiedName))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 19)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public XmlQualifiedName(string name, string ns)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x170001CE")]
		public string Namespace
		{
			[global::Cpp2ILInjected.Token(Token = "0x60007A5")]
			[global::Cpp2ILInjected.Address(RVA = "0x1DB0744", Offset = "0x1DB0744", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x170001CF")]
		public string Name
		{
			[global::Cpp2ILInjected.Token(Token = "0x60007A6")]
			[global::Cpp2ILInjected.Address(RVA = "0x1DB074C", Offset = "0x1DB074C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x60007A7")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DB0754", Offset = "0x1DB0754", Length = "0xC0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlQualifiedName), Member = "GetHashCodeDelegate", ReturnType = typeof(XmlQualifiedName.HashCodeOfStringDelegate))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public override int GetHashCode()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x170001D0")]
		public bool IsEmpty
		{
			[global::Cpp2ILInjected.Token(Token = "0x60007A8")]
			[global::Cpp2ILInjected.Address(RVA = "0x1DB0984", Offset = "0x1DB0984", Length = "0x28")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlLoader), Member = "LoadDocumentType", MemberParameters = new object[]
			{
				typeof(IDtdInfo),
				typeof(XmlDocumentType)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DtdParser), Member = "VerifyEntityReference", MemberParameters = new object[]
			{
				typeof(XmlQualifiedName),
				typeof(bool),
				typeof(bool),
				typeof(bool)
			}, ReturnType = typeof(SchemaEntity))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SchemaEntity), Member = "System.Xml.IDtdEntityInfo.get_IsUnparsedEntity", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlBaseConverter), Member = "get_XmlTypeName", ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 6)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x60007A9")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DB09AC", Offset = "0x1DB09AC", Length = "0x64")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public override string ToString()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60007AA")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DB0A10", Offset = "0x1DB0A10", Length = "0xD8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlQualifiedName), Member = "op_Inequality", MemberParameters = new object[]
		{
			typeof(XmlQualifiedName),
			typeof(XmlQualifiedName)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public override bool Equals(object other)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60007AB")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DB0B58", Offset = "0x1DB0B58", Length = "0x68")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlQualifiedName), Member = "op_Inequality", MemberParameters = new object[]
		{
			typeof(XmlQualifiedName),
			typeof(XmlQualifiedName)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlSchemaSimpleTypeRestriction), Member = "set_BaseTypeName", MemberParameters = new object[] { typeof(XmlQualifiedName) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(bool))]
		public static bool operator ==(XmlQualifiedName a, XmlQualifiedName b)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60007AC")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DB0AE8", Offset = "0x1DB0AE8", Length = "0x70")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlQualifiedName), Member = "Equals", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SymbolsDictionary), Member = "GetNamespaceListSymbols", MemberParameters = new object[] { typeof(NamespaceList) }, ReturnType = typeof(ICollection))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlQualifiedName), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(XmlQualifiedName),
			typeof(XmlQualifiedName)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static bool operator !=(XmlQualifiedName a, XmlQualifiedName b)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60007AD")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DB0814", Offset = "0x1DB0814", Length = "0x170")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlQualifiedName), Member = "GetHashCode", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(RuntimeTypeHandle) }, ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "GetMethod", MemberParameters = new object[]
		{
			typeof(string),
			typeof(BindingFlags)
		}, ReturnType = typeof(MethodInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MethodInfo), Member = "op_Inequality", MemberParameters = new object[]
		{
			typeof(MethodInfo),
			typeof(MethodInfo)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Delegate), Member = "CreateDelegate", MemberParameters = new object[]
		{
			typeof(Type),
			typeof(MethodInfo)
		}, ReturnType = typeof(Delegate))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlQualifiedName.HashCodeOfStringDelegate), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 12)]
		private static XmlQualifiedName.HashCodeOfStringDelegate GetHashCodeDelegate()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60007AE")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DB0BC0", Offset = "0x1DB0BC0", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private static bool IsRandomizedHashingDisabled()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60007AF")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DB0CA0", Offset = "0x1DB0CA0", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		private static int GetHashCodeOfString(string s, int length, long additionalEntropy)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60007B0")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DB0CAC", Offset = "0x1DB0CAC", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(QueryOutputWriter), Member = "WriteStartElement", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		internal void Init(string name, string ns)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60007B1")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DB0CB8", Offset = "0x1DB0CB8", Length = "0x1A0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Datatype_QName), Member = "TryParseValue", MemberParameters = new object[]
		{
			typeof(string),
			typeof(XmlNameTable),
			typeof(IXmlNamespaceResolver),
			typeof(ref object)
		}, ReturnType = typeof(Exception))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Datatype_NOTATION), Member = "TryParseValue", MemberParameters = new object[]
		{
			typeof(string),
			typeof(XmlNameTable),
			typeof(IXmlNamespaceResolver),
			typeof(ref object)
		}, ReturnType = typeof(Exception))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Datatype_QNameXdr), Member = "ParseValue", MemberParameters = new object[]
		{
			typeof(string),
			typeof(XmlNameTable),
			typeof(IXmlNamespaceResolver)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ValidateNames), Member = "ParseQNameThrow", MemberParameters = new object[]
		{
			typeof(string),
			typeof(ref string),
			typeof(ref string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlQualifiedName), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 12)]
		internal static XmlQualifiedName Parse(string s, IXmlNamespaceResolver nsmgr, out string prefix)
		{
			throw null;
		}

		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x60007B2")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DB0E58", Offset = "0x1DB0E58", Length = "0x88")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlQualifiedName), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		static XmlQualifiedName()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x40003E1")]
		private static XmlQualifiedName.HashCodeOfStringDelegate hashCodeDelegate;

		[global::Cpp2ILInjected.Token(Token = "0x40003E2")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private string name;

		[global::Cpp2ILInjected.Token(Token = "0x40003E3")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private string ns;

		[global::Cpp2ILInjected.Token(Token = "0x40003E4")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		[NonSerialized]
		private int hash;

		[global::Cpp2ILInjected.Token(Token = "0x40003E5")]
		public static readonly XmlQualifiedName Empty;

		[global::Cpp2ILInjected.Token(Token = "0x20000AE")]
		private delegate int HashCodeOfStringDelegate(string s, int sLen, long additionalEntropy);
	}
}
