using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Xml.Schema
{
	// Token: 0x020000E3 RID: 227
	[global::Cpp2ILInjected.Token(Token = "0x200010F")]
	internal class Datatype_byte : Datatype_short
	{
		// Token: 0x17000268 RID: 616
		// (get) Token: 0x060008E5 RID: 2277 RVA: 0x00004907 File Offset: 0x00002B07
		[global::Cpp2ILInjected.Token(Token = "0x1700028E")]
		internal override FacetsChecker FacetsChecker
		{
			[global::Cpp2ILInjected.Token(Token = "0x600097A")]
			[global::Cpp2ILInjected.Address(RVA = "0x1DC37E4", Offset = "0x1DC37E4", Length = "0x58")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000269 RID: 617
		// (get) Token: 0x060008E6 RID: 2278 RVA: 0x0000490A File Offset: 0x00002B0A
		[global::Cpp2ILInjected.Token(Token = "0x1700028F")]
		public override XmlTypeCode TypeCode
		{
			[global::Cpp2ILInjected.Token(Token = "0x600097B")]
			[global::Cpp2ILInjected.Address(RVA = "0x1DC383C", Offset = "0x1DC383C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x060008E7 RID: 2279 RVA: 0x0000490D File Offset: 0x00002B0D
		[global::Cpp2ILInjected.Token(Token = "0x600097C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DC3844", Offset = "0x1DC3844", Length = "0x8C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(sbyte), Member = "CompareTo", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		internal override int Compare(object value1, object value2)
		{
			throw null;
		}

		// Token: 0x1700026A RID: 618
		// (get) Token: 0x060008E8 RID: 2280 RVA: 0x00004910 File Offset: 0x00002B10
		[global::Cpp2ILInjected.Token(Token = "0x17000290")]
		public override Type ValueType
		{
			[global::Cpp2ILInjected.Token(Token = "0x600097D")]
			[global::Cpp2ILInjected.Address(RVA = "0x1DC38D0", Offset = "0x1DC38D0", Length = "0x58")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700026B RID: 619
		// (get) Token: 0x060008E9 RID: 2281 RVA: 0x00004913 File Offset: 0x00002B13
		[global::Cpp2ILInjected.Token(Token = "0x17000291")]
		internal override Type ListValueType
		{
			[global::Cpp2ILInjected.Token(Token = "0x600097E")]
			[global::Cpp2ILInjected.Address(RVA = "0x1DC3928", Offset = "0x1DC3928", Length = "0x58")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		// Token: 0x060008EA RID: 2282 RVA: 0x00004916 File Offset: 0x00002B16
		[global::Cpp2ILInjected.Token(Token = "0x600097F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DC3980", Offset = "0x1DC3980", Length = "0x134")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XmlConvert), Member = "TryToSByte", MemberParameters = new object[]
		{
			typeof(string),
			typeof(ref sbyte)
		}, ReturnType = typeof(Exception))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		internal override Exception TryParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr, out object typedValue)
		{
			throw null;
		}

		// Token: 0x060008EB RID: 2283 RVA: 0x00004919 File Offset: 0x00002B19
		[global::Cpp2ILInjected.Token(Token = "0x6000980")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DC3AB4", Offset = "0x1DC3AB4", Length = "0x54")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DatatypeImplementation), Member = ".cctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Datatype_short), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public Datatype_byte()
		{
			throw null;
		}

		// Token: 0x060008EC RID: 2284 RVA: 0x0000491C File Offset: 0x00002B1C
		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x6000981")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DC3B08", Offset = "0x1DC3B08", Length = "0x160")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(RuntimeTypeHandle) }, ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(decimal), Member = ".ctor", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		static Datatype_byte()
		{
			throw null;
		}

		// Token: 0x0400037C RID: 892
		[global::Cpp2ILInjected.Token(Token = "0x40004F6")]
		private static readonly Type atomicValueType;

		// Token: 0x0400037D RID: 893
		[global::Cpp2ILInjected.Token(Token = "0x40004F7")]
		private static readonly Type listValueType;

		// Token: 0x0400037E RID: 894
		[global::Cpp2ILInjected.Token(Token = "0x40004F8")]
		private static readonly FacetsChecker numeric10FacetsChecker;
	}
}
