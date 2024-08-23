using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Xml.Schema
{
	// Token: 0x020000D0 RID: 208
	[global::Cpp2ILInjected.Token(Token = "0x20000FC")]
	internal class Datatype_QName : Datatype_anySimpleType
	{
		// Token: 0x06000891 RID: 2193 RVA: 0x0000480B File Offset: 0x00002A0B
		[global::Cpp2ILInjected.Token(Token = "0x6000926")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DC1B88", Offset = "0x1DC1B88", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlMiscConverter), Member = "Create", MemberParameters = new object[] { typeof(XmlSchemaType) }, ReturnType = typeof(XmlValueConverter))]
		internal override XmlValueConverter CreateValueConverter(XmlSchemaType schemaType)
		{
			throw null;
		}

		// Token: 0x1700023A RID: 570
		// (get) Token: 0x06000892 RID: 2194 RVA: 0x0000480E File Offset: 0x00002A0E
		[global::Cpp2ILInjected.Token(Token = "0x17000260")]
		internal override FacetsChecker FacetsChecker
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000927")]
			[global::Cpp2ILInjected.Address(RVA = "0x1DC1B94", Offset = "0x1DC1B94", Length = "0x58")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700023B RID: 571
		// (get) Token: 0x06000893 RID: 2195 RVA: 0x00004811 File Offset: 0x00002A11
		[global::Cpp2ILInjected.Token(Token = "0x17000261")]
		public override XmlTypeCode TypeCode
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000928")]
			[global::Cpp2ILInjected.Address(RVA = "0x1DC1BEC", Offset = "0x1DC1BEC", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700023C RID: 572
		// (get) Token: 0x06000894 RID: 2196 RVA: 0x00004814 File Offset: 0x00002A14
		[global::Cpp2ILInjected.Token(Token = "0x17000262")]
		public override XmlTokenizedType TokenizedType
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000929")]
			[global::Cpp2ILInjected.Address(RVA = "0x1DC1BF4", Offset = "0x1DC1BF4", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700023D RID: 573
		// (get) Token: 0x06000895 RID: 2197 RVA: 0x00004817 File Offset: 0x00002A17
		[global::Cpp2ILInjected.Token(Token = "0x17000263")]
		public override Type ValueType
		{
			[global::Cpp2ILInjected.Token(Token = "0x600092A")]
			[global::Cpp2ILInjected.Address(RVA = "0x1DC1BFC", Offset = "0x1DC1BFC", Length = "0x58")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700023E RID: 574
		// (get) Token: 0x06000896 RID: 2198 RVA: 0x0000481A File Offset: 0x00002A1A
		[global::Cpp2ILInjected.Token(Token = "0x17000264")]
		internal override Type ListValueType
		{
			[global::Cpp2ILInjected.Token(Token = "0x600092B")]
			[global::Cpp2ILInjected.Address(RVA = "0x1DC1C54", Offset = "0x1DC1C54", Length = "0x58")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700023F RID: 575
		// (get) Token: 0x06000897 RID: 2199 RVA: 0x0000481D File Offset: 0x00002A1D
		[global::Cpp2ILInjected.Token(Token = "0x17000265")]
		internal override XmlSchemaWhiteSpace BuiltInWhitespaceFacet
		{
			[global::Cpp2ILInjected.Token(Token = "0x600092C")]
			[global::Cpp2ILInjected.Address(RVA = "0x1DC1CAC", Offset = "0x1DC1CAC", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06000898 RID: 2200 RVA: 0x00004820 File Offset: 0x00002A20
		[global::Cpp2ILInjected.Token(Token = "0x600092D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DC1CB4", Offset = "0x1DC1CB4", Length = "0x228")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlQualifiedName), Member = "Parse", MemberParameters = new object[]
		{
			typeof(string),
			typeof(IXmlNamespaceResolver),
			typeof(ref string)
		}, ReturnType = typeof(XmlQualifiedName))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlSchemaException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 20)]
		internal override Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out object typedValue)
		{
			throw null;
		}

		// Token: 0x06000899 RID: 2201 RVA: 0x00004823 File Offset: 0x00002A23
		[global::Cpp2ILInjected.Token(Token = "0x600092E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DC1EDC", Offset = "0x1DC1EDC", Length = "0x54")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DatatypeImplementation), Member = ".cctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Datatype_anySimpleType), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public Datatype_QName()
		{
			throw null;
		}

		// Token: 0x0600089A RID: 2202 RVA: 0x00004826 File Offset: 0x00002A26
		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x600092F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DC1F30", Offset = "0x1DC1F30", Length = "0xBC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(RuntimeTypeHandle) }, ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		static Datatype_QName()
		{
			throw null;
		}

		// Token: 0x0400036D RID: 877
		[global::Cpp2ILInjected.Token(Token = "0x40004E7")]
		private static readonly Type atomicValueType;

		// Token: 0x0400036E RID: 878
		[global::Cpp2ILInjected.Token(Token = "0x40004E8")]
		private static readonly Type listValueType;
	}
}
