using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Xml.Schema
{
	// Token: 0x020000BC RID: 188
	[global::Cpp2ILInjected.Token(Token = "0x20000E8")]
	internal class Datatype_decimal : Datatype_anySimpleType
	{
		// Token: 0x0600083C RID: 2108 RVA: 0x0000470C File Offset: 0x0000290C
		[global::Cpp2ILInjected.Token(Token = "0x60008D1")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DBF270", Offset = "0x1DBF270", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		internal override XmlValueConverter CreateValueConverter(XmlSchemaType schemaType)
		{
			throw null;
		}

		// Token: 0x17000213 RID: 531
		// (get) Token: 0x0600083D RID: 2109 RVA: 0x0000470F File Offset: 0x0000290F
		[global::Cpp2ILInjected.Token(Token = "0x17000239")]
		internal override FacetsChecker FacetsChecker
		{
			[global::Cpp2ILInjected.Token(Token = "0x60008D2")]
			[global::Cpp2ILInjected.Address(RVA = "0x1DBF2D0", Offset = "0x1DBF2D0", Length = "0x58")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000214 RID: 532
		// (get) Token: 0x0600083E RID: 2110 RVA: 0x00004712 File Offset: 0x00002912
		[global::Cpp2ILInjected.Token(Token = "0x1700023A")]
		public override XmlTypeCode TypeCode
		{
			[global::Cpp2ILInjected.Token(Token = "0x60008D3")]
			[global::Cpp2ILInjected.Address(RVA = "0x1DBF328", Offset = "0x1DBF328", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000215 RID: 533
		// (get) Token: 0x0600083F RID: 2111 RVA: 0x00004715 File Offset: 0x00002915
		[global::Cpp2ILInjected.Token(Token = "0x1700023B")]
		public override Type ValueType
		{
			[global::Cpp2ILInjected.Token(Token = "0x60008D4")]
			[global::Cpp2ILInjected.Address(RVA = "0x1DBF330", Offset = "0x1DBF330", Length = "0x58")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000216 RID: 534
		// (get) Token: 0x06000840 RID: 2112 RVA: 0x00004718 File Offset: 0x00002918
		[global::Cpp2ILInjected.Token(Token = "0x1700023C")]
		internal override Type ListValueType
		{
			[global::Cpp2ILInjected.Token(Token = "0x60008D5")]
			[global::Cpp2ILInjected.Address(RVA = "0x1DBF388", Offset = "0x1DBF388", Length = "0x58")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000217 RID: 535
		// (get) Token: 0x06000841 RID: 2113 RVA: 0x0000471B File Offset: 0x0000291B
		[global::Cpp2ILInjected.Token(Token = "0x1700023D")]
		internal override XmlSchemaWhiteSpace BuiltInWhitespaceFacet
		{
			[global::Cpp2ILInjected.Token(Token = "0x60008D6")]
			[global::Cpp2ILInjected.Address(RVA = "0x1DBF3E0", Offset = "0x1DBF3E0", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06000842 RID: 2114 RVA: 0x0000471E File Offset: 0x0000291E
		[global::Cpp2ILInjected.Token(Token = "0x60008D7")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DBF3E8", Offset = "0x1DBF3E8", Length = "0xB4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(decimal), Member = "CompareTo", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		internal override int Compare(object value1, object value2)
		{
			throw null;
		}

		// Token: 0x06000843 RID: 2115 RVA: 0x00004721 File Offset: 0x00002921
		[global::Cpp2ILInjected.Token(Token = "0x60008D8")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DBF49C", Offset = "0x1DBF49C", Length = "0x158")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlConvert), Member = "TryToDecimal", MemberParameters = new object[]
		{
			typeof(string),
			typeof(ref decimal)
		}, ReturnType = typeof(Exception))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		internal override Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out object typedValue)
		{
			throw null;
		}

		// Token: 0x06000844 RID: 2116 RVA: 0x00004724 File Offset: 0x00002924
		[global::Cpp2ILInjected.Token(Token = "0x60008D9")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DBF5F4", Offset = "0x1DBF5F4", Length = "0x54")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DatatypeImplementation), Member = ".cctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Datatype_integer), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Datatype_fixed), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Datatype_anySimpleType), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public Datatype_decimal()
		{
			throw null;
		}

		// Token: 0x06000845 RID: 2117 RVA: 0x00004727 File Offset: 0x00002927
		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x60008DA")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DBF648", Offset = "0x1DBF648", Length = "0x180")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(RuntimeTypeHandle) }, ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(decimal), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(bool),
			typeof(byte)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		static Datatype_decimal()
		{
			throw null;
		}

		// Token: 0x0400035F RID: 863
		[global::Cpp2ILInjected.Token(Token = "0x40004D9")]
		private static readonly Type atomicValueType;

		// Token: 0x04000360 RID: 864
		[global::Cpp2ILInjected.Token(Token = "0x40004DA")]
		private static readonly Type listValueType;

		// Token: 0x04000361 RID: 865
		[global::Cpp2ILInjected.Token(Token = "0x40004DB")]
		private static readonly FacetsChecker numeric10FacetsChecker;
	}
}
