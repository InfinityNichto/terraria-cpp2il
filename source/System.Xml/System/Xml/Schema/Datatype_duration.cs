using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Xml.Schema
{
	// Token: 0x020000BD RID: 189
	[global::Cpp2ILInjected.Token(Token = "0x20000E9")]
	internal class Datatype_duration : Datatype_anySimpleType
	{
		// Token: 0x06000846 RID: 2118 RVA: 0x0000472A File Offset: 0x0000292A
		[global::Cpp2ILInjected.Token(Token = "0x60008DB")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DBF808", Offset = "0x1DBF808", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlMiscConverter), Member = "Create", MemberParameters = new object[] { typeof(XmlSchemaType) }, ReturnType = typeof(XmlValueConverter))]
		internal override XmlValueConverter CreateValueConverter(XmlSchemaType schemaType)
		{
			throw null;
		}

		// Token: 0x17000218 RID: 536
		// (get) Token: 0x06000847 RID: 2119 RVA: 0x0000472D File Offset: 0x0000292D
		[global::Cpp2ILInjected.Token(Token = "0x1700023E")]
		internal override FacetsChecker FacetsChecker
		{
			[global::Cpp2ILInjected.Token(Token = "0x60008DC")]
			[global::Cpp2ILInjected.Address(RVA = "0x1DBF814", Offset = "0x1DBF814", Length = "0x58")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000219 RID: 537
		// (get) Token: 0x06000848 RID: 2120 RVA: 0x00004730 File Offset: 0x00002930
		[global::Cpp2ILInjected.Token(Token = "0x1700023F")]
		public override XmlTypeCode TypeCode
		{
			[global::Cpp2ILInjected.Token(Token = "0x60008DD")]
			[global::Cpp2ILInjected.Address(RVA = "0x1DBF86C", Offset = "0x1DBF86C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700021A RID: 538
		// (get) Token: 0x06000849 RID: 2121 RVA: 0x00004733 File Offset: 0x00002933
		[global::Cpp2ILInjected.Token(Token = "0x17000240")]
		public override Type ValueType
		{
			[global::Cpp2ILInjected.Token(Token = "0x60008DE")]
			[global::Cpp2ILInjected.Address(RVA = "0x1DBF874", Offset = "0x1DBF874", Length = "0x58")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700021B RID: 539
		// (get) Token: 0x0600084A RID: 2122 RVA: 0x00004736 File Offset: 0x00002936
		[global::Cpp2ILInjected.Token(Token = "0x17000241")]
		internal override Type ListValueType
		{
			[global::Cpp2ILInjected.Token(Token = "0x60008DF")]
			[global::Cpp2ILInjected.Address(RVA = "0x1DBF8CC", Offset = "0x1DBF8CC", Length = "0x58")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700021C RID: 540
		// (get) Token: 0x0600084B RID: 2123 RVA: 0x00004739 File Offset: 0x00002939
		[global::Cpp2ILInjected.Token(Token = "0x17000242")]
		internal override XmlSchemaWhiteSpace BuiltInWhitespaceFacet
		{
			[global::Cpp2ILInjected.Token(Token = "0x60008E0")]
			[global::Cpp2ILInjected.Address(RVA = "0x1DBF924", Offset = "0x1DBF924", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0600084C RID: 2124 RVA: 0x0000473C File Offset: 0x0000293C
		[global::Cpp2ILInjected.Token(Token = "0x60008E1")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DBF92C", Offset = "0x1DBF92C", Length = "0x8C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TimeSpan), Member = "CompareTo", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		internal override int Compare(object value1, object value2)
		{
			throw null;
		}

		// Token: 0x0600084D RID: 2125 RVA: 0x0000473F File Offset: 0x0000293F
		[global::Cpp2ILInjected.Token(Token = "0x60008E2")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DBF9B8", Offset = "0x1DBF9B8", Length = "0x1B4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlConvert), Member = "TryToTimeSpan", MemberParameters = new object[]
		{
			typeof(string),
			typeof(ref TimeSpan)
		}, ReturnType = typeof(Exception))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlSchemaException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 11)]
		internal override Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out object typedValue)
		{
			throw null;
		}

		// Token: 0x0600084E RID: 2126 RVA: 0x00004742 File Offset: 0x00002942
		[global::Cpp2ILInjected.Token(Token = "0x60008E3")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DBFC2C", Offset = "0x1DBFC2C", Length = "0x54")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DatatypeImplementation), Member = ".cctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Datatype_yearMonthDuration), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Datatype_dayTimeDuration), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Datatype_anySimpleType), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public Datatype_duration()
		{
			throw null;
		}

		// Token: 0x0600084F RID: 2127 RVA: 0x00004745 File Offset: 0x00002945
		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x60008E4")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DBFC80", Offset = "0x1DBFC80", Length = "0xBC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(RuntimeTypeHandle) }, ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		static Datatype_duration()
		{
			throw null;
		}

		// Token: 0x04000362 RID: 866
		[global::Cpp2ILInjected.Token(Token = "0x40004DC")]
		private static readonly Type atomicValueType;

		// Token: 0x04000363 RID: 867
		[global::Cpp2ILInjected.Token(Token = "0x40004DD")]
		private static readonly Type listValueType;
	}
}
