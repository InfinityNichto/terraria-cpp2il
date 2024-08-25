using System;
using System.Collections;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Xml.Schema
{
	[global::Cpp2ILInjected.Token(Token = "0x2000151")]
	public class XmlSchemaSet
	{
		[global::Cpp2ILInjected.Token(Token = "0x6000B04")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DCED78", Offset = "0x1DCED78", Length = "0x5C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlReaderSettings), Member = "get_Schemas", ReturnType = typeof(XmlSchemaSet))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NameTable), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public XmlSchemaSet()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000B05")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DCEDD4", Offset = "0x1DCEDD4", Length = "0x264")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SortedList), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Hashtable), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ValidationEventHandler), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlReaderSettings), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlUrlResolver), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlReaderSettings), Member = "set_XmlResolver", MemberParameters = new object[] { typeof(XmlResolver) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlReaderSettings), Member = "set_NameTable", MemberParameters = new object[] { typeof(XmlNameTable) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlReaderSettings), Member = "set_DtdProcessing", MemberParameters = new object[] { typeof(DtdProcessing) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SchemaInfo), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 22)]
		public XmlSchemaSet(XmlNameTable nameTable)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000B06")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DCF038", Offset = "0x1DCF038", Length = "0x30")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private void InternalValidationCallback(object sender, ValidationEventArgs e)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x40005AA")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private XmlNameTable nameTable;

		[global::Cpp2ILInjected.Token(Token = "0x40005AB")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private SortedList schemas;

		[global::Cpp2ILInjected.Token(Token = "0x40005AC")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private ValidationEventHandler internalEventHandler;

		[global::Cpp2ILInjected.Token(Token = "0x40005AD")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private ValidationEventHandler eventHandler;

		[global::Cpp2ILInjected.Token(Token = "0x40005AE")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		private Hashtable schemaLocations;

		[global::Cpp2ILInjected.Token(Token = "0x40005AF")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		private Hashtable chameleonSchemas;

		[global::Cpp2ILInjected.Token(Token = "0x40005B0")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
		private Hashtable targetNamespaces;

		[global::Cpp2ILInjected.Token(Token = "0x40005B1")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
		private bool compileAll;

		[global::Cpp2ILInjected.Token(Token = "0x40005B2")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
		private SchemaInfo cachedCompiledInfo;

		[global::Cpp2ILInjected.Token(Token = "0x40005B3")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x58")]
		private XmlReaderSettings readerSettings;

		[global::Cpp2ILInjected.Token(Token = "0x40005B4")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x60")]
		private XmlSchemaCompilationSettings compilationSettings;
	}
}
