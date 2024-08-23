using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Xml.Schema
{
	// Token: 0x020000F1 RID: 241
	[global::Cpp2ILInjected.Token(Token = "0x200011D")]
	internal sealed class DtdValidator : BaseValidator
	{
		// Token: 0x06000932 RID: 2354 RVA: 0x000049EE File Offset: 0x00002BEE
		[global::Cpp2ILInjected.Token(Token = "0x60009C7")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DC6B6C", Offset = "0x1DC6B6C", Length = "0x3A8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DtdParser), Member = "ParseAttlistDefault", MemberParameters = new object[]
		{
			typeof(SchemaAttDef),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Trim", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlSchemaException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 27)]
		public static void SetDefaultTypedValue(SchemaAttDef attdef, IDtdParserAdapter readerAdapter)
		{
			throw null;
		}

		// Token: 0x06000933 RID: 2355 RVA: 0x000049F1 File Offset: 0x00002BF1
		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x60009C8")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DC6F68", Offset = "0x1DC6F68", Length = "0x70")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlNamespaceManager), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		static DtdValidator()
		{
			throw null;
		}

		// Token: 0x04000393 RID: 915
		[global::Cpp2ILInjected.Token(Token = "0x400050D")]
		private static DtdValidator.NamespaceManager namespaceManager;

		// Token: 0x02000172 RID: 370
		[global::Cpp2ILInjected.Token(Token = "0x200011E")]
		private class NamespaceManager : XmlNamespaceManager
		{
			// Token: 0x06000CC8 RID: 3272 RVA: 0x000053B4 File Offset: 0x000035B4
			[global::Cpp2ILInjected.Token(Token = "0x60009C9")]
			[global::Cpp2ILInjected.Address(RVA = "0x1DC6FE0", Offset = "0x1DC6FE0", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public override string LookupNamespace(string prefix)
			{
				throw null;
			}

			// Token: 0x06000CC9 RID: 3273 RVA: 0x000053B7 File Offset: 0x000035B7
			[global::Cpp2ILInjected.Token(Token = "0x60009CA")]
			[global::Cpp2ILInjected.Address(RVA = "0x1DC6FD8", Offset = "0x1DC6FD8", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlNamespaceManager), Member = ".ctor", ReturnType = typeof(void))]
			public NamespaceManager()
			{
				throw null;
			}
		}
	}
}
