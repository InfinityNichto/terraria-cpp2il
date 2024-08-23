using System;
using System.Collections;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Xml.Schema
{
	// Token: 0x0200011D RID: 285
	[global::Cpp2ILInjected.Token(Token = "0x2000151")]
	public class XmlSchemaSet
	{
		// Token: 0x06000A69 RID: 2665 RVA: 0x00004D57 File Offset: 0x00002F57
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

		// Token: 0x06000A6A RID: 2666 RVA: 0x00004D5A File Offset: 0x00002F5A
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

		// Token: 0x06000A6B RID: 2667 RVA: 0x00004D5D File Offset: 0x00002F5D
		[global::Cpp2ILInjected.Token(Token = "0x6000B06")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DCF038", Offset = "0x1DCF038", Length = "0x30")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private void InternalValidationCallback(object sender, ValidationEventArgs e)
		{
			throw null;
		}

		// Token: 0x04000417 RID: 1047
		[global::Cpp2ILInjected.Token(Token = "0x40005AA")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private XmlNameTable nameTable;

		// Token: 0x04000418 RID: 1048
		[global::Cpp2ILInjected.Token(Token = "0x40005AB")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private SortedList schemas;

		// Token: 0x04000419 RID: 1049
		[global::Cpp2ILInjected.Token(Token = "0x40005AC")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private ValidationEventHandler internalEventHandler;

		// Token: 0x0400041A RID: 1050
		[global::Cpp2ILInjected.Token(Token = "0x40005AD")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private ValidationEventHandler eventHandler;

		// Token: 0x0400041B RID: 1051
		[global::Cpp2ILInjected.Token(Token = "0x40005AE")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		private Hashtable schemaLocations;

		// Token: 0x0400041C RID: 1052
		[global::Cpp2ILInjected.Token(Token = "0x40005AF")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		private Hashtable chameleonSchemas;

		// Token: 0x0400041D RID: 1053
		[global::Cpp2ILInjected.Token(Token = "0x40005B0")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
		private Hashtable targetNamespaces;

		// Token: 0x0400041E RID: 1054
		[global::Cpp2ILInjected.Token(Token = "0x40005B1")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
		private bool compileAll;

		// Token: 0x0400041F RID: 1055
		[global::Cpp2ILInjected.Token(Token = "0x40005B2")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
		private SchemaInfo cachedCompiledInfo;

		// Token: 0x04000420 RID: 1056
		[global::Cpp2ILInjected.Token(Token = "0x40005B3")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x58")]
		private XmlReaderSettings readerSettings;

		// Token: 0x04000421 RID: 1057
		[global::Cpp2ILInjected.Token(Token = "0x40005B4")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x60")]
		private XmlSchemaCompilationSettings compilationSettings;
	}
}
