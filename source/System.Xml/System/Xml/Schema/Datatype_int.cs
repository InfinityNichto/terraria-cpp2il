using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Xml.Schema
{
	// Token: 0x020000E1 RID: 225
	[global::Cpp2ILInjected.Token(Token = "0x200010D")]
	internal class Datatype_int : Datatype_long
	{
		// Token: 0x17000260 RID: 608
		// (get) Token: 0x060008D5 RID: 2261 RVA: 0x000048D7 File Offset: 0x00002AD7
		[global::Cpp2ILInjected.Token(Token = "0x17000286")]
		internal override FacetsChecker FacetsChecker
		{
			[global::Cpp2ILInjected.Token(Token = "0x600096A")]
			[global::Cpp2ILInjected.Address(RVA = "0x1DC2EDC", Offset = "0x1DC2EDC", Length = "0x58")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000261 RID: 609
		// (get) Token: 0x060008D6 RID: 2262 RVA: 0x000048DA File Offset: 0x00002ADA
		[global::Cpp2ILInjected.Token(Token = "0x17000287")]
		public override XmlTypeCode TypeCode
		{
			[global::Cpp2ILInjected.Token(Token = "0x600096B")]
			[global::Cpp2ILInjected.Address(RVA = "0x1DC2F34", Offset = "0x1DC2F34", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x060008D7 RID: 2263 RVA: 0x000048DD File Offset: 0x00002ADD
		[global::Cpp2ILInjected.Token(Token = "0x600096C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DC2F3C", Offset = "0x1DC2F3C", Length = "0x8C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(int), Member = "CompareTo", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		internal override int Compare(object value1, object value2)
		{
			throw null;
		}

		// Token: 0x17000262 RID: 610
		// (get) Token: 0x060008D8 RID: 2264 RVA: 0x000048E0 File Offset: 0x00002AE0
		[global::Cpp2ILInjected.Token(Token = "0x17000288")]
		public override Type ValueType
		{
			[global::Cpp2ILInjected.Token(Token = "0x600096D")]
			[global::Cpp2ILInjected.Address(RVA = "0x1DC2FC8", Offset = "0x1DC2FC8", Length = "0x58")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000263 RID: 611
		// (get) Token: 0x060008D9 RID: 2265 RVA: 0x000048E3 File Offset: 0x00002AE3
		[global::Cpp2ILInjected.Token(Token = "0x17000289")]
		internal override Type ListValueType
		{
			[global::Cpp2ILInjected.Token(Token = "0x600096E")]
			[global::Cpp2ILInjected.Address(RVA = "0x1DC3020", Offset = "0x1DC3020", Length = "0x58")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		// Token: 0x060008DA RID: 2266 RVA: 0x000048E6 File Offset: 0x00002AE6
		[global::Cpp2ILInjected.Token(Token = "0x600096F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DC3078", Offset = "0x1DC3078", Length = "0x134")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlConvert), Member = "TryToInt32", MemberParameters = new object[]
		{
			typeof(string),
			typeof(ref int)
		}, ReturnType = typeof(Exception))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		internal override Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out object typedValue)
		{
			throw null;
		}

		// Token: 0x060008DB RID: 2267 RVA: 0x000048E9 File Offset: 0x00002AE9
		[global::Cpp2ILInjected.Token(Token = "0x6000970")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DC31AC", Offset = "0x1DC31AC", Length = "0x54")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DatatypeImplementation), Member = ".cctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Datatype_short), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Datatype_integer), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public Datatype_int()
		{
			throw null;
		}

		// Token: 0x060008DC RID: 2268 RVA: 0x000048EC File Offset: 0x00002AEC
		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x6000971")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DC3200", Offset = "0x1DC3200", Length = "0x160")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(RuntimeTypeHandle) }, ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(decimal), Member = ".ctor", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		static Datatype_int()
		{
			throw null;
		}

		// Token: 0x04000376 RID: 886
		[global::Cpp2ILInjected.Token(Token = "0x40004F0")]
		private static readonly Type atomicValueType;

		// Token: 0x04000377 RID: 887
		[global::Cpp2ILInjected.Token(Token = "0x40004F1")]
		private static readonly Type listValueType;

		// Token: 0x04000378 RID: 888
		[global::Cpp2ILInjected.Token(Token = "0x40004F2")]
		private static readonly FacetsChecker numeric10FacetsChecker;
	}
}
