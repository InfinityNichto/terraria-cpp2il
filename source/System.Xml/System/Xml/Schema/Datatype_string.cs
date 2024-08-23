using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Xml.Schema
{
	// Token: 0x020000B8 RID: 184
	[global::Cpp2ILInjected.Token(Token = "0x20000E4")]
	internal class Datatype_string : Datatype_anySimpleType
	{
		// Token: 0x06000817 RID: 2071 RVA: 0x0000469D File Offset: 0x0000289D
		[global::Cpp2ILInjected.Token(Token = "0x60008AC")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DBE48C", Offset = "0x1DBE48C", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlStringConverter), Member = "Create", MemberParameters = new object[] { typeof(XmlSchemaType) }, ReturnType = typeof(XmlValueConverter))]
		internal override XmlValueConverter CreateValueConverter(XmlSchemaType schemaType)
		{
			throw null;
		}

		// Token: 0x17000200 RID: 512
		// (get) Token: 0x06000818 RID: 2072 RVA: 0x000046A0 File Offset: 0x000028A0
		[global::Cpp2ILInjected.Token(Token = "0x17000226")]
		internal override XmlSchemaWhiteSpace BuiltInWhitespaceFacet
		{
			[global::Cpp2ILInjected.Token(Token = "0x60008AD")]
			[global::Cpp2ILInjected.Address(RVA = "0x1DBE498", Offset = "0x1DBE498", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000201 RID: 513
		// (get) Token: 0x06000819 RID: 2073 RVA: 0x000046A3 File Offset: 0x000028A3
		[global::Cpp2ILInjected.Token(Token = "0x17000227")]
		internal override FacetsChecker FacetsChecker
		{
			[global::Cpp2ILInjected.Token(Token = "0x60008AE")]
			[global::Cpp2ILInjected.Address(RVA = "0x1DBE4A0", Offset = "0x1DBE4A0", Length = "0x58")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000202 RID: 514
		// (get) Token: 0x0600081A RID: 2074 RVA: 0x000046A6 File Offset: 0x000028A6
		[global::Cpp2ILInjected.Token(Token = "0x17000228")]
		public override XmlTypeCode TypeCode
		{
			[global::Cpp2ILInjected.Token(Token = "0x60008AF")]
			[global::Cpp2ILInjected.Address(RVA = "0x1DBE4F8", Offset = "0x1DBE4F8", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000203 RID: 515
		// (get) Token: 0x0600081B RID: 2075 RVA: 0x000046A9 File Offset: 0x000028A9
		[global::Cpp2ILInjected.Token(Token = "0x17000229")]
		public override XmlTokenizedType TokenizedType
		{
			[global::Cpp2ILInjected.Token(Token = "0x60008B0")]
			[global::Cpp2ILInjected.Address(RVA = "0x1DBE500", Offset = "0x1DBE500", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0600081C RID: 2076 RVA: 0x000046AC File Offset: 0x000028AC
		[global::Cpp2ILInjected.Token(Token = "0x60008B1")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DBE508", Offset = "0x1DBE508", Length = "0xC8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		internal override Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out object typedValue)
		{
			throw null;
		}

		// Token: 0x0600081D RID: 2077 RVA: 0x000046AF File Offset: 0x000028AF
		[global::Cpp2ILInjected.Token(Token = "0x60008B2")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DBE5D0", Offset = "0x1DBE5D0", Length = "0x54")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DatatypeImplementation), Member = ".cctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Datatype_normalizedString), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Datatype_normalizedStringV1Compat), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Datatype_token), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Datatype_tokenV1Compat), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Datatype_language), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Datatype_NMTOKEN), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Datatype_Name), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Datatype_NCName), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Datatype_ID), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Datatype_IDREF), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Datatype_ENTITY), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Datatype_ENUMERATION), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 13)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Datatype_anySimpleType), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public Datatype_string()
		{
			throw null;
		}
	}
}
