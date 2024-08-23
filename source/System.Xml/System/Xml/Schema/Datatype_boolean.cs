using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Xml.Schema
{
	// Token: 0x020000B9 RID: 185
	[global::Cpp2ILInjected.Token(Token = "0x20000E5")]
	internal class Datatype_boolean : Datatype_anySimpleType
	{
		// Token: 0x0600081E RID: 2078 RVA: 0x000046B2 File Offset: 0x000028B2
		[global::Cpp2ILInjected.Token(Token = "0x60008B3")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DBE624", Offset = "0x1DBE624", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		internal override XmlValueConverter CreateValueConverter(XmlSchemaType schemaType)
		{
			throw null;
		}

		// Token: 0x17000204 RID: 516
		// (get) Token: 0x0600081F RID: 2079 RVA: 0x000046B5 File Offset: 0x000028B5
		[global::Cpp2ILInjected.Token(Token = "0x1700022A")]
		internal override FacetsChecker FacetsChecker
		{
			[global::Cpp2ILInjected.Token(Token = "0x60008B4")]
			[global::Cpp2ILInjected.Address(RVA = "0x1DBE684", Offset = "0x1DBE684", Length = "0x58")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000205 RID: 517
		// (get) Token: 0x06000820 RID: 2080 RVA: 0x000046B8 File Offset: 0x000028B8
		[global::Cpp2ILInjected.Token(Token = "0x1700022B")]
		public override XmlTypeCode TypeCode
		{
			[global::Cpp2ILInjected.Token(Token = "0x60008B5")]
			[global::Cpp2ILInjected.Address(RVA = "0x1DBE6DC", Offset = "0x1DBE6DC", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000206 RID: 518
		// (get) Token: 0x06000821 RID: 2081 RVA: 0x000046BB File Offset: 0x000028BB
		[global::Cpp2ILInjected.Token(Token = "0x1700022C")]
		public override Type ValueType
		{
			[global::Cpp2ILInjected.Token(Token = "0x60008B6")]
			[global::Cpp2ILInjected.Address(RVA = "0x1DBE6E4", Offset = "0x1DBE6E4", Length = "0x58")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000207 RID: 519
		// (get) Token: 0x06000822 RID: 2082 RVA: 0x000046BE File Offset: 0x000028BE
		[global::Cpp2ILInjected.Token(Token = "0x1700022D")]
		internal override Type ListValueType
		{
			[global::Cpp2ILInjected.Token(Token = "0x60008B7")]
			[global::Cpp2ILInjected.Address(RVA = "0x1DBE73C", Offset = "0x1DBE73C", Length = "0x58")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000208 RID: 520
		// (get) Token: 0x06000823 RID: 2083 RVA: 0x000046C1 File Offset: 0x000028C1
		[global::Cpp2ILInjected.Token(Token = "0x1700022E")]
		internal override XmlSchemaWhiteSpace BuiltInWhitespaceFacet
		{
			[global::Cpp2ILInjected.Token(Token = "0x60008B8")]
			[global::Cpp2ILInjected.Address(RVA = "0x1DBE794", Offset = "0x1DBE794", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06000824 RID: 2084 RVA: 0x000046C4 File Offset: 0x000028C4
		[global::Cpp2ILInjected.Token(Token = "0x60008B9")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DBE79C", Offset = "0x1DBE79C", Length = "0x8C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(bool), Member = "CompareTo", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		internal override int Compare(object value1, object value2)
		{
			throw null;
		}

		// Token: 0x06000825 RID: 2085 RVA: 0x000046C7 File Offset: 0x000028C7
		[global::Cpp2ILInjected.Token(Token = "0x60008BA")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DBE828", Offset = "0x1DBE828", Length = "0x100")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlConvert), Member = "TryToBoolean", MemberParameters = new object[]
		{
			typeof(string),
			typeof(ref bool)
		}, ReturnType = typeof(Exception))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		internal override Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out object typedValue)
		{
			throw null;
		}

		// Token: 0x06000826 RID: 2086 RVA: 0x000046CA File Offset: 0x000028CA
		[global::Cpp2ILInjected.Token(Token = "0x60008BB")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DBE928", Offset = "0x1DBE928", Length = "0x54")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DatatypeImplementation), Member = ".cctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Datatype_anySimpleType), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public Datatype_boolean()
		{
			throw null;
		}

		// Token: 0x06000827 RID: 2087 RVA: 0x000046CD File Offset: 0x000028CD
		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x60008BC")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DBE97C", Offset = "0x1DBE97C", Length = "0xBC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(RuntimeTypeHandle) }, ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		static Datatype_boolean()
		{
			throw null;
		}

		// Token: 0x04000359 RID: 857
		[global::Cpp2ILInjected.Token(Token = "0x40004D3")]
		private static readonly Type atomicValueType;

		// Token: 0x0400035A RID: 858
		[global::Cpp2ILInjected.Token(Token = "0x40004D4")]
		private static readonly Type listValueType;
	}
}
