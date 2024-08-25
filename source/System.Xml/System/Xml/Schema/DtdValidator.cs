using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Xml.Schema
{
	[global::Cpp2ILInjected.Token(Token = "0x200011D")]
	internal sealed class DtdValidator : BaseValidator
	{
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

		[global::Cpp2ILInjected.Token(Token = "0x400050D")]
		private static DtdValidator.NamespaceManager namespaceManager;

		[global::Cpp2ILInjected.Token(Token = "0x200011E")]
		private class NamespaceManager : XmlNamespaceManager
		{
			[global::Cpp2ILInjected.Token(Token = "0x60009C9")]
			[global::Cpp2ILInjected.Address(RVA = "0x1DC6FE0", Offset = "0x1DC6FE0", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public override string LookupNamespace(string prefix)
			{
				throw null;
			}

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
